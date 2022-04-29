using SwissTransport.Core;

namespace SwissTransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Abfahrtstafel_Button_Click(object sender, EventArgs e)
        {
            Abfahrtstafel abfahrtstafel = new Abfahrtstafel();
            this.Hide();
            abfahrtstafel.ShowDialog();
            abfahrtstafel = null;
            this.Show();



        }

        private void övVerbindungen_Button_Click(object sender, EventArgs e)
        {
            ÖV_Verbindungen öV_Verbindungen = new ÖV_Verbindungen();
            this.Hide();
            öV_Verbindungen.ShowDialog();
            öV_Verbindungen = null;
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }
    }
}