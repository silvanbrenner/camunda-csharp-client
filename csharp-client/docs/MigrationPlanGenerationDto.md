# Camunda.OpenApi.Client.Model.MigrationPlanGenerationDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceProcessDefinitionId** | **string** | The id of the source process definition for the migration. | [optional] 
**TargetProcessDefinitionId** | **string** | The id of the target process definition for the migration. | [optional] 
**UpdateEventTriggers** | **bool?** | A boolean flag indicating whether instructions between events should be configured to update the event triggers. | [optional] 
**Variables** | [**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md) | A map of variables which will be set into the process instances&#39; scope. Each key is a variable name and each value a JSON variable value object. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

