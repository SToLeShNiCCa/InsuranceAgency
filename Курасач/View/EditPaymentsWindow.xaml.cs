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
    /// Логика взаимодействия для AddNewPaymentsWindow.xaml
    /// </summary>
    public partial class EditPaymentsWindow : Window
    {
        public EditPaymentsWindow(Payment payment)
        {
            InitializeComponent();
            DataContext = new DataManager();
            DataManager.SelectedPayment = payment;
            DataManager.PaymentIdClients = payment.IdClients.ToString();
            DataManager.PaymentIdPolices = payment.IdPolices.ToString();
            DataManager.PaymentSumma = payment.Summa.ToString();
            DataManager.PaymentDateOfPay = payment.DateOfPay;
            DataManager.PaymentTypeOfPay = payment.TypeOfPay;

        }
    }
}
