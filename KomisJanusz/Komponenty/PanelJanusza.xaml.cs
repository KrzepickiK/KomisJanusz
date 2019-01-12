using KomisJanusz.Klasy;
using KomisJanuszDane;
using KomisJanuszDane.DAL;
using KomisJanuszDane.Pojazdy.Samochody;
using KomisJanuszDane.Pojazdy.Samochody.Fordy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KomisJanusz.Komponenty
{
    /// <summary>
    /// Logika interakcji dla klasy PanelJanusza.xaml
    /// </summary>
    public partial class PanelJanusza : Window
    {
        public PanelJanusza()
        {
            InitializeComponent();
            FillDataGrid();
        }

        public void Run()
        {
            Log.Write(GetType(), "Run PanelJanusza");

            Title += $" {DateTime.Now.ToString("dd-MM-yyyy")} wersja panelu janusza i całej aplikacji: {Zasoby.WersjaAplikacji}";


            try
            {
                FillDataGrid();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Czy jest na sali programista ?? \nWystąpił straszny błąd!!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FillDataGrid()
        {
            
            DataTable dt = new DataTable("Cars");

            // kolumny
            DataColumn col1 = new DataColumn("Typ pojazdu", System.Type.GetType("System.String"));
            DataColumn col2 = new DataColumn("Marka", System.Type.GetType("System.String"));
            DataColumn col3 = new DataColumn("Model", System.Type.GetType("System.String"));
            DataColumn col4 = new DataColumn("Rok produkcji", System.Type.GetType("System.Int32"));
            DataColumn col5 = new DataColumn("Cena zakupu", System.Type.GetType("System.Int32"));
            DataColumn col6 = new DataColumn("Marża", System.Type.GetType("System.Int32"));

            AppData Db = new AppData();
            Db.SeedDefaultData();

            dt.Columns.AddRange(new DataColumn[] { col1, col2, col3, col4, col5, col6 });
            foreach (var auto in Db.Pojazdy)
            {
                dt.Rows.Add(new object[] { auto.TypPojazdu, auto.Marka, auto.Model, auto.RokProdukcji, auto.CenaZakupu, auto.CenaSprzedazy });
            }
            CarsDG.ItemsSource = dt.AsDataView();
        }
    }
}
