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
    /// Логика взаимодействия для AddNewHealthInsuranceWindow.xaml
    /// </summary>
    public partial class EditHealthInsuranceWindow : Window
    {
        public EditHealthInsuranceWindow(HealthInsurance healthInsurance)
        {
            InitializeComponent();
            DataContext = new DataManager();
            DataManager.SelectedHealthInsurance = healthInsurance;
            DataManager.HealthClientId = healthInsurance.ClientId.ToString();
            DataManager.MedicalConditions = healthInsurance.MedicalConditions;
            DataManager.CoverageLimit = healthInsurance.CoverageLimit.ToString();
        }
    }
}
