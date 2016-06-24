using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(TagPrefix + "checkbox")]
    public class Checkbox : MdlTagHelperBase
    {
        public Checkbox() : base(new []{ "mdl-checkbox","mdl-js-checkbox"},"label") {}

        [HtmlAttributeName("ripple")]
        public bool HasRipple { get; set; } = true;
        
        [HtmlAttributeName("label")]
        public string Label { get; set; }

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
            var content = $"<input type =\"checkbox\" id=\"{id}\" class=\"mdl-checkbox__input\" {string.Join(" ", finalAttributes)} >";
            content += $"<span class=\"mdl-checkbox__label\">{Label}</span>";
            return content;
        }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            {() => HasRipple, _=> "mdl-js-ripple-effect" }
        };
}
}
