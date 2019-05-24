using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Scaffolding.WebForms.Utils
{
    internal class VisualStudioUtils
    {

        private DTE2 _dte;

        internal VisualStudioUtils()
        {
            this._dte = Package.GetGlobalService(typeof(DTE)) as DTE2;
        }

        //编译项目
        internal void BuildProject(Project project)
        {
            var solutionConfiguration = _dte.Solution.SolutionBuild.ActiveConfiguration.Name;
            if (project == null)
            {
                throw new NullReferenceException("project");
            }

            _dte.Solution.SolutionBuild.BuildProject(solutionConfiguration, project.FullName, true);
        }


    }
}
