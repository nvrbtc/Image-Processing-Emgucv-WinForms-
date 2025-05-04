using APO_Tsarehradskiy.customUI.TabPageInherited;
using APO_Tsarehradskiy.Enums;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.Services.Interfaces
{
    public interface ITabManager
    {
        TabControl tabControl { get; set; }
        ImageTabPage GetSelectedTab();
        void AddPage(ImageTabPage tab);
        void AddPage(ImageLoadResult result);
        void RemovePage(ImageTabPage tab);
    }
}
