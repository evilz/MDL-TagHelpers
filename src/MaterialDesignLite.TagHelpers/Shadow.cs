using System.Collections.Generic;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement("*", Attributes = TagPrefix + "shadow")]
    public class Shadow : MdlTagHelperBase
    {
        public const string Name = "shadow";

        [HtmlAttributeName(TagPrefix + Name)]
        public MdlShadow DeepShadow { get; set; }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            { ()=> true , (_) => DeepShadow.ToString()}
        };
        
    }
   
}
