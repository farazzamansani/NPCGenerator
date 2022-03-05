using NPCGenerator.Server.Models;

namespace NPCGenerator.Server.Services
{
    public interface IGenerator
    {
        public string GenerateSex();

        public int GenerateAge();
        public string GenerateFirstName(string sex);
        public string GenerateLastName();
        public string GenerateHairStyle(string sex);
        public string GenerateBodyFat();
        public string GenerateMusculature(string sex, int age, string bodyFat);

        public string GenerateFacialHair(string sex, int age);

        public string GenerateVoice(string sex);

        public string GenerateFriendliness();

        public string GenerateCleanliness(string sex);

        public string GenerateInjury(string sex);

        public SkinTone GenerateSkinTone();

        public string GenerateHairColor(int darkness);

        public string GenerateEyeColor(int darkness);

        public string GenerateAurilAttitude();

        public string GenerateWorship(string aurilAttitude);

        public string GenerateAttitudeToMagic();

        public string GenerateQuirk(string sex);

        public string GenerateClothes();

        public string GenerateColdTolerance();

    }
}
