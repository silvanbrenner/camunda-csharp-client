# Camunda.OpenApi.Client.Api.HistoricProcessDefinitionApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCleanableHistoricProcessInstanceReport**](HistoricProcessDefinitionApi.md#getcleanablehistoricprocessinstancereport) | **GET** /history/process-definition/cleanable-process-instance-report | Get Cleanable Process Instance Report
[**GetCleanableHistoricProcessInstanceReportCount**](HistoricProcessDefinitionApi.md#getcleanablehistoricprocessinstancereportcount) | **GET** /history/process-definition/cleanable-process-instance-report/count | Get Cleanable Process Instance Report Count
[**GetHistoricActivityStatistics**](HistoricProcessDefinitionApi.md#gethistoricactivitystatistics) | **GET** /history/process-definition/{id}/statistics | Get Historic Activity Statistics


<a name="getcleanablehistoricprocessinstancereport"></a>
# **GetCleanableHistoricProcessInstanceReport**
> List&lt;CleanableHistoricProcessInstanceReportResultDto&gt; GetCleanableHistoricProcessInstanceReport (string processDefinitionIdIn = null, string processDefinitionKeyIn = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? compact = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Cleanable Process Instance Report

Retrieves a report about a process definition and finished process instances relevant to history cleanup (see [History cleanup](https://docs.camunda.org/manual/7.17/user-guide/process-engine/history/#history-cleanup))  so that you can tune the history time to live. These reports include the count of the finished historic process instances, cleanable process instances and basic process definition data - id, key, name and version. The size of the result set can be retrieved by using the [Get Cleanable Process Instance Report Count](https://docs.camunda.org/manual/7.17/reference/rest/history/process-definition/get-cleanable-process-instance-report-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetCleanableHistoricProcessInstanceReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricProcessDefinitionApi(httpClient, config, httpClientHandler);
            var processDefinitionIdIn = processDefinitionIdIn_example;  // string | Filter by process definition ids. Must be a comma-separated list of process definition ids. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Filter by process definition keys. Must be a comma-separated list of process definition keys. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A process definition must have one of the given  tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include process definitions which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var compact = true;  // bool? | Only include process instances which have more than zero finished instances. Value may only be `true`, as `false` is the default behavior. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get Cleanable Process Instance Report
                List<CleanableHistoricProcessInstanceReportResultDto> result = apiInstance.GetCleanableHistoricProcessInstanceReport(processDefinitionIdIn, processDefinitionKeyIn, tenantIdIn, withoutTenantId, compact, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessDefinitionApi.GetCleanableHistoricProcessInstanceReport: " + e.Message );
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
 **processDefinitionIdIn** | **string**| Filter by process definition ids. Must be a comma-separated list of process definition ids. | [optional] 
 **processDefinitionKeyIn** | **string**| Filter by process definition keys. Must be a comma-separated list of process definition keys. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A process definition must have one of the given  tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include process definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **compact** | **bool?**| Only include process instances which have more than zero finished instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;CleanableHistoricProcessInstanceReportResultDto&gt;**](CleanableHistoricProcessInstanceReportResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **500** | See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcleanablehistoricprocessinstancereportcount"></a>
# **GetCleanableHistoricProcessInstanceReportCount**
> CountResultDto GetCleanableHistoricProcessInstanceReportCount (string processDefinitionIdIn = null, string processDefinitionKeyIn = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? compact = null)

Get Cleanable Process Instance Report Count

Queries for the number of report results about a process definition and finished process instances relevant to history cleanup (see [History cleanup](https://docs.camunda.org/manual/7.17/user-guide/process-engine/history/#history-cleanup)). Takes the same parameters as the [Get Cleanable Process Instance Report](https://docs.camunda.org/manual/7.17/reference/rest/history/process-definition/get-cleanable-process-instance-report/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetCleanableHistoricProcessInstanceReportCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricProcessDefinitionApi(httpClient, config, httpClientHandler);
            var processDefinitionIdIn = processDefinitionIdIn_example;  // string | Filter by process definition ids. Must be a comma-separated list of process definition ids. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Filter by process definition keys. Must be a comma-separated list of process definition keys. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A process definition must have one of the given  tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include process definitions which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var compact = true;  // bool? | Only include process instances which have more than zero finished instances. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get Cleanable Process Instance Report Count
                CountResultDto result = apiInstance.GetCleanableHistoricProcessInstanceReportCount(processDefinitionIdIn, processDefinitionKeyIn, tenantIdIn, withoutTenantId, compact);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessDefinitionApi.GetCleanableHistoricProcessInstanceReportCount: " + e.Message );
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
 **processDefinitionIdIn** | **string**| Filter by process definition ids. Must be a comma-separated list of process definition ids. | [optional] 
 **processDefinitionKeyIn** | **string**| Filter by process definition keys. Must be a comma-separated list of process definition keys. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A process definition must have one of the given  tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include process definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **compact** | **bool?**| Only include process instances which have more than zero finished instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

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
| **500** | See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricactivitystatistics"></a>
# **GetHistoricActivityStatistics**
> List&lt;HistoricActivityStatisticsDto&gt; GetHistoricActivityStatistics (string id, bool? canceled = null, bool? finished = null, bool? completeScope = null, bool? incidents = null, DateTime? startedBefore = null, DateTime? startedAfter = null, DateTime? finishedBefore = null, DateTime? finishedAfter = null, string processInstanceIdIn = null, string sortBy = null, string sortOrder = null)

Get Historic Activity Statistics

Retrieves historic statistics of a given process definition, grouped by activities. These statistics include the number of running activity instances and, optionally, the number of canceled activity instances, finished activity instances and activity instances which completed a scope (i.e., in BPMN 2.0 manner: a scope is completed by an activity instance when the activity instance consumed a token but did not emit a new token). **Note:** This only includes historic data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricActivityStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricProcessDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the process definition.
            var canceled = true;  // bool? | Whether to include the number of canceled activity instances in the result or not. Valid values are `true` or `false`. Default: `false`. (optional) 
            var finished = true;  // bool? | Whether to include the number of finished activity instances in the result or not. Valid values are `true` or `false`. Default: `false`. (optional) 
            var completeScope = true;  // bool? | Whether to include the number of activity instances which completed a scope in the result or not. Valid values are `true` or `false`. Default: `false`. (optional) 
            var incidents = true;  // bool? | Whether to include the number of incidents. Valid values are `true` or `false`. Default: `false`. (optional) 
            var startedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to process instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/),  the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`,  e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to process instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/),  the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`,  e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to process instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/),  the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`,  e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to process instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/),  the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`,  e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var processInstanceIdIn = processInstanceIdIn_example;  // string | Restrict to process instances with the given IDs. The IDs must be provided as a comma- separated list. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 

            try
            {
                // Get Historic Activity Statistics
                List<HistoricActivityStatisticsDto> result = apiInstance.GetHistoricActivityStatistics(id, canceled, finished, completeScope, incidents, startedBefore, startedAfter, finishedBefore, finishedAfter, processInstanceIdIn, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessDefinitionApi.GetHistoricActivityStatistics: " + e.Message );
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
 **id** | **string**| The id of the process definition. | 
 **canceled** | **bool?**| Whether to include the number of canceled activity instances in the result or not. Valid values are &#x60;true&#x60; or &#x60;false&#x60;. Default: &#x60;false&#x60;. | [optional] 
 **finished** | **bool?**| Whether to include the number of finished activity instances in the result or not. Valid values are &#x60;true&#x60; or &#x60;false&#x60;. Default: &#x60;false&#x60;. | [optional] 
 **completeScope** | **bool?**| Whether to include the number of activity instances which completed a scope in the result or not. Valid values are &#x60;true&#x60; or &#x60;false&#x60;. Default: &#x60;false&#x60;. | [optional] 
 **incidents** | **bool?**| Whether to include the number of incidents. Valid values are &#x60;true&#x60; or &#x60;false&#x60;. Default: &#x60;false&#x60;. | [optional] 
 **startedBefore** | **DateTime?**| Restrict to process instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/),  the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;,  e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedAfter** | **DateTime?**| Restrict to process instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/),  the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;,  e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedBefore** | **DateTime?**| Restrict to process instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/),  the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;,  e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedAfter** | **DateTime?**| Restrict to process instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/),  the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;,  e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **processInstanceIdIn** | **string**| Restrict to process instances with the given IDs. The IDs must be provided as a comma- separated list. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 

### Return type

[**List&lt;HistoricActivityStatisticsDto&gt;**](HistoricActivityStatisticsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

