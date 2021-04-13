# Camunda.OpenApi.Client.Model.BatchStatisticsDtoAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemainingJobs** | **int?** | The number of remaining batch execution jobs. This does include failed batch execution jobs and batch execution jobs which still have to be created by the seed job. | [optional] 
**CompletedJobs** | **int?** | The number of completed batch execution jobs. This does include aborted/deleted batch execution jobs. | [optional] 
**FailedJobs** | **int?** | The number of failed batch execution jobs. This does not include aborted or deleted batch execution jobs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

