using System;
using System.Collections.Generic;
using System.Text;

namespace Task03.ATMClasses
{
    public class ATM
    {
        // This method starts the ATM
        public static void Start()
        {
            ChooseOption();
        }

        // This method is for choosing option Login / Register - main menu
        public static void ChooseOption()
        {
            while (true)
            {
                Console.Clear();
                WelcomeMessage();

                Console.WriteLine(" ------------------------");
                Console.WriteLine("|       1. Log in        |");
                Console.WriteLine("|       2. Register      |");
                Console.WriteLine(" ------------------------\n");

                Console.Write("Please enter your option: ");

                bool checkUserInput = int.TryParse(Console.ReadLine(), out int checkedNumber);
                if (checkUserInput)
                {
                    if (checkedNumber == 1)
                    {
                        Login();
                        break;
                    }
                    else if (checkedNumber == 2)
                    {
                        Register();
                        break;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Write("Wrong input, please enter 1 or 2: ");
                            string userChoise = Console.ReadLine();
                            if (userChoise.ToLower() == "1")
                            {
                                Login();
                                break;
                            }
                            else if (userChoise.ToLower() == "2")
                            {
                                Register();
                                break;
                            }
                            else
                            {
                                continue;
                            }

                        }
                    }  
                }
            }
            
        }

        // Print welcome message
        public static void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("****Welcome to the ATM app****");
            Console.ResetColor();
        }

        // Print greeting message
        public static void GreetingMessage(Customer customer)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"*********Welcome {customer.PrintFullName()}********");
            Console.ResetColor();
        }

        // Print goodbye message
        public static void GoodbyeMessage(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"*********Goodbye {customer.PrintFullName()}********");
            Console.ResetColor();
        }

        // Register (for new users)
        public static void Register()
        {
            List<Customer> customers = ATMUsers();

            Console.Clear();
            WelcomeMessage();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" -------------------");
            Console.WriteLine("| Registration form |");
            Console.WriteLine(" -------------------");

            Console.Write("1. Please enter your name: ");
            string firstNameInput = Console.ReadLine();
            bool checkFirstName = IsValidString(firstNameInput);

            Console.Write("2. Please enter your last name: ");
            string lastNameInput = Console.ReadLine();
            bool checkLastName = IsValidString(lastNameInput);

            if (checkFirstName && checkLastName)
            {
                Console.WriteLine("3. Please enter you card number");
                Console.Write("(16-digits) format (####-####-####-####): ");
                string[] filterCardNo = Console.ReadLine().Split("-");
                string cardNoInp = String.Join("", filterCardNo);
                bool checkCardNo = long.TryParse(cardNoInp, out long cardNo);

                if (checkCardNo)
                {
                    if (ValidateCardNumber(customers, cardNo))
                    {
                        Console.Write("4. Please enter your new PIN (4-digits): ");
                        bool checkPIN = int.TryParse(Console.ReadLine(), out int pinInput);
                        Console.ResetColor();
                        if (checkPIN)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("5. Please enter money on your acc so we can start it up: ");
                            bool checkBalance = int.TryParse(Console.ReadLine(), out int balanceInput);
                            Console.ResetColor();
                            if (checkBalance)
                            {
                                Customer newCustomer = new Customer(firstNameInput, lastNameInput, cardNo, pinInput, balanceInput);
                                customers.Add(newCustomer);
                                GenerateMenu(newCustomer);
                                return;
                            }
                        }
                    }
                }
            }
        }

        // Login Method
        public static void Login()
        {
            Console.Clear();
            WelcomeMessage();

            List<Customer> customers = ATMUsers();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(">>>Please enter your card number");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The cardNo should be entered like this format:");
            Console.Write("Card No: ####-####-####-####: ");
            Console.ResetColor();

            string[] filteredString = Console.ReadLine().Split("-");
            string cardNoString = String.Join("", filteredString);
            bool checkUserInput = long.TryParse(cardNoString, out long cardNoInput);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(">>>Please enter your PIN: ");
            Console.ResetColor();

            bool checkPINInput = int.TryParse(Console.ReadLine(), out int pinInput);

            if (checkUserInput && checkPINInput)
            {
                ValidateUser(customers, cardNoInput, pinInput);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter card number and PIN with NUMBERS!!!");
                Console.ResetColor();
            }
        }

        // Validates if the cardNo is already used or not
        public static bool ValidateCardNumber(List<Customer> customers, long cardInput)
        {

            foreach (var customer in customers)
            {
                if (cardInput == customer.CardNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Card number already used. Please select new one!");
                    Console.ResetColor();
                    return false;
                }
            }
            return true;
        }

        // Validates customers via CardNo and Pass from the customerList
        public static void ValidateUser(List<Customer> customers, long cardInput, int pinCode)
        {
            foreach (var customer in customers)
            {
                if (cardInput == customer.CardNumber && pinCode == customer.AccessPin())
                {
                    Customer currentCustomer = customer;

                    GenerateMenu(currentCustomer);
                    return;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong card number or PIN !");
            Console.ResetColor();
        }

        // Validates if the string is valid string
        public static bool IsValidString(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (!char.IsLetter(inputString[i]))
                        return false;
                    if (!char.IsWhiteSpace(inputString[i]))
                    {
                        return true;
                    }
                }
                return true;
            }
        }

        // This method is for choosing option Check Balance / Cash Withdrawal / Cash Deposit - Login menu
        public static void GenerateMenu(Customer customer)
        {
            GreetingMessage(customer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ----------------------------------");
            Console.WriteLine("|    What would you like to do:    |");
            Console.WriteLine("|                                  |");
            Console.WriteLine("|       1. Check Balance           |");
            Console.WriteLine("|       2. Cash Withdrawal         |");
            Console.WriteLine("|       3. Cash Deposit            |");
            Console.WriteLine(" ----------------------------------\n");

            Console.Write("Please enter your option: ");
            Console.ResetColor();

            bool checkUserOpinion = int.TryParse(Console.ReadLine(), out int userOpinion);
            if (checkUserOpinion)
            {
                switch (userOpinion)
                {
                    case 1:
                        customer.PrintBalance();
                        AnotherTransaction(customer);
                        break;
                    case 2:
                        double cashToWithdraw = TakeCashInputToWithdraw();
                        customer.CashWithdrawal(cashToWithdraw);
                        AnotherTransaction(customer);
                        break;
                    case 3:
                        double cashToDeposit = TakeCashInputToDeposit();
                        customer.CashDepositon(cashToDeposit);
                        AnotherTransaction(customer);
                        break;
                    default:
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please choose option 1 , 2 or 3 !");
                            Console.ResetColor();
                            string userChoise = Console.ReadLine();
                            if(userChoise == "1")
                            {
                                customer.PrintBalance();
                                AnotherTransaction(customer);
                                break;
                            }
                            else if (userChoise == "2")
                            {
                                double cashToWithdraw2 = TakeCashInputToWithdraw();
                                customer.CashWithdrawal(cashToWithdraw2);
                                AnotherTransaction(customer);
                                break;
                            }
                            else if(userChoise == "3")
                            {
                                double cashToDeposit2 = TakeCashInputToDeposit();
                                customer.CashDepositon(cashToDeposit2);
                                AnotherTransaction(customer);
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                        
                }
            }
            else
            {
                
            }
        }

        // Asking user if he want to do another action or exit to the main menu
        public static void AnotherTransaction(Customer customer)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Press Y if you want to do another transaction \nor X if you want to EXIT: ");
                Console.ResetColor();

                string userOpinion = Console.ReadLine();

                if (userOpinion.ToLower() == "y")
                {
                    GenerateMenu(customer);
                    continue;
                }
                else if (userOpinion.ToLower() == "x")
                {
                    GoodbyeMessage(customer);
                    ChooseOption();
                    return;
                }
                else
                {
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Wrong input, please enter Y or X: ");
                        Console.ResetColor();
                        string userChoise = Console.ReadLine();
                        if (userChoise.ToLower() == "y")
                        {
                            break;
                        }
                        else if (userChoise.ToLower() == "x")
                        {
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }

        // Method for taking input from user how much money to withdraw
        public static double TakeCashInputToWithdraw()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the ammount you want to withdraw: ");
            Console.ResetColor();

            bool checkCashToWithdraw = double.TryParse(Console.ReadLine(), out double cashWithdraw);
            if (!checkCashToWithdraw)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter ammount of money with numbers!");
                Console.ResetColor();
            }
            return cashWithdraw;
        }

        // Method for taking input from user how much money to deposit
        public static double TakeCashInputToDeposit()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the ammount you want to deposit: ");
            Console.ResetColor();

            bool checkCashToDeposit = double.TryParse(Console.ReadLine(), out double cashDeposit);
            if (!checkCashToDeposit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter ammount of money with numbers!");
                Console.ResetColor();
            }
            return cashDeposit;
        }

        // Method for generating customers
        public static List<Customer> ATMUsers()
        {
            Customer customer01 = new Customer("Bob", "Bobsky", 1111111111111111, 1111, 1000.00);
            Customer customer02 = new Customer("John", "Johnsky", 1111222222222222, 1222, 5000.00);
            Customer customer03 = new Customer("Greg", "Gregsky", 1111333333333333, 1333, 1250.00);
            Customer customer04 = new Customer("Tom", "Tomsky", 1111444444444444, 1444, 2000.00);
            Customer customer05 = new Customer("Bill", "Billsky", 1111555555555555, 1555, 2500.00);

            List<Customer> customers = new List<Customer>
            {
                customer01,customer02,customer03,customer04,customer05
            };

            return customers;
        }

    }
}
