using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.Interfaces
{
    public interface IGetStrategy
    {
        IAlgorithmStrategy GetAlgoInstance();
    }
}
