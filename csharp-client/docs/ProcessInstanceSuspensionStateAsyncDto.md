# CamundaClient.Model.ProcessInstanceSuspensionStateAsyncDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Suspended** | **bool?** | A Boolean value which indicates whether to activate or suspend a given process instance. When the value is set to true, the given process instance will be suspended and when the value is set to false, the given process instance will be activated. | [optional] 
**ProcessInstanceIds** | **List&lt;string&gt;** | A list of process instance ids which defines a group of process instances which will be activated or suspended by the operation. | [optional] 
**ProcessInstanceQuery** | [**ProcessInstanceQueryDto**](ProcessInstanceQueryDto.md) |  | [optional] 
**HistoricProcessInstanceQuery** | [**HistoricProcessInstanceQueryDto**](HistoricProcessInstanceQueryDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

