using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MaterialDesignLite.TagHelpers
{
    public class ConditionnalContent
    {
        public ConditionnalContent(Func<bool> condition, Func<TagHelperOutput,string> content)
        {
            Condition = condition;
            Content = content;
        }

        public Func<bool> Condition { get; private set; }
        public Func<TagHelperOutput, string> Content { get; private set; }
        
    }

    public static class ConditionnalContentExt
    {
        public static void Add(this ICollection<ConditionnalContent> source, Func<bool> condition, Func<TagHelperOutput, string> content)
        {
            source.Add(new ConditionnalContent(condition, content));
        }

        public static IEnumerable<Func<TagHelperOutput, string>> AllOk(this ICollection<ConditionnalContent> source)
        {
            return source.Where(x => x.Condition()).Select(x => x.Content);
        }
    }
}