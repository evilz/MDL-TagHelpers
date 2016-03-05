using System.Threading.Tasks;
using MaterialDesignLite.TagHelpers.StyleValues;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    //[HtmlTargetElement("mdl-badge")]
    //public class Badge : TagHelper
    //{
    //    [HtmlAttributeName("data")]
    //    public string Data { get; set; }

    //    [HtmlAttributeName("class")]
    //    public string CssClass { get; set; }

    //    [HtmlAttributeName("color")]
    //    public string Color { get; set; }

    //    [HtmlAttributeName("href")]
    //    public string HRef { get; set; }

    //    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    //    {
    //        output.Attributes.RemoveAll("data");
    //        output.Attributes.RemoveAll("class");
    //        output.Attributes.RemoveAll("href");


    //        // TODO : convert to class add class to tag 
    //        output.Attributes.RemoveAll("color");


    //        if (string.IsNullOrEmpty(Data))
    //            return;

    //        output.TagName = "a";

    //        if (string.IsNullOrEmpty(HRef))
    //        {
    //            output.TagName = "span";
    //        }

    //         CssClass += " mdl-badge";

    //        output.Attributes["class"] = CssClass;

    //        output.Attributes.Add("data-badge",Data);

    //        await base.ProcessAsync(context, output);
    //    }

    //}

    [HtmlTargetElement(Attributes = MDLTagHelper.TagPrefix + Name)]
    public class Badge : TagHelper
    {
        private const string Name = "badge";

        [HtmlAttributeName(MDLTagHelper.TagPrefix + Name)]
        public string Data { get; set; }

        [HtmlAttributeName(MDLTagHelper.TagPrefix + Name + "-color")]
        public MDLColor Color { get; set; }
        
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.IsNullOrEmpty(Data))
                return;
            
            output.AppendCssClass("mdl-badge");
            output.Attributes.Add("data-badge", Data);

            if (Color != null)
            {
                output.AppendCssClass("mdl-color-badge--" + Color); // TODO
            }

            await base.ProcessAsync(context, output);
        }

    }

}
