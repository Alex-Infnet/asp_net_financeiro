using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Web.TagHelpers
{
    public class FormOutputMessage
    {
        public bool Valid { get; set; }
        public string? Message { get; set; }
    }
    [HtmlTargetElement("message")]
    public class MessageHelper : TagHelper
    {
        public FormOutputMessage outputMessage { get; set; }

        public MessageHelper()
        {
            outputMessage = new FormOutputMessage()
            {
                Valid = false,
                Message = ""
            };
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetHtmlContent("<div class='alert alert-success'>" +
                $"{outputMessage.Message}" +
                "</div>");
            output.TagMode = TagMode.StartTagAndEndTag;

            if (!outputMessage.Valid)
            {
                output.TagName = "div";
                output.Content.SetHtmlContent("<div class='alert alert-danger'>" +
                    $"{outputMessage.Message}" +
                    "</div>");
                output.TagMode = TagMode.StartTagAndEndTag;
            }
            base.Process(context, output);
        }
    }
}

