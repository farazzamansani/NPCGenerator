namespace NPCGenerator.Server.Models
{
    public class WeightedFeature:Feature
    {
        /// <summary>
        /// Weight- Default 1, higher values make it more likely relative to others in the list.
        /// </summary>
        public double Weight { get; set; } = 1;
    }
    public class SexInfluencedFeature:Feature
    {
        //public string Value { get; set; }
        public double WeightFem { get; set; } = 1;

        public double WeightM { get; set; } = 1;
    }

    public abstract class Feature
    {
        public string Value { get; set; } = string.Empty;

    }
    public class SkinTone: WeightedFeature
    {
        public string Color { get; set; } = string.Empty;
        //Use this to sway hair/eye color because melanin.
        public int Darkness { get; set; }
    }
}
