# Camunda.OpenApi.Client.Model.DeleteProcessInstancesDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessInstanceIds** | **List&lt;string&gt;** | A list process instance ids to delete. | [optional] 
**DeleteReason** | **string** | A string with delete reason. | [optional] 
**SkipCustomListeners** | **bool?** | Skip execution listener invocation for activities that are started or ended as part of this request. | [optional] 
**SkipSubprocesses** | **bool?** | Skip deletion of the subprocesses related to deleted processes as part of this request. | [optional] 
**ProcessInstanceQuery** | [**ProcessInstanceQueryDto**](ProcessInstanceQueryDto.md) |  | [optional] 
**HistoricProcessInstanceQuery** | [**HistoricProcessInstanceQueryDto**](HistoricProcessInstanceQueryDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

