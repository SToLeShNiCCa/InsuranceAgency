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
    /// Логика взаимодействия для MainWindowForWork.xaml
    /// </summary>
    public partial class MainWindowForWork : Window
    {
        public static ListView AllAgentsView;
        public static ListView AllBranchView;
        public static ListView AllUsersView;
        public static ListView AllContractsView;
        public static ListView AllHealthInsuranceView;
        public static ListView AllInsuranceClaimView;
        public static ListView AllPaymentsView;
        public static ListView AllPolicyView;
        public static ListView AllPolicyTypeView;
        public static ListView AllPropertyView;
        public static ListView AllReviewView;
        public static ListView AllVehicleView;
        public static ListView AllVersionUpdateView;
        public static ListView SortedAgents;

        //добавить контракт
        //добавить медицинскую страховку
        //
        //добавить страховые случаи
        //добавить страхование жизни
        //добавить тип полиса
        //добавить выплаты
        //добавить авто
        //добавить отзывы
        public MainWindowForWork()
        {
            InitializeComponent();
            DataContext = new DataManager();
            AllAgentsView = ViewAllAgent;
            AllBranchView = ViewAllBranch;
            AllUsersView = ViewAllUsers;
            AllContractsView = ViewAllContracts;
            AllHealthInsuranceView = ViewAllHealthInsurance;
            AllInsuranceClaimView = ViewAllInsuranceClaims;
            AllPaymentsView = ViewAllPayment;
            AllPolicyView = ViewAllPolicy;
            AllPolicyTypeView = ViewAllPolicyType;
            AllPropertyView = ViewAllProperty;
            AllReviewView = ViewAllReview;
            AllVehicleView = ViewAllVehicle;
            AllVersionUpdateView = ViewAllVersionUpdate;
            SortedAgents = ViewAllAgent;
        }
    }
}
