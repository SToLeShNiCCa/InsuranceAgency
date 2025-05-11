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
    /// Логика взаимодействия для AddNewLifeInsuranceWindow.xaml
    /// </summary>
    public partial class EditLifeInsuranceWindow : Window
    {
        public EditLifeInsuranceWindow(LifeInsurance lifeInsurance)
        {
            InitializeComponent();
            DataContext = new DataManager();
            DataManager.SelectedLifeInsurance = lifeInsurance;
            DataManager.LifeClientId = lifeInsurance.ClientId.ToString();
            DataManager.InsuredAmount = lifeInsurance.InsuredAmount.ToString();
            DataManager.ExpirationDate = lifeInsurance.ExpirationDate;
        }

    }
}
