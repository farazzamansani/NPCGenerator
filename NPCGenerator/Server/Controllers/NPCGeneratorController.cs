using Microsoft.AspNetCore.Connections.Features;
using NPCGenerator.Server.Data;
using NPCGenerator.Shared;
using Microsoft.AspNetCore.Mvc;
using NPCGenerator.Server.Services;

namespace NPCGenerator.Server.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class NPCGeneratorController : ControllerBase
    {
       

        private readonly ILogger<NPCGeneratorController> _logger;
        private readonly IGenerator _generator;
        private int _myCat = 0;
        
        public NPCGeneratorController(ILogger<NPCGeneratorController> logger, IMyDependency myDep, IGenerator generator)
        {
            _logger = logger;
            _generator = generator;
        }

        private NPC GenerateNPC(string? sexS)
        {
            var age = _generator.GenerateAge();
            var sex = sexS??_generator.GenerateSex();
            var bodyFat = _generator.GenerateBodyFat();
            var skinToneObj = _generator.GenerateSkinTone();
            var skinTone = skinToneObj.Color;
            var aurilAttitude = _generator.GenerateAurilAttitude();
            return new NPC(age: age, sex: sex, firstName: _generator.GenerateFirstName(sex),
                lastName: _generator.GenerateLastName(), skinTone: skinTone,
                hairColor: _generator.GenerateHairColor(skinToneObj.Darkness),
                hairStyle: _generator.GenerateHairStyle(sex), facialHair: _generator.GenerateFacialHair(sex, age),
                coldTolerance: _generator.GenerateColdTolerance(),
                musculature: _generator.GenerateMusculature(sex, age, bodyFat), bodyFat: bodyFat,
                aurilAttitude: _generator.GenerateAurilAttitude(),
                voice: _generator.GenerateVoice(sex), friendliness: _generator.GenerateFriendliness(),
                clothes: _generator.GenerateClothes(), attitudeToMagic: _generator.GenerateAttitudeToMagic(),
                quirks: _generator.GenerateQuirk(sex), worship: _generator.GenerateWorship(aurilAttitude),
                cleanliness: _generator.GenerateCleanliness(sex), injuries: _generator.GenerateInjury(sex),
                eyeColor: _generator.GenerateEyeColor(skinToneObj.Darkness));
        }

        [HttpGet]
        public IEnumerable<NPC> Get()
        {
            var Generations = 5;
            var NPCs = new List<NPC>();

            for (int i = 0; i < Generations; i++)
            {
                var npc = GenerateNPC(null);
                NPCs.Add(npc);
            }

            return NPCs.ToArray();
        }

        [HttpGet("single")]
        public NPC GetSingleNPC()
       {
           return GenerateNPC(null);
        }

        [HttpPost("singleSpecific")]
        [Produces("application/json")]
        public NPC GetSingleNPC(NPCRequest sex)
        {
            _logger.LogInformation("GetSingleNPC");
            return GenerateNPC(sex.Sex);
        }

        private void Testing()
        {
            int a = 5;
            a.IsGreaterThan(6);
            Dely handler = DelegateMethodm8;
            var test = handler(1);
            PassDelegate(handler);
            var c = _myCat;
        }


        [HttpPost("rerollAttribute/{PropertyName}")]
        [Produces("application/json")]
        public NPC GetSingleNPCPost(NPCAttributes.Attribute PropertyName, NPC npc)
        {
            var darkness = FeatureData.SkinTones.First(st => st.Color == npc.SkinTone).Darkness;
            switch (PropertyName)
            {
                case NPCAttributes.Attribute.SkinTone:
                    npc.SkinTone = _generator.GenerateSkinTone().Color;
                    break;
                case NPCAttributes.Attribute.Musculature:
                    npc.Musculature = _generator.GenerateMusculature(npc.Sex, (int)npc.Age, npc.BodyFat);
                    break;
                case NPCAttributes.Attribute.Voice:
                    npc.Voice = _generator.GenerateVoice(npc.Sex);
                    break;
                case NPCAttributes.Attribute.FirstName:
                    npc.FirstName = _generator.GenerateFirstName(npc.Sex);
                    break;
                 case NPCAttributes.Attribute.BodyFat:
                    npc.BodyFat = _generator.GenerateBodyFat();
                    break;
                case NPCAttributes.Attribute.HairColor:
                    npc.HairColor = _generator.GenerateHairColor(darkness);
                    break;
                case NPCAttributes.Attribute.EyeColor:
                    npc.EyeColor = _generator.GenerateEyeColor(darkness);
                    break;
                case NPCAttributes.Attribute.FacialHair:
                    npc.FacialHair = _generator.GenerateFacialHair(npc.Sex,(int)npc.Age);
                    break;
                case NPCAttributes.Attribute.HairStyle:
                    npc.HairStyle = _generator.GenerateHairStyle(npc.Sex);
                    break;
                case NPCAttributes.Attribute.AurilAttitude:
                    npc.AurilAttitude= _generator.GenerateAurilAttitude();
                    break;
                case NPCAttributes.Attribute.Worship:
                    npc.Worship = _generator.GenerateWorship(npc.AurilAttitude);
                    break;
                case NPCAttributes.Attribute.Cleanliness:
                    npc.Cleanliness = _generator.GenerateCleanliness(npc.Sex);
                    break;
                case NPCAttributes.Attribute.Injuries:
                    npc.Injuries = _generator.GenerateInjury(npc.Sex);
                    break;
                case NPCAttributes.Attribute.Friendliness:
                    npc.Friendliness = _generator.GenerateFriendliness();
                    break;
                case NPCAttributes.Attribute.AttitudeToMagic:
                    npc.AttitudeToMagic = _generator.GenerateAttitudeToMagic();
                    break;
                case NPCAttributes.Attribute.Quirks:
                    npc.Quirks = _generator.GenerateQuirk(npc.Sex);
                    break;
                case NPCAttributes.Attribute.Clothes:
                    npc.Clothes = _generator.GenerateClothes();
                    break;
                case NPCAttributes.Attribute.ColdTolerance:
                    npc.ColdTolerance = _generator.GenerateColdTolerance();
                    break;
                default:
                    return UpdateNPCWithReflection(PropertyName.ToString(), npc);
            }
    
            return npc;
        }

        private NPC UpdateNPCWithReflection(string PropertyName, NPC npc)
        {
            var propertyToUpdate = npc.GetType().GetProperty(PropertyName);
            var method = _generator.GetType().GetMethod($"Generate{PropertyName}");
            if (method != null)
            {
                var value = method.Invoke(_generator, null);
                if (propertyToUpdate != null) propertyToUpdate.SetValue(npc, value);
            }

            return npc;
        }

      
        //[HttpGet]
        //[Route("single/{minAge}")]
        //public NPC GetSingleNPC(int minAge)
        //{
        //    var age = GenerateAge();
        //    var npc = new NPC()
        //    {
        //        Age = age,
        //        FirstName = FirstNames[Random.Shared.Next(FirstNames.Length)],
        //        LastName = LastNames[Random.Shared.Next(LastNames.Length)],
        //        SkinTone = SkinTones[Random.Shared.Next(SkinTones.Length)],
        //        HairColor = HairColours[Random.Shared.Next(HairColours.Length)],
        //        HairStyle = HairStyles[Random.Shared.Next(HairStyles.Length)],
        //        ColdTolerance = "",
        //    };
        //    return npc;
        //}

        public delegate int Dely(int var);
        private int DelegateMethodm8(int var)
        {
            _myCat = 9;
            return 5+var;
        }

        public static bool PassDelegate(Dely d)
        {
            if (d.Invoke(1) > 0)
            {
                return true;
            }

            return false;
        }

    }

    public static class IntExtensionsTest
    {
        public static bool IsGreaterThan(this int i, int valueToCheck)
        {
            if (valueToCheck > i)
                return true;
            return false;
        }
    }

  
}