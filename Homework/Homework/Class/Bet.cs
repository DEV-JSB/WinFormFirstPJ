using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            return "";
        }
        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                Bettor.Cash += Amount;
                return 1;
            }
            else
                return 0;
        }
    }
}
