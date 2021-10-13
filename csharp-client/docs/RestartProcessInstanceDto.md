# Camunda.OpenApi.Client.Model.RestartProcessInstanceDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessInstanceIds** | **List&lt;string&gt;** | A list of process instance ids to restart. | [optional] 
**HistoricProcessInstanceQuery** | [**HistoricProcessInstanceQueryDto**](HistoricProcessInstanceQueryDto.md) |  | [optional] 
**SkipCustomListeners** | **bool?** | Skip execution listener invocation for activities that are started as part of this request. | [optional] 
**SkipIoMappings** | **bool?** | Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started as part of this request. | [optional] 
**InitialVariables** | **bool?** | Set the initial set of variables during restart. By default, the last set of variables is used. | [optional] 
**WithoutBusinessKey** | **bool?** | Do not take over the business key of the historic process instance. | [optional] 
**Instructions** | [**List&lt;RestartProcessInstanceModificationInstructionDto&gt;**](RestartProcessInstanceModificationInstructionDto.md) | **Optional**. A JSON array of instructions that specify which activities to start the process instance at. If this property is omitted, the process instance starts at its default blank start event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

