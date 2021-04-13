# Camunda.OpenApi.Client.Model.TransitionInstanceDto
A JSON object corresponding to the Activity Instance tree of the given process instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the transition instance. | [optional] 
**ParentActivityInstanceId** | **string** | The id of the parent activity instance, for example a sub process instance. | [optional] 
**ActivityId** | **string** | The id of the activity that this instance enters (asyncBefore job) or leaves (asyncAfter job) | [optional] 
**ActivityName** | **string** | The name of the activity that this instance enters (asyncBefore job) or leaves (asyncAfter job) | [optional] 
**ActivityType** | **string** | The type of the activity that this instance enters (asyncBefore job) or leaves (asyncAfter job) | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance this instance is part of. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition. | [optional] 
**ExecutionId** | **string** | The execution id. | [optional] 
**IncidentIds** | **List&lt;string&gt;** | A list of incident ids. | [optional] 
**Incidents** | [**List&lt;ActivityInstanceIncidentDto&gt;**](ActivityInstanceIncidentDto.md) | A list of JSON objects containing incident specific properties: * &#x60;id&#x60;: the id of the incident * &#x60;activityId&#x60;: the activity id in which the incident occurred | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

