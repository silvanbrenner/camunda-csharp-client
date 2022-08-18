# Camunda.OpenApi.Client.Api.HistoricTaskInstanceApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHistoricTaskInstanceReport**](HistoricTaskInstanceApi.md#gethistorictaskinstancereport) | **GET** /history/task/report | Get Task Report (Historic)
[**GetHistoricTaskInstances**](HistoricTaskInstanceApi.md#gethistorictaskinstances) | **GET** /history/task | Get Tasks (Historic)
[**GetHistoricTaskInstancesCount**](HistoricTaskInstanceApi.md#gethistorictaskinstancescount) | **GET** /history/task/count | Get Task Count
[**QueryHistoricTaskInstances**](HistoricTaskInstanceApi.md#queryhistorictaskinstances) | **POST** /history/task | Get Tasks (Historic) (POST)
[**QueryHistoricTaskInstancesCount**](HistoricTaskInstanceApi.md#queryhistorictaskinstancescount) | **POST** /history/task/count | Get Task Count (POST)


<a name="gethistorictaskinstancereport"></a>
# **GetHistoricTaskInstanceReport**
> List&lt;HistoricTaskInstanceReportResultDto&gt; GetHistoricTaskInstanceReport (string reportType = null, string periodUnit = null, DateTime? completedBefore = null, DateTime? completedAfter = null, string groupBy = null)

Get Task Report (Historic)

Retrieves a report of completed tasks. When the report type is set to `count`, the report contains a list of completed task counts where an entry contains the task name, the definition key of the task, the process definition id, the process definition key, the process definition name and the count of how many tasks were completed for the specified key in a given period. When the report type is set to `duration`, the report contains a minimum, maximum and average duration value of all completed task instances in a given period.

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
    public class GetHistoricTaskInstanceReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricTaskInstanceApi(httpClient, config, httpClientHandler);
            var reportType = reportType_example;  // string | **Mandatory.** Specifies the kind of the report to execute. To retrieve a report about the duration of process instances the value must be set to `duration`. For a report of the completed tasks in a specific timespan the value must be set to `count`. (optional) 
            var periodUnit = periodUnit_example;  // string | When the report type is set to `duration`, this parameter is **mandatory**. Specifies the granularity of the report. Valid values are `month` and `quarter`. (optional) 
            var completedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that were completed before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var completedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that were completed after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var groupBy = groupBy_example;  // string | When the report type is set to `count`, this parameter is **mandatory**. Groups the tasks report by a given criterion. Valid values are `taskName` and `processDefinition`. (optional) 

            try
            {
                // Get Task Report (Historic)
                List<HistoricTaskInstanceReportResultDto> result = apiInstance.GetHistoricTaskInstanceReport(reportType, periodUnit, completedBefore, completedAfter, groupBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricTaskInstanceApi.GetHistoricTaskInstanceReport: " + e.Message );
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
 **reportType** | **string**| **Mandatory.** Specifies the kind of the report to execute. To retrieve a report about the duration of process instances the value must be set to &#x60;duration&#x60;. For a report of the completed tasks in a specific timespan the value must be set to &#x60;count&#x60;. | [optional] 
 **periodUnit** | **string**| When the report type is set to &#x60;duration&#x60;, this parameter is **mandatory**. Specifies the granularity of the report. Valid values are &#x60;month&#x60; and &#x60;quarter&#x60;. | [optional] 
 **completedBefore** | **DateTime?**| Restrict to tasks that were completed before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **completedAfter** | **DateTime?**| Restrict to tasks that were completed after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **groupBy** | **string**| When the report type is set to &#x60;count&#x60;, this parameter is **mandatory**. Groups the tasks report by a given criterion. Valid values are &#x60;taskName&#x60; and &#x60;processDefinition&#x60;. | [optional] 

### Return type

[**List&lt;HistoricTaskInstanceReportResultDto&gt;**](HistoricTaskInstanceReportResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;completedAfter&#x60; parameter is supplied, but the date format is wrong. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistorictaskinstances"></a>
# **GetHistoricTaskInstances**
> List&lt;HistoricTaskInstanceDto&gt; GetHistoricTaskInstances (string taskId = null, string taskParentTaskId = null, string processInstanceId = null, string processInstanceBusinessKey = null, string processInstanceBusinessKeyIn = null, string processInstanceBusinessKeyLike = null, string executionId = null, string processDefinitionId = null, string processDefinitionKey = null, string processDefinitionName = null, string caseInstanceId = null, string caseExecutionId = null, string caseDefinitionId = null, string caseDefinitionKey = null, string caseDefinitionName = null, string activityInstanceIdIn = null, string taskName = null, string taskNameLike = null, string taskDescription = null, string taskDescriptionLike = null, string taskDefinitionKey = null, string taskDefinitionKeyIn = null, string taskDeleteReason = null, string taskDeleteReasonLike = null, string taskAssignee = null, string taskAssigneeLike = null, string taskOwner = null, string taskOwnerLike = null, int? taskPriority = null, bool? assigned = null, bool? unassigned = null, bool? finished = null, bool? unfinished = null, bool? processFinished = null, bool? processUnfinished = null, DateTime? taskDueDate = null, DateTime? taskDueDateBefore = null, DateTime? taskDueDateAfter = null, bool? withoutTaskDueDate = null, DateTime? taskFollowUpDate = null, DateTime? taskFollowUpDateBefore = null, DateTime? taskFollowUpDateAfter = null, DateTime? startedBefore = null, DateTime? startedAfter = null, DateTime? finishedBefore = null, DateTime? finishedAfter = null, string tenantIdIn = null, bool? withoutTenantId = null, string taskVariables = null, string processVariables = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null, string taskInvolvedUser = null, string taskInvolvedGroup = null, string taskHadCandidateUser = null, string taskHadCandidateGroup = null, bool? withCandidateGroups = null, bool? withoutCandidateGroups = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Tasks (Historic)

Queries for historic tasks that fulfill the given parameters. The size of the result set can be retrieved by using the [Get Task Count](https://docs.camunda.org/manual/7.17/reference/rest/history/task/get-task-query-count/) method.

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
    public class GetHistoricTaskInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricTaskInstanceApi(httpClient, config, httpClientHandler);
            var taskId = taskId_example;  // string | Filter by task id. (optional) 
            var taskParentTaskId = taskParentTaskId_example;  // string | Filter by parent task id. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processInstanceBusinessKey = processInstanceBusinessKey_example;  // string | Filter by process instance business key. (optional) 
            var processInstanceBusinessKeyIn = processInstanceBusinessKeyIn_example;  // string | Filter by process instances with one of the give business keys. The keys need to be in a comma-separated list. (optional) 
            var processInstanceBusinessKeyLike = processInstanceBusinessKeyLike_example;  // string | Filter by  process instance business key that has the parameter value as a substring. (optional) 
            var executionId = executionId_example;  // string | Filter by the id of the execution that executed the task. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Restrict to tasks that belong to a process definition with the given key. (optional) 
            var processDefinitionName = processDefinitionName_example;  // string | Restrict to tasks that belong to a process definition with the given name. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by case instance id. (optional) 
            var caseExecutionId = caseExecutionId_example;  // string | Filter by the id of the case execution that executed the task. (optional) 
            var caseDefinitionId = caseDefinitionId_example;  // string | Filter by case definition id. (optional) 
            var caseDefinitionKey = caseDefinitionKey_example;  // string | Restrict to tasks that belong to a case definition with the given key. (optional) 
            var caseDefinitionName = caseDefinitionName_example;  // string | Restrict to tasks that belong to a case definition with the given name. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Only include tasks which belong to one of the passed comma-separated activity instance ids. (optional) 
            var taskName = taskName_example;  // string | Restrict to tasks that have the given name. (optional) 
            var taskNameLike = taskNameLike_example;  // string | Restrict to tasks that have a name with the given parameter value as substring. (optional) 
            var taskDescription = taskDescription_example;  // string | Restrict to tasks that have the given description. (optional) 
            var taskDescriptionLike = taskDescriptionLike_example;  // string | Restrict to tasks that have a description that has the parameter value as a substring. (optional) 
            var taskDefinitionKey = taskDefinitionKey_example;  // string | Restrict to tasks that have the given key. (optional) 
            var taskDefinitionKeyIn = taskDefinitionKeyIn_example;  // string | Restrict to tasks that have one of the passed comma-separated task definition keys. (optional) 
            var taskDeleteReason = taskDeleteReason_example;  // string | Restrict to tasks that have the given delete reason. (optional) 
            var taskDeleteReasonLike = taskDeleteReasonLike_example;  // string | Restrict to tasks that have a delete reason that has the parameter value as a substring. (optional) 
            var taskAssignee = taskAssignee_example;  // string | Restrict to tasks that the given user is assigned to. (optional) 
            var taskAssigneeLike = taskAssigneeLike_example;  // string | Restrict to tasks that are assigned to users with the parameter value as a substring. (optional) 
            var taskOwner = taskOwner_example;  // string | Restrict to tasks that the given user owns. (optional) 
            var taskOwnerLike = taskOwnerLike_example;  // string | Restrict to tasks that are owned by users with the parameter value as a substring. (optional) 
            var taskPriority = 56;  // int? | Restrict to tasks that have the given priority. (optional) 
            var assigned = true;  // bool? | If set to `true`, restricts the query to all tasks that are assigned. (optional) 
            var unassigned = true;  // bool? | If set to `true`, restricts the query to all tasks that are unassigned. (optional) 
            var finished = true;  // bool? | Only include finished tasks. Value may only be `true`, as `false` is the default behavior. (optional) 
            var unfinished = true;  // bool? | Only include unfinished tasks. Value may only be `true`, as `false` is the default behavior. (optional) 
            var processFinished = true;  // bool? | Only include tasks of finished processes. Value may only be `true`, as `false` is the default behavior. (optional) 
            var processUnfinished = true;  // bool? | Only include tasks of unfinished processes. Value may only be `true`, as `false` is the default behavior. (optional) 
            var taskDueDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that are due on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var taskDueDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that are due before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var taskDueDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that are due after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var withoutTaskDueDate = true;  // bool? | Only include tasks which have no due date. Value may only be `true`, as `false` is the default behavior. (optional) 
            var taskFollowUpDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that have a followUp date on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var taskFollowUpDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that have a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var taskFollowUpDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that have a followUp date after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that were started before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that were started after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that were finished before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that were finished after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A task instance must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic task instances that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var taskVariables = taskVariables_example;  // string | Only include tasks that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value. **Note:** Values are always treated as `String` objects on server side.   Valid operator values are: * `eq` - equal to; * `neq` - not equal to; * `gt` - greater than; * `gteq` - greater than or equal to; * `lt` - lower than; * `lteq` - lower than or equal to; * `like`.  `key` and `value` may not contain underscore or comma characters. (optional) 
            var processVariables = processVariables_example;  // string | Only include tasks that belong to process instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value. **Note:** Values are always treated as `String` objects on server side.   Valid operator values are: * `eq` - equal to; * `neq` - not equal to; * `gt` - greater than; * `gteq` - greater than or equal to; * `lt` - lower than; * `lteq` - lower than or equal to; * `like`; * `notLike`.  `key` and `value` may not contain underscore or comma characters. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match the variable name provided in `taskVariables` and `processVariables` case- insensitively. If set to `true` **variableName** and **variablename** are treated as equal. (optional) 
            var variableValuesIgnoreCase = true;  // bool? | Match the variable value provided in `taskVariables` and `processVariables` case- insensitively. If set to `true` **variableValue** and **variablevalue** are treated as equal. (optional) 
            var taskInvolvedUser = taskInvolvedUser_example;  // string | Restrict to tasks with a historic identity link to the given user. (optional) 
            var taskInvolvedGroup = taskInvolvedGroup_example;  // string | Restrict to tasks with a historic identity link to the given group. (optional) 
            var taskHadCandidateUser = taskHadCandidateUser_example;  // string | Restrict to tasks with a historic identity link to the given candidate user. (optional) 
            var taskHadCandidateGroup = taskHadCandidateGroup_example;  // string | Restrict to tasks with a historic identity link to the given candidate group. (optional) 
            var withCandidateGroups = true;  // bool? | Only include tasks which have a candidate group. Value may only be `true`, as `false` is the default behavior. (optional) 
            var withoutCandidateGroups = true;  // bool? | Only include tasks which have no candidate group. Value may only be `true`, as `false` is the default behavior. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get Tasks (Historic)
                List<HistoricTaskInstanceDto> result = apiInstance.GetHistoricTaskInstances(taskId, taskParentTaskId, processInstanceId, processInstanceBusinessKey, processInstanceBusinessKeyIn, processInstanceBusinessKeyLike, executionId, processDefinitionId, processDefinitionKey, processDefinitionName, caseInstanceId, caseExecutionId, caseDefinitionId, caseDefinitionKey, caseDefinitionName, activityInstanceIdIn, taskName, taskNameLike, taskDescription, taskDescriptionLike, taskDefinitionKey, taskDefinitionKeyIn, taskDeleteReason, taskDeleteReasonLike, taskAssignee, taskAssigneeLike, taskOwner, taskOwnerLike, taskPriority, assigned, unassigned, finished, unfinished, processFinished, processUnfinished, taskDueDate, taskDueDateBefore, taskDueDateAfter, withoutTaskDueDate, taskFollowUpDate, taskFollowUpDateBefore, taskFollowUpDateAfter, startedBefore, startedAfter, finishedBefore, finishedAfter, tenantIdIn, withoutTenantId, taskVariables, processVariables, variableNamesIgnoreCase, variableValuesIgnoreCase, taskInvolvedUser, taskInvolvedGroup, taskHadCandidateUser, taskHadCandidateGroup, withCandidateGroups, withoutCandidateGroups, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricTaskInstanceApi.GetHistoricTaskInstances: " + e.Message );
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
 **taskId** | **string**| Filter by task id. | [optional] 
 **taskParentTaskId** | **string**| Filter by parent task id. | [optional] 
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **processInstanceBusinessKey** | **string**| Filter by process instance business key. | [optional] 
 **processInstanceBusinessKeyIn** | **string**| Filter by process instances with one of the give business keys. The keys need to be in a comma-separated list. | [optional] 
 **processInstanceBusinessKeyLike** | **string**| Filter by  process instance business key that has the parameter value as a substring. | [optional] 
 **executionId** | **string**| Filter by the id of the execution that executed the task. | [optional] 
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **processDefinitionKey** | **string**| Restrict to tasks that belong to a process definition with the given key. | [optional] 
 **processDefinitionName** | **string**| Restrict to tasks that belong to a process definition with the given name. | [optional] 
 **caseInstanceId** | **string**| Filter by case instance id. | [optional] 
 **caseExecutionId** | **string**| Filter by the id of the case execution that executed the task. | [optional] 
 **caseDefinitionId** | **string**| Filter by case definition id. | [optional] 
 **caseDefinitionKey** | **string**| Restrict to tasks that belong to a case definition with the given key. | [optional] 
 **caseDefinitionName** | **string**| Restrict to tasks that belong to a case definition with the given name. | [optional] 
 **activityInstanceIdIn** | **string**| Only include tasks which belong to one of the passed comma-separated activity instance ids. | [optional] 
 **taskName** | **string**| Restrict to tasks that have the given name. | [optional] 
 **taskNameLike** | **string**| Restrict to tasks that have a name with the given parameter value as substring. | [optional] 
 **taskDescription** | **string**| Restrict to tasks that have the given description. | [optional] 
 **taskDescriptionLike** | **string**| Restrict to tasks that have a description that has the parameter value as a substring. | [optional] 
 **taskDefinitionKey** | **string**| Restrict to tasks that have the given key. | [optional] 
 **taskDefinitionKeyIn** | **string**| Restrict to tasks that have one of the passed comma-separated task definition keys. | [optional] 
 **taskDeleteReason** | **string**| Restrict to tasks that have the given delete reason. | [optional] 
 **taskDeleteReasonLike** | **string**| Restrict to tasks that have a delete reason that has the parameter value as a substring. | [optional] 
 **taskAssignee** | **string**| Restrict to tasks that the given user is assigned to. | [optional] 
 **taskAssigneeLike** | **string**| Restrict to tasks that are assigned to users with the parameter value as a substring. | [optional] 
 **taskOwner** | **string**| Restrict to tasks that the given user owns. | [optional] 
 **taskOwnerLike** | **string**| Restrict to tasks that are owned by users with the parameter value as a substring. | [optional] 
 **taskPriority** | **int?**| Restrict to tasks that have the given priority. | [optional] 
 **assigned** | **bool?**| If set to &#x60;true&#x60;, restricts the query to all tasks that are assigned. | [optional] 
 **unassigned** | **bool?**| If set to &#x60;true&#x60;, restricts the query to all tasks that are unassigned. | [optional] 
 **finished** | **bool?**| Only include finished tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **unfinished** | **bool?**| Only include unfinished tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **processFinished** | **bool?**| Only include tasks of finished processes. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **processUnfinished** | **bool?**| Only include tasks of unfinished processes. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **taskDueDate** | **DateTime?**| Restrict to tasks that are due on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **taskDueDateBefore** | **DateTime?**| Restrict to tasks that are due before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **taskDueDateAfter** | **DateTime?**| Restrict to tasks that are due after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **withoutTaskDueDate** | **bool?**| Only include tasks which have no due date. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **taskFollowUpDate** | **DateTime?**| Restrict to tasks that have a followUp date on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **taskFollowUpDateBefore** | **DateTime?**| Restrict to tasks that have a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **taskFollowUpDateAfter** | **DateTime?**| Restrict to tasks that have a followUp date after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedBefore** | **DateTime?**| Restrict to tasks that were started before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedAfter** | **DateTime?**| Restrict to tasks that were started after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedBefore** | **DateTime?**| Restrict to tasks that were finished before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedAfter** | **DateTime?**| Restrict to tasks that were finished after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A task instance must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic task instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **taskVariables** | **string**| Only include tasks that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. **Note:** Values are always treated as &#x60;String&#x60; objects on server side.   Valid operator values are: * &#x60;eq&#x60; - equal to; * &#x60;neq&#x60; - not equal to; * &#x60;gt&#x60; - greater than; * &#x60;gteq&#x60; - greater than or equal to; * &#x60;lt&#x60; - lower than; * &#x60;lteq&#x60; - lower than or equal to; * &#x60;like&#x60;.  &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **processVariables** | **string**| Only include tasks that belong to process instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. **Note:** Values are always treated as &#x60;String&#x60; objects on server side.   Valid operator values are: * &#x60;eq&#x60; - equal to; * &#x60;neq&#x60; - not equal to; * &#x60;gt&#x60; - greater than; * &#x60;gteq&#x60; - greater than or equal to; * &#x60;lt&#x60; - lower than; * &#x60;lteq&#x60; - lower than or equal to; * &#x60;like&#x60;; * &#x60;notLike&#x60;.  &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match the variable name provided in &#x60;taskVariables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal. | [optional] 
 **variableValuesIgnoreCase** | **bool?**| Match the variable value provided in &#x60;taskVariables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal. | [optional] 
 **taskInvolvedUser** | **string**| Restrict to tasks with a historic identity link to the given user. | [optional] 
 **taskInvolvedGroup** | **string**| Restrict to tasks with a historic identity link to the given group. | [optional] 
 **taskHadCandidateUser** | **string**| Restrict to tasks with a historic identity link to the given candidate user. | [optional] 
 **taskHadCandidateGroup** | **string**| Restrict to tasks with a historic identity link to the given candidate group. | [optional] 
 **withCandidateGroups** | **bool?**| Only include tasks which have a candidate group. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **withoutCandidateGroups** | **bool?**| Only include tasks which have no candidate group. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;HistoricTaskInstanceDto&gt;**](HistoricTaskInstanceDto.md)

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

<a name="gethistorictaskinstancescount"></a>
# **GetHistoricTaskInstancesCount**
> CountResultDto GetHistoricTaskInstancesCount (string taskId = null, string taskParentTaskId = null, string processInstanceId = null, string processInstanceBusinessKey = null, string processInstanceBusinessKeyIn = null, string processInstanceBusinessKeyLike = null, string executionId = null, string processDefinitionId = null, string processDefinitionKey = null, string processDefinitionName = null, string caseInstanceId = null, string caseExecutionId = null, string caseDefinitionId = null, string caseDefinitionKey = null, string caseDefinitionName = null, string activityInstanceIdIn = null, string taskName = null, string taskNameLike = null, string taskDescription = null, string taskDescriptionLike = null, string taskDefinitionKey = null, string taskDefinitionKeyIn = null, string taskDeleteReason = null, string taskDeleteReasonLike = null, string taskAssignee = null, string taskAssigneeLike = null, string taskOwner = null, string taskOwnerLike = null, int? taskPriority = null, bool? assigned = null, bool? unassigned = null, bool? finished = null, bool? unfinished = null, bool? processFinished = null, bool? processUnfinished = null, DateTime? taskDueDate = null, DateTime? taskDueDateBefore = null, DateTime? taskDueDateAfter = null, bool? withoutTaskDueDate = null, DateTime? taskFollowUpDate = null, DateTime? taskFollowUpDateBefore = null, DateTime? taskFollowUpDateAfter = null, DateTime? startedBefore = null, DateTime? startedAfter = null, DateTime? finishedBefore = null, DateTime? finishedAfter = null, string tenantIdIn = null, bool? withoutTenantId = null, string taskVariables = null, string processVariables = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null, string taskInvolvedUser = null, string taskInvolvedGroup = null, string taskHadCandidateUser = null, string taskHadCandidateGroup = null, bool? withCandidateGroups = null, bool? withoutCandidateGroups = null)

Get Task Count

Queries for the number of historic tasks that fulfill the given parameters. Takes the same parameters as the [Get Tasks (Historic)](https://docs.camunda.org/manual/7.17/reference/rest/history/task/get-task-query/) method.

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
    public class GetHistoricTaskInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricTaskInstanceApi(httpClient, config, httpClientHandler);
            var taskId = taskId_example;  // string | Filter by task id. (optional) 
            var taskParentTaskId = taskParentTaskId_example;  // string | Filter by parent task id. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processInstanceBusinessKey = processInstanceBusinessKey_example;  // string | Filter by process instance business key. (optional) 
            var processInstanceBusinessKeyIn = processInstanceBusinessKeyIn_example;  // string | Filter by process instances with one of the give business keys. The keys need to be in a comma-separated list. (optional) 
            var processInstanceBusinessKeyLike = processInstanceBusinessKeyLike_example;  // string | Filter by  process instance business key that has the parameter value as a substring. (optional) 
            var executionId = executionId_example;  // string | Filter by the id of the execution that executed the task. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by process definition id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Restrict to tasks that belong to a process definition with the given key. (optional) 
            var processDefinitionName = processDefinitionName_example;  // string | Restrict to tasks that belong to a process definition with the given name. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by case instance id. (optional) 
            var caseExecutionId = caseExecutionId_example;  // string | Filter by the id of the case execution that executed the task. (optional) 
            var caseDefinitionId = caseDefinitionId_example;  // string | Filter by case definition id. (optional) 
            var caseDefinitionKey = caseDefinitionKey_example;  // string | Restrict to tasks that belong to a case definition with the given key. (optional) 
            var caseDefinitionName = caseDefinitionName_example;  // string | Restrict to tasks that belong to a case definition with the given name. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Only include tasks which belong to one of the passed comma-separated activity instance ids. (optional) 
            var taskName = taskName_example;  // string | Restrict to tasks that have the given name. (optional) 
            var taskNameLike = taskNameLike_example;  // string | Restrict to tasks that have a name with the given parameter value as substring. (optional) 
            var taskDescription = taskDescription_example;  // string | Restrict to tasks that have the given description. (optional) 
            var taskDescriptionLike = taskDescriptionLike_example;  // string | Restrict to tasks that have a description that has the parameter value as a substring. (optional) 
            var taskDefinitionKey = taskDefinitionKey_example;  // string | Restrict to tasks that have the given key. (optional) 
            var taskDefinitionKeyIn = taskDefinitionKeyIn_example;  // string | Restrict to tasks that have one of the passed comma-separated task definition keys. (optional) 
            var taskDeleteReason = taskDeleteReason_example;  // string | Restrict to tasks that have the given delete reason. (optional) 
            var taskDeleteReasonLike = taskDeleteReasonLike_example;  // string | Restrict to tasks that have a delete reason that has the parameter value as a substring. (optional) 
            var taskAssignee = taskAssignee_example;  // string | Restrict to tasks that the given user is assigned to. (optional) 
            var taskAssigneeLike = taskAssigneeLike_example;  // string | Restrict to tasks that are assigned to users with the parameter value as a substring. (optional) 
            var taskOwner = taskOwner_example;  // string | Restrict to tasks that the given user owns. (optional) 
            var taskOwnerLike = taskOwnerLike_example;  // string | Restrict to tasks that are owned by users with the parameter value as a substring. (optional) 
            var taskPriority = 56;  // int? | Restrict to tasks that have the given priority. (optional) 
            var assigned = true;  // bool? | If set to `true`, restricts the query to all tasks that are assigned. (optional) 
            var unassigned = true;  // bool? | If set to `true`, restricts the query to all tasks that are unassigned. (optional) 
            var finished = true;  // bool? | Only include finished tasks. Value may only be `true`, as `false` is the default behavior. (optional) 
            var unfinished = true;  // bool? | Only include unfinished tasks. Value may only be `true`, as `false` is the default behavior. (optional) 
            var processFinished = true;  // bool? | Only include tasks of finished processes. Value may only be `true`, as `false` is the default behavior. (optional) 
            var processUnfinished = true;  // bool? | Only include tasks of unfinished processes. Value may only be `true`, as `false` is the default behavior. (optional) 
            var taskDueDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that are due on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var taskDueDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that are due before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var taskDueDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that are due after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var withoutTaskDueDate = true;  // bool? | Only include tasks which have no due date. Value may only be `true`, as `false` is the default behavior. (optional) 
            var taskFollowUpDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that have a followUp date on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var taskFollowUpDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that have a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var taskFollowUpDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that have a followUp date after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that were started before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that were started after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that were finished before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to tasks that were finished after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A task instance must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic task instances that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var taskVariables = taskVariables_example;  // string | Only include tasks that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value. **Note:** Values are always treated as `String` objects on server side.   Valid operator values are: * `eq` - equal to; * `neq` - not equal to; * `gt` - greater than; * `gteq` - greater than or equal to; * `lt` - lower than; * `lteq` - lower than or equal to; * `like`.  `key` and `value` may not contain underscore or comma characters. (optional) 
            var processVariables = processVariables_example;  // string | Only include tasks that belong to process instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value. **Note:** Values are always treated as `String` objects on server side.   Valid operator values are: * `eq` - equal to; * `neq` - not equal to; * `gt` - greater than; * `gteq` - greater than or equal to; * `lt` - lower than; * `lteq` - lower than or equal to; * `like`; * `notLike`.  `key` and `value` may not contain underscore or comma characters. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match the variable name provided in `taskVariables` and `processVariables` case- insensitively. If set to `true` **variableName** and **variablename** are treated as equal. (optional) 
            var variableValuesIgnoreCase = true;  // bool? | Match the variable value provided in `taskVariables` and `processVariables` case- insensitively. If set to `true` **variableValue** and **variablevalue** are treated as equal. (optional) 
            var taskInvolvedUser = taskInvolvedUser_example;  // string | Restrict to tasks with a historic identity link to the given user. (optional) 
            var taskInvolvedGroup = taskInvolvedGroup_example;  // string | Restrict to tasks with a historic identity link to the given group. (optional) 
            var taskHadCandidateUser = taskHadCandidateUser_example;  // string | Restrict to tasks with a historic identity link to the given candidate user. (optional) 
            var taskHadCandidateGroup = taskHadCandidateGroup_example;  // string | Restrict to tasks with a historic identity link to the given candidate group. (optional) 
            var withCandidateGroups = true;  // bool? | Only include tasks which have a candidate group. Value may only be `true`, as `false` is the default behavior. (optional) 
            var withoutCandidateGroups = true;  // bool? | Only include tasks which have no candidate group. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get Task Count
                CountResultDto result = apiInstance.GetHistoricTaskInstancesCount(taskId, taskParentTaskId, processInstanceId, processInstanceBusinessKey, processInstanceBusinessKeyIn, processInstanceBusinessKeyLike, executionId, processDefinitionId, processDefinitionKey, processDefinitionName, caseInstanceId, caseExecutionId, caseDefinitionId, caseDefinitionKey, caseDefinitionName, activityInstanceIdIn, taskName, taskNameLike, taskDescription, taskDescriptionLike, taskDefinitionKey, taskDefinitionKeyIn, taskDeleteReason, taskDeleteReasonLike, taskAssignee, taskAssigneeLike, taskOwner, taskOwnerLike, taskPriority, assigned, unassigned, finished, unfinished, processFinished, processUnfinished, taskDueDate, taskDueDateBefore, taskDueDateAfter, withoutTaskDueDate, taskFollowUpDate, taskFollowUpDateBefore, taskFollowUpDateAfter, startedBefore, startedAfter, finishedBefore, finishedAfter, tenantIdIn, withoutTenantId, taskVariables, processVariables, variableNamesIgnoreCase, variableValuesIgnoreCase, taskInvolvedUser, taskInvolvedGroup, taskHadCandidateUser, taskHadCandidateGroup, withCandidateGroups, withoutCandidateGroups);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricTaskInstanceApi.GetHistoricTaskInstancesCount: " + e.Message );
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
 **taskId** | **string**| Filter by task id. | [optional] 
 **taskParentTaskId** | **string**| Filter by parent task id. | [optional] 
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **processInstanceBusinessKey** | **string**| Filter by process instance business key. | [optional] 
 **processInstanceBusinessKeyIn** | **string**| Filter by process instances with one of the give business keys. The keys need to be in a comma-separated list. | [optional] 
 **processInstanceBusinessKeyLike** | **string**| Filter by  process instance business key that has the parameter value as a substring. | [optional] 
 **executionId** | **string**| Filter by the id of the execution that executed the task. | [optional] 
 **processDefinitionId** | **string**| Filter by process definition id. | [optional] 
 **processDefinitionKey** | **string**| Restrict to tasks that belong to a process definition with the given key. | [optional] 
 **processDefinitionName** | **string**| Restrict to tasks that belong to a process definition with the given name. | [optional] 
 **caseInstanceId** | **string**| Filter by case instance id. | [optional] 
 **caseExecutionId** | **string**| Filter by the id of the case execution that executed the task. | [optional] 
 **caseDefinitionId** | **string**| Filter by case definition id. | [optional] 
 **caseDefinitionKey** | **string**| Restrict to tasks that belong to a case definition with the given key. | [optional] 
 **caseDefinitionName** | **string**| Restrict to tasks that belong to a case definition with the given name. | [optional] 
 **activityInstanceIdIn** | **string**| Only include tasks which belong to one of the passed comma-separated activity instance ids. | [optional] 
 **taskName** | **string**| Restrict to tasks that have the given name. | [optional] 
 **taskNameLike** | **string**| Restrict to tasks that have a name with the given parameter value as substring. | [optional] 
 **taskDescription** | **string**| Restrict to tasks that have the given description. | [optional] 
 **taskDescriptionLike** | **string**| Restrict to tasks that have a description that has the parameter value as a substring. | [optional] 
 **taskDefinitionKey** | **string**| Restrict to tasks that have the given key. | [optional] 
 **taskDefinitionKeyIn** | **string**| Restrict to tasks that have one of the passed comma-separated task definition keys. | [optional] 
 **taskDeleteReason** | **string**| Restrict to tasks that have the given delete reason. | [optional] 
 **taskDeleteReasonLike** | **string**| Restrict to tasks that have a delete reason that has the parameter value as a substring. | [optional] 
 **taskAssignee** | **string**| Restrict to tasks that the given user is assigned to. | [optional] 
 **taskAssigneeLike** | **string**| Restrict to tasks that are assigned to users with the parameter value as a substring. | [optional] 
 **taskOwner** | **string**| Restrict to tasks that the given user owns. | [optional] 
 **taskOwnerLike** | **string**| Restrict to tasks that are owned by users with the parameter value as a substring. | [optional] 
 **taskPriority** | **int?**| Restrict to tasks that have the given priority. | [optional] 
 **assigned** | **bool?**| If set to &#x60;true&#x60;, restricts the query to all tasks that are assigned. | [optional] 
 **unassigned** | **bool?**| If set to &#x60;true&#x60;, restricts the query to all tasks that are unassigned. | [optional] 
 **finished** | **bool?**| Only include finished tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **unfinished** | **bool?**| Only include unfinished tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **processFinished** | **bool?**| Only include tasks of finished processes. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **processUnfinished** | **bool?**| Only include tasks of unfinished processes. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **taskDueDate** | **DateTime?**| Restrict to tasks that are due on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **taskDueDateBefore** | **DateTime?**| Restrict to tasks that are due before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **taskDueDateAfter** | **DateTime?**| Restrict to tasks that are due after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **withoutTaskDueDate** | **bool?**| Only include tasks which have no due date. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **taskFollowUpDate** | **DateTime?**| Restrict to tasks that have a followUp date on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **taskFollowUpDateBefore** | **DateTime?**| Restrict to tasks that have a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **taskFollowUpDateAfter** | **DateTime?**| Restrict to tasks that have a followUp date after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedBefore** | **DateTime?**| Restrict to tasks that were started before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedAfter** | **DateTime?**| Restrict to tasks that were started after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedBefore** | **DateTime?**| Restrict to tasks that were finished before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedAfter** | **DateTime?**| Restrict to tasks that were finished after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A task instance must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic task instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **taskVariables** | **string**| Only include tasks that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. **Note:** Values are always treated as &#x60;String&#x60; objects on server side.   Valid operator values are: * &#x60;eq&#x60; - equal to; * &#x60;neq&#x60; - not equal to; * &#x60;gt&#x60; - greater than; * &#x60;gteq&#x60; - greater than or equal to; * &#x60;lt&#x60; - lower than; * &#x60;lteq&#x60; - lower than or equal to; * &#x60;like&#x60;.  &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **processVariables** | **string**| Only include tasks that belong to process instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. **Note:** Values are always treated as &#x60;String&#x60; objects on server side.   Valid operator values are: * &#x60;eq&#x60; - equal to; * &#x60;neq&#x60; - not equal to; * &#x60;gt&#x60; - greater than; * &#x60;gteq&#x60; - greater than or equal to; * &#x60;lt&#x60; - lower than; * &#x60;lteq&#x60; - lower than or equal to; * &#x60;like&#x60;; * &#x60;notLike&#x60;.  &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match the variable name provided in &#x60;taskVariables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal. | [optional] 
 **variableValuesIgnoreCase** | **bool?**| Match the variable value provided in &#x60;taskVariables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal. | [optional] 
 **taskInvolvedUser** | **string**| Restrict to tasks with a historic identity link to the given user. | [optional] 
 **taskInvolvedGroup** | **string**| Restrict to tasks with a historic identity link to the given group. | [optional] 
 **taskHadCandidateUser** | **string**| Restrict to tasks with a historic identity link to the given candidate user. | [optional] 
 **taskHadCandidateGroup** | **string**| Restrict to tasks with a historic identity link to the given candidate group. | [optional] 
 **withCandidateGroups** | **bool?**| Only include tasks which have a candidate group. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **withoutCandidateGroups** | **bool?**| Only include tasks which have no candidate group. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistorictaskinstances"></a>
# **QueryHistoricTaskInstances**
> List&lt;HistoricTaskInstanceDto&gt; QueryHistoricTaskInstances (int? firstResult = null, int? maxResults = null, HistoricTaskInstanceQueryDto historicTaskInstanceQueryDto = null)

Get Tasks (Historic) (POST)

Queries for historic tasks that fulfill the given parameters. This method is slightly more powerful than the [Get Tasks (Historic)](https://docs.camunda.org/manual/7.17/reference/rest/history/task/get-task-query/) method because it allows filtering by multiple process or task variables of types `String`, `Number` or `Boolean`. The size of the result set can be retrieved by using the [Get Task Count (POST)](https://docs.camunda.org/manual/7.17/reference/rest/history/task/post-task-query-count/) method.

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
    public class QueryHistoricTaskInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricTaskInstanceApi(httpClient, config, httpClientHandler);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var historicTaskInstanceQueryDto = new HistoricTaskInstanceQueryDto(); // HistoricTaskInstanceQueryDto |  (optional) 

            try
            {
                // Get Tasks (Historic) (POST)
                List<HistoricTaskInstanceDto> result = apiInstance.QueryHistoricTaskInstances(firstResult, maxResults, historicTaskInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricTaskInstanceApi.QueryHistoricTaskInstances: " + e.Message );
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
 **historicTaskInstanceQueryDto** | [**HistoricTaskInstanceQueryDto**](HistoricTaskInstanceQueryDto.md)|  | [optional] 

### Return type

[**List&lt;HistoricTaskInstanceDto&gt;**](HistoricTaskInstanceDto.md)

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

<a name="queryhistorictaskinstancescount"></a>
# **QueryHistoricTaskInstancesCount**
> CountResultDto QueryHistoricTaskInstancesCount (HistoricTaskInstanceQueryDto historicTaskInstanceQueryDto = null)

Get Task Count (POST)

Queries for the number of historic tasks that fulfill the given parameters. Takes the same parameters as the [Get Tasks (Historic)](https://docs.camunda.org/manual/7.17/reference/rest/history/task/get-task-query/) method. Corresponds to the size of the result set of the [Get Tasks (Historic) (POST)](https://docs.camunda.org/manual/7.17/reference/rest/history/task/post-task-query/) method and takes the same parameters.

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
    public class QueryHistoricTaskInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricTaskInstanceApi(httpClient, config, httpClientHandler);
            var historicTaskInstanceQueryDto = new HistoricTaskInstanceQueryDto(); // HistoricTaskInstanceQueryDto |  (optional) 

            try
            {
                // Get Task Count (POST)
                CountResultDto result = apiInstance.QueryHistoricTaskInstancesCount(historicTaskInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricTaskInstanceApi.QueryHistoricTaskInstancesCount: " + e.Message );
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
 **historicTaskInstanceQueryDto** | [**HistoricTaskInstanceQueryDto**](HistoricTaskInstanceQueryDto.md)|  | [optional] 

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
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

