using System;
using System.Collections.Generic;
using System.Linq;
using Bimser.CSP.DataSource.Api.Models;
using Newtonsoft.Json;

namespace FazlaMesaiSureciYK.DataSources
{
   ///RequestEntities
  public class TalepAkisi_ProcessItemsRequest : DataSourceFlowProcessItemsRequest
{
}

public class OdemeAkisi_ProcessItemsRequest : DataSourceFlowProcessItemsRequest
{
}

public class MesaiNedenleriGetirRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            
        };
    }
}

public class OdemeTalepArsivi_DataSourceRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.String Culture { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "Culture", Culture }
        };
    }
}
}