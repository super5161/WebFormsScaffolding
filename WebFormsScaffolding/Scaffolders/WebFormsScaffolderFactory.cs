using System;
using System.ComponentModel.Composition;
using System.Runtime.Versioning;

namespace Microsoft.AspNet.Scaffolding.WebForms.Scaffolders
{

    /// <summary>
    /// 入口
    /// 代码生成器工厂
    /// </summary>
    [Export(typeof(CodeGeneratorFactory))]
    public class WebFormsScaffolderFactory : CodeGeneratorFactory
    {
        public WebFormsScaffolderFactory() : base(CreateCodeGeneratorInformation())
        {

        }

        //获取代码生成器
        public override ICodeGenerator CreateInstance(CodeGenerationContext context)
        {
            return new WebFormsScaffolder(context, Information);
        }

    
        ///支持判断
        public override bool IsSupported(CodeGenerationContext codeGenerationContext)
        {
            if (ProjectLanguage.CSharp.Equals(codeGenerationContext.ActiveProject.GetCodeLanguage()))
            {
                FrameworkName targetFramework = codeGenerationContext.ActiveProject.GetTargetFramework();
                return targetFramework != null &&
                           string.Equals(".NetFramework", targetFramework.Identifier, StringComparison.OrdinalIgnoreCase) &&
                           targetFramework.Version >= new Version(4, 5);
            }

            return false;
        }

        /// <summary>
        /// 获取描述信息
        /// </summary>
        /// <returns></returns>
        private static CodeGeneratorInformation CreateCodeGeneratorInformation()
        {
            return new CodeGeneratorInformation(
                displayName: Resources.WebFormsScaffolder_Name,
                description: Resources.WebFormsScaffolder_Description,
                author: "Outercurve Foundation",
                version: new Version(1, 0, 0, 0),
                id: typeof(WebFormsScaffolder).Name,
                icon: null,
                gestures: null,
                categories: new[] { "Common/Web Forms" }
            );
        }
    }
}
