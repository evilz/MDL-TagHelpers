using System;
using System.Linq;
using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class Card : TagHelper
    {
        private const string Name = "card";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            output.AppendCssClass("mdl-card");
            await base.ProcessAsync(context, output);
        }

    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class CardTitle : TagHelper
    {
        private const string Name = "card-title";

        public CardTitle()
        {
            TitleSize = MdlCardTitleSize.H2;
        }

        [HtmlAttributeName("title-size")]
        public MdlCardTitleSize TitleSize { get; set; }

        [HtmlAttributeName("title")]
        public string Title { get; set; }

        [HtmlAttributeName("subtitle")]
        public string Subtitle { get; set; }

        [HtmlAttributeName("expand")]
        public bool Expand { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AppendCssClass("mdl-card__title");
            if (Expand)
            { output.AppendCssClass("mdl-card--expand"); }


            var content = string.Empty;

            if (!string.IsNullOrEmpty(Title))
            {
                content += $"<{TitleSize.ToString().ToLowerInvariant()} class=\"mdl-card__title-text\" >{Title}</{TitleSize.ToString().ToLowerInvariant()}>";
            }

            if (!string.IsNullOrEmpty(Subtitle))
            {
                content += $"<div class=\"mdl-card__subtitle-text\" >{Subtitle}</div>";
            }

            output.CleanAttributes("subtitle","title");
            output.Content.SetHtmlContent(content);

            await base.ProcessAsync(context, output);
        }
    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class CardMedia : TagHelper
    {
        private const string Name = "card-media";
        
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            

            var content = $"<img ";
            content = output.Attributes.Aggregate(content,
                (accumulator, attribute) => accumulator + attribute.Name + "=\"" + attribute.Value + "\"");
            content += " />";

            output.Attributes.Clear();

            output.AppendCssClass("mdl-card__media");

            output.Content.SetHtmlContent(content);
            await base.ProcessAsync(context, output);
        }
    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class CardSupportingText : TagHelper
    {
        private const string Name = "card-supporting-text";
        
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AppendCssClass("mdl-card__supporting-text");
            await base.ProcessAsync(context, output);
        }
    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class CardActions : TagHelper
    {
        private const string Name = "card-actions";

        [HtmlAttributeName("title-size")]
        public MdlCardTitleSize TitleSize { get; set; }

        [HtmlAttributeName("border")]
        public bool Border { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AppendCssClass("mdl-card__actions");

            if (Border)
            { output.AppendCssClass("mdl-card--border"); }

            await base.ProcessAsync(context, output);
        }
    }

    [HtmlTargetElement(MDLTagHelper.TagPrefix + Name)]
    public class CardMenu : TagHelper
    {
        private const string Name = "card-menu";
        
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AppendCssClass("mdl-card__menu");
            
            await base.ProcessAsync(context, output);
        }
    }
    
    

}
