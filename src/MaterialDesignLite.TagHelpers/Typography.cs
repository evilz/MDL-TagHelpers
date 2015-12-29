using System.Threading.Tasks;
using Microsoft.AspNet.Razor.TagHelpers;
using MaterialDesignLite.TagHelpers.StyleValues;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement("div",   Attributes = TypoAttributeName)]
    [HtmlTargetElement("span",  Attributes = TypoAttributeName)]
    [HtmlTargetElement("a",     Attributes = TypoAttributeName)]
    [HtmlTargetElement("li",    Attributes = TypoAttributeName)]
    [HtmlTargetElement("h1",    Attributes = TypoAttributeName)]
    [HtmlTargetElement("h2",    Attributes = TypoAttributeName)]
    [HtmlTargetElement("h3",    Attributes = TypoAttributeName)]
    [HtmlTargetElement("h4",    Attributes = TypoAttributeName)]
    [HtmlTargetElement("h5",    Attributes = TypoAttributeName)]
    [HtmlTargetElement("h6",    Attributes = TypoAttributeName)]
    public class Typography : TagHelper
    {
        private const string TypoAttributeName = "mdl-typo";

        [HtmlAttributeName(TypoAttributeName)]
        public MDLTypographies Typo { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll(TypoAttributeName);
            
            output.Attributes["class"] = output.Attributes["class"]?.Value + " mdl-typography--" + Typo.ToCssClass();
            
            await base.ProcessAsync(context, output);
        }

    }

}
