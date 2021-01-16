# Camunda.OpenApi.Client.Model.BatchDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the batch. | [optional] 
**Type** | **string** | The type of the batch. | [optional] 
**TotalJobs** | **int** | The total jobs of a batch is the number of batch execution jobs required to complete the batch. | [optional] 
**JobsCreated** | **int** | The number of batch execution jobs already created by the seed job. | [optional] 
**BatchJobsPerSeed** | **int** | The number of batch execution jobs created per seed job invocation. The batch seed job is invoked until it has created all batch execution jobs required by the batch (see totalJobs property). | [optional] 
**InvocationsPerBatchJob** | **int** | Every batch execution job invokes the command executed by the batch invocationsPerBatchJob times. E.g., for a process instance migration batch this specifies the number of process instances which are migrated per batch execution job. | [optional] 
**SeedJobDefinitionId** | **string** | The job definition id for the seed jobs of this batch. | [optional] 
**MonitorJobDefinitionId** | **string** | The job definition id for the monitor jobs of this batch. | [optional] 
**BatchJobDefinitionId** | **string** | The job definition id for the batch execution jobs of this batch. | [optional] 
**Suspended** | **bool** | Indicates whether this batch is suspended or not. | [optional] 
**TenantId** | **string** | The tenant id of the batch. | [optional] 
**CreateUserId** | **string** | The id of the user that created the batch. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

