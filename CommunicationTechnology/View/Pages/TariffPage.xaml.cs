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
    /// Логика взаимодействия для TariffPage.xaml
    /// </summary>
    public partial class TariffPage : Page
    {
        Core db = new Core();
        List<Tarif> arrayTariff;
        public TariffPage()
        {
            InitializeComponent();
            arrayTariff = db.context.Tarif.ToList();
            TariffCombobox.ItemsSource = arrayTariff;
            TariffCombobox.DisplayMemberPath = "TarifName";
            TariffCombobox.SelectedValuePath = "IdTarif";
        }

        private void TariffCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idActiveTariff = Convert.ToInt32(TariffCombobox.SelectedValue);
            Console.WriteLine(idActiveTariff);
            int internetTariff, countMinutesTariff, countSMSTariff, salaryTariff;
            foreach (var item in arrayTariff)
            {
                if (item.IdTarif == idActiveTariff)
                {
                    internetTariff = Convert.ToInt32(item.Internet);
                    countMinutesTariff = Convert.ToInt32(item.CountMinutes);
                    countSMSTariff = Convert.ToInt32(item.CountSMS);
                    salaryTariff = Convert.ToInt32(item.Salary);
                    Console.WriteLine(internetTariff);
                    Console.WriteLine(countMinutesTariff);
                    Console.WriteLine(countSMSTariff);
                    Console.WriteLine(salaryTariff);
                }
            }
        }
    }
}
