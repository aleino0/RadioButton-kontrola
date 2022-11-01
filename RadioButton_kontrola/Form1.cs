using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rezerviraj_Click(object sender, EventArgs e)
        {
            if(avion.Checked)
            {
                prikaz.Text = "Odabrali ste prijevoz avionom.";
            }
            else if (autobus.Checked)
            {
                prikaz.Text = "Odabrali ste prijevoz autobusom.";
            }
            else if (vlastitiPrijevoz.Checked)
            {
                prikaz.Text = "Odabrali ste vlastiti prijevoz.";
            }
        }
    }
}
