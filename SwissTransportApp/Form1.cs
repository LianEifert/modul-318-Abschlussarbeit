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
            abfahrtstafel.Show();
            
            
            
        }

        private void �vVerbindungen_Button_Click(object sender, EventArgs e)
        {
            �V_Verbindungen �V_Verbindungen = new �V_Verbindungen();
            this.Hide();
            �V_Verbindungen.Show();
        }
    }
}