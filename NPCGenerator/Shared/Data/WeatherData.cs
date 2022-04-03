using System.Reflection.Metadata;
using NPCGenerator.Shared.Models;

namespace NPCGenerator.Shared.Data
{

    public static class WeatherData
    {

        public static readonly WeightedFeature[] Weather = new[]
        {
            new WeightedFeature{ Weight = 1, Value = "<b>Ray of Hope</b> <br> Players receive 10 Temp Hp"},
            new WeightedFeature{ Weight = 5, Value = "<b>Clear Sky</b> <br> No Issues"},
            new WeightedFeature{ Weight = 6, Value = "<b>Light Snow</b>  <br>Vision reduced to 100 feet"},
            new WeightedFeature{ Weight = 3, Value = "<b>Heavy Snow</b>  <br>Vision reduced to 60 feet,</br> Disadvantage on perception checks, </br>+20% Cold Damage,<br> Travel 1/2 speed"},
            new WeightedFeature{ Weight = 2, Value = "<b>Frigid Wind</b> <br> Disadvantage ranged projectile attacks, <br> Travel 3/4 speed, <br> Flying by non magical means is impossible, <br>Hearing reduced to 100 feet, <br>Open flames immediately extinguish"},
            new WeightedFeature{ Weight = 2, Value = "<b>Dense Fog</b> <br> Vision is reduced to 30 feet, <br>Orientation checks are made at disadvantage, <br> Travel 3/4 speed"},
            new WeightedFeature{ Weight = 1, Value = "<b>Blizzardy and Stormy</b> <br> Vision is reduced to 30 feet, <br>Hearing reduced to 100 feet orientation checks are made at disadvantage, <br>Disadvantage ranged projectile attacks, <br> Flying by non magical means is impossible, <br> Open flames immediately extinguish, <br>Travel 1/2 speed,"},
        };
    }
}
