# Camunda.OpenApi.Client.Api.JobDefinitionApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetJobDefinition**](JobDefinitionApi.md#getjobdefinition) | **GET** /job-definition/{id} | Get Job Definition
[**GetJobDefinitions**](JobDefinitionApi.md#getjobdefinitions) | **GET** /job-definition | Get Job Definitions
[**GetJobDefinitionsCount**](JobDefinitionApi.md#getjobdefinitionscount) | **GET** /job-definition/count | Get Job Definition Count
[**QueryJobDefinitions**](JobDefinitionApi.md#queryjobdefinitions) | **POST** /job-definition | Get Job Definitions (POST)
[**QueryJobDefinitionsCount**](JobDefinitionApi.md#queryjobdefinitionscount) | **POST** /job-definition/count | Get Job Definition Count (POST)
[**SetJobPriorityJobDefinition**](JobDefinitionApi.md#setjobpriorityjobdefinition) | **PUT** /job-definition/{id}/jobPriority | Set Job Definition Priority by Id
[**SetJobRetriesJobDefinition**](JobDefinitionApi.md#setjobretriesjobdefinition) | **PUT** /job-definition/{id}/retries | Set Job Retries By Job Definition Id
[**UpdateSuspensionStateJobDefinition**](JobDefinitionApi.md#updatesuspensionstatejobdefinition) | **PUT** /job-definition/{id}/suspended | Activate/Suspend Job Definition By Id
[**UpdateSuspensionStateJobDefinitions**](JobDefinitionApi.md#updatesuspensionstatejobdefinitions) | **PUT** /job-definition/suspended | Activate/Suspend Job Definitions


<a name="getjobdefinition"></a>
# **GetJobDefinition**
> JobDefinitionDto GetJobDefinition (string id)

Get Job Definition

Retrieves a job definition by id, according to the `JobDefinition` interface in the engine.

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
    public class GetJobDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job definition to be retrieved.

            try
            {
                // Get Job Definition
                JobDefinitionDto result = apiInstance.GetJobDefinition(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobDefinitionApi.GetJobDefinition: " + e.Message );
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
 **id** | **string**| The id of the job definition to be retrieved. | 

### Return type

[**JobDefinitionDto**](JobDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Job definition with given id does not exist.  See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobdefinitions"></a>
# **GetJobDefinitions**
> List&lt;JobDefinitionDto&gt; GetJobDefinitions (string jobDefinitionId = null, string activityIdIn = null, string processDefinitionId = null, string processDefinitionKey = null, string jobType = null, string jobConfiguration = null, bool? active = null, bool? suspended = null, bool? withOverridingJobPriority = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeJobDefinitionsWithoutTenantId = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Job Definitions

Queries for job definitions that fulfill given parameters. The size of the result set can be retrieved by using the [Get Job Definition Count](https://docs.camunda.org/manual/7.17/reference/rest/job-definition/get-query-count/) method.

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
    public class GetJobDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobDefinitionApi(httpClient, config, httpClientHandler);
            var jobDefinitionId = jobDefinitionId_example;  // string | Filter by job definition id. (optional) 
            var activityIdIn = activityIdIn_example;  // string | Only include job definitions which belong to one of the passed and comma-separated activity ids. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Only include job definitions which exist for the given process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Only include job definitions which exist for the given process definition key. (optional) 
            var jobType = jobType_example;  // string | Only include job definitions which exist for the given job type. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/the-job-executor/#job-creation) for more information about job types. (optional) 
            var jobConfiguration = jobConfiguration_example;  // string | Only include job definitions which exist for the given job configuration. For example: for timer jobs it is the timer configuration. (optional) 
            var active = true;  // bool? | Only include active job definitions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | Only include suspended job definitions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var withOverridingJobPriority = true;  // bool? | Only include job definitions that have an overriding job priority defined. The only effective value is `true`. If set to `false`, this filter is not applied. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include job definitions which belong to one of the passed and comma-separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include job definitions which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var includeJobDefinitionsWithoutTenantId = true;  // bool? | Include job definitions which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get Job Definitions
                List<JobDefinitionDto> result = apiInstance.GetJobDefinitions(jobDefinitionId, activityIdIn, processDefinitionId, processDefinitionKey, jobType, jobConfiguration, active, suspended, withOverridingJobPriority, tenantIdIn, withoutTenantId, includeJobDefinitionsWithoutTenantId, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobDefinitionApi.GetJobDefinitions: " + e.Message );
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
 **jobDefinitionId** | **string**| Filter by job definition id. | [optional] 
 **activityIdIn** | **string**| Only include job definitions which belong to one of the passed and comma-separated activity ids. | [optional] 
 **processDefinitionId** | **string**| Only include job definitions which exist for the given process definition id. | [optional] 
 **processDefinitionKey** | **string**| Only include job definitions which exist for the given process definition key. | [optional] 
 **jobType** | **string**| Only include job definitions which exist for the given job type. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/the-job-executor/#job-creation) for more information about job types. | [optional] 
 **jobConfiguration** | **string**| Only include job definitions which exist for the given job configuration. For example: for timer jobs it is the timer configuration. | [optional] 
 **active** | **bool?**| Only include active job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **suspended** | **bool?**| Only include suspended job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **withOverridingJobPriority** | **bool?**| Only include job definitions that have an overriding job priority defined. The only effective value is &#x60;true&#x60;. If set to &#x60;false&#x60;, this filter is not applied. | [optional] 
 **tenantIdIn** | **string**| Only include job definitions which belong to one of the passed and comma-separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include job definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeJobDefinitionsWithoutTenantId** | **bool?**| Include job definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;JobDefinitionDto&gt;**](JobDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobdefinitionscount"></a>
# **GetJobDefinitionsCount**
> CountResultDto GetJobDefinitionsCount (string jobDefinitionId = null, string activityIdIn = null, string processDefinitionId = null, string processDefinitionKey = null, string jobType = null, string jobConfiguration = null, bool? active = null, bool? suspended = null, bool? withOverridingJobPriority = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeJobDefinitionsWithoutTenantId = null)

Get Job Definition Count

Queries for the number of job definitions that fulfill given parameters. Takes the same parameters as the [Get Job Definitions](https://docs.camunda.org/manual/7.17/reference/rest/job-definition/get-query/) method.

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
    public class GetJobDefinitionsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobDefinitionApi(httpClient, config, httpClientHandler);
            var jobDefinitionId = jobDefinitionId_example;  // string | Filter by job definition id. (optional) 
            var activityIdIn = activityIdIn_example;  // string | Only include job definitions which belong to one of the passed and comma-separated activity ids. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Only include job definitions which exist for the given process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Only include job definitions which exist for the given process definition key. (optional) 
            var jobType = jobType_example;  // string | Only include job definitions which exist for the given job type. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/the-job-executor/#job-creation) for more information about job types. (optional) 
            var jobConfiguration = jobConfiguration_example;  // string | Only include job definitions which exist for the given job configuration. For example: for timer jobs it is the timer configuration. (optional) 
            var active = true;  // bool? | Only include active job definitions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | Only include suspended job definitions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var withOverridingJobPriority = true;  // bool? | Only include job definitions that have an overriding job priority defined. The only effective value is `true`. If set to `false`, this filter is not applied. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include job definitions which belong to one of the passed and comma-separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include job definitions which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var includeJobDefinitionsWithoutTenantId = true;  // bool? | Include job definitions which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get Job Definition Count
                CountResultDto result = apiInstance.GetJobDefinitionsCount(jobDefinitionId, activityIdIn, processDefinitionId, processDefinitionKey, jobType, jobConfiguration, active, suspended, withOverridingJobPriority, tenantIdIn, withoutTenantId, includeJobDefinitionsWithoutTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobDefinitionApi.GetJobDefinitionsCount: " + e.Message );
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
 **jobDefinitionId** | **string**| Filter by job definition id. | [optional] 
 **activityIdIn** | **string**| Only include job definitions which belong to one of the passed and comma-separated activity ids. | [optional] 
 **processDefinitionId** | **string**| Only include job definitions which exist for the given process definition id. | [optional] 
 **processDefinitionKey** | **string**| Only include job definitions which exist for the given process definition key. | [optional] 
 **jobType** | **string**| Only include job definitions which exist for the given job type. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/the-job-executor/#job-creation) for more information about job types. | [optional] 
 **jobConfiguration** | **string**| Only include job definitions which exist for the given job configuration. For example: for timer jobs it is the timer configuration. | [optional] 
 **active** | **bool?**| Only include active job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **suspended** | **bool?**| Only include suspended job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **withOverridingJobPriority** | **bool?**| Only include job definitions that have an overriding job priority defined. The only effective value is &#x60;true&#x60;. If set to &#x60;false&#x60;, this filter is not applied. | [optional] 
 **tenantIdIn** | **string**| Only include job definitions which belong to one of the passed and comma-separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include job definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeJobDefinitionsWithoutTenantId** | **bool?**| Include job definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryjobdefinitions"></a>
# **QueryJobDefinitions**
> List&lt;JobDefinitionDto&gt; QueryJobDefinitions (int? firstResult = null, int? maxResults = null, JobDefinitionQueryDto jobDefinitionQueryDto = null)

Get Job Definitions (POST)

Queries for job definitions that fulfill given parameters. This method is slightly more powerful than the [Get Job Definitions](https://docs.camunda.org/manual/7.17/reference/rest/job-definition/get-query/) method because it allows filtering by multiple job definitions of types `String`, `Number` or `Boolean`.

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
    public class QueryJobDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobDefinitionApi(httpClient, config, httpClientHandler);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var jobDefinitionQueryDto = new JobDefinitionQueryDto(); // JobDefinitionQueryDto |  (optional) 

            try
            {
                // Get Job Definitions (POST)
                List<JobDefinitionDto> result = apiInstance.QueryJobDefinitions(firstResult, maxResults, jobDefinitionQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobDefinitionApi.QueryJobDefinitions: " + e.Message );
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
 **jobDefinitionQueryDto** | [**JobDefinitionQueryDto**](JobDefinitionQueryDto.md)|  | [optional] 

### Return type

[**List&lt;JobDefinitionDto&gt;**](JobDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryjobdefinitionscount"></a>
# **QueryJobDefinitionsCount**
> CountResultDto QueryJobDefinitionsCount (JobDefinitionQueryDto jobDefinitionQueryDto = null)

Get Job Definition Count (POST)

Queries for the number of job definitions that fulfill given parameters. This method takes the same message body as the [Get Job Definitions (POST)](https://docs.camunda.org/manual/7.17/reference/rest/job-definition/post-query/) method and therefore it is slightly more powerful than the [Get Job Definition Count](https://docs.camunda.org/manual/7.17/reference/rest/job-definition/get-query-count/) method.

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
    public class QueryJobDefinitionsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobDefinitionApi(httpClient, config, httpClientHandler);
            var jobDefinitionQueryDto = new JobDefinitionQueryDto(); // JobDefinitionQueryDto |  (optional) 

            try
            {
                // Get Job Definition Count (POST)
                CountResultDto result = apiInstance.QueryJobDefinitionsCount(jobDefinitionQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobDefinitionApi.QueryJobDefinitionsCount: " + e.Message );
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
 **jobDefinitionQueryDto** | [**JobDefinitionQueryDto**](JobDefinitionQueryDto.md)|  | [optional] 

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
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setjobpriorityjobdefinition"></a>
# **SetJobPriorityJobDefinition**
> void SetJobPriorityJobDefinition (string id, JobDefinitionPriorityDto jobDefinitionPriorityDto = null)

Set Job Definition Priority by Id

Sets an overriding execution priority for jobs with the given definition id. Optionally, the priorities of all the definitions' existing jobs are updated accordingly. The priority can be reset by setting it to `null`, meaning that a new job's priority will not be determined based on its definition's priority any longer. See the [user guide on job prioritization](https://docs.camunda.org/manual/7.17/user-guide/process-engine/the-job-executor/#set-job-definition-priorities-via-managementservice-api) for details.

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
    public class SetJobPriorityJobDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job definition to be updated.
            var jobDefinitionPriorityDto = new JobDefinitionPriorityDto(); // JobDefinitionPriorityDto |  (optional) 

            try
            {
                // Set Job Definition Priority by Id
                apiInstance.SetJobPriorityJobDefinition(id, jobDefinitionPriorityDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobDefinitionApi.SetJobPriorityJobDefinition: " + e.Message );
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
 **id** | **string**| The id of the job definition to be updated. | 
 **jobDefinitionPriorityDto** | [**JobDefinitionPriorityDto**](JobDefinitionPriorityDto.md)|  | [optional] 

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
| **404** | Job definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The retries could not be set successfully. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setjobretriesjobdefinition"></a>
# **SetJobRetriesJobDefinition**
> void SetJobRetriesJobDefinition (string id, RetriesDto retriesDto = null)

Set Job Retries By Job Definition Id

Sets the number of retries of all **failed** jobs associated with the given job definition id.

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
    public class SetJobRetriesJobDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job definition to be updated.
            var retriesDto = new RetriesDto(); // RetriesDto |  (optional) 

            try
            {
                // Set Job Retries By Job Definition Id
                apiInstance.SetJobRetriesJobDefinition(id, retriesDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobDefinitionApi.SetJobRetriesJobDefinition: " + e.Message );
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
 **id** | **string**| The id of the job definition to be updated. | 
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
| **500** | The retries could not be set successfully. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesuspensionstatejobdefinition"></a>
# **UpdateSuspensionStateJobDefinition**
> void UpdateSuspensionStateJobDefinition (string id, JobDefinitionSuspensionStateDto jobDefinitionSuspensionStateDto = null)

Activate/Suspend Job Definition By Id

Activates or suspends a given job definition by id.

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
    public class UpdateSuspensionStateJobDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the job definition to activate or suspend.
            var jobDefinitionSuspensionStateDto = new JobDefinitionSuspensionStateDto(); // JobDefinitionSuspensionStateDto |  (optional) 

            try
            {
                // Activate/Suspend Job Definition By Id
                apiInstance.UpdateSuspensionStateJobDefinition(id, jobDefinitionSuspensionStateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobDefinitionApi.UpdateSuspensionStateJobDefinition: " + e.Message );
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
 **id** | **string**| The id of the job definition to activate or suspend. | 
 **jobDefinitionSuspensionStateDto** | [**JobDefinitionSuspensionStateDto**](JobDefinitionSuspensionStateDto.md)|  | [optional] 

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
| **400** | Returned if some of the request parameters are invalid, for example if the provided &#x60;executionDate&#x60; parameter doesn&#39;t have the expected format. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesuspensionstatejobdefinitions"></a>
# **UpdateSuspensionStateJobDefinitions**
> void UpdateSuspensionStateJobDefinitions (JobDefinitionsSuspensionStateDto jobDefinitionsSuspensionStateDto = null)

Activate/Suspend Job Definitions

Activates or suspends job definitions with the given process definition id or process definition key.

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
    public class UpdateSuspensionStateJobDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new JobDefinitionApi(httpClient, config, httpClientHandler);
            var jobDefinitionsSuspensionStateDto = new JobDefinitionsSuspensionStateDto(); // JobDefinitionsSuspensionStateDto |  (optional) 

            try
            {
                // Activate/Suspend Job Definitions
                apiInstance.UpdateSuspensionStateJobDefinitions(jobDefinitionsSuspensionStateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobDefinitionApi.UpdateSuspensionStateJobDefinitions: " + e.Message );
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
 **jobDefinitionsSuspensionStateDto** | [**JobDefinitionsSuspensionStateDto**](JobDefinitionsSuspensionStateDto.md)|  | [optional] 

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
| **400** | Returned if some of the request parameters are invalid, for example if the provided &#x60;executionDate&#x60; parameter doesn&#39;t have the expected format. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

