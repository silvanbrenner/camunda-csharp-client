# Camunda.OpenApi.Client.Model.IncidentDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the incident. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition this incident is associated with. | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance this incident is associated with. | [optional] 
**ExecutionId** | **string** | The id of the execution this incident is associated with. | [optional] 
**IncidentTimestamp** | **DateTime?** | The time this incident happened. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
**IncidentType** | **string** | The type of incident, for example: &#x60;failedJobs&#x60; will be returned in case of an incident which identified a failed job during the execution of a process instance. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
**ActivityId** | **string** | The id of the activity this incident is associated with. | [optional] 
**FailedActivityId** | **string** | The id of the activity on which the last exception occurred. | [optional] 
**CauseIncidentId** | **string** | The id of the associated cause incident which has been triggered. | [optional] 
**RootCauseIncidentId** | **string** | The id of the associated root cause incident which has been triggered. | [optional] 
**_Configuration** | **string** | The payload of this incident. | [optional] 
**TenantId** | **string** | The id of the tenant this incident is associated with. | [optional] 
**IncidentMessage** | **string** | The message of this incident. | [optional] 
**JobDefinitionId** | **string** | The job definition id the incident is associated with. | [optional] 
**Annotation** | **string** | The annotation set to the incident. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

