using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Курасач.Migrations;
using Курасач.View;

namespace Курасач.Models
{
    class DataWorker
    {
        //получить всех агентов
        public static List<Agent> GetAllAgents()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.Agents.OrderBy(a=>a.FullAgentsName).ToList();
                return result;
            }
        }

        //создать нового агента
        public static string CreateNewAgent(string fullName, string contactNumber, string email, DateTime date, string stat)
        {
            string result = "Такой агент уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool chechExist = db.Agents.Any(el => el.FullAgentsName == fullName);
                if (!chechExist)
                {
                    Agent newAgent = new Agent {
                        FullAgentsName = fullName,
                        ContactNumber = contactNumber,
                        Email = email,
                        HireDate = date,
                        Stat = stat
                    };
                    db.Add(newAgent);
                    db.SaveChanges();
                    result = "Агент успешно добавлен";
                }
            }
            return result;
        }

        //удалить агента
        public static string DeleteAgent(Agent agent)
        {
            string result = "Такого агента не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.Remove(agent);
                db.SaveChanges();
                result = "Агент " + agent.FullAgentsName + " удален!";
            }
            return result;
        }

        //изменить данные агента
        public static string EditAgent(Agent oldAgent, string NewfullName, string NewcontactNumber, string Newemail, DateTime Newdate, string Newstat)
        {
            string result = "Такого агента не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                Agent agent = db.Agents.FirstOrDefault(p => p.AgentId == oldAgent.AgentId);
                if (agent != null)
                {
                    agent.FullAgentsName = NewfullName;
                    agent.ContactNumber = NewcontactNumber;
                    agent.Email = Newemail;
                    agent.HireDate = Newdate;
                    agent.Stat = Newstat;
                    db.SaveChanges();
                    result = "Агент " + agent.FullAgentsName + "успешно изменен!";
                }
            }
            return result;
        }

        //получить все филлиалы
        public static List<Branch> GetAllBranches()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.Branches.OrderBy(a=> a.Name).ToList();
                return result;
            }
        }

        //добавить филлиал
        public static string CreateBranches(string name, string address, int employeeCount)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.Branches.Any(el => el.Name == name);
                if (!checkExist)
                {
                    Branch newBranch = new Branch { Name = name,
                        Address = address,
                        EmployeeCount = employeeCount };
                    db.Add(newBranch);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }

        //удалить филлиал
        public static string DeleteBranch(Branch branch)
        {
            string result = "Такого филлиала не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.Branches.Remove(branch);
                db.SaveChanges();
                result = "Филлиал " + branch.Address + " удален!";
            }
            return result;
        }

        //редактировать филлиал
        public static string EditBranch(Branch oldBranch, string newName, string newAddress, int newEmployeeCount)
        {
            string result = "Такого филлиала не существует!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                Branch branch = db.Branches.FirstOrDefault(p => p.Id == oldBranch.Id);
                if (branch != null)
                {
                    branch.Name = newName;
                    branch.Address = newAddress;
                    branch.EmployeeCount = newEmployeeCount;
                    db.SaveChanges();
                    result = "Филлиал " + branch.Name + "успешно изменен!";
                }
            }
            return result;
        }

        //получить всех пользователей
        public static List<CommonUser> GetAllUsers()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.CommonUsers.OrderBy(a=> a.FullName).ToList();
                return result;
            }
        }

        //добавление юзера
        public static string CreateCommonUser(string fullname, string address, string phoneNumber, int passportID, string passportNumber, int cardsNumber, string userLogin, string usersPassword, string usersMail)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.CommonUsers.Any(el =>
                                                     el.FullName == fullname &&
                                                     el.Address == address &&
                                                     el.PhoneNumber == phoneNumber &&
                                                     el.PassportId == passportID &&
                                                     el.PassportNumber == passportNumber &&
                                                     el.CardsNumber == cardsNumber &&
                                                     el.UsersLogin == userLogin &&
                                                     el.UsersPassword == usersPassword &&
                                                     el.UsersMail == usersMail);
                if (!checkExist)
                {
                    CommonUser newCommonUser = new CommonUser { FullName = fullname,
                        Address = address,
                        PhoneNumber = phoneNumber,
                        PassportId = passportID,
                        PassportNumber = passportNumber,
                        CardsNumber = cardsNumber,
                        UsersLogin = userLogin,
                        UsersPassword = usersPassword,
                        UsersMail = usersMail };
                    db.CommonUsers.Add(newCommonUser);
                    db.SaveChanges();
                    result = "Успешно";
                }

            }
            return result;
        }

        //удалить пользователя
        public static string DeleteCommonUsers(CommonUser user)
        {
            string result = "Не удалось удалить!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.CommonUsers.Remove(user);
                db.SaveChanges();
                result = "Готово!\nПользователь " + user.FullName + " удален!";
            }
            return result;
        }

        //редактировать пользователя
        public static string EditCommonUsers(CommonUser OldUser, string NewFullName, string Newaddress, string NewphoneNumber, int NewpassportID, string NewpassportNumber, int NewcardsNumber, string NewuserLogin, string NewusersPassword, string NewusersMail)
        {
            string result = "Такого пользователя не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                CommonUser user = db.CommonUsers.FirstOrDefault(p => p.Id == OldUser.Id);
                if (user != null)
                {
                    user.FullName = NewFullName;
                    user.Address = Newaddress;
                    user.PhoneNumber = NewphoneNumber;
                    user.PassportId = NewpassportID;
                    user.PassportNumber = NewpassportNumber;
                    user.CardsNumber = NewcardsNumber;
                    user.UsersLogin = NewuserLogin;
                    user.UsersPassword = NewusersPassword;
                    user.UsersMail = NewusersMail;

                    db.SaveChanges();
                    result = "Пользователь " + user.FullName + " изменен!";
                }
            }
            return result;
        }

        //получить все контакты
        public static List<Contact> GetAllContacts()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.Contacts.ToList();
                return result;
            }
        }

        //создать новый контакт
        public static string CreateContact(string nameOfMessager, string messageContacts)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.Contacts.Any(el => el.MessageContacts == messageContacts);
                if (!checkExist)
                {
                    Contact newContact = new Contact
                    {
                        NameOfMessager = nameOfMessager,
                        MessageContacts = messageContacts
                    };
                    db.Add(newContact);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }

        //удалить констакт
        public static string DeleteContact(Contact contact)
        {
            string result = "Такого контакта не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.Contacts.Remove(contact);
                db.SaveChanges();
                result = "Контакт " + contact.MessageContacts + " удален!";
            }
            return result;
        }

        //редактировать контакт
        public static string EditContact(Contact oldContact, string newNameOfMessager, string newMessageContacts)
        {
            string result = "Такого филлиала не существует!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                Contact contact = db.Contacts.FirstOrDefault(p => p.Id == oldContact.Id);
                if (contact != null)
                {
                    contact.NameOfMessager = newNameOfMessager;
                    contact.MessageContacts = newMessageContacts;
                    db.SaveChanges();
                    result = "Контакт " + contact.MessageContacts + "успешно изменен!";
                }
            }
            return result;
        }


        //получить все договора
        public static List<Contract> GetAllContracts()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.Contracts.OrderBy(a=> a.ContractDate).ToList();
                return result;
            }
        }

        //создать новый контакт
        //на подумать
        //сделать метод для поиска конкретного клиента через окно с вводом фио
        public static string CreateContract(int agentId, int clientId, DateTime contractDate, string terms)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.Contracts.Any(el => el.AgentId == agentId && el.ClientId == clientId);
                if (!checkExist)
                {
                    Contract newContract = new Contract
                    {
                        AgentId = agentId,
                        ClientId = clientId,
                        ContractDate = contractDate,
                        Terms = terms
                    };
                    db.Add(newContract);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }

        //удалить констакт
        public static string DeleteContract(Contract contract)
        {
            string result = "Такого контакта не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.Contracts.Remove(contract);
                db.SaveChanges();
                result = "Контракт № " + contract.Id + " удален!";
            }
            return result;
        }

        //редактировать договор
        public static string EditContract(Contract oldContact, int newAgentId, int newClientId, DateTime newContractDate, string newTerms)
        {
            string result = "Такого филлиала не существует!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                Contract contract = db.Contracts.FirstOrDefault(p => p.Id == oldContact.Id);
                if (contract != null)
                {
                    contract.AgentId = newAgentId;
                    contract.ClientId = newClientId;
                    contract.ContractDate = newContractDate;
                    contract.Terms = newTerms;
                    db.SaveChanges();
                    result = "Контракт №" + contract.Id + "успешно изменен!";
                }
            }
            return result;
        }

        //получить все страхования здоровья
        public static List<HealthInsurance> GetAllHealthInsurance()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.HealthInsurances.OrderBy(a=>a.CoverageLimit).ToList();
                return result;
            }
        }

        public static string CreateHealthInsurance(int clientId, string medicalConditions, Decimal coverageLimit)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.HealthInsurances.Any(el => el.ClientId == clientId && el.CoverageLimit == coverageLimit);
                if (!checkExist)
                {
                    HealthInsurance newHealthInsurance = new HealthInsurance
                    {
                        ClientId = clientId,
                        MedicalConditions = medicalConditions,
                        CoverageLimit = coverageLimit,
                    };
                    db.Add(newHealthInsurance);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }

        public static string DeleteHealthInsurance(HealthInsurance healthIns)
        {
            string result = "Такого контакта не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.HealthInsurances.Remove(healthIns);
                db.SaveChanges();
                result = "Страхование здоровья № " + healthIns.Id + " удалено!";
            }
            return result;
        }

        public static string EditHealthInsurance(HealthInsurance oldHealthInsurance, int newClientId, string newMedicalConditions, decimal newCoverageLimit)
        {
            string result = "Такой медицинской страховки не существует!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                HealthInsurance healthInsurance = db.HealthInsurances.FirstOrDefault(p => p.Id == oldHealthInsurance.Id);
                if (healthInsurance != null)
                {
                    healthInsurance.ClientId = newClientId;
                    healthInsurance.MedicalConditions = newMedicalConditions;
                    healthInsurance.CoverageLimit = newCoverageLimit;
                    db.SaveChanges();
                    result = "Медицинская страховка №" + healthInsurance.Id + "успешно изменена!";
                }
            }
            return result;
        }

        //получить все страхования жизни
        public static List<LifeInsurance> GetAllLifeInsurance()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.LifeInsurances.OrderBy(a=>a.ExpirationDate).ToList();
                return result;
            }
        }

        public static string CreateLifeInsurance(int clientId, Decimal insuredAmount, DateTime expirationDate)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.LifeInsurances.Any(el => el.ClientId == clientId && el.InsuredAmount == insuredAmount);
                if (!checkExist)
                {
                    LifeInsurance newLifeInsurance = new LifeInsurance
                    {
                        ClientId = clientId,
                        ExpirationDate = expirationDate,
                        InsuredAmount = insuredAmount,
                    };
                    db.Add(newLifeInsurance);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }

        public static string DeleteLifeInsurance(LifeInsurance El)
        {
            string result = "Такого страхования жизни не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.LifeInsurances.Remove(El);
                db.SaveChanges();
                result = "Страхование жизни № " + El.Id + " удалено!";
            }
            return result;
        }

        public static string EditLifeInsurance(LifeInsurance oldLifeInsurance, int newClientId, decimal newInsuredAmount, DateTime newExpirationDate)
        {
            string result = "Такой медицинской страховки не существует!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                LifeInsurance lifeInsurance = db.LifeInsurances.FirstOrDefault(p => p.Id == oldLifeInsurance.Id);
                if (lifeInsurance != null)
                {
                    lifeInsurance.ClientId = newClientId;
                    lifeInsurance.InsuredAmount = newInsuredAmount;
                    lifeInsurance.ExpirationDate = newExpirationDate;
                    db.SaveChanges();
                    result = "Страхование жизни №" + lifeInsurance.Id + "успешно изменено!";
                }
            }
            return result;
        }
        //получить все страховые случаи
        public static List<InsuranceClaim> GetAllInsuranceClaims()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.InsuranceClaims.OrderBy(a=>a.IncidentDate).ToList();
                return result;
            }
        }

        public static string CreateInsuranceClaim(int policyId, DateTime incidentDate, string description, string claimStatus)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.InsuranceClaims.Any(el => el.PolicyId == policyId && el.IncidentDate == incidentDate);
                if (!checkExist)
                {
                    InsuranceClaim newInsuranceClaim = new InsuranceClaim
                    {
                        PolicyId = policyId,
                        IncidentDate = incidentDate,
                        Description = description,
                        ClaimStatus = claimStatus
                    };
                    db.Add(newInsuranceClaim);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }

        public static string DeleteInsuranceClaim(InsuranceClaim El)
        {
            string result = "Такого контакта не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.InsuranceClaims.Remove(El);
                db.SaveChanges();
                result = "Страховой случай № " + El.Id + " удален!";
            }
            return result;
        }

        public static string EditInsuranceClaim(InsuranceClaim oldInsuranceClaim, int newPolicyId, DateTime newIncidentDate, string newDescription, string newClaimStatus)
        {
            string result = "Такой медицинской страховки не существует!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                InsuranceClaim insuranceClaim = db.InsuranceClaims.FirstOrDefault(p => p.Id == oldInsuranceClaim.Id);
                if (insuranceClaim != null)
                {
                    insuranceClaim.PolicyId = newPolicyId;
                    insuranceClaim.IncidentDate = newIncidentDate;
                    insuranceClaim.Description = newDescription;
                    insuranceClaim.ClaimStatus = newClaimStatus;
                    db.SaveChanges();
                    result = "Страховой случай №" + insuranceClaim.Id + "успешно изменен!";
                }
            }
            return result;
        }

        //получить все платежи
        public static List<Payment> GetAllPayments()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.Payments.OrderBy(a=>a.DateOfPay).ToList();
                return result;
            }
        }

        public static string CreatePayment(int idClients, int idPolices, decimal summa, DateTime dateOfPay, string typeOfPay)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.Payments.Any(el => el.IdClients == idClients && el.Summa == summa && el.DateOfPay == dateOfPay && el.IdPolices == idPolices);
                if (!checkExist)
                {
                    Payment newPayment = new Payment
                    {
                        IdClients = idClients,
                        IdPolices = idPolices,
                        Summa = summa,
                        DateOfPay = dateOfPay,
                        TypeOfPay = typeOfPay
                    };
                    db.Add(newPayment);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }

        public static string DeletePayment(Payment El)
        {
            string result = "Такого контакта не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.Payments.Remove(El);
                db.SaveChanges();
                result = "Выплата № " + El.IdPayment + " удален!";
            }
            return result;
        }

        public static string EditPayment(Payment oldPayment, int newIdClients, int newIdPolices, decimal newSumma, DateTime newDateOfPay, string newTypeOfPay)
        {
            string result = "Такой выплаты не существует!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                Payment payment = db.Payments.FirstOrDefault(p => p.IdPayment == oldPayment.IdPayment);
                if (payment != null)
                {
                    payment.IdClients = newIdClients;
                    payment.IdPolices = newIdPolices;
                    payment.Summa = newSumma;
                    payment.DateOfPay = newDateOfPay;
                    payment.TypeOfPay = newTypeOfPay;
                    db.SaveChanges();
                    result = "Выплата №" + payment.IdPayment + "успешно изменена!";
                }
            }
            return result;
        }

        //получить все полисы
        public static List<Policy> GetAllPolicy()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.Policies.OrderBy(a=>a.Stat).ToList();
                return result;
            }
        }

        public static string CreatePolicy(int clientId, string policyType, decimal coverageAmount, decimal premium, DateTime startDate, DateTime endDate, string stat)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.Policies.Any(el => el.ClientId == clientId && el.PolicyType == policyType && el.StartDate == startDate && el.EndDate == endDate);
                if (!checkExist)
                {
                    Policy newPolicy = new Policy
                    {
                        ClientId = clientId,
                        PolicyType = policyType,
                        CoverageAmount = coverageAmount,
                        Premium = premium,
                        StartDate = startDate,
                        EndDate = endDate,
                        Stat = stat
                    };
                    db.Add(newPolicy);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }
        public static string DeletePolicy(Policy El)
        {
            string result = "Такого контакта не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.Policies.Remove(El);
                db.SaveChanges();
                result = "Полис № " + El.PolicyId + " удален!";
            }
            return result;
        }

        public static string EditPolicy(Policy oldPolicy, int newClientId, string newPolicyType, decimal newCoverageAmount, decimal newPremium, DateTime newStartDate, DateTime newEndDate, string newStat)
        {
            string result = "Такой выплаты не существует!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                Policy policy = db.Policies.FirstOrDefault(p => p.PolicyId == oldPolicy.PolicyId);
                if (policy != null)
                {
                    policy.ClientId = newClientId;
                    policy.PolicyType = newPolicyType;
                    policy.CoverageAmount = newCoverageAmount;
                    policy.Premium = newPremium;
                    policy.StartDate = newStartDate;
                    policy.EndDate = newEndDate;
                    policy.Stat = newStat;
                    db.SaveChanges();
                    result = "Полис №" + policy.PolicyId + "успешно изменена!";
                }
            }
            return result;
        }

        //получить все типы полисов
        //da
        public static List<PolicyType> GetAllPolicyType()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.PolicyTypes.OrderBy(a=>a.Name).ToList();
                return result;
            }
        }

        public static string CreatePolicyType(string name, string description, Decimal basePrice)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.PolicyTypes.Any(el => el.Name.Equals(name) && el.BasePrice == basePrice);
                if (!checkExist)
                {
                    PolicyType newPolicyType = new PolicyType
                    {
                        Name = name,
                        Description = description,
                        BasePrice = basePrice,
                    };
                    db.Add(newPolicyType);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }

        //удалить тип полиса
        public static string DeletePolicyType(PolicyType El)
        {
            string result = "Такого контакта не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.PolicyTypes.Remove(El);
                db.SaveChanges();
                result = "Тип полиса № " + El.Id + " удален!";
            }
            return result;
        }

        //редактировать тип полиса
        public static string EditPolicyType(PolicyType oldPolicyType, string newName, string newDescription, decimal newBasePrice)
        {
            string result = "Такого филлиала не существует!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                PolicyType policyType = db.PolicyTypes.FirstOrDefault(p => p.Id == oldPolicyType.Id);
                if (policyType != null)
                {
                    policyType.Name = newName;
                    policyType.Description = newDescription;
                    policyType.BasePrice = newBasePrice;
                    db.SaveChanges();
                    result = "Тип полиса " + policyType.Id + "успешно изменен!";
                }
            }
            return result;
        }


        public static List<Review> GetAllReview()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.Reviews.OrderBy(a=>a.ReviewDate).ToList();
                return result;
            }
        }

        public static string CreateReview(int clientId, int rating, string comments, DateTime reviewDate)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.Reviews.Any(el => el.ClientId == clientId && el.Rating == rating);
                if (!checkExist)
                {
                    Review newReview = new Review
                    {
                        ClientId = clientId,
                        Rating = rating,
                        Comments = comments,
                        ReviewDate = reviewDate
                    };
                    db.Add(newReview);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }

        public static string DeleteReview(Review El)
        {
            string result = "Такого контакта не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.Reviews.Remove(El);
                db.SaveChanges();
                result = "Отзыв № " + El.Id + " удален!";
            }
            return result;
        }


        //получить всю недвижку
        public static List<Property> GetAllProperty()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.Properties.OrderBy(a=>a.PropertyType).ToList();
                return result;
            }
        }

        public static string CreateProperty(int clientId, string propertyType, string address, decimal insuredValue)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.Properties.Any(el => el.ClientId == clientId && el.InsuredValue == insuredValue);
                if (!checkExist)
                {
                    Property newProperty = new Property
                    {
                        ClientId = clientId,
                        PropertyType = propertyType,
                        Address = address,
                        InsuredValue = insuredValue
                    };
                    db.Add(newProperty);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }

        public static string DeleteProperty(Property El)
        {
            string result = "Такого контакта не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.Properties.Remove(El);
                db.SaveChanges();
                result = "Недвижимость № " + El.Id + " удалена!";
            }
            return result;
        }

        public static string EditProperty(Property oldProperty, int newClientId, string newPropertyType, string newAddress, decimal newInsuredValue)
        {
            string result = "Такого филлиала не существует!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                Property property = db.Properties.FirstOrDefault(p => p.Id == oldProperty.Id);
                if (property != null)
                {
                    property.ClientId = newClientId;
                    property.PropertyType = newPropertyType;
                    property.Address = newAddress;
                    property.InsuredValue = newInsuredValue;
                    db.SaveChanges();
                    result = "Недвижимость № " + property.Id + "успешно изменена!";
                }
            }
            return result;
        }

        //получить все транспортное средство
        public static List<Vehicle> GetAllVehicle()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.Vehicles.OrderBy(a=>a.Mark).ToList();
                return result;
            }
        }

        public static string CreateVehicle(int clientId, string mark, string model, int yearOfMade, string registrationNumber, decimal insuredValue)
        {
            string result = "Уже существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                bool checkExist = db.Vehicles.Any(el => el.ClientId == clientId && el.InsuredValue == insuredValue && el.YearOfMade == yearOfMade);
                if (!checkExist)
                {
                    Vehicle newVehicle = new Vehicle
                    {
                        ClientId = clientId,
                        Mark = mark,
                        Model = model,
                        YearOfMade = yearOfMade,
                        RegistrationNumber = registrationNumber,
                        InsuredValue = insuredValue
                    };
                    db.Add(newVehicle);
                    db.SaveChanges();
                    result = "Успешно!";
                }
            }
            return result;
        }

        public static string DeleteVehicle(Vehicle El)
        {
            string result = "Такого контакта не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.Vehicles.Remove(El);
                db.SaveChanges();
                result = "Транспорт № " + El.Id + " удален!";
            }
            return result;
        }

        public static string EditVehicle(Vehicle oldVehicle, int newClientId, string newMark, string newModel, int newYearOfMade, string newRegistrationNumber, decimal newInsuredValue)
        {
            string result = "Такого филлиала не существует!";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                Vehicle vehicle = db.Vehicles.FirstOrDefault(p => p.Id == oldVehicle.Id);
                if (vehicle != null)
                {
                    vehicle.ClientId = newClientId;
                    vehicle.Mark = newMark;
                    vehicle.Model = newModel;
                    vehicle.YearOfMade = newYearOfMade;
                    vehicle.RegistrationNumber = newRegistrationNumber;
                    vehicle.InsuredValue = newInsuredValue;
                    db.SaveChanges();
                    result = "Автомобиль № " + vehicle.Id + "успешно изменен!";
                }
            }
            return result;
        }

        //получить все обновления
        public static List<VersionUpdate> GetAllVersionUpdate()
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                var result = db.VersionUpdates.ToList();
                return result;
            }
        }

        //удалить обновление
        public static string DeleteVersionUpdate(VersionUpdate update)
        {
            string result = "Такого обновления не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                db.VersionUpdates.Remove(update);
                db.SaveChanges();
                result = "Обновление номер " + update.NumberOfUpdate + " удалено!";
            }
            return result;
        }

        //редактировать Обновление
        /*        public static string EditUpdateVersion(VersionUpdate oldVersion, DateOnly newDateOfUpdate, string newContentUpdate)
                {
                    string result = "Такого обновления не существует!";
                    using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
                    {
                        VersionUpdate update = db.VersionUpdates.FirstOrDefault(p => p.NumberOfUpdate == oldVersion.NumberOfUpdate);
                        if (update != null)
                        {
                            update.DateOfUpdate = newDateOfUpdate;
                            update.ContentUpdate = newContentUpdate;
                            db.SaveChanges();
                            result = "Обновление номер " + update.NumberOfUpdate + " успешно изменено!";
                        }
                    }
                    return result;
                }*/
        public static string Sign_UpMethod(string usersLogin, string usersPassword)
        {
            string result = "Такого пользователя не существует";
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                CommonUser user = db.CommonUsers.FirstOrDefault(p => p.UsersLogin == usersLogin && p.UsersPassword == usersPassword);
                if (user != null)
                {
                    result = "Вход выполнен успешно!";
                    MainWindowForWork MainWnd = new MainWindowForWork();
                    MainWnd.Show();
                }
            }
            MessageBox.Show(result, "Заголовок окна", MessageBoxButton.OK, MessageBoxImage.Information);
            return result;
        }

        public static List<CommonUser> GetAllContractByUsersId(int id)
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                List<CommonUser> contracts = (from contract in GetAllUsers() where contract.Id == id select contract).ToList();
                return contracts;
            }
        }

        public static List<CommonUser> GetAllUsersForHealth(int id)
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                List<CommonUser> user = (from health in GetAllUsers() where health.Id == id select health).ToList();
                return user;
            }
        }
        public static CommonUser GetAllUsersNameForContract(int id)
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                CommonUser user = db.CommonUsers.FirstOrDefault(p => p.Id == id);
                return user;
            }
        }

        public static CommonUser GetAllUsersNameForLife(int id)
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                CommonUser user = db.CommonUsers.FirstOrDefault(p => p.Id == id);
                return user;
            }
        }
        public static CommonUser GetAllUsersNameForVehicle(int id)
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                CommonUser user = db.CommonUsers.FirstOrDefault(p => p.Id == id);
                return user;
            }
                
        }

        public static Agent GetAllAgentsNameForContract(int id)
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                Agent agent = db.Agents.FirstOrDefault(p => p.AgentId == id);
                return agent;
            }
        }

        public static CommonUser GetAllUsersNameForProperty(int id)
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                CommonUser agent = db.CommonUsers.FirstOrDefault(p => p.Id == id);
                return agent;
            }
        }

        public static CommonUser GetAllUsersLoginForReview(int id)
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                CommonUser user = db.CommonUsers.FirstOrDefault(p => p.Id == id);
                return user;
            }
        }

        public static Policy GetAllPolicyNameForClaim(int id)
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                Policy policy = db.Policies.FirstOrDefault(p => p.PolicyId == id);
                return policy;
            }
        }
        public static CommonUser GetAllClientNameForPayment(int id)
        {
            using (InsuranceAgencyDbContext db = new InsuranceAgencyDbContext())
            {
                CommonUser user = db.CommonUsers.FirstOrDefault(p => p.Id == id);
                return user;
            }
        }
    }
}
