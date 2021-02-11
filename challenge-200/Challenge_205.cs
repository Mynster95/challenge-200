using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace challenge_200
{
    public class Challenge_205 : IChallenge_205
    {
        public Challenge_205() { }

        public IEnumerable<int> Encrypt(string str) 
        {
            List<int> encodedList = new List<int>();
            encodedList.Add(str[0]);
            for (int i = 1; i < str.Length; i++) 
            {
                var leftie = str[i-1];
                var current = str[i];

                encodedList.Add(current - leftie);
            }
            return encodedList;
        }

        public string Decrypt(IEnumerable<int> encodedList) 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((char)encodedList.FirstOrDefault());

            for (int i = 1; i < encodedList.Count(); i++) 
            {
                var lastElement = sb[sb.Length - 1];
                var current = encodedList.ElementAt(i);

                sb.Append((char) (current + lastElement)); 



            }
            return sb.ToString();
        
        }
       

    }
}
