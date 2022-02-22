class Bank {
    public int account_no;
    public String account_holder_name;
    public double avaliable_balance;

    public Bank(int acc_no, String acc_name, double ava_bal) {
        this.account_no = acc_no;
        this.account_holder_name = acc_name;
        this.avaliable_balance = ava_bal;
    }
}

public delegate void WatchBalance(double n);

class Assignment {

    public static void checkBalance(double bal) {
        if(bal < 0) {
            Console.WriteLine("You are overdrawn");
        } else if (bal < 10) {
            Console.WriteLine("Your account balance is very low");
        } else if (bal < 100) {
            Console.WriteLine("Watch your spending carefully.");
        } else {
            Console.WriteLine("You have over $10 in your account");
        }
    }

    static void Main() {

        WatchBalance watch = checkBalance;
        Bank ac1 = new Bank(200012232,"Darpan",1000);
        watch(ac1.avaliable_balance);
        Console.WriteLine("Mr. " + ac1.account_holder_name + " your current balance is " + ac1.avaliable_balance);

        Console.WriteLine("*********************");

        Bank ac2 = new Bank(200012255,"Micheal",2000);
        watch(ac2.avaliable_balance);
        Console.WriteLine("Mr. " + ac2.account_holder_name + " your current balance is " + ac2.avaliable_balance);

        Console.WriteLine("*********************");

        Bank ac3 = new Bank(200012222,"Trevor",3000);
        watch(ac3.avaliable_balance);
        Console.WriteLine("Mr. " + ac3.account_holder_name + " your current balance is " + ac3.avaliable_balance);

        Console.WriteLine("*********************");

        Bank ac4 = new Bank(200012291,"Franklin",4000);
        watch(ac4.avaliable_balance);
        Console.WriteLine("Mr. " + ac4.account_holder_name + " your current balance is " + ac4.avaliable_balance);

    }
}
