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
using System.Windows.Shapes;
using Курасач.Models;
using Курасач.View_Model;

namespace Курасач.View
{
    /// <summary>
    /// Логика взаимодействия для AddNewPropertyWindow.xaml
    /// </summary>
    public partial class EditPropertyWindow : Window
    {
        public EditPropertyWindow(Property property)
        {
            InitializeComponent();
            DataContext = new DataManager();
            DataManager.SelectedProperty = property;
            DataManager.PropertyClientId = property.ClientId.ToString();
            DataManager.PropertyPropertyType = property.PropertyType;
            DataManager.PropertyAddress = property.Address;
            DataManager.PropertyInsuredValue = property.InsuredValue.ToString();
        }
    }
}
