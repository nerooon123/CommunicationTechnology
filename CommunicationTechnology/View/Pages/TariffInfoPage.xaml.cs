using CommunicationTechnology.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommunicationTechnology.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TariffInfoPage.xaml
    /// </summary>
    public partial class TariffInfoPage : Page
    {
        Core db = new Core();
        List<Tarif> arrayTariff;
        List<Services> arrayServices;
        public TariffInfoPage()
        {
            InitializeComponent();
            arrayTariff = db.context.Tarif.ToList();
            TariffDataGrid.ItemsSource = arrayTariff;
            arrayServices = db.context.Services.ToList();
            ServiceListView.ItemsSource = arrayServices;
        }
    }
}
