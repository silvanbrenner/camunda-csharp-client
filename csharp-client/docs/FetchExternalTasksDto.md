# Camunda.OpenApi.Client.Model.FetchExternalTasksDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkerId** | **string** | **Mandatory.** The id of the worker on which behalf tasks are fetched. The returned tasks are locked for that worker and can only be completed when providing the same worker id. | 
**MaxTasks** | **int?** | **Mandatory.** The maximum number of tasks to return. | 
**UsePriority** | **bool?** | A &#x60;boolean&#x60; value, which indicates whether the task should be fetched based on its priority or arbitrarily. | [optional] 
**AsyncResponseTimeout** | **long?** | The [Long Polling](https://docs.camunda.org/manual/7.14/user-guide/process-engine/external-tasks/#long-polling-to-fetch-and-lock-external-tasks) timeout in milliseconds.  **Note:** The value cannot be set larger than 1.800.000 milliseconds (corresponds to 30 minutes). | [optional] 
**Topics** | [**List&lt;FetchExternalTaskTopicDto&gt;**](FetchExternalTaskTopicDto.md) | A JSON array of topic objects for which external tasks should be fetched. The returned tasks may be arbitrarily distributed among these topics. Each topic object has the following properties: | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

