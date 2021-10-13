# Camunda.OpenApi.Client.Model.HistoricTaskInstanceReportResultDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskName** | **string** | The name of the task. It is only available when the &#x60;groupBy&#x60; parameter is set to &#x60;taskName&#x60;. Else the value is &#x60;null&#x60;.  **Note:** This property is only set for a historic task report object. In these cases, the value of the &#x60;reportType&#x60; query parameter is &#x60;count&#x60;. | [optional] 
**Count** | **long?** | The number of tasks which have the given definition.  **Note:** This property is only set for a historic task report object. In these cases, the value of the &#x60;reportType&#x60; query parameter is &#x60;count&#x60;. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition.  **Note:** This property is only set for a historic task report object. In these cases, the value of the &#x60;reportType&#x60; query parameter is &#x60;count&#x60;. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition.  **Note:** This property is only set for a historic task report object. In these cases, the value of the &#x60;reportType&#x60; query parameter is &#x60;count&#x60;. | [optional] 
**ProcessDefinitionName** | **string** | The name of the process definition.  **Note:** This property is only set for a historic task report object. In these cases, the value of the &#x60;reportType&#x60; query parameter is &#x60;count&#x60;. | [optional] 
**Period** | **int?** | Specifies a span of time within a year. **Note:** The period must be interpreted in conjunction with the returned &#x60;periodUnit&#x60;.  **Note:** This property is only set for a duration report object. In these cases, the value of the &#x60;reportType&#x60; query parameter is &#x60;duration&#x60;. | [optional] 
**PeriodUnit** | **string** | The unit of the given period. Possible values are &#x60;MONTH&#x60; and &#x60;QUARTER&#x60;.  **Note:** This property is only set for a duration report object. In these cases, the value of the &#x60;reportType&#x60; query parameter is &#x60;duration&#x60;. | [optional] 
**Minimum** | **long?** | The smallest duration in milliseconds of all completed process instances which were started in the given period.  **Note:** This property is only set for a duration report object. In these cases, the value of the &#x60;reportType&#x60; query parameter is &#x60;duration&#x60;. | [optional] 
**Maximum** | **long?** | The greatest duration in milliseconds of all completed process instances which were started in the given period.  **Note:** This property is only set for a duration report object. In these cases, the value of the &#x60;reportType&#x60; query parameter is &#x60;duration&#x60;. | [optional] 
**Average** | **long?** | The average duration in milliseconds of all completed process instances which were started in the given period.  **Note:** This property is only set for a duration report object. In these cases, the value of the &#x60;reportType&#x60; query parameter is &#x60;duration&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

