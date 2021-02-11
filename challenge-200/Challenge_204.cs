using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace challenge_200
{
    public class Challenge_204 : IChallenge_204
    {
        public Challenge_204() { }

        public int Potatoes(string s) 
        {
            // Define a regular expression for repeated words.
            Regex rx = new Regex(@"\W*((?i)potato(?-i))\W*",
              RegexOptions.Compiled | RegexOptions.IgnoreCase);

            // Find matches.
            MatchCollection matches = rx.Matches(s);

            return matches.Count();

        }
       

    }
}
