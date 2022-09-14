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
    public partial class Instructions : Form
    {
        public Welcome MENU = new Welcome();

        public Instructions()
        {
            InitializeComponent();
        }

        private void Backtomenu_Click(object sender, EventArgs e)
        {
            //Goes back to menu
            this.Hide();
            MENU.Show();
        }
    }
}
