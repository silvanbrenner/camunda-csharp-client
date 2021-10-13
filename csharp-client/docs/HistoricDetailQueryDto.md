# Camunda.OpenApi.Client.Model.HistoricDetailQueryDto
A historic detail query which defines a group of historic details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessInstanceId** | **string** | Filter by process instance id. | [optional] 
**ProcessInstanceIdIn** | **List&lt;string&gt;** | Only include historic details which belong to one of the passed  process instance ids. | [optional] 
**ExecutionId** | **string** | Filter by execution id. | [optional] 
**TaskId** | **string** | Filter by task id. | [optional] 
**ActivityInstanceId** | **string** | Filter by activity instance id. | [optional] 
**CaseInstanceId** | **string** | Filter by case instance id. | [optional] 
**CaseExecutionId** | **string** | Filter by case execution id. | [optional] 
**VariableInstanceId** | **string** | Filter by variable instance id. | [optional] 
**VariableTypeIn** | **List&lt;string&gt;** | Only include historic details where the variable updates belong to one of the passed  list of variable types. A list of all supported variable types can be found [here](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#supported-variable-values). **Note:** All non-primitive variables are associated with the type &#x60;serializable&#x60;. | [optional] 
**TenantIdIn** | **List&lt;string&gt;** | Filter by a  list of tenant ids. | [optional] 
**WithoutTenantId** | **bool?** | Only include historic details that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**UserOperationId** | **string** | Filter by a user operation id. | [optional] 
**FormFields** | **bool?** | Only include &#x60;HistoricFormFields&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**VariableUpdates** | **bool?** | Only include &#x60;HistoricVariableUpdates&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**ExcludeTaskDetails** | **bool?** | Excludes all task-related &#x60;HistoricDetails&#x60;, so only items which have no task id set will be selected. When this parameter is used together with &#x60;taskId&#x60;, this call is ignored and task details are not excluded. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Initial** | **bool?** | Restrict to historic variable updates that contain only initial variable values. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**OccurredBefore** | **DateTime?** | Restrict to historic details that occured before the given date (including the date). Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., 2013-01-23T14:42:45.000+0200. | [optional] 
**OccurredAfter** | **DateTime?** | Restrict to historic details that occured after the given date (including the date). Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., 2013-01-23T14:42:45.000+0200. | [optional] 
**Sorting** | [**List&lt;HistoricDetailQueryDtoSorting&gt;**](HistoricDetailQueryDtoSorting.md) | A JSON array of criteria to sort the result by. Each element of the array is                     a JSON object that specifies one ordering. The position in the array                     identifies the rank of an ordering, i.e., whether it is primary, secondary,                     etc. Does not have an effect for the &#x60;count&#x60; endpoint. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

