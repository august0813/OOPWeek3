// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        //creating an object (variable of a cetain class type)
        Transaction transaction = new Transaction();

        transaction.setDate(new DateTime(2008, 6, 1));
        transaction.setVal(10.5f);

        Console.WriteLine("Transaction value is " + transaction.getVal() + 
            " at time " + transaction.getDate().ToString());
    }

}
