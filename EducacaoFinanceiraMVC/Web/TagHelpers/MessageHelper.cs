using System;
using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Web.TagHelpers
{
    [HtmlTargetElement("message")]
	public class MessageHelper : TagHelper
	{
        public string? Message { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.PreContent.SetHtmlContent(this.Message);
        }
    }
}

