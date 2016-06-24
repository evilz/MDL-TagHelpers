using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{

    [HtmlTargetElement("*", Attributes = TagPrefix + Name)]
    public class BgColor : MdlTagHelperBase
    {
        public  const string Name = "bgcolor";

        [HtmlAttributeName(TagPrefix + Name)]
        public StyleValues.MDLColor BackgroundColor { get; set; }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            {()=>true, (_)=>"mdl-color--" + BackgroundColor }
        };
   
    }

    [HtmlTargetElement("*", Attributes = TagPrefix + Name)]
    public class Color : MdlTagHelperBase
    {
        public const string Name = "color";

        [HtmlAttributeName(TagPrefix + Name)]
        public StyleValues.MDLColor TextColor { get; set; }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            {()=>true, (_) => "mdl-color-text--" + TextColor }
        };
    

    }

}
