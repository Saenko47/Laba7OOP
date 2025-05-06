using LabaOOP5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba7OOP
{
    internal interface IContainer
    {

        int count { get; }
        void Add(Magazine mag);
        void Delete(int element);
    }
}
