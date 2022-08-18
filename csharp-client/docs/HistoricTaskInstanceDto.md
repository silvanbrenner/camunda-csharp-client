# Camunda.OpenApi.Client.Model.HistoricTaskInstanceDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The task id. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition the task belongs to. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition the task belongs to. | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance the task belongs to. | [optional] 
**ExecutionId** | **string** | The id of the execution the task belongs to. | [optional] 
**CaseDefinitionKey** | **string** | The key of the case definition the task belongs to. | [optional] 
**CaseDefinitionId** | **string** | The id of the case definition the task belongs to. | [optional] 
**CaseInstanceId** | **string** | The id of the case instance the task belongs to. | [optional] 
**CaseExecutionId** | **string** | The id of the case execution the task belongs to. | [optional] 
**ActivityInstanceId** | **string** | The id of the activity that this object is an instance of. | [optional] 
**Name** | **string** | The task name. | [optional] 
**Description** | **string** | The task&#39;s description. | [optional] 
**DeleteReason** | **string** | The task&#39;s delete reason. | [optional] 
**Owner** | **string** | The owner&#39;s id. | [optional] 
**Assignee** | **string** | The assignee&#39;s id. | [optional] 
**StartTime** | **DateTime?** | The time the task was started. Default [format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**EndTime** | **DateTime?** | The time the task ended. Default [format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**Duration** | **long?** | The time the task took to finish (in milliseconds). | [optional] 
**TaskDefinitionKey** | **string** | The task&#39;s key. | [optional] 
**Priority** | **int?** | The task&#39;s priority. | [optional] 
**Due** | **DateTime?** | The task&#39;s due date. Default [format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**ParentTaskId** | **string** | The id of the parent task, if this task is a subtask. | [optional] 
**FollowUp** | **DateTime?** | The follow-up date for the task. Default [format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**TenantId** | **string** | The tenant id of the task instance. | [optional] 
**RemovalTime** | **DateTime?** | The time after which the task should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the process containing this task. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

