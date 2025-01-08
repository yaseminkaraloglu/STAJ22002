using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace FazlaMesaiSureciYK.Forms
{
    [Route("apps/FazlaMesaiSureciYK/latest/api/FazlaMesaiOdemeFormu/[action]")]
    [Route("apps/FazlaMesaiSureciYK/{v:int:min(1)}/api/FazlaMesaiOdemeFormu/[action]")]
    [Route("api/FazlaMesaiOdemeFormu/[action]")]
    [Produces("application/json")]
    public class FazlaMesaiOdemeFormuController : BaseFormController<FazlaMesaiOdemeFormu>
    {
        public FazlaMesaiOdemeFormuController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "FazlaMesaiOdemeFormu API Controller is ok";            
        }
    }
}