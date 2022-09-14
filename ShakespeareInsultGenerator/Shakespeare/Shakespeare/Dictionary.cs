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
    public partial class Dictionary : Form
    {
        //Creates variable for the menu form
        public static Welcome MENU = new Welcome();
        

        public Dictionary()
        {
            InitializeComponent();
        }

        private void Listofinsults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Finddefinition_Click(object sender, EventArgs e)
        {
            string insultsword = Listofinsults.Text;

            //Definitions for each word
            if (Listofinsults.Text == "Apple-john")
            {
                //Displays word and if its a noun or adjective
                Word.Text = insultsword + " (noun)";
                //Displays definition to label
                Definition.Text = "A preserved apple which has lost the majority of its water content and thus appears wrinkled and shriveled.";
            }
            else if (Listofinsults.Text == "Artless")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Lacking art, knowledge, or skill; uncultured.";
            }
            else if  (Listofinsults.Text == "Baggage")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A women of loose morals; prostitute; strumpet.";
            }
            else if  (Listofinsults.Text == "Barnacle")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A shellfish, supposed to produce the sea-bird of thea sieve.";
            }
            else if (Listofinsults.Text == "Base-court")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "An inferior court, one not of record nor used.";
            }
            else if (Listofinsults.Text == "Bat-fowling")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Fowling at night by means ofa net with torches and poles.";
            }
            else if (Listofinsults.Text == "Bawdy")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Dealing with sexual matters in a comical way; humourously indecent.";
            }
            else if (Listofinsults.Text == "Beetle-headed")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A stupid person; blockhead";
            }
            else if (Listofinsults.Text == "Beef-witted")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Extraordinarily unintelligent; stupid.";
            }
            else if (Listofinsults.Text == "Beslubbering")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "To besmear especially with something thick or oily.";
            }
            else if (Listofinsults.Text == "Bladder")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A membranous sac in humans and other animals, in which urine is collected for excretion.";
            }
            else if (Listofinsults.Text == "Blind-worm")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A European lizard often mistaken for a snake.";
            }
            else if (Listofinsults.Text == "Boar-pig")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "An uncastrated male swine.";
            }
            else if (Listofinsults.Text == "Boil-brained")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "An individual renowned for their stupidity.";
            }
            else if (Listofinsults.Text == "Bootless")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Ineffectual; useless (of a task or undertaking).";
            }
            else if (Listofinsults.Text == "Brazen-faced")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Bold and without shame; inpudent.";
            }
            else if (Listofinsults.Text == "Bugbear")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A cause of obsessive fear, irritation, or loathing.";
            }
            else if (Listofinsults.Text == "Bum-bailey")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "Bailiff or Sherrif's officer (word associated with being an excessively good person).";
            }
            else if (Listofinsults.Text == "Bunch-back'd")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Having a bunch on the back; crooked.";
            }
            else if (Listofinsults.Text == "Burly-boned")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Having large bones; (an individual) of massive build.";
            }
            else if (Listofinsults.Text == "Calumnious")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "(Of a statement) false and defamatory; slanderous.";
            }
            else if (Listofinsults.Text == "Canker-blossom")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "Destroyer of blossoming love.";
            }
            else if (Listofinsults.Text == "Churlish")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Rude in a mean-spirited and surly way.";
            }
            else if (Listofinsults.Text == "Clack-dish")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A dish with a movable lid, formerly carried by beggars, who clacked the lid to attract notice.";
            }
            else if (Listofinsults.Text == "Clapper-clawed")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Something clawed at with your nails; beaten; abused.";
            }
            else if (Listofinsults.Text == "Clay-brained")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Stupid; dull.";
            }
            else if (Listofinsults.Text == "Clotpole")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A very stupid individual.";
            }
            else if (Listofinsults.Text == "Clouted")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A blow especially with the hand.";
            }
            else if (Listofinsults.Text == "Cockered")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "To pamper or spoil by indulgence.";
            }
            else if (Listofinsults.Text == "Codpiece")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A covering flap or pouch that attaches to the front of the crotch of men's trousers.";
            }
            else if (Listofinsults.Text == "Common-kissing")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Someone who touches everyone.";
            }
            else if (Listofinsults.Text == "Coxcomb")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A vain and conceited man; a dandy.";
            }
            else if (Listofinsults.Text == "Craven")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Contemptibly lacking in courage; cowardly.";
            }
            else if (Listofinsults.Text == "Crook-pated")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A robber who takes property by threatening or performing violence on the person who is robbed.";
            }
            else if (Listofinsults.Text == "Cullionly")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Obselete; useless.";
            }
            else if (Listofinsults.Text == "Currish")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Like a cur; snappish, ignoble.";
            }
            else if (Listofinsults.Text == "Dankish")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Somewhat moist; damp.";
            }
            else if (Listofinsults.Text == "Death-token")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "Fatal symptom; death-like sign.";
            }
            else if (Listofinsults.Text == "Devil-monk")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A mischievous individual.";
            }
            else if (Listofinsults.Text == "Dewberry")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A tall and skinny individual who is low on intelligence.";
            }
            else if (Listofinsults.Text == "Dismal-dreaming")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Full of ill-bodied dreams.";
            }
            else if (Listofinsults.Text == "Dissembling")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Conceal one's true motives, feelings, or beliefs.";
            }
            else if (Listofinsults.Text == "Dizzy-eyed")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Dazzling, blinding";
            }
            else if (Listofinsults.Text == "Doghearted")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Cruel; callous; malevolent.";
            }
            else if (Listofinsults.Text == "Dread-bolted")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Armed with dreaded bolts.";
            }
            else if (Listofinsults.Text == "Droning")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A bothersome individual; irritating.";
            }
            else if (Listofinsults.Text == "Earth-vexing")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Tormenting earhtly life; life-afflicting.";
            }
            else if (Listofinsults.Text == "Elf-skinned")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Pale skinned.";
            }
            else if (Listofinsults.Text == "Errant")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "(An individual who is) wandering, straying, erring.";
            }
            else if (Listofinsults.Text == "Fat-kidneyed")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Gross and lubberly";
            }
            else if (Listofinsults.Text == "Fawning")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Displaying exaggerated flattery or affection; obsequious.";
            }
            else if (Listofinsults.Text == "Fen-sucked")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Sucked out of marches.";
            }
            else if (Listofinsults.Text == "Fishified")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "To have changed (flesh) to fish; transformed into a fish.";
            }
            else if (Listofinsults.Text == "Flap-dragon")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A parlour game popular in the 1600s - in which the players snatch raisins, plums, etc., out of burning brandy, and eat them.";
            }
            else if (Listofinsults.Text == "Flap-mouthed")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Having broad, hangling lips.";
            }
            else if (Listofinsults.Text == "Flax-wench")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A women who spins flax; a prostitute.";
            }
            else if (Listofinsults.Text == "Flirt-gill")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A pert or wanton woman.";
            }
            else if (Listofinsults.Text == "Fly-bitten")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Marked by or as if by the bite of flies.";
            }
            else if (Listofinsults.Text == "Fobbing")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Deceitfully attemptpting to satisgy someone by making excuses or giving them something inferior.";
            }
            else if (Listofinsults.Text == "Folly-fallen")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Falling into folly; stooping to foolishness.";
            }
            else if (Listofinsults.Text == "Fool-born")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A person who was born as an unintelligent individual.";
            }
            else if (Listofinsults.Text == "Foot-licker")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A slave; a fawning or obsequious person, a sycophant; foot kisser.";
            }
            else if (Listofinsults.Text == "Frothy")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Light and entertaining but of little substance.";
            }
            else if (Listofinsults.Text == "Froward")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "(Of a person) difficult to deal with; contrary.";
            }
            else if (Listofinsults.Text == "Full-gorged")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "An individual who is over fed; fat.";
            }
            else if (Listofinsults.Text == "Fustilarian")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A low fellow; a stinkard; a scoundrel.";
            }
            else if (Listofinsults.Text == "Fusty")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Smelling stale, damp, or stuffy.";
            }
            else if (Listofinsults.Text == "Giglet")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A lascivious woman.";
            }
            else if (Listofinsults.Text == "Gleeking")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "The act of stimulating the salivary glands underneath your tongue into spitting a concentrated jet of pure saliva.";
            }
            else if (Listofinsults.Text == "Goatish")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "(Typically of a male) lustful; lecherous.";
            }
            else if (Listofinsults.Text == "Gorbellied")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "An individual who is corpulent, with a protruding belly; fat.";
            }
            else if (Listofinsults.Text == "Gudgeon")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A small freshwater fish of Eurasian origin.";
            }
            else if (Listofinsults.Text == "Guts-griping")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Gripping pain in the bowels.";
            }
            else if (Listofinsults.Text == "Haggard")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "(An individual) looking exhausted and unwell, especially from fatigue, worry, or suffering.";
            }
            else if (Listofinsults.Text == "Half-faced")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A person who shows only part of the face; wretched-looking (figurative language associated with deceit).";
            }
            else if (Listofinsults.Text == "Harpy")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A rapacious monster described as having a woman's head and body and a bird's wings and claws or depicted as a bird of prey with a woman's face.";
            }
            else if (Listofinsults.Text == "Hasty-witted")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Rash; acting without prior planning or consideration.";
            }
            else if (Listofinsults.Text == "Hedge-born")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Born under a hedge; of low birth";
            }
            else if (Listofinsults.Text == "Hedge-pig")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A young hedgehog.";
            }
            else if (Listofinsults.Text == "Hell-hated")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Hated by the devil.";
            }
            else if (Listofinsults.Text == "Horn-beast")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A horned beast; an animal with horns.";
            }
            else if (Listofinsults.Text == "Hugger-mugger")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "An act of secrecy performed without any thought.";
            }
            else if (Listofinsults.Text == "Idle-headed")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Foolish; stupid.";
            }
            else if (Listofinsults.Text == "Ill-breeding")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Rude; impolite; having or showing bad manners.";
            }
            else if (Listofinsults.Text == "Ill-nurtured")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "An individual who was improperly raised during their childhood.";
            }
            else if (Listofinsults.Text == "Impertinent")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Not showing proper respect; rude; insolent.";
            }
            else if (Listofinsults.Text == "Infectious")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "An entity that is destructive or pernicious in nature.";
            }
            else if (Listofinsults.Text == "Jarring")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Having an unpleasant, annoying, or disturbing effect.";
            }
            else if (Listofinsults.Text == "Jolthead")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A stupid or foolish person.";
            }
            else if (Listofinsults.Text == "Knave")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A dishonest or unscrupulous man.";
            }
            else if (Listofinsults.Text == "Knotty-pated")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A person who is dull-witted; block-head.";
            }
            else if (Listofinsults.Text == "Leaden-footed")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Slow and laborious in movement.";
            }
            else if (Listofinsults.Text == "Lewdster")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A lewd person; a lecher.";
            }
            else if (Listofinsults.Text == "Lily-livered.")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Weak and cowardly.";
            }
            else if (Listofinsults.Text == "Loggerheaded")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A person renowned for their lack of intellectual activity; idiotic.";
            }
            else if (Listofinsults.Text == "Lout")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "An awkward, stupid person; clumsy, ill-mannered boor; oaf.";
            }
            else if (Listofinsults.Text == "Lumpish")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "(Of a person) stupid and lethargic.";
            }
            else if (Listofinsults.Text == "Maggot-pie")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A pie made out of maggots or common fly larva (possesses connotations as a curse word).";
            }
            else if (Listofinsults.Text == "Malcontent")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A person who is dissatisfied and rebellious; troublemaker.";
            }
            else if (Listofinsults.Text == "Malcontent")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A person who is dissatisfied and rebellious; troublemaker.";
            }
            else if (Listofinsults.Text == "Malmsey-nosed")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "An acned nose is the result of drinking too much malmsey wine.";
            }
            else if (Listofinsults.Text == "Malt-worm")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A malt infestation with a sense of a heavy drinker; drunkard.";
            }
            else if (Listofinsults.Text == "Mammering")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Hesistant; (of a person) constant stammering or muttering within speech.";
            }
            else if (Listofinsults.Text == "Mammet")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A false idol; effigy; lifeless figure.";
            }
            else if (Listofinsults.Text == "Mangled")
            {
                
                Definition.Text = "(Of a person's look) severely mutilated or disfigured.";
            }
            else if (Listofinsults.Text == "Measle")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "Scabs; lepers";
            }
            else if (Listofinsults.Text == "Mewling")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "(Especially of a baby) cry feebly or querulously; whimper.";
            }
            else if (Listofinsults.Text == "Milk-livered")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Cowardly, timorous.";
            }
            else if (Listofinsults.Text == "Minnow")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A person of relatively small size or influence; puny.";
            }
            else if (Listofinsults.Text == "Misbegotten")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Contemptible; badly concieved, designed, or planned.";
            }
            else if (Listofinsults.Text == "Miscreant")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A person who behaves badly or in a way that breaks the law; wrongdoer.";
            }
            else if (Listofinsults.Text == "Moldwarp")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A stupid or shiftless individual.";
            }
            else if (Listofinsults.Text == "Motley-minded")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Having a mind or character like that of a professional fool or clown; exhibiting incoherence in thought; having thoughts of a motley character.";
            }
            else if (Listofinsults.Text == "Muddy-mettled")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Having a dull spirit.";
            }
            else if (Listofinsults.Text == "Mumble-news")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A talebearer; gossip.";
            }
            else if (Listofinsults.Text == "Nut-hook")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A thief who steals by means of a hook.";
            }
            else if (Listofinsults.Text == "Odiferous")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Having or giving off a smell, especially an unpleasant or distinctive one.";
            }
            else if (Listofinsults.Text == "Onion-eyed")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Sluggish; dull-spirited.";
            }
            else if (Listofinsults.Text == "Paunchy")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Having a prominent stomach; potbellied.";
            }
            else if (Listofinsults.Text == "Pigeon-egg")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "(Figurative) something very small or insignificant.";
            }
            else if (Listofinsults.Text == "Pignut")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "Any of several bitter-flavored hickory nuts (in relation to a bitter-minded person).";
            }
            else if (Listofinsults.Text == "Plume-plucked")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Stripped of a source of pride, humbled.";
            }
            else if (Listofinsults.Text == "Poisonous")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Extremely unpleasant or malicious";
            }
            else if (Listofinsults.Text == "Popinjay")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A vain or conceited person, especially one who dresses or behaves extravagantly.";
            }
            else if (Listofinsults.Text == "Pottle-deep")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "As deep as the pottle; to the bottom of the pottle.";
            }
            else if (Listofinsults.Text == "Pox-marked")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A mark or scar on the skin that is usually caused by a disease.";
            }
            else if (Listofinsults.Text == "Pribbling")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Argumentative.";
            }
            else if (Listofinsults.Text == "Puking")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Vomiting.";
            }
            else if (Listofinsults.Text == "Pumpion")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "Pumpkin.";
            }
            else if (Listofinsults.Text == "Puny")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Small and weak.";
            }
            else if (Listofinsults.Text == "Puttock")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "Greedy scavenger; a rapacious person who preys on the defenseless.";
            }
            else if (Listofinsults.Text == "Qualling")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "An individual who always follows the rules; obedient.";
            }
            else if (Listofinsults.Text == "Rampallian")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "A good-for-nothing scoundrel; wretched.";
            }
            else if (Listofinsults.Text == "Rank")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Swollen; brim.";
            }
            else if (Listofinsults.Text == "Rascal")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A mischievous or cheeky person, especially a child or man.";
            }
            else if (Listofinsults.Text == "Ratsbane")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "Rat poison.";
            }
            else if (Listofinsults.Text == "Reeky")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "To emit a foul smell.";
            }
            else if (Listofinsults.Text == "Reeling-ripe")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Drunk enough to be on the verge of reeling.";
            }
            else if (Listofinsults.Text == "Roguish")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "The characteristic of a dishonest or unprincipled person.";
            }
            else if (Listofinsults.Text == "Rough-hewn")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "An individual who is not sophisticated, polished, or elegant.";
            }
            else if (Listofinsults.Text == "Rude-growing")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Lacking in social refinement; rough; discourteous; rude.";
            }
            else if (Listofinsults.Text == "Rump-fed")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Fattened in the rump; pampered";
            }
            else if (Listofinsults.Text == "Ruttish")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Inclined to rut; lustful.";
            }
            else if (Listofinsults.Text == "Saucy")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Lack of respect for another person; impudent; flippant;";
            }
            else if (Listofinsults.Text == "Scut")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A person perceived as foolish, contemptible, or objectionable.";
            }
            else if (Listofinsults.Text == "Shard-borne")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Born on shards or scaly wing cases.";
            }
            else if (Listofinsults.Text == "Sheep-biting")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Contemptible; unscrupulous; shifty.";
            }
            else if (Listofinsults.Text == "Skainsmate")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A prostitute.";
            }
            else if (Listofinsults.Text == "Spleeny")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Full of or displaying spleen; irritable.";
            }
            else if (Listofinsults.Text == "Spongy")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Soft-hearted.";
            }
            else if (Listofinsults.Text == "Spur-galled")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "To gall or wound with a spur.";
            }
            else if (Listofinsults.Text == "Strumpet")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A female prostitute or a promiscuous woman.";
            }
            else if (Listofinsults.Text == "Surly")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Bad-tempered and unfriendly.";
            }
            else if (Listofinsults.Text == "Swag-bellied")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Having a prominent, overhanging belly; fat.";
            }
            else if (Listofinsults.Text == "Tardy-gaited")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Slow-paced; having a slow step or pace.";
            }
            else if (Listofinsults.Text == "Toad")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Foully blemished; most evil; infamous.";
            }
            else if (Listofinsults.Text == "Tickle-brained")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "One who has a tickle or unsteady brain, as one intoxicated.";
            }
            else if (Listofinsults.Text == "Toad-spotted")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Thickly stained or spotted, like a toad; covered thickly with blemishes or stains of guilt.";
            }
            else if (Listofinsults.Text == "Tottering")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "An unstable mental condition.";
            }
            else if (Listofinsults.Text == "Urchin-snouted")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Having a nose like that of a hedgehog; having a goblin-like, demoniac snout.";
            }
            else if (Listofinsults.Text == "Unmuzzled")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Stupid; foolish; ludicrous.";
            }
            else if (Listofinsults.Text == "Vain")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Having or showing undue or excessive pride in one's appearance or achievements.";
            }
            else if (Listofinsults.Text == "Varlot")
            {
                Word.Text = insultsword + " (noun.)";
                Definition.Text = "A base unprincipled person; knave.";
            }
            else if (Listofinsults.Text == "Vassal")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A person or country in a subordinate position to another.";
            }
            else if (Listofinsults.Text == "Venomed")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Something resembling or suggesting poison in its effect; spite; malice.";
            }
            else if (Listofinsults.Text == "Villainous")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Extremely bad or unpleasant.";
            }
            else if (Listofinsults.Text == "Wagtail")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "Any of numerous small, chiefly Old World birds of the family Motacillidae, having a slender body with a long, narrow tail that is habitually wagged up and down.";
            }
            else if (Listofinsults.Text == "Warped")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "(Of a person's mind, attitude, humour) perverse; strange; aberrant; deviant.";
            }
            else if (Listofinsults.Text == "Wayward")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Difficult to control or predict because of unusual or perverse behavior.";
            }
            else if (Listofinsults.Text == "Weather-bitten")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Eaten into, defaced, or worn, by exposure to the weather.";
            }
            else if (Listofinsults.Text == "Weedy")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "(Of a person) thin and physically weak in appearance.";
            }
            else if (Listofinsults.Text == "Whey-face")
            {
                Word.Text = insultsword + " (noun)";
                Definition.Text = "A person having a pale face (as from fear).";
            }
            else if (Listofinsults.Text == "Whoreson")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "An unpleasant or greatly disliked person.";
            }
            else if (Listofinsults.Text == "Yeasty")
            {
                Word.Text = insultsword + " (adj.)";
                Definition.Text = "Characterized by or producing upheaval or agitation; in a state of turbulence.";
            }
            //if none of the definitions are chosen, the user will be asked to put a valid input
            else
            {
                DialogResult prompt;
                prompt = MessageBox.Show("Please enter a word from the dropdown list.", "Invalid Entry", MessageBoxButtons.OK);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Gotomainmenu_Click(object sender, EventArgs e)
        {
            //Resets form's aesthetics
            Definition.Text = "Hither will by thy definition!";
            Listofinsults.Text = "";
            Word.Text = "";
            this.Hide();
            MENU.Show();
        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            //Info on help for form
            MessageBox.Show("To find the definition of a word, select a word from the dropdown list and proceed to hit the button labelled 'Findeth thy Definition'. The definition of the word will be shown on the right-hand box. For further information on the program, please go to the instructions section via the main menu.", "Help", MessageBoxButtons.OK);
        }
    }
}
