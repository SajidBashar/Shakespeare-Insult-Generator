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
    public partial class Welcome : Form
    {

        //public variables for each form
        public static Generator GENERATOR = new Generator();
        public static Facts FACTS = new Facts();
        public static Dictionary DICTION = new Dictionary();
        public static Instructions HELP = new Instructions();

        public Welcome()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //Exits program
            Application.Exit();
        }

        private void Gotogenerator_Click(object sender, EventArgs e)
        {
            //Goes to generator
            this.Hide();
            GENERATOR.Show();
        }

        private void Gotofacts_Click(object sender, EventArgs e)
        {
            //Goes to facts section
            this.Hide();
            FACTS.Show();
        }

        private void Gotodictionary_Click(object sender, EventArgs e)
        {
            //Goes to dictionary
            this.Hide();
            DICTION.Show();
        }

        private void Gotohelp_Click(object sender, EventArgs e)
        {
            //Goes to help section
            this.Hide();
            HELP.Show();
        }
    }
}
