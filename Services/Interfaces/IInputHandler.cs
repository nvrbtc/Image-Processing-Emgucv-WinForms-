namespace APO_Tsarehradskiy.Services.Interfaces
{
    public interface IInputHandler
    {
        void HandleSignedIntegerTextBox(object? sender, KeyPressEventArgs e);
        void HandlePositiveIntegerTextBox(object? sender, KeyPressEventArgs e);
        void HandleSignedDoubleTextBox(object? sender, KeyPressEventArgs e);
        void HandlePositiveDoubleTextBox(object? sender, KeyPressEventArgs e);
    }
}
