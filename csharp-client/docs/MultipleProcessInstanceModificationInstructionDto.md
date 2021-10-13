# Camunda.OpenApi.Client.Model.MultipleProcessInstanceModificationInstructionDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | **Mandatory**. One of the following values: &#x60;cancel&#x60;, &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A cancel instruction requests cancellation of a single activity instance or all instances of one activity. * A startBeforeActivity instruction requests to enter a given activity. * A startAfterActivity instruction requests to execute the single outgoing sequence flow of a given activity. * A startTransition instruction requests to execute a specific sequence flow. | 
**ActivityId** | **string** | Can be used with instructions of types &#x60;startTransition&#x60;. Specifies the sequence flow to start. | [optional] 
**TransitionId** | **string** | Can be used with instructions of types &#x60;startTransition&#x60;. Specifies the sequence flow to start. | [optional] 
**CancelCurrentActiveActivityInstances** | **bool?** | Can be used with instructions of type cancel. Prevents the deletion of new created activity instances. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

