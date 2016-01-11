using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class Tabs : TagHelper
    {
        private const string Name = "tabs";

        [HtmlAttributeName("ripple")]
        public bool HasRipple { get; set; } = true;
        
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            output.AppendCssClass("mdl-tabs", "mdl-js-tabs");

            if (HasRipple)
            { output.AppendCssClass("mdl-js-ripple-effect");}

            string content = output.GetChildContent();
            // parse content to get div panel
           // string pattern = "<div class="mdl-tabs__panel(\s)*>&nbsp;</p>(\r\n)?)+";
           // string newtext = Regex.Replace(input, pattern, "<br/>");

            await base.ProcessAsync(context, output);
        }

    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class TabPanel : TagHelper
    {
        private const string Name = "tab-panel";

        [HtmlAttributeName("title")]
        public string Title { get; set; }
        
        [HtmlAttributeName("active")]
        public bool IsActive { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            output.AppendCssClass("mdl-tabs__panel");

            if (IsActive)
            { output.AppendCssClass("is-active"); }

            await base.ProcessAsync(context, output);
        }

    }

}
