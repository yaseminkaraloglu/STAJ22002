using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace FazlaMesaiSureciYK.Forms
{
    [Route("apps/FazlaMesaiSureciYK/latest/api/FazlaMesaiFormu/[action]")]
    [Route("apps/FazlaMesaiSureciYK/{v:int:min(1)}/api/FazlaMesaiFormu/[action]")]
    [Route("api/FazlaMesaiFormu/[action]")]
    [Produces("application/json")]
    public class FazlaMesaiFormuController : BaseFormController<FazlaMesaiFormu>
    {
        public FazlaMesaiFormuController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "FazlaMesaiFormu API Controller is ok";            
        }
    }
}