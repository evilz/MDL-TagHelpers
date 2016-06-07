using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers;
using MaterialDesignLite.TagHelpers.StyleValues;

namespace MaterialDesignLite.WebSample.ViewModels
{
    public class PageViewConfig
    {
        public Header Header { get; set; }
        public bool RightOnHeader { get; set; }
        public PageViewConfig()
        {
            RightOnHeader = true;
        }
    }

    public class Header
    {
        public string BgClass { get; set; }
        public SpectrumAlphaMDLColor BgColor { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
    }
}
