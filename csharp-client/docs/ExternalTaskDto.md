# Camunda.OpenApi.Client.Model.ExternalTaskDto
An External Task object with the following properties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityId** | **string** | The id of the activity that this external task belongs to. | [optional] 
**ActivityInstanceId** | **string** | The id of the activity instance that the external task belongs to. | [optional] 
**ErrorMessage** | **string** | The full error message submitted with the latest reported failure executing this task; &#x60;null&#x60; if no failure was reported previously or if no error message was submitted | [optional] 
**ExecutionId** | **string** | The id of the execution that the external task belongs to. | [optional] 
**Id** | **string** | The id of the external task. | [optional] 
**LockExpirationTime** | **DateTime?** | The date that the task&#39;s most recent lock expires or has expired. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition the external task is defined in. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition the external task is defined in. | [optional] 
**ProcessDefinitionVersionTag** | **string** | The version tag of the process definition the external task is defined in. | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance the external task belongs to. | [optional] 
**TenantId** | **string** | The id of the tenant the external task belongs to. | [optional] 
**Retries** | **int?** | The number of retries the task currently has left. | [optional] 
**Suspended** | **bool?** | A flag indicating whether the external task is suspended or not. | [optional] 
**WorkerId** | **string** | The id of the worker that posesses or posessed the most recent lock. | [optional] 
**TopicName** | **string** | The topic name of the external task. | [optional] 
**Priority** | **long?** | The priority of the external task. | [optional] 
**BusinessKey** | **string** | The business key of the process instance the external task belongs to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

