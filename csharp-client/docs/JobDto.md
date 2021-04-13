# Camunda.OpenApi.Client.Model.JobDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the job. | [optional] 
**JobDefinitionId** | **string** | The id of the associated job definition. | [optional] 
**DueDate** | **DateTime?** | The date on which this job is supposed to be processed. | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance which execution created the job. | [optional] 
**ExecutionId** | **string** | The specific execution id on which the job was created. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition which this job belongs to. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition which this job belongs to. | [optional] 
**Retries** | **int?** | The number of retries this job has left. | [optional] 
**ExceptionMessage** | **string** | The message of the exception that occurred, the last time the job was executed. Is null when no exception occurred. | [optional] 
**FailedActivityId** | **string** | The id of the activity on which the last exception occurred, the last time the job was executed. Is null when no exception occurred. | [optional] 
**Suspended** | **bool?** | A flag indicating whether the job is suspended or not. | [optional] 
**Priority** | **long?** | The job&#39;s priority for execution. | [optional] 
**TenantId** | **string** | The id of the tenant which this job belongs to. | [optional] 
**CreateTime** | **DateTime?** | The date on which this job has been created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

