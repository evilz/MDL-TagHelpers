using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement("*", Attributes = TagPrefix + Name)]
    public class TooltipsAttr : MdlTagHelperBase
    {
        public const string Name = "tooltips";

        [HtmlAttributeName(TagPrefix + Name)]
        public string Text { get; set; }

        [HtmlAttributeName(TagPrefix + Name + "-large")]
        public bool IsLarge { get; set; }

        private string WeightClass => IsLarge ? "mdl-tooltip--large" : string.Empty;

        protected override IList<ConditionnalContent> ConditionnalPostContents => new List<ConditionnalContent>
        {
            { ()=> !string.IsNullOrEmpty(Text), o => $"<div class=\"mdl-tooltip {WeightClass}\" for={o.GetOrCreateId()}>{Text}</div>" }
        };
    }

    [HtmlTargetElement(TagPrefix + Name)]
    public class TooltipsElm : MdlTagHelperBase
    {
        public const string Name = "tooltips";

        [HtmlAttributeName("large")]
        public bool IsLarge { get; set; }
        
        public TooltipsElm() : base("mdl-tooltip", "div") { }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            {() => IsLarge, _=> "mdl-tooltip--large" }
        };
    }
}