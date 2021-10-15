# Camunda.OpenApi.Client.Api.HistoricIncidentApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHistoricIncidents**](HistoricIncidentApi.md#gethistoricincidents) | **GET** /history/incident | Get Incidents
[**GetHistoricIncidentsCount**](HistoricIncidentApi.md#gethistoricincidentscount) | **GET** /history/incident/count | Get Incident Count


<a name="gethistoricincidents"></a>
# **GetHistoricIncidents**
> List&lt;HistoricIncidentDto&gt; GetHistoricIncidents (string incidentId = null, string incidentType = null, string incidentMessage = null, string incidentMessageLike = null, string processDefinitionId = null, string processDefinitionKey = null, string processDefinitionKeyIn = null, string processInstanceId = null, string executionId = null, DateTime? createTimeBefore = null, DateTime? createTimeAfter = null, DateTime? endTimeBefore = null, DateTime? endTimeAfter = null, string activityId = null, string failedActivityId = null, string causeIncidentId = null, string rootCauseIncidentId = null, string configuration = null, string historyConfiguration = null, bool? open = null, bool? resolved = null, bool? deleted = null, string tenantIdIn = null, bool? withoutTenantId = null, string jobDefinitionIdIn = null, string sortBy = null, string sortOrder = null)

Get Incidents

Queries for historic incidents that fulfill given parameters. The size of the result set can be retrieved by using the [Get Incident Count](https://docs.camunda.org/manual/7.16/reference/rest/history/incident/get-incident-query-count/) method.

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
    public class GetHistoricIncidentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricIncidentApi(httpClient, config, httpClientHandler);
            var incidentId = incidentId_example;  // string | Restricts to incidents that have the given id. (optional) 
            var incidentType = incidentType_example;  // string | Restricts to incidents that belong to the given incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Restricts to incidents that have the given incident message. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Restricts to incidents that incidents message is a substring of the given value. The string can include the wildcard character '%' to express like-strategy: starts with (string%), ends with (%string) or contains (%string%).  (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Restricts to incidents that belong to a process definition with the given id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Restricts to incidents that have the given processDefinitionKey. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Restricts to incidents that have one of the given process definition keys. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Restricts to incidents that belong to a process instance with the given id. (optional) 
            var executionId = executionId_example;  // string | Restricts to incidents that belong to an execution with the given id. (optional) 
            var createTimeBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have a createTime date before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var createTimeAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have a createTime date after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var endTimeBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have an endTimeBefore date before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var endTimeAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have an endTimeAfter date after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var activityId = activityId_example;  // string | Restricts to incidents that belong to an activity with the given id. (optional) 
            var failedActivityId = failedActivityId_example;  // string | Restricts to incidents that were created due to the failure of an activity with the given id. (optional) 
            var causeIncidentId = causeIncidentId_example;  // string | Restricts to incidents that have the given incident id as cause incident. (optional) 
            var rootCauseIncidentId = rootCauseIncidentId_example;  // string | Restricts to incidents that have the given incident id as root cause incident. (optional) 
            var configuration = configuration_example;  // string | Restricts to incidents that have the given parameter set as configuration. (optional) 
            var historyConfiguration = historyConfiguration_example;  // string | Restricts to incidents that have the given parameter set as history configuration. (optional) 
            var open = true;  // bool? | Restricts to incidents that are open. (optional) 
            var resolved = true;  // bool? | Restricts to incidents that are resolved. (optional) 
            var deleted = true;  // bool? | Restricts to incidents that are deleted. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Restricts to incidents that have one of the given comma-separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic incidents that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var jobDefinitionIdIn = jobDefinitionIdIn_example;  // string | Restricts to incidents that have one of the given comma-separated job definition ids. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 

            try
            {
                // Get Incidents
                List<HistoricIncidentDto> result = apiInstance.GetHistoricIncidents(incidentId, incidentType, incidentMessage, incidentMessageLike, processDefinitionId, processDefinitionKey, processDefinitionKeyIn, processInstanceId, executionId, createTimeBefore, createTimeAfter, endTimeBefore, endTimeAfter, activityId, failedActivityId, causeIncidentId, rootCauseIncidentId, configuration, historyConfiguration, open, resolved, deleted, tenantIdIn, withoutTenantId, jobDefinitionIdIn, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricIncidentApi.GetHistoricIncidents: " + e.Message );
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
 **incidentId** | **string**| Restricts to incidents that have the given id. | [optional] 
 **incidentType** | **string**| Restricts to incidents that belong to the given incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentMessage** | **string**| Restricts to incidents that have the given incident message. | [optional] 
 **incidentMessageLike** | **string**| Restricts to incidents that incidents message is a substring of the given value. The string can include the wildcard character &#39;%&#39; to express like-strategy: starts with (string%), ends with (%string) or contains (%string%).  | [optional] 
 **processDefinitionId** | **string**| Restricts to incidents that belong to a process definition with the given id. | [optional] 
 **processDefinitionKey** | **string**| Restricts to incidents that have the given processDefinitionKey. | [optional] 
 **processDefinitionKeyIn** | **string**| Restricts to incidents that have one of the given process definition keys. | [optional] 
 **processInstanceId** | **string**| Restricts to incidents that belong to a process instance with the given id. | [optional] 
 **executionId** | **string**| Restricts to incidents that belong to an execution with the given id. | [optional] 
 **createTimeBefore** | **DateTime?**| Restricts to incidents that have a createTime date before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **createTimeAfter** | **DateTime?**| Restricts to incidents that have a createTime date after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **endTimeBefore** | **DateTime?**| Restricts to incidents that have an endTimeBefore date before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **endTimeAfter** | **DateTime?**| Restricts to incidents that have an endTimeAfter date after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **activityId** | **string**| Restricts to incidents that belong to an activity with the given id. | [optional] 
 **failedActivityId** | **string**| Restricts to incidents that were created due to the failure of an activity with the given id. | [optional] 
 **causeIncidentId** | **string**| Restricts to incidents that have the given incident id as cause incident. | [optional] 
 **rootCauseIncidentId** | **string**| Restricts to incidents that have the given incident id as root cause incident. | [optional] 
 **configuration** | **string**| Restricts to incidents that have the given parameter set as configuration. | [optional] 
 **historyConfiguration** | **string**| Restricts to incidents that have the given parameter set as history configuration. | [optional] 
 **open** | **bool?**| Restricts to incidents that are open. | [optional] 
 **resolved** | **bool?**| Restricts to incidents that are resolved. | [optional] 
 **deleted** | **bool?**| Restricts to incidents that are deleted. | [optional] 
 **tenantIdIn** | **string**| Restricts to incidents that have one of the given comma-separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic incidents that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **jobDefinitionIdIn** | **string**| Restricts to incidents that have one of the given comma-separated job definition ids. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 

### Return type

[**List&lt;HistoricIncidentDto&gt;**](HistoricIncidentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricincidentscount"></a>
# **GetHistoricIncidentsCount**
> CountResultDto GetHistoricIncidentsCount (string incidentId = null, string incidentType = null, string incidentMessage = null, string incidentMessageLike = null, string processDefinitionId = null, string processDefinitionKey = null, string processDefinitionKeyIn = null, string processInstanceId = null, string executionId = null, DateTime? createTimeBefore = null, DateTime? createTimeAfter = null, DateTime? endTimeBefore = null, DateTime? endTimeAfter = null, string activityId = null, string failedActivityId = null, string causeIncidentId = null, string rootCauseIncidentId = null, string configuration = null, string historyConfiguration = null, bool? open = null, bool? resolved = null, bool? deleted = null, string tenantIdIn = null, bool? withoutTenantId = null, string jobDefinitionIdIn = null, string sortBy = null, string sortOrder = null)

Get Incident Count

Queries for the number of historic incidents that fulfill the given parameters. Takes the same parameters as the [Get Incidents](https://docs.camunda.org/manual/7.16/reference/rest/history/incident/get-incident-query/) method.

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
    public class GetHistoricIncidentsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricIncidentApi(httpClient, config, httpClientHandler);
            var incidentId = incidentId_example;  // string | Restricts to incidents that have the given id. (optional) 
            var incidentType = incidentType_example;  // string | Restricts to incidents that belong to the given incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Restricts to incidents that have the given incident message. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Restricts to incidents that incidents message is a substring of the given value. The string can include the wildcard character '%' to express like-strategy: starts with (string%), ends with (%string) or contains (%string%).  (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Restricts to incidents that belong to a process definition with the given id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Restricts to incidents that have the given processDefinitionKey. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Restricts to incidents that have one of the given process definition keys. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Restricts to incidents that belong to a process instance with the given id. (optional) 
            var executionId = executionId_example;  // string | Restricts to incidents that belong to an execution with the given id. (optional) 
            var createTimeBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have a createTime date before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var createTimeAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have a createTime date after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var endTimeBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have an endTimeBefore date before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var endTimeAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have an endTimeAfter date after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var activityId = activityId_example;  // string | Restricts to incidents that belong to an activity with the given id. (optional) 
            var failedActivityId = failedActivityId_example;  // string | Restricts to incidents that were created due to the failure of an activity with the given id. (optional) 
            var causeIncidentId = causeIncidentId_example;  // string | Restricts to incidents that have the given incident id as cause incident. (optional) 
            var rootCauseIncidentId = rootCauseIncidentId_example;  // string | Restricts to incidents that have the given incident id as root cause incident. (optional) 
            var configuration = configuration_example;  // string | Restricts to incidents that have the given parameter set as configuration. (optional) 
            var historyConfiguration = historyConfiguration_example;  // string | Restricts to incidents that have the given parameter set as history configuration. (optional) 
            var open = true;  // bool? | Restricts to incidents that are open. (optional) 
            var resolved = true;  // bool? | Restricts to incidents that are resolved. (optional) 
            var deleted = true;  // bool? | Restricts to incidents that are deleted. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Restricts to incidents that have one of the given comma-separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic incidents that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var jobDefinitionIdIn = jobDefinitionIdIn_example;  // string | Restricts to incidents that have one of the given comma-separated job definition ids. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 

            try
            {
                // Get Incident Count
                CountResultDto result = apiInstance.GetHistoricIncidentsCount(incidentId, incidentType, incidentMessage, incidentMessageLike, processDefinitionId, processDefinitionKey, processDefinitionKeyIn, processInstanceId, executionId, createTimeBefore, createTimeAfter, endTimeBefore, endTimeAfter, activityId, failedActivityId, causeIncidentId, rootCauseIncidentId, configuration, historyConfiguration, open, resolved, deleted, tenantIdIn, withoutTenantId, jobDefinitionIdIn, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricIncidentApi.GetHistoricIncidentsCount: " + e.Message );
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
 **incidentId** | **string**| Restricts to incidents that have the given id. | [optional] 
 **incidentType** | **string**| Restricts to incidents that belong to the given incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentMessage** | **string**| Restricts to incidents that have the given incident message. | [optional] 
 **incidentMessageLike** | **string**| Restricts to incidents that incidents message is a substring of the given value. The string can include the wildcard character &#39;%&#39; to express like-strategy: starts with (string%), ends with (%string) or contains (%string%).  | [optional] 
 **processDefinitionId** | **string**| Restricts to incidents that belong to a process definition with the given id. | [optional] 
 **processDefinitionKey** | **string**| Restricts to incidents that have the given processDefinitionKey. | [optional] 
 **processDefinitionKeyIn** | **string**| Restricts to incidents that have one of the given process definition keys. | [optional] 
 **processInstanceId** | **string**| Restricts to incidents that belong to a process instance with the given id. | [optional] 
 **executionId** | **string**| Restricts to incidents that belong to an execution with the given id. | [optional] 
 **createTimeBefore** | **DateTime?**| Restricts to incidents that have a createTime date before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **createTimeAfter** | **DateTime?**| Restricts to incidents that have a createTime date after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **endTimeBefore** | **DateTime?**| Restricts to incidents that have an endTimeBefore date before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **endTimeAfter** | **DateTime?**| Restricts to incidents that have an endTimeAfter date after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **activityId** | **string**| Restricts to incidents that belong to an activity with the given id. | [optional] 
 **failedActivityId** | **string**| Restricts to incidents that were created due to the failure of an activity with the given id. | [optional] 
 **causeIncidentId** | **string**| Restricts to incidents that have the given incident id as cause incident. | [optional] 
 **rootCauseIncidentId** | **string**| Restricts to incidents that have the given incident id as root cause incident. | [optional] 
 **configuration** | **string**| Restricts to incidents that have the given parameter set as configuration. | [optional] 
 **historyConfiguration** | **string**| Restricts to incidents that have the given parameter set as history configuration. | [optional] 
 **open** | **bool?**| Restricts to incidents that are open. | [optional] 
 **resolved** | **bool?**| Restricts to incidents that are resolved. | [optional] 
 **deleted** | **bool?**| Restricts to incidents that are deleted. | [optional] 
 **tenantIdIn** | **string**| Restricts to incidents that have one of the given comma-separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic incidents that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **jobDefinitionIdIn** | **string**| Restricts to incidents that have one of the given comma-separated job definition ids. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

