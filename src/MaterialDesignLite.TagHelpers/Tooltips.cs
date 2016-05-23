using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement("*", Attributes = MDLTagHelper.TagPrefix + Name)]
    public class TooltipsAttr : TagHelper
    {
        public const string Name = "tooltips";

        [HtmlAttributeName(MDLTagHelper.TagPrefix + Name)]
        public string Text { get; set; }

        [HtmlAttributeName(MDLTagHelper.TagPrefix + Name + "-large")]
        public bool IsLarge { get; set; }

        private string WeightClass => IsLarge ? "mdl-tooltip--large" : string.Empty;

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.CleanAttributes(MDLTagHelper.TagPrefix + Name);

            if (string.IsNullOrEmpty(Text))
                return;

            var id = output.GetOrCreateId();

            var tooltips = $"<div class=\"mdl-tooltip {WeightClass}\" for={id}>{Text}</div>";
            output.PostElement.AppendHtml(tooltips);
            await base.ProcessAsync(context, output);
        }





    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class TooltipsElm : TagHelper
    {
        public const string Name = "tooltips";
        private const string LargeAttrName = "large";
        private const string ForAttrNAme = "for";

        [HtmlAttributeName(LargeAttrName)]
        public bool IsLarge { get; set; }

        //[HtmlAttributeName(ForAttrNAme)]
        //public string For { get; set; }

        private string WeightClass => IsLarge ? "mdl-tooltip--large" : string.Empty;

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            //if (string.IsNullOrEmpty(For))
            //{
            //    output.SuppressOutput();
            //    return;
            //}

            output.CleanAttributes(LargeAttrName);
            output.TagName = "div";
            output.AppendCssClass("mdl-tooltip", WeightClass);

            await base.ProcessAsync(context, output);
        }

    }
}