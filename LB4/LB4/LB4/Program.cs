using LB4;

Console.WriteLine("Выполнил студент группы 453502, Бибиков Максим Алексеевич, Вариант 15/5");

BanksManager banksManager = BanksManager.GetInstance();

bool debugMode = false;
DebugModeAsking();

if(debugMode) DebugModeAction();

Console.WriteLine("######################################## BANK PROGRAM ########################################");

while (true)
{
    banksManager.ShowMenu();
    int choice = IO.ReadInteger("Input choice number: ");
    switch (choice)
    {
        case 1:
            banksManager.ShowBanksList();
            BanksManager.ToContinue();
            break;
        case 2:
            banksManager.AddBank();
            BanksManager.ToContinue();
            break;
        case 3:
            banksManager.DeleteBank();
            BanksManager.ToContinue();
            break;
        case 4:
            banksManager.GetBankInfo();
            BanksManager.ToContinue();
            break;
        case 5:
            var bank = banksManager.AccessBank();
            if (bank == null)
            {
                BanksManager.ToContinue();
                break;
            }
            BanksManager.ToContinue();
            bank.SwitchCaseForMenu();
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Incorret input! Try again");
            BanksManager.ToContinue();
            continue;
    }
}

void DebugModeAsking()
{
    string str = IO.ReadString("Turn on Debug Mode?(y/n)");
    if (str.ToLower() == "y")
    {
        debugMode = true;
    }
}

void DebugModeAction()
{
    Bank sberbank = new Bank("Sberbank", 1000000, 5.5);
    sberbank.AddDepositAccount("John Doe", 50000);
    sberbank.AddDepositAccount("Jane Smith", 75000);
    sberbank.AddDepositAccount("Alice Johnson", 120000);
    banksManager.AddBank(sberbank);
    
    Bank vtb = new Bank("VTB", 2000000, 6.0);
    vtb.AddDepositAccount("Michael Brown", 100000);
    vtb.AddDepositAccount("Emily Davis", 250000);
    banksManager.AddBank(vtb);
    
    Bank alpha = new Bank("Alpha Bank", 500000, 4.8);
    alpha.AddDepositAccount("David Wilson", 30000);
    alpha.AddDepositAccount("Sarah Taylor", 45000);
    alpha.AddDepositAccount("James Miller", 80000);
    banksManager.AddBank(alpha); 

    Console.WriteLine("Test data initialized!");
}




