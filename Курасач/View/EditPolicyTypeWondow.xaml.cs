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
    /// Логика взаимодействия для AddNewPolicyTypeWondow.xaml
    /// </summary>
    public partial class EditPolicyTypeWondow : Window
    {
        public EditPolicyTypeWondow(PolicyType policyType)
        {
            InitializeComponent();
            DataContext = new DataManager();
            DataManager.SelectedPolicyType = policyType;
            DataManager.PolicyTypeName = policyType.Name;
            DataManager.PolicyTypeDescription = policyType.Description;
            DataManager.PolicyTypeBasePrice = policyType.BasePrice.ToString();
        }
    }
}
