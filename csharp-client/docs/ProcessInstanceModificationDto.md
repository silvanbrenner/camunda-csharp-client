# Camunda.OpenApi.Client.Model.ProcessInstanceModificationDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SkipCustomListeners** | **bool?** | Skip execution listener invocation for activities that are started or ended as part of this request. | [optional] 
**SkipIoMappings** | **bool?** | Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started or ended as part of this request. | [optional] 
**Instructions** | [**List&lt;ProcessInstanceModificationInstructionDto&gt;**](ProcessInstanceModificationInstructionDto.md) | JSON array of modification instructions. The instructions are executed in the order they are in. | [optional] 
**Annotation** | **string** | An arbitrary text annotation set by a user for auditing reasons. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

