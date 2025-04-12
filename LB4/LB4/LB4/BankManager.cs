namespace LB4;

public class BanksManager
{
    private static BanksManager _instance;
    private List<Bank> Banks = new List<Bank>();
    
    public static BanksManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new BanksManager();
        }

        return _instance;
    }
    
    public void ShowMenu()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("1. Bank List");
        Console.WriteLine("2. Add Bank");
        Console.WriteLine("3. Remove Bank");
        Console.WriteLine("4. Bank Information");
        Console.WriteLine("5. Access Bank Management");
        Console.WriteLine("6. Exit");
        Console.WriteLine("-------------------------\n");
    }
    
    static public void ToContinue()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
    
    public void AddBank()
    {
        string? name = IO.ReadString("Enter bank name: ");
        double deposit = IO.ReadDouble("Max deposit amount in $: ");
        double percentage = IO.ReadDouble("Percentage deposit amount in %: ");
    
        Banks.Add(new Bank(name, deposit, percentage));     
    }
    
    public void AddBank(Bank bank)
    {
        Banks.Add(bank);     
    }
    
    public void DeleteBank()
    {
        string? name = IO.ReadString("Input Bank name to delete: ");
        for(int i = 0; i < Banks.Count; ++i)
        {
            if (Banks[i].Name == name)
            {
                Banks.RemoveAt(i);
                Console.WriteLine("Bank deleted");
                return;
            }
        }
        Console.WriteLine("Bank not found!");
    }

    public void ShowBanksList()
    {
        Console.WriteLine("\nBanks connected to system:");
        if (Banks.Count == 0)
        {
            Console.WriteLine("No banks connected to system.");
            return;
        }

        for (int i = 0; i < Banks.Count; i++)
        {
            Console.WriteLine($"{i+1}. {Banks[i].Name}");
        }
    }

    public void GetBankInfo()
    {
        string? name = IO.ReadString("Input Bank name to gather information: ");
        for(int i = 0; i < Banks.Count; ++i)
        {
            if (Banks[i].Name == name)
            {
                Console.WriteLine($"Bank: {Banks[i].Name}");
                Console.WriteLine($"Max Deposit: {Banks[i].MaxDepositAmount}$");
                Console.WriteLine($"Percentage: {Banks[i].Percentage}%");
                return;
            }
        }
        Console.WriteLine("\nBank not found!");
    }

    public Bank AccessBank()
    {
        string? name = IO.ReadString("Input Bank name to access: ");
        for (int i = 0; i < Banks.Count; ++i)
        {
            if (Banks[i].Name == name)
            {
                Console.WriteLine($"Access granted!");
                return Banks[i];
            }
        }
        Console.WriteLine("\nBank not found!");
        return null;
    }
}