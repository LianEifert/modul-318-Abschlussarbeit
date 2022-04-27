using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Models;

namespace SwissTransportApp
{
    public partial class Abfahrtstafel : Form
    {
        public Abfahrtstafel()
        {
            InitializeComponent();
        }
        ITransport transport = new Transport();

        private void zurück_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();  
        }

        private void Suchen_Button_Click(object sender, EventArgs e)
        {
            List<Connection> list = transport.GetConnections("Buttisholz, Dorf",EingabeTextbox.Text).ConnectionList;

            foreach (Connection connection in list)
            {
                Abfahrtstafel_Gridview.Rows.Add(connection.From.Station.Name,connection.To.Station.Name,connection.From.Departure,connection.To.Arrival,connection.From.Platform,connection.To.Platform);
            }
        }
    }
}
