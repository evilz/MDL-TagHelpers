using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class Textfield : TagHelper
    {
        public const string Name = "textfield";
        

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            
            output.TagName = "div";

            output.AppendCssClass("mdl-textfield", "mdl-js-textfield");

            var id = new Guid().ToString();
            output.Content.SetHtmlContent("<input class=\"mdl-textfield__input\" type=\"text\"  id=\"{id}\"><label class=\"mdl-textfield__label\" for=\"{id}\">Number...</label><span class=\"mdl-textfield__error\">Input is not a number!</span>");
            

            await base.ProcessAsync(context, output);
        }

    }
   
}
