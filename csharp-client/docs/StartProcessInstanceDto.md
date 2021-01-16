# Camunda.OpenApi.Client.Model.StartProcessInstanceDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessKey** | **string** | The business key of the process instance. | [optional] 
**Variables** | [**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md) |  | [optional] 
**CaseInstanceId** | **string** | The case instance id the process instance is to be initialized with. | [optional] 
**StartInstructions** | [**List&lt;ProcessInstanceModificationInstructionDto&gt;**](ProcessInstanceModificationInstructionDto.md) | **Optional**. A JSON array of instructions that specify which activities to start the process instance at. If this property is omitted, the process instance starts at its default blank start event. | [optional] 
**SkipCustomListeners** | **bool?** | Skip execution listener invocation for activities that are started or ended as part of this request. **Note**: This option is currently only respected when start instructions are submitted via the &#x60;startInstructions&#x60; property. | [optional] 
**SkipIoMappings** | **bool?** | Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.14/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started or ended as part of this request. **Note**: This option is currently only respected when start instructions are submitted via the &#x60;startInstructions&#x60; property. | [optional] 
**WithVariablesInReturn** | **bool?** | Indicates if the variables, which was used by the process instance during execution, should be returned. Default value: &#x60;false&#x60; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

