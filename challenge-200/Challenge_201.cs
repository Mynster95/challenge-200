using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace challenge_200
{
    public class Challenge_201 : IChallenge_201
    {
        public Challenge_201() { }


        public string Maskify(string cardNumber) 
        {
            var cardNumberCount = cardNumber.Count();
            StringBuilder sb = new StringBuilder(cardNumber);

            if (cardNumberCount < 5) 
            {

                return cardNumber;
            }

            for (int i = 0; i < cardNumberCount - 4; i++)
            {
                sb[i] = '#';
            }

            return sb.ToString();
        
        }

    }
}
