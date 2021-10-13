# Camunda.OpenApi.Client.Model.HistoricVariableInstanceDtoAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the variable instance. | [optional] 
**Name** | **string** | The name of the variable instance. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition the variable instance belongs to. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition the variable instance belongs to. | [optional] 
**ProcessInstanceId** | **string** | The process instance id the variable instance belongs to. | [optional] 
**ExecutionId** | **string** | The execution id the variable instance belongs to. | [optional] 
**ActivityInstanceId** | **string** | The id of the activity instance in which the variable is valid. | [optional] 
**CaseDefinitionKey** | **string** | The key of the case definition the variable instance belongs to. | [optional] 
**CaseDefinitionId** | **string** | The id of the case definition the variable instance belongs to. | [optional] 
**CaseInstanceId** | **string** | The case instance id the variable instance belongs to. | [optional] 
**CaseExecutionId** | **string** | The case execution id the variable instance belongs to. | [optional] 
**TaskId** | **string** | The id of the task the variable instance belongs to. | [optional] 
**TenantId** | **string** | The id of the tenant that this variable instance belongs to. | [optional] 
**ErrorMessage** | **string** | An error message in case a Java Serialized Object could not be de-serialized. | [optional] 
**State** | **string** | The current state of the variable. Can be &#39;CREATED&#39; or &#39;DELETED&#39;. | [optional] 
**CreateTime** | **DateTime?** | The time the variable was inserted. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RemovalTime** | **DateTime?** | The time after which the variable should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the process containing this variable. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

