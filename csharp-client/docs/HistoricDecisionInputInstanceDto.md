# Camunda.OpenApi.Client.Model.HistoricDecisionInputInstanceDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the decision input value. | [optional] 
**DecisionInstanceId** | **string** | The id of the decision instance the input value belongs to. | [optional] 
**ClauseId** | **string** | The id of the clause the input value belongs to. | [optional] 
**ClauseName** | **string** | The name of the clause the input value belongs to. | [optional] 
**ErrorMessage** | **string** | An error message in case a Java Serialized Object could not be de-serialized. | [optional] 
**Type** | **string** | The value type of the variable. | [optional] 
**CreateTime** | **DateTime?** | The time the variable was inserted.  [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RemovalTime** | **DateTime?** | The time after which the entry should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the process containing this entry. | [optional] 
**Value** | **Object** | The variable&#39;s value. Value differs depending on the variable&#39;s type and on the &#x60;disableCustomObjectDeserialization&#x60; parameter. | [optional] 
**ValueInfo** | **Dictionary&lt;string, Object&gt;** | A JSON object containing additional, value-type-dependent properties.  For variables of type &#x60;Object&#x60;, the following properties are returned:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name.  * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

