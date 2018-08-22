using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ERP.RazorLibrary.Helpers
{

    [HtmlTargetElement("form-control-user-roles")]
    public class FormControlUserRolesHelper : TagHelper
    {
        [HtmlAttributeName("asp-for")]
        public ModelExpression For { get; set; }

        [HtmlAttributeName("asp-rows")]
        public ModelExpression Rows { get; set; }

        private readonly IHtmlGenerator _generator;

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public FormControlUserRolesHelper(IHtmlGenerator generator)
        {
            _generator = generator;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            using (var writer = new StringWriter())
            {
                writer.Write(@"<div class=""form-group"">");

                var label = _generator.GenerateLabel(ViewContext, For.ModelExplorer, For.Name, null, new { @class = "control-label" });
                label.WriteTo(writer, NullHtmlEncoder.Default);

                var tagBuilder = _generator.GenerateTextArea(ViewContext, For.ModelExplorer, For.Name, (int)Rows.Model, 10, new { @class = "form-control", @disabled = "disabled" });

                tagBuilder.WriteTo(writer, NullHtmlEncoder.Default);
                writer.Write(@"</div>");

                output.Content.SetHtmlContent(writer.ToString());

            }

        }
    }
}
