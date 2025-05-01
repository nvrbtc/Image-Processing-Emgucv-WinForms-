using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.Services
{
    public interface IInputHandler
    {
        void HandleSignedIntegerTextBox ( object? sender,KeyPressEventArgs e);
        void HandlePositiveIntegerTextBox ( object? sender,KeyPressEventArgs e);
        void HandleSignedDoubleTextBox ( object? sender,KeyPressEventArgs e);
        void HandlePositiveDoubleTextBox ( object? sender,KeyPressEventArgs e);
    }
}
