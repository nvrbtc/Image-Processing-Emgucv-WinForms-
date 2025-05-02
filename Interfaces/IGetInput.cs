using APO_Tsarehradskiy.Enums;

namespace APO_Tsarehradskiy.Interfaces.InputReturn
{
    public interface IGetInput
    {
        object ReturnInput();
        Strategies ReturnStrategy();
    }
}
