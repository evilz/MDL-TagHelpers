using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement("mdl-button")]
    public class Button : TagHelper
    {
        private const string Name = "button";

       

        [HtmlAttributeName("type")]
        public string Type { get; set; }  // TODO :  create enum !

        [HtmlAttributeName("color")]
        public string Color { get; set; } // TODO :  create enum !




        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
        
            output.TagName = "button";

            output.AppendCssClass("mdl-button","mdl-js-button","mdl-js-ripple-effect");

            await base.ProcessAsync(context, output);
        }

    }
   
}
