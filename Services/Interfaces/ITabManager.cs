using Apo.DTO;

namespace APO_Tsarehradskiy.Services.Interfaces
{
    public interface ITabManager
    {
        public void SetTab(TabControl tabControl);
        public ImageData? GetImageDataFromTab();
        public void TryDuplicate();
        public void AddPage(ImageLoadResult result);
        public void RemovePage();
    }
}
