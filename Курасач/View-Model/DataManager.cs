using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Курасач.Models;
using Курасач.View;

namespace Курасач.View_Model
{
    class DataManager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //все агенты
        private List<Agent> allAgents = DataWorker.GetAllAgents();
        public List<Agent> AllAgents
        {
            get { return allAgents; }
            set
            {
                allAgents = value;
                NotifyPropertyChanged("All Agents");
            }
        }

        //все филлиалы
        private List<Branch> allBranch = DataWorker.GetAllBranches();
        public List<Branch> AllBranch
        {
            get { return allBranch; }
            set
            {
                allBranch = value;
                NotifyPropertyChanged("All Branch");
            }
        }

        //все юзеры
        private List<CommonUser> allUsers = DataWorker.GetAllUsers();
        public List<CommonUser> AllUsers
        {
            get { return allUsers; }
            set
            {
                allUsers = value;
                NotifyPropertyChanged("All Common users");
            }
        }

        //все контакты
        private List<Contact> allContacts = DataWorker.GetAllContacts();
        public List<Contact> AllContacts
        {
            get { return allContacts; }
            set
            {
                allContacts = value;
                NotifyPropertyChanged("All Contacts");
            }
        }

        //все контракты
        private List<Contract> allContracts = DataWorker.GetAllContracts();
        public List<Contract> AllContracts
        {
            get { return allContracts; }
            set
            {
                allContracts = value;
                NotifyPropertyChanged("All Contracts");
            }
        }

        //все страховки на здоровье
        private List<HealthInsurance> allHealthInsurance = DataWorker.GetAllHealthInsurance();
        public List<HealthInsurance> AllHealthInsurance
        {
            get { return allHealthInsurance; }
            set
            {
                allHealthInsurance = value;
                NotifyPropertyChanged("All Health Insurances");
            }
        }

        //все страховые выплаты
        private List<InsuranceClaim> allInsuranceClaims = DataWorker.GetAllInsuranceClaims();
        public List<InsuranceClaim> AllInsuranceClaims
        {
            get { return allInsuranceClaims; }
            set 
            {
                allInsuranceClaims = value;
                NotifyPropertyChanged("All Insurance Claims");
            }
        }

        //все страхования жизни
        private List<LifeInsurance> allLifeInsurance = DataWorker.GetAllLifeInsurance();
        public List<LifeInsurance> AllLifeInsurance 
        {
            get { return allLifeInsurance; }
            set 
            {
                allLifeInsurance = value;
                NotifyPropertyChanged("All Life Insurances");
            }
        }

        //все платежи
        private List<Payment> allPayment = DataWorker.GetAllPayments();
        public List<Payment> AllPayment 
        {
            get { return allPayment; }
            set 
            {
                allPayment = value;
                NotifyPropertyChanged("All Payments");
            }
        }

        //все полисы
        private List<Policy> allPolicy = DataWorker.GetAllPolicy();
        public List<Policy> AllPolicy 
        {
            get { return allPolicy; }
            set 
            {
                allPolicy = value;
                NotifyPropertyChanged("All Policies");
            }
        }

        //все типы полисов
        private List<PolicyType> allPolicyType = DataWorker.GetAllPolicyType();
        public List<PolicyType> AllPolicyType 
        {
            get { return allPolicyType; }
            set 
            {
                allPolicyType = value;
                NotifyPropertyChanged("All Policy Types");
            }
        }

        private List<Property> allProperty = DataWorker.GetAllProperty();
        public List<Property> AllProperty 
        {
            get { return allProperty; }
            set 
            {
                allProperty = value;
                NotifyPropertyChanged("All Property");
            }
        }

        //все отзывы
        private List<Review> allReview = DataWorker.GetAllReview();
        public List<Review> AllReview 
        {
            get { return allReview; }
            set 
            {
                allReview = value;
                NotifyPropertyChanged("All Reviews");
            }
        }

        //все застрахованные авто
        private List<Vehicle> allVehicle = DataWorker.GetAllVehicle();
        public List<Vehicle> AllVehicle 
        {
            get { return allVehicle; }
            set 
            {
                allVehicle = value;
                NotifyPropertyChanged("All Vehicles");
            }
        }

        //все обновления
        private List<VersionUpdate> allVersionUpdate = DataWorker.GetAllVersionUpdate();
        public List<VersionUpdate> AllVersionUpdate 
        {
            get { return allVersionUpdate; }
            set 
            {
                allVersionUpdate = value;
                NotifyPropertyChanged("All Version Updates");
            }
        }


        //свойство для выделенных элементов
        public TabItem SelectedTabItem { get; set; }
        public static Agent SelectedAgent { get; set; }
        public static Branch SelectedBranch { get; set; }
        public static CommonUser SelectedCommonUser { get; set; }
        public static Contract SelectedContract { get; set; }
        public static HealthInsurance SelectedHealthInsurance { get; set; }
        public static InsuranceClaim SelectedInsuranceClaim { get; set; }
        public static LifeInsurance SelectedLifeInsurance { get; set; }
        public static Payment SelectedPayment { get; set; }
        public static Policy SelectedPolicy { get; set; }
        public static PolicyType SelectedPolicyType { get; set; }
        public static Property SelectedProperty { get; set; }
        public static Review SelectedReview { get; set; }
        public static Vehicle SelectedVehicle { get; set; }
        public static VersionUpdate SelectedVersionUpdate { get; set; }


        #region COMMANDS TO ADD
        public static string Sign_UpUsersLogin { get; set; }
        public static string Sign_UpUsers_Password { get; set; }

        private RelayCommand sign_Up;
        public RelayCommand Sign_Up
        {
            get 
            {
                return sign_Up ?? new RelayCommand(obj =>
                    {
                        Window wnd = obj as Window;
                        string resultStr = "";
                        if (Sign_UpUsersLogin == null || Sign_UpUsersLogin.Replace(" ", "").Length == 0)
                        {
                            SetRedBlockControll(wnd, "Sign_UpUsersLoginBlock");
                        }
                        else if (Sign_UpUsers_Password == null || Sign_UpUsers_Password.Replace(" ", "").Length == 0)
                        {
                            SetRedBlockControll(wnd, "Sign_UpUsers_PasswordBlock");
                        }
                        else
                        {
                            resultStr = DataWorker.Sign_UpMethod(Sign_UpUsersLogin, Sign_UpUsers_Password);
                            wnd.Close();
                        }

                    }
                );
            }
        }
        


        public static string AgentsFullName { get; set; }
        public static string AgentsMail { get; set; }
        public static string AgentsStatus { get; set; }
        public static string AgentsContactNumber { get; set; }
        public static DateTime AgentsHireDate { get; set; }


        private RelayCommand addNewAgent;
        public RelayCommand AddNewAgent
        {
            get
            {
                return addNewAgent ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (AgentsFullName == null || AgentsFullName.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "FullNameBlock");
                    }
                    else if (AgentsMail == null || AgentsMail.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "AgentMailBlock");
                    }
                    else if (AgentsStatus == null || AgentsStatus.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "AgentStatBlock");
                    }
                    else if (AgentsContactNumber == null || AgentsContactNumber.Replace(" ","").Length == 0) 
                    {
                        SetRedBlockControll(wnd, "AgentContactBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateNewAgent(AgentsFullName, AgentsContactNumber, AgentsMail, AgentsHireDate, AgentsStatus);
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }

        public static string BranchName { get; set; }
        public static string BranchAddress { get; set; }
        public static string BranchEmployeeCount { get; set; }


        private RelayCommand addNewBranch;
        public RelayCommand AddNewBranch
        {
            get
            {
                return addNewBranch ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (BranchName == null || BranchName.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "BranchNameBlock");
                    }
                    else if (BranchAddress == null || BranchAddress.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "BranchAddressBlock");
                    }
                    else if (int.Parse(BranchEmployeeCount) <= 0)
                    {
                        SetRedBlockControll(wnd, "BranchEmployeeCountBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateBranches(BranchName, BranchAddress, int.Parse(BranchEmployeeCount));
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }


        public static string UsersFullName { get; set; }
        public static string UsersAddress { get; set; }
        public static string UsersPhoneNumber { get; set; }
        public static string UsersPassportId { get; set; }
        public static string UsersPassportNumber { get; set; }
        public static string UsersCardsNumber { get; set; }
        public static string UsersUsersLogin { get; set; }
        public static string UsersPassword { get; set; }
        public static string UsersMail { get; set; }


        private RelayCommand addNewUser;
        public RelayCommand AddNewUser
        {
            get
            {
                return addNewUser ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (UsersFullName == null || UsersFullName.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "UsersFullNameBlock");
                    }
                    else if (UsersAddress == null || UsersAddress.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "UsersAddressBlock");
                    }
                    else if (UsersPhoneNumber == null || UsersPhoneNumber.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "UsersPhoneNumberBlock");
                    }
                    else if (int.Parse(UsersPassportId) <= 0)
                    {
                        SetRedBlockControll(wnd, "UsersPassportIdBlock");
                    }
                    else if (UsersPassportNumber == null || UsersPassportNumber.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "UsersPassportNumberBlock");
                    }
                    else if (UsersCardsNumber == null || UsersCardsNumber.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "UsersCardsNumberBlock");
                    }
                    else if (UsersUsersLogin == null || UsersUsersLogin.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "UsersUsersLoginBlock");
                    }
                    else if (UsersPassword == null || UsersPassword.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "UsersPasswordBlock");
                    }
                    else if (UsersMail == null || UsersMail.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "UsersMailBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateCommonUser(UsersFullName, UsersAddress, UsersPhoneNumber, int.Parse(UsersPassportId), UsersPassportNumber,int.Parse(UsersCardsNumber), UsersUsersLogin, UsersPassword, UsersMail);
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }

        public static string AgentId { get; set; }
        public static string ClientId { get; set; }
        public static DateTime ContractDate { get; set; }
        public static string Terms { get; set; }


        private RelayCommand addNewContract;
        public RelayCommand AddNewContract
        {
            get
            {
                return addNewContract ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (int.Parse(AgentId) <= 0)
                    {
                        SetRedBlockControll(wnd, "AgentIdBlock");
                    }
                    else if (int.Parse(ClientId) <= 0)
                    {
                        SetRedBlockControll(wnd, "ClientIdBlock");
                    }
                    else if (Terms == null || Terms.Replace(" ","").Length == 0)
                    {
                        SetRedBlockControll(wnd, "TermsBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateContract(int.Parse(AgentId),int.Parse(ClientId), ContractDate, Terms);
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }

        public static string HealthClientId { get; set; }
        public static string MedicalConditions { get; set; }
        public static string CoverageLimit { get; set; }


        private RelayCommand addNewHealthInsurance;
        public RelayCommand AddNewHealthInsurance
        {
            get
            {
                return addNewHealthInsurance ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (int.Parse(HealthClientId) <= 0)
                    {
                        SetRedBlockControll(wnd, "HealthClientIdBlock");
                    }
                    else if (MedicalConditions ==null || MedicalConditions.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "MedicalConditionsBlock");
                    }
                    else if (decimal.Parse(CoverageLimit) <= 0)
                    {
                        SetRedBlockControll(wnd, "CoverageLimitBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateHealthInsurance(int.Parse(HealthClientId), MedicalConditions, decimal.Parse(CoverageLimit));
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }


        public static string LifeClientId { get; set; }
        public static string InsuredAmount { get; set; }
        public static DateTime ExpirationDate { get; set; }


        private RelayCommand addNewLifeInsurance;
        public RelayCommand AddNewLifeInsurance
        {
            get
            {
                return addNewLifeInsurance ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (int.Parse(LifeClientId) <= 0 || LifeClientId == null || LifeClientId.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "LifeClientIdBlock");
                    }
                    else if (decimal.Parse(InsuredAmount) <= 0 || InsuredAmount == null || InsuredAmount.Replace(" ","").Length == 0 )
                    {
                        SetRedBlockControll(wnd, "InsuredAmountBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateLifeInsurance(int.Parse(LifeClientId), decimal.Parse(InsuredAmount),ExpirationDate);
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }

        public static string PaymentIdClients { get; set; }
        public static string PaymentIdPolices { get; set; }
        public static string PaymentSumma { get; set; }
        public static DateTime PaymentDateOfPay { get; set; }
        public static string PaymentTypeOfPay { get; set; }




        private RelayCommand addNewPayment;
        public RelayCommand AddNewPayment
        {
            get
            {
                return addNewPayment ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (PaymentIdClients == null || PaymentIdClients.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PaymentIdClientsBlock");
                    }
                    else if (PaymentIdPolices == null || PaymentIdPolices.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PaymentIdPolicesBlock");
                    }
                    else if (PaymentSumma == null || PaymentSumma.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PaymentSummaBlock");
                    }
                    else if (PaymentTypeOfPay == null || PaymentTypeOfPay.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PaymentTypeOfPayBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreatePayment(int.Parse(PaymentIdClients), int.Parse(PaymentIdPolices), decimal.Parse(PaymentSumma), PaymentDateOfPay, PaymentTypeOfPay);
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }


        public static string PolicyTypeName { get; set; }
        public static string PolicyTypeDescription { get; set; }
        public static string PolicyTypeBasePrice { get; set; }


        private RelayCommand addNewPolicyType;
        public RelayCommand AddNewPolicyType
        {
            get
            {
                return addNewPolicyType ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (PolicyTypeName == null || PolicyTypeName.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PolicyTypeNameBlock");
                    }
                    else if (PolicyTypeDescription == null || PolicyTypeDescription.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PolicyTypeDescriptionBlock");
                    }
                    else if (PolicyTypeBasePrice == null || PolicyTypeBasePrice.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PolicyTypeBasePriceBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreatePolicyType(PolicyTypeName, PolicyTypeDescription, Decimal.Parse(PolicyTypeBasePrice));
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }

        public static string PolicyClientId { get; set; }
        public static string PolicyPolicyType { get; set; }
        public static string PolicyCoverageAmount { get; set; }
        public static string PolicyPremium { get; set; }
        public static DateTime PolicyStartDate { get; set; }
        public static DateTime PolicyEndDate { get; set; }
        public static string PolicyStat { get; set; }


        private RelayCommand addNewPolicy;
        public RelayCommand AddNewPolicy
        {
            get
            {
                return addNewPolicy ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (PolicyClientId == null || PolicyClientId.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PolicyClientIdBlock");
                    }
                    else if (PolicyPolicyType == null || PolicyPolicyType.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PolicyPolicyTypeBlock");
                    }
                    else if (PolicyCoverageAmount == null || PolicyCoverageAmount.Replace(" ", "").Length == 0 )
                    {
                        SetRedBlockControll(wnd, "PolicyCoverageAmountBlock");
                    }
                    else if (PolicyPremium == null || PolicyPremium.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PolicyPremiumBlock");
                    }
                    else if (PolicyStat == null || PolicyStat.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PolicyStatBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreatePolicy(int.Parse(PolicyClientId), PolicyPolicyType, decimal.Parse(PolicyCoverageAmount), decimal.Parse(PolicyPremium), PolicyStartDate, PolicyEndDate, PolicyStat);
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }

        public static string ReviewClientId { get; set; }
        public static string ReviewRating { get; set; }
        public static string ReviewComments { get; set; }
        public static DateTime ReviewDate { get; set; }


        private RelayCommand addNewReview;
        public RelayCommand AddNewReview
        {
            get
            {
                return addNewReview ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (ReviewClientId == null || ReviewClientId.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "ReviewClientIdBlock");
                    }
                    else if (ReviewRating == null || ReviewRating.Replace(" ", "").Length == 0 || (int.Parse(ReviewRating) >= 10 && int.Parse(ReviewRating) < 0))
                    {
                        SetRedBlockControll(wnd, "ReviewRatingBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateReview(int.Parse(ReviewClientId),int.Parse(ReviewRating), ReviewComments, ReviewDate);
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }

        public static string InsuranceClaimPolicyId { get; set; }
        public static DateTime InsuranceClaimIncidentDate { get; set; }
        public static string InsuranceClaimDescription { get; set; }
        public static string InsuranceClaimClaimStatus { get; set; }


        private RelayCommand addNewInsuranceClaim;
        public RelayCommand AddNewInsuranceClaim
        {
            get
            {
                return addNewInsuranceClaim ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (InsuranceClaimPolicyId == null || InsuranceClaimPolicyId.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "InsuranceClaimPolicyIdBlock");
                    }
                    else if (InsuranceClaimDescription == null || InsuranceClaimDescription.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "InsuranceClaimDescriptionBlock");
                    }
                    else if (InsuranceClaimClaimStatus == null || InsuranceClaimClaimStatus.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "InsuranceClaimClaimStatusBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateInsuranceClaim(int.Parse(InsuranceClaimPolicyId), InsuranceClaimIncidentDate, InsuranceClaimDescription, InsuranceClaimClaimStatus);
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }

        public static string PropertyClientId { get; set; }
        public static string PropertyPropertyType { get; set; }
        public static string PropertyAddress { get; set; }
        public static string PropertyInsuredValue { get; set; }


        private RelayCommand addNewProperty;
        public RelayCommand AddNewProperty
        {
            get
            {
                return addNewProperty ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (PropertyClientId == null || PropertyClientId.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PropertyClientIdBlock");
                    }
                    else if (PropertyPropertyType == null || PropertyPropertyType.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PropertyPropertyTypeBlock");
                    }
                    else if (PropertyAddress == null || PropertyAddress.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PropertyAddressBlock");
                    }
                    else if (PropertyInsuredValue == null || PropertyInsuredValue.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "PropertyInsuredValueBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateProperty(int.Parse(PropertyClientId), PropertyPropertyType, PropertyAddress, decimal.Parse(PropertyInsuredValue));
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }

        public static string VehicleClientId { get; set; }
        public static string VehicleMark { get; set; }
        public static string VehicleModel { get; set; }
        public static string VehicleYearOfMade { get; set; }
        public static string VehicleRegistrationNumber { get; set; }
        public static string VehicleInsuredValue { get; set; }


        private RelayCommand addNewVehicle;
        public RelayCommand AddNewVehicle
        {
            get
            {
                return addNewVehicle ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (VehicleClientId == null || VehicleClientId.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "VehicleClientIdBlock");
                    }
                    else if (VehicleMark == null || VehicleMark.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "VehicleMarkBlock");
                    }
                    else if (VehicleModel == null || VehicleModel.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "VehicleModelBlock");
                    }
                    else if (VehicleYearOfMade == null || VehicleYearOfMade.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "VehicleYearOfMadeBlock");
                    }
                    else if (VehicleRegistrationNumber == null || VehicleRegistrationNumber.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "VehicleRegistrationNumberBlock");
                    }
                    else if (VehicleInsuredValue == null || VehicleInsuredValue.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "VehicleInsuredValueBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateVehicle(int.Parse(VehicleClientId), VehicleMark, VehicleModel, int.Parse(VehicleYearOfMade), VehicleRegistrationNumber, decimal.Parse(VehicleInsuredValue));
                        UpdateAllDataView();
                        wnd.Close();
                    }
                }
                );
            }
        }
        #endregion

        #region DELETE

        private RelayCommand deleteItem;
        public RelayCommand DeleteItem
        {
            get
            {
                return deleteItem ?? new RelayCommand(obj =>
                {
                    string resultStr = "Ничего не выбрано";
                    if (SelectedTabItem.Name == "AgentTab" && SelectedAgent != null)
                    {
                        resultStr = DataWorker.DeleteAgent(SelectedAgent);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "BranchTab" && SelectedBranch != null)
                    {
                        resultStr = DataWorker.DeleteBranch(SelectedBranch);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "UserTab" && SelectedCommonUser != null)
                    {
                        resultStr = DataWorker.DeleteCommonUsers(SelectedCommonUser);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "ContractTab" && SelectedContract != null)
                    {
                        resultStr = DataWorker.DeleteContract(SelectedContract);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "HealthInsuranceTab" && SelectedHealthInsurance != null)
                    {
                        resultStr = DataWorker.DeleteHealthInsurance(SelectedHealthInsurance);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "InsuranceClaimTab" && SelectedInsuranceClaim != null)
                    {
                        resultStr = DataWorker.DeleteInsuranceClaim(SelectedInsuranceClaim);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "LifeInsuranceTab" && SelectedLifeInsurance != null)
                    {
                        resultStr = DataWorker.DeleteLifeInsurance(SelectedLifeInsurance);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "PaymentTab" && SelectedPayment != null)
                    {
                        resultStr = DataWorker.DeletePayment(SelectedPayment);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "PolicyTab" && SelectedPolicy != null)
                    {
                        resultStr = DataWorker.DeletePolicy(SelectedPolicy);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "PolicyTypeTab" && SelectedPolicyType != null)
                    {
                        resultStr = DataWorker.DeletePolicyType(SelectedPolicyType);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "PropertyTab" && SelectedProperty != null)
                    {
                        resultStr = DataWorker.DeleteProperty(SelectedProperty);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "ReviewTab" && SelectedReview != null)
                    {
                        resultStr = DataWorker.DeleteReview(SelectedReview);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "VehicleTab" && SelectedVehicle != null)
                    {
                        resultStr = DataWorker.DeleteVehicle(SelectedVehicle);
                        UpdateAllDataView();
                    }
                    if (SelectedTabItem.Name == "VersionUpdateTab" && SelectedVersionUpdate != null)
                    {
                        resultStr = DataWorker.DeleteVersionUpdate(SelectedVersionUpdate);
                        UpdateAllDataView();
                    }
                    MessageBox.Show(resultStr, "Заголовок окна", MessageBoxButton.OK, MessageBoxImage.Information);

                    SetNullValuesToProperties();
                }
                );
            }
        }

        #endregion

        #region Edit
        private RelayCommand openEditItem;
        public RelayCommand OpenEditItem
        {
            get
            {
                return openEditItem ?? new RelayCommand(obj =>
                {
                    if (SelectedTabItem.Name == "AgentTab" && SelectedAgent != null)
                    {
                        OpenEditAgentWindowMethod(SelectedAgent);
                    }
                    if (SelectedTabItem.Name == "BranchTab" && SelectedBranch != null)
                    {
                        OpenEditBranchWindowMethod(SelectedBranch);
                    }
                    if (SelectedTabItem.Name == "UserTab" && SelectedCommonUser != null)
                    {
                        OpenEditCommonUserWindowMethod(SelectedCommonUser);
                    }
                    if (SelectedTabItem.Name == "ContractTab" && SelectedContract != null)
                    {
                        OpenEditContractWindowMethod(SelectedContract);
                    }
                    if (SelectedTabItem.Name == "HealthInsuranceTab" && SelectedHealthInsurance != null)
                    {
                        OpenEditHealthInsuranceWindowMethod(SelectedHealthInsurance);
                    }
                    if (SelectedTabItem.Name == "InsuranceClaimTab" && SelectedInsuranceClaim != null)
                    {
                        OpenEditInsuranceClaimWindowMethod(SelectedInsuranceClaim);
                    }
                    if (SelectedTabItem.Name == "LifeInsuranceTab" && SelectedLifeInsurance != null)
                    {
                        OpenEditLifeInsuranceWindowMethod(SelectedLifeInsurance);
                    }
                    if (SelectedTabItem.Name == "PaymentTab" && SelectedPayment != null)
                    {
                        OpenEditPaymentsWindowMethod(SelectedPayment);
                    }
                    if (SelectedTabItem.Name == "PolicyTab" && SelectedPolicy != null)
                    {
                        OpenEditPoliceWindowMethod(SelectedPolicy);
                    }
                    if (SelectedTabItem.Name == "PolicyTypeTab" && SelectedPolicyType != null)
                    {
                        OpenEditPoliceTypeWindowMethod(SelectedPolicyType);
                    }
                    if (SelectedTabItem.Name == "PropertyTab" && SelectedProperty != null)
                    {
                        OpenEditPropertyWindowMethod(SelectedProperty);
                    }
                    if (SelectedTabItem.Name == "VehicleTab" && SelectedVehicle != null)
                    {
                        OpenEditVehicleWindowMethod(SelectedVehicle);
                    }
                }
                ); 
            }
        }
        #endregion

        #region EDIT COMMAND

        private RelayCommand editAgent;
        public RelayCommand EditAgent
        {
            get
            {
                return editAgent ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedAgent != null)
                    {
                        
                        result = DataWorker.EditAgent(SelectedAgent,AgentsFullName, AgentsContactNumber, AgentsMail, AgentsHireDate, AgentsStatus);
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }

        private RelayCommand editBranch;
        public RelayCommand EditBranch
        {
            get
            {
                return editBranch ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedBranch != null)
                    {
                        result = DataWorker.EditBranch(SelectedBranch,BranchName, BranchAddress, int.Parse(BranchEmployeeCount));
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }

        private RelayCommand editUser;
        public RelayCommand EditUser
        {
            get
            {
                return editUser ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedCommonUser != null)
                    {
                        result = DataWorker.EditCommonUsers(SelectedCommonUser,UsersFullName,UsersAddress,UsersPhoneNumber,int.Parse(UsersPassportId),UsersPassportNumber,int.Parse(UsersCardsNumber),UsersUsersLogin,UsersPassword,UsersMail);
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }

        private RelayCommand editContract;
        public RelayCommand EditContract
        {
            get
            {
                return editContract ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedContract != null)
                    {
                        result = DataWorker.EditContract(SelectedContract,int.Parse(AgentId), int.Parse(ClientId), ContractDate, Terms);
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }

        private RelayCommand editHealthInsurance;
        public RelayCommand EditInsurance
        {
            get
            {
                return editHealthInsurance ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedHealthInsurance != null)
                    {
                        result = DataWorker.EditHealthInsurance(SelectedHealthInsurance,int.Parse(HealthClientId), MedicalConditions, decimal.Parse(CoverageLimit));
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }

        private RelayCommand editInsuranceClaim;
        public RelayCommand EditInsuranceClaim
        {
            get
            {
                return editInsuranceClaim ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedInsuranceClaim != null)
                    {
                        result = DataWorker.EditInsuranceClaim(SelectedInsuranceClaim,int.Parse(InsuranceClaimPolicyId), InsuranceClaimIncidentDate, InsuranceClaimDescription, InsuranceClaimClaimStatus);
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }

        private RelayCommand editLifeInsurance;
        public RelayCommand EditLifeInsurance
        {
            get
            {
                return editLifeInsurance ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedLifeInsurance != null)
                    {
                        result = DataWorker.EditLifeInsurance(SelectedLifeInsurance,int.Parse(LifeClientId), decimal.Parse(InsuredAmount), ExpirationDate);
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }

        private RelayCommand editPayment;
        public RelayCommand EditPayment
        {
            get
            {
                return editPayment ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedPayment != null)
                    {
                        result = DataWorker.EditPayment(SelectedPayment,int.Parse(PaymentIdClients), int.Parse(PaymentIdPolices), decimal.Parse(PaymentSumma), PaymentDateOfPay, PaymentTypeOfPay);
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }

        private RelayCommand editPolicy;
        public RelayCommand EditPolicy
        {
            get
            {
                return editPolicy ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedPolicy != null)
                    {
                        result = DataWorker.EditPolicy(SelectedPolicy, int.Parse(PolicyClientId), PolicyPolicyType, decimal.Parse(PolicyCoverageAmount), decimal.Parse(PolicyPremium), PolicyStartDate, PolicyEndDate, PolicyStat);
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }

        private RelayCommand editPolicyType;
        public RelayCommand EditPolicyType
        {
            get
            {
                return editPolicyType ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedPolicyType != null)
                    {
                        result = DataWorker.EditPolicyType(SelectedPolicyType,PolicyTypeName, PolicyTypeDescription, Decimal.Parse(PolicyTypeBasePrice));
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }

        private RelayCommand editProperty;
        public RelayCommand EditProperty
        {
            get
            {
                return editProperty ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedProperty != null)
                    {
                        result = DataWorker.EditProperty(SelectedProperty,int.Parse(PropertyClientId), PropertyPropertyType, PropertyAddress, decimal.Parse(PropertyInsuredValue));
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }

        private RelayCommand editVehicle;
        public RelayCommand EditVehicle
        {
            get
            {
                return editVehicle ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result;
                    if (SelectedVehicle != null)
                    {
                        result = DataWorker.EditVehicle(SelectedVehicle,int.Parse(VehicleClientId), VehicleMark, VehicleModel, int.Parse(VehicleYearOfMade), VehicleRegistrationNumber, decimal.Parse(VehicleInsuredValue));
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                }
                );
            }
        }




        #endregion

        #region COMMANDS TO OPEN WINDOW
        private RelayCommand openAddAgentWnd;
        public RelayCommand OpenAddNewAgentWnd 
        {
            get 
            {
                return openAddAgentWnd ?? new RelayCommand(obj =>
                    {
                        OpenAddAgentWindowMethod();
                    }
                    );
            }
        }


        private RelayCommand openAddBranchWnd;
        public RelayCommand OpenAddNewBranchWnd
        {
            get
            {
                return openAddBranchWnd ?? new RelayCommand(obj =>
                {
                    OpenAddBranchWindowMethod();
                }
                    );
            }
        }


        private RelayCommand openAddCommonUsersWnd;
        public RelayCommand OpenAddCommonUsersWnd
        {
            get
            {
                return openAddCommonUsersWnd ?? new RelayCommand(obj =>
                {
                    OpenAddCommonUserWindowMethod();
                }
                    );

            }
        }


        private RelayCommand openAddContractWnd;
        public RelayCommand OpenAddNewContractWnd
        {
            get
            {
                return openAddContractWnd ?? new RelayCommand(obj =>
                {
                    OpenAddContractWindowMethod();
                }
                    );
            }
        }


        private RelayCommand openAddHealthIsuranceWnd;
        public RelayCommand OpenAddHealthIsuranceWnd
        {
            get
            {
                return openAddHealthIsuranceWnd ?? new RelayCommand(obj =>
                {
                    OpenAddHealthInsuranceWindowMethod();
                }
                    );
            }
        }


        private RelayCommand openAddIsuranceClaimWnd;
        public RelayCommand OpenAddIsuranceClaimWnd
        {
            get
            {
                return openAddIsuranceClaimWnd ?? new RelayCommand(obj =>
                {
                    OpenAddInsuranceClaimWindowMethod();
                }
                    );
            }
        }


        private RelayCommand openAddLifeIsuranceWnd;
        public RelayCommand OpenAddLifeIsuranceWnd
        {
            get
            {
                return openAddLifeIsuranceWnd ?? new RelayCommand(obj =>
                {
                    OpenAddLifeInsuranceWindowMethod();
                }
                    );
            }
        }


        private RelayCommand openAddPaymentsWnd;
        public RelayCommand OpenAddPaymentsWnd
        {
            get
            {
                return openAddPaymentsWnd ?? new RelayCommand(obj =>
                {
                    OpenAddPaymentsWindowMethod();
                }
                    );
            }
        }


        private RelayCommand openAddPoliceWnd;
        public RelayCommand OpenAddPoliceWnd
        {
            get
            {
                return openAddPoliceWnd ?? new RelayCommand(obj =>
                {
                    OpenAddPoliceWindowMethod();
                }
                    );
            }
        }


        private RelayCommand openAddPolicyTypeWnd;
        public RelayCommand OpenAddPolicyTypeWnd
        {
            get
            {
                return openAddPolicyTypeWnd ?? new RelayCommand(obj =>
                {
                    OpenAddPolicyTypeWindowMethod();
                }
                    );
            }
        }


        private RelayCommand openAddPropertyWnd;
        public RelayCommand OpenAddPropertyWnd
        {
            get
            {
                return openAddPropertyWnd ?? new RelayCommand(obj =>
                {
                    OpenAddPropertyWindowMethod();
                }
                    );
            }
        }


        private RelayCommand openAddReviewWnd;
        public RelayCommand OpenAddReviewWnd
        {
            get
            {
                return openAddReviewWnd ?? new RelayCommand(obj =>
                {
                    OpenAddReviewWindowMethod();
                }
                    );
            }
        }


        private RelayCommand openAddVehicleWnd;
        public RelayCommand OpenAddVehicleWnd
        {
            get
            {
                return openAddVehicleWnd ?? new RelayCommand(obj =>
                {
                    OpenAddVehicleWindowMethod();
                }
                    );
            }
        }

        private RelayCommand openSign_UpWnd;

        public RelayCommand OpenSign_UpWnd
        {
            get 
            {
                return openSign_UpWnd ?? new RelayCommand(obj =>
                {
                    OpenSign_UpWindowMethod();
                }
                );
            }
        }


        #endregion

        #region METHODS TO OPEN WINDOW
        private void OpenAddAgentWindowMethod() 
        {
            AddNewAgentWindow newAgentWindow = new AddNewAgentWindow();
            SetCentralPositionAndOpen(newAgentWindow);
        }
        private void OpenAddBranchWindowMethod()
        {
            AddNewBranchWindow newBranchWindow = new AddNewBranchWindow();
            SetCentralPositionAndOpen(newBranchWindow);
        }
        private void OpenAddCommonUserWindowMethod()
        {
            Register_Form newCommonUser = new Register_Form();
            SetCentralPositionAndOpen(newCommonUser);
        }
        private void OpenAddContractWindowMethod()
        {
            AddNewContractWindow newContractWindow = new AddNewContractWindow();
            SetCentralPositionAndOpen(newContractWindow);
        }
        private void OpenAddHealthInsuranceWindowMethod()
        {
            AddNewHealthInsuranceWindow newHealthInsuranceWindow = new AddNewHealthInsuranceWindow();
            SetCentralPositionAndOpen(newHealthInsuranceWindow);
        }
        private void OpenAddInsuranceClaimWindowMethod()
        {
            AddNewInsuranceClaimWindow newInsuranceClaimWindow = new AddNewInsuranceClaimWindow();
            SetCentralPositionAndOpen(newInsuranceClaimWindow);
        }
        private void OpenAddLifeInsuranceWindowMethod()
        {
            AddNewLifeInsuranceWindow newLifeInsuranceWindow = new AddNewLifeInsuranceWindow();
            SetCentralPositionAndOpen(newLifeInsuranceWindow);
        }
        private void OpenAddPaymentsWindowMethod()
        {
            AddNewPaymentsWindow newPaymentsWindow = new AddNewPaymentsWindow();
            SetCentralPositionAndOpen(newPaymentsWindow);
        }
        private void OpenAddPoliceWindowMethod()
        {
            AddNewPoliceWindow newPoliceWindow = new AddNewPoliceWindow();
            SetCentralPositionAndOpen(newPoliceWindow);
        }
        private void OpenAddPolicyTypeWindowMethod()
        {
            AddNewPolicyTypeWondow newPolicyTypeWindow = new AddNewPolicyTypeWondow();
            SetCentralPositionAndOpen(newPolicyTypeWindow);
        }
        private void OpenAddPropertyWindowMethod()
        {
            AddNewPropertyWindow newPropertyWindow = new AddNewPropertyWindow();
            SetCentralPositionAndOpen(newPropertyWindow);
        }
        private void OpenAddReviewWindowMethod()
        {
            AddNewReviewWindow newReviewWindow = new AddNewReviewWindow();
            SetCentralPositionAndOpen(newReviewWindow);
        }
        private void OpenAddVehicleWindowMethod()
        {
            AddNewVehicleWindow newVehicleWindow = new AddNewVehicleWindow();
            SetCentralPositionAndOpen(newVehicleWindow);
        }



        private void OpenEditAgentWindowMethod(Agent agent)
        {
            EditAgentWindow EditAgentWindow = new EditAgentWindow(agent);
            SetCentralPositionAndOpen(EditAgentWindow);
        }
        private void OpenEditBranchWindowMethod(Branch branch)
        {
            EditBranchWindow EditBranchWindow = new EditBranchWindow(branch);
            SetCentralPositionAndOpen(EditBranchWindow);
        }

        private void OpenEditCommonUserWindowMethod(CommonUser user)
        {
            Edit_Form EditCommonUser = new Edit_Form(user);
            SetCentralPositionAndOpen(EditCommonUser);
        }
        private void OpenEditContractWindowMethod(Contract contract)
        {
            EditContractWindow EditContractWindow = new EditContractWindow(contract);
            SetCentralPositionAndOpen(EditContractWindow);
        }
        private void OpenEditHealthInsuranceWindowMethod(HealthInsurance healthIns)
        {
            EditHealthInsuranceWindow EditHealthInsuranceWindow = new EditHealthInsuranceWindow(healthIns);
            SetCentralPositionAndOpen(EditHealthInsuranceWindow);
        }
        private void OpenEditInsuranceClaimWindowMethod(InsuranceClaim insClaim)
        {
            EditInsuranceClaimWindow EditInsuranceClaimWindow = new EditInsuranceClaimWindow(insClaim);
            SetCentralPositionAndOpen(EditInsuranceClaimWindow);
        }
        private void OpenEditLifeInsuranceWindowMethod(LifeInsurance lifeIns)
        {
            EditLifeInsuranceWindow EditLifeInsuranceWindow = new EditLifeInsuranceWindow(lifeIns);
            SetCentralPositionAndOpen(EditLifeInsuranceWindow);
        }
        private void OpenEditPaymentsWindowMethod(Payment payment)
        {
            EditPaymentsWindow EditPaymentsWindow = new EditPaymentsWindow(payment);
            SetCentralPositionAndOpen(EditPaymentsWindow);
        }
        private void OpenEditPoliceWindowMethod(Policy policy)
        {
            EditPoliceWindow EditPoliceWindow = new EditPoliceWindow(policy);
            SetCentralPositionAndOpen(EditPoliceWindow);
        }
        private void OpenEditPoliceTypeWindowMethod(PolicyType policyType)
        {
            EditPolicyTypeWondow EditPolicyTypeWindow = new EditPolicyTypeWondow(policyType);
            SetCentralPositionAndOpen(EditPolicyTypeWindow);
        }
        private void OpenEditPropertyWindowMethod(Property property)
        {
            EditPropertyWindow EditPropertyWindow = new EditPropertyWindow(property);
            SetCentralPositionAndOpen(EditPropertyWindow);
        }
        private void OpenEditVehicleWindowMethod(Vehicle vehicle)
        {
            EditVehicleWindow EditVehicleWindow = new EditVehicleWindow(vehicle);
            SetCentralPositionAndOpen(EditVehicleWindow);
        }
        private void OpenSign_UpWindowMethod()
        {
            Sign_Up_Form sign_Up = new Sign_Up_Form();
            SetCentralPositionAndOpen(sign_Up);
            Application.Current.Windows[0].Hide();
        }
        #endregion

        private void SetRedBlockControll(Window wnd, string blockName)
        {
            Control block = wnd.FindName(blockName) as Control;
            block.BorderBrush = Brushes.Red;
        }

        #region UPDATE VIEW

        private void SetNullValuesToProperties()
        {
            AgentsFullName = null;
            AgentsMail = null;
            AgentsStatus = null;
            AgentsContactNumber = null;

            BranchName = null;
            BranchAddress = null;
            BranchEmployeeCount = null;

            UsersFullName = null;
            UsersAddress = null;
            UsersPhoneNumber = null;
            UsersPassportId = null;
            UsersPassportNumber = null;
            UsersCardsNumber = null;
            UsersUsersLogin = null;
            UsersPassword = null;
            UsersMail = null;

            AgentId = null;
            ClientId = null;
            Terms = null;

            HealthClientId = null;
            MedicalConditions = null;
            CoverageLimit = null;

            LifeClientId = null;
            InsuredAmount = null;

            PaymentIdClients = null;
            PaymentIdPolices = null;
            PaymentSumma = null;
            PaymentTypeOfPay = null;

            PolicyTypeName = null;
            PolicyTypeDescription = null;
            PolicyTypeBasePrice = null;

            PolicyClientId = null;
            PolicyPolicyType = null;
            PolicyCoverageAmount = null;
            PolicyPremium = null;
            PolicyStat = null;

            ReviewClientId = null;
            ReviewRating = null;
            ReviewComments = null;

            InsuranceClaimPolicyId = null;
            InsuranceClaimDescription = null;
            InsuranceClaimClaimStatus = null;

            PropertyClientId = null;
            PropertyPropertyType = null;
            PropertyAddress = null;
            PropertyInsuredValue = null;

            VehicleClientId = null;
            VehicleMark = null;
            VehicleModel = null;
            VehicleYearOfMade = null;
            VehicleRegistrationNumber = null;
            VehicleInsuredValue = null;
        }

        private void UpdateAllDataView() 
        {
            UpdateAllAgentsView();
            UpdateAllBranchView();
            UpdateAllUsersView();
            UpdateAllContractsView();
            UpdateAllHealthInsuranceView();
            UpdateAllInsuranceClaimView();
            UpdateAllPaymentsView();
            UpdateAllPolicyView();
            UpdateAllPolicyTypeView();
            UpdateAllPropertyView();
            UpdateAllReviewView();
            UpdateAllVehicleView();
            UpdateAllVersionUpdateView();
        }

        private void UpdateAllAgentsView() 
        {
            AllAgents = DataWorker.GetAllAgents();
            MainWindowForWork.AllAgentsView.ItemsSource = null;
            MainWindowForWork.AllAgentsView.Items.Clear();
            MainWindowForWork.AllAgentsView.ItemsSource = AllAgents;
            MainWindowForWork.AllAgentsView.Items.Refresh();

        }

        public void SortAllAgentsView()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.Agents.OrderBy(x => x.FullAgentsName).ToList();
                MainWindowForWork.AllAgentsView.ItemsSource = null;
                MainWindowForWork.AllAgentsView.ItemsSource = result;
                MainWindowForWork.AllAgentsView.Items.Refresh();
            }
        }

        private void UpdateAllBranchView()
        {
            AllBranch = DataWorker.GetAllBranches();
            MainWindowForWork.AllBranchView.ItemsSource = null;
            MainWindowForWork.AllBranchView.Items.Clear();
            MainWindowForWork.AllBranchView.ItemsSource = AllBranch;
            MainWindowForWork.AllBranchView.Items.Refresh();

        }
        private void UpdateAllUsersView()
        {
            AllUsers = DataWorker.GetAllUsers();
            MainWindowForWork.AllUsersView.ItemsSource = null;
            MainWindowForWork.AllUsersView.Items.Clear();
            MainWindowForWork.AllUsersView.ItemsSource = AllUsers;
            MainWindowForWork.AllUsersView.Items.Refresh();

        }
        private void UpdateAllContractsView()
        {
            AllContracts = DataWorker.GetAllContracts();
            MainWindowForWork.AllContractsView.ItemsSource = null;
            MainWindowForWork.AllContractsView.Items.Clear();
            MainWindowForWork.AllContractsView.ItemsSource = AllContracts;
            MainWindowForWork.AllContractsView.Items.Refresh();

        }
        private void UpdateAllHealthInsuranceView()
        {
            AllHealthInsurance = DataWorker.GetAllHealthInsurance();
            MainWindowForWork.AllHealthInsuranceView.ItemsSource = null;
            MainWindowForWork.AllHealthInsuranceView.Items.Clear();
            MainWindowForWork.AllHealthInsuranceView.ItemsSource = AllHealthInsurance;
            MainWindowForWork.AllHealthInsuranceView.Items.Refresh();

        }
        private void UpdateAllInsuranceClaimView()
        {
            AllInsuranceClaims = DataWorker.GetAllInsuranceClaims();
            MainWindowForWork.AllInsuranceClaimView.ItemsSource = null;
            MainWindowForWork.AllInsuranceClaimView.Items.Clear();
            MainWindowForWork.AllInsuranceClaimView.ItemsSource = AllInsuranceClaims;
            MainWindowForWork.AllInsuranceClaimView.Items.Refresh();

        }
        private void UpdateAllPaymentsView()
        {
            AllPayment = DataWorker.GetAllPayments();
            MainWindowForWork.AllPaymentsView.ItemsSource = null;
            MainWindowForWork.AllPaymentsView.Items.Clear();
            MainWindowForWork.AllPaymentsView.ItemsSource = AllPayment;
            MainWindowForWork.AllPaymentsView.Items.Refresh();

        }
        private void UpdateAllPolicyView()
        {
            AllPolicy = DataWorker.GetAllPolicy();
            MainWindowForWork.AllPolicyView.ItemsSource = null;
            MainWindowForWork.AllPolicyView.Items.Clear();
            MainWindowForWork.AllPolicyView.ItemsSource = AllPolicy;
            MainWindowForWork.AllPolicyView.Items.Refresh();
        }
        private void UpdateAllPolicyTypeView()
        {
            AllPolicyType = DataWorker.GetAllPolicyType();
            MainWindowForWork.AllPolicyTypeView.ItemsSource = null;
            MainWindowForWork.AllPolicyTypeView.Items.Clear();
            MainWindowForWork.AllPolicyTypeView.ItemsSource = AllPolicyType;
            MainWindowForWork.AllPolicyTypeView.Items.Refresh();
        }
        private void UpdateAllPropertyView()
        {
            AllProperty = DataWorker.GetAllProperty();
            MainWindowForWork.AllPropertyView.ItemsSource = null;
            MainWindowForWork.AllPropertyView.Items.Clear();
            MainWindowForWork.AllPropertyView.ItemsSource = AllProperty;
            MainWindowForWork.AllPropertyView.Items.Refresh();
        }
        private void UpdateAllReviewView()
        {
            AllReview = DataWorker.GetAllReview();
            MainWindowForWork.AllReviewView.ItemsSource = null;
            MainWindowForWork.AllReviewView.Items.Clear();
            MainWindowForWork.AllReviewView.ItemsSource = AllReview;
            MainWindowForWork.AllReviewView.Items.Refresh();
        }
        private void UpdateAllVehicleView()
        {
            AllVehicle = DataWorker.GetAllVehicle();
            MainWindowForWork.AllVehicleView.ItemsSource = null;
            MainWindowForWork.AllVehicleView.Items.Clear();
            MainWindowForWork.AllVehicleView.ItemsSource = AllVehicle;
            MainWindowForWork.AllVehicleView.Items.Refresh();
        }
        private void UpdateAllVersionUpdateView()
        {
            AllVersionUpdate = DataWorker.GetAllVersionUpdate();
            MainWindowForWork.AllVersionUpdateView.ItemsSource = null;
            MainWindowForWork.AllVersionUpdateView.Items.Clear();
            MainWindowForWork.AllVersionUpdateView.ItemsSource = AllVersionUpdate;
            MainWindowForWork.AllVersionUpdateView.Items.Refresh();
        }
        #endregion

        private void SetCentralPositionAndOpen(Window window) 
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }

        
    }
}
