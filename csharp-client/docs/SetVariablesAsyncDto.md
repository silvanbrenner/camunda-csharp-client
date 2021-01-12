# CamundaClient.Model.SetVariablesAsyncDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessInstanceIds** | **List&lt;string&gt;** | A list of process instance ids that define a group of process instances to which the operation will set variables.  Please note that if &#x60;processInstanceIds&#x60;, &#x60;processInstanceQuery&#x60; and &#x60;historicProcessInstanceQuery&#x60; are defined, the resulting operation will be performed on the union of these sets. | [optional] 
**ProcessInstanceQuery** | [**ProcessInstanceQueryDto**](ProcessInstanceQueryDto.md) |  | [optional] 
**HistoricProcessInstanceQuery** | [**HistoricProcessInstanceQueryDto**](HistoricProcessInstanceQueryDto.md) |  | [optional] 
**Variables** | [**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md) | A variables the operation will set in the root scope of the process instances. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

