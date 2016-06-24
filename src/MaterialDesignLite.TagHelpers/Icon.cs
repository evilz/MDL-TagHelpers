using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(TagPrefix + Name)]
    public class Icon : MdlTagHelperBase
    {
        public const string Name = "icon";

        [HtmlAttributeName("icon")]
        public StyleValues.MDLIcon MdlIcon { get; set; }

        [HtmlAttributeName("icon-size")]
        public int IconSize { get; set; }

        public Icon() : base("material-icons","i") {}

        protected override IList<ConditionnalContent> ConditionnalContents => new List<ConditionnalContent>
        {
            { () => MdlIcon != null, CreateIcon }
        };

        private Func<TagHelperOutput, string> CreateIcon => output =>
        {
            if (IconSize > 0)
            {
                var style = output.Attributes.ContainsName("style")
                    ? output.Attributes["style"].Value
                    : string.Empty;

                output.Attributes.SetAttribute("style", $" {style} font-size:{IconSize}px");
            }
            return MdlIcon.Ligature;
        };
        
    }

}
