# Camunda.OpenApi.Client.Api.HistoricIdentityLinkLogApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHistoricIdentityLinks**](HistoricIdentityLinkLogApi.md#gethistoricidentitylinks) | **GET** /history/identity-link-log | Get Identity Link Logs
[**GetHistoricIdentityLinksCount**](HistoricIdentityLinkLogApi.md#gethistoricidentitylinkscount) | **GET** /history/identity-link-log/count | Get Identity Link Log Count


<a name="gethistoricidentitylinks"></a>
# **GetHistoricIdentityLinks**
> List&lt;HistoricIdentityLinkLogDto&gt; GetHistoricIdentityLinks (string type = null, string userId = null, string groupId = null, DateTime? dateBefore = null, DateTime? dateAfter = null, string taskId = null, string processDefinitionId = null, string processDefinitionKey = null, string operationType = null, string assignerId = null, string tenantIdIn = null, bool? withoutTenantId = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Identity Link Logs

Queries for historic identity link logs that fulfill given parameters. The size of the result set can be retrieved by using the [Get Identity-Link-Log Count](https://docs.camunda.org/manual/7.16/reference/rest/history/identity-links/get-identity-link-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricIdentityLinksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricIdentityLinkLogApi(config);
            var type = type_example;  // string | Restricts to identity links that have the given type (candidate/assignee/owner). (optional) 
            var userId = userId_example;  // string | Restricts to identity links that have the given user id. (optional) 
            var groupId = groupId_example;  // string | Restricts to identity links that have the given group id. (optional) 
            var dateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to identity links that have the time before the given time. (optional) 
            var dateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to identity links that have the time after the given time. (optional) 
            var taskId = taskId_example;  // string | Restricts to identity links that have the given task id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Restricts to identity links that have the given process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Restricts to identity links that have the given process definition key. (optional) 
            var operationType = operationType_example;  // string | Restricts to identity links that have the given operationType (add/delete). (optional) 
            var assignerId = assignerId_example;  // string | Restricts to identity links that have the given assigner id. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic identity links that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get Identity Link Logs
                List<HistoricIdentityLinkLogDto> result = apiInstance.GetHistoricIdentityLinks(type, userId, groupId, dateBefore, dateAfter, taskId, processDefinitionId, processDefinitionKey, operationType, assignerId, tenantIdIn, withoutTenantId, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricIdentityLinkLogApi.GetHistoricIdentityLinks: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Restricts to identity links that have the given type (candidate/assignee/owner). | [optional] 
 **userId** | **string**| Restricts to identity links that have the given user id. | [optional] 
 **groupId** | **string**| Restricts to identity links that have the given group id. | [optional] 
 **dateBefore** | **DateTime?**| Restricts to identity links that have the time before the given time. | [optional] 
 **dateAfter** | **DateTime?**| Restricts to identity links that have the time after the given time. | [optional] 
 **taskId** | **string**| Restricts to identity links that have the given task id. | [optional] 
 **processDefinitionId** | **string**| Restricts to identity links that have the given process definition id. | [optional] 
 **processDefinitionKey** | **string**| Restricts to identity links that have the given process definition key. | [optional] 
 **operationType** | **string**| Restricts to identity links that have the given operationType (add/delete). | [optional] 
 **assignerId** | **string**| Restricts to identity links that have the given assigner id. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic identity links that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;HistoricIdentityLinkLogDto&gt;**](HistoricIdentityLinkLogDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricidentitylinkscount"></a>
# **GetHistoricIdentityLinksCount**
> CountResultDto GetHistoricIdentityLinksCount (string type = null, string userId = null, string groupId = null, DateTime? dateBefore = null, DateTime? dateAfter = null, string taskId = null, string processDefinitionId = null, string processDefinitionKey = null, string operationType = null, string assignerId = null, string tenantIdIn = null, bool? withoutTenantId = null)

Get Identity Link Log Count

Queries for the number of historic identity link logs that fulfill the given parameters. Takes the same parameters as the [Get Identity-Link-Logs](https://docs.camunda.org/manual/7.16/reference/rest/history/identity-links/get-identity-link-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricIdentityLinksCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricIdentityLinkLogApi(config);
            var type = type_example;  // string | Restricts to identity links that have the given type (candidate/assignee/owner). (optional) 
            var userId = userId_example;  // string | Restricts to identity links that have the given user id. (optional) 
            var groupId = groupId_example;  // string | Restricts to identity links that have the given group id. (optional) 
            var dateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to identity links that have the time before the given time. (optional) 
            var dateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to identity links that have the time after the given time. (optional) 
            var taskId = taskId_example;  // string | Restricts to identity links that have the given task id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Restricts to identity links that have the given process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Restricts to identity links that have the given process definition key. (optional) 
            var operationType = operationType_example;  // string | Restricts to identity links that have the given operationType (add/delete). (optional) 
            var assignerId = assignerId_example;  // string | Restricts to identity links that have the given assigner id. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic identity links that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get Identity Link Log Count
                CountResultDto result = apiInstance.GetHistoricIdentityLinksCount(type, userId, groupId, dateBefore, dateAfter, taskId, processDefinitionId, processDefinitionKey, operationType, assignerId, tenantIdIn, withoutTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricIdentityLinkLogApi.GetHistoricIdentityLinksCount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Restricts to identity links that have the given type (candidate/assignee/owner). | [optional] 
 **userId** | **string**| Restricts to identity links that have the given user id. | [optional] 
 **groupId** | **string**| Restricts to identity links that have the given group id. | [optional] 
 **dateBefore** | **DateTime?**| Restricts to identity links that have the time before the given time. | [optional] 
 **dateAfter** | **DateTime?**| Restricts to identity links that have the time after the given time. | [optional] 
 **taskId** | **string**| Restricts to identity links that have the given task id. | [optional] 
 **processDefinitionId** | **string**| Restricts to identity links that have the given process definition id. | [optional] 
 **processDefinitionKey** | **string**| Restricts to identity links that have the given process definition key. | [optional] 
 **operationType** | **string**| Restricts to identity links that have the given operationType (add/delete). | [optional] 
 **assignerId** | **string**| Restricts to identity links that have the given assigner id. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic identity links that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

### Return type

[**CountResultDto**](CountResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

