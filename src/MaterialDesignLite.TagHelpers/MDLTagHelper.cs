using System;
using Microsoft.AspNet.Razor.TagHelpers;
using System.Linq;

namespace MaterialDesignLite.TagHelpers
{
    public static class MDLTagHelper
    {
        public const string TagPrefix = "mdl-";

        public static void CleanAttributes(this TagHelperOutput output, params string[] attributeNames)
        {
            foreach (var attribute in attributeNames)
            {
                output.Attributes.RemoveAll(attribute);
            }
        }

        public static void AppendCssClass(this TagHelperOutput output, params string[] cssClass)
        {
            var currentValue = output.Attributes.ContainsName("class") 
                ? output.Attributes["class"].Value.ToString() 
                : string.Empty;

            var finalCssClass = cssClass.ToList();
            finalCssClass.Insert(0, currentValue);

            output.Attributes["class"] = string.Join(" ", finalCssClass);
        }

        public static string GetOrCreateId(this TagHelperOutput output)
        {
            if (output.Attributes.ContainsName("id"))
            {
                return output.Attributes["id"].Value.ToString();
            }
            
            var id = Guid.NewGuid().ToString();
            output.Attributes["id"] = "gid_"+id;
            return id;
        }

        public static string GetChildContent(this TagHelperOutput output)
        {
           return output.Content.IsModified
                ? output.Content.GetContent() :
                output.GetChildContentAsync().Result.GetContent();
        } 
    }
}
