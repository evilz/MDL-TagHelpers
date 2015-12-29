using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaterialDesignLite.TagHelpers.StyleValues
{
    public enum MDLTypographies
    {
        display_4,
        display_3,
        display_2,
        display_1,
        headline,
        title
    }

    public static class MDLTypographiesExtention
    {
        public static string ToCssClass(this MDLTypographies MDLTypography)
        {
            return MDLTypography.ToString().Replace('_', '-');
        }
    }
}
