using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Web
{
    public class WebAPIConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            var formatters = config.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}