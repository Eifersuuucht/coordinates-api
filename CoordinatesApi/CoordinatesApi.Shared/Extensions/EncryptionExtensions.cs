using System.Text;
using System.Security.Cryptography;

namespace CoordinatesApi.Shared.Extensions;

public static class EncryptionExtensions
{
    public static string Encrypt(this string plainText, string key)
    {
        byte[] iv = new byte[16];
        byte[] array;

        using (Aes aes = Aes.Create())
        {
            aes.Key = AdjustKeySize(key, 32);
            aes.IV = iv;

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                    {
                        streamWriter.Write(plainText);
                    }

                    array = memoryStream.ToArray();
                }
            }
        }

        return Convert.ToBase64String(array);
    }

    public static string Decrypt(string key, string cipherText)
    {
        byte[] iv = new byte[16];
        byte[] buffer = Convert.FromBase64String(cipherText);

        using (Aes aes = Aes.Create())
        {
            aes.Key = AdjustKeySize(key, 32);
            aes.IV = iv;
            
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            using (MemoryStream memoryStream = new MemoryStream(buffer))
            {
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }
    }
    
    public static byte[] AdjustKeySize(string key, int size)
    {
        var keyBytes = Encoding.UTF8.GetBytes(key);
        if (keyBytes.Length == size)
        {
            return keyBytes;
        }

        var adjustedKey = new byte[size];
        if (keyBytes.Length > size)
        {
            Array.Copy(keyBytes, adjustedKey, size);
        }
        else
        {
            Array.Copy(keyBytes, adjustedKey, keyBytes.Length);
        }

        return adjustedKey;
    }
}