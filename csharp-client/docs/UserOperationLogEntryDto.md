# Camunda.OpenApi.Client.Model.UserOperationLogEntryDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of this log entry. | [optional] 
**UserId** | **string** | The user who performed this operation. | [optional] 
**Timestamp** | **DateTime?** | Timestamp of this operation. | [optional] 
**OperationId** | **string** | The unique identifier of this operation. A composite operation that changes multiple properties has a common &#x60;operationId&#x60;. | [optional] 
**OperationType** | **string** | The type of this operation, e.g., &#x60;Assign&#x60;, &#x60;Claim&#x60; and so on. | [optional] 
**EntityType** | **string** | The type of the entity on which this operation was executed, e.g., &#x60;Task&#x60; or &#x60;Attachment&#x60;. | [optional] 
**Category** | **string** | The name of the category this operation was associated with, e.g., &#x60;TaskWorker&#x60; or &#x60;Admin&#x60;. | [optional] 
**Annotation** | **string** | An arbitrary annotation set by a user for auditing reasons. | [optional] 
**Property** | **string** | The property changed by this operation. | [optional] 
**OrgValue** | **string** | The original value of the changed property. | [optional] 
**NewValue** | **string** | The new value of the changed property. | [optional] 
**DeploymentId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this deployment. | [optional] 
**ProcessDefinitionId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this process definition. | [optional] 
**ProcessDefinitionKey** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to process definitions with this key. | [optional] 
**ProcessInstanceId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this process instance. | [optional] 
**ExecutionId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this execution. | [optional] 
**CaseDefinitionId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case definition. | [optional] 
**CaseInstanceId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case instance. | [optional] 
**CaseExecutionId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case execution. | [optional] 
**TaskId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this task. | [optional] 
**ExternalTaskId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this external task. | [optional] 
**BatchId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this batch. | [optional] 
**JobId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this job. | [optional] 
**JobDefinitionId** | **string** | If not &#x60;null&#x60;, the operation is restricted to entities in relation to this job definition. | [optional] 
**RemovalTime** | **DateTime?** | The time after which the entry should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the process containing this entry. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

