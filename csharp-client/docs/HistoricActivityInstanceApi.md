# Camunda.OpenApi.Client.Api.HistoricActivityInstanceApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHistoricActivityInstance**](HistoricActivityInstanceApi.md#gethistoricactivityinstance) | **GET** /history/activity-instance/{id} | Get
[**GetHistoricActivityInstances**](HistoricActivityInstanceApi.md#gethistoricactivityinstances) | **GET** /history/activity-instance | Get List
[**GetHistoricActivityInstancesCount**](HistoricActivityInstanceApi.md#gethistoricactivityinstancescount) | **GET** /history/activity-instance/count | Get List Count
[**QueryHistoricActivityInstances**](HistoricActivityInstanceApi.md#queryhistoricactivityinstances) | **POST** /history/activity-instance | Get List (POST)
[**QueryHistoricActivityInstancesCount**](HistoricActivityInstanceApi.md#queryhistoricactivityinstancescount) | **POST** /history/activity-instance/count | Get List Count (POST)


<a name="gethistoricactivityinstance"></a>
# **GetHistoricActivityInstance**
> HistoricActivityInstanceDto GetHistoricActivityInstance (string id)

Get

Retrieves a historic activity instance by id, according to the `HistoricActivityInstance` interface in the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricActivityInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricActivityInstanceApi(config);
            var id = id_example;  // string | The id of the historic activity instance to be retrieved.

            try
            {
                // Get
                HistoricActivityInstanceDto result = apiInstance.GetHistoricActivityInstance(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricActivityInstanceApi.GetHistoricActivityInstance: " + e.Message );
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
 **id** | **string**| The id of the historic activity instance to be retrieved. | 

### Return type

[**HistoricActivityInstanceDto**](HistoricActivityInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Not Found Historic activity instance with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricactivityinstances"></a>
# **GetHistoricActivityInstances**
> List&lt;HistoricActivityInstanceDto&gt; GetHistoricActivityInstances (string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null, string activityInstanceId = null, string processInstanceId = null, string processDefinitionId = null, string executionId = null, string activityId = null, string activityName = null, string activityType = null, string taskAssignee = null, bool? finished = null, bool? unfinished = null, bool? canceled = null, bool? completeScope = null, DateTime? startedBefore = null, DateTime? startedAfter = null, DateTime? finishedBefore = null, DateTime? finishedAfter = null, string tenantIdIn = null, bool? withoutTenantId = null)

Get List

Queries for historic activity instances that fulfill the given parameters. The size of the result set can be retrieved by using the [Get Historic Activity Instance Count](https://docs.camunda.org/manual/7.15/reference/rest/history/activity-instance/get-activity-instance-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricActivityInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricActivityInstanceApi(config);
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var activityInstanceId = activityInstanceId_example;  // string | Filter by activity instance id. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var executionId = executionId_example;  // string | Filter by the id of the execution that executed the activity instance. (optional) 
            var activityId = activityId_example;  // string | Filter by the activity id (according to BPMN 2.0 XML). (optional) 
            var activityName = activityName_example;  // string | Filter by the activity name (according to BPMN 2.0 XML). (optional) 
            var activityType = activityType_example;  // string | Filter by activity type. (optional) 
            var taskAssignee = taskAssignee_example;  // string | Only include activity instances that are user tasks and assigned to a given user. (optional) 
            var finished = true;  // bool? | Only include finished activity instances. Value may only be `true`, as `false` behaves the same as when the property is not set. (optional) 
            var unfinished = true;  // bool? | Only include unfinished activity instances. Value may only be `true`, as `false` behaves the same as when the property is not set. (optional) 
            var canceled = true;  // bool? | Only include canceled activity instances. Value may only be `true`, as `false` behaves the same as when the property is not set. (optional) 
            var completeScope = true;  // bool? | Only include activity instances which completed a scope. Value may only be `true`, as `false` behaves the same as when the property is not set. (optional) 
            var startedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of ids. An activity instance must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic activity instances that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get List
                List<HistoricActivityInstanceDto> result = apiInstance.GetHistoricActivityInstances(sortBy, sortOrder, firstResult, maxResults, activityInstanceId, processInstanceId, processDefinitionId, executionId, activityId, activityName, activityType, taskAssignee, finished, unfinished, canceled, completeScope, startedBefore, startedAfter, finishedBefore, finishedAfter, tenantIdIn, withoutTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricActivityInstanceApi.GetHistoricActivityInstances: " + e.Message );
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
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 
 **activityInstanceId** | **string**| Filter by activity instance id. | [optional] 
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **executionId** | **string**| Filter by the id of the execution that executed the activity instance. | [optional] 
 **activityId** | **string**| Filter by the activity id (according to BPMN 2.0 XML). | [optional] 
 **activityName** | **string**| Filter by the activity name (according to BPMN 2.0 XML). | [optional] 
 **activityType** | **string**| Filter by activity type. | [optional] 
 **taskAssignee** | **string**| Only include activity instances that are user tasks and assigned to a given user. | [optional] 
 **finished** | **bool?**| Only include finished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
 **unfinished** | **bool?**| Only include unfinished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
 **canceled** | **bool?**| Only include canceled activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
 **completeScope** | **bool?**| Only include activity instances which completed a scope. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
 **startedBefore** | **DateTime?**| Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedAfter** | **DateTime?**| Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedBefore** | **DateTime?**| Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedAfter** | **DateTime?**| Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of ids. An activity instance must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic activity instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

### Return type

[**List&lt;HistoricActivityInstanceDto&gt;**](HistoricActivityInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad Request Returned if some of the query parameters are invalid, for example if a sortOrder parameter is supplied, but no sortBy. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricactivityinstancescount"></a>
# **GetHistoricActivityInstancesCount**
> CountResultDto GetHistoricActivityInstancesCount (string activityInstanceId = null, string processInstanceId = null, string processDefinitionId = null, string executionId = null, string activityId = null, string activityName = null, string activityType = null, string taskAssignee = null, bool? finished = null, bool? unfinished = null, bool? canceled = null, bool? completeScope = null, DateTime? startedBefore = null, DateTime? startedAfter = null, DateTime? finishedBefore = null, DateTime? finishedAfter = null, string tenantIdIn = null, bool? withoutTenantId = null)

Get List Count

Queries for the number of historic activity instances that fulfill the given parameters. Takes the same parameters as the [Get Historic Activity Instance](https://docs.camunda.org/manual/7.15/reference/rest/history/activity-instance/get-activity-instance-query/)  method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricActivityInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricActivityInstanceApi(config);
            var activityInstanceId = activityInstanceId_example;  // string | Filter by activity instance id. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var executionId = executionId_example;  // string | Filter by the id of the execution that executed the activity instance. (optional) 
            var activityId = activityId_example;  // string | Filter by the activity id (according to BPMN 2.0 XML). (optional) 
            var activityName = activityName_example;  // string | Filter by the activity name (according to BPMN 2.0 XML). (optional) 
            var activityType = activityType_example;  // string | Filter by activity type. (optional) 
            var taskAssignee = taskAssignee_example;  // string | Only include activity instances that are user tasks and assigned to a given user. (optional) 
            var finished = true;  // bool? | Only include finished activity instances. Value may only be `true`, as `false` behaves the same as when the property is not set. (optional) 
            var unfinished = true;  // bool? | Only include unfinished activity instances. Value may only be `true`, as `false` behaves the same as when the property is not set. (optional) 
            var canceled = true;  // bool? | Only include canceled activity instances. Value may only be `true`, as `false` behaves the same as when the property is not set. (optional) 
            var completeScope = true;  // bool? | Only include activity instances which completed a scope. Value may only be `true`, as `false` behaves the same as when the property is not set. (optional) 
            var startedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of ids. An activity instance must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic activity instances that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get List Count
                CountResultDto result = apiInstance.GetHistoricActivityInstancesCount(activityInstanceId, processInstanceId, processDefinitionId, executionId, activityId, activityName, activityType, taskAssignee, finished, unfinished, canceled, completeScope, startedBefore, startedAfter, finishedBefore, finishedAfter, tenantIdIn, withoutTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricActivityInstanceApi.GetHistoricActivityInstancesCount: " + e.Message );
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
 **activityInstanceId** | **string**| Filter by activity instance id. | [optional] 
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **executionId** | **string**| Filter by the id of the execution that executed the activity instance. | [optional] 
 **activityId** | **string**| Filter by the activity id (according to BPMN 2.0 XML). | [optional] 
 **activityName** | **string**| Filter by the activity name (according to BPMN 2.0 XML). | [optional] 
 **activityType** | **string**| Filter by activity type. | [optional] 
 **taskAssignee** | **string**| Only include activity instances that are user tasks and assigned to a given user. | [optional] 
 **finished** | **bool?**| Only include finished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
 **unfinished** | **bool?**| Only include unfinished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
 **canceled** | **bool?**| Only include canceled activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
 **completeScope** | **bool?**| Only include activity instances which completed a scope. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
 **startedBefore** | **DateTime?**| Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedAfter** | **DateTime?**| Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedBefore** | **DateTime?**| Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedAfter** | **DateTime?**| Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of ids. An activity instance must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic activity instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

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
| **400** | Bad Request Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistoricactivityinstances"></a>
# **QueryHistoricActivityInstances**
> List&lt;HistoricActivityInstanceDto&gt; QueryHistoricActivityInstances (int? firstResult = null, int? maxResults = null, HistoricActivityInstanceQueryDto historicActivityInstanceQueryDto = null)

Get List (POST)

Queries for historic activity instances that fulfill the given parameters. The size of the result set can be retrieved by using the [Get Historic Activity Instance Count](https://docs.camunda.org/manual/7.15/reference/rest/history/activity-instance/get-activity-instance-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryHistoricActivityInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricActivityInstanceApi(config);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var historicActivityInstanceQueryDto = new HistoricActivityInstanceQueryDto(); // HistoricActivityInstanceQueryDto |  (optional) 

            try
            {
                // Get List (POST)
                List<HistoricActivityInstanceDto> result = apiInstance.QueryHistoricActivityInstances(firstResult, maxResults, historicActivityInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricActivityInstanceApi.QueryHistoricActivityInstances: " + e.Message );
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
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 
 **historicActivityInstanceQueryDto** | [**HistoricActivityInstanceQueryDto**](HistoricActivityInstanceQueryDto.md)|  | [optional] 

### Return type

[**List&lt;HistoricActivityInstanceDto&gt;**](HistoricActivityInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad Request Returned if some of the query parameters are invalid, for example if a sortOrder parameter is supplied, but no sortBy. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistoricactivityinstancescount"></a>
# **QueryHistoricActivityInstancesCount**
> CountResultDto QueryHistoricActivityInstancesCount (HistoricActivityInstanceQueryDto historicActivityInstanceQueryDto = null)

Get List Count (POST)

Queries for the number of historic activity instances that fulfill the given parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryHistoricActivityInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricActivityInstanceApi(config);
            var historicActivityInstanceQueryDto = new HistoricActivityInstanceQueryDto(); // HistoricActivityInstanceQueryDto |  (optional) 

            try
            {
                // Get List Count (POST)
                CountResultDto result = apiInstance.QueryHistoricActivityInstancesCount(historicActivityInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricActivityInstanceApi.QueryHistoricActivityInstancesCount: " + e.Message );
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
 **historicActivityInstanceQueryDto** | [**HistoricActivityInstanceQueryDto**](HistoricActivityInstanceQueryDto.md)|  | [optional] 

### Return type

[**CountResultDto**](CountResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad Request Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

