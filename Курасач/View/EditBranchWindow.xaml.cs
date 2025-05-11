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
    /// Логика взаимодействия для AddNewBranchWindow.xaml
    /// </summary>
    public partial class EditBranchWindow : Window
    {
        public EditBranchWindow(Branch branch)
        {
            InitializeComponent();
            DataContext = new DataManager();
            DataManager.SelectedBranch = branch;
            DataManager.BranchName = branch.Name;
            DataManager.BranchAddress = branch.Address;
            DataManager.BranchEmployeeCount = branch.EmployeeCount.ToString();
        }
    }
}
