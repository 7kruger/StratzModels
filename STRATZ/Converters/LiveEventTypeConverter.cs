using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace STRATZ.Converters
{
    public class LiveEventTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(ILiveEventType).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var typeName = jsonObject["__typename"]?.Value<string>();

            var type = typeof(ILiveEventType).Assembly
                .GetExportedTypes()
                .FirstOrDefault(t => t.GetInterfaces().Any(i => i == typeof(ILiveEventType)) && t.Name == typeName);

            if (type == null)
            {
                throw CreateJsonReaderException(reader, $"Could not create an instance of type \"{objectType.FullName}\"");
            }

            var target = Activator.CreateInstance(type);

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
