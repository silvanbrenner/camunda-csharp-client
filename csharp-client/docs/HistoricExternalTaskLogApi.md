# Camunda.OpenApi.Client.Api.HistoricExternalTaskLogApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetErrorDetailsHistoricExternalTaskLog**](HistoricExternalTaskLogApi.md#geterrordetailshistoricexternaltasklog) | **GET** /history/external-task-log/{id}/error-details | Get External Task Log Error Details
[**GetHistoricExternalTaskLog**](HistoricExternalTaskLogApi.md#gethistoricexternaltasklog) | **GET** /history/external-task-log/{id} | Get External Task Log
[**GetHistoricExternalTaskLogs**](HistoricExternalTaskLogApi.md#gethistoricexternaltasklogs) | **GET** /history/external-task-log | Get External Task Logs
[**GetHistoricExternalTaskLogsCount**](HistoricExternalTaskLogApi.md#gethistoricexternaltasklogscount) | **GET** /history/external-task-log/count | Get External Task Log Count
[**QueryHistoricExternalTaskLogs**](HistoricExternalTaskLogApi.md#queryhistoricexternaltasklogs) | **POST** /history/external-task-log | Get External Task Logs (POST)
[**QueryHistoricExternalTaskLogsCount**](HistoricExternalTaskLogApi.md#queryhistoricexternaltasklogscount) | **POST** /history/external-task-log/count | Get External Task Log Count (POST)


<a name="geterrordetailshistoricexternaltasklog"></a>
# **GetErrorDetailsHistoricExternalTaskLog**
> Object GetErrorDetailsHistoricExternalTaskLog (string id)

Get External Task Log Error Details

Retrieves the corresponding error details of the passed historic external task log by id.

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
    public class GetErrorDetailsHistoricExternalTaskLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricExternalTaskLogApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the historic external task log to get the error details for.

            try
            {
                // Get External Task Log Error Details
                Object result = apiInstance.GetErrorDetailsHistoricExternalTaskLog(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricExternalTaskLogApi.GetErrorDetailsHistoricExternalTaskLog: " + e.Message );
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
 **id** | **string**| The id of the historic external task log to get the error details for. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Historic external task log with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricexternaltasklog"></a>
# **GetHistoricExternalTaskLog**
> HistoricExternalTaskLogDto GetHistoricExternalTaskLog (string id)

Get External Task Log

Retrieves a historic external task log by id.

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
    public class GetHistoricExternalTaskLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricExternalTaskLogApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the log entry.

            try
            {
                // Get External Task Log
                HistoricExternalTaskLogDto result = apiInstance.GetHistoricExternalTaskLog(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricExternalTaskLogApi.GetHistoricExternalTaskLog: " + e.Message );
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
 **id** | **string**| The id of the log entry. | 

### Return type

[**HistoricExternalTaskLogDto**](HistoricExternalTaskLogDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Historic external task log with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricexternaltasklogs"></a>
# **GetHistoricExternalTaskLogs**
> List&lt;HistoricExternalTaskLogDto&gt; GetHistoricExternalTaskLogs (string logId = null, string externalTaskId = null, string topicName = null, string workerId = null, string errorMessage = null, string activityIdIn = null, string activityInstanceIdIn = null, string executionIdIn = null, string processInstanceId = null, string processDefinitionId = null, string processDefinitionKey = null, string tenantIdIn = null, bool? withoutTenantId = null, long? priorityLowerThanOrEquals = null, long? priorityHigherThanOrEquals = null, bool? creationLog = null, bool? failureLog = null, bool? successLog = null, bool? deletionLog = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get External Task Logs

Queries for historic external task logs that fulfill the given parameters. The size of the result set can be retrieved by using the [Get External Task Log Count](https://docs.camunda.org/manual/7.16/reference/rest/history/external-task-log/get-external-task-log-query-count/) method.

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
    public class GetHistoricExternalTaskLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricExternalTaskLogApi(httpClient, config, httpClientHandler);
            var logId = logId_example;  // string | Filter by historic external task log id. (optional) 
            var externalTaskId = externalTaskId_example;  // string | Filter by external task id. (optional) 
            var topicName = topicName_example;  // string | Filter by an external task topic. (optional) 
            var workerId = workerId_example;  // string | Filter by the id of the worker that the task was most recently locked by. (optional) 
            var errorMessage = errorMessage_example;  // string | Filter by external task exception message. (optional) 
            var activityIdIn = activityIdIn_example;  // string | Only include historic external task logs which belong to one of the passed activity ids. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Only include historic external task logs which belong to one of the passed activity instance ids. (optional) 
            var executionIdIn = executionIdIn_example;  // string | Only include historic external task logs which belong to one of the passed execution ids. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by process definition key. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include historic external task log entries which belong to one of the passed and comma-separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic external task log entries that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var priorityLowerThanOrEquals = 789;  // long? | Only include logs for which the associated external task had a priority lower than or equal to the given value. Value must be a valid `long` value. (optional) 
            var priorityHigherThanOrEquals = 789;  // long? | Only include logs for which the associated external task had a priority higher than or equal to the given value. Value must be a valid `long` value. (optional) 
            var creationLog = true;  // bool? | Only include creation logs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var failureLog = true;  // bool? | Only include failure logs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var successLog = true;  // bool? | Only include success logs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var deletionLog = true;  // bool? | Only include deletion logs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get External Task Logs
                List<HistoricExternalTaskLogDto> result = apiInstance.GetHistoricExternalTaskLogs(logId, externalTaskId, topicName, workerId, errorMessage, activityIdIn, activityInstanceIdIn, executionIdIn, processInstanceId, processDefinitionId, processDefinitionKey, tenantIdIn, withoutTenantId, priorityLowerThanOrEquals, priorityHigherThanOrEquals, creationLog, failureLog, successLog, deletionLog, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricExternalTaskLogApi.GetHistoricExternalTaskLogs: " + e.Message );
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
 **logId** | **string**| Filter by historic external task log id. | [optional] 
 **externalTaskId** | **string**| Filter by external task id. | [optional] 
 **topicName** | **string**| Filter by an external task topic. | [optional] 
 **workerId** | **string**| Filter by the id of the worker that the task was most recently locked by. | [optional] 
 **errorMessage** | **string**| Filter by external task exception message. | [optional] 
 **activityIdIn** | **string**| Only include historic external task logs which belong to one of the passed activity ids. | [optional] 
 **activityInstanceIdIn** | **string**| Only include historic external task logs which belong to one of the passed activity instance ids. | [optional] 
 **executionIdIn** | **string**| Only include historic external task logs which belong to one of the passed execution ids. | [optional] 
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **processDefinitionKey** | **string**| Filter by process definition key. | [optional] 
 **tenantIdIn** | **string**| Only include historic external task log entries which belong to one of the passed and comma-separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic external task log entries that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **priorityLowerThanOrEquals** | **long?**| Only include logs for which the associated external task had a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **priorityHigherThanOrEquals** | **long?**| Only include logs for which the associated external task had a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **creationLog** | **bool?**| Only include creation logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **failureLog** | **bool?**| Only include failure logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **successLog** | **bool?**| Only include success logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **deletionLog** | **bool?**| Only include deletion logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;HistoricExternalTaskLogDto&gt;**](HistoricExternalTaskLogDto.md)

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

<a name="gethistoricexternaltasklogscount"></a>
# **GetHistoricExternalTaskLogsCount**
> CountResultDto GetHistoricExternalTaskLogsCount (string logId = null, string externalTaskId = null, string topicName = null, string workerId = null, string errorMessage = null, string activityIdIn = null, string activityInstanceIdIn = null, string executionIdIn = null, string processInstanceId = null, string processDefinitionId = null, string processDefinitionKey = null, string tenantIdIn = null, bool? withoutTenantId = null, long? priorityLowerThanOrEquals = null, long? priorityHigherThanOrEquals = null, bool? creationLog = null, bool? failureLog = null, bool? successLog = null, bool? deletionLog = null)

Get External Task Log Count

Queries for the number of historic external task logs that fulfill the given parameters. Takes the same parameters as the [Get External Task Logs](https://docs.camunda.org/manual/7.16/reference/rest/history/external-task-log/get-external-task-log-query/) method.

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
    public class GetHistoricExternalTaskLogsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricExternalTaskLogApi(httpClient, config, httpClientHandler);
            var logId = logId_example;  // string | Filter by historic external task log id. (optional) 
            var externalTaskId = externalTaskId_example;  // string | Filter by external task id. (optional) 
            var topicName = topicName_example;  // string | Filter by an external task topic. (optional) 
            var workerId = workerId_example;  // string | Filter by the id of the worker that the task was most recently locked by. (optional) 
            var errorMessage = errorMessage_example;  // string | Filter by external task exception message. (optional) 
            var activityIdIn = activityIdIn_example;  // string | Only include historic external task logs which belong to one of the passed activity ids. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Only include historic external task logs which belong to one of the passed activity instance ids. (optional) 
            var executionIdIn = executionIdIn_example;  // string | Only include historic external task logs which belong to one of the passed execution ids. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by process definition key. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include historic external task log entries which belong to one of the passed and comma-separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic external task log entries that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var priorityLowerThanOrEquals = 789;  // long? | Only include logs for which the associated external task had a priority lower than or equal to the given value. Value must be a valid `long` value. (optional) 
            var priorityHigherThanOrEquals = 789;  // long? | Only include logs for which the associated external task had a priority higher than or equal to the given value. Value must be a valid `long` value. (optional) 
            var creationLog = true;  // bool? | Only include creation logs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var failureLog = true;  // bool? | Only include failure logs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var successLog = true;  // bool? | Only include success logs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var deletionLog = true;  // bool? | Only include deletion logs. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get External Task Log Count
                CountResultDto result = apiInstance.GetHistoricExternalTaskLogsCount(logId, externalTaskId, topicName, workerId, errorMessage, activityIdIn, activityInstanceIdIn, executionIdIn, processInstanceId, processDefinitionId, processDefinitionKey, tenantIdIn, withoutTenantId, priorityLowerThanOrEquals, priorityHigherThanOrEquals, creationLog, failureLog, successLog, deletionLog);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricExternalTaskLogApi.GetHistoricExternalTaskLogsCount: " + e.Message );
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
 **logId** | **string**| Filter by historic external task log id. | [optional] 
 **externalTaskId** | **string**| Filter by external task id. | [optional] 
 **topicName** | **string**| Filter by an external task topic. | [optional] 
 **workerId** | **string**| Filter by the id of the worker that the task was most recently locked by. | [optional] 
 **errorMessage** | **string**| Filter by external task exception message. | [optional] 
 **activityIdIn** | **string**| Only include historic external task logs which belong to one of the passed activity ids. | [optional] 
 **activityInstanceIdIn** | **string**| Only include historic external task logs which belong to one of the passed activity instance ids. | [optional] 
 **executionIdIn** | **string**| Only include historic external task logs which belong to one of the passed execution ids. | [optional] 
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **processDefinitionKey** | **string**| Filter by process definition key. | [optional] 
 **tenantIdIn** | **string**| Only include historic external task log entries which belong to one of the passed and comma-separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic external task log entries that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **priorityLowerThanOrEquals** | **long?**| Only include logs for which the associated external task had a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **priorityHigherThanOrEquals** | **long?**| Only include logs for which the associated external task had a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **creationLog** | **bool?**| Only include creation logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **failureLog** | **bool?**| Only include failure logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **successLog** | **bool?**| Only include success logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **deletionLog** | **bool?**| Only include deletion logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistoricexternaltasklogs"></a>
# **QueryHistoricExternalTaskLogs**
> List&lt;HistoricExternalTaskLogDto&gt; QueryHistoricExternalTaskLogs (HistoricExternalTaskLogQueryDto historicExternalTaskLogQueryDto = null)

Get External Task Logs (POST)

Queries for historic external task logs that fulfill the given parameters. This method is slightly more powerful than the [Get External Task Logs](https://docs.camunda.org/manual/7.16/reference/rest/history/external-task-log/get-external-task-log-query/) method because it allows filtering by historic external task logs values of the different types `String`, `Number` or `Boolean`.

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
    public class QueryHistoricExternalTaskLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricExternalTaskLogApi(httpClient, config, httpClientHandler);
            var historicExternalTaskLogQueryDto = new HistoricExternalTaskLogQueryDto(); // HistoricExternalTaskLogQueryDto |  (optional) 

            try
            {
                // Get External Task Logs (POST)
                List<HistoricExternalTaskLogDto> result = apiInstance.QueryHistoricExternalTaskLogs(historicExternalTaskLogQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricExternalTaskLogApi.QueryHistoricExternalTaskLogs: " + e.Message );
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
 **historicExternalTaskLogQueryDto** | [**HistoricExternalTaskLogQueryDto**](HistoricExternalTaskLogQueryDto.md)|  | [optional] 

### Return type

[**List&lt;HistoricExternalTaskLogDto&gt;**](HistoricExternalTaskLogDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistoricexternaltasklogscount"></a>
# **QueryHistoricExternalTaskLogsCount**
> CountResultDto QueryHistoricExternalTaskLogsCount (HistoricExternalTaskLogQueryDto historicExternalTaskLogQueryDto = null)

Get External Task Log Count (POST)

Queries for the number of historic external task logs that fulfill the given parameters. This method takes the same message body as the [Get External Task Logs (POST)](https://docs.camunda.org/manual/7.16/reference/rest/history/external-task-log/post-external-task-log-query/) method and therefore it is slightly more powerful than the [Get External Task Log Count](https://docs.camunda.org/manual/7.16/reference/rest/history/external-task-log/get-external-task-log-query-count/) method.

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
    public class QueryHistoricExternalTaskLogsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricExternalTaskLogApi(httpClient, config, httpClientHandler);
            var historicExternalTaskLogQueryDto = new HistoricExternalTaskLogQueryDto(); // HistoricExternalTaskLogQueryDto |  (optional) 

            try
            {
                // Get External Task Log Count (POST)
                CountResultDto result = apiInstance.QueryHistoricExternalTaskLogsCount(historicExternalTaskLogQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricExternalTaskLogApi.QueryHistoricExternalTaskLogsCount: " + e.Message );
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
 **historicExternalTaskLogQueryDto** | [**HistoricExternalTaskLogQueryDto**](HistoricExternalTaskLogQueryDto.md)|  | [optional] 

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

