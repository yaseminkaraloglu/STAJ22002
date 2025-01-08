using Bimser.CSP.DataSource.Api;
using Bimser.CSP.DataSource.Api.Base;
using Bimser.CSP.DataSource.Api.Models;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Bimser.Framework.Domain.Option;
using Bimser.Framework.Domain.Option.Filters;
using Bimser.Framework.Domain.Option.Pagination;
using Bimser.Framework.Domain.Option.Sorts;
using Bimser.Synergy.Entities.DataSource.Providers.Database;
using Bimser.Synergy.Entities.DataSource.Providers.Database.MSSQL;
using Bimser.Synergy.Entities.DataSource.Providers.Database.MYSQL;
using Bimser.Synergy.Entities.DataSource.Providers.Database.ODBC;
using Bimser.Synergy.Entities.DataSource.Providers.Database.Oracle;
using Bimser.Synergy.Entities.DataSource.Providers.GPT;
using Bimser.Synergy.Entities.DataSource.Providers.SAP;
using Bimser.Synergy.Entities.DataSource.Providers.WebService.Rest;
using Bimser.Synergy.Entities.DataSource.Providers.WebService.Soap.Objects;
using System.Collections.Generic;
using System.IO;

namespace FazlaMesaiSureciYK.DataSources 
{
    [Route("apps/FazlaMesaiSureciYK/latest/api/DataSource/[action]")]
    [Route("apps/FazlaMesaiSureciYK/{v:int:min(1)}/api/DataSource/[action]")]
    [Route("api/DataSource/[action]")]
    [Produces ("application/json")]
    [Authorize(AuthenticationSchemes = "BimserBearer")]
    public class DataSourceController : BaseDataSourceController 
    {

        #region [.ctor]

        public DataSourceController (IIocManager iocManager, string authorization = "", string bimserEncryptedData = "", string bimserLanguage = "", string bimserInstance = "") : base (iocManager, authorization, bimserEncryptedData, bimserLanguage, bimserInstance) 
        {

        }

        #endregion

        ///Actions
        [HttpPost]
[AcceptVerbs("POST")]
[ActionName("TalepAkisi_ProcessItems")]
public async Task<object> TalepAkisi_ProcessItems_Action([FromBody] TalepAkisi_ProcessItemsRequest request)
{
    return await TalepAkisi_ProcessItems(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("OdemeAkisi_ProcessItems")]
public async Task<object> OdemeAkisi_ProcessItems_Action([FromBody] OdemeAkisi_ProcessItemsRequest request)
{
    return await OdemeAkisi_ProcessItems(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("MesaiNedenleriGetir")]
public async Task<object> MesaiNedenleriGetir_Action([FromBody] MesaiNedenleriGetirRequest request)
{
    return await MesaiNedenleriGetir(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("OdemeTalepArsivi_DataSource")]
public async Task<object> OdemeTalepArsivi_DataSource_Action([FromBody] OdemeTalepArsivi_DataSourceRequest request)
{
    return await OdemeTalepArsivi_DataSource(request);
}

        ///Handles
        internal async Task<DataSourceResponse<object>> TalepAkisi_ProcessItems(TalepAkisi_ProcessItemsRequest request)
{
    string queryName = "TalepAkisi_ProcessItems";

    JObject queryContent = await DataSourceApi.GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = DataSourceApi.GetQueryDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = DataSourceApi.GetQueryStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(connectionId, context, HttpClientOptions.InternalApiUrl);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(queryContent, context, HttpClientOptions.InternalApiUrl);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> OdemeAkisi_ProcessItems(OdemeAkisi_ProcessItemsRequest request)
{
    string queryName = "OdemeAkisi_ProcessItems";

    JObject queryContent = await DataSourceApi.GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = DataSourceApi.GetQueryDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = DataSourceApi.GetQueryStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(connectionId, context, HttpClientOptions.InternalApiUrl);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(queryContent, context, HttpClientOptions.InternalApiUrl);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> MesaiNedenleriGetir(MesaiNedenleriGetirRequest request)
{
    string queryName = "MesaiNedenleriGetir";

    JObject queryContent = await DataSourceApi.GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = DataSourceApi.GetQueryDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = DataSourceApi.GetQueryStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(connectionId, context, HttpClientOptions.InternalApiUrl);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(queryContent, context, HttpClientOptions.InternalApiUrl);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> OdemeTalepArsivi_DataSource(OdemeTalepArsivi_DataSourceRequest request)
{
    string queryName = "OdemeTalepArsivi_DataSource";

    JObject queryContent = await DataSourceApi.GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = DataSourceApi.GetQueryDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = DataSourceApi.GetQueryStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(connectionId, context, HttpClientOptions.InternalApiUrl);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(queryContent, context, HttpClientOptions.InternalApiUrl);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

        ///Iterators
        [NonAction]
public IEnumerable<Dictionary<string, object>> TalepAkisi_ProcessItemsIterator(TalepAkisi_ProcessItemsRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = TalepAkisi_ProcessItems(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> OdemeAkisi_ProcessItemsIterator(OdemeAkisi_ProcessItemsRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = OdemeAkisi_ProcessItems(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> MesaiNedenleriGetirIterator(MesaiNedenleriGetirRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = MesaiNedenleriGetir(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> OdemeTalepArsivi_DataSourceIterator(OdemeTalepArsivi_DataSourceRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = OdemeTalepArsivi_DataSource(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

    }
}