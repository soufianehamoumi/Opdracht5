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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UserDialog dialogWindow = new UserDialog();
            dialogWindow.ShowDialog();

            if (dialogWindow.DialogResult == DialogResult.OK)
            {
                VoegToeAanLijst(dialogWindow.number);
                berekenGemiddelde();
                dialogWindow.Dispose();
            }


          
        }

          public void VoegToeAanLijst(double number)
            {
                Getallen.Items.Add(number);

            }


            public void berekenGemiddelde()
            {

                double total = 0;


                for (int i = 0; i < Getallen.Items.Count; i++)
                {
                    total = total + double.Parse(Getallen.Items[i].ToString());
                }

                total = (total / Getallen.Items.Count);


                button1.Text = total.ToString();

            }
    }
}
