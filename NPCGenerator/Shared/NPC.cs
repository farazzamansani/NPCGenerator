namespace NPCGenerator.Shared
{
  
    public class NPC
    {
        public NPC(double age, string sex, string? firstName, string? lastName, string? skinTone, string? hairColor, string? hairStyle, string? facialHair, string? coldTolerance, string? musculature, string bodyFat, string? aurilAttitude, string? voice, string? friendliness, string? clothes, string? attitudeToMagic, string? quirks, string? worship, string? cleanliness, string? injuries, string? eyeColor)
        {
            Age = age;
            Sex = sex;
            FirstName = firstName;
            LastName = lastName;
            SkinTone = skinTone;
            HairColor = hairColor;
            HairStyle = hairStyle;
            FacialHair = facialHair;
            ColdTolerance = coldTolerance;
            Musculature = musculature;
            BodyFat = bodyFat;
            AurilAttitude = aurilAttitude;
            Voice = voice;
            Friendliness = friendliness;
            Clothes = clothes;
            AttitudeToMagic = attitudeToMagic;
            Quirks = quirks;
            Worship = worship;
            Cleanliness = cleanliness;
            Injuries = injuries;
            EyeColor = eyeColor;
        }

        public double Age { get; set; }

        public string Sex { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? SkinTone { get; set; }

        public string? HairColor { get; set; }
        public string? HairStyle { get; set; }

        public string? FacialHair { get; set; }

        public string? ColdTolerance { get; set; }
        public string? Musculature { get; set; }
        public string BodyFat { get; set; }
        public string? AurilAttitude { get; set; }

        public string? Voice { get; set; }

        public string? Friendliness { get; set; }

        public string? Clothes { get; set; }

        public string? AttitudeToMagic { get; set; }

        public string? Quirks { get; set; }

        public string? Worship { get; set; }

        public string? Cleanliness { get; set; }

        public string? Injuries { get; set; }

        public string? EyeColor { get; set; }

    }

}