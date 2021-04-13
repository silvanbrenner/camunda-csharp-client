# Camunda.OpenApi.Client.Model.ExecutionQueryDto
A Execution instance query which defines a list of Execution instances

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessKey** | **string** | Filter by the business key of the process instances the executions belong to. | [optional] 
**ProcessDefinitionId** | **string** | Filter by the process definition the executions run on. | [optional] 
**ProcessDefinitionKey** | **string** | Filter by the key of the process definition the executions run on. | [optional] 
**ProcessInstanceId** | **string** | Filter by the id of the process instance the execution belongs to. | [optional] 
**ActivityId** | **string** | Filter by the id of the activity the execution currently executes. | [optional] 
**SignalEventSubscriptionName** | **string** | Select only those executions that expect a signal of the given name. | [optional] 
**MessageEventSubscriptionName** | **string** | Select only those executions that expect a message of the given name. | [optional] 
**Active** | **bool?** | Only include active executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Suspended** | **bool?** | Only include suspended executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**IncidentId** | **string** | Filter by the incident id. | [optional] 
**IncidentType** | **string** | Filter by the incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
**IncidentMessage** | **string** | Filter by the incident message. Exact match. | [optional] 
**IncidentMessageLike** | **string** | Filter by the incident message that the parameter is a substring of. | [optional] 
**TenantIdIn** | **List&lt;string&gt;** | Filter by a  list of tenant ids. An execution must have one of the given tenant ids. | [optional] 
**Variables** | [**List&lt;VariableQueryParameterDto&gt;**](VariableQueryParameterDto.md) | An array to only include executions that have variables with certain values.  The array consists of objects with the three properties &#x60;name&#x60;, &#x60;operator&#x60; and &#x60;value&#x60;. &#x60;name (String)&#x60; is the variable name, &#x60;operator (String)&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. &#x60;value&#x60; may be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;. | [optional] 
**ProcessVariables** | [**List&lt;VariableQueryParameterDto&gt;**](VariableQueryParameterDto.md) | An array to only include executions that belong to a process instance with variables with certain values.  The array consists of objects with the three properties &#x60;name&#x60;, &#x60;operator&#x60; and &#x60;value&#x60;. &#x60;name (String)&#x60; is the variable name, &#x60;operator (String)&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. &#x60;value&#x60; may be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to. | [optional] 
**VariableNamesIgnoreCase** | **bool?** | Match all variable names provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal. | [optional] 
**VariableValuesIgnoreCase** | **bool?** | Match all variable values provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal. | [optional] 
**Sorting** | [**List&lt;ExecutionQueryDtoSorting&gt;**](ExecutionQueryDtoSorting.md) | An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Has no effect for the &#x60;/count&#x60; endpoint | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

