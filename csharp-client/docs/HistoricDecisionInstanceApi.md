# Camunda.OpenApi.Client.Api.HistoricDecisionInstanceApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAsync**](HistoricDecisionInstanceApi.md#deleteasync) | **POST** /history/decision-instance/delete | Delete Async (POST)
[**GetHistoricDecisionInstance**](HistoricDecisionInstanceApi.md#gethistoricdecisioninstance) | **GET** /history/decision-instance/{id} | Get Historic Decision Instance
[**GetHistoricDecisionInstances**](HistoricDecisionInstanceApi.md#gethistoricdecisioninstances) | **GET** /history/decision-instance | Get Historic Decision Instances
[**GetHistoricDecisionInstancesCount**](HistoricDecisionInstanceApi.md#gethistoricdecisioninstancescount) | **GET** /history/decision-instance/count | Get Historic Decision Instance Count
[**SetRemovalTimeAsyncHistoricDecisionInstance**](HistoricDecisionInstanceApi.md#setremovaltimeasynchistoricdecisioninstance) | **POST** /history/decision-instance/set-removal-time | Set Removal Time Async (POST)


<a name="deleteasync"></a>
# **DeleteAsync**
> BatchDto DeleteAsync (DeleteHistoricDecisionInstancesDto deleteHistoricDecisionInstancesDto = null)

Delete Async (POST)

Delete multiple historic decision instances asynchronously (batch). At least `historicDecisionInstanceIds` or `historicDecisionInstanceQuery`  has to be provided. If both are provided then all instances matching query  criterion and instances from the list will be deleted.

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
    public class DeleteAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricDecisionInstanceApi(httpClient, config, httpClientHandler);
            var deleteHistoricDecisionInstancesDto = new DeleteHistoricDecisionInstancesDto(); // DeleteHistoricDecisionInstancesDto |  (optional) 

            try
            {
                // Delete Async (POST)
                BatchDto result = apiInstance.DeleteAsync(deleteHistoricDecisionInstancesDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDecisionInstanceApi.DeleteAsync: " + e.Message );
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
 **deleteHistoricDecisionInstancesDto** | [**DeleteHistoricDecisionInstancesDto**](DeleteHistoricDecisionInstancesDto.md)|  | [optional] 

### Return type

[**BatchDto**](BatchDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, i.e. neither &#x60;historicDecisionInstanceIds&#x60; nor &#x60;historicDecisionInstanceQuery&#x60; is present. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling)  for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricdecisioninstance"></a>
# **GetHistoricDecisionInstance**
> HistoricDecisionInstanceDto GetHistoricDecisionInstance (string id, bool? includeInputs = null, bool? includeOutputs = null, bool? disableBinaryFetching = null, bool? disableCustomObjectDeserialization = null)

Get Historic Decision Instance

Retrieves a historic decision instance by id, according to the  `HistoricDecisionInstance` interface in the engine.

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
    public class GetHistoricDecisionInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricDecisionInstanceApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the historic decision instance to be retrieved.
            var includeInputs = true;  // bool? | Include input values in the result. Value may only be `true`, as `false` is the default behavior. (optional) 
            var includeOutputs = true;  // bool? | Include output values in the result. Value may only be `true`, as `false` is the default behavior. (optional) 
            var disableBinaryFetching = true;  // bool? | Disables fetching of byte array input and output values. Value may only be `true`, as `false` is the default behavior. (optional) 
            var disableCustomObjectDeserialization = true;  // bool? | Disables deserialization of input and output values that are custom objects. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get Historic Decision Instance
                HistoricDecisionInstanceDto result = apiInstance.GetHistoricDecisionInstance(id, includeInputs, includeOutputs, disableBinaryFetching, disableCustomObjectDeserialization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDecisionInstanceApi.GetHistoricDecisionInstance: " + e.Message );
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
 **id** | **string**| The id of the historic decision instance to be retrieved. | 
 **includeInputs** | **bool?**| Include input values in the result. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeOutputs** | **bool?**| Include output values in the result. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **disableBinaryFetching** | **bool?**| Disables fetching of byte array input and output values. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **disableCustomObjectDeserialization** | **bool?**| Disables deserialization of input and output values that are custom objects. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

### Return type

[**HistoricDecisionInstanceDto**](HistoricDecisionInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Historic decision instance with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricdecisioninstances"></a>
# **GetHistoricDecisionInstances**
> List&lt;HistoricDecisionInstanceDto&gt; GetHistoricDecisionInstances (string decisionInstanceId = null, string decisionInstanceIdIn = null, string decisionDefinitionId = null, string decisionDefinitionIdIn = null, string decisionDefinitionKey = null, string decisionDefinitionKeyIn = null, string decisionDefinitionName = null, string decisionDefinitionNameLike = null, string processDefinitionId = null, string processDefinitionKey = null, string processInstanceId = null, string caseDefinitionId = null, string caseDefinitionKey = null, string caseInstanceId = null, string activityIdIn = null, string activityInstanceIdIn = null, string tenantIdIn = null, bool? withoutTenantId = null, DateTime? evaluatedBefore = null, DateTime? evaluatedAfter = null, string userId = null, string rootDecisionInstanceId = null, bool? rootDecisionInstancesOnly = null, string decisionRequirementsDefinitionId = null, string decisionRequirementsDefinitionKey = null, bool? includeInputs = null, bool? includeOutputs = null, bool? disableBinaryFetching = null, bool? disableCustomObjectDeserialization = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Historic Decision Instances

Queries for historic decision instances that fulfill the given parameters.  The size of the result set can be retrieved by using the  [Get Historic Decision Instance Count](https://docs.camunda.org/manual/7.16/reference/rest/history/decision-instance/get-decision-instance-query-count/)  method.

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
    public class GetHistoricDecisionInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricDecisionInstanceApi(httpClient, config, httpClientHandler);
            var decisionInstanceId = decisionInstanceId_example;  // string | Filter by decision instance id. (optional) 
            var decisionInstanceIdIn = decisionInstanceIdIn_example;  // string | Filter by decision instance ids. Must be a comma-separated list of decision instance ids. (optional) 
            var decisionDefinitionId = decisionDefinitionId_example;  // string | Filter by the decision definition the instances belongs to. (optional) 
            var decisionDefinitionIdIn = decisionDefinitionIdIn_example;  // string | Filter by the decision definitions the instances belongs to. Must be a comma-separated list of decision definition ids. (optional) 
            var decisionDefinitionKey = decisionDefinitionKey_example;  // string | Filter by the key of the decision definition the instances belongs to. (optional) 
            var decisionDefinitionKeyIn = decisionDefinitionKeyIn_example;  // string | Filter by the keys of the decision definition the instances belongs to. Must be a comma- separated list of decision definition keys. (optional) 
            var decisionDefinitionName = decisionDefinitionName_example;  // string | Filter by the name of the decision definition the instances belongs to. (optional) 
            var decisionDefinitionNameLike = decisionDefinitionNameLike_example;  // string | Filter by the name of the decision definition the instances belongs to, that the parameter is a substring of. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the process definition the instances belongs to. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by the key of the process definition the instances belongs to. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by the process instance the instances belongs to. (optional) 
            var caseDefinitionId = caseDefinitionId_example;  // string | Filter by the case definition the instances belongs to. (optional) 
            var caseDefinitionKey = caseDefinitionKey_example;  // string | Filter by the key of the case definition the instances belongs to. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by the case instance the instances belongs to. (optional) 
            var activityIdIn = activityIdIn_example;  // string | Filter by the activity ids the instances belongs to. Must be a comma-separated list of acitvity ids. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Filter by the activity instance ids the instances belongs to. Must be a comma-separated list of acitvity instance ids. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A historic decision instance must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic decision instances that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var evaluatedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were evaluated before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM- dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var evaluatedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were evaluated after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM- dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var userId = userId_example;  // string | Restrict to instances that were evaluated by the given user. (optional) 
            var rootDecisionInstanceId = rootDecisionInstanceId_example;  // string | Restrict to instances that have a given root decision instance id. This also includes the decision instance with the given id. (optional) 
            var rootDecisionInstancesOnly = true;  // bool? | Restrict to instances those are the root decision instance of an evaluation. Value may only be `true`, as `false` is the default behavior. (optional) 
            var decisionRequirementsDefinitionId = decisionRequirementsDefinitionId_example;  // string | Filter by the decision requirements definition the instances belongs to. (optional) 
            var decisionRequirementsDefinitionKey = decisionRequirementsDefinitionKey_example;  // string | Filter by the key of the decision requirements definition the instances belongs to. (optional) 
            var includeInputs = true;  // bool? | Include input values in the result. Value may only be `true`, as `false` is the default behavior. (optional) 
            var includeOutputs = true;  // bool? | Include output values in the result. Value may only be `true`, as `false` is the default behavior. (optional) 
            var disableBinaryFetching = true;  // bool? | Disables fetching of byte array input and output values. Value may only be `true`, as `false` is the default behavior. (optional) 
            var disableCustomObjectDeserialization = true;  // bool? | Disables deserialization of input and output values that are custom objects. Value may only be `true`, as `false` is the default behavior. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get Historic Decision Instances
                List<HistoricDecisionInstanceDto> result = apiInstance.GetHistoricDecisionInstances(decisionInstanceId, decisionInstanceIdIn, decisionDefinitionId, decisionDefinitionIdIn, decisionDefinitionKey, decisionDefinitionKeyIn, decisionDefinitionName, decisionDefinitionNameLike, processDefinitionId, processDefinitionKey, processInstanceId, caseDefinitionId, caseDefinitionKey, caseInstanceId, activityIdIn, activityInstanceIdIn, tenantIdIn, withoutTenantId, evaluatedBefore, evaluatedAfter, userId, rootDecisionInstanceId, rootDecisionInstancesOnly, decisionRequirementsDefinitionId, decisionRequirementsDefinitionKey, includeInputs, includeOutputs, disableBinaryFetching, disableCustomObjectDeserialization, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDecisionInstanceApi.GetHistoricDecisionInstances: " + e.Message );
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
 **decisionInstanceId** | **string**| Filter by decision instance id. | [optional] 
 **decisionInstanceIdIn** | **string**| Filter by decision instance ids. Must be a comma-separated list of decision instance ids. | [optional] 
 **decisionDefinitionId** | **string**| Filter by the decision definition the instances belongs to. | [optional] 
 **decisionDefinitionIdIn** | **string**| Filter by the decision definitions the instances belongs to. Must be a comma-separated list of decision definition ids. | [optional] 
 **decisionDefinitionKey** | **string**| Filter by the key of the decision definition the instances belongs to. | [optional] 
 **decisionDefinitionKeyIn** | **string**| Filter by the keys of the decision definition the instances belongs to. Must be a comma- separated list of decision definition keys. | [optional] 
 **decisionDefinitionName** | **string**| Filter by the name of the decision definition the instances belongs to. | [optional] 
 **decisionDefinitionNameLike** | **string**| Filter by the name of the decision definition the instances belongs to, that the parameter is a substring of. | [optional] 
 **processDefinitionId** | **string**| Filter by the process definition the instances belongs to. | [optional] 
 **processDefinitionKey** | **string**| Filter by the key of the process definition the instances belongs to. | [optional] 
 **processInstanceId** | **string**| Filter by the process instance the instances belongs to. | [optional] 
 **caseDefinitionId** | **string**| Filter by the case definition the instances belongs to. | [optional] 
 **caseDefinitionKey** | **string**| Filter by the key of the case definition the instances belongs to. | [optional] 
 **caseInstanceId** | **string**| Filter by the case instance the instances belongs to. | [optional] 
 **activityIdIn** | **string**| Filter by the activity ids the instances belongs to. Must be a comma-separated list of acitvity ids. | [optional] 
 **activityInstanceIdIn** | **string**| Filter by the activity instance ids the instances belongs to. Must be a comma-separated list of acitvity instance ids. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A historic decision instance must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic decision instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **evaluatedBefore** | **DateTime?**| Restrict to instances that were evaluated before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM- dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **evaluatedAfter** | **DateTime?**| Restrict to instances that were evaluated after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM- dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **userId** | **string**| Restrict to instances that were evaluated by the given user. | [optional] 
 **rootDecisionInstanceId** | **string**| Restrict to instances that have a given root decision instance id. This also includes the decision instance with the given id. | [optional] 
 **rootDecisionInstancesOnly** | **bool?**| Restrict to instances those are the root decision instance of an evaluation. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **decisionRequirementsDefinitionId** | **string**| Filter by the decision requirements definition the instances belongs to. | [optional] 
 **decisionRequirementsDefinitionKey** | **string**| Filter by the key of the decision requirements definition the instances belongs to. | [optional] 
 **includeInputs** | **bool?**| Include input values in the result. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeOutputs** | **bool?**| Include output values in the result. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **disableBinaryFetching** | **bool?**| Disables fetching of byte array input and output values. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **disableCustomObjectDeserialization** | **bool?**| Disables deserialization of input and output values that are custom objects. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;HistoricDecisionInstanceDto&gt;**](HistoricDecisionInstanceDto.md)

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

<a name="gethistoricdecisioninstancescount"></a>
# **GetHistoricDecisionInstancesCount**
> CountResultDto GetHistoricDecisionInstancesCount (string decisionInstanceId = null, string decisionInstanceIdIn = null, string decisionDefinitionId = null, string decisionDefinitionIdIn = null, string decisionDefinitionKey = null, string decisionDefinitionKeyIn = null, string decisionDefinitionName = null, string decisionDefinitionNameLike = null, string processDefinitionId = null, string processDefinitionKey = null, string processInstanceId = null, string caseDefinitionId = null, string caseDefinitionKey = null, string caseInstanceId = null, string activityIdIn = null, string activityInstanceIdIn = null, string tenantIdIn = null, bool? withoutTenantId = null, DateTime? evaluatedBefore = null, DateTime? evaluatedAfter = null, string userId = null, string rootDecisionInstanceId = null, bool? rootDecisionInstancesOnly = null, string decisionRequirementsDefinitionId = null, string decisionRequirementsDefinitionKey = null)

Get Historic Decision Instance Count

Queries for the number of historic decision instances that fulfill the given parameters.  Takes the same parameters as the  [Get Historic Decision Instances](https://docs.camunda.org/manual/7.16/reference/rest/history/decision-instance/get-decision-instance-query/)  method.

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
    public class GetHistoricDecisionInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricDecisionInstanceApi(httpClient, config, httpClientHandler);
            var decisionInstanceId = decisionInstanceId_example;  // string | Filter by decision instance id. (optional) 
            var decisionInstanceIdIn = decisionInstanceIdIn_example;  // string | Filter by decision instance ids. Must be a comma-separated list of decision instance ids. (optional) 
            var decisionDefinitionId = decisionDefinitionId_example;  // string | Filter by the decision definition the instances belongs to. (optional) 
            var decisionDefinitionIdIn = decisionDefinitionIdIn_example;  // string | Filter by the decision definitions the instances belongs to. Must be a comma-separated list of decision definition ids. (optional) 
            var decisionDefinitionKey = decisionDefinitionKey_example;  // string | Filter by the key of the decision definition the instances belongs to. (optional) 
            var decisionDefinitionKeyIn = decisionDefinitionKeyIn_example;  // string | Filter by the keys of the decision definition the instances belongs to. Must be a comma- separated list of decision definition keys. (optional) 
            var decisionDefinitionName = decisionDefinitionName_example;  // string | Filter by the name of the decision definition the instances belongs to. (optional) 
            var decisionDefinitionNameLike = decisionDefinitionNameLike_example;  // string | Filter by the name of the decision definition the instances belongs to, that the parameter is a substring of. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the process definition the instances belongs to. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by the key of the process definition the instances belongs to. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by the process instance the instances belongs to. (optional) 
            var caseDefinitionId = caseDefinitionId_example;  // string | Filter by the case definition the instances belongs to. (optional) 
            var caseDefinitionKey = caseDefinitionKey_example;  // string | Filter by the key of the case definition the instances belongs to. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by the case instance the instances belongs to. (optional) 
            var activityIdIn = activityIdIn_example;  // string | Filter by the activity ids the instances belongs to. Must be a comma-separated list of acitvity ids. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Filter by the activity instance ids the instances belongs to. Must be a comma-separated list of acitvity instance ids. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A historic decision instance must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic decision instances that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var evaluatedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were evaluated before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM- dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var evaluatedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were evaluated after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM- dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var userId = userId_example;  // string | Restrict to instances that were evaluated by the given user. (optional) 
            var rootDecisionInstanceId = rootDecisionInstanceId_example;  // string | Restrict to instances that have a given root decision instance id. This also includes the decision instance with the given id. (optional) 
            var rootDecisionInstancesOnly = true;  // bool? | Restrict to instances those are the root decision instance of an evaluation. Value may only be `true`, as `false` is the default behavior. (optional) 
            var decisionRequirementsDefinitionId = decisionRequirementsDefinitionId_example;  // string | Filter by the decision requirements definition the instances belongs to. (optional) 
            var decisionRequirementsDefinitionKey = decisionRequirementsDefinitionKey_example;  // string | Filter by the key of the decision requirements definition the instances belongs to. (optional) 

            try
            {
                // Get Historic Decision Instance Count
                CountResultDto result = apiInstance.GetHistoricDecisionInstancesCount(decisionInstanceId, decisionInstanceIdIn, decisionDefinitionId, decisionDefinitionIdIn, decisionDefinitionKey, decisionDefinitionKeyIn, decisionDefinitionName, decisionDefinitionNameLike, processDefinitionId, processDefinitionKey, processInstanceId, caseDefinitionId, caseDefinitionKey, caseInstanceId, activityIdIn, activityInstanceIdIn, tenantIdIn, withoutTenantId, evaluatedBefore, evaluatedAfter, userId, rootDecisionInstanceId, rootDecisionInstancesOnly, decisionRequirementsDefinitionId, decisionRequirementsDefinitionKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDecisionInstanceApi.GetHistoricDecisionInstancesCount: " + e.Message );
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
 **decisionInstanceId** | **string**| Filter by decision instance id. | [optional] 
 **decisionInstanceIdIn** | **string**| Filter by decision instance ids. Must be a comma-separated list of decision instance ids. | [optional] 
 **decisionDefinitionId** | **string**| Filter by the decision definition the instances belongs to. | [optional] 
 **decisionDefinitionIdIn** | **string**| Filter by the decision definitions the instances belongs to. Must be a comma-separated list of decision definition ids. | [optional] 
 **decisionDefinitionKey** | **string**| Filter by the key of the decision definition the instances belongs to. | [optional] 
 **decisionDefinitionKeyIn** | **string**| Filter by the keys of the decision definition the instances belongs to. Must be a comma- separated list of decision definition keys. | [optional] 
 **decisionDefinitionName** | **string**| Filter by the name of the decision definition the instances belongs to. | [optional] 
 **decisionDefinitionNameLike** | **string**| Filter by the name of the decision definition the instances belongs to, that the parameter is a substring of. | [optional] 
 **processDefinitionId** | **string**| Filter by the process definition the instances belongs to. | [optional] 
 **processDefinitionKey** | **string**| Filter by the key of the process definition the instances belongs to. | [optional] 
 **processInstanceId** | **string**| Filter by the process instance the instances belongs to. | [optional] 
 **caseDefinitionId** | **string**| Filter by the case definition the instances belongs to. | [optional] 
 **caseDefinitionKey** | **string**| Filter by the key of the case definition the instances belongs to. | [optional] 
 **caseInstanceId** | **string**| Filter by the case instance the instances belongs to. | [optional] 
 **activityIdIn** | **string**| Filter by the activity ids the instances belongs to. Must be a comma-separated list of acitvity ids. | [optional] 
 **activityInstanceIdIn** | **string**| Filter by the activity instance ids the instances belongs to. Must be a comma-separated list of acitvity instance ids. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A historic decision instance must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic decision instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **evaluatedBefore** | **DateTime?**| Restrict to instances that were evaluated before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM- dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **evaluatedAfter** | **DateTime?**| Restrict to instances that were evaluated after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM- dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **userId** | **string**| Restrict to instances that were evaluated by the given user. | [optional] 
 **rootDecisionInstanceId** | **string**| Restrict to instances that have a given root decision instance id. This also includes the decision instance with the given id. | [optional] 
 **rootDecisionInstancesOnly** | **bool?**| Restrict to instances those are the root decision instance of an evaluation. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **decisionRequirementsDefinitionId** | **string**| Filter by the decision requirements definition the instances belongs to. | [optional] 
 **decisionRequirementsDefinitionKey** | **string**| Filter by the key of the decision requirements definition the instances belongs to. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setremovaltimeasynchistoricdecisioninstance"></a>
# **SetRemovalTimeAsyncHistoricDecisionInstance**
> BatchDto SetRemovalTimeAsyncHistoricDecisionInstance (SetRemovalTimeToHistoricDecisionInstancesDto setRemovalTimeToHistoricDecisionInstancesDto = null)

Set Removal Time Async (POST)

Sets the removal time to multiple historic decision instances asynchronously (batch).  At least `historicDecisionInstanceIds` or `historicDecisionInstanceQuery` has to be provided. If both are provided, all instances matching query criterion and instances from the list will be updated with a removal time.

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
    public class SetRemovalTimeAsyncHistoricDecisionInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricDecisionInstanceApi(httpClient, config, httpClientHandler);
            var setRemovalTimeToHistoricDecisionInstancesDto = new SetRemovalTimeToHistoricDecisionInstancesDto(); // SetRemovalTimeToHistoricDecisionInstancesDto |  (optional) 

            try
            {
                // Set Removal Time Async (POST)
                BatchDto result = apiInstance.SetRemovalTimeAsyncHistoricDecisionInstance(setRemovalTimeToHistoricDecisionInstancesDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDecisionInstanceApi.SetRemovalTimeAsyncHistoricDecisionInstance: " + e.Message );
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
 **setRemovalTimeToHistoricDecisionInstancesDto** | [**SetRemovalTimeToHistoricDecisionInstancesDto**](SetRemovalTimeToHistoricDecisionInstancesDto.md)|  | [optional] 

### Return type

[**BatchDto**](BatchDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Request was unsuccessfull due to a bad user request. This occurs if some of the query parameters are invalid, e. g. if neither historicDecisionInstances nor historicDecisionInstanceQuery is present or if no mode is specified.  See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

