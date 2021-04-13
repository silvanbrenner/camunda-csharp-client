# Camunda.OpenApi.Client.Model.JobQueryDto
A Job instance query which defines a list of Job instances

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobId** | **string** | Filter by job id. | [optional] 
**JobIds** | **List&lt;string&gt;** | Filter by a  list of job ids. | [optional] 
**JobDefinitionId** | **string** | Only select jobs which exist for the given job definition. | [optional] 
**ProcessInstanceId** | **string** | Only select jobs which exist for the given process instance. | [optional] 
**ProcessInstanceIds** | **List&lt;string&gt;** | Only select jobs which exist for the given  list of process instance ids. | [optional] 
**ExecutionId** | **string** | Only select jobs which exist for the given execution. | [optional] 
**ProcessDefinitionId** | **string** | Filter by the id of the process definition the jobs run on. | [optional] 
**ProcessDefinitionKey** | **string** | Filter by the key of the process definition the jobs run on. | [optional] 
**ActivityId** | **string** | Only select jobs which exist for an activity with the given id. | [optional] 
**WithRetriesLeft** | **bool?** | Only select jobs which have retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Executable** | **bool?** | Only select jobs which are executable, i.e., retries &gt; 0 and due date is &#x60;null&#x60; or due date is in the past. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Timers** | **bool?** | Only select jobs that are timers. Cannot be used together with &#x60;messages&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Messages** | **bool?** | Only select jobs that are messages. Cannot be used together with &#x60;timers&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**DueDates** | [**List&lt;JobConditionQueryParameterDto&gt;**](JobConditionQueryParameterDto.md) | Only select jobs where the due date is lower or higher than the given date.  | [optional] 
**CreateTimes** | [**List&lt;JobConditionQueryParameterDto&gt;**](JobConditionQueryParameterDto.md) | Only select jobs created before or after the given date.  | [optional] 
**WithException** | **bool?** | Only select jobs that failed due to an exception. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**ExceptionMessage** | **string** | Only select jobs that failed due to an exception with the given message. | [optional] 
**FailedActivityId** | **string** | Only select jobs that failed due to an exception at an activity with the given id. | [optional] 
**NoRetriesLeft** | **bool?** | Only select jobs which have no retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Active** | **bool?** | Only include active jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Suspended** | **bool?** | Only include suspended jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**PriorityLowerThanOrEquals** | **long?** | Only include jobs with a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
**PriorityHigherThanOrEquals** | **long?** | Only include jobs with a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value. | [optional] 
**TenantIdIn** | **List&lt;string&gt;** | Only include jobs which belong to one of the passed  tenant ids. | [optional] 
**WithoutTenantId** | **bool?** | Only include jobs which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**IncludeJobsWithoutTenantId** | **bool?** | Include jobs which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**Sorting** | [**List&lt;JobQueryDtoSorting&gt;**](JobQueryDtoSorting.md) | An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Does not have an effect for the &#x60;count&#x60; endpoint. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

