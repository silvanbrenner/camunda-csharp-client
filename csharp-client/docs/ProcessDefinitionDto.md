# Camunda.OpenApi.Client.Model.ProcessDefinitionDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the process definition | [optional] 
**Key** | **string** | The key of the process definition, i.e., the id of the BPMN 2.0 XML process definition. | [optional] 
**Category** | **string** | The category of the process definition. | [optional] 
**Description** | **string** | The description of the process definition. | [optional] 
**Name** | **string** | The name of the process definition. | [optional] 
**Version** | **int** | The version of the process definition that the engine assigned to it. | [optional] 
**Resource** | **string** | The file name of the process definition. | [optional] 
**DeploymentId** | **string** | The deployment id of the process definition. | [optional] 
**Diagram** | **string** | The file name of the process definition diagram, if it exists. | [optional] 
**Suspended** | **bool** | A flag indicating whether the definition is suspended or not. | [optional] 
**TenantId** | **string** | The tenant id of the process definition. | [optional] 
**VersionTag** | **string** | The version tag of the process definition. | [optional] 
**HistoryTimeToLive** | **int?** | History time to live value of the process definition. Is used within [History cleanup](https://docs.camunda.org/manual/7.14/user-guide/process-engine/history/#history-cleanup). | [optional] 
**StartableInTasklist** | **bool** | A flag indicating whether the process definition is startable in Tasklist or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

