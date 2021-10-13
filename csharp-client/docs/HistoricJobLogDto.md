# Camunda.OpenApi.Client.Model.HistoricJobLogDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the log entry. | [optional] 
**Timestamp** | **DateTime?** | The time when the log entry has been written. | [optional] 
**RemovalTime** | **DateTime?** | The time after which the log entry should be removed by the History Cleanup job. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further info see the [docs](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) | [optional] 
**JobId** | **string** | The id of the associated job. | [optional] 
**JobDueDate** | **DateTime?** | The date on which the associated job is supposed to be processed. | [optional] 
**JobRetries** | **int?** | The number of retries the associated job has left. | [optional] 
**JobPriority** | **long?** | The execution priority the job had when the log entry was created. | [optional] 
**JobExceptionMessage** | **string** | The message of the exception that occurred by executing the associated job. | [optional] 
**FailedActivityId** | **string** | The id of the activity on which the last exception occurred by executing the associated job. | [optional] 
**JobDefinitionId** | **string** | The id of the job definition on which the associated job was created. | [optional] 
**JobDefinitionType** | **string** | The job definition type of the associated job. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/the-job-executor/#job-creation) for more information about job definition types. | [optional] 
**JobDefinitionConfiguration** | **string** | The job definition configuration type of the associated job. | [optional] 
**ActivityId** | **string** | The id of the activity on which the associated job was created. | [optional] 
**ExecutionId** | **string** | The execution id on which the associated job was created. | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance on which the associated job was created. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition which the associated job belongs to. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition which the associated job belongs to. | [optional] 
**DeploymentId** | **string** | The id of the deployment which the associated job belongs to. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the process which the associated job belongs to. | [optional] 
**TenantId** | **string** | The id of the tenant that this historic job log entry belongs to. | [optional] 
**Hostname** | **string** |  The name of the host of the Process Engine where the job of this historic job log entry was executed. | [optional] 
**CreationLog** | **bool?** | A flag indicating whether this log represents the creation of the associated job. | [optional] 
**FailureLog** | **bool?** | A flag indicating whether this log represents the failed execution of the associated job. | [optional] 
**SuccessLog** | **bool?** | A flag indicating whether this log represents the successful execution of the associated job. | [optional] 
**DeletionLog** | **bool?** | A flag indicating whether this log represents the deletion of the associated job. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

