namespace Oef2
{
    public partial class Form1 : Form
    {
        App gemiddelde = new App();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            gemiddelde.MdiParent = this;
            gemiddelde.Show();
        }
    }
}