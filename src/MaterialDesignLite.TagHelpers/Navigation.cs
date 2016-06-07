using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class Navigation : TagHelper
    {
        private const string Name = "nav";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "nav";
            output.AppendCssClass("mdl-navigation");
            await base.ProcessAsync(context, output);
        }

    }

    [HtmlTargetElement("a", Attributes = MDLTagHelper.TagPrefix + Name)]
    public class NavigationLink : TagHelper
    {
        private const string Name = "nav-item";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.AppendCssClass("mdl-navigation__link");
            await base.ProcessAsync(context, output);
        }

    }

}
