using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kingsman11_20.Res
{
    internal class EF
    {
        public static DataBase.Entities Context { get; } = new DataBase.Entities();
    }
}
