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
    /// Логика взаимодействия для AddNewAgentWindow.xaml
    /// </summary>
    public partial class EditAgentWindow : Window
    {
        public EditAgentWindow(Agent agent)
        {
            InitializeComponent();
            DataContext = new DataManager();
            DataManager.SelectedAgent = agent;
            DataManager.AgentsFullName = agent.FullAgentsName;
            DataManager.AgentsContactNumber = agent.ContactNumber;
            DataManager.AgentsMail = agent.Email;
            DataManager.AgentsHireDate = agent.HireDate;
            DataManager.AgentsStatus = agent.Stat;
        }
    }
}
