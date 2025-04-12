namespace LB4;

public class Bank
{
    public class DepositAccount
    {
        public string FIO { get; }
        public double Balance { get; private set; }
        public double Percentage { get; private set; }

        public DepositAccount(string fio, double balance, double percentage)
        {
            FIO = fio;
            Balance = balance;
            Percentage = percentage;
        }

        public void AccountInfo()
        {
            Console.WriteLine("Account Information:");
            Console.WriteLine($"FIO:{FIO}");
            Console.WriteLine($"Balance:{Balance}");
            Console.WriteLine($"Percentage:{Percentage}");
            
        }
        
        public void AddBalance(double amount)
        {
            Balance += amount;
            if (amount < 0)
                Console.WriteLine($"{amount}$ withdrew from your account");
            else if (amount > Balance)
            {
                Console.WriteLine($"Account balance less than {amount}$!");
            }else
                Console.WriteLine($"{amount}$ added to your account");
        }

        public void ChangePercentage(double percentage)
        {
            Percentage = percentage;
            Console.WriteLine($"New percentage: {Percentage}%");
        }

        public void CalculateAmountWithPercentage()
        {
            double amount = Balance * ((Percentage / 100) + 1);
            Console.WriteLine($"Annual amount with {Percentage}%: {amount}$");
        }

        public void ShowMenu()
        {
            Console.WriteLine($"\n{FIO} Account");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Account information");
            Console.WriteLine("2. Change account balance");
            Console.WriteLine("3. Change account percentage");
            Console.WriteLine("4. Calculate percentage balance");
            Console.WriteLine("5. Exit");
            Console.WriteLine("-------------------------\n");
        }
        
        public void SwitchCaseForAccount()
        {
            bool exitBool = false;
            while (exitBool == false)
            {
                ShowMenu();
                int choiceAccount = IO.ReadInteger("Input choice number: ");
            
                switch (choiceAccount)
                {
                    case 1:
                        AccountInfo();
                        BanksManager.ToContinue();
                        break;
                    case 2:
                        double balance = IO.ReadDouble("Enter balance: ");
                        AddBalance(balance);
                        BanksManager.ToContinue();
                        break;
                    case 3:
                        double percentage = IO.ReadDouble("Enter percentage: ");
                        ChangePercentage(percentage);
                        BanksManager.ToContinue();
                        break;
                    case 4:
                        CalculateAmountWithPercentage();
                        BanksManager.ToContinue();
                        break;
                    case 5:
                        Console.WriteLine("Exiting Account Menu...\n");
                        exitBool = true;
                        break;
                    default:
                        Console.WriteLine("Incorret input! Try again");
                        BanksManager.ToContinue();
                        continue;
                }
            }
        }
    }
    
    public string Name { get; set; }
    public double MaxDepositAmount { get; set; }
    public double Percentage { get; set; }
    private List<DepositAccount> DepositAccounts = new List<DepositAccount>();

    public Bank(string name, double maxDepositAmount, double percentage, int amountOfAccounts = 0)
    {
        Name = name;
        MaxDepositAmount = maxDepositAmount;
        Percentage = percentage;
    }

    public void AmountOfDepositAccounts()
    {
        Console.WriteLine($"Total amount of deposit accounts: {DepositAccounts.Count}");
        for (int i = 0; i < DepositAccounts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {DepositAccounts[i].FIO}");
        }
    }

    public void GetBankPercantage()
    {
        Console.WriteLine($"Deposit percantage is {Percentage}%");
    }

    public void ChangeBankPercantage()
    {
        double percantage = IO.ReadDouble("Input new bank percantage: ");
        Percentage = percantage;
    }

    public void AddDepositAccount()
    {
        string? fio = IO.ReadString("Input new deposit FIO: ");
        double balance = IO.ReadDouble("Balance amount in $: ");
        if (balance > MaxDepositAmount)
        {
            Console.WriteLine("Deposit account is too big!");
            return;
        }
        
        DepositAccounts.Add(new DepositAccount(fio, balance, Percentage));
        Console.WriteLine($"Deposit account with FIO {fio} added to the bank system");
    }
    
    public void AddDepositAccount(string fio, double balance)
    {
        DepositAccounts.Add(new DepositAccount(fio, balance, Percentage));
    }

    public void DeleteDepositAccount()
    {
        string? fio = IO.ReadString("Input deposit FIO to delete: ");
        for(int i = 0; i < DepositAccounts.Count; ++i)
        {
            if (DepositAccounts[i].FIO == fio)
            {
                DepositAccounts.RemoveAt(i);
                return;
            }
        }
        Console.WriteLine("Account not found!");
    }
    
    public DepositAccount AccessDepositAccount()
    {
        string? fio = IO.ReadString("Input deposit FIO to access: ");
        for(int i = 0; i < DepositAccounts.Count; ++i)
        {
            if (DepositAccounts[i].FIO == fio)
            {
                return DepositAccounts[i];
            }
        }
        Console.WriteLine("Account not found!");
        return null;
    }
    
    public void ShowMenu()
    {
        Console.WriteLine($"\n{Name} Main Menu");
        Console.WriteLine("-------------------------");
        Console.WriteLine("1. Amount of deposit accounts");
        Console.WriteLine("2. Get bank percentage");
        Console.WriteLine("3. Change bank percentage");
        Console.WriteLine("4. Add deposit account");
        Console.WriteLine("5. Delete deposit account");
        Console.WriteLine("6. Access specific deposit account");
        Console.WriteLine("7. Exit");
        Console.WriteLine("-------------------------\n");
    }
    
    public void SwitchCaseForMenu()
    {
        bool exitBool = false;
        while (exitBool == false)
        {
            ShowMenu();
            int choiceBankMenu = IO.ReadInteger("Input choice number: ");
            
            switch (choiceBankMenu)
            {
                case 1:
                    AmountOfDepositAccounts();
                    BanksManager.ToContinue();
                    break;
                case 2:
                    GetBankPercantage();
                    BanksManager.ToContinue();
                    break;
                case 3:
                    ChangeBankPercantage();
                    BanksManager.ToContinue();
                    break;
                case 4:
                    AddDepositAccount();
                    BanksManager.ToContinue();
                    break;
                case 5:
                    DeleteDepositAccount();
                    BanksManager.ToContinue();
                    break;
                case 6:
                    var account = AccessDepositAccount();
                    if (account == null)
                    {
                        BanksManager.ToContinue();
                        break;
                    }
                    BanksManager.ToContinue();
                    account.SwitchCaseForAccount();
                    break;
                case 7:
                    Console.WriteLine("Exiting Bank Menu...\n");
                    exitBool = true;
                    break;
                default:
                    Console.WriteLine("Incorret input! Try again");
                    BanksManager.ToContinue();
                    continue;
            }
        }
    }
}