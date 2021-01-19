using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CreepingLine // рекламное сообщение, предназначенное для отображения на бегущей строке.
    {
        public string AdMessage { get; set; } //
        public CreepingLine(string message)
        {
            AdMessage = message;
        }
    }
}
