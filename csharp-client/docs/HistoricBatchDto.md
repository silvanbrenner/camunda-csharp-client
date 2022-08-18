# Camunda.OpenApi.Client.Model.HistoricBatchDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the batch. | [optional] 
**Type** | **string** | The type of the batch. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types. | [optional] 
**TotalJobs** | **int?** |  The total jobs of a batch is the number of batch execution jobs required to complete the batch.  | [optional] 
**BatchJobsPerSeed** | **int?** |  The number of batch execution jobs created per seed job invocation. The batch seed job is invoked until it has created all batch execution jobs required by the batch (see &#x60;totalJobs&#x60; property).  | [optional] 
**InvocationsPerBatchJob** | **int?** |  Every batch execution job invokes the command executed by the batch &#x60;invocationsPerBatchJob&#x60; times. E.g., for a process instance migration batch this specifies the number of process instances which are migrated per batch execution job.  | [optional] 
**SeedJobDefinitionId** | **string** | The job definition id for the seed jobs of this batch. | [optional] 
**MonitorJobDefinitionId** | **string** | The job definition id for the monitor jobs of this batch. | [optional] 
**BatchJobDefinitionId** | **string** | The job definition id for the batch execution jobs of this batch. | [optional] 
**TenantId** | **string** | The tenant id of the batch. | [optional] 
**CreateUserId** | **string** | The batch creator&#39;s user id. | [optional] 
**StartTime** | **DateTime?** | The time the batch was started. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) | [optional] 
**EndTime** | **DateTime?** | The time the batch ended. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) | [optional] 
**RemovalTime** | **DateTime?** | The time after which the historic batch should be removed by the History Cleanup job. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

