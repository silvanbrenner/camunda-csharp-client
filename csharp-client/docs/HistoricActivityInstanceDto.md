# Camunda.OpenApi.Client.Model.HistoricActivityInstanceDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the activity instance. | [optional] 
**ParentActivityInstanceId** | **string** | The id of the parent activity instance, for example a sub process instance. | [optional] 
**ActivityId** | **string** | The id of the activity that this object is an instance of. | [optional] 
**ActivityName** | **string** | The name of the activity that this object is an instance of. | [optional] 
**ActivityType** | **string** | The type of the activity that this object is an instance of. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition that this activity instance belongs to. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition that this activity instance belongs to. | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance that this activity instance belongs to. | [optional] 
**ExecutionId** | **string** | The id of the execution that executed this activity instance. | [optional] 
**TaskId** | **string** | The id of the task that is associated to this activity instance. Is only set if the activity is a user task. | [optional] 
**Assignee** | **string** | The assignee of the task that is associated to this activity instance. Is only set if the activity is a user task. | [optional] 
**CalledProcessInstanceId** | **string** | The id of the called process instance. Is only set if the activity is a call activity and the called instance a process instance. | [optional] 
**CalledCaseInstanceId** | **string** | The id of the called case instance. Is only set if the activity is a call activity and the called instance a case instance. | [optional] 
**StartTime** | **DateTime?** | The time the instance was started. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
**EndTime** | **DateTime?** | The time the instance ended. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
**DurationInMillis** | **long?** | The time the instance took to finish (in milliseconds). | [optional] 
**Canceled** | **bool?** | If &#x60;true&#x60;, this activity instance is canceled. | [optional] 
**CompleteScope** | **bool?** | If &#x60;true&#x60;, this activity instance did complete a BPMN 2.0 scope. | [optional] 
**TenantId** | **string** | The tenant id of the activity instance. | [optional] 
**RemovalTime** | **DateTime?** | The time after which the activity instance should be removed by the History Cleanup job. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the process containing this activity instance. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

