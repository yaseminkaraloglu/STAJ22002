using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Microsoft.AspNetCore.Mvc;

namespace EgitimTalepDegerlendirmeSureci.Project
{
    [Route("apps/EgitimTalepDegerlendirmeSureci/latest/api/project/forms/[action]")]
    [Route("apps/EgitimTalepDegerlendirmeSureci/{v:int:min(1)}/api/project/forms/[action]")]
    [Route("api/project/forms/[action]")]
    [Produces("application/json")]
    public class ProjectFormsController : BaseProjectFormsController
    {
        public ProjectFormsController(IIocManager iocManager)
            : base(iocManager)
        {
        }
    }
}