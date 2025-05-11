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
    /// Логика взаимодействия для Register_Form.xaml
    /// </summary>
    public partial class Edit_Form : Window
    {
        public Edit_Form(CommonUser UserToEdit)
        {
            InitializeComponent();
            DataContext = new DataManager();
            DataManager.SelectedCommonUser = UserToEdit;
            DataManager.UsersFullName = UserToEdit.FullName;
            DataManager.UsersAddress = UserToEdit.Address;
            DataManager.UsersPhoneNumber = UserToEdit.PhoneNumber ;
            DataManager.UsersPassportId = UserToEdit.PassportId.ToString();
            DataManager.UsersPassportNumber = UserToEdit.PassportNumber;
            DataManager.UsersCardsNumber = UserToEdit.CardsNumber.ToString();
            DataManager.UsersUsersLogin = UserToEdit.UsersLogin;
            DataManager.UsersPassword = UserToEdit.UsersPassword;
            DataManager.UsersMail = UserToEdit.UsersMail;
        }
    }
}
