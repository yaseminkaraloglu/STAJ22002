using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace FazlaMesaiSureciYK.Forms
{
    [Route("apps/FazlaMesaiSureciYK/latest/api/FazlaMesaiNedenleri/[action]")]
    [Route("apps/FazlaMesaiSureciYK/{v:int:min(1)}/api/FazlaMesaiNedenleri/[action]")]
    [Route("api/FazlaMesaiNedenleri/[action]")]
    [Produces("application/json")]
    public class FazlaMesaiNedenleriController : BaseFormController<FazlaMesaiNedenleri>
    {
        public FazlaMesaiNedenleriController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "FazlaMesaiNedenleri API Controller is ok";            
        }
    }
}