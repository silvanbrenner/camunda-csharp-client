# Camunda.OpenApi.Client.Model.HistoricIdentityLinkLogDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of the Historic identity link entry. | [optional] 
**Time** | **DateTime?** | The time when the identity link is logged.  [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**Type** | **string** | The type of identity link (candidate/assignee/owner). | [optional] 
**UserId** | **string** | The id of the user/assignee. | [optional] 
**GroupId** | **string** | The id of the group. | [optional] 
**TaskId** | **string** | The id of the task. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition. | [optional] 
**OperationType** | **string** | Type of operation (add/delete). | [optional] 
**AssignerId** | **string** | The id of the assigner. | [optional] 
**TenantId** | **string** | The id of the tenant. | [optional] 
**RemovalTime** | **DateTime?** | The time after which the identity link should be removed by the History Cleanup job.  [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the process containing this identity link. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

