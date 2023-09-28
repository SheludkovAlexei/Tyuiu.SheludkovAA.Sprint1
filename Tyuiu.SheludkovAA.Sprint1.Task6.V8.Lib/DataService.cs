using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SheludkovAA.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string v = value.Remove(0, 1);
            string s = value.Remove(1, value.Length-1);
            string res = v + s;
            return res;
        }
    }
}
