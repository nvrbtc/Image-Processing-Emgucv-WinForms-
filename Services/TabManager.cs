using APO_Tsarehradskiy.customUI;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            tabControl.TabPages.Add(new ImageTabPage(result.img, result.imageType,result.fileName) { Text = result.fileName, Name = result.fileName });
            tabControl.SelectedTab = tabControl.TabPages[$"{result.fileName}"];
        }
        public void RemovePage(ImageTabPage page)
        {
            tabControl?.TabPages.Remove(page);
        }
        public void UpdateImage(ImageTabPage? page, Mat img)
        {
            page?.RefreshImg(img);
        }

        public ImageTabPage? GetSelectedTab()
        {
            ImageTabPage? temp = tabControl.SelectedTab as ImageTabPage;

            if (temp == null || temp.Img == null) return null;

            return temp;
        }
    }
}
