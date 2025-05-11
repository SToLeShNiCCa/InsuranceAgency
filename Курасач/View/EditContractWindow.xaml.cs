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
    /// Логика взаимодействия для AddNewContractWindow.xaml
    /// </summary>
    public partial class EditContractWindow : Window
    {
        public EditContractWindow(Contract contract)
        {
            InitializeComponent();
            DataContext = new DataManager();
            DataManager.SelectedContract = contract;
            DataManager.ClientId = contract.ClientId.ToString();
            DataManager.AgentId = contract.AgentId.ToString();
            DataManager.ContractDate = contract.ContractDate;
            DataManager.Terms = contract.Terms;
        }
    }
}
