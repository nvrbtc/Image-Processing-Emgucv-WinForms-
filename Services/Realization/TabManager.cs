using APO_Tsarehradskiy.customUI;
using APO_Tsarehradskiy.DTO;

namespace APO_Tsarehradskiy.Services
{
    public class TabManager : ITabManager
    {
        private TabControl tabControl { get; set; }
        public void TryDuplicate() { 
            var tab = tabControl.SelectedTab as ImageTabPage;
            if (tab == null) return;
            var clonedPage = tab.Clone();
            tabControl.TabPages.Add(clonedPage);
            tabControl.SelectedTab = clonedPage;
            
        }
        public void AddPage(ImageLoadResult result)
        {
            var tab = new ImageTabPage(result.img, result.imageType, result.fileName) { Text = result.fileName, Name = result.fileName };
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
        }
        public void RemovePage()
        {
            //tabControl?.TabPages.Remove(page);
        }

        public ImageData? GetImageDataFromTab()
        {
            ImageTabPage? temp = tabControl.SelectedTab as ImageTabPage;

            return temp?.imageData;
        }

        public void SetTab(TabControl tabControl)
        {
            this.tabControl = tabControl;
        }

    }
}
