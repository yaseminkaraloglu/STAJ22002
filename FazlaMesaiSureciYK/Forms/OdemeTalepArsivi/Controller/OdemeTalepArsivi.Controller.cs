using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace FazlaMesaiSureciYK.Forms
{
    [Route("apps/FazlaMesaiSureciYK/latest/api/OdemeTalepArsivi/[action]")]
    [Route("apps/FazlaMesaiSureciYK/{v:int:min(1)}/api/OdemeTalepArsivi/[action]")]
    [Route("api/OdemeTalepArsivi/[action]")]
    [Produces("application/json")]
    public class OdemeTalepArsiviController : BaseFormController<OdemeTalepArsivi>
    {
        public OdemeTalepArsiviController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "OdemeTalepArsivi API Controller is ok";            
        }
    }
}