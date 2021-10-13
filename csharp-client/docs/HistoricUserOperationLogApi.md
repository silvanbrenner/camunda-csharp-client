# Camunda.OpenApi.Client.Api.HistoricUserOperationLogApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClearAnnotationUserOperationLog**](HistoricUserOperationLogApi.md#clearannotationuseroperationlog) | **PUT** /history/user-operation/{operationId}/clear-annotation | Clear Annotation of an User Operation Log (Historic)
[**QueryUserOperationCount**](HistoricUserOperationLogApi.md#queryuseroperationcount) | **GET** /history/user-operation/count | Get User Operation Log Count
[**QueryUserOperationEntries**](HistoricUserOperationLogApi.md#queryuseroperationentries) | **GET** /history/user-operation | Get User Operation Log (Historic)
[**SetAnnotationUserOperationLog**](HistoricUserOperationLogApi.md#setannotationuseroperationlog) | **PUT** /history/user-operation/{operationId}/set-annotation | Set Annotation to an User Operation Log (Historic)


<a name="clearannotationuseroperationlog"></a>
# **ClearAnnotationUserOperationLog**
> void ClearAnnotationUserOperationLog (string operationId)

Clear Annotation of an User Operation Log (Historic)

Clear the annotation which was previously set for auditing reasons.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ClearAnnotationUserOperationLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricUserOperationLogApi(config);
            var operationId = operationId_example;  // string | The operation id of the operation log to be updated.

            try
            {
                // Clear Annotation of an User Operation Log (Historic)
                apiInstance.ClearAnnotationUserOperationLog(operationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricUserOperationLogApi.ClearAnnotationUserOperationLog: " + e.Message );
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
 **operationId** | **string**| The operation id of the operation log to be updated. | 

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
| **400** | Returned if some of the request parameters are invalid, for example if the &#x60;operationId&#x60; path parameter value does not exists. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryuseroperationcount"></a>
# **QueryUserOperationCount**
> CountResultDto QueryUserOperationCount (string deploymentId = null, string processDefinitionId = null, string processDefinitionKey = null, string processInstanceId = null, string executionId = null, string caseDefinitionId = null, string caseInstanceId = null, string caseExecutionId = null, string taskId = null, string externalTaskId = null, string batchId = null, string jobId = null, string jobDefinitionId = null, string userId = null, string operationId = null, string operationType = null, string entityType = null, string entityTypeIn = null, string category = null, string categoryIn = null, string property = null, DateTime? afterTimestamp = null, DateTime? beforeTimestamp = null)

Get User Operation Log Count

Queries for the number of user operation log entries that fulfill the given parameters. Takes the same parameters as the [Get User Operation Log (Historic)](https://docs.camunda.org/manual/7.16/reference/rest/history/user-operation-log/get-user-operation-log-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryUserOperationCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricUserOperationLogApi(config);
            var deploymentId = deploymentId_example;  // string | Filter by deployment id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by process definition key. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var executionId = executionId_example;  // string | Filter by execution id. (optional) 
            var caseDefinitionId = caseDefinitionId_example;  // string | Filter by case definition id. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by case instance id. (optional) 
            var caseExecutionId = caseExecutionId_example;  // string | Filter by case execution id. (optional) 
            var taskId = taskId_example;  // string | Only include operations on this task. (optional) 
            var externalTaskId = externalTaskId_example;  // string | Only include operations on this external task. (optional) 
            var batchId = batchId_example;  // string | Only include operations on this batch. (optional) 
            var jobId = jobId_example;  // string | Filter by job id. (optional) 
            var jobDefinitionId = jobDefinitionId_example;  // string | Filter by job definition id. (optional) 
            var userId = userId_example;  // string | Only include operations of this user. (optional) 
            var operationId = operationId_example;  // string | Filter by the id of the operation. This allows fetching of multiple entries which are part of a composite operation. (optional) 
            var operationType = operationType_example;  // string | Filter by the type of the operation like `Claim` or `Delegate`. See the [Javadoc](https://docs.camunda.org/manual/7.16/reference/javadoc/?org/camunda/bpm/engine/history/UserOperationLogEntry.html) for a list of available operation types. (optional) 
            var entityType = entityType_example;  // string | Filter by the type of the entity that was affected by this operation, possible values are `Task`, `Attachment` or `IdentityLink`. (optional) 
            var entityTypeIn = entityTypeIn_example;  // string | Filter by a comma-separated list of types of the entities that was affected by this operation, possible values are `Task`, `Attachment` or `IdentityLink`. (optional) 
            var category = category_example;  // string | Filter by the category that this operation is associated with, possible values are `TaskWorker`, `Admin` or `Operator`. (optional) 
            var categoryIn = categoryIn_example;  // string | Filter by a comma-separated list of categories that this operation is associated with, possible values are `TaskWorker`, `Admin` or `Operator`. (optional) 
            var property = property_example;  // string | Only include operations that changed this property, e.g., `owner` or `assignee`. (optional) 
            var afterTimestamp = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to entries that were created after the given timestamp. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the timestamp must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., 2013-01-23T14:42:45.000+0200. (optional) 
            var beforeTimestamp = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to entries that were created before the given timestamp. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the timestamp must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., 2013-01-23T14:42:45.000+0200. (optional) 

            try
            {
                // Get User Operation Log Count
                CountResultDto result = apiInstance.QueryUserOperationCount(deploymentId, processDefinitionId, processDefinitionKey, processInstanceId, executionId, caseDefinitionId, caseInstanceId, caseExecutionId, taskId, externalTaskId, batchId, jobId, jobDefinitionId, userId, operationId, operationType, entityType, entityTypeIn, category, categoryIn, property, afterTimestamp, beforeTimestamp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricUserOperationLogApi.QueryUserOperationCount: " + e.Message );
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
 **deploymentId** | **string**| Filter by deployment id. | [optional] 
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **processDefinitionKey** | **string**| Filter by process definition key. | [optional] 
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **executionId** | **string**| Filter by execution id. | [optional] 
 **caseDefinitionId** | **string**| Filter by case definition id. | [optional] 
 **caseInstanceId** | **string**| Filter by case instance id. | [optional] 
 **caseExecutionId** | **string**| Filter by case execution id. | [optional] 
 **taskId** | **string**| Only include operations on this task. | [optional] 
 **externalTaskId** | **string**| Only include operations on this external task. | [optional] 
 **batchId** | **string**| Only include operations on this batch. | [optional] 
 **jobId** | **string**| Filter by job id. | [optional] 
 **jobDefinitionId** | **string**| Filter by job definition id. | [optional] 
 **userId** | **string**| Only include operations of this user. | [optional] 
 **operationId** | **string**| Filter by the id of the operation. This allows fetching of multiple entries which are part of a composite operation. | [optional] 
 **operationType** | **string**| Filter by the type of the operation like &#x60;Claim&#x60; or &#x60;Delegate&#x60;. See the [Javadoc](https://docs.camunda.org/manual/7.16/reference/javadoc/?org/camunda/bpm/engine/history/UserOperationLogEntry.html) for a list of available operation types. | [optional] 
 **entityType** | **string**| Filter by the type of the entity that was affected by this operation, possible values are &#x60;Task&#x60;, &#x60;Attachment&#x60; or &#x60;IdentityLink&#x60;. | [optional] 
 **entityTypeIn** | **string**| Filter by a comma-separated list of types of the entities that was affected by this operation, possible values are &#x60;Task&#x60;, &#x60;Attachment&#x60; or &#x60;IdentityLink&#x60;. | [optional] 
 **category** | **string**| Filter by the category that this operation is associated with, possible values are &#x60;TaskWorker&#x60;, &#x60;Admin&#x60; or &#x60;Operator&#x60;. | [optional] 
 **categoryIn** | **string**| Filter by a comma-separated list of categories that this operation is associated with, possible values are &#x60;TaskWorker&#x60;, &#x60;Admin&#x60; or &#x60;Operator&#x60;. | [optional] 
 **property** | **string**| Only include operations that changed this property, e.g., &#x60;owner&#x60; or &#x60;assignee&#x60;. | [optional] 
 **afterTimestamp** | **DateTime?**| Restrict to entries that were created after the given timestamp. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the timestamp must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., 2013-01-23T14:42:45.000+0200. | [optional] 
 **beforeTimestamp** | **DateTime?**| Restrict to entries that were created before the given timestamp. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the timestamp must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., 2013-01-23T14:42:45.000+0200. | [optional] 

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

<a name="queryuseroperationentries"></a>
# **QueryUserOperationEntries**
> List&lt;UserOperationLogEntryDto&gt; QueryUserOperationEntries (string deploymentId = null, string processDefinitionId = null, string processDefinitionKey = null, string processInstanceId = null, string executionId = null, string caseDefinitionId = null, string caseInstanceId = null, string caseExecutionId = null, string taskId = null, string externalTaskId = null, string batchId = null, string jobId = null, string jobDefinitionId = null, string userId = null, string operationId = null, string operationType = null, string entityType = null, string entityTypeIn = null, string category = null, string categoryIn = null, string property = null, DateTime? afterTimestamp = null, DateTime? beforeTimestamp = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get User Operation Log (Historic)

Queries for user operation log entries that fulfill the given parameters. The size of the result set can be retrieved by using the [Get User Operation Log Count](https://docs.camunda.org/manual/7.16/reference/rest/history/user-operation-log/get-user-operation-log-query-count/) method.  Note that the properties of operation log entries are interpreted as restrictions on the entities they apply to. That means, if a single process instance is updated, the field `processInstanceId` is populated. If a single operation updates all process instances of the same process definition, the field `processInstanceId` is `null` (a `null` restriction is viewed as a wildcard, i.e., matches a process instance with any id) and the field `processDefinitionId` is populated. This way, which entities were changed by a user operation can easily be reconstructed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryUserOperationEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricUserOperationLogApi(config);
            var deploymentId = deploymentId_example;  // string | Filter by deployment id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by process definition key. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var executionId = executionId_example;  // string | Filter by execution id. (optional) 
            var caseDefinitionId = caseDefinitionId_example;  // string | Filter by case definition id. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by case instance id. (optional) 
            var caseExecutionId = caseExecutionId_example;  // string | Filter by case execution id. (optional) 
            var taskId = taskId_example;  // string | Only include operations on this task. (optional) 
            var externalTaskId = externalTaskId_example;  // string | Only include operations on this external task. (optional) 
            var batchId = batchId_example;  // string | Only include operations on this batch. (optional) 
            var jobId = jobId_example;  // string | Filter by job id. (optional) 
            var jobDefinitionId = jobDefinitionId_example;  // string | Filter by job definition id. (optional) 
            var userId = userId_example;  // string | Only include operations of this user. (optional) 
            var operationId = operationId_example;  // string | Filter by the id of the operation. This allows fetching of multiple entries which are part of a composite operation. (optional) 
            var operationType = operationType_example;  // string | Filter by the type of the operation like `Claim` or `Delegate`. See the [Javadoc](https://docs.camunda.org/manual/7.16/reference/javadoc/?org/camunda/bpm/engine/history/UserOperationLogEntry.html) for a list of available operation types. (optional) 
            var entityType = entityType_example;  // string | Filter by the type of the entity that was affected by this operation, possible values are `Task`, `Attachment` or `IdentityLink`. (optional) 
            var entityTypeIn = entityTypeIn_example;  // string | Filter by a comma-separated list of types of the entities that was affected by this operation, possible values are `Task`, `Attachment` or `IdentityLink`. (optional) 
            var category = category_example;  // string | Filter by the category that this operation is associated with, possible values are `TaskWorker`, `Admin` or `Operator`. (optional) 
            var categoryIn = categoryIn_example;  // string | Filter by a comma-separated list of categories that this operation is associated with, possible values are `TaskWorker`, `Admin` or `Operator`. (optional) 
            var property = property_example;  // string | Only include operations that changed this property, e.g., `owner` or `assignee`. (optional) 
            var afterTimestamp = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to entries that were created after the given timestamp. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the timestamp must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., 2013-01-23T14:42:45.000+0200. (optional) 
            var beforeTimestamp = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to entries that were created before the given timestamp. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the timestamp must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., 2013-01-23T14:42:45.000+0200. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get User Operation Log (Historic)
                List<UserOperationLogEntryDto> result = apiInstance.QueryUserOperationEntries(deploymentId, processDefinitionId, processDefinitionKey, processInstanceId, executionId, caseDefinitionId, caseInstanceId, caseExecutionId, taskId, externalTaskId, batchId, jobId, jobDefinitionId, userId, operationId, operationType, entityType, entityTypeIn, category, categoryIn, property, afterTimestamp, beforeTimestamp, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricUserOperationLogApi.QueryUserOperationEntries: " + e.Message );
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
 **deploymentId** | **string**| Filter by deployment id. | [optional] 
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **processDefinitionKey** | **string**| Filter by process definition key. | [optional] 
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **executionId** | **string**| Filter by execution id. | [optional] 
 **caseDefinitionId** | **string**| Filter by case definition id. | [optional] 
 **caseInstanceId** | **string**| Filter by case instance id. | [optional] 
 **caseExecutionId** | **string**| Filter by case execution id. | [optional] 
 **taskId** | **string**| Only include operations on this task. | [optional] 
 **externalTaskId** | **string**| Only include operations on this external task. | [optional] 
 **batchId** | **string**| Only include operations on this batch. | [optional] 
 **jobId** | **string**| Filter by job id. | [optional] 
 **jobDefinitionId** | **string**| Filter by job definition id. | [optional] 
 **userId** | **string**| Only include operations of this user. | [optional] 
 **operationId** | **string**| Filter by the id of the operation. This allows fetching of multiple entries which are part of a composite operation. | [optional] 
 **operationType** | **string**| Filter by the type of the operation like &#x60;Claim&#x60; or &#x60;Delegate&#x60;. See the [Javadoc](https://docs.camunda.org/manual/7.16/reference/javadoc/?org/camunda/bpm/engine/history/UserOperationLogEntry.html) for a list of available operation types. | [optional] 
 **entityType** | **string**| Filter by the type of the entity that was affected by this operation, possible values are &#x60;Task&#x60;, &#x60;Attachment&#x60; or &#x60;IdentityLink&#x60;. | [optional] 
 **entityTypeIn** | **string**| Filter by a comma-separated list of types of the entities that was affected by this operation, possible values are &#x60;Task&#x60;, &#x60;Attachment&#x60; or &#x60;IdentityLink&#x60;. | [optional] 
 **category** | **string**| Filter by the category that this operation is associated with, possible values are &#x60;TaskWorker&#x60;, &#x60;Admin&#x60; or &#x60;Operator&#x60;. | [optional] 
 **categoryIn** | **string**| Filter by a comma-separated list of categories that this operation is associated with, possible values are &#x60;TaskWorker&#x60;, &#x60;Admin&#x60; or &#x60;Operator&#x60;. | [optional] 
 **property** | **string**| Only include operations that changed this property, e.g., &#x60;owner&#x60; or &#x60;assignee&#x60;. | [optional] 
 **afterTimestamp** | **DateTime?**| Restrict to entries that were created after the given timestamp. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the timestamp must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., 2013-01-23T14:42:45.000+0200. | [optional] 
 **beforeTimestamp** | **DateTime?**| Restrict to entries that were created before the given timestamp. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the timestamp must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., 2013-01-23T14:42:45.000+0200. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;UserOperationLogEntryDto&gt;**](UserOperationLogEntryDto.md)

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

<a name="setannotationuseroperationlog"></a>
# **SetAnnotationUserOperationLog**
> void SetAnnotationUserOperationLog (string operationId, AnnotationDto annotationDto = null)

Set Annotation to an User Operation Log (Historic)

Set an annotation for auditing reasons.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SetAnnotationUserOperationLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricUserOperationLogApi(config);
            var operationId = operationId_example;  // string | The operation id of the operation log to be updated.
            var annotationDto = new AnnotationDto(); // AnnotationDto |  (optional) 

            try
            {
                // Set Annotation to an User Operation Log (Historic)
                apiInstance.SetAnnotationUserOperationLog(operationId, annotationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricUserOperationLogApi.SetAnnotationUserOperationLog: " + e.Message );
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
 **operationId** | **string**| The operation id of the operation log to be updated. | 
 **annotationDto** | [**AnnotationDto**](AnnotationDto.md)|  | [optional] 

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
| **400** | Returned if some of the request parameters are invalid, for example if the &#x60;operationId&#x60; path parameter value does not exists. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

