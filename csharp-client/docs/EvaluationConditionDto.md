# Camunda.OpenApi.Client.Model.EvaluationConditionDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Variables** | [**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md) | A map of variables which are used for evaluation of the conditions and are injected into the process instances which have been triggered. Each key is a variable name and each value a JSON variable value object with the following properties. | [optional] 
**BusinessKey** | **string** | Used for the process instances that have been triggered after the evaluation. | [optional] 
**TenantId** | **string** | Used to evaluate a condition for a tenant with the given id. Will only evaluate conditions of process definitions which belong to the tenant. | [optional] 
**WithoutTenantId** | **bool?** | A Boolean value that indicates whether the conditions should only be evaluated of process definitions which belong to no tenant or not. Value may only be true, as false is the default behavior. | [optional] 
**ProcessDefinitionId** | **string** | Used to evaluate conditions of the process definition with the given id. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

