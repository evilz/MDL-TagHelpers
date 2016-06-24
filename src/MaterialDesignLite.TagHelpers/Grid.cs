using System.Collections.Generic;
using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(TagPrefix + Name)]
    //[RestrictChildren(TagPrefix+Cell.Name)]
    public class Grid : MdlTagHelperBase
    {
        public const string Name = "grid";
        
        [HtmlAttributeName("no-spacing")]
        public bool NoSpacing { get; set; }
        
        public Grid() : base("mdl-grid", "div") {}

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            { ()=> NoSpacing , (_) => "mdl-grid--no-spacing" }
        };
        
    }


    [HtmlTargetElement(TagPrefix + Name, ParentTag = TagPrefix + Grid.Name)]
    public class Cell : MdlTagHelperBase
    {
        public const string Name = "cell";
        
        private const int maxSizeDesktop = 12;
        private const int maxSizeTablet = 8;
        private const int maxSizePhone = 4;

        [HtmlAttributeName("size")]
        public int? Size { get; set; }

        [HtmlAttributeName("desktop")]
        public int? Desktop { get; set; }

        [HtmlAttributeName("tablet")]
        public int? Tablet { get; set; }

        [HtmlAttributeName("phone")]
        public int? Phone { get; set; }

        [HtmlAttributeName("valign")]
        public MDLCellVAlign VAlign { get; set; }
        
        private string SizeClass
        {
            get
            {
                if (!Size.HasValue) return string.Empty;
                if (Size.Value <= 0) return string.Empty;
                if (Size.Value > maxSizeDesktop) Size = maxSizeDesktop;
                return " mdl-cell--" + Size.Value + "-col";
            }
        }
        
        private string DesktopClass
        {
            get
            {

                if (!Desktop.HasValue) return string.Empty;
                if (Desktop.Value <= 0) return " mdl-cell--hide-desktop";
                if (Desktop.Value > maxSizeDesktop) Tablet = maxSizeDesktop;
                return " mdl-cell--" + Desktop.Value + "-col-desktop";
            }
        }

        private string TabletClass
        {
            get
            {
                if (!Tablet.HasValue) return string.Empty;
                if (Tablet.Value <= 0) return " mdl-cell--hide-tablet";
                if (Tablet.Value > maxSizeTablet) Tablet = maxSizeTablet;
                return " mdl-cell--" + Tablet.Value + "-col-tablet";
            }
        }

        private string PhoneClass
        {
            get
            {
                if (!Phone.HasValue) return string.Empty;
                if (Phone.Value <= 0) return " mdl-cell--hide-phone";
                if (Phone.Value > maxSizePhone) Phone = maxSizePhone;
                return " mdl-cell--" + Phone.Value + "-col-phone";
            }
        }

        private string VAlignClass
        {
            get
            {
                if (VAlign == MDLCellVAlign.None) return string.Empty;
                return " mdl-cell--" + VAlign.ToString().ToLowerInvariant();
            }
        }

        public Cell() : base("mdl-cell", "div") { }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            { ()=> Size.HasValue, (_) => SizeClass },
            { ()=> Desktop.HasValue, (_) => DesktopClass },
            { ()=> Tablet.HasValue, (_) => TabletClass },
            { ()=> Phone.HasValue, (_) => PhoneClass },
            { ()=> VAlign != MDLCellVAlign.None, (_) => VAlignClass },
        };
        
    }
}
