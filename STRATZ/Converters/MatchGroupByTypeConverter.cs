using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace STRATZ.Converters
{
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

            IMatchGroupByType target;
            switch (typeName)
            {
                case "MatchGroupByHeroType":
                    target = new MatchGroupByHeroType();
                    break;
                case "MatchGroupByFactionType":
                    target = new MatchGroupByFactionType();
                    break;
                case "MatchGroupByKillsType":
                    target = new MatchGroupByKillsType();
                    break;
                case "MatchGroupByDeathsType":
                    target = new MatchGroupByDeathsType();
                    break;
                case "MatchGroupByAssistsType":
                    target = new MatchGroupByAssistsType();
                    break;
                case "MatchGroupByIsLeaverType":
                    target = new MatchGroupByIsLeaverType();
                    break;
                case "MatchGroupByLevelType":
                    target = new MatchGroupByLevelType();
                    break;
                case "MatchGroupByIsPartyType":
                    target = new MatchGroupByIsPartyType();
                    break;
                case "MatchGroupByIsRandomType":
                    target = new MatchGroupByIsRandomType();
                    break;
                case "MatchGroupByLaneType":
                    target = new MatchGroupByLaneType();
                    break;
                case "MatchGroupByRoleType":
                    target = new MatchGroupByRoleType();
                    break;
                case "MatchGroupByIsIntentionalFeedingType":
                    target = new MatchGroupByIsIntentionalFeedingType();
                    break;
                case "MatchGroupByAwardType":
                    target = new MatchGroupByAwardType();
                    break;
                case "MatchGroupByRoamLaneType":
                    target = new MatchGroupByRoamLaneType();
                    break;
                case "MatchGroupByIsVictoryType":
                    target = new MatchGroupByIsVictoryType();
                    break;
                case "MatchGroupByDurationMinutesType":
                    target = new MatchGroupByDurationMinutesType();
                    break;
                case "MatchGroupByClusterType":
                    target = new MatchGroupByClusterType();
                    break;
                case "MatchGroupByRegionType":
                    target = new MatchGroupByRegionType();
                    break;
                case "MatchGroupByLobbyTypeType":
                    target = new MatchGroupByLobbyTypeType();
                    break;
                case "MatchGroupByIsLeagueType":
                    target = new MatchGroupByIsLeagueType();
                    break;
                case "MatchGroupByIsSeriesType":
                    target = new MatchGroupByIsSeriesType();
                    break;
                case "MatchGroupByGameModeType":
                    target = new MatchGroupByGameModeType();
                    break;
                case "MatchGroupByIsStatsType":
                    target = new MatchGroupByIsStatsType();
                    break;
                case "MatchGroupByGameVersionType":
                    target = new MatchGroupByGameVersionType();
                    break;
                case "MatchGroupByTeamType":
                    target = new MatchGroupByTeamType();
                    break;
                case "MatchGroupByHeroPerformanceType":
                    target = new MatchGroupByHeroPerformanceType();
                    break;
                case "MatchGroupBySteamAccountIdType":
                    target = new MatchGroupBySteamAccountIdType();
                    break;
                case "MatchGroupBySteamAccountIdHeroIdType":
                    target = new MatchGroupBySteamAccountIdHeroIdType();
                    break;
                case "MatchGroupBySteamAccountIdWithTeamType":
                    target = new MatchGroupBySteamAccountIdWithTeamType();
                    break;
                case "MatchGroupBySteamAccountIdHeroIdWithTeamType":
                    target = new MatchGroupBySteamAccountIdHeroIdWithTeamType();
                    break;
                case "MatchGroupBySteamAccountIdAgainstTeamType":
                    target = new MatchGroupBySteamAccountIdAgainstTeamType();
                    break;
                case "MatchGroupBySteamAccountIdHeroIdAgainstTeamType":
                    target = new MatchGroupBySteamAccountIdHeroIdAgainstTeamType();
                    break;
                case "MatchGroupByLeagueIdType":
                    target = new MatchGroupByLeagueIdType();
                    break;
                case "MatchGroupByPositionType":
                    target = new MatchGroupByPositionType();
                    break;
                case "MatchGroupByDateDayType":
                    target = new MatchGroupByDateDayType();
                    break;
                case "MatchGroupByDateDayHeroType":
                    target = new MatchGroupByDateDayHeroType();
                    break;
                case "MatchGroupByTotalKillsType":
                    target = new MatchGroupByTotalKillsType();
                    break;
                case "MatchGroupByGoldPerMinuteType":
                    target = new MatchGroupByGoldPerMinuteType();
                    break;
                case "MatchGroupByHourType":
                    target = new MatchGroupByHourType();
                    break;
                default:
                    throw CreateJsonReaderException(reader,
                        $"Could not create an instance of type \"{objectType.FullName}\"");
            }

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
}
