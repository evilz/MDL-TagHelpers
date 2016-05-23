using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement("*", Attributes = MDLTagHelper.TagPrefix + Name)]
    public class Shadow : TagHelper
    {
        public const string Name = "shadow";

        [HtmlAttributeName(MDLTagHelper.TagPrefix + Name)]
        public MdlShadow DeepShadow { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.CleanAttributes(MDLTagHelper.TagPrefix + Name);
           
            // TODO : convert to class add class to tag 
            output.Attributes.RemoveAll("color");
            output.AppendCssClass(DeepShadow.ToString());
            await base.ProcessAsync(context, output);
        }

    }
   
}
