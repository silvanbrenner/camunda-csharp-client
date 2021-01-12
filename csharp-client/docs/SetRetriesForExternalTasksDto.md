# CamundaClient.Model.SetRetriesForExternalTasksDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Retries** | **int?** | The number of retries to set for the external task.  Must be &gt;&#x3D; 0. If this is 0, an incident is created and the task cannot be fetched anymore unless the retries are increased again. Can not be null. | [optional] 
**ExternalTaskIds** | **List&lt;string&gt;** | The ids of the external tasks to set the number of retries for. | [optional] 
**ProcessInstanceIds** | **List&lt;string&gt;** | The ids of process instances containing the tasks to set the number of retries for. | [optional] 
**ExternalTaskQuery** | [**ExternalTaskQueryDto**](ExternalTaskQueryDto.md) |  | [optional] 
**ProcessInstanceQuery** | [**ProcessInstanceQueryDto**](ProcessInstanceQueryDto.md) |  | [optional] 
**HistoricProcessInstanceQuery** | [**HistoricProcessInstanceQueryDto**](HistoricProcessInstanceQueryDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

