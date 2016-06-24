using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{

    [HtmlTargetElement(TagPrefix + "menu")]
    public class Menu : MdlTagHelperBase
    {
        private static Dictionary<MenuDirection, string> directionClass = new Dictionary<MenuDirection, string>
        {
            { MenuDirection.TopLeft,"mdl-menu--top-left" },
            { MenuDirection.TopRight,"mdl-menu--top-right" },
            { MenuDirection.BottomRight,"mdl-menu--bottom-right" },
            { MenuDirection.BottomLeft,"" }
         };

        [HtmlAttributeName("direction")]
        public MenuDirection Direction { get; set; } = MenuDirection.BottomLeft;

        [HtmlAttributeName("ripple")]
        public bool Ripple { get; set; } = true;

        public Menu() : base(new[] { "mdl-menu", "mdl-js-menu" }, "ul") { }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            { () => true, _ =>  directionClass[Direction] },
            { () => Ripple, _ => "mdl-js-ripple-effect" },
        };
    }

    [HtmlTargetElement(TagPrefix + "menu-item")]
    public class MenuItem : MdlTagHelperBase
    {
        [HtmlAttributeName("bleed-divider")]
        public bool BleedDivider { get; set; }

        public MenuItem() : base("mdl-menu__item","li") { }

        protected override IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>
        {
            { () => BleedDivider, _ => "mdl-menu__item--full-bleed-divider" }
        };
    }

}
