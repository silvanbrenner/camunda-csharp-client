# Camunda.OpenApi.Client.Model.ExternalTaskBpmnError
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkerId** | **string** | The id of the worker that reports the failure. Must match the id of the worker who has most recently locked the task. | [optional] 
**ErrorCode** | **string** | An error code that indicates the predefined error. It is used to identify the BPMN error handler. | [optional] 
**ErrorMessage** | **string** | An error message that describes the error. | [optional] 
**Variables** | [**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md) | A JSON object containing variable key-value pairs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

