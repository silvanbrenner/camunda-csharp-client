# Camunda.OpenApi.Client.Model.HistoricDecisionInstanceQueryDto
A historic decision instance query which defines a list of historic decision instances

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DecisionInstanceId** | **string** | Filter by decision instance id. | [optional] 
**DecisionInstanceIdIn** | **List&lt;string&gt;** | Filter by decision instance ids. Must be a comma-separated list of decision instance ids. | [optional] 
**DecisionDefinitionId** | **string** | Filter by the decision definition the instances belongs to. | [optional] 
**DecisionDefinitionIdIn** | **List&lt;string&gt;** | Filter by the decision definitions the instances belongs to. Must be a comma-separated list of decision definition ids. | [optional] 
**DecisionDefinitionKey** | **string** | Filter by the key of the decision definition the instances belongs to. | [optional] 
**DecisionDefinitionKeyIn** | **List&lt;string&gt;** | Filter by the keys of the decision definition the instances belongs to. Must be a comma- separated list of decision definition keys. | [optional] 
**DecisionDefinitionName** | **string** | Filter by the name of the decision definition the instances belongs to. | [optional] 
**DecisionDefinitionNameLike** | **string** | Filter by the name of the decision definition the instances belongs to, that the parameter is a substring of. | [optional] 
**ProcessDefinitionId** | **string** | Filter by the process definition the instances belongs to. | [optional] 
**ProcessDefinitionKey** | **string** | Filter by the key of the process definition the instances belongs to. | [optional] 
**ProcessInstanceId** | **string** | Filter by the process instance the instances belongs to. | [optional] 
**CaseDefinitionId** | **string** | Filter by the case definition the instances belongs to. | [optional] 
**CaseDefinitionKey** | **string** | Filter by the key of the case definition the instances belongs to. | [optional] 
**CaseInstanceId** | **string** | Filter by the case instance the instances belongs to. | [optional] 
**ActivityIdIn** | **List&lt;string&gt;** | Filter by the activity ids the instances belongs to. Must be a comma-separated list of acitvity ids. | [optional] 
**ActivityInstanceIdIn** | **List&lt;string&gt;** | Filter by the activity instance ids the instances belongs to. Must be a comma-separated list of acitvity instance ids. | [optional] 
**TenantIdIn** | **List&lt;string&gt;** | Filter by a comma-separated list of tenant ids. A historic decision instance must have one of the given tenant ids. | [optional] 
**WithoutTenantId** | **bool?** | Only include historic decision instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**EvaluatedBefore** | **DateTime?** | Restrict to instances that were evaluated before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM- dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
**EvaluatedAfter** | **DateTime?** | Restrict to instances that were evaluated after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM- dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
**UserId** | **string** | Restrict to instances that were evaluated by the given user. | [optional] 
**RootDecisionInstanceId** | **string** | Restrict to instances that have a given root decision instance id. This also includes the decision instance with the given id. | [optional] 
**RootDecisionInstancesOnly** | **bool?** | Restrict to instances those are the root decision instance of an evaluation. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**DecisionRequirementsDefinitionId** | **string** | Filter by the decision requirements definition the instances belongs to. | [optional] 
**DecisionRequirementsDefinitionKey** | **string** | Filter by the key of the decision requirements definition the instances belongs to. | [optional] 
**IncludeInputs** | **bool?** | Include input values in the result. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**IncludeOutputs** | **bool?** | Include output values in the result. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**DisableBinaryFetching** | **bool?** | Disables fetching of byte array input and output values. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**DisableCustomObjectDeserialization** | **bool?** | Disables deserialization of input and output values that are custom objects. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

