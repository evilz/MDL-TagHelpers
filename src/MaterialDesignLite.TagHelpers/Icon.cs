using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class Icon : TagHelper
    {
        public const string Name = "icon";

        [HtmlAttributeName("icon")]
        public StyleValues.MDLIcon MdlIcon { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.CleanAttributes(Name);

            if (MdlIcon == null) { return; }
              
            output.TagName = "i";
            output.AppendCssClass("material-icons");
            output.Content.SetContent(MdlIcon.Ligature); // TODO : MANAGE IE using codepoint ...

            await base.ProcessAsync(context, output);
        }

    }

}
