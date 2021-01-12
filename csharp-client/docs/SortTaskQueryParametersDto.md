# CamundaClient.Model.SortTaskQueryParametersDto
Mandatory when `sortBy` is one of the following values: `processVariable`, `executionVariable`, `taskVariable`, `caseExecutionVariable` or `caseInstanceVariable`. Must be a JSON object with the properties `variable` and `type` where `variable` is a variable name and `type` is the name of a variable value type.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Variable** | **string** | The name of the variable to sort by. | [optional] 
**Type** | **string** | The name of the type of the variable value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

