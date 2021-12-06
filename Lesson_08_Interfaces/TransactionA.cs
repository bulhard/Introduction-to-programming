using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08_Interfaces
{
    public abstract class TransactionA
    {
        private int amount;

        public abstract void showTransaction();

        public double GetAmount()
        {
            return amount;
        }
    }


    public class TransactionAConcrete : TransactionA
    {
        public override void showTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
