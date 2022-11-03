using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef2
{
    public partial class UserDialog : Form
    {


        App Gemiddelde = new App();

        public double number { get; set; }
        public UserDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.number = double.Parse(textBox1.Text);

        }
    }
}
