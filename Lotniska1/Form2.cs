using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lotniska1.Form1;

namespace Lotniska1
{
    public partial class Form2 : Form
    {
        public Form2(string airportName, bool city, bool voivodeship, bool ICAO, bool IATA, bool numberOfPassengers, bool change, List<AirportData> airports, int selected_index)
        {
            InitializeComponent();
            List<AirportData>zmienna = airports;
            add_data_to_gridview(airportName, city, voivodeship, ICAO, IATA, numberOfPassengers, change, zmienna, selected_index);
        }
        private void add_data_to_gridview(string airportName, bool city, bool voivodeship, bool ICAO, bool IATA, bool numberOfPassengers, bool change, List<AirportData>zmienna, int selected_index)
        {
            dataGridView1.Columns.Add("Nazwa lotniska", "Nazwa lotniska");
            dataGridView1.Rows[0].Cells[0].Value = airportName;
            int counter = 1;
            if (city)
            {
                dataGridView1.Columns.Add("Miasto", "Miasto");
                dataGridView1.Rows[0].Cells[counter].Value = zmienna[selected_index].City;
                counter++;
            }
            if (voivodeship)
            {
                dataGridView1.Columns.Add("Województwo", "Województwo");
                dataGridView1.Rows[0].Cells[counter].Value = zmienna[selected_index].Province;
                counter++;
            }
            if (ICAO)
            {
                dataGridView1.Columns.Add("ICAO", "ICAO");
                dataGridView1.Rows[0].Cells[counter].Value = zmienna[selected_index].ICAO;
                counter++;
            }
            if (IATA)
            {
                dataGridView1.Columns.Add("IATA", "IATA");
                dataGridView1.Rows[0].Cells[counter].Value = zmienna[selected_index].IATA;
                counter++;
            }
            if (numberOfPassengers)
            {
                dataGridView1.Columns.Add("Liczba pasażerów", "Liczba pasażerów");
                dataGridView1.Rows[0].Cells[counter].Value = zmienna[selected_index].PassengerCount;
                counter++;
            }
            if (change)
            {
                dataGridView1.Columns.Add("Zmiana", "Zmiana");
                dataGridView1.Rows[0].Cells[counter].Value = zmienna[selected_index].Change;
                counter++;
            }
        }
            

    }
            

        

    
}

