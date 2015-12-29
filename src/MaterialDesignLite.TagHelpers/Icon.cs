using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement("mdl-icon")]
    public class Icon : TagHelper
    {
        [HtmlAttributeName("value")]
        public StyleValues.MDLIcon Value { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("value");

            if (Value == null) { return; }
              

            output.TagName = "i";
            output.Attributes["class"] = "material-icons";
            output.Content.SetContent(Value.Ligature); // TODO : MANAGE IE using codepoint ...

            await base.ProcessAsync(context, output);
        }

    }

}
