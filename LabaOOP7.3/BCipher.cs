using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._3
{
    internal class BCipher:ICipher
    {
        public string massage { get; set; }
        private const string alphabet = "абвгґдеєжзииіїйклмнопрстуфхцчшщьюя";
        public string encode()
        {
            int mirrorindex;
            string[] strings = massage.Split(' ');
            StringBuilder sb = new StringBuilder();
            for(int k = 0;k<strings.Length; ++k)
            {
                char[] chars = strings[k].ToCharArray();
                for (int j = 0;j<chars.Length; ++j)
                {
                    mirrorindex = alphabet.Length - 1 - alphabet.IndexOf(chars[j]);
                    chars[j] = alphabet[mirrorindex];
                }
                sb.Append(new string(chars).ToString());
                if (k < strings.Length - 1)
                {
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }
        public string decode()
        {
            int mirrorIndex;
            string[] strings = massage.Split(' ');  
            StringBuilder sb = new StringBuilder();

            for (int k = 0; k < strings.Length; ++k)
            {
                char[] chars = strings[k].ToCharArray();

                for (int j = 0; j < chars.Length; ++j)
                {
                    
                    mirrorIndex = alphabet.Length - 1 - alphabet.IndexOf(chars[j]);
                    chars[j] = alphabet[mirrorIndex];
                }

                sb.Append(new string(chars));

             
                if (k < strings.Length - 1)
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
