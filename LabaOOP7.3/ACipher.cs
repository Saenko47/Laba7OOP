using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._3
{
    internal class ACipher : ICipher
    {
        public string massage { get; set; }
        public ACipher(string massage)
        {
            this.massage = massage;
        }
        public string encode()
        {
            string[] strings = massage.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int k = 0;k<strings.Length; ++k)
            {
                
                char[] chars = strings[k].ToCharArray();
                for (int j = 0;j<chars.Length; ++j)
                {
                    if (chars[j] == 'Я') {
                        chars[j] = 'А';
                    }
                    else if (chars[j] == 'я')
                    {
                        chars[j] = 'а';
                    }
                    else
                    {
                        chars[j] = (char)(chars[j] + 1);
                    }
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
            string[] strings = massage.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int k = 0; k < strings.Length; ++k)
            {
                char[] chars = strings[k].ToCharArray();

                for (int j = 0; j < chars.Length; ++j)
                {
                    if (chars[j] == 'А')
                    {
                        chars[j] = 'Я';
                    }
                    else if (chars[j] == 'а')
                    {
                        chars[j] = 'я';
                    }
                    else
                    {
                        chars[j] = (char)(chars[j] - 1);
                    }
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
