using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace STRATZ.Converters;

public class MatchGroupByTypeConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return typeof(IMatchGroupByType).IsAssignableFrom(objectType);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        var jsonObject = JObject.Load(reader);
        var typeName = jsonObject["__typename"]?.Value<string>();

        IMatchGroupByType target = typeName switch
        {
            "MatchGroupByHeroType" => new MatchGroupByHeroType(),
            "MatchGroupByFactionType" => new MatchGroupByFactionType(),
            "MatchGroupByKillsType" => new MatchGroupByKillsType(),
            "MatchGroupByDeathsType" => new MatchGroupByDeathsType(),
            "MatchGroupByAssistsType" => new MatchGroupByAssistsType(),
            "MatchGroupByIsLeaverType" => new MatchGroupByIsLeaverType(),
            "MatchGroupByLevelType" => new MatchGroupByLevelType(),
            "MatchGroupByIsPartyType" => new MatchGroupByIsPartyType(),
            "MatchGroupByIsRandomType" => new MatchGroupByIsRandomType(),
            "MatchGroupByLaneType" => new MatchGroupByLaneType(),
            "MatchGroupByRoleType" => new MatchGroupByRoleType(),
            "MatchGroupByIsIntentionalFeedingType" => new MatchGroupByIsIntentionalFeedingType(),
            "MatchGroupByAwardType" => new MatchGroupByAwardType(),
            "MatchGroupByRoamLaneType" => new MatchGroupByRoamLaneType(),
            "MatchGroupByIsVictoryType" => new MatchGroupByIsVictoryType(),
            "MatchGroupByDurationMinutesType" => new MatchGroupByDurationMinutesType(),
            "MatchGroupByClusterType" => new MatchGroupByClusterType(),
            "MatchGroupByRegionType" => new MatchGroupByRegionType(),
            "MatchGroupByLobbyTypeType" => new MatchGroupByLobbyTypeType(),
            "MatchGroupByIsLeagueType" => new MatchGroupByIsLeagueType(),
            "MatchGroupByIsSeriesType" => new MatchGroupByIsSeriesType(),
            "MatchGroupByGameModeType" => new MatchGroupByGameModeType(),
            "MatchGroupByIsStatsType" => new MatchGroupByIsStatsType(),
            "MatchGroupByGameVersionType" => new MatchGroupByGameVersionType(),
            "MatchGroupByTeamType" => new MatchGroupByTeamType(),
            "MatchGroupByHeroPerformanceType" => new MatchGroupByHeroPerformanceType(),
            "MatchGroupBySteamAccountIdType" => new MatchGroupBySteamAccountIdType(),
            "MatchGroupBySteamAccountIdHeroIdType" => new MatchGroupBySteamAccountIdHeroIdType(),
            "MatchGroupBySteamAccountIdWithTeamType" => new MatchGroupBySteamAccountIdWithTeamType(),
            "MatchGroupBySteamAccountIdHeroIdWithTeamType" => new MatchGroupBySteamAccountIdHeroIdWithTeamType(),
            "MatchGroupBySteamAccountIdAgainstTeamType" => new MatchGroupBySteamAccountIdAgainstTeamType(),
            "MatchGroupBySteamAccountIdHeroIdAgainstTeamType" => new MatchGroupBySteamAccountIdHeroIdAgainstTeamType(),
            "MatchGroupByLeagueIdType" => new MatchGroupByLeagueIdType(),
            "MatchGroupByPositionType" => new MatchGroupByPositionType(),
            "MatchGroupByDateDayType" => new MatchGroupByDateDayType(),
            "MatchGroupByDateDayHeroType" => new MatchGroupByDateDayHeroType(),
            "MatchGroupByTotalKillsType" => new MatchGroupByTotalKillsType(),
            "MatchGroupByGoldPerMinuteType" => new MatchGroupByGoldPerMinuteType(),
            "MatchGroupByHourType" => new MatchGroupByHourType(),
            _ => throw CreateJsonReaderException(reader, $"Could not create an instance of type \"{objectType.FullName}\"")
        };

        serializer.Populate(jsonObject.CreateReader(), target);
        return target;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    private static JsonReaderException CreateJsonReaderException(JsonReader reader, string message)
    {
        if (reader is IJsonLineInfo lineInfo && lineInfo.HasLineInfo())
            return new JsonReaderException(message, reader.Path, lineInfo.LineNumber, lineInfo.LinePosition, null);

        return new JsonReaderException(message);
    }
}
