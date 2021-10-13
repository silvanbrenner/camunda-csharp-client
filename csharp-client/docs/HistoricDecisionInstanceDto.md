# Camunda.OpenApi.Client.Model.HistoricDecisionInstanceDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the decision instance. | [optional] 
**DecisionDefinitionId** | **string** | The id of the decision definition that this decision instance belongs to. | [optional] 
**DecisionDefinitionKey** | **string** | The key of the decision definition that this decision instance belongs to. | [optional] 
**DecisionDefinitionName** | **string** | The name of the decision definition that this decision instance belongs to. | [optional] 
**EvaluationTime** | **DateTime?** | The time the instance was evaluated.  [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RemovalTime** | **DateTime?** | The time after which the instance should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition that this decision instance belongs to. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition that this decision instance belongs to. | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance that this decision instance belongs to. | [optional] 
**CaseDefinitionId** | **string** | The id of the case definition that this decision instance belongs to. | [optional] 
**CaseDefinitionKey** | **string** | The key of the case definition that this decision instance belongs to. | [optional] 
**CaseInstanceId** | **string** | The id of the case instance that this decision instance belongs to. | [optional] 
**ActivityId** | **string** | The id of the activity that this decision instance belongs to. | [optional] 
**ActivityInstanceId** | **string** | The id of the activity instance that this decision instance belongs to. | [optional] 
**TenantId** | **string** | The tenant id of the historic decision instance. | [optional] 
**UserId** | **string** | The id of the authenticated user that has evaluated this decision instance without a process or case instance. | [optional] 
**Inputs** | [**List&lt;HistoricDecisionInputInstanceDto&gt;**](HistoricDecisionInputInstanceDto.md) | The list of decision input values. **Only exists** if &#x60;includeInputs&#x60; was set to &#x60;true&#x60; in the query. | [optional] 
**Ouputs** | [**List&lt;HistoricDecisionOutputInstanceDto&gt;**](HistoricDecisionOutputInstanceDto.md) | The list of decision output values. **Only exists** if &#x60;includeOutputs&#x60; was set to &#x60;true&#x60; in the query. | [optional] 
**CollectResultValue** | **double?** | The result of the collect aggregation of the decision result if used. &#x60;null&#x60; if no aggregation was used. | [optional] 
**RootDecisionInstanceId** | **string** | The decision instance id of the evaluated root decision. Can be &#x60;null&#x60; if this instance is the root decision instance of the evaluation. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance that initiated the evaluation of this decision. Can be &#x60;null&#x60; if this decision instance is not evaluated as part of a BPMN process. | [optional] 
**DecisionRequirementsDefinitionId** | **string** | The id of the decision requirements definition that this decision instance belongs to. | [optional] 
**DecisionRequirementsDefinitionKey** | **string** | The key of the decision requirements definition that this decision instance belongs to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

