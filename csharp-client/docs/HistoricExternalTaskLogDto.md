# Camunda.OpenApi.Client.Model.HistoricExternalTaskLogDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the log entry. | [optional] 
**ExternalTaskId** | **string** | The id of the external task. | [optional] 
**Timestamp** | **DateTime?** | The time when the log entry has been written. | [optional] 
**TopicName** | **string** | The topic name of the associated external task. | [optional] 
**WorkerId** | **string** | The id of the worker that posessed the most recent lock. | [optional] 
**Retries** | **int?** | The number of retries the associated external task has left. | [optional] 
**Priority** | **long?** | The execution priority the external task had when the log entry was created. | [optional] 
**ErrorMessage** | **string** | The message of the error that occurred by executing the associated external task. | [optional] 
**ActivityId** | **string** | The id of the activity on which the associated external task was created. | [optional] 
**ActivityInstanceId** | **string** | The id of the activity instance on which the associated external task was created. | [optional] 
**ExecutionId** | **string** | The execution id on which the associated external task was created. | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance on which the associated external task was created. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition which the associated external task belongs to. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition which the associated external task belongs to. | [optional] 
**TenantId** | **string** | The id of the tenant that this historic external task log entry belongs to. | [optional] 
**CreationLog** | **bool?** | A flag indicating whether this log represents the creation of the associated external task. | [optional] 
**FailureLog** | **bool?** | A flag indicating whether this log represents the failed execution of the associated external task. | [optional] 
**SuccessLog** | **bool?** | A flag indicating whether this log represents the successful execution of the associated external task. | [optional] 
**DeletionLog** | **bool?** | A flag indicating whether this log represents the deletion of the associated external task. | [optional] 
**RemovalTime** | **DateTime?** | The time after which this log should be removed by the History Cleanup job. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.  For further information, please see the [documentation](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the process containing this log. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

