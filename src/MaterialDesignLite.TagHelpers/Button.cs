using System;
using System.Collections.Generic;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{

    [HtmlTargetElement(TagPrefix + Name)]
    public class Button : MdlTagHelperBase
    {
        public Button()
            : base(new[] { "mdl-button", "mdl-js-button" }, "button") { }

        private const string Name = "button";

        [HtmlAttributeName("ripple")]
        public bool HasRipple { get; set; } = true;

        [HtmlAttributeName("raised")]
        public bool IsRaised { get; set; }

        [HtmlAttributeName("icon")]
        public bool HasIcon { get; set; }

        [HtmlAttributeName("fab")]
        public bool IsFab { get; set; }

        [HtmlAttributeName("mini")]
        public bool IsMiniFab { get; set; }

        [HtmlAttributeName("color")]
        public ButtonColors Color { get; set; }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
                {
                    { ()=> HasRipple,(_)=> "mdl-js-ripple-effect" },
                    { ()=> Color != ButtonColors.None,(_)=> $"mdl-button--{Color.ToString().ToLowerInvariant()}" },
                    { ()=> IsRaised,(_)=> "mdl-button--raised" },
                    { ()=> HasIcon,(_)=> "mdl-button--icon" },
                    { ()=> IsFab,(_)=> "mdl-button--fab" },
                    { ()=> IsFab && IsMiniFab,(_)=> "mdl-button--mini-fab" },
                };
    }

}
