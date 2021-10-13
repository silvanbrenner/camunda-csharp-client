# Camunda.OpenApi.Client.Model.MigrationPlanDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceProcessDefinitionId** | **string** | The id of the source process definition for the migration. | [optional] 
**TargetProcessDefinitionId** | **string** | The id of the target process definition for the migration. | [optional] 
**Instructions** | [**List&lt;MigrationInstructionDto&gt;**](MigrationInstructionDto.md) | A list of migration instructions which map equal activities. Each migration instruction is a JSON object with the following properties: | [optional] 
**Variables** | [**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md) | A map of variables which will be set into the process instances&#39; scope. Each key is a variable name and each value a JSON variable value object. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

