using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace Apo.ImageProcessingAlgos;

public class Pyramid : IStrategy
{
    public string Name { get; set; } = "Pyramid";
    private PyramidInput input;
    public async Task Run(ImageData imageData, object parameters)
    {
        if ( imageData?.ValidateValuesAreNull() == true || parameters is not PyramidInput pyrInput) return;
        this.input =  pyrInput;
        
        for (int i = 0; i < input.Iterations; )
        {
            
            Mat result = new Mat();
            if (input.IsDown)
            {
                
                CvInvoke.PyrDown(imageData.Image, result, input.BorderType);
            }
            else
            {
                CvInvoke.PyrUp(imageData.Image, result, input.BorderType);
            }
            imageData.UpdateImage(result,++i == input.Iterations );
        }
    }
}