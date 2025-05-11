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
using Курасач.View_Model;

namespace Курасач.View
{
    /// <summary>
    /// Логика взаимодействия для AddNewHealthInsuranceWindow.xaml
    /// </summary>
    public partial class AddNewHealthInsuranceWindow : Window
    {
        public AddNewHealthInsuranceWindow()
        {
            InitializeComponent();
            DataContext = new DataManager();
        }
    }
}
