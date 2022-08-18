# Camunda.OpenApi.Client.Model.JobDefinitionQueryDto
A Job definition query which defines a list of Job definitions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobDefinitionId** | **string** | Filter by job definition id. | [optional] 
**ActivityIdIn** | **List&lt;string&gt;** | Only include job definitions which belong to one of the passed activity ids. | [optional] 
**ProcessDefinitionId** | **string** | Only include job definitions which exist for the given process definition id. | [optional] 
**ProcessDefinitionKey** | **string** | Only include job definitions which exist for the given process definition key. | [optional] 
**JobType** | **string** | Only include job definitions which exist for the given job type. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/the-job-executor/#job-creation) for more information about job types. | [optional] 
**JobConfiguration** | **string** | Only include job definitions which exist for the given job configuration. For example: for timer jobs it is the timer configuration. | [optional] 
**Active** | **bool?** | Only include active job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Suspended** | **bool?** | Only include suspended job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**WithOverridingJobPriority** | **bool?** | Only include job definitions that have an overriding job priority defined. The only effective value is &#x60;true&#x60;. If set to &#x60;false&#x60;, this filter is not applied. | [optional] 
**TenantIdIn** | **List&lt;string&gt;** | Only include job definitions which belong to one of the passed tenant ids. | [optional] 
**WithoutTenantId** | **bool?** | Only include job definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**IncludeJobDefinitionsWithoutTenantId** | **bool?** | Include job definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Sorting** | [**List&lt;JobDefinitionQueryDtoSorting&gt;**](JobDefinitionQueryDtoSorting.md) | An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Sorting has no effect for &#x60;count&#x60; endpoints. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

