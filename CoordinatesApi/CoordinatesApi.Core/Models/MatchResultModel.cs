using System.Collections.Immutable;

namespace CoordinatesApi.Core.Models;

public sealed record MatchResultModel(
    IImmutableList<SingleMatchResultModel> MatchResults);