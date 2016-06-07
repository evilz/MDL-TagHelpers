using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class Drawer : TagHelper
    {
        private const string Name = "drawer";

        [HtmlAttributeName("title")]
        public string Title { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AppendCssClass("mdl-layout__drawer");

            var content = (await output.GetChildContentAsync()).GetContent();

            if (!string.IsNullOrEmpty(Title))
            {
                content = $"<span class=\"mdl-layout__title\">{Title}</span>" + content;
            }
            output.Content.SetHtmlContent(content);

            await base.ProcessAsync(context, output);
        }

    }
    
}
