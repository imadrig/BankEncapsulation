namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();


            Console.WriteLine("How much would you like to deposit today?");
            double userDeposit = double.Parse(Console.ReadLine());

            account1.Deposit(userDeposit);
         

            Console.WriteLine($"Thank you, your balance is: ${account1.GetBalance()}");

        }
    }
}
