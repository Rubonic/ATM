using System;

public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(String cardNum, int pin, String firstName, String lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getCardNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void getCardNum(String cardNum)
    {
        cardNum = cardNum;
    }

    public void getPin(int pin)
    {
        pin = pin;
    }

    public void getFirstName(String firstName)
    {
        firstName = firstName;
    }

    public void getLastName(String lastName)
    {
        lastName = lastName;
    }

    public void getBalance(double balance)
    {
        balance = balance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("Please enter the amount you would like to deposit...");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you for your deposit. Your new balance is: " + currentUser.getBalance());
        }

        void Withdraw(cardHolder currentUser)
        {
            Console.WriteLine("Please enter the amount you would like to withdraw...");
            double withdrawal = Double.Parse(Console.ReadLine());
            //Check if the user has enough money to withdraw
            if(currentUser.setBalance() > withdrawal);
            {
                Console.WriteLine("Insufficient funds. Please try again.");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("You are all set! Thank You :)");
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current Balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolder = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4532772818527395", 1234, "Rias", "Gremory", 150000.65));
        cardHolders.Add(new cardHolder("9527712355527395", 4987, "Issei", "Hyoudou", 500.15));
        cardHolders.Add(new cardHolder("7751552818527395", 2345, "Akeno", "Himejima", 999956.65));
        cardHolders.Add(new cardHolder("8542772818524547", 9874, "Kiba", "Yuuto", 25.85));
        cardHolders.Add(new cardHolder("1532772814527395", 6280, "Xenovia", "Quarta", 1000.01));
        cardHolders.Add(new cardHolder("3532772818527395", 3647, "Asia", "Argento", 15.00));

        // Prompt user
        Console.WriteLine("Welcome to the ATM!");
        Console.WriteLine("Please enter your card number...");
        String debitCardNum = "";
        cardHolder currentUser;

        // Check if the card number is valid
        while(true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                // Check against all the card numbers in the list
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Invalid card number. Please try again."); }
            }
            catch (Console.WriteLine("Invalid card number. Please try again.");)
        }

        Console.WriteLine("Please enter your PIN...");
        int userPin = 0;
        while(true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                // Check against all the card numbers in the list
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Invalid pin. Please try again."); }
            }
            catch {Console.WriteLine("Invalid pin. Please try again."); }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstName() + " :)");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(console.ReadLine());
            }
            catch {  }
            if(option == 1) { deposit(currentUser); }
            else if(option == 2) { withdraw(currentUser, depositCardNum); }
            else if(option == 3) { balance(currentUser); }
            else if(option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you for using the ATM!");
    }

}