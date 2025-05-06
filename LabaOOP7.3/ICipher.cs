using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._3
{
    internal interface ICipher
    {
        string massage { get; set; }
        string encode();
        string decode();

    }
}
