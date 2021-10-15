# Camunda.OpenApi.Client.Api.ExecutionApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateIncident**](ExecutionApi.md#createincident) | **POST** /execution/{id}/create-incident | Create Incident
[**DeleteLocalExecutionVariable**](ExecutionApi.md#deletelocalexecutionvariable) | **DELETE** /execution/{id}/localVariables/{varName} | Delete Local Execution Variable
[**GetExecution**](ExecutionApi.md#getexecution) | **GET** /execution/{id} | Get Execution
[**GetExecutions**](ExecutionApi.md#getexecutions) | **GET** /execution | Get Executions
[**GetExecutionsCount**](ExecutionApi.md#getexecutionscount) | **GET** /execution/count | Get Execution Count
[**GetLocalExecutionVariable**](ExecutionApi.md#getlocalexecutionvariable) | **GET** /execution/{id}/localVariables/{varName} | Get Local Execution Variable
[**GetLocalExecutionVariableBinary**](ExecutionApi.md#getlocalexecutionvariablebinary) | **GET** /execution/{id}/localVariables/{varName}/data | Get Local Execution Variable (Binary)
[**GetLocalExecutionVariables**](ExecutionApi.md#getlocalexecutionvariables) | **GET** /execution/{id}/localVariables | Get Local Execution Variables
[**GetMessageEventSubscription**](ExecutionApi.md#getmessageeventsubscription) | **GET** /execution/{id}/messageSubscriptions/{messageName} | Get Message Event Subscription
[**ModifyLocalExecutionVariables**](ExecutionApi.md#modifylocalexecutionvariables) | **POST** /execution/{id}/localVariables | Update/Delete Local Execution Variables
[**PutLocalExecutionVariable**](ExecutionApi.md#putlocalexecutionvariable) | **PUT** /execution/{id}/localVariables/{varName} | Put Local Execution Variable
[**QueryExecutions**](ExecutionApi.md#queryexecutions) | **POST** /execution | Get Executions (POST)
[**QueryExecutionsCount**](ExecutionApi.md#queryexecutionscount) | **POST** /execution/count | Get Execution Count (POST)
[**SetLocalExecutionVariableBinary**](ExecutionApi.md#setlocalexecutionvariablebinary) | **POST** /execution/{id}/localVariables/{varName}/data | Post Local Execution Variable (Binary)
[**SignalExecution**](ExecutionApi.md#signalexecution) | **POST** /execution/{id}/signal | Trigger Execution
[**TriggerEvent**](ExecutionApi.md#triggerevent) | **POST** /execution/{id}/messageSubscriptions/{messageName}/trigger | Trigger Message Event Subscription


<a name="createincident"></a>
# **CreateIncident**
> IncidentDto CreateIncident (string id, CreateIncidentDto createIncidentDto = null)

Create Incident

Creates a custom incident with given properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class CreateIncidentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution to create a new incident for.
            var createIncidentDto = new CreateIncidentDto(); // CreateIncidentDto |  (optional) 

            try
            {
                // Create Incident
                IncidentDto result = apiInstance.CreateIncident(id, createIncidentDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.CreateIncident: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution to create a new incident for. | 
 **createIncidentDto** | [**CreateIncidentDto**](CreateIncidentDto.md)|  | [optional] 

### Return type

[**IncidentDto**](IncidentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if the incident type is null, the execution does not exist or the execution is not related to any activity. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocalexecutionvariable"></a>
# **DeleteLocalExecutionVariable**
> void DeleteLocalExecutionVariable (string id, string varName)

Delete Local Execution Variable

Deletes a variable in the context of a given execution by id. Deletion does not propagate upwards in the execution hierarchy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteLocalExecutionVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution to delete the variable from.
            var varName = varName_example;  // string | The name of the variable to delete.

            try
            {
                // Delete Local Execution Variable
                apiInstance.DeleteLocalExecutionVariable(id, varName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.DeleteLocalExecutionVariable: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution to delete the variable from. | 
 **varName** | **string**| The name of the variable to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. This method returns no content. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexecution"></a>
# **GetExecution**
> ExecutionDto GetExecution (string id)

Get Execution

Retrieves an execution by id, according to the `Execution` interface in the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetExecutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution to be retrieved.

            try
            {
                // Get Execution
                ExecutionDto result = apiInstance.GetExecution(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.GetExecution: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution to be retrieved. | 

### Return type

[**ExecutionDto**](ExecutionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Execution with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexecutions"></a>
# **GetExecutions**
> List&lt;ExecutionDto&gt; GetExecutions (string businessKey = null, string processDefinitionId = null, string processDefinitionKey = null, string processInstanceId = null, string activityId = null, string signalEventSubscriptionName = null, string messageEventSubscriptionName = null, bool? active = null, bool? suspended = null, string incidentId = null, string incidentType = null, string incidentMessage = null, string incidentMessageLike = null, string tenantIdIn = null, string variables = null, string processVariables = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Executions

Queries for the executions that fulfill given parameters. Parameters may be static as well as dynamic runtime properties of executions. The size of the result set can be retrieved by using the [Get Execution Count](https://docs.camunda.org/manual/7.16/reference/rest/execution/get-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetExecutionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var businessKey = businessKey_example;  // string | Filter by the business key of the process instances the executions belong to. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the process definition the executions run on. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by the key of the process definition the executions run on. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by the id of the process instance the execution belongs to. (optional) 
            var activityId = activityId_example;  // string | Filter by the id of the activity the execution currently executes. (optional) 
            var signalEventSubscriptionName = signalEventSubscriptionName_example;  // string | Select only those executions that expect a signal of the given name. (optional) 
            var messageEventSubscriptionName = messageEventSubscriptionName_example;  // string | Select only those executions that expect a message of the given name. (optional) 
            var active = true;  // bool? | Only include active executions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | Only include suspended executions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var incidentId = incidentId_example;  // string | Filter by the incident id. (optional) 
            var incidentType = incidentType_example;  // string | Filter by the incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Filter by the incident message. Exact match. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Filter by the incident message that the parameter is a substring of. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. An execution must have one of the given tenant ids. (optional) 
            var variables = variables_example;  // string | Only include executions that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value. **Note:** Values are always treated as `String` objects on server side.  Valid operator values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var processVariables = processVariables_example;  // string | Only include executions that belong to a process instance with variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value. **Note:** Values are always treated as `String` objects on server side.  Valid operator values are: `eq` - equal to; `neq` - not equal to. `key` and `value` may not contain underscore or comma characters. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match all variable names provided in `variables` and `processVariables` case- insensitively. If set to `true` **variableName** and **variablename** are treated as equal. (optional) 
            var variableValuesIgnoreCase = true;  // bool? | Match all variable values provided in `variables` and `processVariables` case- insensitively. If set to `true` **variableValue** and **variablevalue** are treated as equal. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get Executions
                List<ExecutionDto> result = apiInstance.GetExecutions(businessKey, processDefinitionId, processDefinitionKey, processInstanceId, activityId, signalEventSubscriptionName, messageEventSubscriptionName, active, suspended, incidentId, incidentType, incidentMessage, incidentMessageLike, tenantIdIn, variables, processVariables, variableNamesIgnoreCase, variableValuesIgnoreCase, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.GetExecutions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessKey** | **string**| Filter by the business key of the process instances the executions belong to. | [optional] 
 **processDefinitionId** | **string**| Filter by the process definition the executions run on. | [optional] 
 **processDefinitionKey** | **string**| Filter by the key of the process definition the executions run on. | [optional] 
 **processInstanceId** | **string**| Filter by the id of the process instance the execution belongs to. | [optional] 
 **activityId** | **string**| Filter by the id of the activity the execution currently executes. | [optional] 
 **signalEventSubscriptionName** | **string**| Select only those executions that expect a signal of the given name. | [optional] 
 **messageEventSubscriptionName** | **string**| Select only those executions that expect a message of the given name. | [optional] 
 **active** | **bool?**| Only include active executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **suspended** | **bool?**| Only include suspended executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **incidentId** | **string**| Filter by the incident id. | [optional] 
 **incidentType** | **string**| Filter by the incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentMessage** | **string**| Filter by the incident message. Exact match. | [optional] 
 **incidentMessageLike** | **string**| Filter by the incident message that the parameter is a substring of. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. An execution must have one of the given tenant ids. | [optional] 
 **variables** | **string**| Only include executions that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. **Note:** Values are always treated as &#x60;String&#x60; objects on server side.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **processVariables** | **string**| Only include executions that belong to a process instance with variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. **Note:** Values are always treated as &#x60;String&#x60; objects on server side.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match all variable names provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal. | [optional] 
 **variableValuesIgnoreCase** | **bool?**| Match all variable values provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;ExecutionDto&gt;**](ExecutionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;, or if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexecutionscount"></a>
# **GetExecutionsCount**
> CountResultDto GetExecutionsCount (string businessKey = null, string processDefinitionId = null, string processDefinitionKey = null, string processInstanceId = null, string activityId = null, string signalEventSubscriptionName = null, string messageEventSubscriptionName = null, bool? active = null, bool? suspended = null, string incidentId = null, string incidentType = null, string incidentMessage = null, string incidentMessageLike = null, string tenantIdIn = null, string variables = null, string processVariables = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null)

Get Execution Count

Queries for the number of executions that fulfill given parameters. Takes the same parameters as the [Get Executions](https://docs.camunda.org/manual/7.16/reference/rest/execution/get-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetExecutionsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var businessKey = businessKey_example;  // string | Filter by the business key of the process instances the executions belong to. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the process definition the executions run on. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by the key of the process definition the executions run on. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by the id of the process instance the execution belongs to. (optional) 
            var activityId = activityId_example;  // string | Filter by the id of the activity the execution currently executes. (optional) 
            var signalEventSubscriptionName = signalEventSubscriptionName_example;  // string | Select only those executions that expect a signal of the given name. (optional) 
            var messageEventSubscriptionName = messageEventSubscriptionName_example;  // string | Select only those executions that expect a message of the given name. (optional) 
            var active = true;  // bool? | Only include active executions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | Only include suspended executions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var incidentId = incidentId_example;  // string | Filter by the incident id. (optional) 
            var incidentType = incidentType_example;  // string | Filter by the incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Filter by the incident message. Exact match. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Filter by the incident message that the parameter is a substring of. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. An execution must have one of the given tenant ids. (optional) 
            var variables = variables_example;  // string | Only include executions that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value. **Note:** Values are always treated as `String` objects on server side.  Valid operator values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var processVariables = processVariables_example;  // string | Only include executions that belong to a process instance with variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value. **Note:** Values are always treated as `String` objects on server side.  Valid operator values are: `eq` - equal to; `neq` - not equal to. `key` and `value` may not contain underscore or comma characters. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match all variable names provided in `variables` and `processVariables` case- insensitively. If set to `true` **variableName** and **variablename** are treated as equal. (optional) 
            var variableValuesIgnoreCase = true;  // bool? | Match all variable values provided in `variables` and `processVariables` case- insensitively. If set to `true` **variableValue** and **variablevalue** are treated as equal. (optional) 

            try
            {
                // Get Execution Count
                CountResultDto result = apiInstance.GetExecutionsCount(businessKey, processDefinitionId, processDefinitionKey, processInstanceId, activityId, signalEventSubscriptionName, messageEventSubscriptionName, active, suspended, incidentId, incidentType, incidentMessage, incidentMessageLike, tenantIdIn, variables, processVariables, variableNamesIgnoreCase, variableValuesIgnoreCase);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.GetExecutionsCount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessKey** | **string**| Filter by the business key of the process instances the executions belong to. | [optional] 
 **processDefinitionId** | **string**| Filter by the process definition the executions run on. | [optional] 
 **processDefinitionKey** | **string**| Filter by the key of the process definition the executions run on. | [optional] 
 **processInstanceId** | **string**| Filter by the id of the process instance the execution belongs to. | [optional] 
 **activityId** | **string**| Filter by the id of the activity the execution currently executes. | [optional] 
 **signalEventSubscriptionName** | **string**| Select only those executions that expect a signal of the given name. | [optional] 
 **messageEventSubscriptionName** | **string**| Select only those executions that expect a message of the given name. | [optional] 
 **active** | **bool?**| Only include active executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **suspended** | **bool?**| Only include suspended executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **incidentId** | **string**| Filter by the incident id. | [optional] 
 **incidentType** | **string**| Filter by the incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentMessage** | **string**| Filter by the incident message. Exact match. | [optional] 
 **incidentMessageLike** | **string**| Filter by the incident message that the parameter is a substring of. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. An execution must have one of the given tenant ids. | [optional] 
 **variables** | **string**| Only include executions that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. **Note:** Values are always treated as &#x60;String&#x60; objects on server side.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **processVariables** | **string**| Only include executions that belong to a process instance with variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. **Note:** Values are always treated as &#x60;String&#x60; objects on server side.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match all variable names provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal. | [optional] 
 **variableValuesIgnoreCase** | **bool?**| Match all variable values provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal. | [optional] 

### Return type

[**CountResultDto**](CountResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalexecutionvariable"></a>
# **GetLocalExecutionVariable**
> VariableValueDto GetLocalExecutionVariable (string id, string varName, bool? deserializeValue = null)

Get Local Execution Variable

Retrieves a variable from the context of a given execution by id. Does not traverse the parent execution hierarchy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetLocalExecutionVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution to retrieve the variable from.
            var varName = varName_example;  // string | The name of the variable to get.
            var deserializeValue = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath. If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional) 

            try
            {
                // Get Local Execution Variable
                VariableValueDto result = apiInstance.GetLocalExecutionVariable(id, varName, deserializeValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.GetLocalExecutionVariable: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution to retrieve the variable from. | 
 **varName** | **string**| The name of the variable to get. | 
 **deserializeValue** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath. If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] 

### Return type

[**VariableValueDto**](VariableValueDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Variable with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalexecutionvariablebinary"></a>
# **GetLocalExecutionVariableBinary**
> FileParameter GetLocalExecutionVariableBinary (string id, string varName)

Get Local Execution Variable (Binary)

Retrieves a binary variable from the context of a given execution by id. Does not traverse the parent execution hierarchy. Applicable for byte array and file variables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetLocalExecutionVariableBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution to retrieve the variable from.
            var varName = varName_example;  // string | The name of the variable to get.

            try
            {
                // Get Local Execution Variable (Binary)
                FileParameter result = apiInstance.GetLocalExecutionVariableBinary(id, varName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.GetLocalExecutionVariableBinary: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution to retrieve the variable from. | 
 **varName** | **string**| The name of the variable to get. | 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful.         For binary variables or files without any MIME type information, a byte stream is returned.         File variables with MIME type information are returned as the saved type.         Additionally, for file variables the Content-Disposition header will be set. |  -  |
| **400** | Variable instance with given id exists but is not a binary variable. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Variable instance with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalexecutionvariables"></a>
# **GetLocalExecutionVariables**
> Dictionary&lt;string, VariableValueDto&gt; GetLocalExecutionVariables (string id, bool? deserializeValues = null)

Get Local Execution Variables

Retrieves all variables of a given execution by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetLocalExecutionVariablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution to retrieve the variables from.
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional) 

            try
            {
                // Get Local Execution Variables
                Dictionary<string, VariableValueDto> result = apiInstance.GetLocalExecutionVariables(id, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.GetLocalExecutionVariables: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution to retrieve the variables from. | 
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] 

### Return type

[**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. Returns A JSON object of variables key-value pairs. Each key is a variable name and each value a VariableValueDto |  -  |
| **500** | Execution with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessageeventsubscription"></a>
# **GetMessageEventSubscription**
> EventSubscriptionDto GetMessageEventSubscription (string id, string messageName)

Get Message Event Subscription

Retrieves a message event subscription for a given execution by id and a message name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetMessageEventSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution that holds the subscription.
            var messageName = messageName_example;  // string | The name of the message that the subscription corresponds to.

            try
            {
                // Get Message Event Subscription
                EventSubscriptionDto result = apiInstance.GetMessageEventSubscription(id, messageName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.GetMessageEventSubscription: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution that holds the subscription. | 
 **messageName** | **string**| The name of the message that the subscription corresponds to. | 

### Return type

[**EventSubscriptionDto**](EventSubscriptionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | A message subscription for the given name and execution does not exist. This may either mean that the execution does not exist, or that it is not subscribed on such a message. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifylocalexecutionvariables"></a>
# **ModifyLocalExecutionVariables**
> void ModifyLocalExecutionVariables (string id, PatchVariablesDto patchVariablesDto = null)

Update/Delete Local Execution Variables

Updates or deletes the variables in the context of an execution by id. The updates do not propagate upwards in the execution hierarchy. Updates precede deletions. So, if a variable is updated AND deleted, the deletion overrides the update.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ModifyLocalExecutionVariablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution to set variables for.
            var patchVariablesDto = new PatchVariablesDto(); // PatchVariablesDto |  (optional) 

            try
            {
                // Update/Delete Local Execution Variables
                apiInstance.ModifyLocalExecutionVariables(id, patchVariablesDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.ModifyLocalExecutionVariables: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution to set variables for. | 
 **patchVariablesDto** | [**PatchVariablesDto**](PatchVariablesDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. This method returns no content. |  -  |
| **400** | The variable value or type is invalid, for example if the value could not be parsed to an Integer value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error- handling) for the error response format. |  -  |
| **500** | Update or delete could not be executed, for example because the execution does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putlocalexecutionvariable"></a>
# **PutLocalExecutionVariable**
> void PutLocalExecutionVariable (string id, string varName, VariableValueDto variableValueDto = null)

Put Local Execution Variable

Sets a variable in the context of a given execution by id. Update does not propagate upwards in the execution hierarchy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class PutLocalExecutionVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution to set the variable for.
            var varName = varName_example;  // string | The name of the variable to set.
            var variableValueDto = new VariableValueDto(); // VariableValueDto |  (optional) 

            try
            {
                // Put Local Execution Variable
                apiInstance.PutLocalExecutionVariable(id, varName, variableValueDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.PutLocalExecutionVariable: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution to set the variable for. | 
 **varName** | **string**| The name of the variable to set. | 
 **variableValueDto** | [**VariableValueDto**](VariableValueDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. This method returns no content. |  -  |
| **400** | The variable value or type is invalid, for example if the value could not be parsed to an Integer value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error- handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryexecutions"></a>
# **QueryExecutions**
> List&lt;ExecutionDto&gt; QueryExecutions (int? firstResult = null, int? maxResults = null, ExecutionQueryDto executionQueryDto = null)

Get Executions (POST)

Queries for executions that fulfill given parameters through a JSON object. This method is slightly more powerful than the [Get Executions](https://docs.camunda.org/manual/7.16/reference/rest/execution/get-query/) method because it allows to filter by multiple instance and execution variables of types `String`, `Number` or `Boolean`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryExecutionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var executionQueryDto = new ExecutionQueryDto(); // ExecutionQueryDto |  (optional) 

            try
            {
                // Get Executions (POST)
                List<ExecutionDto> result = apiInstance.QueryExecutions(firstResult, maxResults, executionQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.QueryExecutions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 
 **executionQueryDto** | [**ExecutionQueryDto**](ExecutionQueryDto.md)|  | [optional] 

### Return type

[**List&lt;ExecutionDto&gt;**](ExecutionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;, or if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryexecutionscount"></a>
# **QueryExecutionsCount**
> CountResultDto QueryExecutionsCount (ExecutionQueryDto executionQueryDto = null)

Get Execution Count (POST)

Queries for the number of executions that fulfill given parameters. This method takes the same message body as the [Get Executions POST](https://docs.camunda.org/manual/7.16/reference/rest/execution/post-query/) method and therefore it is slightly more powerful than the [Get Execution Count](https://docs.camunda.org/manual/7.16/reference/rest/execution/get-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryExecutionsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var executionQueryDto = new ExecutionQueryDto(); // ExecutionQueryDto |  (optional) 

            try
            {
                // Get Execution Count (POST)
                CountResultDto result = apiInstance.QueryExecutionsCount(executionQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.QueryExecutionsCount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionQueryDto** | [**ExecutionQueryDto**](ExecutionQueryDto.md)|  | [optional] 

### Return type

[**CountResultDto**](CountResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setlocalexecutionvariablebinary"></a>
# **SetLocalExecutionVariableBinary**
> void SetLocalExecutionVariableBinary (string id, string varName, FileParameter data = null, string valueType = null)

Post Local Execution Variable (Binary)

Sets the serialized value for a binary variable or the binary value for a file variable in the context of a given execution by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SetLocalExecutionVariableBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution to set the variable for.
            var varName = varName_example;  // string | The name of the variable to set.
            var data = BINARY_DATA_HERE;  // FileParameter | The binary data to be set. For File variables, this multipart can contain the filename, binary value and MIME type of the file variable to be set Only the filename is mandatory. (optional) 
            var valueType = valueType_example;  // string | The name of the variable type. Either Bytes for a byte array variable or File for a file variable. (optional) 

            try
            {
                // Post Local Execution Variable (Binary)
                apiInstance.SetLocalExecutionVariableBinary(id, varName, data, valueType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.SetLocalExecutionVariableBinary: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution to set the variable for. | 
 **varName** | **string**| The name of the variable to set. | 
 **data** | **FileParameter****FileParameter**| The binary data to be set. For File variables, this multipart can contain the filename, binary value and MIME type of the file variable to be set Only the filename is mandatory. | [optional] 
 **valueType** | **string**| The name of the variable type. Either Bytes for a byte array variable or File for a file variable. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. This method returns no content. |  -  |
| **400** | The variable value or type is invalid, for example if no filename is set. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signalexecution"></a>
# **SignalExecution**
> void SignalExecution (string id, ExecutionTriggerDto executionTriggerDto = null)

Trigger Execution

Signals an execution by id. Can for example be used to explicitly skip user tasks or signal asynchronous continuations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SignalExecutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution to signal.
            var executionTriggerDto = new ExecutionTriggerDto(); // ExecutionTriggerDto |  (optional) 

            try
            {
                // Trigger Execution
                apiInstance.SignalExecution(id, executionTriggerDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.SignalExecution: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution to signal. | 
 **executionTriggerDto** | [**ExecutionTriggerDto**](ExecutionTriggerDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. This method returns no content. |  -  |
| **400** | The variable value or type is invalid, for example if the value could not be parsed to an Integer value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="triggerevent"></a>
# **TriggerEvent**
> void TriggerEvent (string id, string messageName, ExecutionTriggerDto executionTriggerDto = null)

Trigger Message Event Subscription

Delivers a message to a specific execution by id, to trigger an existing message event subscription. Inject process variables as the message's payload.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class TriggerEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExecutionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the execution to submit the message to.
            var messageName = messageName_example;  // string | The name of the message that the addressed subscription corresponds to.
            var executionTriggerDto = new ExecutionTriggerDto(); // ExecutionTriggerDto |  (optional) 

            try
            {
                // Trigger Message Event Subscription
                apiInstance.TriggerEvent(id, messageName, executionTriggerDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExecutionApi.TriggerEvent: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the execution to submit the message to. | 
 **messageName** | **string**| The name of the message that the addressed subscription corresponds to. | 
 **executionTriggerDto** | [**ExecutionTriggerDto**](ExecutionTriggerDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. This method returns no content. |  -  |
| **400** | The variable value or type is invalid, for example if the value could not be parsed to an Integer value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The addressed execution has no pending message subscriptions for the given message. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

