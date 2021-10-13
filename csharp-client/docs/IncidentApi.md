# Camunda.OpenApi.Client.Api.IncidentApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClearIncidentAnnotation**](IncidentApi.md#clearincidentannotation) | **DELETE** /incident/{id}/annotation | Clear Incident Annotation
[**GetIncident**](IncidentApi.md#getincident) | **GET** /incident/{id} | Get Incident
[**GetIncidents**](IncidentApi.md#getincidents) | **GET** /incident | Get List
[**GetIncidentsCount**](IncidentApi.md#getincidentscount) | **GET** /incident/count | Get List Count
[**ResolveIncident**](IncidentApi.md#resolveincident) | **DELETE** /incident/{id} | Resolve Incident
[**SetIncidentAnnotation**](IncidentApi.md#setincidentannotation) | **PUT** /incident/{id}/annotation | Set Incident Annotation


<a name="clearincidentannotation"></a>
# **ClearIncidentAnnotation**
> void ClearIncidentAnnotation (string id)

Clear Incident Annotation

Clears the annotation of an incident with given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ClearIncidentAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new IncidentApi(config);
            var id = id_example;  // string | The id of the incident to clear the annotation at.

            try
            {
                // Clear Incident Annotation
                apiInstance.ClearIncidentAnnotation(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentApi.ClearIncidentAnnotation: " + e.Message );
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
 **id** | **string**| The id of the incident to clear the annotation at. | 

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
| **400** | Returned if no incident can be found for the given id. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getincident"></a>
# **GetIncident**
> IncidentDto GetIncident (string id)

Get Incident

Retrieves an incident by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetIncidentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new IncidentApi(config);
            var id = id_example;  // string | The id of the incident to be retrieved.

            try
            {
                // Get Incident
                IncidentDto result = apiInstance.GetIncident(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentApi.GetIncident: " + e.Message );
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
 **id** | **string**| The id of the incident to be retrieved. | 

### Return type

[**IncidentDto**](IncidentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Returned if an incident with given id does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getincidents"></a>
# **GetIncidents**
> List&lt;IncidentDto&gt; GetIncidents (string incidentId = null, string incidentType = null, string incidentMessage = null, string incidentMessageLike = null, string processDefinitionId = null, string processDefinitionKeyIn = null, string processInstanceId = null, string executionId = null, DateTime? incidentTimestampBefore = null, DateTime? incidentTimestampAfter = null, string activityId = null, string failedActivityId = null, string causeIncidentId = null, string rootCauseIncidentId = null, string configuration = null, string tenantIdIn = null, string jobDefinitionIdIn = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get List

Queries for incidents that fulfill given parameters. The size of the result set can be retrieved by using the [Get Incident Count](https://docs.camunda.org/manual/7.16/reference/rest/incident/get-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetIncidentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new IncidentApi(config);
            var incidentId = incidentId_example;  // string | Restricts to incidents that have the given id. (optional) 
            var incidentType = incidentType_example;  // string | Restricts to incidents that belong to the given incident type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Restricts to incidents that have the given incident message. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Restricts to incidents that incidents message is a substring of the given value. The string can include the wildcard character '%' to express like-strategy: starts with (`string%`), ends with (`%string`) or contains (`%string%`). (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Restricts to incidents that belong to a process definition with the given id. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Restricts to incidents that belong to a process definition with the given keys. Must be a comma-separated list. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Restricts to incidents that belong to a process instance with the given id. (optional) 
            var executionId = executionId_example;  // string | Restricts to incidents that belong to an execution with the given id. (optional) 
            var incidentTimestampBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have an incidentTimestamp date before the given date.  By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var incidentTimestampAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have an incidentTimestamp date after the given date.  By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var activityId = activityId_example;  // string | Restricts to incidents that belong to an activity with the given id. (optional) 
            var failedActivityId = failedActivityId_example;  // string | Restricts to incidents that were created due to the failure of an activity with the given id. (optional) 
            var causeIncidentId = causeIncidentId_example;  // string | Restricts to incidents that have the given incident id as cause incident. (optional) 
            var rootCauseIncidentId = rootCauseIncidentId_example;  // string | Restricts to incidents that have the given incident id as root cause incident. (optional) 
            var configuration = configuration_example;  // string | Restricts to incidents that have the given parameter set as configuration. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Restricts to incidents that have one of the given comma-separated tenant ids. (optional) 
            var jobDefinitionIdIn = jobDefinitionIdIn_example;  // string | Restricts to incidents that have one of the given comma-separated job definition ids. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get List
                List<IncidentDto> result = apiInstance.GetIncidents(incidentId, incidentType, incidentMessage, incidentMessageLike, processDefinitionId, processDefinitionKeyIn, processInstanceId, executionId, incidentTimestampBefore, incidentTimestampAfter, activityId, failedActivityId, causeIncidentId, rootCauseIncidentId, configuration, tenantIdIn, jobDefinitionIdIn, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentApi.GetIncidents: " + e.Message );
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
 **incidentType** | **string**| Restricts to incidents that belong to the given incident type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentMessage** | **string**| Restricts to incidents that have the given incident message. | [optional] 
 **incidentMessageLike** | **string**| Restricts to incidents that incidents message is a substring of the given value. The string can include the wildcard character &#39;%&#39; to express like-strategy: starts with (&#x60;string%&#x60;), ends with (&#x60;%string&#x60;) or contains (&#x60;%string%&#x60;). | [optional] 
 **processDefinitionId** | **string**| Restricts to incidents that belong to a process definition with the given id. | [optional] 
 **processDefinitionKeyIn** | **string**| Restricts to incidents that belong to a process definition with the given keys. Must be a comma-separated list. | [optional] 
 **processInstanceId** | **string**| Restricts to incidents that belong to a process instance with the given id. | [optional] 
 **executionId** | **string**| Restricts to incidents that belong to an execution with the given id. | [optional] 
 **incidentTimestampBefore** | **DateTime?**| Restricts to incidents that have an incidentTimestamp date before the given date.  By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **incidentTimestampAfter** | **DateTime?**| Restricts to incidents that have an incidentTimestamp date after the given date.  By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **activityId** | **string**| Restricts to incidents that belong to an activity with the given id. | [optional] 
 **failedActivityId** | **string**| Restricts to incidents that were created due to the failure of an activity with the given id. | [optional] 
 **causeIncidentId** | **string**| Restricts to incidents that have the given incident id as cause incident. | [optional] 
 **rootCauseIncidentId** | **string**| Restricts to incidents that have the given incident id as root cause incident. | [optional] 
 **configuration** | **string**| Restricts to incidents that have the given parameter set as configuration. | [optional] 
 **tenantIdIn** | **string**| Restricts to incidents that have one of the given comma-separated tenant ids. | [optional] 
 **jobDefinitionIdIn** | **string**| Restricts to incidents that have one of the given comma-separated job definition ids. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;IncidentDto&gt;**](IncidentDto.md)

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

<a name="getincidentscount"></a>
# **GetIncidentsCount**
> CountResultDto GetIncidentsCount (string incidentId = null, string incidentType = null, string incidentMessage = null, string incidentMessageLike = null, string processDefinitionId = null, string processDefinitionKeyIn = null, string processInstanceId = null, string executionId = null, DateTime? incidentTimestampBefore = null, DateTime? incidentTimestampAfter = null, string activityId = null, string failedActivityId = null, string causeIncidentId = null, string rootCauseIncidentId = null, string configuration = null, string tenantIdIn = null, string jobDefinitionIdIn = null)

Get List Count

Queries for the number of incidents that fulfill given parameters. Takes the same parameters as the [Get Incidents](https://docs.camunda.org/manual/7.16/reference/rest/incident/get-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetIncidentsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new IncidentApi(config);
            var incidentId = incidentId_example;  // string | Restricts to incidents that have the given id. (optional) 
            var incidentType = incidentType_example;  // string | Restricts to incidents that belong to the given incident type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Restricts to incidents that have the given incident message. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Restricts to incidents that incidents message is a substring of the given value. The string can include the wildcard character '%' to express like-strategy: starts with (`string%`), ends with (`%string`) or contains (`%string%`). (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Restricts to incidents that belong to a process definition with the given id. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Restricts to incidents that belong to a process definition with the given keys. Must be a comma-separated list. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Restricts to incidents that belong to a process instance with the given id. (optional) 
            var executionId = executionId_example;  // string | Restricts to incidents that belong to an execution with the given id. (optional) 
            var incidentTimestampBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have an incidentTimestamp date before the given date.  By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var incidentTimestampAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to incidents that have an incidentTimestamp date after the given date.  By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var activityId = activityId_example;  // string | Restricts to incidents that belong to an activity with the given id. (optional) 
            var failedActivityId = failedActivityId_example;  // string | Restricts to incidents that were created due to the failure of an activity with the given id. (optional) 
            var causeIncidentId = causeIncidentId_example;  // string | Restricts to incidents that have the given incident id as cause incident. (optional) 
            var rootCauseIncidentId = rootCauseIncidentId_example;  // string | Restricts to incidents that have the given incident id as root cause incident. (optional) 
            var configuration = configuration_example;  // string | Restricts to incidents that have the given parameter set as configuration. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Restricts to incidents that have one of the given comma-separated tenant ids. (optional) 
            var jobDefinitionIdIn = jobDefinitionIdIn_example;  // string | Restricts to incidents that have one of the given comma-separated job definition ids. (optional) 

            try
            {
                // Get List Count
                CountResultDto result = apiInstance.GetIncidentsCount(incidentId, incidentType, incidentMessage, incidentMessageLike, processDefinitionId, processDefinitionKeyIn, processInstanceId, executionId, incidentTimestampBefore, incidentTimestampAfter, activityId, failedActivityId, causeIncidentId, rootCauseIncidentId, configuration, tenantIdIn, jobDefinitionIdIn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentApi.GetIncidentsCount: " + e.Message );
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
 **incidentType** | **string**| Restricts to incidents that belong to the given incident type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentMessage** | **string**| Restricts to incidents that have the given incident message. | [optional] 
 **incidentMessageLike** | **string**| Restricts to incidents that incidents message is a substring of the given value. The string can include the wildcard character &#39;%&#39; to express like-strategy: starts with (&#x60;string%&#x60;), ends with (&#x60;%string&#x60;) or contains (&#x60;%string%&#x60;). | [optional] 
 **processDefinitionId** | **string**| Restricts to incidents that belong to a process definition with the given id. | [optional] 
 **processDefinitionKeyIn** | **string**| Restricts to incidents that belong to a process definition with the given keys. Must be a comma-separated list. | [optional] 
 **processInstanceId** | **string**| Restricts to incidents that belong to a process instance with the given id. | [optional] 
 **executionId** | **string**| Restricts to incidents that belong to an execution with the given id. | [optional] 
 **incidentTimestampBefore** | **DateTime?**| Restricts to incidents that have an incidentTimestamp date before the given date.  By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **incidentTimestampAfter** | **DateTime?**| Restricts to incidents that have an incidentTimestamp date after the given date.  By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **activityId** | **string**| Restricts to incidents that belong to an activity with the given id. | [optional] 
 **failedActivityId** | **string**| Restricts to incidents that were created due to the failure of an activity with the given id. | [optional] 
 **causeIncidentId** | **string**| Restricts to incidents that have the given incident id as cause incident. | [optional] 
 **rootCauseIncidentId** | **string**| Restricts to incidents that have the given incident id as root cause incident. | [optional] 
 **configuration** | **string**| Restricts to incidents that have the given parameter set as configuration. | [optional] 
 **tenantIdIn** | **string**| Restricts to incidents that have one of the given comma-separated tenant ids. | [optional] 
 **jobDefinitionIdIn** | **string**| Restricts to incidents that have one of the given comma-separated job definition ids. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolveincident"></a>
# **ResolveIncident**
> void ResolveIncident (string id)

Resolve Incident

Resolves an incident with given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ResolveIncidentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new IncidentApi(config);
            var id = id_example;  // string | The id of the incident to be resolved.

            try
            {
                // Resolve Incident
                apiInstance.ResolveIncident(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentApi.ResolveIncident: " + e.Message );
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
 **id** | **string**| The id of the incident to be resolved. | 

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
| **404** | Returned if an incident with given id does not exist. |  -  |
| **400** | Returned if an incident is not related to any execution or an incident is of type &#x60;failedJob&#x60; or &#x60;failedExternalTask&#x60;. To resolve such an incident, please refer to the [Incident Types](https://docs.camunda.org/manual/7.16/user-guide/process-engine/incidents/#incident-types) section. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setincidentannotation"></a>
# **SetIncidentAnnotation**
> void SetIncidentAnnotation (string id, AnnotationDto annotationDto = null)

Set Incident Annotation

Sets the annotation of an incident with given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SetIncidentAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new IncidentApi(config);
            var id = id_example;  // string | The id of the incident to clear the annotation at.
            var annotationDto = new AnnotationDto(); // AnnotationDto |  (optional) 

            try
            {
                // Set Incident Annotation
                apiInstance.SetIncidentAnnotation(id, annotationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentApi.SetIncidentAnnotation: " + e.Message );
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
 **id** | **string**| The id of the incident to clear the annotation at. | 
 **annotationDto** | [**AnnotationDto**](AnnotationDto.md)|  | [optional] 

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
| **204** | Request successful. |  -  |
| **400** | Returned if no incident can be found for the given id. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

