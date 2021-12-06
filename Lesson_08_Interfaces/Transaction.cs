using Lesson_08_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08_Interfaces
{
    public class FinancialTransaction : ITransactions
    {
        public double getAmount()
        { 
            throw new NotImplementedException();
        }

        public void showTransaction()
        {
            throw new NotImplementedException();
        }
    }


    public class NonFinnancialTransaction : ITransactions
    {
        
        public double getAmount()
        {
            throw new NotImplementedException();
        }

        public void showTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
