using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(TagPrefix + "nav")]
    public class Navigation : MdlTagHelperBase
    {
        public Navigation() : base("mdl-navigation", "nav") { }
    }

    [HtmlTargetElement("a", Attributes = TagPrefix + "nav-item")]
    public class NavigationLink : MdlTagHelperBase
    {
        public NavigationLink() :base("mdl-navigation__link") { }
 
    }

}
