using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class Idgeneeator
    {

        //taking system date to create an id for an account holder
        static int start = 999;
        string tempId;
        DateTime date = DateTime.Now;

        public string Geneeator()
        {
            string temp = DateTime.Now.ToString("yyyy-MM-");
            tempId = temp + ++start;
            
            return tempId;

        }

    }
}
