# Camunda.OpenApi.Client.Model.HistoricJobLogQueryDto
A Historic Job Log instance query which defines a list of Historic Job Log instances

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LogId** | **string** | Filter by historic job log id. | [optional] 
**JobId** | **string** | Filter by job id. | [optional] 
**JobExceptionMessage** | **string** | Filter by job exception message. | [optional] 
**JobDefinitionId** | **string** | Filter by job definition id. | [optional] 
**JobDefinitionType** | **string** | Filter by job definition type. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/the-job-executor/#job-creation) for more information about job definition types. | [optional] 
**JobDefinitionConfiguration** | **string** | Filter by job definition configuration. | [optional] 
**ActivityIdIn** | **List&lt;string&gt;** | Only include historic job logs which belong to one of the passed activity ids. | [optional] 
**FailedActivityIdIn** | **List&lt;string&gt;** | Only include historic job logs which belong to failures of one of the passed activity ids. | [optional] 
**ExecutionIdIn** | **List&lt;string&gt;** | Only include historic job logs which belong to one of the passed execution ids. | [optional] 
**ProcessInstanceId** | **string** | Filter by process instance id. | [optional] 
**ProcessDefinitionId** | **string** | Filter by process definition id. | [optional] 
**ProcessDefinitionKey** | **string** | Filter by process definition key. | [optional] 
**DeploymentId** | **string** | Filter by deployment id. | [optional] 
**TenantIdIn** | **List&lt;string&gt;** | Only include historic job log entries which belong to one of the passed and comma- separated tenant ids. | [optional] 
**WithoutTenantId** | **bool?** | Only include historic job log entries that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Hostname** | **string** | Filter by hostname. | [optional] 
**JobPriorityLowerThanOrEquals** | **long?** | Only include logs for which the associated job had a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
**JobPriorityHigherThanOrEquals** | **long?** | Only include logs for which the associated job had a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
**CreationLog** | **bool?** | Only include creation logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**FailureLog** | **bool?** | Only include failure logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**SuccessLog** | **bool?** | Only include success logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**DeletionLog** | **bool?** | Only include deletion logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Sorting** | [**List&lt;HistoricJobLogQueryDtoSorting&gt;**](HistoricJobLogQueryDtoSorting.md) | An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Sorting has no effect for &#x60;count&#x60; endpoints | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

