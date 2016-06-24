using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace MaterialDesignLite.TagHelpers
{
    public abstract class MdlTagHelperBase : TagHelper
    {
        private readonly string _outputTag;
        private readonly TagMode _tagMode;
        private readonly string[] _defaultCssClass;
        
        protected MdlTagHelperBase(string[] defaultCssClass, string outputTag = null, TagMode tagmode = TagMode.StartTagAndEndTag ) 
        {
            _defaultCssClass = defaultCssClass;
            _outputTag = outputTag;
            _tagMode = tagmode;
        }

        protected MdlTagHelperBase(string defaultCssClass, string outputTag = null, TagMode tagmode = TagMode.StartTagAndEndTag) 
            : this(new[] {defaultCssClass},outputTag,tagmode)
        {}

        protected MdlTagHelperBase(): this(string.Empty) {}

        protected virtual IList<ConditionnalContent> ConditionnalCssClasses => new List<ConditionnalContent>();
        protected virtual IDictionary<string, string> SpecialAttributs => new Dictionary<string, string>();

        protected virtual IList<ConditionnalContent> ConditionnalPreContents => new List<ConditionnalContent>();
        protected virtual IList<ConditionnalContent> ConditionnalContents => new List<ConditionnalContent>();

        protected virtual IList<ConditionnalContent> ConditionnalPostContents => new List<ConditionnalContent>();

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
         
            SetTagName(output);
            SetTagMode(output);
            SetDefaultCssClass(output);
            SetConditionnalCssClass(output);
            SetAttributs(output);
            SetPreContent(output);
            SetContent(output);
            SetPostContent(output);
            AfterPRocess(output);


        }

        private void SetTagMode(TagHelperOutput output)
        {
            output.TagMode = _tagMode;
        }

        protected virtual void AfterPRocess(TagHelperOutput output) { }

        private void SetPreContent(TagHelperOutput output)
        {
            if (ConditionnalPreContents.AllOk().Any())
            {
                output.PreContent.SetHtmlContent(string.Join(" ", ConditionnalPreContents.AllOk().Select(x => x.Invoke(output))));
            }
        }

        private void SetPostContent(TagHelperOutput output)
        {
            if (ConditionnalPostContents.AllOk().Any())
            {
                output.PostContent.SetHtmlContent(string.Join(" ", ConditionnalPostContents.AllOk().Select(x => x.Invoke(output))));
            }
        }

        private void  SetContent(TagHelperOutput output)
        {
            if (ConditionnalContents.AllOk().Any())
            {
                output.Content.SetHtmlContent(string.Join(" ", ConditionnalContents.AllOk().Select(x => x.Invoke(output))));
            }
        }

        private void SetAttributs(TagHelperOutput output)
        {
            foreach (var specialAttribut in SpecialAttributs)
            {
                output.Attributes.Add(specialAttribut.Key, specialAttribut.Value);
            }
        }

        private void SetConditionnalCssClass(TagHelperOutput output)
        {
            foreach (var conditionnalCss in ConditionnalCssClasses.AllOk())
            {
                output.AppendCssClass(conditionnalCss(output));
            }
        }

        private void SetDefaultCssClass(TagHelperOutput output)
        {
            output.AppendCssClass(_defaultCssClass);
        }

        private void SetTagName(TagHelperOutput output)
        {
            if (!string.IsNullOrEmpty(_outputTag))
            {
                output.TagName = _outputTag;
            }
        }
    }
}
