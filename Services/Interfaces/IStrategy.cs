using Apo.DTO;

namespace APO_Tsarehradskiy.Services.Interfaces

{
    /// <summary>
    /// Defines an abstraction for image processing algorithms.
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Gets operation name, used in <c>ImageAndHistory</c> history tree. May include additional details ( e.g. "Hough : Isolated, 10px ... " ).
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Executes image processing strategy
        /// </summary>
        /// <param name="imageData">Includes image related information.</param>
        /// <param name="parameters">Includes required parameters to run strategy.</param>
        /// <returns></returns>
        Task Run(ImageData imageData, object parameters);

    }
}
