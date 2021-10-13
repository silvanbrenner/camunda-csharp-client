# Camunda.OpenApi.Client.Model.MigrationPlanReportDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstructionReports** | [**List&lt;MigrationInstructionValidationReportDto&gt;**](MigrationInstructionValidationReportDto.md) | The list of instruction validation reports. If no validation errors are detected it is an empty list. | [optional] 
**VariableReports** | [**Dictionary&lt;string, MigrationVariableValidationReportDto&gt;**](MigrationVariableValidationReportDto.md) | A map of variable reports. Each key is a variable name and each value a JSON object consisting of the variable&#39;s type, value, value info object and a list of failures. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

