# Camunda.OpenApi.Client.Model.HistoricVariableInstanceQueryDto
A Historic Variable Instance instance query which defines a list of Historic Variable Instance instances

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VariableName** | **string** | Filter by variable name. | [optional] 
**VariableNameLike** | **string** | Restrict to variables with a name like the parameter. | [optional] 
**VariableValue** | **Object** | Filter by variable value. May be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;. | [optional] 
**VariableNamesIgnoreCase** | **bool?** | Match the variable name provided in &#x60;variableName&#x60; and &#x60;variableNameLike&#x60; case- insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal. | [optional] 
**VariableValuesIgnoreCase** | **bool?** | Match the variable value provided in &#x60;variableValue&#x60; case-insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal. | [optional] 
**VariableTypeIn** | **List&lt;string&gt;** | Only include historic variable instances which belong to one of the passed and comma- separated variable types. A list of all supported variable types can be found [here](https://docs.camunda.org/manual/7.17/user-guide/process-engine/variables/#supported-variable-values). **Note:** All non-primitive variables are associated with the type &#39;serializable&#39;. | [optional] 
**IncludeDeleted** | **bool?** | Include variables that has already been deleted during the execution. | [optional] 
**ProcessInstanceId** | **string** | Filter by the process instance the variable belongs to. | [optional] 
**ProcessInstanceIdIn** | **List&lt;string&gt;** | Only include historic variable instances which belong to one of the passed  process instance ids. | [optional] 
**ProcessDefinitionId** | **string** | Filter by the process definition the variable belongs to. | [optional] 
**ProcessDefinitionKey** | **string** | Filter by a key of the process definition the variable belongs to. | [optional] 
**ExecutionIdIn** | **List&lt;string&gt;** | Only include historic variable instances which belong to one of the passed and  execution ids. | [optional] 
**CaseInstanceId** | **string** | Filter by the case instance the variable belongs to. | [optional] 
**CaseExecutionIdIn** | **List&lt;string&gt;** | Only include historic variable instances which belong to one of the passed and  case execution ids. | [optional] 
**CaseActivityIdIn** | **List&lt;string&gt;** | Only include historic variable instances which belong to one of the passed and  case activity ids. | [optional] 
**TaskIdIn** | **List&lt;string&gt;** | Only include historic variable instances which belong to one of the passed and  task ids. | [optional] 
**ActivityInstanceIdIn** | **List&lt;string&gt;** | Only include historic variable instances which belong to one of the passed and  activity instance ids. | [optional] 
**TenantIdIn** | **List&lt;string&gt;** | Only include historic variable instances which belong to one of the passed and comma- separated tenant ids. | [optional] 
**WithoutTenantId** | **bool?** | Only include historic variable instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**VariableNameIn** | **List&lt;string&gt;** | Only include historic variable instances which belong to one of the passed  variable names. | [optional] 
**Sorting** | [**List&lt;HistoricVariableInstanceQueryDtoSorting&gt;**](HistoricVariableInstanceQueryDtoSorting.md) | An array of criteria to sort the result by. Each element of the array is                      an object that specifies one ordering. The position in the array                      identifies the rank of an ordering, i.e., whether it is primary, secondary,                      etc. Sorting has no effect for &#x60;count&#x60; endpoints | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

