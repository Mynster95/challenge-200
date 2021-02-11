using System.Collections.Generic;

namespace challenge_200
{
    public interface IChallenge_205
    {
        public IEnumerable<int> Encrypt(string str);
        public string Decrypt(IEnumerable<int> encodedList);
    }
}