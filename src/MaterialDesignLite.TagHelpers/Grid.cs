using System.Threading.Tasks;
using Microsoft.AspNet.Razor.TagHelpers;
using MaterialDesignLite.TagHelpers.StyleValues;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement("mdl-grid")]
    public class Grid : TagHelper
    {
        private const string NoSpacingAttributeName = "no-spacing";

        [HtmlAttributeName(NoSpacingAttributeName)]
        public bool NoSpacing { get; set; }

        private string NoSpacingClass { get { return NoSpacing ? " mdl-grid--no-spacing" : string.Empty; } }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll(NoSpacingAttributeName);

            output.TagName = "div";

            output.Attributes["class"] = "mdl-grid" + NoSpacingClass;

            await base.ProcessAsync(context, output);
        }

    }

    //<mdl-cell size="1" desktop="1" tablet="1" phone="1" stretch valign="top">UNE CELL</mdl-cell>

    [HtmlTargetElement("mdl-cell")]
    public class Cell : TagHelper
    {
        private const string SizeAttributeName = "size";
        private const string DesktopAttributeName = "desktop";
        private const string TabletAttributeName = "tablet";
        private const string PhoneAttributeName = "phone";
        private const string VAlignAttributeName = "valign";

        private const int maxSizeDesktop = 12;
        private const int maxSizeTablet = 8;
        private const int maxSizePhone = 4;

        [HtmlAttributeName(SizeAttributeName)]
        public int? Size { get; set; }

        [HtmlAttributeName(DesktopAttributeName)]
        public int? Desktop { get; set; }

        [HtmlAttributeName(TabletAttributeName)]
        public int? Tablet { get; set; }

        [HtmlAttributeName(PhoneAttributeName)]
        public int? Phone { get; set; }

        [HtmlAttributeName(VAlignAttributeName)]
        public MDLCellVAlign VAlign { get; set; }

        [HtmlAttributeName("class")]
        public string Class { get; set; }

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

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll(SizeAttributeName);
            output.Attributes.RemoveAll(DesktopAttributeName);
            output.Attributes.RemoveAll(TabletAttributeName);
            output.Attributes.RemoveAll(PhoneAttributeName);
            output.Attributes.RemoveAll(VAlignAttributeName);

            output.TagName = "div";
            
            output.Attributes["class"] = Class + " mdl-cell"
                + SizeClass
                + DesktopClass
                + TabletClass
                + PhoneClass
                + VAlignClass;

            await base.ProcessAsync(context, output);
        }

    }
}
