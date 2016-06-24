using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(TagPrefix + Name)]
    public class Card : MdlTagHelperBase
    {
        private const string Name = "card";
        public Card() : base("mdl-card", "div") { }
    }

    [HtmlTargetElement(TagPrefix + Name)]
    public class CardTitle : MdlTagHelperBase
    {
        private const string Name = "card-title";

        public CardTitle() : base("mdl-card__title", "div") { }

        [HtmlAttributeName("title-size")]
        public MdlCardTitleSize TitleSize { get; set; } = MdlCardTitleSize.H2;

        [HtmlAttributeName("title")]
        public string Title { get; set; }

        [HtmlAttributeName("subtitle")]
        public string Subtitle { get; set; }

        [HtmlAttributeName("expand")]
        public bool Expand { get; set; }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
                    { ()=> Expand, (_)=> "mdl-card--expand"}
        };

        private string TitleSizeTag => TitleSize.ToString().ToLowerInvariant();

        protected override IList<ConditionnalContent> ConditionnalPreContents => new List<ConditionnalContent>
        {
            { ()=> !string.IsNullOrEmpty(Title),(_)=> $"<{TitleSizeTag} class=\"mdl-card__title-text\" >{Title}</{TitleSizeTag}>"},
             { () => !string.IsNullOrEmpty(Subtitle),(_)=> $"<div class=\"mdl-card__subtitle-text\" >{Subtitle}</div>"},

        };
    }

    [HtmlTargetElement(TagPrefix + Name)]
    public class CardMedia : MdlTagHelperBase
    {
        private const string Name = "card-media";

        public CardMedia() : base("mdl-card__media", "div") { }

        protected override IList<ConditionnalContent> ConditionnalPreContents => new List<ConditionnalContent>
        {
            { ()=> true, (o) => CreateImg(o) }
        };

        public string CreateImg(TagHelperOutput output)
        {
            var attributes = output.Attributes.Select(x => x.Name + "=\"" + x.Value + "\"");
            return $"<img {string.Join(" ", attributes)} />";
        }
    }

    [HtmlTargetElement(TagPrefix + Name)]
    public class CardSupportingText : MdlTagHelperBase
    {
        private const string Name = "card-supporting-text";

        public CardSupportingText() : base("mdl-card__supporting-text", "div") { }
    }

    [HtmlTargetElement(TagPrefix + Name)]
    public class CardActions : MdlTagHelperBase
    {
        private const string Name = "card-actions";

        [HtmlAttributeName("title-size")]
        public MdlCardTitleSize TitleSize { get; set; }

        [HtmlAttributeName("border")]
        public bool Border { get; set; }

        public CardActions() : base("mdl-card__actions", "div") { }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            { () => Border, (_) => "mdl-card--border"}
        };
    }

    [HtmlTargetElement(TagPrefix + Name)]
    public class CardMenu : MdlTagHelperBase
    {
        private const string Name = "card-menu";

        public CardMenu() : base("mdl-card__menu", "div") { }
    }

}
