using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class Layout : TagHelper
    {
        private const string Name = "layout";

        [HtmlAttributeName("fixed-drawer")]
        public bool HasFixedDrawer { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AppendCssClass("mdl-layout", "mdl-js-layout");

            if (HasFixedDrawer)
            { output.AppendCssClass("mdl-layout--fixed-drawer"); }


            await base.ProcessAsync(context, output);
        }

    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class LayoutHeader : TagHelper
    {
        private const string Name = "layout-header";
        
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "header";
            output.AppendCssClass("mdl-layout__header");
            await base.ProcessAsync(context, output);
        }

    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class LayoutIcon : TagHelper
    {
        private const string Name = "layout-icon";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AppendCssClass("mdl-layout-icon");
            await base.ProcessAsync(context, output);
        }

    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class LayoutHeaderRow : TagHelper
    {
        private const string Name = "header-row";

        [HtmlAttributeName("title")]
        public string Title { get; set; }


        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AppendCssClass("mdl-layout__header-row");

            var content = (await output.GetChildContentAsync()).GetContent();

            if (!string.IsNullOrEmpty(Title))
            {
               content = $"<span class=\"mdl-layout__title\">{Title}</span>" + content;
            }
            output.Content.SetHtmlContent(content);
            await base.ProcessAsync(context, output);
        }

    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class LayoutSpacer : TagHelper
    {
        private const string Name = "spacer";
        

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AppendCssClass("mdl-layout-spacer");
            await base.ProcessAsync(context, output);
        }

    }

}
