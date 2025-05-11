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
    /// Логика взаимодействия для AddNewInsuranceClaimWindow.xaml
    /// </summary>
    public partial class EditInsuranceClaimWindow : Window
    {
        public EditInsuranceClaimWindow(InsuranceClaim insuranceClaim)
        {
            InitializeComponent();
            DataContext = new DataManager();
            DataManager.SelectedInsuranceClaim = insuranceClaim;
            DataManager.InsuranceClaimPolicyId = insuranceClaim.PolicyId.ToString();
            DataManager.InsuranceClaimIncidentDate = insuranceClaim.IncidentDate;
            DataManager.InsuranceClaimDescription = insuranceClaim.Description;
            DataManager.InsuranceClaimClaimStatus = insuranceClaim.ClaimStatus;
        }
    }
}
