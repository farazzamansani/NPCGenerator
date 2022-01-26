using System.Runtime.CompilerServices;
using BlazorWebApp2.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebApp2.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NPCGeneratorController : ControllerBase
    {
        private static readonly string[] FirstNames = new[]
        {
        "Roy", "Tim", "Larry"
    };
        private static readonly string[] LastNames = new[]
        {
            "Underhill", "O'Dryden"
        };
        private static readonly string[] SkinTones = new[]
        {
            "Sickly Pale", "Pale", "Light", "Average", "Slightly Tan", "Tanned", "Darkish", "Dark", "Very Dark", "Almost Unnaturally Dark"
        };
        private static readonly string[] HairColours = new[]
        {
            "Light Ash Blonde",
            "Light Blonde",
            "Light Golden Blonde",
            "honey",
            "champagne",
            "butterscotch",
            "Beeline Honey",
            "Medium Champagne",
            "Butterscotch",
            "light cool brown",
            "light brown",
            "light golden brown",
            "Light Cool Brown",
            "Light Brown",
            "Light Golden Brown",
            "chart chocolate brown",
            "dark golden brown",
            "medium ash",
            "Chocolate Brown",
            "Dark Golden Brown",
            "Medium Ash Brown",
            "reddish blonde",
            "light auburn",
            "medium auburn",
            "Reddish Blonde",
            "Light Auburn",
            "Medium Auburn",
            "chart cinnamon",
            "chart jet black",
            "Red Hot Cinnamon",
            "Espresso",
            "Jet Black"
        };
        private static readonly string[] HairStyles = new[]
        {
            "Short, Neat", "Short Unkempt", "Shoulder Length Neat", "Shoulder Length Unkempt", "Mid Back Length Neat", "Mid Back Unkempt"
        };

        private static readonly string[] Weights = new[]
        {
            "Starved, gaunt and skinny", "Gaunt", "Skinny", "Thin", "Average", "Thick", "Stout", "Tubby", "Fat", "Very Fat", "Obese"
        };

        private static readonly string[] Musculature = new[]
        {
            "Sickly Muscle definition", "Low muscle Definition", "Average", "toned", "Good definition", "Visibly fit", "Strong Labourer Physique", "Ripped"
        };

        private static readonly string[] ColdTolerances = new[]
        {
            "Incredibly Struggles to leave the house", "Very Low", "Low", "Average", "Relatively Good", "Tolerant", "Very Tolerant"
        };

        private static readonly string[] AurilAttitude = new[]
        {
            "Hates", "Dislikes", "Fearful", "Disbeleives she caused Rhyme", "Reveres", "Devout Worship"
        };

        private readonly ILogger<NPCGeneratorController> _logger;

        private int _myCat = 0;

        public NPCGeneratorController(ILogger<NPCGeneratorController> logger, IMyDependency myDep)
        {
            _logger = logger;
            var dog = myDep.GetCat();
            _myCat = myDep.GetCat();

        }

        [HttpGet]
        public IEnumerable<NPC> Get()
        {
            var Generations = 5;
            var NPCs = new List<NPC>();


            for (int i = 0; i < Generations; i++)
            {
                var age = GenerateAge();
                var npc = new NPC()
                {
                    Age = age,
                    FirstName = FirstNames[Random.Shared.Next(FirstNames.Length)],
                    LastName = LastNames[Random.Shared.Next(LastNames.Length)],
                    SkinTone = SkinTones[Random.Shared.Next(SkinTones.Length)],
                    HairColor = HairColours[Random.Shared.Next(HairColours.Length)],
                    HairStyle = HairStyles[Random.Shared.Next(HairStyles.Length)],
                    ColdTolerance = ColdTolerances[Random.Shared.Next(ColdTolerances.Length)],
                    Musculature = Musculature[Random.Shared.Next(Musculature.Length)],
                    Weights = Weights[Random.Shared.Next(Weights.Length)],
                    AurilAttitude = AurilAttitude[Random.Shared.Next(AurilAttitude.Length)]
                };
                NPCs.Add(npc);
               
            }

            return NPCs.ToArray();

            return Enumerable.Range(1, 5).Select(index => new NPC
            {
                Age = (Random.Shared.Next(7, 99) + Random.Shared.Next(7, 99)) / 2,
                FirstName = FirstNames[Random.Shared.Next(FirstNames.Length)],
                LastName = LastNames[Random.Shared.Next(LastNames.Length)],
                SkinTone = SkinTones[Random.Shared.Next(SkinTones.Length)],
                HairColor = HairColours[Random.Shared.Next(HairColours.Length)],
                HairStyle = HairStyles[Random.Shared.Next(HairStyles.Length)],
            })
            .ToArray();
        }

        [HttpGet]
        [Route("single")]
        public NPC GetSingleNPC()
        {
            int a = 5;

            a.IsGreaterThan(6);

            Dely handler = DelegateMethodm8;
            var test = handler(1);
            passDelegate(handler);
            var c = _myCat;
            var age = GenerateAge();
            var npc = new NPC()
            {
                Age = age,
                FirstName = FirstNames[Random.Shared.Next(FirstNames.Length)],
                LastName = LastNames[Random.Shared.Next(LastNames.Length)],
                SkinTone = SkinTones[Random.Shared.Next(SkinTones.Length)],
                HairColor = HairColours[Random.Shared.Next(HairColours.Length)],
                HairStyle = HairStyles[Random.Shared.Next(HairStyles.Length)],
                ColdTolerance = ColdTolerances[Random.Shared.Next(ColdTolerances.Length)],
                Musculature = Musculature[Random.Shared.Next(Musculature.Length)],
                Weights = Weights[Random.Shared.Next(Weights.Length)],
                AurilAttitude = AurilAttitude[Random.Shared.Next(AurilAttitude.Length)]
            };
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

        public static bool passDelegate(Dely d)
        {
            if (d.Invoke(1) > 0)
            {
                return true;
            }

            return false;
        }
        private int GenerateAge()
        {
            double percentage = Random.Shared.NextDouble();

            if (percentage >= 0.3) // 1.0 - 0.3 = 70%
            {
                return Random.Shared.Next(20, 70);
            }
            else if (percentage >= 0.15) // 0.3 - 0.15 = 15%
            {
                return Random.Shared.Next(8, 20);
            }
            else // remaining 10%
            {
                return Random.Shared.Next(70, 100);
            }
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