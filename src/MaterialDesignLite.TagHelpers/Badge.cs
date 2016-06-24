using System.Collections.Generic;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{

    [HtmlTargetElement(Attributes = TagPrefix + Name)]
    public class Badge : MdlTagHelperBase
    {
        private const string Name = "badge";

        [HtmlAttributeName(TagPrefix + Name)]
        public string Data { get; set; }

        [HtmlAttributeName(TagPrefix + Name + "-color")]
        public MDLColor Color { get; set; }
        
        public Badge() : base(new[] { "mdl-badge" }) { }
        
        protected override IList<ConditionnalContent> ConditionnalCssClasses =>
            new List<ConditionnalContent>
            {
                {() => Color != null, (_)=> "mdl-color-badge--" + Color}
            };

        protected override IDictionary<string, string> SpecialAttributs =>
            new Dictionary<string, string>
            {
                {"data-badge", Data}
            };
    }
}
