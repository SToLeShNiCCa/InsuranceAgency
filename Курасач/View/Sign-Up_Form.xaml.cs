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
    /// Логика взаимодействия для Sign_Up_Form.xaml
    /// </summary>
    public partial class Sign_Up_Form : Window
    {
        public Sign_Up_Form()
        {
            InitializeComponent();
            DataContext = new DataManager();
        }
    }
}
