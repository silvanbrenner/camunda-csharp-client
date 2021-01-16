# Camunda.OpenApi.Client.Model.FetchExternalTaskTopicDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TopicName** | **string** | **Mandatory.** The topic&#39;s name. | 
**LockDuration** | **long?** | **Mandatory.** The duration to lock the external tasks for in milliseconds. | 
**Variables** | **List&lt;string&gt;** | A JSON array of &#x60;String&#x60; values that represent variable names. For each result task belonging to this topic, the given variables are returned as well if they are accessible from the external task&#39;s execution. If not provided - all variables will be fetched. | [optional] 
**LocalVariables** | **bool?** | If &#x60;true&#x60; only local variables will be fetched. | [optional] [default to false]
**BusinessKey** | **string** | A &#x60;String&#x60; value which enables the filtering of tasks based on process instance business key. | [optional] 
**ProcessDefinitionId** | **string** | Filter tasks based on process definition id. | [optional] 
**ProcessDefinitionIdIn** | **List&lt;string&gt;** | Filter tasks based on process definition ids. | [optional] 
**ProcessDefinitionKey** | **string** | Filter tasks based on process definition key. | [optional] 
**ProcessDefinitionKeyIn** | **List&lt;string&gt;** | Filter tasks based on process definition keys. | [optional] 
**ProcessDefinitionVersionTag** | **string** | Filter tasks based on process definition version tag. | [optional] 
**WithoutTenantId** | **bool?** | Filter tasks without tenant id. | [optional] [default to false]
**TenantIdIn** | **List&lt;string&gt;** | Filter tasks based on tenant ids. | [optional] 
**ProcessVariables** | **Dictionary&lt;string, Object&gt;** | A &#x60;JSON&#x60; object used for filtering tasks based on process instance variable values. A property name of the object represents a process variable name, while the property value represents the process variable value to filter tasks by. | [optional] 
**DeserializeValues** | **bool?** | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;false&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML. | [optional] [default to false]
**IncludeExtensionProperties** | **bool?** | Determines whether custom extension properties defined in the BPMN activity of the external task (e.g. via the Extensions tab in the Camunda modeler) should be included in the response. Default: false | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

