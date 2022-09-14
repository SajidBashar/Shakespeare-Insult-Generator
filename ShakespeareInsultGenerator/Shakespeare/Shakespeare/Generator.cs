using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shakespeare
{
    
    public partial class Generator : Form
    {
        //variables for accessing other forms as the user is interacting with the generator
        public static Dictionary DICTION = new Dictionary();
        public static Welcome MENU = new Welcome();


        public Generator()
        {
            InitializeComponent();
        }

        //Creates an array for 51 different adjectives
        public string[] Column0 =
        {
            "artless",
            "bawdy",
            "beslubbering",
            "bootless",
            "churlish",
            "cullionly",
            "cockered",
            "clouted",
            "craven",
            "currish",
            "dankish",
            "dissembling",
            "droning",
            "errant",
            "fawning",
            "fobbing",          
            "froward",         
            "frothy",              
            "gleeking",         
            "goatish",            
            "gorbellied",          
            "impertinent",       
            "infectious",         
            "jarring",      
            "loggerheaded",       
            "lumpish",            
            "mammering",           
            "mangled",            
            "mewling",            
            "paunchy",            
            "pribbling",          
            "puking",             
            "puny",                
            "qualling",
            "rank",           
            "reeky",               
            "roguish",             
            "ruttish",            
            "saucy",               
            "spleeny",            
            "spongy",              
            "surly",               
            "tottering",       
            "unmuzzled",           
            "vain",               
            "venomed",             
            "villainous",          
            "warped",              
            "wayward",             
            "weedy",               
            "yeasty",              
        };

        //Creates an array for 51 different adjectives 
        public string[] Column1 =
        {
            "base-court",
            "bat-fowling",
            "beef-witted",
            "beetle-headed",
            "boil-brained",
            "clapper-clawed",
            "clay-brained",
            "common-kissing",
            "crook-pated",
            "dismal-dreaming",
            "dizzy-eyed",
            "doghearted",
            "dread-bolted",
            "earth-vexing",
            "elf-skinned",
            "fat-kidneyed",
            "fen-sucking",
            "flap-mouthed",
            "fly-bitten",
            "folly-fallen",
            "fool-born",
            "full-gorged",
            "guts-griping",
            "half-faced",
            "hasty-witted",
            "hedge-born",
            "hell-hated",
            "idle-headed",
            "ill-breeding",
            "ill-nurtured",
            "knotty-pated",
            "milk-livered",
            "motley-minded",
            "malmsey-nosed",
            "onion-eyed",
            "plume-plucked",
            "pottle-deep",
            "pox-marked",
            "reeling-ripe",
            "rough-hewn",
            "rude-growing",
            "rump-fed",
            "shard-borne",
            "sheep-biting",
            "spur-galled",
            "swag-bellied",
            "tardy-gaited",
            "tickle-brained",
            "toad-spotted",
            "urchin-snouted",
            "weather-bitten",

        };

        //Creates an array for 49 different nouns
        public string[] Column2 =
        {

            "apple-john",
            "baggage",
            "barnacle",
            "bladder",
            "boar-pig",
            "bugbear",
            "bum-bailey",
            "canker-blossom",
            "clack-dish",
            "clotpole",
            "coxcomb",
            "codpiece",
            "death-token",
            "dewberry",
            "flap-dragon",
            "flax-wench",
            "flirt-gill",
            "foot-licker",
            "fustilarian",
            "giglet",
            "gudgeon",
            "haggard",
            "horn-beast",
            "hugger-mugger",
            "jolthead",
            "lewdster",
            "lout",
            "maggot-pie",
            "malt-worm",
            "mammet",
            "measle",
            "minnow",
            "miscreant",
            "moldwarp",
            "mumble-news",
            "nut-hook",
            "pigeon-egg",
            "popinjay",
            "pignut",
            "puttock",
            "pumpion",
            "ratsbane",
            "scut",
            "skainsmate",
            "strumpet",
            "varlot",
            "vassal",
            "whey-face",
            "wagtail",

        };

        //Generates a random sentence by getting the program to randomly pick a word from each array
        private void Generate_Click(object sender, EventArgs e)
        {
            //Converts arrays of each section to string
            String adj1 = Convert.ToString(Column0.RandomElement());
            String adj2 = Convert.ToString(Column1.RandomElement());
            String noun = Convert.ToString(Column2.RandomElement());

            //Forms a sentence with each random variable
            Randomsentence.Text = "Thou " +
                adj1 + ", " +
                adj2 + " " +
                noun + "!";

            //Variables to hold the translation of each insult 
            String adj1trans = "";
            String adj2trans = "";
            String nountrans = "";
            
            //Translation of first adjective in insult
            // If statements will match the insult and assign the translation variable with its actual translation
            if (adj1 == "artless")
            {
                adj1trans = "uncultured";
            }
            if (adj1 == "bawdy")
            {
                adj1trans = "filthy";
            }
            if(adj1 == "beslubbering")
            {
                adj1trans = "besmear";
            }
            if (adj1 == "bootless")
            {
                adj1trans = "useless";
            }
            if (adj1 == "cullionly")
            {
                adj1trans = "mean";
            }
            if (adj1 == "churlish")
            {
                adj1trans = "stingy";
            }
            if (adj1 == "cockered")
            {
                adj1trans = "pampering";
            }
            if (adj1 == "clouted")
            {
                adj1trans = "ragged";
            }
            if (adj1 == "craven")
            {
                adj1trans = "coward";
            }
            if (adj1 == "currish")
            {
                adj1trans = "snarling";
            }
            if (adj1 == "droning")
            {
                adj1trans = "bothersome";
            }
            if (adj1 == "dissembling")
            {
                adj1trans = "deceitful";
            }
            if (adj1 == "dankish")
            {
                adj1trans = "devious";
            }
            if (adj1 == "errant")
            {
                adj1trans = "wandering";
            }
            if (adj1 == "fawning")
            {
                adj1trans = "cheating";
            }
            if (adj1 == "fobbing")
            {
                adj1trans = "smooching";
            }
            if (adj1 == "froward")
            {
                adj1trans = "naughty";
            }
            if (adj1 == "frothy")
            {
                adj1trans = "weak";
            }
            if (adj1 == "gleeking")
            {
                adj1trans = "devious";
            }
            if (adj1 == "goatish")
            {
                adj1trans = "lecherous";
            }
            if (adj1 == "gorbellied")
            {
                adj1trans = "fat";
            }
            if (adj1 == "impertinent")
            {
                adj1trans = "insolate";
            }
            if (adj1 == "infectious")
            {
                adj1trans = "sick";
            }
            if (adj1 == "jarring")
            {
                adj1trans = "loud";
            }
            if (adj1 == "loggerheaded")
            {
                adj1trans = "stupid";
            }
            if (adj1 == "lumpish")
            {
                adj1trans = "lethargic";
            }
            if (adj1 == "mammering")
            {
                adj1trans = "hesitant";
            }
            if (adj1 == "mangled")
            {
                adj1trans = "disfigured";
            }
            if (adj1 == "mewling")
            {
                adj1trans = "whimpering";
            }
            if (adj1 == "paunchy")
            {
                adj1trans = "potbellied";
            }
            if (adj1 == "pribbling")
            {
                adj1trans = "nonsensical";
            }
            if (adj1 == "puking")
            {
                adj1trans = "vomiting";
            }
            if (adj1 == "puny")
            {
                adj1trans = "small";
            }
            if (adj1 == "qualling")
            {
                adj1trans = "squaring";
            }
            if (adj1 == "rank")
            {
                adj1trans = "disgusting";
            }
            if (adj1 == "reeky")
            {
                adj1trans = "foul";
            }
            if (adj1 == "roguish")
            {
                adj1trans = "deceitful";
            }
            if (adj1 == "ruttish")
            {
                adj1trans = "lustful";
            }
            if (adj1 == "qualling")
            {
                adj1trans = "squaring";
            }
            if (adj1 == "qualling")
            {
                adj1trans = "squaring";
            }
            if (adj1 == "saucy")
            {
                adj1trans = "troublemaking";
            }
            if (adj1 == "spleeny")
            {
                adj1trans = "irritable";
            }
            if (adj1 == "spongy")
            {
                adj1trans = "drunk";
            }
            if (adj1 == "surly")
            {
                adj1trans = "hostile";
            }
            if (adj1 == "tottering")
            {
                adj1trans = "crazy";
            }
            if (adj1 == "unmuzzled")
            {
                adj1trans = "stupid";
            }
            if (adj1 == "vain")
            {
                adj1trans = "conceited";
            }
            if (adj1 == "venomed")
            {
                adj1trans = "evil";
            }
            if (adj1 == "villainous")
            {
                adj1trans = "wicked";
            }
            if (adj1 == "warped")
            {
                adj1trans = "strange";
            }
            if (adj1 == "wayward")
            {
                adj1trans = "selfish";
            }
            if (adj1 == "weedy")
            {
                adj1trans = "weak";
            }
            if (adj1 == "yeasty")
            {
                adj1trans = "superficial";
            }

            //Translation of second adjective in insult
            if (adj2 == "base-court")
            {
                adj2trans = "bailey";
            }
            if (adj2 == "bat-fowling")
            {
                adj2trans = "blinding";
            }
            if (adj2 == "beef-witted")
            {
                adj2trans = "stupid";
            }
            if (adj2 == "beetle-headed")
            {
                adj2trans = "stupid";
            }
            if (adj2 == "boil-brained")
            {
                adj2trans = "dull";
            }
            if (adj2 == "clapper-clawed")
            {
                adj2trans = "clawed";
            }
            if (adj2 == "clay-brained")
            {
                adj2trans = "clumsy";
            }
            if (adj2 == "common-kissing")
            {
                adj2trans = "perverted";
            }
            if (adj2 == "crook-pated")
            {
                adj2trans = "robbing";
            }
            if (adj2 == "dismal-dreaming")
            {
                adj2trans = "miserable";
            }
            if (adj2 == "dizzy-eyed")
            {
                adj2trans = "blinded";
            }
            if (adj2 == "doghearted")
            {
                adj2trans = "inhumane";
            }
            if (adj2 == "dread-bolted")
            {
                adj2trans = "dreaded";
            }
            if (adj2 == "earth-vexing")
            {
                adj2trans = "annoying";
            }
            if (adj2 == "elf-skinned")
            {
                adj2trans = "smelly";
            }
            if (adj2 == "fat-kidneyed")
            {
                adj2trans = "gross";
            }
            if (adj2 == "fen-sucking")
            {
                adj2trans = "marshy";
            }
            if (adj2 == "flap-mouthed")
            {
                adj2trans = "broad-lipped";
            }
            if (adj2 == "fly-bitten")
            {
                adj2trans = "ugly";
            }
            if (adj2 == "folly-fallen")
            {
                adj2trans = "evil";
            }
            if (adj2 == "fool-born")
            {
                adj2trans = "idiotic";
            }
            if (adj2 == "full-gorged")
            {
                adj2trans = "fat";
            }
            if (adj2 == "guts-griping")
            {
                adj2trans = "bellyached";
            }
            if (adj2 == "half-faced")
            {
                adj2trans = "two-faced";
            }
            if (adj2 == "hasty-witted")
            {
                adj2trans = "rash";
            }
            if (adj2 == "hedge-born")
            {
                adj2trans = "lowly";
            }
            if (adj2 == "hell-hated")
            {
                adj2trans = "despised";
            }
            if (adj2 == "idle-headed")
            {
                adj2trans = "foolish";
            }
            if (adj2 == "ill-breeding")
            {
                adj2trans = "rude";
            }
            if (adj2 == "ill-breeding")
            {
                adj2trans = "ill-mannered";
            }
            if (adj2 == "ill-nurtured")
            {
                adj2trans = "sick";
            }
            if (adj2 == "knotty-pated")
            {
                adj2trans = "dull-witted";
            }
            if (adj2 == "milk-livered")
            {
                adj2trans = "cowardly";
            }
            if (adj2 == "motley-minded")
            {
                adj2trans = "foolish";
            }
            if (adj2 == "malmsey-nosed")
            {
                adj2trans = "red-nosed";
            }
            if (adj2 == "onion-eyed")
            {
                adj2trans = "sluggish";
            }
            if (adj2 == "plume-plucked")
            {
                adj2trans = "prideless";
            }
            if (adj2 == "pottle-deep")
            {
                adj2trans = "troubled";
            }
            if (adj2 == "pox-marked")
            {
                adj2trans = "ugly-looking";
            }
            if (adj2 == "reeling-ripe")
            {
                adj2trans = "drunkened";
            }
            if (adj2 == "rough-hewn")
            {
                adj2trans = "naive";
            }
            if (adj2 == "rude-growing")
            {
                adj2trans = "discourteous";
            }
            if (adj2 == "rump-fed")
            {
                adj2trans = "pampered";
            }
            if (adj2 == "shard-borne")
            {
                adj2trans = "impovershed";
            }
            if (adj2 == "sheep-biting")
            {
                adj2trans = "thieving";
            }
            if (adj2 == "spur-galled")
            {
                adj2trans = "injured";
            }
            if (adj2 == "swag-bellied")
            {
                adj2trans = "large-bellied";
            }
            if (adj2 == "tardy-gaited")
            {
                adj2trans = "slow-paced";
            }
            if (adj2 == "tickle-brained")
            {
                adj2trans = "intoxicated";
            }
            if (adj2 == "toad-spotted")
            {
                adj2trans = "foully-blemished";
            }
            if (adj2 == "urchin-snouted")
            {
                adj2trans = "grim";
            }
            if (adj2 == "weather-bitten")
            {
                adj2trans = "defaced";
            }

            //Translations of noun in insult
            if (noun == "apple-john")
            {
                nountrans = "shriveled apple";
            }
            if (noun == "baggage")
            {
                nountrans = "prostitute";
            }
            if (noun == "barnacle")
            {
                nountrans = "shellfish";
            }
            if (noun == "bladder")
            {
                nountrans = "bladder";
            }
            if (noun == "boar-pig")
            {
                nountrans = "swine";
            }
            if (noun == "bugbear")
            {
                nountrans = "mishap";
            }
            if (noun == "bum-bailey")
            {
                nountrans = "do-gooder";
            }
            if (noun == "canker-blossom")
            {
                nountrans = "slut";
            }
            if (noun == "clack-dish")
            {
                nountrans = "beggar";
            }
            if (noun == "clotpole")
            {
                nountrans = "idiot";
            }
            if (noun == "coxcomb")
            {
                nountrans = "dandy";
            }
            if (noun == "codpiece")
            {
                nountrans = "scrotum";
            }
            if (noun == "death-token")
            {
                nountrans = "corpse";
            }
            if (noun == "dewberry")
            {
                nountrans = "buffoon";
            }
            if (noun == "flap-dragon")
            {
                nountrans = "robber";
            }
            if (noun == "flax-wenched")
            {
                nountrans = "prostitute";
            }
            if (noun == "flirt-gill")
            {
                nountrans = "wanton";
            }
            if (noun == "foot-licker")
            {
                nountrans = "brown noser";
            }
            if (noun == "fustilarian")
            {
                nountrans = "scoundrel";
            }
            if (noun == "giglet")
            {
                nountrans = "whore";
            }
            if (noun == "gudgeon")
            {
                nountrans = "fish";
            }
            if (noun == "haggard")
            {
                nountrans = "witch";
            }
            if (noun == "horn-beast")
            {
                nountrans = "monster";
            }
            if (noun == "hugger-mugger")
            {
                nountrans = "liar";
            }
            if (noun == "jolthead")
            {
                nountrans = "imbecile";
            }
            if (noun == "lewdster")
            {
                nountrans = "lecher";
            }
            if (noun == "lout")
            {
                nountrans = "ruffian";
            }
            if (noun == "maggot-pie")
            {
                nountrans = "insect";
            }
            if (noun == "malt-worm")
            {
                nountrans = "drunkard";
            }
            if (noun == "mammet")
            {
                nountrans = "puppet";
            }
            if (noun == "measle")
            {
                nountrans = "disease";
            }
            if (noun == "minnow")
            {
                nountrans = "dwarf";
            }
            if (noun == "miscreant")
            {
                nountrans = "criminal";
            }
            if (noun == "moldwarp")
            {
                nountrans = "blockhead";
            }
            if (noun == "mumble-news")
            {
                nountrans = "gossiper";
            }
            if (noun == "nut-hook")
            {
                nountrans = "thief ";
            }
            if (noun == "pigeon-egg")
            {
                nountrans = "servant";
            }
            if (noun == "popinjay")
            {
                nountrans = "egoist";
            }
            if (noun == "pignut")
            {
                nountrans = "villain";
            }
            if (noun == "puttock")
            {
                nountrans = "predator";
            }
            if (noun == "pumpion")
            {
                nountrans = "pumpkin";
            }
            if (noun == "ratsbane")
            {
                nountrans = "pessimist";
            }
            if (noun == "scut")
            {
                nountrans = "moron";
            }
            if (noun == "skainsmate")
            {
                nountrans = "prostitute";
            }
            if (noun == "strumpet")
            {
                nountrans = "hooker";
            }
            if (noun == "varlot")
            {
                nountrans = "knave";
            }
            if (noun == "vassal")
            {
                nountrans = "weakling";
            }
            if (noun == "whey-face")
            {
                nountrans = "wimp";
            }
            if (noun == "wagtail")
            {
                nountrans = "elf";
            }


            //final translated sentence will combine the translated sections 
            Translation.Text = "You " + adj1trans + ", " + adj2trans + " " + nountrans + "!";
        }

        private void Gotodictionary_Click(object sender, EventArgs e)
        {
            //Resets the form's aesthetics
            this.Hide();
            DICTION.Show();
            Translation.Text = "Here will be your translation!";
            Randomsentence.Text = "Hither will be thy insult!";
        }

        private void Gotomainmenu_Click(object sender, EventArgs e)
        {
            //Resets the form's aesthetics
            this.Hide();
            MENU.Show();
            Translation.Text = "Here will be your translation!";
            Randomsentence.Text = "Hither will be thy insult!";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //Exits program
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gives the user guidance for the specific form
            MessageBox.Show("To generate a random insult, press the button labelled 'Make Thy Random Fig', and a random insult will appear in the box below it. Along with the insult, the translation of the sentence into modern English will appear in the box located on the bottom of the generator. For further information on the program, please go to the instructions section via the main menu.", "Help", MessageBoxButtons.OK); 
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            //Clears translation and insult
            Translation.Text = "";
            Randomsentence.Text = "";
        }
    }
}
public static class ArrayExtensions
{
    // The random number generator
    private static Random Rand = new Random();

    // Return a random item from an array
    public static T RandomElement<T>(this T[] items)
    {
        // Return a random item
        return items[Rand.Next(0, items.Length)];
    }

    // Return a random item from a list
    public static T RandomElement<T>(this List<T> items)
    {
        // Return a random item
        return items[Rand.Next(0, items.Count)];
    }
}
