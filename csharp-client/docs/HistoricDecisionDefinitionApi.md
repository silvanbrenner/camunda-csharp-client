# Camunda.OpenApi.Client.Api.HistoricDecisionDefinitionApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCleanableHistoricDecisionInstanceReport**](HistoricDecisionDefinitionApi.md#getcleanablehistoricdecisioninstancereport) | **GET** /history/decision-definition/cleanable-decision-instance-report | Get Cleanable Decision Instance Report
[**GetCleanableHistoricDecisionInstanceReportCount**](HistoricDecisionDefinitionApi.md#getcleanablehistoricdecisioninstancereportcount) | **GET** /history/decision-definition/cleanable-decision-instance-report/count | Get Cleanable Decision Instance Report Count


<a name="getcleanablehistoricdecisioninstancereport"></a>
# **GetCleanableHistoricDecisionInstanceReport**
> List&lt;CleanableHistoricDecisionInstanceReportResultDto&gt; GetCleanableHistoricDecisionInstanceReport (string decisionDefinitionIdIn = null, string decisionDefinitionKeyIn = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? compact = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Cleanable Decision Instance Report

Retrieves a report about a decision definition and finished decision instances relevant to history cleanup (see [History cleanup](https://docs.camunda.org/manual/7.16/user-guide/process-engine/history/#history-cleanup)),  so that you can tune the history time to live. These reports include the count of the finished historic decision instances, cleanable decision instances and basic decision definition data - id, key, name and version. The size of the result set can be retrieved by using the  [Get Cleanable Decision Instance Report Count](https://docs.camunda.org/manual/7.16/reference/rest/history/decision-definition/get-cleanable-decision-instance-report-count/) method.

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
    public class GetCleanableHistoricDecisionInstanceReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricDecisionDefinitionApi(httpClient, config, httpClientHandler);
            var decisionDefinitionIdIn = decisionDefinitionIdIn_example;  // string | Filter by decision definition ids. Must be a comma-separated list of decision definition ids. (optional) 
            var decisionDefinitionKeyIn = decisionDefinitionKeyIn_example;  // string | Filter by decision definition keys. Must be a comma-separated list of decision definition keys. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A decision definition must have one of the given tenant  ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include decision definitions which belong to no tenant. Value may only be `true`, as `false`  is the default behavior. (optional) 
            var compact = true;  // bool? | Only include decision instances which have more than zero finished instances. Value may only be `true`,  as `false` is the default behavior. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get Cleanable Decision Instance Report
                List<CleanableHistoricDecisionInstanceReportResultDto> result = apiInstance.GetCleanableHistoricDecisionInstanceReport(decisionDefinitionIdIn, decisionDefinitionKeyIn, tenantIdIn, withoutTenantId, compact, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDecisionDefinitionApi.GetCleanableHistoricDecisionInstanceReport: " + e.Message );
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
 **decisionDefinitionIdIn** | **string**| Filter by decision definition ids. Must be a comma-separated list of decision definition ids. | [optional] 
 **decisionDefinitionKeyIn** | **string**| Filter by decision definition keys. Must be a comma-separated list of decision definition keys. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A decision definition must have one of the given tenant  ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include decision definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60;  is the default behavior. | [optional] 
 **compact** | **bool?**| Only include decision instances which have more than zero finished instances. Value may only be &#x60;true&#x60;,  as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;CleanableHistoricDecisionInstanceReportResultDto&gt;**](CleanableHistoricDecisionInstanceReportResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **500** | See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcleanablehistoricdecisioninstancereportcount"></a>
# **GetCleanableHistoricDecisionInstanceReportCount**
> CountResultDto GetCleanableHistoricDecisionInstanceReportCount (string decisionDefinitionIdIn = null, string decisionDefinitionKeyIn = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? compact = null)

Get Cleanable Decision Instance Report Count

Queries for the number of report results about a decision definition and finished decision instances relevant to history cleanup (see [History cleanup](https://docs.camunda.org/manual/7.16/user-guide/process-engine/history/#history-cleanup)). Takes the same parameters as the [Get Cleanable Decision Instance Report](https://docs.camunda.org/manual/7.16/reference/rest/history/decision-definition/get-cleanable-decision-instance-report/)  method.

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
    public class GetCleanableHistoricDecisionInstanceReportCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricDecisionDefinitionApi(httpClient, config, httpClientHandler);
            var decisionDefinitionIdIn = decisionDefinitionIdIn_example;  // string | Filter by decision definition ids. Must be a comma-separated list of decision definition ids. (optional) 
            var decisionDefinitionKeyIn = decisionDefinitionKeyIn_example;  // string | Filter by decision definition keys. Must be a comma-separated list of decision definition keys. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A decision definition must have one of the given tenant  ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include decision definitions which belong to no tenant. Value may only be `true`, as `false`  is the default behavior. (optional) 
            var compact = true;  // bool? | Only include decision instances which have more than zero finished instances. Value may only be `true`,  as `false` is the default behavior. (optional) 

            try
            {
                // Get Cleanable Decision Instance Report Count
                CountResultDto result = apiInstance.GetCleanableHistoricDecisionInstanceReportCount(decisionDefinitionIdIn, decisionDefinitionKeyIn, tenantIdIn, withoutTenantId, compact);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDecisionDefinitionApi.GetCleanableHistoricDecisionInstanceReportCount: " + e.Message );
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
 **decisionDefinitionIdIn** | **string**| Filter by decision definition ids. Must be a comma-separated list of decision definition ids. | [optional] 
 **decisionDefinitionKeyIn** | **string**| Filter by decision definition keys. Must be a comma-separated list of decision definition keys. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A decision definition must have one of the given tenant  ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include decision definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60;  is the default behavior. | [optional] 
 **compact** | **bool?**| Only include decision instances which have more than zero finished instances. Value may only be &#x60;true&#x60;,  as &#x60;false&#x60; is the default behavior. | [optional] 

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
| **500** | See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

