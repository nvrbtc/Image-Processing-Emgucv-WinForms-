using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.InputTypes
{
    public class ComboBoxInput<T>
    {
        public string Text { get; set; }
        public T Value { get; set; }

    }
}
