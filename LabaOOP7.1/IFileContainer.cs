using LabaOOP5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7OOP
{
    internal interface IFileContainer:IContainer
    {
        void Save(String fileName);
        void Load(String fileName);
         Boolean IsDataSaved { get; set; }
    }
}
