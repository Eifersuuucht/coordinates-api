using System.Collections.Immutable;

namespace CoordinatesApi.Core.Models.Rectangles;

public sealed record MatchResultModel(
    IImmutableList<SingleMatchResultModel> MatchResults);