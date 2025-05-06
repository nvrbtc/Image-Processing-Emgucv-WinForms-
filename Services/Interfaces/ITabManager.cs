using APO_Tsarehradskiy.customUI;
using APO_Tsarehradskiy.DTO;

namespace APO_Tsarehradskiy.Services
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
