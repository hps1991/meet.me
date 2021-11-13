using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class ScreenVM
    {
        public bool Trial(string s)
        {
            if (s.Equals("i"))
                return true;
            else
                return false;
        }
    }
}
