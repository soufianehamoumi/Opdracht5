namespace oef1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redCtrlRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.ForeColor = Color.Red;
        }

        private void bleuCtrlBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.ForeColor = Color.Blue;

        }

        private void greenCtrlGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.ForeColor = Color.Green;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.BackColor = Color.Red;
        }

        private void bleuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.BackColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.BackColor = Color.Green;
        }

        private void smalCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           text.Font = Font = new Font(text.Font.Name, 5,
                   text.Font.Style, text.Font.Unit);
        }

        private void normalCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Font = Font = new Font(text.Font.Name, 9,
                    text.Font.Style, text.Font.Unit);
        }

        private void largeCtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Font = Font = new Font(text.Font.Name, 15,
                   text.Font.Style, text.Font.Unit);
        }
    }
}