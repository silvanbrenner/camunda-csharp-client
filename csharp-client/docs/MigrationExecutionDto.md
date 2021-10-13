# Camunda.OpenApi.Client.Model.MigrationExecutionDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MigrationPlan** | [**MigrationPlanDto**](MigrationPlanDto.md) |  | [optional] 
**ProcessInstanceIds** | **List&lt;string&gt;** | A list of process instance ids to migrate. | [optional] 
**ProcessInstanceQuery** | [**ProcessInstanceQueryDto**](ProcessInstanceQueryDto.md) |  | [optional] 
**SkipCustomListeners** | **bool?** | A boolean value to control whether execution listeners should be invoked during migration. | [optional] 
**SkipIoMappings** | **bool?** | A boolean value to control whether input/output mappings should be executed during migration. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

