# CamundaClient.Model.ProcessInstanceDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the process instance. | [optional] 
**DefinitionId** | **string** | The id of the process definition that this process instance belongs to. | [optional] 
**BusinessKey** | **string** | The business key of the process instance. | [optional] 
**CaseInstanceId** | **string** | The id of the case instance associated with the process instance. | [optional] 
**Ended** | **bool** | A flag indicating whether the process instance has ended or not. Deprecated: will always be false! | [optional] 
**Suspended** | **bool** | A flag indicating whether the process instance is suspended or not. | [optional] 
**TenantId** | **string** | The tenant id of the process instance. | [optional] 
**Links** | [**List&lt;AtomLink&gt;**](AtomLink.md) | The links associated to this resource, with &#x60;method&#x60;, &#x60;href&#x60; and &#x60;rel&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

