using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(TagPrefix + "textfield")]
    public class Textfield : MdlTagHelperBase
    {
        [HtmlAttributeName("type")]
        public string Type { get; set; }

        [HtmlAttributeName("id")]
        public string Id { get; set; } = "gid_" + Guid.NewGuid();

        [HtmlAttributeName("label")]
        public string Label { get; set; }

        [HtmlAttributeName("floating-label")]
        public bool FloatingLabel { get; set; } = true;

        [HtmlAttributeName("error-message")]
        public string ErrorMessage { get; set; }

        [HtmlAttributeName("expendable-icon")]
        public MDLIcon ExpendableIcon { get; set; }

        public Textfield() : base(new[] { "mdl-textfield", "mdl-js-textfield" }, "div") { }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            { ()=> FloatingLabel,(_)=> "mdl-textfield--floating-label" }
        };

        protected override IList<ConditionnalContent> ConditionnalPreContents => new List<ConditionnalContent>
        {
            { ()=> ExpendableIcon != null, _ => $"<label class=\"mdl-button mdl-js-button mdl-button--icon\" for=\"{Id}\"><i class=\"material-icons\">{ExpendableIcon.Ligature}</i></label>"},
            { ()=> ExpendableIcon != null, _ => $"<div class=\"mdl-textfield__expandable-holder\">"},
            { ()=>true, CreateInput },
            { ()=>!string.IsNullOrEmpty(Label),(_)=> $"<label class=\"mdl-textfield__label\" for=\"{Id}\" >{Label}</label>"},
            { ()=>!string.IsNullOrEmpty(ErrorMessage),(_)=> $"<span class=\"mdl-textfield__error\" >{ErrorMessage}</span>"},
            { ()=> ExpendableIcon != null, _ => $"</div>"}

        };

        protected virtual string CreateInput(TagHelperOutput output)
        {
            var attributes = output.Attributes.Where(x => x.Name.ToLowerInvariant() != "class").ToArray();
            var finalAttributes = attributes.Select(x => $"{x.Name}=\"{x.Value}\"");
            output.CleanAttributes(attributes.Select(x => x.Name).ToArray());
            return $"<input {string.Join(" ", finalAttributes)} type=\"{Type}\" class=\"mdl-textfield__input\" id=\"{Id}\" />";
        }

    }

    [HtmlTargetElement(TagPrefix + "textarea")]
    public class TextArea : Textfield
    {
        [HtmlAttributeName("value")]
        public string Value { get; set; }

        protected override string CreateInput(TagHelperOutput output)
        {
            var attributes = output.Attributes.Where(x => x.Name.ToLowerInvariant() != "class").ToArray();
            var finalAttributes = attributes.Select(x => $"{x.Name}=\"{x.Value}\"");
            output.CleanAttributes(attributes.Select(x => x.Name).ToArray());
            return $"<textarea {string.Join(" ", finalAttributes)}  class=\"mdl-textfield__input\" id=\"{Id}\" >{Value}</textarea>";
        }

    }

}
