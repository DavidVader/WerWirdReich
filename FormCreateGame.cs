using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerWirdReich
{
    public partial class FormCreateGame : Form
    {
        public FormCreateGame()
        {
            InitializeComponent();
            FormClosing += CreateGame_FormClosing;
        }

        private void CreateGame_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
