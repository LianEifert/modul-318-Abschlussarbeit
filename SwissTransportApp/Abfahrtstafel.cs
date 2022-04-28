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
            Abfahrtstafel_Gridview.Rows.Clear();
            
                var list = transport.GetStationBoard(SucheCombobox.Text, SucheCombobox.Text);

            foreach (StationBoard connection in list.Entries)
            {
                Abfahrtstafel_Gridview.Rows.Add(list.Station.Name,connection.To,connection.Stop.Departure);
                
            }
        }

    

        private void SucheCombobox_TextChanged(object sender, EventArgs e)
        {
          
                
                
                
                
            


        }
        private void ClearAll(ComboBox combobox)
        {
            var items = combobox.Items;
            foreach (var item in items)
            {
                combobox.Items.Remove(item);
            }


        }

        private void SucheCombobox_KeyDown(object sender, KeyEventArgs e)
        {
           

        }
                List<string> list = new List<string>();
        Stations stations;
        string ErstesItem;
        private void SucheCombobox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SucheCombobox.Text.Length == 6)
            {

                SucheCombobox.Items.Clear();



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
            SucheCombobox.SelectionStart = SucheCombobox.Text.Length + 1;

        }
    }
}
