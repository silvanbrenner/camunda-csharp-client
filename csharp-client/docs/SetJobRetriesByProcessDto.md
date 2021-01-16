# Camunda.OpenApi.Client.Model.SetJobRetriesByProcessDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessInstances** | **List&lt;string&gt;** | A list of process instance ids to fetch jobs, for which retries will be set. | [optional] 
**Retries** | **int?** | An integer representing the number of retries. Please note that the value cannot be negative or null. | [optional] 
**ProcessInstanceQuery** | [**ProcessInstanceQueryDto**](ProcessInstanceQueryDto.md) |  | [optional] 
**HistoricProcessInstanceQuery** | [**HistoricProcessInstanceQueryDto**](HistoricProcessInstanceQueryDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

