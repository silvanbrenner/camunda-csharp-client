# Camunda.OpenApi.Client.Model.DeploymentWithDefinitionsDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeployedProcessDefinitions** | [**Dictionary&lt;string, ProcessDefinitionDto&gt;**](ProcessDefinitionDto.md) | A JSON Object containing a property for each of the process definitions, which are successfully deployed with that deployment. The key is the process definition id, the value is a JSON Object corresponding to the process definition. | [optional] 
**DeployedDecisionDefinitions** | [**Dictionary&lt;string, DecisionDefinitionDto&gt;**](DecisionDefinitionDto.md) | A JSON Object containing a property for each of the decision definitions, which are successfully deployed with that deployment. The key is the decision definition id, the value is a JSON Object corresponding to the decision definition. | [optional] 
**DeployedDecisionRequirementsDefinitions** | [**Dictionary&lt;string, DecisionRequirementsDefinitionDto&gt;**](DecisionRequirementsDefinitionDto.md) | A JSON Object containing a property for each of the decision requirements definitions, which are successfully deployed with that deployment. The key is the decision requirements definition id, the value is a JSON Object corresponding to the decision requirements definition. | [optional] 
**DeployedCaseDefinitions** | [**Dictionary&lt;string, CaseDefinitionDto&gt;**](CaseDefinitionDto.md) | A JSON Object containing a property for each of the case definitions, which are successfully deployed with that deployment. The key is the case definition id, the value is a JSON Object corresponding to the case definition. | [optional] 
**Id** | **string** | The id of the deployment. | [optional] 
**TenantId** | **string** | The tenant id of the deployment. | [optional] 
**DeploymentTime** | **DateTime** | The time when the deployment was created. | [optional] 
**Source** | **string** | The source of the deployment. | [optional] 
**Name** | **string** | The name of the deployment. | [optional] 
**Links** | [**List&lt;AtomLink&gt;**](AtomLink.md) | The links associated to this resource, with &#x60;method&#x60;, &#x60;href&#x60; and &#x60;rel&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

