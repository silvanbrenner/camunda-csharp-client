# Camunda.OpenApi.Client.Model.JobSuspensionStateDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobDefinitionId** | **string** | The job definition id of the jobs to activate or suspend. | [optional] 
**ProcessDefinitionId** | **string** | The process definition id of the jobs to activate or suspend. | [optional] 
**ProcessInstanceId** | **string** | The process instance id of the jobs to activate or suspend. | [optional] 
**ProcessDefinitionKey** | **string** | The process definition key of the jobs to activate or suspend. | [optional] 
**ProcessDefinitionTenantId** | **string** | Only activate or suspend jobs of a process definition which belongs to a tenant with the given id. Works only when selecting with &#x60;processDefinitionKey&#x60;. | [optional] 
**ProcessDefinitionWithoutTenantId** | **bool?** | Only activate or suspend jobs of a process definition which belongs to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. Works only when selecting with &#x60;processDefinitionKey&#x60;. | [optional] 
**Suspended** | **bool?** | A Boolean value which indicates whether to activate or suspend a given instance  (e.g. process instance, job, job definition, or batch). When the value is set to true,  the given instance will be suspended and when the value is set to false,  the given instance will be activated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

