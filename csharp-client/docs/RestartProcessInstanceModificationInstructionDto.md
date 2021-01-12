# CamundaClient.Model.RestartProcessInstanceModificationInstructionDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | **Mandatory**. One of the following values: &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A &#x60;startBeforeActivity&#x60; instruction requests to enter a given activity. * A &#x60;startAfterActivity&#x60; instruction requests to execute the single outgoing sequence flow of a given activity. * A &#x60;startTransition&#x60; instruction requests to execute a specific sequence flow. | 
**ActivityId** | **string** | **Can be used with instructions of types** &#x60;startBeforeActivity&#x60; and &#x60;startAfterActivity&#x60;. Specifies the sequence flow to start. | [optional] 
**TransitionId** | **string** | **Can be used with instructions of types** &#x60;startTransition&#x60;. Specifies the sequence flow to start. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

