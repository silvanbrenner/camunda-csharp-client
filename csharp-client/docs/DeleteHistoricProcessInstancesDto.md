# Camunda.OpenApi.Client.Model.DeleteHistoricProcessInstancesDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HistoricProcessInstanceIds** | **List&lt;string&gt;** | A list historic process instance ids to delete. | [optional] 
**HistoricProcessInstanceQuery** | [**HistoricProcessInstanceQueryDto**](HistoricProcessInstanceQueryDto.md) |  | [optional] 
**DeleteReason** | **string** | A string with delete reason. | [optional] 
**FailIfNotExists** | **bool?** | If set to &#x60;false&#x60;, the request will still be successful if one ore more of the process ids are not found. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

