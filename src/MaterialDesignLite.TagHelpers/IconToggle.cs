using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(TagPrefix + "icon-toggle")]
    public class IconToggle : MdlTagHelperBase
    {
        public IconToggle() : base(new []{ "mdl-icon-toggle","mdl-js-icon-toggle" },"label") {}

        [HtmlAttributeName("ripple")]
        public bool HasRipple { get; set; } = true;
        
        [HtmlAttributeName("icon")]
        public MDLIcon Icon { get; set; }

        protected override IList<ConditionnalContent> ConditionnalContents => new List<ConditionnalContent>
        {
            { () => true, Content }
           
        };

        private string Content(TagHelperOutput output)
        {
           
            var attributes = output.Attributes.Where(x => x.Name.ToLowerInvariant() != "class").ToArray();
            var finalAttributes = attributes.Select(x => $"{x.Name}=\"{x.Value}\"");
            output.CleanAttributes(attributes.Select(x => x.Name).ToArray());

            var id = output.GetAndDeleteId();
            output.Attributes.SetAttribute("for",id);
            var content = $"<input type =\"checkbox\" id=\"{id}\" class=\"mdl-icon-toggle__input\" {string.Join(" ", finalAttributes)} >";
            content += $"<i class=\"mdl-icon-toggle__label material-icons\">{Icon.Ligature}</i>";
            return content;
        }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            {() => HasRipple, _=> "mdl-js-ripple-effect" }
        };
}
}
