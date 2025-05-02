using APO_Tsarehradskiy.Services;

namespace APO_Tsarehradskiy.Interfaces

{
    public interface IStrategy
    {
        string name { get; }
        ImageData ImageData { get; set; }
        Task Run(ImageData img, object parameters);
        
    }
}
