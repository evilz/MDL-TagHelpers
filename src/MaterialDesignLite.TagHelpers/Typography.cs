using System.Collections.Generic;
using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement("*",   Attributes = TypoAttributeName)]
    public class Typography : MdlTagHelperBase
    {
        private const string TypoAttributeName = "mdl-typo";

        [HtmlAttributeName(TypoAttributeName)]
        public MDLTypographies Typo { get; set; }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            {() => true, _ => "mdl-typography--" + Typo.ToCssClass() }
        };
    }

}
