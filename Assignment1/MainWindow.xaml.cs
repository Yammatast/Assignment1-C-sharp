using Assignment1.kåd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Controller controller = new Controller();
        public MainWindow()
        {
            InitializeComponent();
            btn.Content = "tast mannen";
            countries.SelectedIndex = 0;
            setUpComboBox();
            
        }

        private void Btn_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            btn.Content = "Sug kuk";
           // lbl.Content = controller.setToText();

           // Console.WriteLine(controller.setToText());
          

        }
        private void Btn_addToList_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           Address address = controller.getAddress(street.Text, zipcode.Text, city.Text, (Countries)countries.SelectedItem);
            controller.addToList(address, (LegalForm)legalform.SelectedItem, (Category)category.SelectedItem, (BuildingType)type.SelectedItem);
            lbl.Content = (controller.setToText(address));
        }


        private void setUpComboBox()
        {
            countries.ItemsSource = Enum.GetValues(typeof(Countries));
            type.ItemsSource = Enum.GetValues(typeof(BuildingType));
            category.ItemsSource = Enum.GetValues(typeof(Category));
            legalform.ItemsSource = Enum.GetValues(typeof(LegalForm));
        }

      
        
    }
}
