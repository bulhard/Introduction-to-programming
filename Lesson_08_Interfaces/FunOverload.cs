using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08_Interfaces
{
    class FunOverload
    {
        public string name; 
        
        public void setName(string last)
        {
            name = last;
        }
        
        public void setName(string first, string last)
        {
            name = first + "" + last;
        }
        
        static void Main(string[] args)
        {
            FunOverload obj = new FunOverload(); 
            
            obj.setName("barack");
            obj.setName("barack ", " obama ");

        }
    }
}
