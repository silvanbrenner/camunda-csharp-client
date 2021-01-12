# CamundaClient.Model.DurationReportResultDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Period** | **int** | Specifies a timespan within a year. **Note:** The period must be interpreted in conjunction with the returned &#x60;periodUnit&#x60;. | [optional] 
**PeriodUnit** | **string** | The unit of the given period. Possible values are &#x60;MONTH&#x60; and &#x60;QUARTER&#x60;. | [optional] 
**Minimum** | **long** | The smallest duration in milliseconds of all completed process instances which were started in the given period. | [optional] 
**Maximum** | **long** | The greatest duration in milliseconds of all completed process instances which were started in the given period. | [optional] 
**Average** | **long** | The average duration in milliseconds of all completed process instances which were started in the given period. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

