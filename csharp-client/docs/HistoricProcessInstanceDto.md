# Camunda.OpenApi.Client.Model.HistoricProcessInstanceDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the process instance. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the process. | [optional] 
**SuperProcessInstanceId** | **string** | The id of the parent process instance, if it exists. | [optional] 
**SuperCaseInstanceId** | **string** | The id of the parent case instance, if it exists. | [optional] 
**CaseInstanceId** | **string** | The id of the parent case instance, if it exists. | [optional] 
**ProcessDefinitionName** | **string** | The name of the process definition that this process instance belongs to. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition that this process instance belongs to. | [optional] 
**ProcessDefinitionVersion** | **int?** | The version of the process definition that this process instance belongs to. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition that this process instance belongs to. | [optional] 
**BusinessKey** | **string** | The business key of the process instance. | [optional] 
**StartTime** | **DateTime?** | The time the instance was started. Default [format](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**EndTime** | **DateTime?** | The time the instance ended. Default [format](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RemovalTime** | **DateTime?** | The time after which the instance should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**DurationInMillis** | **long?** | The time the instance took to finish (in milliseconds). | [optional] 
**StartUserId** | **string** | The id of the user who started the process instance. | [optional] 
**StartActivityId** | **string** | The id of the initial activity that was executed (e.g., a start event). | [optional] 
**DeleteReason** | **string** | The provided delete reason in case the process instance was canceled during execution. | [optional] 
**TenantId** | **string** | The tenant id of the process instance. | [optional] 
**State** | **string** | Last state of the process instance, possible values are:  &#x60;ACTIVE&#x60; - running process instance  &#x60;SUSPENDED&#x60; - suspended process instances  &#x60;COMPLETED&#x60; - completed through normal end event  &#x60;EXTERNALLY_TERMINATED&#x60; - terminated externally, for instance through REST API  &#x60;INTERNALLY_TERMINATED&#x60; - terminated internally, for instance by terminating boundary event | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

