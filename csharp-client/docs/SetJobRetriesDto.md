# Camunda.OpenApi.Client.Model.SetJobRetriesDto
Defines the number of retries for a selection of jobs. Please note that if both jobIds and jobQuery are provided, then retries will be set on the union of these sets.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobIds** | **List&lt;string&gt;** | A list of job ids to set retries for. | [optional] 
**JobQuery** | [**JobQueryDto**](JobQueryDto.md) |  | [optional] 
**Retries** | **int?** | An integer representing the number of retries. Please note that the value cannot be negative or null. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

