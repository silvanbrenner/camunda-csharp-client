# Camunda.OpenApi.Client.Model.HistoricActivityStatisticsDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the activity the results are aggregated for. | [optional] 
**Instances** | **long?** | The total number of all running instances of the activity. | [optional] 
**Canceled** | **long?** | The total number of all canceled instances of the activity. **Note:** Will be &#x60;0&#x60; (not &#x60;null&#x60;), if canceled activity instances were excluded. | [optional] 
**Finished** | **long?** | The total number of all finished instances of the activity. **Note:** Will be &#x60;0&#x60; (not &#x60;null&#x60;), if finished activity instances were excluded. | [optional] 
**CompleteScope** | **long?** | The total number of all instances which completed a scope of the activity. **Note:** Will be &#x60;0&#x60; (not &#x60;null&#x60;), if activity instances which completed a scope were excluded. | [optional] 
**OpenIncidents** | **long?** | The total number of open incidents for the activity. **Note:** Will be &#x60;0&#x60; (not &#x60;null&#x60;), if &#x60;incidents&#x60; is set to &#x60;false&#x60;. | [optional] 
**ResolvedIncidents** | **long?** | The total number of resolved incidents for the activity. **Note:** Will be &#x60;0&#x60; (not &#x60;null&#x60;), if &#x60;incidents&#x60; is set to &#x60;false&#x60;. | [optional] 
**DeletedIncidents** | **long?** | The total number of deleted incidents for the activity. **Note:** Will be &#x60;0&#x60; (not &#x60;null&#x60;), if &#x60;incidents&#x60; is set to &#x60;false&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

