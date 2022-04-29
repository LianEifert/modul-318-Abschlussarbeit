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

       

        private void Suchen_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Abfahrtstafel_Gridview.Rows.Clear();

                var list = transport.GetStationBoard(SucheCombobox.Text, SucheCombobox.Text);

                foreach (StationBoard connection in list.Entries)
                {
                    Abfahrtstafel_Gridview.Rows.Add(list.Station.Name, connection.To, connection.Stop.Departure);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

        
     

        
        List<string> list = new List<string>();

        Stations stations;
        string ErstesItem;
        private void SucheCombobox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (SucheCombobox.Text.Length == 4)
                {
                    SucheCombobox.Items.Clear();



                    SucheCombobox.SelectionStart = SucheCombobox.Text.Length + 1;
                    ErstesItem = SucheCombobox.Text;

                    stations = transport.GetStations(ErstesItem);

                    foreach (var Station in stations.StationList)
                    {
                        list.Add(Station.Name);
                    }

                    foreach (var item in list)
                    {
                        SucheCombobox.Items.Add(item);
                    }

                    SucheCombobox.DroppedDown = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
    }
}
