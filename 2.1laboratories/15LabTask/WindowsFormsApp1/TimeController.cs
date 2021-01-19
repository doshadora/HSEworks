using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TimeController // список рекламных сообщений
    {
        public int CurrentStringNumber { get; set; } // номер рекламного сообщения для вывода
        public List<string> Ad { get; set; } // список рекламных сообщений
        public TimeController(int currentString, List<string> creepingLineList)
        {
            CurrentStringNumber = currentString;
            Ad = creepingLineList;
        }
    }
}