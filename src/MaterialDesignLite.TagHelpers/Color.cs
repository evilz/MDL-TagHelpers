using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{

    [HtmlTargetElement("*", Attributes = MDLTagHelper.TagPrefix + Name)]
    public class BgColor : TagHelper
    {
        public  const string Name = "bgcolor";

        [HtmlAttributeName(MDLTagHelper.TagPrefix + Name)]
        public StyleValues.MDLColor BackgroundColor { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.CleanAttributes(MDLTagHelper.TagPrefix + Name);
          
            output.AppendCssClass("mdl-color--" + BackgroundColor);
            
            await base.ProcessAsync(context, output);
        }

    }

    [HtmlTargetElement("*", Attributes = MDLTagHelper.TagPrefix + Name)]
    public class Color : TagHelper
    {
        public const string Name = "color";

        [HtmlAttributeName(MDLTagHelper.TagPrefix + Name)]
        public StyleValues.MDLColor TextColor { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.CleanAttributes(MDLTagHelper.TagPrefix + Name);

            output.AppendCssClass("mdl-color-text--" + TextColor);

            await base.ProcessAsync(context, output);
        }

    }

}
