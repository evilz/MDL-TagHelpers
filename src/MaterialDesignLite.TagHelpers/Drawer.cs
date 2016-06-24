using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(TagPrefix + Name)]
    public class Drawer : MdlTagHelperBase
    {
        private const string Name = "drawer";

        public Drawer() : base("mdl-layout__drawer" , "div") { }

        [HtmlAttributeName("title")]
        public string Title { get; set; }

        protected override IList<ConditionnalContent> ConditionnalPreContents => new List<ConditionnalContent>
        {
            { ()=> true, (_) =>$"<span class=\"mdl-layout__title\">{Title}</span>" }
        };
    }
    
}
