# Camunda.OpenApi.Client.Api.ExternalTaskApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CallLock**](ExternalTaskApi.md#calllock) | **POST** /external-task/{id}/lock | 
[**CompleteExternalTaskResource**](ExternalTaskApi.md#completeexternaltaskresource) | **POST** /external-task/{id}/complete | Complete
[**ExtendLock**](ExternalTaskApi.md#extendlock) | **POST** /external-task/{id}/extendLock | Extend Lock
[**FetchAndLock**](ExternalTaskApi.md#fetchandlock) | **POST** /external-task/fetchAndLock | Fetch and Lock
[**GetExternalTask**](ExternalTaskApi.md#getexternaltask) | **GET** /external-task/{id} | Get
[**GetExternalTaskErrorDetails**](ExternalTaskApi.md#getexternaltaskerrordetails) | **GET** /external-task/{id}/errorDetails | Get Error Details
[**GetExternalTasks**](ExternalTaskApi.md#getexternaltasks) | **GET** /external-task | Get List
[**GetExternalTasksCount**](ExternalTaskApi.md#getexternaltaskscount) | **GET** /external-task/count | Get List Count
[**GetTopicNames**](ExternalTaskApi.md#gettopicnames) | **GET** /external-task/topic-names | Get External Task Topic Names
[**HandleExternalTaskBpmnError**](ExternalTaskApi.md#handleexternaltaskbpmnerror) | **POST** /external-task/{id}/bpmnError | Handle BPMN Error
[**HandleFailure**](ExternalTaskApi.md#handlefailure) | **POST** /external-task/{id}/failure | Handle Failure
[**QueryExternalTasks**](ExternalTaskApi.md#queryexternaltasks) | **POST** /external-task | Get List (POST)
[**QueryExternalTasksCount**](ExternalTaskApi.md#queryexternaltaskscount) | **POST** /external-task/count | Get List Count (POST)
[**SetExternalTaskResourcePriority**](ExternalTaskApi.md#setexternaltaskresourcepriority) | **PUT** /external-task/{id}/priority | Set Priority
[**SetExternalTaskResourceRetries**](ExternalTaskApi.md#setexternaltaskresourceretries) | **PUT** /external-task/{id}/retries | Set Retries
[**SetExternalTaskRetries**](ExternalTaskApi.md#setexternaltaskretries) | **PUT** /external-task/retries | Set Retries Sync
[**SetExternalTaskRetriesAsyncOperation**](ExternalTaskApi.md#setexternaltaskretriesasyncoperation) | **POST** /external-task/retries-async | Set Retries Async
[**Unlock**](ExternalTaskApi.md#unlock) | **POST** /external-task/{id}/unlock | Unlock


<a name="calllock"></a>
# **CallLock**
> void CallLock (string id, LockExternalTaskDto lockExternalTaskDto = null)



Lock an external task by a given id for a specified worker and amount of time.

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
    public class CallLockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the external task.
            var lockExternalTaskDto = new LockExternalTaskDto(); // LockExternalTaskDto |  (optional) 

            try
            {
                apiInstance.CallLock(id, lockExternalTaskDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.CallLock: " + e.Message );
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
 **id** | **string**| The id of the external task. | 
 **lockExternalTaskDto** | [**LockExternalTaskDto**](LockExternalTaskDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | In case the lock duration is negative or the external task is already locked by a different worker, an exception of type &#x60;InvalidRequestException&#x60; is returned. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Returned if the task does not exist. This could indicate a wrong task id as well as a cancelled task, e.g., due to a caught BPMN boundary event. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="completeexternaltaskresource"></a>
# **CompleteExternalTaskResource**
> void CompleteExternalTaskResource (string id, CompleteExternalTaskDto completeExternalTaskDto = null)

Complete

Completes an external task by id and updates process variables.

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
    public class CompleteExternalTaskResourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to complete.
            var completeExternalTaskDto = new CompleteExternalTaskDto(); // CompleteExternalTaskDto |  (optional) 

            try
            {
                // Complete
                apiInstance.CompleteExternalTaskResource(id, completeExternalTaskDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.CompleteExternalTaskResource: " + e.Message );
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
 **id** | **string**| The id of the task to complete. | 
 **completeExternalTaskDto** | [**CompleteExternalTaskDto**](CompleteExternalTaskDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | Returned if the task&#39;s most recent lock was not acquired by the provided worker. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Returned if the task does not exist. This could indicate a wrong task id as well as a cancelled task, e.g., due to a caught BPMN boundary event. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | Returned if the corresponding process instance could not be resumed successfully. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extendlock"></a>
# **ExtendLock**
> void ExtendLock (string id, ExtendLockOnExternalTaskDto extendLockOnExternalTaskDto = null)

Extend Lock

Extends the timeout of the lock by a given amount of time.

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
    public class ExtendLockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the external task.
            var extendLockOnExternalTaskDto = new ExtendLockOnExternalTaskDto(); // ExtendLockOnExternalTaskDto |  (optional) 

            try
            {
                // Extend Lock
                apiInstance.ExtendLock(id, extendLockOnExternalTaskDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.ExtendLock: " + e.Message );
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
 **id** | **string**| The id of the external task. | 
 **extendLockOnExternalTaskDto** | [**ExtendLockOnExternalTaskDto**](ExtendLockOnExternalTaskDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | In case the new lock duration is negative or the external task is not locked by the given worker or not  locked at all, an exception of type &#x60;InvalidRequestException&#x60; is returned. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Returned if the task does not exist. This could indicate a wrong task id as well as a cancelled task, e.g., due to a caught BPMN boundary event. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fetchandlock"></a>
# **FetchAndLock**
> List&lt;LockedExternalTaskDto&gt; FetchAndLock (FetchExternalTasksDto fetchExternalTasksDto = null)

Fetch and Lock

Fetches and locks a specific number of external tasks for execution by a worker. Query can be restricted to specific task topics and for each task topic an individual lock time can be provided.

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
    public class FetchAndLockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var fetchExternalTasksDto = new FetchExternalTasksDto(); // FetchExternalTasksDto |  (optional) 

            try
            {
                // Fetch and Lock
                List<LockedExternalTaskDto> result = apiInstance.FetchAndLock(fetchExternalTasksDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.FetchAndLock: " + e.Message );
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
 **fetchExternalTasksDto** | [**FetchExternalTasksDto**](FetchExternalTasksDto.md)|  | [optional] 

### Return type

[**List&lt;LockedExternalTaskDto&gt;**](LockedExternalTaskDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad Request. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternaltask"></a>
# **GetExternalTask**
> ExternalTaskDto GetExternalTask (string id)

Get

Retrieves an external task by id, corresponding to the `ExternalTask` interface in the engine.

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
    public class GetExternalTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the external task to be retrieved.

            try
            {
                // Get
                ExternalTaskDto result = apiInstance.GetExternalTask(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.GetExternalTask: " + e.Message );
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
 **id** | **string**| The id of the external task to be retrieved. | 

### Return type

[**ExternalTaskDto**](ExternalTaskDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | External task with the given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternaltaskerrordetails"></a>
# **GetExternalTaskErrorDetails**
> string GetExternalTaskErrorDetails (string id)

Get Error Details

Retrieves the error details in the context of a running external task by id.

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
    public class GetExternalTaskErrorDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the external task for which the error details should be retrieved.

            try
            {
                // Get Error Details
                string result = apiInstance.GetExternalTaskErrorDetails(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.GetExternalTaskErrorDetails: " + e.Message );
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
 **id** | **string**| The id of the external task for which the error details should be retrieved. | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **204** | Request successful. In case the external task has no error details. |  -  |
| **500** | An external task with the given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternaltasks"></a>
# **GetExternalTasks**
> List&lt;ExternalTaskDto&gt; GetExternalTasks (string externalTaskId = null, string externalTaskIdIn = null, string topicName = null, string workerId = null, bool? locked = null, bool? notLocked = null, bool? withRetriesLeft = null, bool? noRetriesLeft = null, DateTime? lockExpirationAfter = null, DateTime? lockExpirationBefore = null, string activityId = null, string activityIdIn = null, string executionId = null, string processInstanceId = null, string processInstanceIdIn = null, string processDefinitionId = null, string tenantIdIn = null, bool? active = null, bool? suspended = null, long? priorityHigherThanOrEquals = null, long? priorityLowerThanOrEquals = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get List

Queries for the external tasks that fulfill given parameters. Parameters may be static as well as dynamic runtime properties of executions. The size of the result set can be retrieved by using the [Get External Task Count](https://docs.camunda.org/manual/7.16/reference/rest/external-task/get-query-count/) method.

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
    public class GetExternalTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var externalTaskId = externalTaskId_example;  // string | Filter by an external task's id. (optional) 
            var externalTaskIdIn = externalTaskIdIn_example;  // string | Filter by the comma-separated list of external task ids. (optional) 
            var topicName = topicName_example;  // string | Filter by an external task topic. (optional) 
            var workerId = workerId_example;  // string | Filter by the id of the worker that the task was most recently locked by. (optional) 
            var locked = true;  // bool? | Only include external tasks that are currently locked (i.e., they have a lock time and it has not expired). Value may only be `true`, as `false` matches any external task. (optional) 
            var notLocked = true;  // bool? | Only include external tasks that are currently not locked (i.e., they have no lock or it has expired). Value may only be `true`, as `false` matches any external task. (optional) 
            var withRetriesLeft = true;  // bool? | Only include external tasks that have a positive (&gt; 0) number of retries (or `null`). Value may only be `true`, as `false` matches any external task. (optional) 
            var noRetriesLeft = true;  // bool? | Only include external tasks that have 0 retries. Value may only be `true`, as `false` matches any external task. (optional) 
            var lockExpirationAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to external tasks that have a lock that expires after a given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var lockExpirationBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to external tasks that have a lock that expires before a given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var activityId = activityId_example;  // string | Filter by the id of the activity that an external task is created for. (optional) 
            var activityIdIn = activityIdIn_example;  // string | Filter by the comma-separated list of ids of the activities that an external task is created for. (optional) 
            var executionId = executionId_example;  // string | Filter by the id of the execution that an external task belongs to. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by the id of the process instance that an external task belongs to. (optional) 
            var processInstanceIdIn = processInstanceIdIn_example;  // string | Filter by a comma-separated list of process instance ids that an external task may belong to. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the id of the process definition that an external task belongs to. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. An external task must have one of the given tenant ids. (optional) 
            var active = true;  // bool? | Only include active tasks. Value may only be `true`, as `false` matches any external task. (optional) 
            var suspended = true;  // bool? | Only include suspended tasks. Value may only be `true`, as `false` matches any external task. (optional) 
            var priorityHigherThanOrEquals = 789;  // long? | Only include jobs with a priority higher than or equal to the given value. Value must be a valid `long` value. (optional) 
            var priorityLowerThanOrEquals = 789;  // long? | Only include jobs with a priority lower than or equal to the given value. Value must be a valid `long` value. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get List
                List<ExternalTaskDto> result = apiInstance.GetExternalTasks(externalTaskId, externalTaskIdIn, topicName, workerId, locked, notLocked, withRetriesLeft, noRetriesLeft, lockExpirationAfter, lockExpirationBefore, activityId, activityIdIn, executionId, processInstanceId, processInstanceIdIn, processDefinitionId, tenantIdIn, active, suspended, priorityHigherThanOrEquals, priorityLowerThanOrEquals, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.GetExternalTasks: " + e.Message );
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
 **externalTaskId** | **string**| Filter by an external task&#39;s id. | [optional] 
 **externalTaskIdIn** | **string**| Filter by the comma-separated list of external task ids. | [optional] 
 **topicName** | **string**| Filter by an external task topic. | [optional] 
 **workerId** | **string**| Filter by the id of the worker that the task was most recently locked by. | [optional] 
 **locked** | **bool?**| Only include external tasks that are currently locked (i.e., they have a lock time and it has not expired). Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **notLocked** | **bool?**| Only include external tasks that are currently not locked (i.e., they have no lock or it has expired). Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **withRetriesLeft** | **bool?**| Only include external tasks that have a positive (&amp;gt; 0) number of retries (or &#x60;null&#x60;). Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **noRetriesLeft** | **bool?**| Only include external tasks that have 0 retries. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **lockExpirationAfter** | **DateTime?**| Restrict to external tasks that have a lock that expires after a given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **lockExpirationBefore** | **DateTime?**| Restrict to external tasks that have a lock that expires before a given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **activityId** | **string**| Filter by the id of the activity that an external task is created for. | [optional] 
 **activityIdIn** | **string**| Filter by the comma-separated list of ids of the activities that an external task is created for. | [optional] 
 **executionId** | **string**| Filter by the id of the execution that an external task belongs to. | [optional] 
 **processInstanceId** | **string**| Filter by the id of the process instance that an external task belongs to. | [optional] 
 **processInstanceIdIn** | **string**| Filter by a comma-separated list of process instance ids that an external task may belong to. | [optional] 
 **processDefinitionId** | **string**| Filter by the id of the process definition that an external task belongs to. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. An external task must have one of the given tenant ids. | [optional] 
 **active** | **bool?**| Only include active tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **suspended** | **bool?**| Only include suspended tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **priorityHigherThanOrEquals** | **long?**| Only include jobs with a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **priorityLowerThanOrEquals** | **long?**| Only include jobs with a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;ExternalTaskDto&gt;**](ExternalTaskDto.md)

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

<a name="getexternaltaskscount"></a>
# **GetExternalTasksCount**
> CountResultDto GetExternalTasksCount (string externalTaskId = null, string externalTaskIdIn = null, string topicName = null, string workerId = null, bool? locked = null, bool? notLocked = null, bool? withRetriesLeft = null, bool? noRetriesLeft = null, DateTime? lockExpirationAfter = null, DateTime? lockExpirationBefore = null, string activityId = null, string activityIdIn = null, string executionId = null, string processInstanceId = null, string processInstanceIdIn = null, string processDefinitionId = null, string tenantIdIn = null, bool? active = null, bool? suspended = null, long? priorityHigherThanOrEquals = null, long? priorityLowerThanOrEquals = null)

Get List Count

Queries for the number of external tasks that fulfill given parameters. Takes the same parameters as the [Get External Tasks](https://docs.camunda.org/manual/7.16/reference/rest/external-task/get-query/) method.

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
    public class GetExternalTasksCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var externalTaskId = externalTaskId_example;  // string | Filter by an external task's id. (optional) 
            var externalTaskIdIn = externalTaskIdIn_example;  // string | Filter by the comma-separated list of external task ids. (optional) 
            var topicName = topicName_example;  // string | Filter by an external task topic. (optional) 
            var workerId = workerId_example;  // string | Filter by the id of the worker that the task was most recently locked by. (optional) 
            var locked = true;  // bool? | Only include external tasks that are currently locked (i.e., they have a lock time and it has not expired). Value may only be `true`, as `false` matches any external task. (optional) 
            var notLocked = true;  // bool? | Only include external tasks that are currently not locked (i.e., they have no lock or it has expired). Value may only be `true`, as `false` matches any external task. (optional) 
            var withRetriesLeft = true;  // bool? | Only include external tasks that have a positive (&gt; 0) number of retries (or `null`). Value may only be `true`, as `false` matches any external task. (optional) 
            var noRetriesLeft = true;  // bool? | Only include external tasks that have 0 retries. Value may only be `true`, as `false` matches any external task. (optional) 
            var lockExpirationAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to external tasks that have a lock that expires after a given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var lockExpirationBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to external tasks that have a lock that expires before a given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var activityId = activityId_example;  // string | Filter by the id of the activity that an external task is created for. (optional) 
            var activityIdIn = activityIdIn_example;  // string | Filter by the comma-separated list of ids of the activities that an external task is created for. (optional) 
            var executionId = executionId_example;  // string | Filter by the id of the execution that an external task belongs to. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by the id of the process instance that an external task belongs to. (optional) 
            var processInstanceIdIn = processInstanceIdIn_example;  // string | Filter by a comma-separated list of process instance ids that an external task may belong to. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the id of the process definition that an external task belongs to. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. An external task must have one of the given tenant ids. (optional) 
            var active = true;  // bool? | Only include active tasks. Value may only be `true`, as `false` matches any external task. (optional) 
            var suspended = true;  // bool? | Only include suspended tasks. Value may only be `true`, as `false` matches any external task. (optional) 
            var priorityHigherThanOrEquals = 789;  // long? | Only include jobs with a priority higher than or equal to the given value. Value must be a valid `long` value. (optional) 
            var priorityLowerThanOrEquals = 789;  // long? | Only include jobs with a priority lower than or equal to the given value. Value must be a valid `long` value. (optional) 

            try
            {
                // Get List Count
                CountResultDto result = apiInstance.GetExternalTasksCount(externalTaskId, externalTaskIdIn, topicName, workerId, locked, notLocked, withRetriesLeft, noRetriesLeft, lockExpirationAfter, lockExpirationBefore, activityId, activityIdIn, executionId, processInstanceId, processInstanceIdIn, processDefinitionId, tenantIdIn, active, suspended, priorityHigherThanOrEquals, priorityLowerThanOrEquals);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.GetExternalTasksCount: " + e.Message );
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
 **externalTaskId** | **string**| Filter by an external task&#39;s id. | [optional] 
 **externalTaskIdIn** | **string**| Filter by the comma-separated list of external task ids. | [optional] 
 **topicName** | **string**| Filter by an external task topic. | [optional] 
 **workerId** | **string**| Filter by the id of the worker that the task was most recently locked by. | [optional] 
 **locked** | **bool?**| Only include external tasks that are currently locked (i.e., they have a lock time and it has not expired). Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **notLocked** | **bool?**| Only include external tasks that are currently not locked (i.e., they have no lock or it has expired). Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **withRetriesLeft** | **bool?**| Only include external tasks that have a positive (&amp;gt; 0) number of retries (or &#x60;null&#x60;). Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **noRetriesLeft** | **bool?**| Only include external tasks that have 0 retries. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **lockExpirationAfter** | **DateTime?**| Restrict to external tasks that have a lock that expires after a given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **lockExpirationBefore** | **DateTime?**| Restrict to external tasks that have a lock that expires before a given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **activityId** | **string**| Filter by the id of the activity that an external task is created for. | [optional] 
 **activityIdIn** | **string**| Filter by the comma-separated list of ids of the activities that an external task is created for. | [optional] 
 **executionId** | **string**| Filter by the id of the execution that an external task belongs to. | [optional] 
 **processInstanceId** | **string**| Filter by the id of the process instance that an external task belongs to. | [optional] 
 **processInstanceIdIn** | **string**| Filter by a comma-separated list of process instance ids that an external task may belong to. | [optional] 
 **processDefinitionId** | **string**| Filter by the id of the process definition that an external task belongs to. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. An external task must have one of the given tenant ids. | [optional] 
 **active** | **bool?**| Only include active tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **suspended** | **bool?**| Only include suspended tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **priorityHigherThanOrEquals** | **long?**| Only include jobs with a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **priorityLowerThanOrEquals** | **long?**| Only include jobs with a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 

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

<a name="gettopicnames"></a>
# **GetTopicNames**
> List&lt;string&gt; GetTopicNames (bool? withLockedTasks = null, bool? withUnlockedTasks = null, bool? withRetriesLeft = null)

Get External Task Topic Names

Queries for distinct topic names of external tasks that fulfill given parameters. Query can be restricted to only tasks with retries left, tasks that are locked, or tasks that are unlocked. The parameters withLockedTasks and withUnlockedTasks are exclusive. Setting them both to true will return an empty list. Providing no parameters will return a list of all distinct topic names with external tasks.

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
    public class GetTopicNamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var withLockedTasks = true;  // bool? | Only include external tasks that are currently locked (i.e., they have a lock time and it has not expired). Value may only be `true`, as `false` matches any external task. (optional) 
            var withUnlockedTasks = true;  // bool? | Only include external tasks that are currently not locked (i.e., they have no lock or it has expired). Value may only be `true`, as `false` matches any external task. (optional) 
            var withRetriesLeft = true;  // bool? | Only include external tasks that have a positive (&gt; 0) number of retries (or `null`). Value may only be `true`, as `false` matches any external task. (optional) 

            try
            {
                // Get External Task Topic Names
                List<string> result = apiInstance.GetTopicNames(withLockedTasks, withUnlockedTasks, withRetriesLeft);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.GetTopicNames: " + e.Message );
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
 **withLockedTasks** | **bool?**| Only include external tasks that are currently locked (i.e., they have a lock time and it has not expired). Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **withUnlockedTasks** | **bool?**| Only include external tasks that are currently not locked (i.e., they have no lock or it has expired). Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 
 **withRetriesLeft** | **bool?**| Only include external tasks that have a positive (&amp;gt; 0) number of retries (or &#x60;null&#x60;). Value may only be &#x60;true&#x60;, as &#x60;false&#x60; matches any external task. | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handleexternaltaskbpmnerror"></a>
# **HandleExternalTaskBpmnError**
> void HandleExternalTaskBpmnError (string id, ExternalTaskBpmnError externalTaskBpmnError = null)

Handle BPMN Error

Reports a business error in the context of a running external task by id. The error code must be specified to identify the BPMN error handler.

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
    public class HandleExternalTaskBpmnErrorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the external task in which context a BPMN error is reported.
            var externalTaskBpmnError = new ExternalTaskBpmnError(); // ExternalTaskBpmnError |  (optional) 

            try
            {
                // Handle BPMN Error
                apiInstance.HandleExternalTaskBpmnError(id, externalTaskBpmnError);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.HandleExternalTaskBpmnError: " + e.Message );
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
 **id** | **string**| The id of the external task in which context a BPMN error is reported. | 
 **externalTaskBpmnError** | [**ExternalTaskBpmnError**](ExternalTaskBpmnError.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | Returned if the task&#39;s most recent lock was not acquired by the provided worker.  See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Returned if the task does not exist. This could indicate a wrong task id as well as a cancelled task, e.g., due to a caught BPMN boundary event.  See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | Returned if the corresponding process instance could not be resumed successfully.  See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlefailure"></a>
# **HandleFailure**
> void HandleFailure (string id, ExternalTaskFailureDto externalTaskFailureDto = null)

Handle Failure

Reports a failure to execute an external task by id. A number of retries and a timeout until the task can be retried can be specified. If retries are set to 0, an incident for this task is created.

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
    public class HandleFailureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the external task to report a failure for.
            var externalTaskFailureDto = new ExternalTaskFailureDto(); // ExternalTaskFailureDto |  (optional) 

            try
            {
                // Handle Failure
                apiInstance.HandleFailure(id, externalTaskFailureDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.HandleFailure: " + e.Message );
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
 **id** | **string**| The id of the external task to report a failure for. | 
 **externalTaskFailureDto** | [**ExternalTaskFailureDto**](ExternalTaskFailureDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | Returned if the task&#39;s most recent lock was not acquired by the provided worker. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Returned if the task does not exist. This could indicate a wrong task id as well as a cancelled task, e.g., due to a caught BPMN boundary event. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | Returned if the corresponding process instance could not be resumed successfully. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryexternaltasks"></a>
# **QueryExternalTasks**
> List&lt;ExternalTaskDto&gt; QueryExternalTasks (int? firstResult = null, int? maxResults = null, ExternalTaskQueryDto externalTaskQueryDto = null)

Get List (POST)

Queries for external tasks that fulfill given parameters in the form of a JSON object.  This method is slightly more powerful than the [Get External Tasks](https://docs.camunda.org/manual/7.16/reference/rest/external-task/get-query/) method because it allows to specify a hierarchical result sorting.

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
    public class QueryExternalTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var externalTaskQueryDto = new ExternalTaskQueryDto(); // ExternalTaskQueryDto |  (optional) 

            try
            {
                // Get List (POST)
                List<ExternalTaskDto> result = apiInstance.QueryExternalTasks(firstResult, maxResults, externalTaskQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.QueryExternalTasks: " + e.Message );
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
 **externalTaskQueryDto** | [**ExternalTaskQueryDto**](ExternalTaskQueryDto.md)|  | [optional] 

### Return type

[**List&lt;ExternalTaskDto&gt;**](ExternalTaskDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. The Response is a JSON array of external task objects. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryexternaltaskscount"></a>
# **QueryExternalTasksCount**
> CountResultDto QueryExternalTasksCount (ExternalTaskQueryDto externalTaskQueryDto = null)

Get List Count (POST)

Queries for the number of external tasks that fulfill given parameters. This method takes the same message body as the [Get External Tasks (POST)](https://docs.camunda.org/manual/7.16/reference/rest/external-task/post-query/) method.

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
    public class QueryExternalTasksCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var externalTaskQueryDto = new ExternalTaskQueryDto(); // ExternalTaskQueryDto |  (optional) 

            try
            {
                // Get List Count (POST)
                CountResultDto result = apiInstance.QueryExternalTasksCount(externalTaskQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.QueryExternalTasksCount: " + e.Message );
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
 **externalTaskQueryDto** | [**ExternalTaskQueryDto**](ExternalTaskQueryDto.md)|  | [optional] 

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
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setexternaltaskresourcepriority"></a>
# **SetExternalTaskResourcePriority**
> void SetExternalTaskResourcePriority (string id, PriorityDto priorityDto = null)

Set Priority

Sets the priority of an existing external task by id. The default value of a priority is 0.

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
    public class SetExternalTaskResourcePriorityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the external task to set the priority for.
            var priorityDto = new PriorityDto(); // PriorityDto |  (optional) 

            try
            {
                // Set Priority
                apiInstance.SetExternalTaskResourcePriority(id, priorityDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.SetExternalTaskResourcePriority: " + e.Message );
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
 **id** | **string**| The id of the external task to set the priority for. | 
 **priorityDto** | [**PriorityDto**](PriorityDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **404** | Returned if the task does not exist. This could indicate a wrong task id as well as a cancelled task, e.g., due to a caught BPMN boundary event. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setexternaltaskresourceretries"></a>
# **SetExternalTaskResourceRetries**
> void SetExternalTaskResourceRetries (string id, RetriesDto retriesDto = null)

Set Retries

Sets the number of retries left to execute an external task by id. If retries are set to 0, an  incident is created.

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
    public class SetExternalTaskResourceRetriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the external task to set the number of retries for.
            var retriesDto = new RetriesDto(); // RetriesDto |  (optional) 

            try
            {
                // Set Retries
                apiInstance.SetExternalTaskResourceRetries(id, retriesDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.SetExternalTaskResourceRetries: " + e.Message );
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
 **id** | **string**| The id of the external task to set the number of retries for. | 
 **retriesDto** | [**RetriesDto**](RetriesDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | Returned if the task does not exist. This could indicate a wrong task id as well as a cancelled task, e.g., due to a caught BPMN boundary event. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | In case the number of retries is negative or null, an exception of type &#x60;InvalidRequestException&#x60; is returned. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setexternaltaskretries"></a>
# **SetExternalTaskRetries**
> void SetExternalTaskRetries (SetRetriesForExternalTasksDto setRetriesForExternalTasksDto = null)

Set Retries Sync

Sets the number of retries left to execute external tasks by id synchronously. If retries are set to 0,  an incident is created.

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
    public class SetExternalTaskRetriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var setRetriesForExternalTasksDto = new SetRetriesForExternalTasksDto(); // SetRetriesForExternalTasksDto |  (optional) 

            try
            {
                // Set Retries Sync
                apiInstance.SetExternalTaskRetries(setRetriesForExternalTasksDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.SetExternalTaskRetries: " + e.Message );
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
 **setRetriesForExternalTasksDto** | [**SetRetriesForExternalTasksDto**](SetRetriesForExternalTasksDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | In case the number of retries is negative or null, an exception of type &#x60;InvalidRequestException&#x60; is returned. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Returned if the task does not exist. This could indicate a wrong task id as well as a cancelled task,  e.g., due to a caught BPMN boundary event. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setexternaltaskretriesasyncoperation"></a>
# **SetExternalTaskRetriesAsyncOperation**
> BatchDto SetExternalTaskRetriesAsyncOperation (SetRetriesForExternalTasksDto setRetriesForExternalTasksDto = null)

Set Retries Async

Sets the number of retries left to execute external tasks by id asynchronously. If retries are set to 0, an incident is created.

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
    public class SetExternalTaskRetriesAsyncOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var setRetriesForExternalTasksDto = new SetRetriesForExternalTasksDto(); // SetRetriesForExternalTasksDto |  (optional) 

            try
            {
                // Set Retries Async
                BatchDto result = apiInstance.SetExternalTaskRetriesAsyncOperation(setRetriesForExternalTasksDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.SetExternalTaskRetriesAsyncOperation: " + e.Message );
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
 **setRetriesForExternalTasksDto** | [**SetRetriesForExternalTasksDto**](SetRetriesForExternalTasksDto.md)|  | [optional] 

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
| **400** | If neither externalTaskIds nor externalTaskQuery are present or externalTaskIds contains null value or  the number of retries is negative or null, an exception of type &#x60;InvalidRequestException&#x60; is returned. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Returned if the task does not exist. This could indicate a wrong task id as well as a cancelled task,  e.g., due to a caught BPMN boundary event. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unlock"></a>
# **Unlock**
> void Unlock (string id)

Unlock

Unlocks an external task by id. Clears the task's lock expiration time and worker id.

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
    public class UnlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExternalTaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the external task to unlock.

            try
            {
                // Unlock
                apiInstance.Unlock(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalTaskApi.Unlock: " + e.Message );
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
 **id** | **string**| The id of the external task to unlock. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **404** | Returned if the task does not exist. This could indicate a wrong task id as well as a cancelled task, e.g., due to a caught BPMN boundary event. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

