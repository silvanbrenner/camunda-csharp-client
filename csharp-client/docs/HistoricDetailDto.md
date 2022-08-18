# Camunda.OpenApi.Client.Model.HistoricDetailDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the historic detail. | [optional] 
**Type** | **string** | The type of the historic detail. Either &#x60;formField&#x60; for a submitted form field value or &#x60;variableUpdate&#x60; for variable updates. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition that this historic detail belongs to. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition that this historic detail belongs to. | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance the historic detail belongs to. | [optional] 
**ActivityInstanceId** | **string** | The id of the activity instance the historic detail belongs to. | [optional] 
**ExecutionId** | **string** | The id of the execution the historic detail belongs to. | [optional] 
**CaseDefinitionKey** | **string** | The key of the case definition that this historic detail belongs to. | [optional] 
**CaseDefinitionId** | **string** | The id of the case definition that this historic detail belongs to. | [optional] 
**CaseInstanceId** | **string** | The id of the case instance the historic detail belongs to. | [optional] 
**CaseExecutionId** | **string** | The id of the case execution the historic detail belongs to. | [optional] 
**TaskId** | **string** | The id of the task the historic detail belongs to. | [optional] 
**TenantId** | **string** | The id of the tenant that this historic detail belongs to. | [optional] 
**UserOperationId** | **string** | The id of user operation which links historic detail with [user operation log](https://docs.camunda.org/manual/7.17/reference/rest/history/user-operation-log/) entries. | [optional] 
**Time** | **DateTime?** | The time when this historic detail occurred. Default [format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RemovalTime** | **DateTime?** | The time after which the historic detail should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the process containing this historic detail. | [optional] 
**FieldId** | **string** | The id of the form field.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;formField&#x60;. | [optional] 
**FieldValue** | **Object** | The submitted form field value. The value differs depending on the form field&#39;s type and on the &#x60;deserializeValue&#x60; parameter.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;formField&#x60;. | [optional] 
**VariableName** | **string** | The name of the variable which has been updated.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;. | [optional] 
**VariableInstanceId** | **string** | The id of the associated variable instance.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;. | [optional] 
**VariableType** | **string** | The value type of the variable.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;. | [optional] 
**Value** | **Object** | The variable&#39;s value. Value differs depending on the variable&#39;s type and on the deserializeValues parameter.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;. | [optional] 
**ValueInfo** | **Dictionary&lt;string, Object&gt;** | A JSON object containing additional, value-type-dependent properties. For variables of type &#x60;Object&#x60;, the following properties are returned:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name. * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;. | [optional] 
**Initial** | **bool?** | Returns &#x60;true&#x60; for variable updates that contains the initial values of the variables.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;. | [optional] 
**Revision** | **int?** | The revision of the historic variable update.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;. | [optional] 
**ErrorMessage** | **string** | An error message in case a Java Serialized Object could not be de-serialized.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

