using NPCGenerator.Server.Data;
using NPCGenerator.Server.Extensions;
using NPCGenerator.Server.Models;

namespace NPCGenerator.Server.Services
{
    //Generic as possible NPCs not unique to any region or campaign.
    public class GenericGenerator : IGenerator
    {
        public string GenerateSex()
        {
            return NPCGenerator.Server.Data.FeatureData.Sex.ToList().RandomElementByWeight(e => e.Weight).Value;
        }

        public int GenerateAge()
        {
            double percentage = Random.Shared.NextDouble();

            if (percentage >= 0.3) // 1.0 - 0.3 = 70%
            {
                return Random.Shared.Next(20, 65);
            }
            else if (percentage >= 0.15) // 0.3 - 0.15 = 15%
            {
                return Random.Shared.Next(8, 20);
            }
            else // remaining 10%
            {
                return Random.Shared.Next(65, 100);
            }
        }

        public string GenerateFirstName(string sex)
        {
            if (sex.Contains("Female"))
                return FeatureData.FirstNamesFem[Random.Shared.Next(FeatureData.FirstNamesFem.Length)];
            else //Male
                return FeatureData.FirstNamesM[Random.Shared.Next(FeatureData.FirstNamesM.Length)];
        }

        public string GenerateLastName()
        {
            return FeatureData.LastNames[Random.Shared.Next(FeatureData.LastNames.Length)];
        }

        public string GenerateBodyFat()
        {
            return FeatureData.Weights[Random.Shared.Next(FeatureData.Weights.Length)];
        }

        public string GenerateHairStyle(string sex)
        {
            return FeatureData.HairStyles.ToList().RandomElementBySexWeight(sex).Value;
        }

        public string GenerateHairColor(int darkness)
        {
            var position = Random.Shared.Next(FeatureData.HairColours.Length);
            position = Math.Min(position + darkness, FeatureData.HairColours.Length-1);
            return FeatureData.HairColours[position];
        }
        public string GenerateEyeColor(int darkness)
        {
            var darknessBrownChance = Random.Shared.Next(8);
            if (darkness > darknessBrownChance)
            {
                return "Brown";
            }
            var position = Random.Shared.Next(FeatureData.EyeColours.Length);
            position = Math.Min(position + darkness, FeatureData.EyeColours.Length-1);
            return FeatureData.EyeColours[position].Value;
        }

        public string GenerateMusculature(string sex, int age, string bodyFat)
        {
            //Crop out the most fit options based on age and extreme low end of bodyFat
            var subtraction = 0;
            if (age > 50)
                subtraction += Random.Shared.Next(0, 1);
            if (age > 70)
                subtraction += Random.Shared.Next(0, 1);
            if (age > 90)
                subtraction += Random.Shared.Next(0, 1);
            if (bodyFat.Contains("skinny") || bodyFat.Contains("gaunt"))
                subtraction += Random.Shared.Next(0, 1);
            if (bodyFat.Contains("gaunt"))
                subtraction += Random.Shared.Next(1, 1);
            var length = FeatureData.Musculature.Length - subtraction;
            var contractedList = FeatureData.Musculature.ToList()
                .GetRange(0, length);
          
            return contractedList.RandomElementBySexWeight(sex).Value;

        }

        public string GenerateFacialHair(string sex, int age)
        {
            if (age < 10) //No facial hair on children
                return "None";
            if (age < 21 && sex.Contains("Female")) //No facial hair young women
                return "None";
            if (age >= 10 && age <= 22 && !sex.Contains("Female"))
                if (Random.Shared.Next(1, 2) == 1)
                    return "Teen Fluff"; //Teen guys have 50% chance fluff

            return FeatureData.FacialHair.ToList().RandomElementBySexWeight(sex).Value;

        }

        public string GenerateVoice(string sex)
        {
            return FeatureData.Voice.ToList().RandomElementBySexWeight(sex).Value;
        }

        public string GenerateFriendliness()
        {
            return FeatureData.Friendliness.ToList().RandomElementByWeight(e => e.Weight).Value;
        }

        public string GenerateCleanliness(string sex)
        {
            return FeatureData.Cleanliness.ToList().RandomElementBySexWeight(sex).Value;
        }

        public string GenerateInjury(string sex)
        {
            return FeatureData.Injuries.ToList().RandomElementBySexWeight(sex).Value;
        }

        public SkinTone GenerateSkinTone()
        {
            return FeatureData.SkinTones.ToList().RandomElementByWeight(e => e.Weight);
        }

        public string GenerateAurilAttitude()
        {
            return FeatureData.AurilAttitude[Random.Shared.Next(FeatureData.AurilAttitude.Length)];
        }
        public string GenerateWorship(string aurilAttitude)
        {
            if (aurilAttitude == "Reveres" || aurilAttitude == "Devout Worship")
                return "Auril";
            return FeatureData.Worships.ToList().RandomElementByWeight(w=>w.Weight).Value;
        }

        public string GenerateAttitudeToMagic()
        {
            return FeatureData.AttitudeToMagic.ToList().RandomElementByWeight(w=>w.Weight).Value;
        }

        public string GenerateQuirk(string sex)
        {
            return FeatureData.Quirks.ToList().RandomElementBySexWeight(sex).Value;
        }
        public string GenerateClothes()
        {
            return FeatureData.Clothes.ToList().RandomElementByWeight(w=>w.Weight).Value;
        }

        public string GenerateColdTolerance()
        {
            throw new NotImplementedException();
        }
    }
}
