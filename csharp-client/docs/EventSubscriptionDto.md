# Camunda.OpenApi.Client.Model.EventSubscriptionDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the event subscription. | [optional] 
**EventType** | **string** | The type of the event subscription. | [optional] 
**EventName** | **string** | The name of the event this subscription belongs to as defined in the process model. | [optional] 
**ExecutionId** | **string** | The execution that is subscribed on the referenced event. | [optional] 
**ProcessInstanceId** | **string** | The process instance this subscription belongs to. | [optional] 
**ActivityId** | **string** | The identifier of the activity that this event subscription belongs to. This could for example be the id of a receive task. | [optional] 
**CreatedDate** | **DateTime?** | The time this event subscription was created. | [optional] 
**TenantId** | **string** | The id of the tenant this event subscription belongs to. Can be &#x60;null&#x60; if the subscription belongs to no single tenant. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

