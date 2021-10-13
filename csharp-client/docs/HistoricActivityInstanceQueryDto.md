# Camunda.OpenApi.Client.Model.HistoricActivityInstanceQueryDto
A historic activity instance query which defines a group of historic activity instances

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityInstanceId** | **string** | Filter by activity instance id. | [optional] 
**ProcessInstanceId** | **string** | Filter by process instance id. | [optional] 
**ProcessDefinitionId** | **string** | Filter by process definition id. | [optional] 
**ExecutionId** | **string** | Filter by the id of the execution that executed the activity instance. | [optional] 
**ActivityId** | **string** | Filter by the activity id (according to BPMN 2.0 XML). | [optional] 
**ActivityName** | **string** | Filter by the activity name (according to BPMN 2.0 XML). | [optional] 
**ActivityType** | **string** | Filter by activity type. | [optional] 
**TaskAssignee** | **string** | Only include activity instances that are user tasks and assigned to a given user. | [optional] 
**Finished** | **bool?** | Only include finished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
**Unfinished** | **bool?** | Only include unfinished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
**Canceled** | **bool?** | Only include canceled activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
**CompleteScope** | **bool?** | Only include activity instances which completed a scope. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set. | [optional] 
**StartedBefore** | **DateTime?** | Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
**StartedAfter** | **DateTime?** | Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
**FinishedBefore** | **DateTime?** | Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
**FinishedAfter** | **DateTime?** | Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
**TenantIdIn** | **List&lt;string&gt;** | Must be a JSON array of Strings. An activity instance must have one of the given tenant ids. | [optional] 
**WithoutTenantId** | **bool?** | Only include historic activity instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Sorting** | [**List&lt;HistoricActivityInstanceQueryDtoSorting&gt;**](HistoricActivityInstanceQueryDtoSorting.md) | Apply sorting of the result | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

