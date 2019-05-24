using EnvDTE;
using System;

namespace Microsoft.AspNet.Scaffolding.WebForms.UI
{
    /// <summary>
    /// Wrapper around CodeType for allowing string values.
    /// </summary>
    public class ModelType
    {
        public ModelType(CodeType codeType)
        {
            CodeType = codeType ?? throw new ArgumentNullException("codeType");
            TypeName = codeType.FullName;
            DisplayName = (codeType.Namespace != null && !string.IsNullOrWhiteSpace(codeType.Namespace.FullName))
                              ? string.Format("{0} ({1})", codeType.Name, codeType.Namespace.FullName)
                              : codeType.Name;
        }

        public ModelType(string typeName)
        {
            CodeType = null;
            TypeName = typeName;
            DisplayName = typeName;
        }

        public CodeType CodeType { get; set; }

        public string TypeName { get; set; }

        public string DisplayName { get; set; }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
