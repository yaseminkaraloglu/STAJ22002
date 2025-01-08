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

namespace EgitimTalepDegerlendirmeSureci.DataSources 
{
    [Route("apps/EgitimTalepDegerlendirmeSureci/latest/api/DataSource/[action]")]
    [Route("apps/EgitimTalepDegerlendirmeSureci/{v:int:min(1)}/api/DataSource/[action]")]
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
[ActionName("EgitimBilgileriBetir")]
public async Task<object> EgitimBilgileriBetir_Action([FromBody] EgitimBilgileriBetirRequest request)
{
    return await EgitimBilgileriBetir(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("FlowEgitimTalep_ProcessItems")]
public async Task<object> FlowEgitimTalep_ProcessItems_Action([FromBody] FlowEgitimTalep_ProcessItemsRequest request)
{
    return await FlowEgitimTalep_ProcessItems(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("FlowEgitimPlanlama_ProcessItems")]
public async Task<object> FlowEgitimPlanlama_ProcessItems_Action([FromBody] FlowEgitimPlanlama_ProcessItemsRequest request)
{
    return await FlowEgitimPlanlama_ProcessItems(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("FlowEgitimAnket_ProcessItems")]
public async Task<object> FlowEgitimAnket_ProcessItems_Action([FromBody] FlowEgitimAnket_ProcessItemsRequest request)
{
    return await FlowEgitimAnket_ProcessItems(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("KatilimciGetir")]
public async Task<object> KatilimciGetir_Action([FromBody] KatilimciGetirRequest request)
{
    return await KatilimciGetir(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("FlowEgitimTalep_Process_Archive_DataSource")]
public async Task<object> FlowEgitimTalep_Process_Archive_DataSource_Action([FromBody] FlowEgitimTalep_Process_Archive_DataSourceRequest request)
{
    return await FlowEgitimTalep_Process_Archive_DataSource(request);
}

        ///Handles
        internal async Task<DataSourceResponse<object>> EgitimBilgileriBetir(EgitimBilgileriBetirRequest request)
{
    string queryName = "EgitimBilgileriBetir";

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

internal async Task<DataSourceResponse<object>> FlowEgitimTalep_ProcessItems(FlowEgitimTalep_ProcessItemsRequest request)
{
    string queryName = "FlowEgitimTalep_ProcessItems";

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

internal async Task<DataSourceResponse<object>> FlowEgitimPlanlama_ProcessItems(FlowEgitimPlanlama_ProcessItemsRequest request)
{
    string queryName = "FlowEgitimPlanlama_ProcessItems";

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

internal async Task<DataSourceResponse<object>> FlowEgitimAnket_ProcessItems(FlowEgitimAnket_ProcessItemsRequest request)
{
    string queryName = "FlowEgitimAnket_ProcessItems";

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

internal async Task<DataSourceResponse<object>> KatilimciGetir(KatilimciGetirRequest request)
{
    string queryName = "KatilimciGetir";

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

internal async Task<DataSourceResponse<object>> FlowEgitimTalep_Process_Archive_DataSource(FlowEgitimTalep_Process_Archive_DataSourceRequest request)
{
    string queryName = "FlowEgitimTalep_Process_Archive_DataSource";

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
public IEnumerable<Dictionary<string, object>> EgitimBilgileriBetirIterator(EgitimBilgileriBetirRequest request)
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

        var response = EgitimBilgileriBetir(request).Result;
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
public IEnumerable<Dictionary<string, object>> FlowEgitimTalep_ProcessItemsIterator(FlowEgitimTalep_ProcessItemsRequest request)
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

        var response = FlowEgitimTalep_ProcessItems(request).Result;
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
public IEnumerable<Dictionary<string, object>> FlowEgitimPlanlama_ProcessItemsIterator(FlowEgitimPlanlama_ProcessItemsRequest request)
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

        var response = FlowEgitimPlanlama_ProcessItems(request).Result;
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
public IEnumerable<Dictionary<string, object>> FlowEgitimAnket_ProcessItemsIterator(FlowEgitimAnket_ProcessItemsRequest request)
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

        var response = FlowEgitimAnket_ProcessItems(request).Result;
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
public IEnumerable<Dictionary<string, object>> KatilimciGetirIterator(KatilimciGetirRequest request)
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

        var response = KatilimciGetir(request).Result;
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
public IEnumerable<Dictionary<string, object>> FlowEgitimTalep_Process_Archive_DataSourceIterator(FlowEgitimTalep_Process_Archive_DataSourceRequest request)
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

        var response = FlowEgitimTalep_Process_Archive_DataSource(request).Result;
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