# Camunda.OpenApi.Client.Model.HistoricExternalTaskLogQueryDto
A Historic External Task Log instance query which defines a list of Historic External Task Log instances

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LogId** | **string** | Filter by historic external task log id. | [optional] 
**ExternalTaskId** | **string** | Filter by external task id. | [optional] 
**TopicName** | **string** | Filter by an external task topic. | [optional] 
**WorkerId** | **string** | Filter by the id of the worker that the task was most recently locked by. | [optional] 
**ErrorMessage** | **string** | Filter by external task exception message. | [optional] 
**ActivityIdIn** | **List&lt;string&gt;** | Only include historic external task logs which belong to one of the passed activity ids. | [optional] 
**ActivityInstanceIdIn** | **List&lt;string&gt;** | Only include historic external task logs which belong to one of the passed activity instance ids. | [optional] 
**ExecutionIdIn** | **List&lt;string&gt;** | Only include historic external task logs which belong to one of the passed execution ids. | [optional] 
**ProcessInstanceId** | **string** | Filter by process instance id. | [optional] 
**ProcessDefinitionId** | **string** | Filter by process definition id. | [optional] 
**ProcessDefinitionKey** | **string** | Filter by process definition key. | [optional] 
**TenantIdIn** | **List&lt;string&gt;** | Only include historic external task log entries which belong to one of the passed and comma-separated tenant ids. | [optional] 
**WithoutTenantId** | **bool?** | Only include historic external task log entries that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**PriorityLowerThanOrEquals** | **long?** | Only include logs for which the associated external task had a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
**PriorityHigherThanOrEquals** | **long?** | Only include logs for which the associated external task had a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
**CreationLog** | **bool?** | Only include creation logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**FailureLog** | **bool?** | Only include failure logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**SuccessLog** | **bool?** | Only include success logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**DeletionLog** | **bool?** | Only include deletion logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Sorting** | [**List&lt;HistoricExternalTaskLogQueryDtoSorting&gt;**](HistoricExternalTaskLogQueryDtoSorting.md) | An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Sorting has no effect for &#x60;count&#x60; endpoints. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

