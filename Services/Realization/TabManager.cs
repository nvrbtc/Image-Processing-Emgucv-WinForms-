using Apo.customUI;
using Apo.DTO;
using APO_Tsarehradskiy.Services.Interfaces;

namespace APO_Tsarehradskiy.Services.Realization
{
    public class TabManager : ITabManager
    {
        private TabControl TabControl;

        public void TryDuplicate()
        {
            var tab = TabControl.SelectedTab as ImageTabPage;
            if (tab == null) return;
            var clonedPage = tab.Clone();
            TabControl.TabPages.Add(clonedPage);
            TabControl.SelectedTab = clonedPage;
        }

        public void AddPage(ImageLoadResult result)
        {
            var tab = new ImageTabPage(result.Image, result.ImageType, result.FileName)
            { Text = result.FileName, Name = result.FileName };
            TabControl.TabPages.Add(tab);
            TabControl.SelectedTab = tab;
        }

        public void RemovePage()
        {
            //tabControl?.TabPages.Remove(page);
        }

        public ImageData? GetImageDataFromTab()
        {
            ImageTabPage? temp = TabControl.SelectedTab as ImageTabPage;

            return temp?.GetImageData();
        }

        public void SetTab(TabControl tabControl)
        {
            TabControl = tabControl;
        }
    }
}