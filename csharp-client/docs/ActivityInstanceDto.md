# CamundaClient.Model.ActivityInstanceDto
A JSON object corresponding to the Activity Instance tree of the given process instance.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the activity instance. | [optional] 
**ParentActivityInstanceId** | **string** | The id of the parent activity instance, for example a sub process instance. | [optional] 
**ActivityId** | **string** | The id of the activity. | [optional] 
**ActivityName** | **string** | The name of the activity | [optional] 
**ActivityType** | **string** | The type of activity (corresponds to the XML element name in the BPMN 2.0, e.g., &#39;userTask&#39;) | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance this activity instance is part of. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition. | [optional] 
**ChildActivityInstances** | [**List&lt;ActivityInstanceDto&gt;**](ActivityInstanceDto.md) | A list of child activity instances. | [optional] 
**ChildTransitionInstances** | [**List&lt;TransitionInstanceDto&gt;**](TransitionInstanceDto.md) | A list of child transition instances. A transition instance represents an execution waiting in an asynchronous continuation. | [optional] 
**ExecutionIds** | **List&lt;string&gt;** | A list of execution ids. | [optional] 
**IncidentIds** | **List&lt;string&gt;** | A list of incident ids. | [optional] 
**Incidents** | [**List&lt;ActivityInstanceIncidentDto&gt;**](ActivityInstanceIncidentDto.md) | A list of JSON objects containing incident specific properties: * &#x60;id&#x60;: the id of the incident * &#x60;activityId&#x60;: the activity id in which the incident occurred | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

