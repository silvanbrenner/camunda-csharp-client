# Camunda.OpenApi.Client.Model.TaskDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The task id. | [optional] 
**Name** | **string** | The task name. | [optional] 
**Assignee** | **string** | The assignee&#39;s id. | [optional] 
**Owner** | **string** | The owner&#39;s id. | [optional] 
**Created** | **DateTime?** | The date the task was created on. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**Due** | **DateTime?** | The task&#39;s due date. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**FollowUp** | **DateTime?** | The follow-up date for the task. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**DelegationState** | **string** | The task&#39;s delegation state. Possible values are &#x60;PENDING&#x60; and &#x60;RESOLVED&#x60;. | [optional] 
**Description** | **string** | The task&#39;s description. | [optional] 
**ExecutionId** | **string** | The id of the execution the task belongs to. | [optional] 
**ParentTaskId** | **string** | The id the parent task, if this task is a subtask. | [optional] 
**Priority** | **int?** | The task&#39;s priority. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition the task belongs to. | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance the task belongs to. | [optional] 
**CaseExecutionId** | **string** | The id of the case execution the task belongs to. | [optional] 
**CaseDefinitionId** | **string** | The id of the case definition the task belongs to. | [optional] 
**CaseInstanceId** | **string** | The id of the case instance the task belongs to. | [optional] 
**TaskDefinitionKey** | **string** | The task&#39;s key. | [optional] 
**Suspended** | **bool?** | Whether the task belongs to a process instance that is suspended. | [optional] 
**FormKey** | **string** | If not &#x60;null&#x60;, the form key for the task. | [optional] 
**CamundaFormRef** | [**Dictionary&lt;string, CamundaFormRef&gt;**](CamundaFormRef.md) | A reference to a specific version of a Camunda Form. | [optional] 
**TenantId** | **string** | If not &#x60;null&#x60;, the tenant id of the task. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

