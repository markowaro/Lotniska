using System;

namespace Lotniska1
{
    public partial class Form1 : Form
    {

        private List<AirportData> airportDataList;

        public Form1()
        {
            InitializeComponent();
            LoadDataFromFile();
            airportDataList = new List<AirportData>();
            ReadDataFromCSV(airportDataList);
        }

        private void ReadDataFromCSV(List <AirportData>airportDataList)
        {

            string filePath = "C:/Users/szymo/Desktop/studia/Semestr IV/Programowanie Wizualne/Lotniska/Lotniska1/Lotniska1/Dane-Testowe.csv";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    bool firstLine = true;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (firstLine)
                        {
                            firstLine = false;
                            continue;
                        }

                        string[] parts = line.Split(',');

                        if (parts.Length >= 6)
                        {
                            AirportData airportData = new AirportData()
                            {
                                City = parts[0].Trim(),
                                Province = parts[1].Trim(),
                                ICAO = parts[2].Trim(),
                                IATA = parts[3].Trim(),
                                AirportName = parts[4].Trim(),
                                PassengerCount = parts[5].Trim(),
                                Change = string.Join(",", parts.Skip(6)).Trim().Trim('"')
                        };

                            airportDataList.Add(airportData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("B³¹d odczytu pliku CSV: " + ex.Message);
            }
        }
        public class AirportData
        {
            public string? City { get; set; }
            public string? Province { get; set; }
            public string? ICAO { get; set; }
            public string? IATA { get; set; }
            public string? AirportName { get; set; }
            public string? PassengerCount { get; set; }
            public string? Change { get; set; }
        }

        private void LoadDataFromFile()
        {
            try
            {
                string filePath = "C:/Users/szymo/Desktop/studia/Semestr IV/Programowanie Wizualne/Lotniska/Lotniska1/Lotniska1/Dane-Testowe.csv";

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    bool isFirstLine = true;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            continue;
                        }

                        string[] values = line.Split(',');

                        if (values.Length >= 7)
                        {
                            string airportName = values[4].Trim();
                            comboBox1.Items.Add(airportName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("B³¹d wczytywania danych z pliku: " + ex.Message);
            }
        }
       
        private void buttonPokaz_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Proszê wybraæ jedn¹ z opcji z ComboBoxa.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            Form2 form = new Form2(comboBox1.SelectedItem.ToString(), checkBoxMiasto.Checked, checkBoxWojewodztwo.Checked, checkBoxICAO.Checked, checkBoxIATA.Checked, checkBoxLiczbaPasazerow.Checked, checkBoxZmiana.Checked, airportDataList, comboBox1.SelectedIndex);
            form.Show();
        }
    }
}
