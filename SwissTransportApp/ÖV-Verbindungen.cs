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
        
      

        private void SuchenButton_Click(object sender, EventArgs e)
        {
            try
            {


                Abfahrtstafel_Gridview.Rows.Clear();

                if (ViaCombo.Text == "")
                {
                    var listCon = transport.GetConnectionsDate(AbfahrtCombo.Text, AnkunftCombo.Text, datePicker.Value, timePicker.Value);
                    foreach (Connection connection in listCon.ConnectionList)
                    {
                        Abfahrtstafel_Gridview.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, connection.From.Departure, connection.To.Arrival, connection.From.Platform, connection.To.Platform);
                    }
                }
                else
                {
                    var listCon = transport.GetConnectionsVia(AbfahrtCombo.Text, AnkunftCombo.Text, ViaCombo.Text, datePicker.Value, timePicker.Value);
                    foreach (Connection connection in listCon.ConnectionList)
                    {
                        Abfahrtstafel_Gridview.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, connection.From.Departure, connection.To.Arrival, connection.From.Platform, connection.To.Platform);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        List<string> list = new List<string>();
        List<string> list2 = new List<string>();
        List<string> list3 = new List<string>();
        private void AbfahrtCombo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {



                if (AbfahrtCombo.Text.Length == 5)
                {
                    AbfahrtCombo.Items.Clear();



                    AbfahrtCombo.SelectionStart = AbfahrtCombo.Text.Length + 1;
                    var ErstesItem = AbfahrtCombo.Text;

                    var stations = transport.GetStations(ErstesItem);

                    foreach (var Station in stations.StationList)
                    {
                        list.Add(Station.Name);
                    }

                    foreach (var item in list)
                    {
                        AbfahrtCombo.Items.Add(item);
                    }

                    AbfahrtCombo.DroppedDown = true;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AnkunftCombo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                if (AnkunftCombo.Text.Length == 5)
                {
                    AnkunftCombo.Items.Clear();



                    AnkunftCombo.SelectionStart = AnkunftCombo.Text.Length + 1;
                    var ErstesItem = AnkunftCombo.Text;

                    var stations = transport.GetStations(ErstesItem);

                    foreach (var Station in stations.StationList)
                    {
                        list2.Add(Station.Name);
                    }

                    foreach (var item in list2)
                    {
                        AnkunftCombo.Items.Add(item);
                    }

                    AnkunftCombo.DroppedDown = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void ViaCombo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                if (ViaCombo.Text.Length == 5)
                {
                    ViaCombo.Items.Clear();



                    ViaCombo.SelectionStart = ViaCombo.Text.Length + 1;
                    var ErstesItem = ViaCombo.Text;

                    var stations = transport.GetStations(ErstesItem);

                    foreach (var Station in stations.StationList)
                    {
                        list3.Add(Station.Name);
                    }

                    foreach (var item in list3)
                    {
                        ViaCombo.Items.Add(item);
                    }

                    ViaCombo.DroppedDown = true;


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

    }
}
