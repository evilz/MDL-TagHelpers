using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class Tabs : TagHelper
    {
        private const string Name = "tabs";

        [HtmlAttributeName("ripple")]
        public bool HasRipple { get; set; } = true;

        [HtmlAttributeName("selected")]
        public int SelectedIndex { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            output.AppendCssClass("mdl-tabs", "mdl-js-tabs");

            if (HasRipple)
            { output.AppendCssClass("mdl-js-ripple-effect"); }

            string content = output.GetChildContent();
           
            var xdoc = XDocument.Parse("<div>"+content+"</div>");
            var tabPanels = xdoc.Root.Elements("div").Where(element => element.Attribute("title") != null).ToArray();

            var tabsBar = new StringBuilder("<div class=\"mdl-tabs__tab-bar\">");

            for (var i = 0; i < tabPanels.Length; i++)
            {
                var title = tabPanels[i].Attribute("title").Value;
                tabPanels[i].Attribute("title").Remove();
                var id = tabPanels[i].Attribute("id").Value;

                if (i == SelectedIndex)
                {
                    tabsBar.Append($"<a href=\"#{id}\" class=\"mdl-tabs__tab is-active\">{title}</a>");
                    tabPanels[i].Attribute("class").Value += " is-active";
                }
                else
                {
                    tabsBar.Append( $"<a href=\"#{id}\" class=\"mdl-tabs__tab\">{title}</a>");
                }
            }
            tabsBar.Append("</div>");
            
            output.PreContent.SetHtmlContent(tabsBar.ToString());

            var reader = xdoc.Root.CreateReader();
            reader.MoveToContent();
            output.Content.SetHtmlContent(reader.ReadInnerXml());

            await base.ProcessAsync(context, output);
        }

    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class TabPanel : TagHelper
    { 
        private const string Name = "tab-panel";
        
        [HtmlAttributeName("active")]
        public bool IsActive { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            output.AppendCssClass("mdl-tabs__panel");

            if (IsActive)
            { output.AppendCssClass("is-active"); }

            output.GetOrCreateId();

            await base.ProcessAsync(context, output);
        }

    }

}
