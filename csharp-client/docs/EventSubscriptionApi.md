# Camunda.OpenApi.Client.Api.EventSubscriptionApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEventSubscriptions**](EventSubscriptionApi.md#geteventsubscriptions) | **GET** /event-subscription | 
[**GetEventSubscriptionsCount**](EventSubscriptionApi.md#geteventsubscriptionscount) | **GET** /event-subscription/count | 


<a name="geteventsubscriptions"></a>
# **GetEventSubscriptions**
> List&lt;EventSubscriptionDto&gt; GetEventSubscriptions (string eventSubscriptionId = null, string eventName = null, string eventType = null, string executionId = null, string processInstanceId = null, string activityId = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeEventSubscriptionsWithoutTenantId = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)



Queries for event subscriptions that fulfill given parameters. The size of the result set can be retrieved by using the [Get Event Subscriptions count](https://docs.camunda.org/manual/7.14/reference/rest/event-subscription/get-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetEventSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new EventSubscriptionApi(config);
            var eventSubscriptionId = eventSubscriptionId_example;  // string | Only select subscription with the given id. (optional) 
            var eventName = eventName_example;  // string | Only select subscriptions for events with the given name. (optional) 
            var eventType = eventType_example;  // string | Only select subscriptions for events with the given type. Valid values: `message`, `signal`, `compensate` and `conditional`. (optional) 
            var executionId = executionId_example;  // string | Only select subscriptions that belong to an execution with the given id. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Only select subscriptions that belong to a process instance with the given id. (optional) 
            var activityId = activityId_example;  // string | Only select subscriptions that belong to an activity with the given id. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. Only select subscriptions that belong to one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only select subscriptions which have no tenant id. Value may only be `true`, as `false` is the default behavior. (optional) 
            var includeEventSubscriptionsWithoutTenantId = true;  // bool? | Select event subscriptions which have no tenant id. Can be used in combination with tenantIdIn parameter. Value may only be `true`, as `false` is the default behavior. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                List<EventSubscriptionDto> result = apiInstance.GetEventSubscriptions(eventSubscriptionId, eventName, eventType, executionId, processInstanceId, activityId, tenantIdIn, withoutTenantId, includeEventSubscriptionsWithoutTenantId, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventSubscriptionApi.GetEventSubscriptions: " + e.Message );
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
 **eventSubscriptionId** | **string**| Only select subscription with the given id. | [optional] 
 **eventName** | **string**| Only select subscriptions for events with the given name. | [optional] 
 **eventType** | **string**| Only select subscriptions for events with the given type. Valid values: &#x60;message&#x60;, &#x60;signal&#x60;, &#x60;compensate&#x60; and &#x60;conditional&#x60;. | [optional] 
 **executionId** | **string**| Only select subscriptions that belong to an execution with the given id. | [optional] 
 **processInstanceId** | **string**| Only select subscriptions that belong to a process instance with the given id. | [optional] 
 **activityId** | **string**| Only select subscriptions that belong to an activity with the given id. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. Only select subscriptions that belong to one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only select subscriptions which have no tenant id. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeEventSubscriptionsWithoutTenantId** | **bool?**| Select event subscriptions which have no tenant id. Can be used in combination with tenantIdIn parameter. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;EventSubscriptionDto&gt;**](EventSubscriptionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad Request Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventsubscriptionscount"></a>
# **GetEventSubscriptionsCount**
> CountResultDto GetEventSubscriptionsCount (string eventSubscriptionId = null, string eventName = null, string eventType = null, string executionId = null, string processInstanceId = null, string activityId = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeEventSubscriptionsWithoutTenantId = null)



Queries for the number of event subscriptions that fulfill given parameters. Takes the same parameters as the [Get Event Subscriptions](https://docs.camunda.org/manual/7.14/reference/rest/event-subscription/get-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetEventSubscriptionsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new EventSubscriptionApi(config);
            var eventSubscriptionId = eventSubscriptionId_example;  // string | Only select subscription with the given id. (optional) 
            var eventName = eventName_example;  // string | Only select subscriptions for events with the given name. (optional) 
            var eventType = eventType_example;  // string | Only select subscriptions for events with the given type. Valid values: `message`, `signal`, `compensate` and `conditional`. (optional) 
            var executionId = executionId_example;  // string | Only select subscriptions that belong to an execution with the given id. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Only select subscriptions that belong to a process instance with the given id. (optional) 
            var activityId = activityId_example;  // string | Only select subscriptions that belong to an activity with the given id. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. Only select subscriptions that belong to one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only select subscriptions which have no tenant id. Value may only be `true`, as `false` is the default behavior. (optional) 
            var includeEventSubscriptionsWithoutTenantId = true;  // bool? | Select event subscriptions which have no tenant id. Can be used in combination with tenantIdIn parameter. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                CountResultDto result = apiInstance.GetEventSubscriptionsCount(eventSubscriptionId, eventName, eventType, executionId, processInstanceId, activityId, tenantIdIn, withoutTenantId, includeEventSubscriptionsWithoutTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventSubscriptionApi.GetEventSubscriptionsCount: " + e.Message );
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
 **eventSubscriptionId** | **string**| Only select subscription with the given id. | [optional] 
 **eventName** | **string**| Only select subscriptions for events with the given name. | [optional] 
 **eventType** | **string**| Only select subscriptions for events with the given type. Valid values: &#x60;message&#x60;, &#x60;signal&#x60;, &#x60;compensate&#x60; and &#x60;conditional&#x60;. | [optional] 
 **executionId** | **string**| Only select subscriptions that belong to an execution with the given id. | [optional] 
 **processInstanceId** | **string**| Only select subscriptions that belong to a process instance with the given id. | [optional] 
 **activityId** | **string**| Only select subscriptions that belong to an activity with the given id. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. Only select subscriptions that belong to one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only select subscriptions which have no tenant id. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeEventSubscriptionsWithoutTenantId** | **bool?**| Select event subscriptions which have no tenant id. Can be used in combination with tenantIdIn parameter. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

