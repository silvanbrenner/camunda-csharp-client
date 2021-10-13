# Camunda.OpenApi.Client.Api.HistoricJobLogApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHistoricJobLog**](HistoricJobLogApi.md#gethistoricjoblog) | **GET** /history/job-log/{id} | Get Job Log
[**GetHistoricJobLogs**](HistoricJobLogApi.md#gethistoricjoblogs) | **GET** /history/job-log | Get Job Logs
[**GetHistoricJobLogsCount**](HistoricJobLogApi.md#gethistoricjoblogscount) | **GET** /history/job-log/count | Get Job Log Count
[**GetStacktraceHistoricJobLog**](HistoricJobLogApi.md#getstacktracehistoricjoblog) | **GET** /history/job-log/{id}/stacktrace | Get Job Log Exception Stacktrace
[**QueryHistoricJobLogs**](HistoricJobLogApi.md#queryhistoricjoblogs) | **POST** /history/job-log | Get Job Logs (POST)
[**QueryHistoricJobLogsCount**](HistoricJobLogApi.md#queryhistoricjoblogscount) | **POST** /history/job-log/count | Get Job Log Count (POST)


<a name="gethistoricjoblog"></a>
# **GetHistoricJobLog**
> HistoricJobLogDto GetHistoricJobLog (string id)

Get Job Log

Retrieves a historic job log by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricJobLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricJobLogApi(config);
            var id = id_example;  // string | The id of the log entry.

            try
            {
                // Get Job Log
                HistoricJobLogDto result = apiInstance.GetHistoricJobLog(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricJobLogApi.GetHistoricJobLog: " + e.Message );
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

[**HistoricJobLogDto**](HistoricJobLogDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Historic job log with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricjoblogs"></a>
# **GetHistoricJobLogs**
> List&lt;HistoricJobLogDto&gt; GetHistoricJobLogs (string logId = null, string jobId = null, string jobExceptionMessage = null, string jobDefinitionId = null, string jobDefinitionType = null, string jobDefinitionConfiguration = null, string activityIdIn = null, string failedActivityIdIn = null, string executionIdIn = null, string processInstanceId = null, string processDefinitionId = null, string processDefinitionKey = null, string deploymentId = null, string tenantIdIn = null, bool? withoutTenantId = null, string hostname = null, long? jobPriorityLowerThanOrEquals = null, long? jobPriorityHigherThanOrEquals = null, bool? creationLog = null, bool? failureLog = null, bool? successLog = null, bool? deletionLog = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Job Logs

Queries for historic job logs that fulfill the given parameters. The size of the result set can be retrieved by using the [Get Job Log Count](https://docs.camunda.org/manual/7.16/reference/rest/history/job-log/get-job-log-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricJobLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricJobLogApi(config);
            var logId = logId_example;  // string | Filter by historic job log id. (optional) 
            var jobId = jobId_example;  // string | Filter by job id. (optional) 
            var jobExceptionMessage = jobExceptionMessage_example;  // string | Filter by job exception message. (optional) 
            var jobDefinitionId = jobDefinitionId_example;  // string | Filter by job definition id. (optional) 
            var jobDefinitionType = jobDefinitionType_example;  // string | Filter by job definition type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/the-job-executor/#job-creation) for more information about job definition types. (optional) 
            var jobDefinitionConfiguration = jobDefinitionConfiguration_example;  // string | Filter by job definition configuration. (optional) 
            var activityIdIn = activityIdIn_example;  // string | Only include historic job logs which belong to one of the passed activity ids. (optional) 
            var failedActivityIdIn = failedActivityIdIn_example;  // string | Only include historic job logs which belong to failures of one of the passed activity ids. (optional) 
            var executionIdIn = executionIdIn_example;  // string | Only include historic job logs which belong to one of the passed execution ids. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by process definition key. (optional) 
            var deploymentId = deploymentId_example;  // string | Filter by deployment id. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include historic job log entries which belong to one of the passed and comma- separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic job log entries that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var hostname = hostname_example;  // string | Filter by hostname. (optional) 
            var jobPriorityLowerThanOrEquals = 789;  // long? | Only include logs for which the associated job had a priority lower than or equal to the given value. Value must be a valid `long` value. (optional) 
            var jobPriorityHigherThanOrEquals = 789;  // long? | Only include logs for which the associated job had a priority higher than or equal to the given value. Value must be a valid `long` value. (optional) 
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
                // Get Job Logs
                List<HistoricJobLogDto> result = apiInstance.GetHistoricJobLogs(logId, jobId, jobExceptionMessage, jobDefinitionId, jobDefinitionType, jobDefinitionConfiguration, activityIdIn, failedActivityIdIn, executionIdIn, processInstanceId, processDefinitionId, processDefinitionKey, deploymentId, tenantIdIn, withoutTenantId, hostname, jobPriorityLowerThanOrEquals, jobPriorityHigherThanOrEquals, creationLog, failureLog, successLog, deletionLog, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricJobLogApi.GetHistoricJobLogs: " + e.Message );
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
 **logId** | **string**| Filter by historic job log id. | [optional] 
 **jobId** | **string**| Filter by job id. | [optional] 
 **jobExceptionMessage** | **string**| Filter by job exception message. | [optional] 
 **jobDefinitionId** | **string**| Filter by job definition id. | [optional] 
 **jobDefinitionType** | **string**| Filter by job definition type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/the-job-executor/#job-creation) for more information about job definition types. | [optional] 
 **jobDefinitionConfiguration** | **string**| Filter by job definition configuration. | [optional] 
 **activityIdIn** | **string**| Only include historic job logs which belong to one of the passed activity ids. | [optional] 
 **failedActivityIdIn** | **string**| Only include historic job logs which belong to failures of one of the passed activity ids. | [optional] 
 **executionIdIn** | **string**| Only include historic job logs which belong to one of the passed execution ids. | [optional] 
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **processDefinitionKey** | **string**| Filter by process definition key. | [optional] 
 **deploymentId** | **string**| Filter by deployment id. | [optional] 
 **tenantIdIn** | **string**| Only include historic job log entries which belong to one of the passed and comma- separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic job log entries that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **hostname** | **string**| Filter by hostname. | [optional] 
 **jobPriorityLowerThanOrEquals** | **long?**| Only include logs for which the associated job had a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **jobPriorityHigherThanOrEquals** | **long?**| Only include logs for which the associated job had a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **creationLog** | **bool?**| Only include creation logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **failureLog** | **bool?**| Only include failure logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **successLog** | **bool?**| Only include success logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **deletionLog** | **bool?**| Only include deletion logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;HistoricJobLogDto&gt;**](HistoricJobLogDto.md)

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

<a name="gethistoricjoblogscount"></a>
# **GetHistoricJobLogsCount**
> CountResultDto GetHistoricJobLogsCount (string logId = null, string jobId = null, string jobExceptionMessage = null, string jobDefinitionId = null, string jobDefinitionType = null, string jobDefinitionConfiguration = null, string activityIdIn = null, string failedActivityIdIn = null, string executionIdIn = null, string processInstanceId = null, string processDefinitionId = null, string processDefinitionKey = null, string deploymentId = null, string tenantIdIn = null, bool? withoutTenantId = null, string hostname = null, long? jobPriorityLowerThanOrEquals = null, long? jobPriorityHigherThanOrEquals = null, bool? creationLog = null, bool? failureLog = null, bool? successLog = null, bool? deletionLog = null)

Get Job Log Count

Queries for the number of historic job logs that fulfill the given parameters. Takes the same parameters as the [Get Job Logs](https://docs.camunda.org/manual/7.16/reference/rest/history/job-log/get-job-log-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricJobLogsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricJobLogApi(config);
            var logId = logId_example;  // string | Filter by historic job log id. (optional) 
            var jobId = jobId_example;  // string | Filter by job id. (optional) 
            var jobExceptionMessage = jobExceptionMessage_example;  // string | Filter by job exception message. (optional) 
            var jobDefinitionId = jobDefinitionId_example;  // string | Filter by job definition id. (optional) 
            var jobDefinitionType = jobDefinitionType_example;  // string | Filter by job definition type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/the-job-executor/#job-creation) for more information about job definition types. (optional) 
            var jobDefinitionConfiguration = jobDefinitionConfiguration_example;  // string | Filter by job definition configuration. (optional) 
            var activityIdIn = activityIdIn_example;  // string | Only include historic job logs which belong to one of the passed activity ids. (optional) 
            var failedActivityIdIn = failedActivityIdIn_example;  // string | Only include historic job logs which belong to failures of one of the passed activity ids. (optional) 
            var executionIdIn = executionIdIn_example;  // string | Only include historic job logs which belong to one of the passed execution ids. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by process definition key. (optional) 
            var deploymentId = deploymentId_example;  // string | Filter by deployment id. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include historic job log entries which belong to one of the passed and comma- separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic job log entries that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var hostname = hostname_example;  // string | Filter by hostname. (optional) 
            var jobPriorityLowerThanOrEquals = 789;  // long? | Only include logs for which the associated job had a priority lower than or equal to the given value. Value must be a valid `long` value. (optional) 
            var jobPriorityHigherThanOrEquals = 789;  // long? | Only include logs for which the associated job had a priority higher than or equal to the given value. Value must be a valid `long` value. (optional) 
            var creationLog = true;  // bool? | Only include creation logs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var failureLog = true;  // bool? | Only include failure logs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var successLog = true;  // bool? | Only include success logs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var deletionLog = true;  // bool? | Only include deletion logs. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get Job Log Count
                CountResultDto result = apiInstance.GetHistoricJobLogsCount(logId, jobId, jobExceptionMessage, jobDefinitionId, jobDefinitionType, jobDefinitionConfiguration, activityIdIn, failedActivityIdIn, executionIdIn, processInstanceId, processDefinitionId, processDefinitionKey, deploymentId, tenantIdIn, withoutTenantId, hostname, jobPriorityLowerThanOrEquals, jobPriorityHigherThanOrEquals, creationLog, failureLog, successLog, deletionLog);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricJobLogApi.GetHistoricJobLogsCount: " + e.Message );
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
 **logId** | **string**| Filter by historic job log id. | [optional] 
 **jobId** | **string**| Filter by job id. | [optional] 
 **jobExceptionMessage** | **string**| Filter by job exception message. | [optional] 
 **jobDefinitionId** | **string**| Filter by job definition id. | [optional] 
 **jobDefinitionType** | **string**| Filter by job definition type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/the-job-executor/#job-creation) for more information about job definition types. | [optional] 
 **jobDefinitionConfiguration** | **string**| Filter by job definition configuration. | [optional] 
 **activityIdIn** | **string**| Only include historic job logs which belong to one of the passed activity ids. | [optional] 
 **failedActivityIdIn** | **string**| Only include historic job logs which belong to failures of one of the passed activity ids. | [optional] 
 **executionIdIn** | **string**| Only include historic job logs which belong to one of the passed execution ids. | [optional] 
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **processDefinitionKey** | **string**| Filter by process definition key. | [optional] 
 **deploymentId** | **string**| Filter by deployment id. | [optional] 
 **tenantIdIn** | **string**| Only include historic job log entries which belong to one of the passed and comma- separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic job log entries that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **hostname** | **string**| Filter by hostname. | [optional] 
 **jobPriorityLowerThanOrEquals** | **long?**| Only include logs for which the associated job had a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **jobPriorityHigherThanOrEquals** | **long?**| Only include logs for which the associated job had a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
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

<a name="getstacktracehistoricjoblog"></a>
# **GetStacktraceHistoricJobLog**
> Object GetStacktraceHistoricJobLog (string id)

Get Job Log Exception Stacktrace

Retrieves the corresponding exception stacktrace to the passed historic job log by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetStacktraceHistoricJobLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricJobLogApi(config);
            var id = id_example;  // string | The id of the historic job log to get the exception stacktrace for.

            try
            {
                // Get Job Log Exception Stacktrace
                Object result = apiInstance.GetStacktraceHistoricJobLog(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricJobLogApi.GetStacktraceHistoricJobLog: " + e.Message );
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
 **id** | **string**| The id of the historic job log to get the exception stacktrace for. | 

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
| **404** | Historic job log with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistoricjoblogs"></a>
# **QueryHistoricJobLogs**
> List&lt;HistoricJobLogDto&gt; QueryHistoricJobLogs (int? firstResult = null, int? maxResults = null, HistoricJobLogQueryDto historicJobLogQueryDto = null)

Get Job Logs (POST)

Queries for historic job logs that fulfill the given parameters. This method is slightly more powerful than the [Get Job Logs](https://docs.camunda.org/manual/7.16/reference/rest/history/job-log/get-job-log-query/) method because it allows filtering by historic job logs values of the different types `String`, `Number` or `Boolean`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryHistoricJobLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricJobLogApi(config);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var historicJobLogQueryDto = new HistoricJobLogQueryDto(); // HistoricJobLogQueryDto |  (optional) 

            try
            {
                // Get Job Logs (POST)
                List<HistoricJobLogDto> result = apiInstance.QueryHistoricJobLogs(firstResult, maxResults, historicJobLogQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricJobLogApi.QueryHistoricJobLogs: " + e.Message );
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
 **historicJobLogQueryDto** | [**HistoricJobLogQueryDto**](HistoricJobLogQueryDto.md)|  | [optional] 

### Return type

[**List&lt;HistoricJobLogDto&gt;**](HistoricJobLogDto.md)

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

<a name="queryhistoricjoblogscount"></a>
# **QueryHistoricJobLogsCount**
> CountResultDto QueryHistoricJobLogsCount (HistoricJobLogQueryDto historicJobLogQueryDto = null)

Get Job Log Count (POST)

Queries for the number of historic job logs that fulfill the given parameters. This method takes the same message body as the [Get Job Logs (POST)](https://docs.camunda.org/manual/7.16/reference/rest/history/job-log/post-job-log-query/) method and therefore it is slightly more powerful than the [Get Job Log Count](https://docs.camunda.org/manual/7.16/reference/rest/history/job-log/get-job-log-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryHistoricJobLogsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricJobLogApi(config);
            var historicJobLogQueryDto = new HistoricJobLogQueryDto(); // HistoricJobLogQueryDto |  (optional) 

            try
            {
                // Get Job Log Count (POST)
                CountResultDto result = apiInstance.QueryHistoricJobLogsCount(historicJobLogQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricJobLogApi.QueryHistoricJobLogsCount: " + e.Message );
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
 **historicJobLogQueryDto** | [**HistoricJobLogQueryDto**](HistoricJobLogQueryDto.md)|  | [optional] 

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

