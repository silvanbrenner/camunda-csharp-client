# Camunda.OpenApi.Client.Model.ModificationDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessDefinitionId** | **string** | The id of the process definition for the modification | [optional] 
**SkipCustomListeners** | **bool?** | Skip execution listener invocation for activities that are started or ended as part of this request. | [optional] 
**SkipIoMappings** | **bool?** | Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started or ended as part of this request. | [optional] 
**ProcessInstanceIds** | **List&lt;string&gt;** | A list of process instance ids to modify. | [optional] 
**ProcessInstanceQuery** | [**ProcessInstanceQueryDto**](ProcessInstanceQueryDto.md) |  | [optional] 
**Instructions** | [**List&lt;MultipleProcessInstanceModificationInstructionDto&gt;**](MultipleProcessInstanceModificationInstructionDto.md) | An array of modification instructions. The instructions are executed in the order they are in.  | [optional] 
**Annotation** | **string** | An arbitrary text annotation set by a user for auditing reasons. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

