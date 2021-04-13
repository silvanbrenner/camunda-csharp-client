# Camunda.OpenApi.Client.Model.BatchStatisticsDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemainingJobs** | **int?** | The number of remaining batch execution jobs. This does include failed batch execution jobs and batch execution jobs which still have to be created by the seed job. | [optional] 
**CompletedJobs** | **int?** | The number of completed batch execution jobs. This does include aborted/deleted batch execution jobs. | [optional] 
**FailedJobs** | **int?** | The number of failed batch execution jobs. This does not include aborted or deleted batch execution jobs. | [optional] 
**Id** | **string** | The id of the batch. | [optional] 
**Type** | **string** | The type of the batch. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types. | [optional] 
**TotalJobs** | **int?** | The total jobs of a batch is the number of batch execution jobs required to complete the batch. | [optional] 
**JobsCreated** | **int?** | The number of batch execution jobs already created by the seed job. | [optional] 
**BatchJobsPerSeed** | **int?** | The number of batch execution jobs created per seed job invocation. The batch seed job is invoked until it has created all batch execution jobs required by the batch (see &#x60;totalJobs&#x60; property). | [optional] 
**InvocationsPerBatchJob** | **int?** | Every batch execution job invokes the command executed by the batch &#x60;invocationsPerBatchJob&#x60; times. E.g., for a process instance migration batch this specifies the number of process instances which are migrated per batch execution job. | [optional] 
**SeedJobDefinitionId** | **string** | The job definition id for the seed jobs of this batch. | [optional] 
**MonitorJobDefinitionId** | **string** | The job definition id for the monitor jobs of this batch. | [optional] 
**BatchJobDefinitionId** | **string** | The job definition id for the batch execution jobs of this batch. | [optional] 
**Suspended** | **bool?** | Indicates whether this batch is suspended or not. | [optional] 
**TenantId** | **string** | The tenant id of the batch. | [optional] 
**CreateUserId** | **string** | The id of the user that created the batch. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

