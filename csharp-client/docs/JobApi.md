# Camunda.OpenApi.Client.Api.JobApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExecuteJob**](JobApi.md#executejob) | **POST** /job/{id}/execute | Execute Job
[**GetJob**](JobApi.md#getjob) | **GET** /job/{id} | Get Job
[**GetJobs**](JobApi.md#getjobs) | **GET** /job | Get Jobs
[**GetJobsCount**](JobApi.md#getjobscount) | **GET** /job/count | Get Job Count
[**GetStacktrace**](JobApi.md#getstacktrace) | **GET** /job/{id}/stacktrace | Get Exception Stacktrace
[**QueryJobs**](JobApi.md#queryjobs) | **POST** /job | Get Jobs (POST)
[**QueryJobsCount**](JobApi.md#queryjobscount) | **POST** /job/count | Get Job Count (POST)
[**RecalculateDuedate**](JobApi.md#recalculateduedate) | **POST** /job/{id}/duedate/recalculate | Recalculate Job Due Date
[**SetJobDuedate**](JobApi.md#setjobduedate) | **PUT** /job/{id}/duedate | Set Job Due Date
[**SetJobPriority**](JobApi.md#setjobpriority) | **PUT** /job/{id}/priority | Set Job Priority
[**SetJobRetries**](JobApi.md#setjobretries) | **PUT** /job/{id}/retries | Set Job Retries
[**SetJobRetriesAsyncOperation**](JobApi.md#setjobretriesasyncoperation) | **POST** /job/retries | Set Job Retries Async (POST)
[**UpdateJobSuspensionState**](JobApi.md#updatejobsuspensionstate) | **PUT** /job/{id}/suspended | Activate/Suspend Job By Id
[**UpdateSuspensionStateBy**](JobApi.md#updatesuspensionstateby) | **PUT** /job/suspended | Activate/Suspend Jobs


<a name="executejob"></a>
# **ExecuteJob**
> void ExecuteJob (string id)

Execute Job

Executes a job by id. **Note:** The execution of the job happens synchronously in the same thread.

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
    public class ExecuteJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job to be executed.

            try
            {
                // Execute Job
                apiInstance.ExecuteJob(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.ExecuteJob: " + e.Message );
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
 **id** | **string**| The id of the job to be executed. | 

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
| **204** | Request successful. This method returns no content. |  -  |
| **404** | Job with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The job could not be executed successfully. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjob"></a>
# **GetJob**
> JobDto GetJob (string id)

Get Job

Retrieves a job by id, according to the `Job` interface in the engine.

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
    public class GetJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job to be retrieved.

            try
            {
                // Get Job
                JobDto result = apiInstance.GetJob(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.GetJob: " + e.Message );
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
 **id** | **string**| The id of the job to be retrieved. | 

### Return type

[**JobDto**](JobDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Job with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobs"></a>
# **GetJobs**
> List&lt;JobDto&gt; GetJobs (string jobId = null, string jobIds = null, string jobDefinitionId = null, string processInstanceId = null, string processInstanceIds = null, string executionId = null, string processDefinitionId = null, string processDefinitionKey = null, string activityId = null, bool? withRetriesLeft = null, bool? executable = null, bool? timers = null, bool? messages = null, string dueDates = null, string createTimes = null, bool? withException = null, string exceptionMessage = null, string failedActivityId = null, bool? noRetriesLeft = null, bool? active = null, bool? suspended = null, long? priorityLowerThanOrEquals = null, long? priorityHigherThanOrEquals = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeJobsWithoutTenantId = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Jobs

Queries for jobs that fulfill given parameters. The size of the result set can be retrieved by using the [Get Job Count](https://docs.camunda.org/manual/7.17/reference/rest/job/get-query-count/) method.

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
    public class GetJobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var jobId = jobId_example;  // string | Filter by job id. (optional) 
            var jobIds = jobIds_example;  // string | Filter by a comma-separated list of job ids. (optional) 
            var jobDefinitionId = jobDefinitionId_example;  // string | Only select jobs which exist for the given job definition. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Only select jobs which exist for the given process instance. (optional) 
            var processInstanceIds = processInstanceIds_example;  // string | Only select jobs which exist for the given comma-separated list of process instance ids. (optional) 
            var executionId = executionId_example;  // string | Only select jobs which exist for the given execution. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the id of the process definition the jobs run on. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by the key of the process definition the jobs run on. (optional) 
            var activityId = activityId_example;  // string | Only select jobs which exist for an activity with the given id. (optional) 
            var withRetriesLeft = true;  // bool? | Only select jobs which have retries left. Value may only be `true`, as `false` is the default behavior. (optional) 
            var executable = true;  // bool? | Only select jobs which are executable, i.e., retries > 0 and due date is `null` or due date is in the past. Value may only be `true`, as `false` is the default behavior. (optional) 
            var timers = true;  // bool? | Only select jobs that are timers. Cannot be used together with `messages`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var messages = true;  // bool? | Only select jobs that are messages. Cannot be used together with `timers`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var dueDates = dueDates_example;  // string | Only select jobs where the due date is lower or higher than the given date. Due date expressions are comma-separated and are structured as follows:  A valid condition value has the form `operator_value`. `operator` is the comparison operator to be used and `value` the date value as string.  Valid operator values are: `gt` - greater than; `lt` - lower than. `value` may not contain underscore or comma characters. (optional) 
            var createTimes = createTimes_example;  // string | Only select jobs created before or after the given date.  Create time expressions are comma-separated and are structured as follows:  A valid condition value has the form `operator_value`. `operator` is the comparison operator to be used and `value` the date value as string.  Valid operator values are: `gt` - greater than; `lt` - lower than. `value` may not contain underscore or comma characters. (optional) 
            var withException = true;  // bool? | Only select jobs that failed due to an exception. Value may only be `true`, as `false` is the default behavior. (optional) 
            var exceptionMessage = exceptionMessage_example;  // string | Only select jobs that failed due to an exception with the given message. (optional) 
            var failedActivityId = failedActivityId_example;  // string | Only select jobs that failed due to an exception at an activity with the given id. (optional) 
            var noRetriesLeft = true;  // bool? | Only select jobs which have no retries left. Value may only be `true`, as `false` is the default behavior. (optional) 
            var active = true;  // bool? | Only include active jobs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | Only include suspended jobs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var priorityLowerThanOrEquals = 789;  // long? | Only include jobs with a priority lower than or equal to the given value. Value must be a valid `long` value. (optional) 
            var priorityHigherThanOrEquals = 789;  // long? | Only include jobs with a priority higher than or equal to the given value. Value must be a valid `long` value. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include jobs which belong to one of the passed comma-separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include jobs which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var includeJobsWithoutTenantId = true;  // bool? | Include jobs which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get Jobs
                List<JobDto> result = apiInstance.GetJobs(jobId, jobIds, jobDefinitionId, processInstanceId, processInstanceIds, executionId, processDefinitionId, processDefinitionKey, activityId, withRetriesLeft, executable, timers, messages, dueDates, createTimes, withException, exceptionMessage, failedActivityId, noRetriesLeft, active, suspended, priorityLowerThanOrEquals, priorityHigherThanOrEquals, tenantIdIn, withoutTenantId, includeJobsWithoutTenantId, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.GetJobs: " + e.Message );
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
 **jobId** | **string**| Filter by job id. | [optional] 
 **jobIds** | **string**| Filter by a comma-separated list of job ids. | [optional] 
 **jobDefinitionId** | **string**| Only select jobs which exist for the given job definition. | [optional] 
 **processInstanceId** | **string**| Only select jobs which exist for the given process instance. | [optional] 
 **processInstanceIds** | **string**| Only select jobs which exist for the given comma-separated list of process instance ids. | [optional] 
 **executionId** | **string**| Only select jobs which exist for the given execution. | [optional] 
 **processDefinitionId** | **string**| Filter by the id of the process definition the jobs run on. | [optional] 
 **processDefinitionKey** | **string**| Filter by the key of the process definition the jobs run on. | [optional] 
 **activityId** | **string**| Only select jobs which exist for an activity with the given id. | [optional] 
 **withRetriesLeft** | **bool?**| Only select jobs which have retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **executable** | **bool?**| Only select jobs which are executable, i.e., retries &gt; 0 and due date is &#x60;null&#x60; or due date is in the past. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **timers** | **bool?**| Only select jobs that are timers. Cannot be used together with &#x60;messages&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **messages** | **bool?**| Only select jobs that are messages. Cannot be used together with &#x60;timers&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **dueDates** | **string**| Only select jobs where the due date is lower or higher than the given date. Due date expressions are comma-separated and are structured as follows:  A valid condition value has the form &#x60;operator_value&#x60;. &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the date value as string.  Valid operator values are: &#x60;gt&#x60; - greater than; &#x60;lt&#x60; - lower than. &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **createTimes** | **string**| Only select jobs created before or after the given date.  Create time expressions are comma-separated and are structured as follows:  A valid condition value has the form &#x60;operator_value&#x60;. &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the date value as string.  Valid operator values are: &#x60;gt&#x60; - greater than; &#x60;lt&#x60; - lower than. &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **withException** | **bool?**| Only select jobs that failed due to an exception. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **exceptionMessage** | **string**| Only select jobs that failed due to an exception with the given message. | [optional] 
 **failedActivityId** | **string**| Only select jobs that failed due to an exception at an activity with the given id. | [optional] 
 **noRetriesLeft** | **bool?**| Only select jobs which have no retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **active** | **bool?**| Only include active jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **suspended** | **bool?**| Only include suspended jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **priorityLowerThanOrEquals** | **long?**| Only include jobs with a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **priorityHigherThanOrEquals** | **long?**| Only include jobs with a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **tenantIdIn** | **string**| Only include jobs which belong to one of the passed comma-separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include jobs which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeJobsWithoutTenantId** | **bool?**| Include jobs which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;JobDto&gt;**](JobDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;, or if an invalid operator for due date comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobscount"></a>
# **GetJobsCount**
> CountResultDto GetJobsCount (string jobId = null, string jobIds = null, string jobDefinitionId = null, string processInstanceId = null, string processInstanceIds = null, string executionId = null, string processDefinitionId = null, string processDefinitionKey = null, string activityId = null, bool? withRetriesLeft = null, bool? executable = null, bool? timers = null, bool? messages = null, string dueDates = null, string createTimes = null, bool? withException = null, string exceptionMessage = null, string failedActivityId = null, bool? noRetriesLeft = null, bool? active = null, bool? suspended = null, long? priorityLowerThanOrEquals = null, long? priorityHigherThanOrEquals = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeJobsWithoutTenantId = null)

Get Job Count

Queries for the number of jobs that fulfill given parameters. Takes the same parameters as the [Get Jobs](https://docs.camunda.org/manual/7.17/reference/rest/job/get-query/) method.

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
    public class GetJobsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var jobId = jobId_example;  // string | Filter by job id. (optional) 
            var jobIds = jobIds_example;  // string | Filter by a comma-separated list of job ids. (optional) 
            var jobDefinitionId = jobDefinitionId_example;  // string | Only select jobs which exist for the given job definition. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Only select jobs which exist for the given process instance. (optional) 
            var processInstanceIds = processInstanceIds_example;  // string | Only select jobs which exist for the given comma-separated list of process instance ids. (optional) 
            var executionId = executionId_example;  // string | Only select jobs which exist for the given execution. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the id of the process definition the jobs run on. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by the key of the process definition the jobs run on. (optional) 
            var activityId = activityId_example;  // string | Only select jobs which exist for an activity with the given id. (optional) 
            var withRetriesLeft = true;  // bool? | Only select jobs which have retries left. Value may only be `true`, as `false` is the default behavior. (optional) 
            var executable = true;  // bool? | Only select jobs which are executable, i.e., retries > 0 and due date is `null` or due date is in the past. Value may only be `true`, as `false` is the default behavior. (optional) 
            var timers = true;  // bool? | Only select jobs that are timers. Cannot be used together with `messages`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var messages = true;  // bool? | Only select jobs that are messages. Cannot be used together with `timers`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var dueDates = dueDates_example;  // string | Only select jobs where the due date is lower or higher than the given date. Due date expressions are comma-separated and are structured as follows:  A valid condition value has the form `operator_value`. `operator` is the comparison operator to be used and `value` the date value as string.  Valid operator values are: `gt` - greater than; `lt` - lower than. `value` may not contain underscore or comma characters. (optional) 
            var createTimes = createTimes_example;  // string | Only select jobs created before or after the given date.  Create time expressions are comma-separated and are structured as follows:  A valid condition value has the form `operator_value`. `operator` is the comparison operator to be used and `value` the date value as string.  Valid operator values are: `gt` - greater than; `lt` - lower than. `value` may not contain underscore or comma characters. (optional) 
            var withException = true;  // bool? | Only select jobs that failed due to an exception. Value may only be `true`, as `false` is the default behavior. (optional) 
            var exceptionMessage = exceptionMessage_example;  // string | Only select jobs that failed due to an exception with the given message. (optional) 
            var failedActivityId = failedActivityId_example;  // string | Only select jobs that failed due to an exception at an activity with the given id. (optional) 
            var noRetriesLeft = true;  // bool? | Only select jobs which have no retries left. Value may only be `true`, as `false` is the default behavior. (optional) 
            var active = true;  // bool? | Only include active jobs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | Only include suspended jobs. Value may only be `true`, as `false` is the default behavior. (optional) 
            var priorityLowerThanOrEquals = 789;  // long? | Only include jobs with a priority lower than or equal to the given value. Value must be a valid `long` value. (optional) 
            var priorityHigherThanOrEquals = 789;  // long? | Only include jobs with a priority higher than or equal to the given value. Value must be a valid `long` value. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include jobs which belong to one of the passed comma-separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include jobs which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var includeJobsWithoutTenantId = true;  // bool? | Include jobs which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get Job Count
                CountResultDto result = apiInstance.GetJobsCount(jobId, jobIds, jobDefinitionId, processInstanceId, processInstanceIds, executionId, processDefinitionId, processDefinitionKey, activityId, withRetriesLeft, executable, timers, messages, dueDates, createTimes, withException, exceptionMessage, failedActivityId, noRetriesLeft, active, suspended, priorityLowerThanOrEquals, priorityHigherThanOrEquals, tenantIdIn, withoutTenantId, includeJobsWithoutTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.GetJobsCount: " + e.Message );
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
 **jobId** | **string**| Filter by job id. | [optional] 
 **jobIds** | **string**| Filter by a comma-separated list of job ids. | [optional] 
 **jobDefinitionId** | **string**| Only select jobs which exist for the given job definition. | [optional] 
 **processInstanceId** | **string**| Only select jobs which exist for the given process instance. | [optional] 
 **processInstanceIds** | **string**| Only select jobs which exist for the given comma-separated list of process instance ids. | [optional] 
 **executionId** | **string**| Only select jobs which exist for the given execution. | [optional] 
 **processDefinitionId** | **string**| Filter by the id of the process definition the jobs run on. | [optional] 
 **processDefinitionKey** | **string**| Filter by the key of the process definition the jobs run on. | [optional] 
 **activityId** | **string**| Only select jobs which exist for an activity with the given id. | [optional] 
 **withRetriesLeft** | **bool?**| Only select jobs which have retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **executable** | **bool?**| Only select jobs which are executable, i.e., retries &gt; 0 and due date is &#x60;null&#x60; or due date is in the past. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **timers** | **bool?**| Only select jobs that are timers. Cannot be used together with &#x60;messages&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **messages** | **bool?**| Only select jobs that are messages. Cannot be used together with &#x60;timers&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **dueDates** | **string**| Only select jobs where the due date is lower or higher than the given date. Due date expressions are comma-separated and are structured as follows:  A valid condition value has the form &#x60;operator_value&#x60;. &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the date value as string.  Valid operator values are: &#x60;gt&#x60; - greater than; &#x60;lt&#x60; - lower than. &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **createTimes** | **string**| Only select jobs created before or after the given date.  Create time expressions are comma-separated and are structured as follows:  A valid condition value has the form &#x60;operator_value&#x60;. &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the date value as string.  Valid operator values are: &#x60;gt&#x60; - greater than; &#x60;lt&#x60; - lower than. &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **withException** | **bool?**| Only select jobs that failed due to an exception. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **exceptionMessage** | **string**| Only select jobs that failed due to an exception with the given message. | [optional] 
 **failedActivityId** | **string**| Only select jobs that failed due to an exception at an activity with the given id. | [optional] 
 **noRetriesLeft** | **bool?**| Only select jobs which have no retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **active** | **bool?**| Only include active jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **suspended** | **bool?**| Only include suspended jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **priorityLowerThanOrEquals** | **long?**| Only include jobs with a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **priorityHigherThanOrEquals** | **long?**| Only include jobs with a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
 **tenantIdIn** | **string**| Only include jobs which belong to one of the passed comma-separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include jobs which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeJobsWithoutTenantId** | **bool?**| Include jobs which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid, for example, if an invalid operator for due date comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstacktrace"></a>
# **GetStacktrace**
> Object GetStacktrace (string id)

Get Exception Stacktrace

Retrieves the exception stacktrace corresponding to the passed job id.

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
    public class GetStacktraceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job to get the exception stacktrace for.

            try
            {
                // Get Exception Stacktrace
                Object result = apiInstance.GetStacktrace(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.GetStacktrace: " + e.Message );
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
 **id** | **string**| The id of the job to get the exception stacktrace for. | 

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
| **404** | Job with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryjobs"></a>
# **QueryJobs**
> List&lt;JobDto&gt; QueryJobs (int? firstResult = null, int? maxResults = null, JobQueryDto jobQueryDto = null)

Get Jobs (POST)

Queries for jobs that fulfill given parameters. This method is slightly more powerful than the [Get Jobs](https://docs.camunda.org/manual/7.17/reference/rest/job/get-query/) method because it allows filtering by multiple jobs of types `String`, `Number` or `Boolean`.

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
    public class QueryJobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var jobQueryDto = new JobQueryDto(); // JobQueryDto |  (optional) 

            try
            {
                // Get Jobs (POST)
                List<JobDto> result = apiInstance.QueryJobs(firstResult, maxResults, jobQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.QueryJobs: " + e.Message );
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
 **jobQueryDto** | [**JobQueryDto**](JobQueryDto.md)|  | [optional] 

### Return type

[**List&lt;JobDto&gt;**](JobDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;, or if an invalid operator for due date comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryjobscount"></a>
# **QueryJobsCount**
> CountResultDto QueryJobsCount (JobQueryDto jobQueryDto = null)

Get Job Count (POST)

Queries for jobs that fulfill given parameters. This method takes the same message body as the [Get Jobs POST](https://docs.camunda.org/manual/7.17/reference/rest/job/post- query/) method and therefore it is slightly more powerful than the [Get Job Count](https://docs.camunda.org/manual/7.17/reference/rest/job/get-query-count/) method.

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
    public class QueryJobsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var jobQueryDto = new JobQueryDto(); // JobQueryDto |  (optional) 

            try
            {
                // Get Job Count (POST)
                CountResultDto result = apiInstance.QueryJobsCount(jobQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.QueryJobsCount: " + e.Message );
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
 **jobQueryDto** | [**JobQueryDto**](JobQueryDto.md)|  | [optional] 

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
| **400** | Returned if some of the query parameters are invalid, for example, if an invalid operator for due date comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recalculateduedate"></a>
# **RecalculateDuedate**
> void RecalculateDuedate (string id, bool? creationDateBased = null)

Recalculate Job Due Date

Recalculates the due date of a job by id.

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
    public class RecalculateDuedateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job to be updated.
            var creationDateBased = true;  // bool? | Recalculate the due date based on the creation date of the job or the current date. Value may only be `false`, as `true` is the default behavior.  (optional) 

            try
            {
                // Recalculate Job Due Date
                apiInstance.RecalculateDuedate(id, creationDateBased);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.RecalculateDuedate: " + e.Message );
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
 **id** | **string**| The id of the job to be updated. | 
 **creationDateBased** | **bool?**| Recalculate the due date based on the creation date of the job or the current date. Value may only be &#x60;false&#x60;, as &#x60;true&#x60; is the default behavior.  | [optional] 

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
| **204** | Request successful. This method returns no content. |  -  |
| **404** | Job with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The due date could not be recalculated successfully. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setjobduedate"></a>
# **SetJobDuedate**
> void SetJobDuedate (string id, JobDuedateDto jobDuedateDto = null)

Set Job Due Date

Updates the due date of a job by id.

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
    public class SetJobDuedateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job to be updated.
            var jobDuedateDto = new JobDuedateDto(); // JobDuedateDto |  (optional) 

            try
            {
                // Set Job Due Date
                apiInstance.SetJobDuedate(id, jobDuedateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.SetJobDuedate: " + e.Message );
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
 **id** | **string**| The id of the job to be updated. | 
 **jobDuedateDto** | [**JobDuedateDto**](JobDuedateDto.md)|  | [optional] 

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
| **204** | Request successful. This method returns no content. |  -  |
| **404** | Job with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The due date could not be set successfully. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setjobpriority"></a>
# **SetJobPriority**
> void SetJobPriority (string id, PriorityDto priorityDto = null)

Set Job Priority

Sets the execution priority of a job by id.

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
    public class SetJobPriorityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job to be updated.
            var priorityDto = new PriorityDto(); // PriorityDto |  (optional) 

            try
            {
                // Set Job Priority
                apiInstance.SetJobPriority(id, priorityDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.SetJobPriority: " + e.Message );
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
 **id** | **string**| The id of the job to be updated. | 
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
| **204** | Request successful. This method returns no content. |  -  |
| **404** | Job with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The priority could not be set successfully. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setjobretries"></a>
# **SetJobRetries**
> void SetJobRetries (string id, RetriesDto retriesDto = null)

Set Job Retries

Sets the retries of the job to the given number of retries by id.

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
    public class SetJobRetriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job to be updated.
            var retriesDto = new RetriesDto(); // RetriesDto |  (optional) 

            try
            {
                // Set Job Retries
                apiInstance.SetJobRetries(id, retriesDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.SetJobRetries: " + e.Message );
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
 **id** | **string**| The id of the job to be updated. | 
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
| **204** | Request successful. This method returns no content. |  -  |
| **404** | Job with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The retries could not be set successfully. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setjobretriesasyncoperation"></a>
# **SetJobRetriesAsyncOperation**
> BatchDto SetJobRetriesAsyncOperation (SetJobRetriesDto setJobRetriesDto = null)

Set Job Retries Async (POST)

Create a batch to set retries of jobs asynchronously.

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
    public class SetJobRetriesAsyncOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var setJobRetriesDto = new SetJobRetriesDto(); // SetJobRetriesDto |  (optional) 

            try
            {
                // Set Job Retries Async (POST)
                BatchDto result = apiInstance.SetJobRetriesAsyncOperation(setJobRetriesDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.SetJobRetriesAsyncOperation: " + e.Message );
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
 **setJobRetriesDto** | [**SetJobRetriesDto**](SetJobRetriesDto.md)|  | [optional] 

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
| **400** | Returned if some of the query parameters are invalid, for example if neither processInstanceIds nor processInstanceQuery is present. Or if the retry count is not specified. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejobsuspensionstate"></a>
# **UpdateJobSuspensionState**
> void UpdateJobSuspensionState (string id, SuspensionStateDto suspensionStateDto = null)

Activate/Suspend Job By Id

Activates or suspends a given job by id.

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
    public class UpdateJobSuspensionStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job to activate or suspend.
            var suspensionStateDto = new SuspensionStateDto(); // SuspensionStateDto |  (optional) 

            try
            {
                // Activate/Suspend Job By Id
                apiInstance.UpdateJobSuspensionState(id, suspensionStateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.UpdateJobSuspensionState: " + e.Message );
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
 **id** | **string**| The id of the job to activate or suspend. | 
 **suspensionStateDto** | [**SuspensionStateDto**](SuspensionStateDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. This method returns no content. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesuspensionstateby"></a>
# **UpdateSuspensionStateBy**
> void UpdateSuspensionStateBy (JobSuspensionStateDto jobSuspensionStateDto = null)

Activate/Suspend Jobs

Activates or suspends jobs matching the given criterion. This can only be on of: * `jobDefinitionId` * `processDefinitionId` * `processInstanceId` * `processDefinitionKey`

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
    public class UpdateSuspensionStateByExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobApi(httpClient, config, httpClientHandler);
            var jobSuspensionStateDto = new JobSuspensionStateDto(); // JobSuspensionStateDto |  (optional) 

            try
            {
                // Activate/Suspend Jobs
                apiInstance.UpdateSuspensionStateBy(jobSuspensionStateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.UpdateSuspensionStateBy: " + e.Message );
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
 **jobSuspensionStateDto** | [**JobSuspensionStateDto**](JobSuspensionStateDto.md)|  | [optional] 

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
| **204** | Request successful. This method returns no content. |  -  |
| **400** | Returned if the request parameters are invalid, for example, if &#x60;jobDefinitionId&#x60; and &#x60;processDefinitionId&#x60; are both specified. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

