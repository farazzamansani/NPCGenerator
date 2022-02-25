using System.Reflection.Metadata;
using NPCGenerator.Server.Models;

namespace NPCGenerator.Server.Data
{

    public static class FeatureData
    {

        public static readonly WeightedFeature[] Sex = new[]
        {
            new WeightedFeature{ Weight = 48, Value = "Male"},
            new WeightedFeature{ Weight = 48, Value = "Female"},
            new WeightedFeature{ Weight = 1, Value = "Androgynous (Male)"},
            new WeightedFeature{ Weight = 1, Value = "Androgynous (Female)"},
        };
        public static readonly string[] FirstNamesM = new[]
        {
            "Roy", "Tim", "Larry", "Almear", "Alver", "Agnar", "Arnor", "Aesklen", "Rolfnir", "Beggi", "Bermoor","Bjorn", "Blainn", "Clemens","Dainn","Dufgall","Elgr","Farulf","Fili","Galm", "Galti","Hafr", "Hafual", "Hein", "Henrik","Lambert","Leifi","Mikel","Nefi","Oddi","Ranbjorn","Sigmarr", "Skorri"  
        };
        
        public static readonly string[] FirstNamesFem = new[]
        {
            "Josephine", "Lorelyn", "Aurelyn", "Joanne", "Alvi","Arna","Berghildr","Bessy","Briet","Dalla","Edna","Elena","Elisabet","Freyja","Geira","Helga","Helena","Hilda","Kristin","Sif","Signi","Sigrid","Tora","Yngrette"
        };

        public static readonly string[] LastNames = new[]
        {
            "None/Based on profession","Underhill", "O'Dryden", "Dolph", "Erling", "Eskildsen", "Frisk","Junge","Leif","Lorenzen", "Breiner","Hall","Horn","Hjorth","Kron","Bell"
        };

        public static readonly SkinTone[] SkinTones = new[]
        {
            new SkinTone { Weight=0.5, Darkness=0, Color="Sickly Pale", },
            new SkinTone { Weight=1.2, Darkness=0, Color="Pale",},
            new SkinTone { Weight=1.6, Darkness=0, Color="Light", },
            new SkinTone { Weight=1.2, Darkness=1, Color="Average", },
            new SkinTone { Weight=1, Darkness=2, Color="Slightly Tan",},
            new SkinTone { Weight=1, Darkness=3, Color="Tanned",},
            new SkinTone { Weight=1, Darkness=4, Color="Darkish", },
            new SkinTone { Weight=0.8, Darkness=5, Color="Dark",},
            new SkinTone { Weight=0.5, Darkness=6, Color="Very Dark",},
            new SkinTone { Weight=0.1, Darkness=7, Color="Almost Unnaturally Dark"},
        };

        //order from lightest to darkest then we can multiply or add to random number by skin darkness.
        public static readonly string[] HairColours = new[]
        {
            "ginger",
            "reddish blonde",
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
            "chocolate brown",
            "dark golden brown",
            "medium ash",
            "Chocolate Brown",
            "Dark Golden Brown",
            "Medium Ash Brown",
            "light auburn",
            "Medium Auburn",
            "cinnamon",
            "Red Hot Cinnamon",
            "Espresso",
            "Jet Black"
        };

        public static readonly WeightedFeature[] EyeColours = new[]
        {
            new WeightedFeature { Weight = 0.1, Value = "Gold" },
            new WeightedFeature { Weight = 0.2, Value = "Yellow" },
            new WeightedFeature { Weight = 0.7, Value = "Silver" },
            new WeightedFeature { Weight = 0.8, Value = "Grey" },
            new WeightedFeature { Weight = 0.6, Value = "Saphire Blue" },
            new WeightedFeature { Weight = 3, Value = "Blue" },
            new WeightedFeature { Weight = 0.8, Value = "Emerald Green" },
            new WeightedFeature { Weight = 3, Value = "Green" },
            new WeightedFeature { Weight = 4, Value = "Turqoise" },
            new WeightedFeature { Weight = 8, Value = "Greeny Brown" },
            new WeightedFeature { Weight = 10, Value = "Brown" },
            new WeightedFeature { Weight = 0.05, Value = "Black" },
            new WeightedFeature { Weight = 0.01, Value = "Red" },
        };

        public static readonly SexInfluencedFeature[] HairStyles = new[]
        {
           new SexInfluencedFeature{Value="Short, Neat", },
           new SexInfluencedFeature{Value="Short Unkempt",},
           new SexInfluencedFeature{Value="Shoulder Length Neat", },
           new SexInfluencedFeature{Value="Shoulder Length Unkempt", },
           new SexInfluencedFeature{Value="Mid Back Length Neat",WeightM = 0.1, WeightFem = 0.9},
           new SexInfluencedFeature{Value="Mid Back Unkempt", WeightM = 0.2, WeightFem = 0.8},
        };

        //consider separate neat/unkempt to a separate modifier so it can be more easily and separatly influenced
        public static readonly SexInfluencedFeature[] FacialHair = new[]
        {
            new SexInfluencedFeature{Value="None/Clean Shaven", WeightM = 1, WeightFem = 99.5},
            new SexInfluencedFeature{Value="Trace Fluff", WeightM = 1, WeightFem = 0.5},
            new SexInfluencedFeature{Value="Short, Neat", WeightFem = 0},
            new SexInfluencedFeature{Value="Short, Neat, Moustache", WeightFem = 0},
            new SexInfluencedFeature{Value="Short Unkempt",WeightFem = 0},
            new SexInfluencedFeature{Value="5ish Cm Neat", WeightFem = 0},
            new SexInfluencedFeature{Value="5ish Cm Unkempt", WeightFem = 0},
            new SexInfluencedFeature{Value="Long Neat",WeightM = 0.7, WeightFem = 0},
            new SexInfluencedFeature{Value="Big Scraggly", WeightM = 0.9, WeightFem = 0},
        };

        //may need to order this from healthiest to unhealthiest instead.
        //possibly add facts such as health, wealth etc then sort and apply math to favour one end.
        public static readonly string[] Weights = new[]
        {
            "Starved, gaunt and skinny", "Gaunt", "Skinny", "Thin", "Average", "Thick", "Stout", "Tubby", "Fat", "Very Fat",
            "Obese"
        };

        public static readonly SexInfluencedFeature[] Musculature = new[]
        {
            new SexInfluencedFeature{Value="Sickly Muscle definition", WeightFem = 0.6, WeightM = 0.6},
            new SexInfluencedFeature{Value="Low muscle Definition", },
            new SexInfluencedFeature{Value="Average", },
            new SexInfluencedFeature{Value="toned",},
            new SexInfluencedFeature{Value="Good definition", },
            new SexInfluencedFeature{Value="Visibly fit",},
            new SexInfluencedFeature{Value="Strong Labourer Physique",WeightFem = 0.3},
            new SexInfluencedFeature{Value="Ripped", WeightFem = 0.1},
        };

        public static readonly SexInfluencedFeature[] Voice = new[]
        {
            new SexInfluencedFeature{Value="Very quiet and Gentle", WeightFem = 0.9, WeightM = 0.1},
            new SexInfluencedFeature{Value="Gentle",WeightFem = 2, WeightM = 0.4 },
            new SexInfluencedFeature{Value="A Voice like Honey", WeightFem = 0.5, WeightM = 0.1 },
            new SexInfluencedFeature{Value="Unremarkable", WeightFem = 3, WeightM = 3},
            new SexInfluencedFeature{Value="Speaks mostly using simple words", WeightFem = 2, WeightM = 2},
            new SexInfluencedFeature{Value="Speaks as if well educated",WeightFem = 0.5, WeightM = 0.5},
            new SexInfluencedFeature{Value="Hearty Voice",WeightFem = 0.2, WeightM = 1},
            new SexInfluencedFeature{Value="Deep Voice",WeightFem = 0.1, WeightM = 0.9},
            new SexInfluencedFeature{Value="Very Gruff Voice", WeightFem = 0.08, WeightM = 0.7},
        };

        public static readonly string[] ColdTolerances = new[]
        {
            "Incredibly Struggles to leave the house", "Very Low", "Low", "Average", "Relatively Good", "Tolerant",
            "Very Tolerant"
        };

        public static readonly string[] AurilAttitude = new[]
        {
            "Hates", "Dislikes", "Fearful", "Disbeleives she caused Rhyme", "Reveres", "Devout Worship"
        };

        public static readonly WeightedFeature[] Friendliness = new[]
        {
            new WeightedFeature{ Weight = 0.05, Value = "Suspiciously/Overly Friendly"},
            new WeightedFeature{ Weight = 0.8, Value = "Very Friendly"},
            new WeightedFeature{ Weight = 1, Value = "Friendly"},
            new WeightedFeature{ Weight = 1, Value = "Average"},
            new WeightedFeature{ Weight = 1, Value = "Unfriendly"},
            new WeightedFeature{ Weight = 1, Value = "Unfriendly and Suspicious of strangers"},
            new WeightedFeature{ Weight = 1, Value = "Mean"},
            new WeightedFeature{ Weight = 0.1, Value = "Pretends to be Friendly"},
        };

        public static readonly WeightedFeature[] AttitudeToMagic = new[]
        {
            new WeightedFeature{ Weight = 1, Value = "Fearful and Ignorant"},
            new WeightedFeature{ Weight = 1, Value = "Seen before, Fearful"},
            new WeightedFeature{ Weight = 1, Value = "Never seen,Fearful"},
            new WeightedFeature{ Weight = 1, Value = "Untrusting"},
            new WeightedFeature{ Weight = 1, Value = "Divine magic is pure, anything else is wrong"},
            new WeightedFeature{ Weight = 1, Value = "likes Divine"},
            new WeightedFeature{ Weight = 3, Value = "Never seen it, no strong feelings"},
            new WeightedFeature{ Weight = 8, Value = "Never seen it, fascinated"},
            new WeightedFeature{ Weight = 1, Value = "Wishes they were magic"},
            new WeightedFeature{ Weight = 1, Value = "Loves magic"},
        };


        public static readonly WeightedFeature[] Worships = new[]
        {
            new WeightedFeature{ Weight = 1, Value = "Auril"},
            new WeightedFeature{ Weight = 0.1, Value = "Asmodeus"},
            new WeightedFeature{ Weight = 0.001, Value = "Mephistopheles"},
            new WeightedFeature{ Weight = 0.001, Value = "Baalzebul"},
            new WeightedFeature{ Weight = 0.001, Value = "Glasya"},
            new WeightedFeature{ Weight = 1, Value = "Levistus"},
            new WeightedFeature{ Weight = 0.001, Value = "Belial"},
            new WeightedFeature{ Weight = 0.001, Value = "Mammon"},
            new WeightedFeature{ Weight = 0.001, Value = "Dispater"},
            new WeightedFeature{ Weight = 0.001, Value = "Bel"},
            new WeightedFeature{ Weight = 1.5, Value = "Lathander"},
            new WeightedFeature{ Weight = 4, Value = "Amaunator"},
            new WeightedFeature{ Weight = 0.6, Value = "Torm"},
            new WeightedFeature{ Weight = 0.001, Value = "Azuth"},
            new WeightedFeature{ Weight = 0.001, Value = "Bane"},
            new WeightedFeature{ Weight = 0.006, Value = "Beshaba"},
            new WeightedFeature{ Weight = 0.001, Value = "Bhaal"},
            new WeightedFeature{ Weight = 0.7, Value = "Chauntea"},
            new WeightedFeature{ Weight = 0.001, Value = "Cyric"},
            new WeightedFeature{ Weight = 0.001, Value = "Deneir"},
            new WeightedFeature{ Weight = 0.001, Value = "Eldath"},
            new WeightedFeature{ Weight = 0.01, Value = "Gond"},
            new WeightedFeature{ Weight = 0.1, Value = "Helm"},
            new WeightedFeature{ Weight = 0.1, Value = "Ilmater"},
            new WeightedFeature{ Weight = 0.01, Value = "Kelemvor"},
            new WeightedFeature{ Weight = 0.001, Value = "Leira"},
            new WeightedFeature{ Weight = 0.01, Value = "Lliira"},
            new WeightedFeature{ Weight = 0.001, Value = "Loviatar"},
            new WeightedFeature{ Weight = 0.07, Value = "Malar"},
            new WeightedFeature{ Weight = 0.01, Value = "Mask"},
            new WeightedFeature{ Weight = 0.008, Value = "Mielikki"},
            new WeightedFeature{ Weight = 0.001, Value = "Myrkul"},
            new WeightedFeature{ Weight = 0.001, Value = "Mystra"},
            new WeightedFeature{ Weight = 0.001, Value = "Oghma"},
            new WeightedFeature{ Weight = 0.1, Value = "Selune"},
            new WeightedFeature{ Weight = 0.006, Value = "Shar"},
            new WeightedFeature{ Weight = 0.1, Value = "Silvanus"},
            new WeightedFeature{ Weight = 0.01, Value = "Sune"},
            new WeightedFeature{ Weight = 0.001, Value = "Talona"},
            new WeightedFeature{ Weight = 0.008, Value = "Talos"},
            new WeightedFeature{ Weight = 0.001, Value = "Tempus"},
            new WeightedFeature{ Weight = 0.1, Value = "Tymora"},
            new WeightedFeature{ Weight = 0.001, Value = "Tyr"},
            new WeightedFeature{ Weight = 0.01, Value = "Umberlee"},
            new WeightedFeature{ Weight = 0.01, Value = "Waukeen"},
            new WeightedFeature{ Weight = 0.1, Value = "No specific worship"},
            new WeightedFeature{ Weight = 0.7, Value = "Hates the Gods"},
            new WeightedFeature{ Weight = 6, Value = "Worships many based on current needs"},
            new WeightedFeature{ Weight = 0.7, Value = "Gods aren't real"},
        };

        public static readonly SexInfluencedFeature[] Cleanliness = new[]
        {
            new SexInfluencedFeature{Value="Filthy and Rancid, doubt they ever bath", WeightFem = 0.05, WeightM = 0.1},
            new SexInfluencedFeature{Value="Filthy years without bathing", WeightFem = 0.06, WeightM = 0.15},
            new SexInfluencedFeature{Value="Gross, Probably 6 months unwashed", WeightFem = 0.9, WeightM = 1.6},
            new SexInfluencedFeature{Value="Pretty Dirty", WeightFem = 2, WeightM = 2},
            new SexInfluencedFeature{Value="Close inspection, not very clean", WeightFem = 2, WeightM = 2},
            new SexInfluencedFeature{Value="Fairly Average", WeightFem = 2, WeightM = 2},
            new SexInfluencedFeature{Value="Cleaner than most", WeightFem = 1, WeightM = 1},
            new SexInfluencedFeature{Value="Well Bathed", WeightFem = 0.08, WeightM = 0.05},
            new SexInfluencedFeature{Value="Immaculate", WeightFem = 0.06, WeightM = 0.05},
            new SexInfluencedFeature{Value="Immaculate and Beautifully Scented", WeightFem = 0.1, WeightM = 0.05},
        };

        //These probably need to be combined with a cause, and possibly quantity
        //probably need a severity to match to realistic causes
        //attacks: Greydwarf,dragon, undead, gnoll, goblin, auril, coldlightwalker,mephit,polarbear,
        public static readonly SexInfluencedFeature[] Injuries = new[]
        {
            new SexInfluencedFeature{Value="None", WeightFem = 50, WeightM = 50},
            new SexInfluencedFeature{Value="Missing a tooth", WeightFem = 10, WeightM = 10},
            new SexInfluencedFeature{Value="Mild Gingivitis", WeightFem = 10, WeightM = 10},
            new SexInfluencedFeature{Value="Extreme Gingivitis", WeightFem = 5, WeightM = 5},
            new SexInfluencedFeature{Value="Missing a finger", WeightFem = 10, WeightM = 10},
            new SexInfluencedFeature{Value="Missing several fingers", WeightFem = 7, WeightM = 7},
            new SexInfluencedFeature{Value="Missing a hand", WeightFem = 2, WeightM = 2},
            new SexInfluencedFeature{Value="Missing both hands", WeightFem = 1, WeightM = 1},
            new SexInfluencedFeature{Value="Prosthetic Foot", WeightFem = 1, WeightM = 1},
            new SexInfluencedFeature{Value="Missing most of a leg", WeightFem = 1, WeightM = 1},
            new SexInfluencedFeature{Value="Missing a leg", WeightFem = 1, WeightM = 1},
            new SexInfluencedFeature{Value="Missing both legs", WeightFem = 0.4, WeightM = 0.4},
            new SexInfluencedFeature{Value="Missing an arm", WeightFem = 1, WeightM = 1},
            new SexInfluencedFeature{Value="Missing both arms", WeightFem = 0.2, WeightM = 0.2},
            new SexInfluencedFeature{Value="Small Burn on the left side of the face", WeightFem = 1, WeightM = 1},
            new SexInfluencedFeature{Value="Major burns on face and body", WeightFem = 1, WeightM = 1},
            new SexInfluencedFeature{Value="Tip of nose severed", WeightFem = 6, WeightM = 6},
            new SexInfluencedFeature{Value="Frostbite damage to nose", WeightFem = 18, WeightM = 18},
            new SexInfluencedFeature{Value="Frostbitten fingers", WeightFem = 20, WeightM = 20},
            new SexInfluencedFeature{Value="Blind in 1 eye", WeightFem = 5, WeightM = 5},
            new SexInfluencedFeature{Value="Blind both eyes", WeightFem = 0.1, WeightM = 0.1},
            new SexInfluencedFeature{Value="Severed Ear", WeightFem = 3, WeightM = 3},
            new SexInfluencedFeature{Value="Skin Disease on face", WeightFem = 1, WeightM = 1},
            new SexInfluencedFeature{Value="Smoke Damaged Lungs", WeightFem = 1, WeightM = 1},

        };

        public static readonly SexInfluencedFeature[] Quirks = new[]
        {
            new SexInfluencedFeature{WeightFem = 5, WeightM = 5, Value="No Quirks"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Mind of a Child"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Nail Biter"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Left Eye Twitches"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Right Eye Twitches"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Fondles Ring Constantly"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Regularly Thinks out loud"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Constantly Itching (flees)"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Refuses to Acknowledge Constant Itching"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Alcoholic"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Drug Addict(mushrooms,foreign drugs)"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Constantly Lies"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Spits a lot"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Hard of Hearing"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Constantly sniffing fingers"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Sever Acne"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Smokes Pipe"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Constant Swearing"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Flirty"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Bull Eyed"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Very Nervous"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Always Positive"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Always Negative"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Obsessed with Partner"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Obsessed with uninterested love interest"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Bad Actor constantly rehearsing"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Excessive Lip Licking"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Regularly has a Cold"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Very Judgmental"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Shopperholic"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Greedy"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Selfish"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Insatiable Carnal Desires"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Racist"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Always Obeys the Law"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Violent"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Hates Poor People"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Hates Rich People"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Loves Animals"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Cruel to Animals"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Easily Amused"},
            new SexInfluencedFeature{WeightFem = 1, WeightM = 1, Value="Haunted by a loved one"},
        };

        public static readonly WeightedFeature[] Clothes = new[]
        {
            new WeightedFeature{ Weight = 1, Value = "Poor haphazard rags"},
            new WeightedFeature{ Weight = 1, Value = "Lot of Animal Hides"},
            new WeightedFeature{ Weight = 1, Value = "Fine Clothes"},
            new WeightedFeature{ Weight = 1, Value = "Very Fluffy Furs"},
        };
    }
}
