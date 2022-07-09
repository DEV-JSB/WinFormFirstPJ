using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public int GetCash() { return Cash; }
        public int UpdateLabels()
        {
            MyLabel.Text = Name + " bets " + Cash.ToString() + " bucks on dog # "+ MyBet.Dog.ToString();
            return 0;
        }
        public void ClearBet()
        {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
            MyLabel.Text = Name + " hasn't placed a bet";
        }

        public bool PlaceBet(int Amount , int Dog)
        {
            Cash -= Amount;
            MyBet.Amount = Amount;
            MyBet.Dog = Dog;
            UpdateLabels();
            return true;
        }
    }
}
