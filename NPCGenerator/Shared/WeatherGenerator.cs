
using NPCGenerator.Shared.Extensions;

namespace NPCGenerator.Shared.Services
{
    public class WeatherGenerator
    {
        public string GenerateWeather()
        {
            return NPCGenerator.Shared.Data.WeatherData.Weather.ToList().RandomElementByWeight(e => e.Weight).Value;
        }
        
    }
}
