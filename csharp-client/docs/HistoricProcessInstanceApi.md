# Camunda.OpenApi.Client.Api.HistoricProcessInstanceApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteHistoricProcessInstance**](HistoricProcessInstanceApi.md#deletehistoricprocessinstance) | **DELETE** /history/process-instance/{id} | Delete
[**DeleteHistoricProcessInstancesAsync**](HistoricProcessInstanceApi.md#deletehistoricprocessinstancesasync) | **POST** /history/process-instance/delete | Delete Async (POST)
[**DeleteHistoricVariableInstancesOfHistoricProcessInstance**](HistoricProcessInstanceApi.md#deletehistoricvariableinstancesofhistoricprocessinstance) | **DELETE** /history/process-instance/{id}/variable-instances | Delete Variable Instances
[**GetHistoricProcessInstance**](HistoricProcessInstanceApi.md#gethistoricprocessinstance) | **GET** /history/process-instance/{id} | Get
[**GetHistoricProcessInstanceDurationReport**](HistoricProcessInstanceApi.md#gethistoricprocessinstancedurationreport) | **GET** /history/process-instance/report | Get Duration Report
[**GetHistoricProcessInstances**](HistoricProcessInstanceApi.md#gethistoricprocessinstances) | **GET** /history/process-instance | Get List
[**GetHistoricProcessInstancesCount**](HistoricProcessInstanceApi.md#gethistoricprocessinstancescount) | **GET** /history/process-instance/count | Get List Count
[**QueryHistoricProcessInstances**](HistoricProcessInstanceApi.md#queryhistoricprocessinstances) | **POST** /history/process-instance | Get List (POST)
[**QueryHistoricProcessInstancesCount**](HistoricProcessInstanceApi.md#queryhistoricprocessinstancescount) | **POST** /history/process-instance/count | Get List Count (POST)
[**SetRemovalTimeAsync**](HistoricProcessInstanceApi.md#setremovaltimeasync) | **POST** /history/process-instance/set-removal-time | Set Removal Time Async (POST)


<a name="deletehistoricprocessinstance"></a>
# **DeleteHistoricProcessInstance**
> void DeleteHistoricProcessInstance (string id, bool? failIfNotExists = null)

Delete

Deletes a process instance from the history by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteHistoricProcessInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricProcessInstanceApi(config);
            var id = id_example;  // string | The id of the historic process instance to be deleted.
            var failIfNotExists = true;  // bool? | If set to `false`, the request will still be successful if the process id is not found. (optional) 

            try
            {
                // Delete
                apiInstance.DeleteHistoricProcessInstance(id, failIfNotExists);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessInstanceApi.DeleteHistoricProcessInstance: " + e.Message );
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
 **id** | **string**| The id of the historic process instance to be deleted. | 
 **failIfNotExists** | **bool?**| If set to &#x60;false&#x60;, the request will still be successful if the process id is not found. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **404** | Not found Historic process instance with given id does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehistoricprocessinstancesasync"></a>
# **DeleteHistoricProcessInstancesAsync**
> BatchDto DeleteHistoricProcessInstancesAsync (DeleteHistoricProcessInstancesDto deleteHistoricProcessInstancesDto = null)

Delete Async (POST)

Delete multiple historic process instances asynchronously (batch). At least `historicProcessInstanceIds` or `historicProcessInstanceQuery` has to be provided. If both are provided then all instances matching query criterion and instances from the list will be deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteHistoricProcessInstancesAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricProcessInstanceApi(config);
            var deleteHistoricProcessInstancesDto = new DeleteHistoricProcessInstancesDto(); // DeleteHistoricProcessInstancesDto |  (optional) 

            try
            {
                // Delete Async (POST)
                BatchDto result = apiInstance.DeleteHistoricProcessInstancesAsync(deleteHistoricProcessInstancesDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessInstanceApi.DeleteHistoricProcessInstancesAsync: " + e.Message );
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
 **deleteHistoricProcessInstancesDto** | [**DeleteHistoricProcessInstancesDto**](DeleteHistoricProcessInstancesDto.md)|  | [optional] 

### Return type

[**BatchDto**](BatchDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, i.e. neither historicProcessInstanceIds, nor historicProcessInstanceQuery is present. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehistoricvariableinstancesofhistoricprocessinstance"></a>
# **DeleteHistoricVariableInstancesOfHistoricProcessInstance**
> void DeleteHistoricVariableInstancesOfHistoricProcessInstance (string id)

Delete Variable Instances

Deletes all variables of a process instance from the history by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteHistoricVariableInstancesOfHistoricProcessInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance for which all historic variables are to be deleted.

            try
            {
                // Delete Variable Instances
                apiInstance.DeleteHistoricVariableInstancesOfHistoricProcessInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessInstanceApi.DeleteHistoricVariableInstancesOfHistoricProcessInstance: " + e.Message );
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
 **id** | **string**| The id of the process instance for which all historic variables are to be deleted. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **404** | Not found Historic process instance with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#parse-exceptions) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricprocessinstance"></a>
# **GetHistoricProcessInstance**
> HistoricProcessInstanceDto GetHistoricProcessInstance (string id)

Get

Retrieves a historic process instance by id, according to the `HistoricProcessInstance` interface in the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricProcessInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricProcessInstanceApi(config);
            var id = id_example;  // string | The id of the historic process instance to be retrieved.

            try
            {
                // Get
                HistoricProcessInstanceDto result = apiInstance.GetHistoricProcessInstance(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessInstanceApi.GetHistoricProcessInstance: " + e.Message );
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
 **id** | **string**| The id of the historic process instance to be retrieved. | 

### Return type

[**HistoricProcessInstanceDto**](HistoricProcessInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Not Found Historic process instance with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricprocessinstancedurationreport"></a>
# **GetHistoricProcessInstanceDurationReport**
> List&lt;DurationReportResultDto&gt; GetHistoricProcessInstanceDurationReport (string reportType, string periodUnit, string processDefinitionIdIn = null, string processDefinitionKeyIn = null, DateTime? startedBefore = null, DateTime? startedAfter = null)

Get Duration Report

Retrieves a report about the duration of completed process instances, grouped by a period. These reports include the maximum, minimum and average duration of all completed process instances which were started in a given period.  **Note:** This only includes historic data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricProcessInstanceDurationReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricProcessInstanceApi(config);
            var reportType = reportType_example;  // string | **Mandatory.** Specifies the type of the report to retrieve. To retrieve a report about the duration of process instances, the value must be set to `duration`.
            var periodUnit = periodUnit_example;  // string | **Mandatory.** Specifies the granularity of the report. Valid values are `month` and `quarter`.
            var processDefinitionIdIn = processDefinitionIdIn_example;  // string | Filter by process definition ids. Must be a comma-separated list of process definition ids. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Filter by process definition keys. Must be a comma-separated list of process definition keys. (optional) 
            var startedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were started before the given date. By [default](), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2016-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2016-01-23T14:42:45.000+0200`. (optional) 

            try
            {
                // Get Duration Report
                List<DurationReportResultDto> result = apiInstance.GetHistoricProcessInstanceDurationReport(reportType, periodUnit, processDefinitionIdIn, processDefinitionKeyIn, startedBefore, startedAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessInstanceApi.GetHistoricProcessInstanceDurationReport: " + e.Message );
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
 **reportType** | **string**| **Mandatory.** Specifies the type of the report to retrieve. To retrieve a report about the duration of process instances, the value must be set to &#x60;duration&#x60;. | 
 **periodUnit** | **string**| **Mandatory.** Specifies the granularity of the report. Valid values are &#x60;month&#x60; and &#x60;quarter&#x60;. | 
 **processDefinitionIdIn** | **string**| Filter by process definition ids. Must be a comma-separated list of process definition ids. | [optional] 
 **processDefinitionKeyIn** | **string**| Filter by process definition keys. Must be a comma-separated list of process definition keys. | [optional] 
 **startedBefore** | **DateTime?**| Restrict to instances that were started before the given date. By [default](), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2016-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedAfter** | **DateTime?**| Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2016-01-23T14:42:45.000+0200&#x60;. | [optional] 

### Return type

[**List&lt;DurationReportResultDto&gt;**](DurationReportResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/csv, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid or mandatory parameters are not supplied. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | If the authenticated user is unauthorized to read the history. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricprocessinstances"></a>
# **GetHistoricProcessInstances**
> List&lt;HistoricProcessInstanceDto&gt; GetHistoricProcessInstances (string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null, string processInstanceId = null, string processInstanceIds = null, string processDefinitionId = null, string processDefinitionKey = null, string processDefinitionKeyIn = null, string processDefinitionName = null, string processDefinitionNameLike = null, string processDefinitionKeyNotIn = null, string processInstanceBusinessKey = null, string processInstanceBusinessKeyLike = null, bool? rootProcessInstances = null, bool? finished = null, bool? unfinished = null, bool? withIncidents = null, bool? withRootIncidents = null, string incidentType = null, string incidentStatus = null, string incidentMessage = null, string incidentMessageLike = null, DateTime? startedBefore = null, DateTime? startedAfter = null, DateTime? finishedBefore = null, DateTime? finishedAfter = null, DateTime? executedActivityAfter = null, DateTime? executedActivityBefore = null, DateTime? executedJobAfter = null, DateTime? executedJobBefore = null, string startedBy = null, string superProcessInstanceId = null, string subProcessInstanceId = null, string superCaseInstanceId = null, string subCaseInstanceId = null, string caseInstanceId = null, string tenantIdIn = null, bool? withoutTenantId = null, string executedActivityIdIn = null, string activeActivityIdIn = null, bool? active = null, bool? suspended = null, bool? completed = null, bool? externallyTerminated = null, bool? internallyTerminated = null, string variables = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null)

Get List

Queries for historic process instances that fulfill the given parameters. The size of the result set can be retrieved by using the [Get Process Instance Count](https://docs.camunda.org/manual/7.16/reference/rest/history/process-instance/get-process-instance-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricProcessInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricProcessInstanceApi(config);
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processInstanceIds = processInstanceIds_example;  // string | Filter by process instance ids. Filter by a comma-separated list of `Strings`. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the process definition the instances run on. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by the key of the process definition the instances run on. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Filter by a list of process definition keys. A process instance must have one of the given process definition keys. Filter by a comma-separated list of `Strings`. (optional) 
            var processDefinitionName = processDefinitionName_example;  // string | Filter by the name of the process definition the instances run on. (optional) 
            var processDefinitionNameLike = processDefinitionNameLike_example;  // string | Filter by process definition names that the parameter is a substring of. (optional) 
            var processDefinitionKeyNotIn = processDefinitionKeyNotIn_example;  // string | Exclude instances that belong to a set of process definitions. Filter by a comma-separated list of `Strings`. (optional) 
            var processInstanceBusinessKey = processInstanceBusinessKey_example;  // string | Filter by process instance business key. (optional) 
            var processInstanceBusinessKeyLike = processInstanceBusinessKeyLike_example;  // string | Filter by process instance business key that the parameter is a substring of. (optional) 
            var rootProcessInstances = true;  // bool? | Restrict the query to all process instances that are top level process instances. (optional) 
            var finished = true;  // bool? | Only include finished process instances. This flag includes all process instances that are completed or terminated. Value may only be `true`, as `false` is the default behavior. (optional) 
            var unfinished = true;  // bool? | Only include unfinished process instances. Value may only be `true`, as `false` is the default behavior. (optional) 
            var withIncidents = true;  // bool? | Only include process instances which have an incident. Value may only be `true`, as `false` is the default behavior. (optional) 
            var withRootIncidents = true;  // bool? | Only include process instances which have a root incident. Value may only be `true`, as `false` is the default behavior. (optional) 
            var incidentType = incidentType_example;  // string | Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentStatus = incidentStatus_example;  // string | Only include process instances which have an incident in status either open or resolved. To get all process instances, use the query parameter withIncidents. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Filter by the incident message. Exact match. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Filter by the incident message that the parameter is a substring of. (optional) 
            var startedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var executedActivityAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that executed an activity after the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var executedActivityBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that executed an activity before the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var executedJobAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that executed an job after the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var executedJobBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that executed an job before the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedBy = startedBy_example;  // string | Only include process instances that were started by the given user. (optional) 
            var superProcessInstanceId = superProcessInstanceId_example;  // string | Restrict query to all process instances that are sub process instances of the given process instance. Takes a process instance id. (optional) 
            var subProcessInstanceId = subProcessInstanceId_example;  // string | Restrict query to one process instance that has a sub process instance with the given id. (optional) 
            var superCaseInstanceId = superCaseInstanceId_example;  // string | Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. (optional) 
            var subCaseInstanceId = subCaseInstanceId_example;  // string | Restrict query to one process instance that has a sub case instance with the given id. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a list of tenant ids. A process instance must have one of the given tenant ids. Filter by a comma-separated list of `Strings` (optional) 
            var withoutTenantId = true;  // bool? | Only include historic process instances which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var executedActivityIdIn = executedActivityIdIn_example;  // string | Restrict to instances that executed an activity with one of given ids. Filter by a comma-separated list of `Strings` (optional) 
            var activeActivityIdIn = activeActivityIdIn_example;  // string | Restrict to instances that have an active activity with one of given ids. Filter by a comma-separated list of `Strings` (optional) 
            var active = true;  // bool? | Restrict to instances that are active. (optional) 
            var suspended = true;  // bool? | Restrict to instances that are suspended. (optional) 
            var completed = true;  // bool? | Restrict to instances that are completed. (optional) 
            var externallyTerminated = true;  // bool? | Restrict to instances that are externallyTerminated. (optional) 
            var internallyTerminated = true;  // bool? | Restrict to instances that are internallyTerminated. (optional) 
            var variables = variables_example;  // string | Only include process instances that have/had variables with certain values. Variable filtering expressions are comma-separated and are structured as follows: A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note:** Values are always treated as String objects on server side.  Valid operator values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`.  Key and value may not contain underscore or comma characters.  (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match all variable names provided in variables case-insensitively. If set to `true` variableName and variablename are treated as equal. (optional) 
            var variableValuesIgnoreCase = true;  // bool? | Match all variable values provided in variables case-insensitively. If set to `true` variableValue and variablevalue are treated as equal. (optional) 

            try
            {
                // Get List
                List<HistoricProcessInstanceDto> result = apiInstance.GetHistoricProcessInstances(sortBy, sortOrder, firstResult, maxResults, processInstanceId, processInstanceIds, processDefinitionId, processDefinitionKey, processDefinitionKeyIn, processDefinitionName, processDefinitionNameLike, processDefinitionKeyNotIn, processInstanceBusinessKey, processInstanceBusinessKeyLike, rootProcessInstances, finished, unfinished, withIncidents, withRootIncidents, incidentType, incidentStatus, incidentMessage, incidentMessageLike, startedBefore, startedAfter, finishedBefore, finishedAfter, executedActivityAfter, executedActivityBefore, executedJobAfter, executedJobBefore, startedBy, superProcessInstanceId, subProcessInstanceId, superCaseInstanceId, subCaseInstanceId, caseInstanceId, tenantIdIn, withoutTenantId, executedActivityIdIn, activeActivityIdIn, active, suspended, completed, externallyTerminated, internallyTerminated, variables, variableNamesIgnoreCase, variableValuesIgnoreCase);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessInstanceApi.GetHistoricProcessInstances: " + e.Message );
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
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **processInstanceIds** | **string**| Filter by process instance ids. Filter by a comma-separated list of &#x60;Strings&#x60;. | [optional] 
 **processDefinitionId** | **string**| Filter by the process definition the instances run on. | [optional] 
 **processDefinitionKey** | **string**| Filter by the key of the process definition the instances run on. | [optional] 
 **processDefinitionKeyIn** | **string**| Filter by a list of process definition keys. A process instance must have one of the given process definition keys. Filter by a comma-separated list of &#x60;Strings&#x60;. | [optional] 
 **processDefinitionName** | **string**| Filter by the name of the process definition the instances run on. | [optional] 
 **processDefinitionNameLike** | **string**| Filter by process definition names that the parameter is a substring of. | [optional] 
 **processDefinitionKeyNotIn** | **string**| Exclude instances that belong to a set of process definitions. Filter by a comma-separated list of &#x60;Strings&#x60;. | [optional] 
 **processInstanceBusinessKey** | **string**| Filter by process instance business key. | [optional] 
 **processInstanceBusinessKeyLike** | **string**| Filter by process instance business key that the parameter is a substring of. | [optional] 
 **rootProcessInstances** | **bool?**| Restrict the query to all process instances that are top level process instances. | [optional] 
 **finished** | **bool?**| Only include finished process instances. This flag includes all process instances that are completed or terminated. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **unfinished** | **bool?**| Only include unfinished process instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **withIncidents** | **bool?**| Only include process instances which have an incident. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **withRootIncidents** | **bool?**| Only include process instances which have a root incident. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **incidentType** | **string**| Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentStatus** | **string**| Only include process instances which have an incident in status either open or resolved. To get all process instances, use the query parameter withIncidents. | [optional] 
 **incidentMessage** | **string**| Filter by the incident message. Exact match. | [optional] 
 **incidentMessageLike** | **string**| Filter by the incident message that the parameter is a substring of. | [optional] 
 **startedBefore** | **DateTime?**| Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedAfter** | **DateTime?**| Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedBefore** | **DateTime?**| Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedAfter** | **DateTime?**| Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **executedActivityAfter** | **DateTime?**| Restrict to instances that executed an activity after the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **executedActivityBefore** | **DateTime?**| Restrict to instances that executed an activity before the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **executedJobAfter** | **DateTime?**| Restrict to instances that executed an job after the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **executedJobBefore** | **DateTime?**| Restrict to instances that executed an job before the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedBy** | **string**| Only include process instances that were started by the given user. | [optional] 
 **superProcessInstanceId** | **string**| Restrict query to all process instances that are sub process instances of the given process instance. Takes a process instance id. | [optional] 
 **subProcessInstanceId** | **string**| Restrict query to one process instance that has a sub process instance with the given id. | [optional] 
 **superCaseInstanceId** | **string**| Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. | [optional] 
 **subCaseInstanceId** | **string**| Restrict query to one process instance that has a sub case instance with the given id. | [optional] 
 **caseInstanceId** | **string**| Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. | [optional] 
 **tenantIdIn** | **string**| Filter by a list of tenant ids. A process instance must have one of the given tenant ids. Filter by a comma-separated list of &#x60;Strings&#x60; | [optional] 
 **withoutTenantId** | **bool?**| Only include historic process instances which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **executedActivityIdIn** | **string**| Restrict to instances that executed an activity with one of given ids. Filter by a comma-separated list of &#x60;Strings&#x60; | [optional] 
 **activeActivityIdIn** | **string**| Restrict to instances that have an active activity with one of given ids. Filter by a comma-separated list of &#x60;Strings&#x60; | [optional] 
 **active** | **bool?**| Restrict to instances that are active. | [optional] 
 **suspended** | **bool?**| Restrict to instances that are suspended. | [optional] 
 **completed** | **bool?**| Restrict to instances that are completed. | [optional] 
 **externallyTerminated** | **bool?**| Restrict to instances that are externallyTerminated. | [optional] 
 **internallyTerminated** | **bool?**| Restrict to instances that are internallyTerminated. | [optional] 
 **variables** | **string**| Only include process instances that have/had variables with certain values. Variable filtering expressions are comma-separated and are structured as follows: A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note:** Values are always treated as String objects on server side.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;.  Key and value may not contain underscore or comma characters.  | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match all variable names provided in variables case-insensitively. If set to &#x60;true&#x60; variableName and variablename are treated as equal. | [optional] 
 **variableValuesIgnoreCase** | **bool?**| Match all variable values provided in variables case-insensitively. If set to &#x60;true&#x60; variableValue and variablevalue are treated as equal. | [optional] 

### Return type

[**List&lt;HistoricProcessInstanceDto&gt;**](HistoricProcessInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad Request Returned if some of the query parameters are invalid, for example if a sortOrder parameter is supplied, but no sortBy. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricprocessinstancescount"></a>
# **GetHistoricProcessInstancesCount**
> CountResultDto GetHistoricProcessInstancesCount (string processInstanceId = null, string processInstanceIds = null, string processDefinitionId = null, string processDefinitionKey = null, string processDefinitionKeyIn = null, string processDefinitionName = null, string processDefinitionNameLike = null, string processDefinitionKeyNotIn = null, string processInstanceBusinessKey = null, string processInstanceBusinessKeyLike = null, bool? rootProcessInstances = null, bool? finished = null, bool? unfinished = null, bool? withIncidents = null, bool? withRootIncidents = null, string incidentType = null, string incidentStatus = null, string incidentMessage = null, string incidentMessageLike = null, DateTime? startedBefore = null, DateTime? startedAfter = null, DateTime? finishedBefore = null, DateTime? finishedAfter = null, DateTime? executedActivityAfter = null, DateTime? executedActivityBefore = null, DateTime? executedJobAfter = null, DateTime? executedJobBefore = null, string startedBy = null, string superProcessInstanceId = null, string subProcessInstanceId = null, string superCaseInstanceId = null, string subCaseInstanceId = null, string caseInstanceId = null, string tenantIdIn = null, bool? withoutTenantId = null, string executedActivityIdIn = null, string activeActivityIdIn = null, bool? active = null, bool? suspended = null, bool? completed = null, bool? externallyTerminated = null, bool? internallyTerminated = null, string variables = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null)

Get List Count

Queries for the number of historic process instances that fulfill the given parameters. Takes the same parameters as the [Get Process Instances](https://docs.camunda.org/manual/7.16/reference/rest/history/process-instance/get-process-instance-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricProcessInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricProcessInstanceApi(config);
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processInstanceIds = processInstanceIds_example;  // string | Filter by process instance ids. Filter by a comma-separated list of `Strings`. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the process definition the instances run on. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by the key of the process definition the instances run on. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Filter by a list of process definition keys. A process instance must have one of the given process definition keys. Filter by a comma-separated list of `Strings`. (optional) 
            var processDefinitionName = processDefinitionName_example;  // string | Filter by the name of the process definition the instances run on. (optional) 
            var processDefinitionNameLike = processDefinitionNameLike_example;  // string | Filter by process definition names that the parameter is a substring of. (optional) 
            var processDefinitionKeyNotIn = processDefinitionKeyNotIn_example;  // string | Exclude instances that belong to a set of process definitions. Filter by a comma-separated list of `Strings`. (optional) 
            var processInstanceBusinessKey = processInstanceBusinessKey_example;  // string | Filter by process instance business key. (optional) 
            var processInstanceBusinessKeyLike = processInstanceBusinessKeyLike_example;  // string | Filter by process instance business key that the parameter is a substring of. (optional) 
            var rootProcessInstances = true;  // bool? | Restrict the query to all process instances that are top level process instances. (optional) 
            var finished = true;  // bool? | Only include finished process instances. This flag includes all process instances that are completed or terminated. Value may only be `true`, as `false` is the default behavior. (optional) 
            var unfinished = true;  // bool? | Only include unfinished process instances. Value may only be `true`, as `false` is the default behavior. (optional) 
            var withIncidents = true;  // bool? | Only include process instances which have an incident. Value may only be `true`, as `false` is the default behavior. (optional) 
            var withRootIncidents = true;  // bool? | Only include process instances which have a root incident. Value may only be `true`, as `false` is the default behavior. (optional) 
            var incidentType = incidentType_example;  // string | Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentStatus = incidentStatus_example;  // string | Only include process instances which have an incident in status either open or resolved. To get all process instances, use the query parameter withIncidents. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Filter by the incident message. Exact match. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Filter by the incident message that the parameter is a substring of. (optional) 
            var startedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var finishedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var executedActivityAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that executed an activity after the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var executedActivityBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that executed an activity before the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var executedJobAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that executed an job after the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var executedJobBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to instances that executed an job before the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedBy = startedBy_example;  // string | Only include process instances that were started by the given user. (optional) 
            var superProcessInstanceId = superProcessInstanceId_example;  // string | Restrict query to all process instances that are sub process instances of the given process instance. Takes a process instance id. (optional) 
            var subProcessInstanceId = subProcessInstanceId_example;  // string | Restrict query to one process instance that has a sub process instance with the given id. (optional) 
            var superCaseInstanceId = superCaseInstanceId_example;  // string | Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. (optional) 
            var subCaseInstanceId = subCaseInstanceId_example;  // string | Restrict query to one process instance that has a sub case instance with the given id. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a list of tenant ids. A process instance must have one of the given tenant ids. Filter by a comma-separated list of `Strings` (optional) 
            var withoutTenantId = true;  // bool? | Only include historic process instances which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var executedActivityIdIn = executedActivityIdIn_example;  // string | Restrict to instances that executed an activity with one of given ids. Filter by a comma-separated list of `Strings` (optional) 
            var activeActivityIdIn = activeActivityIdIn_example;  // string | Restrict to instances that have an active activity with one of given ids. Filter by a comma-separated list of `Strings` (optional) 
            var active = true;  // bool? | Restrict to instances that are active. (optional) 
            var suspended = true;  // bool? | Restrict to instances that are suspended. (optional) 
            var completed = true;  // bool? | Restrict to instances that are completed. (optional) 
            var externallyTerminated = true;  // bool? | Restrict to instances that are externallyTerminated. (optional) 
            var internallyTerminated = true;  // bool? | Restrict to instances that are internallyTerminated. (optional) 
            var variables = variables_example;  // string | Only include process instances that have/had variables with certain values. Variable filtering expressions are comma-separated and are structured as follows: A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note:** Values are always treated as String objects on server side.  Valid operator values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`.  Key and value may not contain underscore or comma characters.  (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match all variable names provided in variables case-insensitively. If set to `true` variableName and variablename are treated as equal. (optional) 
            var variableValuesIgnoreCase = true;  // bool? | Match all variable values provided in variables case-insensitively. If set to `true` variableValue and variablevalue are treated as equal. (optional) 

            try
            {
                // Get List Count
                CountResultDto result = apiInstance.GetHistoricProcessInstancesCount(processInstanceId, processInstanceIds, processDefinitionId, processDefinitionKey, processDefinitionKeyIn, processDefinitionName, processDefinitionNameLike, processDefinitionKeyNotIn, processInstanceBusinessKey, processInstanceBusinessKeyLike, rootProcessInstances, finished, unfinished, withIncidents, withRootIncidents, incidentType, incidentStatus, incidentMessage, incidentMessageLike, startedBefore, startedAfter, finishedBefore, finishedAfter, executedActivityAfter, executedActivityBefore, executedJobAfter, executedJobBefore, startedBy, superProcessInstanceId, subProcessInstanceId, superCaseInstanceId, subCaseInstanceId, caseInstanceId, tenantIdIn, withoutTenantId, executedActivityIdIn, activeActivityIdIn, active, suspended, completed, externallyTerminated, internallyTerminated, variables, variableNamesIgnoreCase, variableValuesIgnoreCase);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessInstanceApi.GetHistoricProcessInstancesCount: " + e.Message );
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
 **processInstanceId** | **string**| Filter by process instance id. | [optional] 
 **processInstanceIds** | **string**| Filter by process instance ids. Filter by a comma-separated list of &#x60;Strings&#x60;. | [optional] 
 **processDefinitionId** | **string**| Filter by the process definition the instances run on. | [optional] 
 **processDefinitionKey** | **string**| Filter by the key of the process definition the instances run on. | [optional] 
 **processDefinitionKeyIn** | **string**| Filter by a list of process definition keys. A process instance must have one of the given process definition keys. Filter by a comma-separated list of &#x60;Strings&#x60;. | [optional] 
 **processDefinitionName** | **string**| Filter by the name of the process definition the instances run on. | [optional] 
 **processDefinitionNameLike** | **string**| Filter by process definition names that the parameter is a substring of. | [optional] 
 **processDefinitionKeyNotIn** | **string**| Exclude instances that belong to a set of process definitions. Filter by a comma-separated list of &#x60;Strings&#x60;. | [optional] 
 **processInstanceBusinessKey** | **string**| Filter by process instance business key. | [optional] 
 **processInstanceBusinessKeyLike** | **string**| Filter by process instance business key that the parameter is a substring of. | [optional] 
 **rootProcessInstances** | **bool?**| Restrict the query to all process instances that are top level process instances. | [optional] 
 **finished** | **bool?**| Only include finished process instances. This flag includes all process instances that are completed or terminated. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **unfinished** | **bool?**| Only include unfinished process instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **withIncidents** | **bool?**| Only include process instances which have an incident. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **withRootIncidents** | **bool?**| Only include process instances which have a root incident. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **incidentType** | **string**| Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentStatus** | **string**| Only include process instances which have an incident in status either open or resolved. To get all process instances, use the query parameter withIncidents. | [optional] 
 **incidentMessage** | **string**| Filter by the incident message. Exact match. | [optional] 
 **incidentMessageLike** | **string**| Filter by the incident message that the parameter is a substring of. | [optional] 
 **startedBefore** | **DateTime?**| Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedAfter** | **DateTime?**| Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedBefore** | **DateTime?**| Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **finishedAfter** | **DateTime?**| Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **executedActivityAfter** | **DateTime?**| Restrict to instances that executed an activity after the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **executedActivityBefore** | **DateTime?**| Restrict to instances that executed an activity before the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **executedJobAfter** | **DateTime?**| Restrict to instances that executed an job after the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **executedJobBefore** | **DateTime?**| Restrict to instances that executed an job before the given date (inclusive). By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **startedBy** | **string**| Only include process instances that were started by the given user. | [optional] 
 **superProcessInstanceId** | **string**| Restrict query to all process instances that are sub process instances of the given process instance. Takes a process instance id. | [optional] 
 **subProcessInstanceId** | **string**| Restrict query to one process instance that has a sub process instance with the given id. | [optional] 
 **superCaseInstanceId** | **string**| Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. | [optional] 
 **subCaseInstanceId** | **string**| Restrict query to one process instance that has a sub case instance with the given id. | [optional] 
 **caseInstanceId** | **string**| Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. | [optional] 
 **tenantIdIn** | **string**| Filter by a list of tenant ids. A process instance must have one of the given tenant ids. Filter by a comma-separated list of &#x60;Strings&#x60; | [optional] 
 **withoutTenantId** | **bool?**| Only include historic process instances which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **executedActivityIdIn** | **string**| Restrict to instances that executed an activity with one of given ids. Filter by a comma-separated list of &#x60;Strings&#x60; | [optional] 
 **activeActivityIdIn** | **string**| Restrict to instances that have an active activity with one of given ids. Filter by a comma-separated list of &#x60;Strings&#x60; | [optional] 
 **active** | **bool?**| Restrict to instances that are active. | [optional] 
 **suspended** | **bool?**| Restrict to instances that are suspended. | [optional] 
 **completed** | **bool?**| Restrict to instances that are completed. | [optional] 
 **externallyTerminated** | **bool?**| Restrict to instances that are externallyTerminated. | [optional] 
 **internallyTerminated** | **bool?**| Restrict to instances that are internallyTerminated. | [optional] 
 **variables** | **string**| Only include process instances that have/had variables with certain values. Variable filtering expressions are comma-separated and are structured as follows: A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note:** Values are always treated as String objects on server side.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;.  Key and value may not contain underscore or comma characters.  | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match all variable names provided in variables case-insensitively. If set to &#x60;true&#x60; variableName and variablename are treated as equal. | [optional] 
 **variableValuesIgnoreCase** | **bool?**| Match all variable values provided in variables case-insensitively. If set to &#x60;true&#x60; variableValue and variablevalue are treated as equal. | [optional] 

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
| **400** | Bad Request Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistoricprocessinstances"></a>
# **QueryHistoricProcessInstances**
> List&lt;HistoricProcessInstanceDto&gt; QueryHistoricProcessInstances (int? firstResult = null, int? maxResults = null, HistoricProcessInstanceQueryDto historicProcessInstanceQueryDto = null)

Get List (POST)

Queries for historic process instances that fulfill the given parameters. This method is slightly more powerful than the [Get Process Instance](https://docs.camunda.org/manual/7.16/reference/rest/history/process-instance/get-process-instance-query/) because it allows filtering by multiple process variables of types `String`, `Number` or `Boolean`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryHistoricProcessInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricProcessInstanceApi(config);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var historicProcessInstanceQueryDto = new HistoricProcessInstanceQueryDto(); // HistoricProcessInstanceQueryDto |  (optional) 

            try
            {
                // Get List (POST)
                List<HistoricProcessInstanceDto> result = apiInstance.QueryHistoricProcessInstances(firstResult, maxResults, historicProcessInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessInstanceApi.QueryHistoricProcessInstances: " + e.Message );
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
 **historicProcessInstanceQueryDto** | [**HistoricProcessInstanceQueryDto**](HistoricProcessInstanceQueryDto.md)|  | [optional] 

### Return type

[**List&lt;HistoricProcessInstanceDto&gt;**](HistoricProcessInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad Request Returned if some of the query parameters are invalid, for example if a sortOrder parameter is supplied, but no sortBy. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistoricprocessinstancescount"></a>
# **QueryHistoricProcessInstancesCount**
> CountResultDto QueryHistoricProcessInstancesCount (HistoricProcessInstanceQueryDto historicProcessInstanceQueryDto = null)

Get List Count (POST)

Queries for the number of historic process instances that fulfill the given parameters. This method takes the same message body as the [Get Process Instances (POST)](https://docs.camunda.org/manual/7.16/reference/rest/history/process-instance/get-process-instance-query/) method and therefore it is slightly more powerful than the [Get Process Instance Count](https://docs.camunda.org/manual/7.16/reference/rest/history/process-instance/post-process-instance-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryHistoricProcessInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricProcessInstanceApi(config);
            var historicProcessInstanceQueryDto = new HistoricProcessInstanceQueryDto(); // HistoricProcessInstanceQueryDto |  (optional) 

            try
            {
                // Get List Count (POST)
                CountResultDto result = apiInstance.QueryHistoricProcessInstancesCount(historicProcessInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessInstanceApi.QueryHistoricProcessInstancesCount: " + e.Message );
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
 **historicProcessInstanceQueryDto** | [**HistoricProcessInstanceQueryDto**](HistoricProcessInstanceQueryDto.md)|  | [optional] 

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
| **400** | Bad Request Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setremovaltimeasync"></a>
# **SetRemovalTimeAsync**
> BatchDto SetRemovalTimeAsync (SetRemovalTimeToHistoricProcessInstancesDto setRemovalTimeToHistoricProcessInstancesDto = null)

Set Removal Time Async (POST)

Sets the removal time to multiple historic process instances asynchronously (batch).  At least `historicProcessInstanceIds` or `historicProcessInstanceQuery` has to be provided. If both are provided, all instances matching query criterion and instances from the list will be updated with a removal time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SetRemovalTimeAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricProcessInstanceApi(config);
            var setRemovalTimeToHistoricProcessInstancesDto = new SetRemovalTimeToHistoricProcessInstancesDto(); // SetRemovalTimeToHistoricProcessInstancesDto |  (optional) 

            try
            {
                // Set Removal Time Async (POST)
                BatchDto result = apiInstance.SetRemovalTimeAsync(setRemovalTimeToHistoricProcessInstancesDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricProcessInstanceApi.SetRemovalTimeAsync: " + e.Message );
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
 **setRemovalTimeToHistoricProcessInstancesDto** | [**SetRemovalTimeToHistoricProcessInstancesDto**](SetRemovalTimeToHistoricProcessInstancesDto.md)|  | [optional] 

### Return type

[**BatchDto**](BatchDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad Request Request was unsuccessfull due to a bad user request. This occurs if some of the query parameters are invalid, e. g. if neither &#x60;historicProcessInstances&#x60; nor &#x60;historicProcessInstanceQuery&#x60; is present or if no mode is specified.  See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

