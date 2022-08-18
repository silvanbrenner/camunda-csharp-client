# Camunda.OpenApi.Client.Model.ProcessDefinitionSuspensionStateDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Suspended** | **bool?** | A &#x60;Boolean&#x60; value which indicates whether to activate or suspend all process definitions with the given key. When the value is set to &#x60;true&#x60;, all process definitions with the given key will be suspended and when the value is set to &#x60;false&#x60;, all process definitions with the given key will be activated. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definitions to activate or suspend. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definitions to activate or suspend. | [optional] 
**IncludeProcessInstances** | **bool?** | A &#x60;Boolean&#x60; value which indicates whether to activate or suspend also all process instances of  the process definitions with the given key. When the value is set to &#x60;true&#x60;, all process instances of the process definitions with the given key will be activated or suspended and when the value is set to &#x60;false&#x60;, the suspension state of  all process instances of the process definitions with the given key will not be updated. | [optional] 
**ExecutionDate** | **DateTime?** | The date on which all process definitions with the given key will be activated or suspended. If &#x60;null&#x60;, the suspension state of all process definitions with the given key is updated immediately. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

