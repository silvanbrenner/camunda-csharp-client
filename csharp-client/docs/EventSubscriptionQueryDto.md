# Camunda.OpenApi.Client.Model.EventSubscriptionQueryDto
A event subscription query which retrieves a list of event subscriptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventSubscriptionId** | **string** | The id of the event subscription. | [optional] 
**EventName** | **string** | The name of the event this subscription belongs to as defined in the process model. | [optional] 
**EventType** | **string** | The type of the event subscription. | [optional] 
**ExecutionId** | **string** | The execution that is subscribed on the referenced event. | [optional] 
**ProcessInstanceId** | **string** | The process instance this subscription belongs to. | [optional] 
**ActivityId** | **string** | The identifier of the activity that this event subscription belongs to. This could for example be the id of a receive task. | [optional] 
**TenantIdIn** | **List&lt;string&gt;** | Filter by a comma-separated list of tenant ids. Only select subscriptions that belong to one of the given tenant ids. | [optional] 
**WithoutTenantId** | **bool?** | Only select subscriptions which have no tenant id. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**IncludeEventSubscriptionsWithoutTenantId** | **bool?** | Select event subscriptions which have no tenant id. Can be used in combination with tenantIdIn parameter. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Sorting** | [**List&lt;EventSubscriptionQueryDtoSorting&gt;**](EventSubscriptionQueryDtoSorting.md) | Apply sorting of the result | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

