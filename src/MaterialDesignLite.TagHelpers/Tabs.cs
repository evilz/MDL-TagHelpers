using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{

    [HtmlTargetElement(TagPrefix + "tabs")]
    public class Tabs : MdlTagHelperBase
    {
        [HtmlAttributeName("ripple")]
        public bool HasRipple { get; set; } = true;
        
        public Tabs() : base(new []{"mdl-tabs", "mdl-js-tabs"}, "div") { }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            {() => HasRipple, _ => "mdl-js-ripple-effect" }
        };

        protected override IList<ConditionnalContent> ConditionnalPreContents => new List<ConditionnalContent>
        {
            { ()=> true, CreateTabs }
        };

        public Func<TagHelperOutput, string> CreateTabs => output =>
        {

            string content = output.GetChildContent();

            var xdoc = XDocument.Parse("<div>" + content + "</div>");
            var tabPanels = xdoc.Root.Elements("div").Where(element => element.Attribute("title") != null).ToArray();

            var tabsBar = new StringBuilder("<div class=\"mdl-tabs__tab-bar\">");

            foreach (var panel in tabPanels)
            {
                var title = panel.Attribute("title").Value;
                panel.Attribute("title").Remove();

                var id = String.Empty;
                if (panel.Attributes("id").Any())
                {
                    id = panel.Attribute("id").Value;
                    
                }
                else
                {
                    panel.SetAttributeValue("id", id);
                }

                // UGLY !!
                var isActiveClass = panel.Attribute("class").Value.Contains("is-active")
                    ? "is-active"
                    : string.Empty;

                tabsBar.Append($"<a href=\"#{id}\" class=\"mdl-tabs__tab {isActiveClass}\">{title}</a>");
            }
            tabsBar.Append("</div>");
            tabsBar.Append("<div>");

            return tabsBar.ToString();
        };

        protected override IList<ConditionnalContent> ConditionnalPostContents => new List<ConditionnalContent>
        {
            { ()=> true, _ => "</div>" }
        };
    }

    [HtmlTargetElement(TagPrefix + "tab-panel")]
    public class TabPanel : MdlTagHelperBase
    { 
        [HtmlAttributeName("active")]
        public bool IsActive { get; set; }

        public TabPanel() : base("mdl-tabs__panel", "div") { }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            {()=> IsActive, _=> "is-active" }
        };

        protected override IDictionary<string, string> SpecialAttributs => new Dictionary<string, string>
        {
            { "id", CreateId()}
        };
    }

}
