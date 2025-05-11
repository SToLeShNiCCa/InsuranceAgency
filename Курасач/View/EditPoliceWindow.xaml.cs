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
    /// Логика взаимодействия для AddNewPoliceWindow.xaml
    /// </summary>
    public partial class EditPoliceWindow : Window
    {
        public EditPoliceWindow(Policy policy)
        {
            InitializeComponent();
            DataContext = new DataManager();
            DataManager.SelectedPolicy = policy;
            DataManager.PolicyClientId = policy.ClientId.ToString();
            DataManager.PolicyPolicyType = policy.PolicyType;
            DataManager.PolicyCoverageAmount = policy.CoverageAmount.ToString();
            DataManager.PolicyPremium = policy.Premium.ToString();
            DataManager.PolicyStartDate = policy.StartDate;
            DataManager.PolicyEndDate = policy.EndDate;
            DataManager.PolicyStat = policy.Stat;
        }
    }
}
