using APO_Tsarehradskiy.DTO;

namespace APO_Tsarehradskiy.Services

{
    public interface IStrategy
    {
        string name { get; set; }
        Task Run(ImageData img, object parameters);

    }
}
