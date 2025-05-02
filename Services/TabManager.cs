using APO_Tsarehradskiy.customUI.TabPageInherited;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace APO_Tsarehradskiy.Services
{
    public class TabManager : ITabManager
    {
        //private ImageTabPage? selectedTab; // ???
        public TabControl tabControl { get; set; }
        //private List<ImageTabPage> allPages = new List<ImageTabPage>();
        public TabManager()
        {

        }
        public int GetSize() => tabControl.TabCount;
        public void AddPage(ImageTabPage page) { tabControl?.Controls.Add(page); }
        public void AddPage(ImageLoadResult result)
        {
            var tab = new ImageTabPage(result.img, result.imageType, result.fileName) { Text = result.fileName, Name = result.fileName };
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
        }
        public void RemovePage(ImageTabPage page)
        {
            tabControl?.TabPages.Remove(page);
        }

        public ImageTabPage? GetSelectedTab()
        {
            ImageTabPage? temp = tabControl.SelectedTab as ImageTabPage;

            if (temp == null || temp.Img == null) return null;

            return temp;
        }
    }
}
