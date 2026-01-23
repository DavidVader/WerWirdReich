using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WerWirdReich
{
    public partial class FormOption : Form
    {
        private FormMenu menu;

        public FormOption()
        {
            InitializeComponent();
            FormClosing += Optionen_FormClosing;
        }
        /*
         * This Function is closing the whole Application, 
         * since the main Form (Menu) is still running in the background...
         * THATS WHY WE COULD NOT START THE PROGRAM, since it already runs in the background...
         * 
         * ~ David
         */
        private void Optionen_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu = new FormMenu();
            menu.Show();
            this.Hide();
        }
    }
}
