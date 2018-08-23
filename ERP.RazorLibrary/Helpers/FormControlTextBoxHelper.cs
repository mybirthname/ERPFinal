using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ERP.RazorLibrary.Helpers
{
    [HtmlTargetElement("form-control-text-box")]
    public class FormControlTextBoxHelper:TagHelper
    {
        [HtmlAttributeName("asp-for")]
        public ModelExpression For { get; set; }

        [HtmlAttributeName("asp-disabled")]
        public bool Disabled { get; set; }

        private readonly IHtmlGenerator _generator;

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public FormControlTextBoxHelper(IHtmlGenerator generator)
        {
            _generator = generator;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            using (var writer = new StringWriter())
            {
                writer.Write(@"<div class=""form-group"">");

                var label = _generator.GenerateLabel(
                                ViewContext, 
                                For.ModelExplorer, 
                                For.Name, null, 
                                new { @class = "control-label" });

                label.WriteTo(writer, NullHtmlEncoder.Default);

                object htmlAttributes = null;
                if(Disabled)
                {
                    htmlAttributes = new { @class = "form-control", @disabled = "disabled" };
                }
                else
                {
                    htmlAttributes = new { @class = "form-control" };
                }

                var textArea = _generator.GenerateTextBox(ViewContext, 
                                    For.ModelExplorer, 
                                    For.Name, 
                                    For.Model, 
                                    null,
                                    htmlAttributes);

                textArea.WriteTo(writer, NullHtmlEncoder.Default);

                var validationMsg = _generator.GenerateValidationMessage(           
                                        ViewContext, 
                                        For.ModelExplorer, 
                                        For.Name, 
                                        null, 
                                        ViewContext.ValidationMessageElement, 
                                        new { @class = "text-danger" });

                validationMsg.WriteTo(writer, NullHtmlEncoder.Default);

                writer.Write(@"</div>");

                output.Content.SetHtmlContent(writer.ToString());

            }

        }
    }
}
