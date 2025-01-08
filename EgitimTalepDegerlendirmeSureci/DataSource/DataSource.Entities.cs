using System;
using System.Collections.Generic;
using System.Linq;
using Bimser.CSP.DataSource.Api.Models;
using Newtonsoft.Json;

namespace EgitimTalepDegerlendirmeSureci.DataSources
{
   ///RequestEntities
  public class EgitimBilgileriBetirRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            
        };
    }
}

public class FlowEgitimTalep_ProcessItemsRequest : DataSourceFlowProcessItemsRequest
{
}

public class FlowEgitimPlanlama_ProcessItemsRequest : DataSourceFlowProcessItemsRequest
{
}

public class FlowEgitimAnket_ProcessItemsRequest : DataSourceFlowProcessItemsRequest
{
}

public class KatilimciGetirRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            
        };
    }
}

public class FlowEgitimTalep_Process_Archive_DataSourceRequest : BaseDataSourceDatabaseRequest
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