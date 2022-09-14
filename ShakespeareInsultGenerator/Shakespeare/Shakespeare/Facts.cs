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
    public partial class Facts : Form
    {
        public static Welcome MENU = new Welcome();

        public Facts()
        {
            InitializeComponent();
        }

        private string[] facts =
        {
            //Cluster of Shakespearean facts
            "Shakespeare was born on April 26, 1564 in Stratford, England.",
            "Shakespeare is most likely to have received a classical Latin education at King’s New School in Stratford.",
            "He married his wife - Anne Hathaway - when he was only 18 years of age.",
            "Shakespeare worked as an actor, writer and co-owner of a drama company called the ‘Lord Chamberlain’s Men’- Later known as the King’s Men.",
            "His greatest plays include Hamlet, King Lear, Othello, Macbeth and Romeo and Juliet.",
            "By 1592, Shakespeare recieved first literary criticism with playwright Robert Greene.",
            "The first publishing of Shakespeare’s works is the First Folio, published in 1623.",
            "Shakespeare was acquainted with Queen Elizabeth I.",
            "Shakespeare’s plays contain 200 references to dogs and 600 references to birds.",
            "Shakespeare has given provided the English language with an estimated 1,700 - 3,000 words.",
            "Estimations of Shakespeare’s vocabulary range from 17,000 to 29,000 words.",
            "Shakespeare has written 38 plays and 154 sonnets.",
            "Because they were often hastily written for performance on stage, none of Shakespeare’s original manuscripts exist.",
            "William Shakespeare is the best-selling fiction author of all tim, with an estimated 4 billion copies sold.",
            "The Globe burned to the ground on June 29, 1613, set fire by a cannon shot during a performance of Shakespeare's Henry VIII.",
            "Shakespeare’s plays feature the first written instances of hundreds of familiar terms.",
            "Very little is known about William Shakespeare’s early years. His actual date of birth remains a mystery to this day.",
            "From 1585-1592, the mysterious William Shakespeare disappeared from records and his actions in this time period remain undetermined.",
            "Shakespeare’s popularity blossomed after the Romantic period and during the Victorian period – receiving the praise of poets, such as Samuel Taylor Coleridge, Victor Hugo and Voltaire.",
            "Early praise for Shakespeare came from writers such as Ben Johnson. Jonson remarked of Shakespeare he was the – “Soul of the age, the applause, delight, the wonder of our stage”.",
            "After the death of Queen Elizabeth I, Shakespeare’s company was awarded a royal patent by the new King James I and changed its name to the Kings Men.",
            "Shakespeare lived through an outbreak of the bubonic plague in London (1524-94) and 1609. The plague also came to Stratford, when Shakespeare was just 3 months old.",
            "Many of Shakespeare’s plays were based on historical accounts, dramatised by Shakespeare. He also dramatised stories from classical writers such as Plutarch and Holinshed.",
            "Shakespeare never seemed to spell his name properly, often signing his name “Willm Shakp,”.",
            "Shakespeare’s grave includes a curse against moving his bones.",
        };

        private void Generaterandomfact_Click(object sender, EventArgs e)
        {
            //Chooses random fact from the list
            Randomfact.Text = facts.RandomElement();
        }

        private void Gotomainmenu_Click(object sender, EventArgs e)
        {
            //Redirect to mainmenu
            this.Hide();
            MENU.Show();
            Randomfact.Text = "Hither will be by fate facts of of the most wondrous sir that is Shakespeare!";
        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            //Help for the user
            MessageBox.Show("To view a random fact on Shakespeare, simply press the button labelled 'Showeth me thy by Fate Facts!'. For further information on the program, please go to the instructions section via the main menu.", "Help", MessageBoxButtons.OK);
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
}