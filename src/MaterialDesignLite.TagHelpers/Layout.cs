using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(TagPrefix + "layout")]
    public class Layout : MdlTagHelperBase
    {
        [HtmlAttributeName("fixed-drawer")]
        public bool HasFixedDrawer { get; set; }

        public Layout() : base(new []{ "mdl-layout", "mdl-js-layout" }, "div"){}

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            {() => HasFixedDrawer, _ => "mdl-layout--fixed-drawer" }
        };
    }

    [HtmlTargetElement(TagPrefix + "layout-header")]
    public class LayoutHeader : MdlTagHelperBase
    {
        public LayoutHeader() : base("mdl-layout__header", "header") {}
    }

    [HtmlTargetElement(TagPrefix + "layout-icon")]
    public class LayoutIcon : MdlTagHelperBase
    {
        public LayoutIcon() : base("mdl-layout-icon", "div") { }
    }

    [HtmlTargetElement(TagPrefix + "header-row")]
    public class LayoutHeaderRow : MdlTagHelperBase
    {
        [HtmlAttributeName("title")]
        public string Title { get; set; }

        public LayoutHeaderRow() : base("mdl-layout__header-row", "div") { }

        protected override IList<ConditionnalContent> ConditionnalPreContents => new List<ConditionnalContent>
        {
            { () => !string.IsNullOrEmpty(Title), _ => $"<span class=\"mdl-layout__title\">{Title}</span>" }
        };
    }

    [HtmlTargetElement(TagPrefix + "spacer")]
    public class LayoutSpacer : MdlTagHelperBase
    {
        public LayoutSpacer() : base("mdl-layout-spacer", "div") {}
    }

    [HtmlTargetElement(TagPrefix + "content")]
    public class LayoutContent : MdlTagHelperBase
    {
        public LayoutContent() : base("mdl-layout__content", "main") { }
    }

}

