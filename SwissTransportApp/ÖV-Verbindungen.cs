using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportApp
{
    public partial class ÖV_Verbindungen : Form
    {
        public ÖV_Verbindungen()
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

        private void SuchenButton_Click(object sender, EventArgs e)
        {
            Abfahrtstafel_Gridview.Rows.Clear();
           
            if (ViaCombo.Text == "")
            {
                var listCon = transport.GetConnectionsDate(AbfahrtCombo.Text, AnkunftCombo.Text,datePicker.Value, timePicker.Value);
                foreach (Connection connection in listCon.ConnectionList)
                {
                    Abfahrtstafel_Gridview.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, connection.From.Departure, connection.To.Arrival, connection.From.Platform,connection.To.Platform);
                }
            }
            else
            {
                var listCon = transport.GetConnectionsVia(AbfahrtCombo.Text, AnkunftCombo.Text,ViaCombo.Text, datePicker.Value, timePicker.Value);
                foreach (Connection connection in listCon.ConnectionList)
                {
                    Abfahrtstafel_Gridview.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, connection.From.Departure, connection.To.Arrival, connection.From.Platform, connection.To.Platform);
                }
            }
        }

        private void AbfahrtCombo_KeyUp(object sender, KeyEventArgs e)
        {
           
            
                AbfahrtCombo.Items.Clear();

                string ErstesItem = AbfahrtCombo.Text;

                var Stations = transport.GetStations(ErstesItem);
                List<string> liste = new List<string>();

                foreach (var Station in Stations.StationList)
                {
                    liste.Add(Station.Name);
                }
                foreach (var item in liste)
                {
                    AbfahrtCombo.Items.Add(item);
                }
                AbfahrtCombo.DroppedDown = true;

            
        }

        private void AnkunftCombo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AnkunftCombo.Items.Clear();

                string ErstesItem = AnkunftCombo.Text;

                var Stations = transport.GetStations(ErstesItem);
                List<string> list = new List<string>();

                foreach (var Station in Stations.StationList)
                {
                    list.Add(Station.Name);
                }
                foreach (var item in list)
                {
                    AnkunftCombo.Items.Add(item);
                }
                AnkunftCombo.DroppedDown = true;

            }
        }

        private void ViaCombo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ViaCombo.Items.Clear();

                string ErstesItem = ViaCombo.Text;

                var Stations = transport.GetStations(ErstesItem);
                List<string> list = new List<string>();

                foreach (var Station in Stations.StationList)
                {
                    list.Add(Station.Name);
                }
                foreach (var item in list)
                {
                    ViaCombo.Items.Add(item);
                }
                ViaCombo.DroppedDown = true;

            }
        }
    }
}
