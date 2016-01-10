using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class Button : TagHelper
    {
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
        
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";

            output.AppendCssClass("mdl-button","mdl-js-button");

            if (HasRipple)
            { output.AppendCssClass("mdl-js-ripple-effect");}

            if(Color != ButtonColors.None)
            { output.AppendCssClass($"mdl-button--{Color.ToString().ToLowerInvariant()}"); }

            if (IsRaised)
            { output.AppendCssClass("mdl-button--raised"); }

            if (HasIcon)
            { output.AppendCssClass("mdl-button--icon"); }

            if (IsFab)
            { output.AppendCssClass("mdl-button--fab"); }

            if (IsFab && IsMiniFab)
            { output.AppendCssClass("mdl-button--mini-fab"); }

            await base.ProcessAsync(context, output);
        }

    }
   
}
