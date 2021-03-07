using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    internal class Idgenerator
    {

        static int start = 999;
        string tempId;
        DateTime date = DateTime.Now;

        public string Generator()
        {
            string temp = DateTime.Now.ToString("yyyy-MM-");
            tempId = temp + ++start;
            
            return tempId;

        }

    }
}
