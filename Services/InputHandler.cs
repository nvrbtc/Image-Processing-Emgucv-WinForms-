using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.Services
{
    public class InputHandler : IInputHandler
    {
        public void HandlePositiveDoubleTextBox(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }

        public void HandlePositiveIntegerTextBox(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
            
            // No leading Zero
            if ((e.KeyChar == '0') && ((sender as TextBox).Text.Length != 0))
            {
                e.Handled = true;
            }
        }

        public void HandleSignedDoubleTextBox(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one sign
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.Length != 0))
            {
                e.Handled = true;
            }
        }

        public void HandleSignedIntegerTextBox(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.Length != 0 ))
            {
                e.Handled = true;
            }
        }
        
    }
}
