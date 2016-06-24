using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using static MaterialDesignLite.TagHelpers.MdlTagHelperExtension;

namespace MaterialDesignLite.TagHelpers
{
    [HtmlTargetElement(TagPrefix + "slider")]
    public class Slider : MdlTagHelperBase
    {
        public Slider() : base(new []{ "mdl-slider","mdl-js-slider" }, "input") {}

        protected override void AfterPRocess(TagHelperOutput output)
        {
            output.Attributes.Add("type","range");
        }
    }
}
