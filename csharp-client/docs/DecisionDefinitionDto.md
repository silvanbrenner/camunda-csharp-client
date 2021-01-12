# CamundaClient.Model.DecisionDefinitionDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the decision definition | [optional] 
**Key** | **string** | The key of the decision definition, i.e., the id of the DMN 1.0 XML decision definition. | [optional] 
**Category** | **string** | The category of the decision definition. | [optional] 
**Name** | **string** | The name of the decision definition. | [optional] 
**Version** | **int** | The version of the decision definition that the engine assigned to it. | [optional] 
**Resource** | **string** | The file name of the decision definition. | [optional] 
**DeploymentId** | **string** | The deployment id of the decision definition. | [optional] 
**TenantId** | **string** | The tenant id of the decision definition. | [optional] 
**DecisionRequirementsDefinitionId** | **string** | The id of the decision requirements definition this decision definition belongs to. | [optional] 
**DecisionRequirementsDefinitionKey** | **string** | The key of the decision requirements definition this decision definition belongs to. | [optional] 
**HistoryTimeToLive** | **int?** | History time to live value of the decision definition. Is used within [History cleanup](https://docs.camunda.org/manual/7.14/user-guide/process-engine/history/#history-cleanup). | [optional] 
**VersionTag** | **string** | The version tag of the decision definition. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

