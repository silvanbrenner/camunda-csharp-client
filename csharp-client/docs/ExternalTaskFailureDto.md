# Camunda.OpenApi.Client.Model.ExternalTaskFailureDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkerId** | **string** | The id of the worker that reports the failure. Must match the id of the worker who has most recently locked the task. | [optional] 
**ErrorMessage** | **string** | An message indicating the reason of the failure. | [optional] 
**ErrorDetails** | **string** | A detailed error description. | [optional] 
**Retries** | **int** | A number of how often the task should be retried. Must be &gt;&#x3D; 0. If this is 0, an incident is created and the task cannot be fetched anymore unless the retries are increased again. The incident&#39;s message is set to the &#x60;errorMessage&#x60; parameter. | [optional] 
**RetryTimeout** | **long** | A timeout in milliseconds before the external task becomes available again for fetching. Must be &gt;&#x3D; 0. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

