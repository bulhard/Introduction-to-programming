using Lesson_08_Interfaces.Interfaces;
using System;

namespace Lesson_08_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            FinancialTransaction tran1 = new FinancialTransaction();

            NonFinnancialTransaction tran2 = new NonFinnancialTransaction();

            DisplayTransaction(tran1);

            DisplayTransaction(tran2);


            TransactionA transactionA = new TransactionAConcrete();
        }

        static void DisplayTransaction(ITransactions transaction)
        {
            transaction.showTransaction();

            Console.WriteLine(transaction);
        }
    }
}
