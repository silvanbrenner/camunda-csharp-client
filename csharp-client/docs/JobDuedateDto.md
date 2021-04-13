# Camunda.OpenApi.Client.Model.JobDuedateDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Duedate** | **DateTime?** | The date to set when the job has the next execution. | [optional] 
**Cascade** | **bool?** | A boolean value to indicate if modifications to the due date should cascade to subsequent jobs. (e.g. Modify the due date of a timer by +15 minutes. This flag indicates if a +15 minutes should be applied to all subsequent timers.) This flag only affects timer jobs and only works if due date is not null. Default: &#x60;false&#x60; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

