# Camunda.OpenApi.Client.Model.HistoricIncidentDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the incident. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition this incident is associated with. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition this incident is associated with. | [optional] 
**ProcessInstanceId** | **string** | The key of the process definition this incident is associated with. | [optional] 
**ExecutionId** | **string** | The id of the execution this incident is associated with. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the process containing this incident. | [optional] 
**CreateTime** | **DateTime?** | The time this incident happened.  [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**EndTime** | **DateTime?** | The time this incident has been deleted or resolved.  [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RemovalTime** | **DateTime?** | The time after which the incident should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**IncidentType** | **string** | The type of incident, for example: &#x60;failedJobs&#x60; will be returned in case of an incident which identified a failed job during the execution of a process instance. See the [User Guide](/manual/develop/user- guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
**ActivityId** | **string** | The id of the activity this incident is associated with. | [optional] 
**FailedActivityId** | **string** | The id of the activity on which the last exception occurred. | [optional] 
**CauseIncidentId** | **string** | The id of the associated cause incident which has been triggered. | [optional] 
**RootCauseIncidentId** | **string** | The id of the associated root cause incident which has been triggered. | [optional] 
**_Configuration** | **string** | The payload of this incident. | [optional] 
**HistoryConfiguration** | **string** | The payload of this incident at the time when it occurred. | [optional] 
**IncidentMessage** | **string** | The message of this incident. | [optional] 
**TenantId** | **string** | The id of the tenant this incident is associated with. | [optional] 
**JobDefinitionId** | **string** | The job definition id the incident is associated with. | [optional] 
**Open** | **bool?** | If true, this incident is open. | [optional] 
**Deleted** | **bool?** | If true, this incident has been deleted. | [optional] 
**Resolved** | **bool?** | If true, this incident has been resolved. | [optional] 
**Annotation** | **string** | The annotation set to the incident. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

