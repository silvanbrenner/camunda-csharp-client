# Camunda.OpenApi.Client.Api.HistoricDetailApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHistoricDetails**](HistoricDetailApi.md#gethistoricdetails) | **GET** /history/detail | Get Historic Details
[**GetHistoricDetailsCount**](HistoricDetailApi.md#gethistoricdetailscount) | **GET** /history/detail/count | Get Historic Detail Count
[**HistoricDetail**](HistoricDetailApi.md#historicdetail) | **GET** /history/detail/{id} | Get Historic Detail
[**HistoricDetailBinary**](HistoricDetailApi.md#historicdetailbinary) | **GET** /history/detail/{id}/data | Get Historic Detail (Binary)
[**QueryHistoricDetails**](HistoricDetailApi.md#queryhistoricdetails) | **POST** /history/detail | Get Historic Details (POST)


<a name="gethistoricdetails"></a>
# **GetHistoricDetails**
> List&lt;HistoricDetailDto&gt; GetHistoricDetails (string processInstanceId = null, string processInstanceIdIn = null, string executionId = null, string taskId = null, string activityInstanceId = null, string caseInstanceId = null, string caseExecutionId = null, string variableInstanceId = null, string variableTypeIn = null, string tenantIdIn = null, bool? withoutTenantId = null, string userOperationId = null, bool? formFields = null, bool? variableUpdates = null, bool? excludeTaskDetails = null, bool? initial = null, DateTime? occurredBefore = null, DateTime? occurredAfter = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null, bool? deserializeValues = null)

Get Historic Details

Queries for historic details that fulfill the given parameters. The size of the result set can be retrieved by using the [Get Historic Detail Count](https://docs.camunda.org/manual/7.16/reference/rest/history/detail/get-detail-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricDetailApi(config);
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processInstanceIdIn = processInstanceIdIn_example;  // string | Only include historic details which belong to one of the passed comma-separated process instance ids. (optional) 
            var executionId = executionId_example;  // string | Filter by execution id. (optional) 
            var taskId = taskId_example;  // string | Filter by task id. (optional) 
            var activityInstanceId = activityInstanceId_example;  // string | Filter by activity instance id. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by case instance id. (optional) 
            var caseExecutionId = caseExecutionId_example;  // string | Filter by case execution id. (optional) 
            var variableInstanceId = variableInstanceId_example;  // string | Filter by variable instance id. (optional) 
            var variableTypeIn = variableTypeIn_example;  // string | Only include historic details where the variable updates belong to one of the passed comma-separated list of variable types. A list of all supported variable types can be found [here](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#supported-variable-values). **Note:** All non-primitive variables are associated with the type `serializable`. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic details that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var userOperationId = userOperationId_example;  // string | Filter by a user operation id. (optional) 
            var formFields = true;  // bool? | Only include `HistoricFormFields`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var variableUpdates = true;  // bool? | Only include `HistoricVariableUpdates`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var excludeTaskDetails = true;  // bool? | Excludes all task-related `HistoricDetails`, so only items which have no task id set will be selected. When this parameter is used together with `taskId`, this call is ignored and task details are not excluded. Value may only be `true`, as `false` is the default behavior. (optional) 
            var initial = true;  // bool? | Restrict to historic variable updates that contain only initial variable values. Value may only be `true`, as `false` is the default behavior. (optional) 
            var occurredBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to historic details that occured before the given date (including the date). Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., 2013-01-23T14:42:45.000+0200. (optional) 
            var occurredAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to historic details that occured after the given date (including the date). Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., 2013-01-23T14:42:45.000+0200. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional) 

            try
            {
                // Get Historic Details
                List<HistoricDetailDto> result = apiInstance.GetHistoricDetails(processInstanceId, processInstanceIdIn, executionId, taskId, activityInstanceId, caseInstanceId, caseExecutionId, variableInstanceId, variableTypeIn, tenantIdIn, withoutTenantId, userOperationId, formFields, variableUpdates, excludeTaskDetails, initial, occurredBefore, occurredAfter, sortBy, sortOrder, firstResult, maxResults, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDetailApi.GetHistoricDetails: " + e.Message );
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
 **processInstanceIdIn** | **string**| Only include historic details which belong to one of the passed comma-separated process instance ids. | [optional] 
 **executionId** | **string**| Filter by execution id. | [optional] 
 **taskId** | **string**| Filter by task id. | [optional] 
 **activityInstanceId** | **string**| Filter by activity instance id. | [optional] 
 **caseInstanceId** | **string**| Filter by case instance id. | [optional] 
 **caseExecutionId** | **string**| Filter by case execution id. | [optional] 
 **variableInstanceId** | **string**| Filter by variable instance id. | [optional] 
 **variableTypeIn** | **string**| Only include historic details where the variable updates belong to one of the passed comma-separated list of variable types. A list of all supported variable types can be found [here](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#supported-variable-values). **Note:** All non-primitive variables are associated with the type &#x60;serializable&#x60;. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic details that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **userOperationId** | **string**| Filter by a user operation id. | [optional] 
 **formFields** | **bool?**| Only include &#x60;HistoricFormFields&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **variableUpdates** | **bool?**| Only include &#x60;HistoricVariableUpdates&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **excludeTaskDetails** | **bool?**| Excludes all task-related &#x60;HistoricDetails&#x60;, so only items which have no task id set will be selected. When this parameter is used together with &#x60;taskId&#x60;, this call is ignored and task details are not excluded. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **initial** | **bool?**| Restrict to historic variable updates that contain only initial variable values. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **occurredBefore** | **DateTime?**| Restrict to historic details that occured before the given date (including the date). Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., 2013-01-23T14:42:45.000+0200. | [optional] 
 **occurredAfter** | **DateTime?**| Restrict to historic details that occured after the given date (including the date). Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., 2013-01-23T14:42:45.000+0200. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] 

### Return type

[**List&lt;HistoricDetailDto&gt;**](HistoricDetailDto.md)

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

<a name="gethistoricdetailscount"></a>
# **GetHistoricDetailsCount**
> CountResultDto GetHistoricDetailsCount (string processInstanceId = null, string processInstanceIdIn = null, string executionId = null, string taskId = null, string activityInstanceId = null, string caseInstanceId = null, string caseExecutionId = null, string variableInstanceId = null, string variableTypeIn = null, string tenantIdIn = null, bool? withoutTenantId = null, string userOperationId = null, bool? formFields = null, bool? variableUpdates = null, bool? excludeTaskDetails = null, bool? initial = null, DateTime? occurredBefore = null, DateTime? occurredAfter = null)

Get Historic Detail Count

Queries for the number of historic details that fulfill the given parameters. Takes the same parameters as the [Get Historic Details](https://docs.camunda.org/manual/7.16/reference/rest/history/detail/get-detail-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetHistoricDetailsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricDetailApi(config);
            var processInstanceId = processInstanceId_example;  // string | Filter by process instance id. (optional) 
            var processInstanceIdIn = processInstanceIdIn_example;  // string | Only include historic details which belong to one of the passed comma-separated process instance ids. (optional) 
            var executionId = executionId_example;  // string | Filter by execution id. (optional) 
            var taskId = taskId_example;  // string | Filter by task id. (optional) 
            var activityInstanceId = activityInstanceId_example;  // string | Filter by activity instance id. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by case instance id. (optional) 
            var caseExecutionId = caseExecutionId_example;  // string | Filter by case execution id. (optional) 
            var variableInstanceId = variableInstanceId_example;  // string | Filter by variable instance id. (optional) 
            var variableTypeIn = variableTypeIn_example;  // string | Only include historic details where the variable updates belong to one of the passed comma-separated list of variable types. A list of all supported variable types can be found [here](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#supported-variable-values). **Note:** All non-primitive variables are associated with the type `serializable`. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic details that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var userOperationId = userOperationId_example;  // string | Filter by a user operation id. (optional) 
            var formFields = true;  // bool? | Only include `HistoricFormFields`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var variableUpdates = true;  // bool? | Only include `HistoricVariableUpdates`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var excludeTaskDetails = true;  // bool? | Excludes all task-related `HistoricDetails`, so only items which have no task id set will be selected. When this parameter is used together with `taskId`, this call is ignored and task details are not excluded. Value may only be `true`, as `false` is the default behavior. (optional) 
            var initial = true;  // bool? | Restrict to historic variable updates that contain only initial variable values. Value may only be `true`, as `false` is the default behavior. (optional) 
            var occurredBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to historic details that occured before the given date (including the date). Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., 2013-01-23T14:42:45.000+0200. (optional) 
            var occurredAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Restrict to historic details that occured after the given date (including the date). Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., 2013-01-23T14:42:45.000+0200. (optional) 

            try
            {
                // Get Historic Detail Count
                CountResultDto result = apiInstance.GetHistoricDetailsCount(processInstanceId, processInstanceIdIn, executionId, taskId, activityInstanceId, caseInstanceId, caseExecutionId, variableInstanceId, variableTypeIn, tenantIdIn, withoutTenantId, userOperationId, formFields, variableUpdates, excludeTaskDetails, initial, occurredBefore, occurredAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDetailApi.GetHistoricDetailsCount: " + e.Message );
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
 **processInstanceIdIn** | **string**| Only include historic details which belong to one of the passed comma-separated process instance ids. | [optional] 
 **executionId** | **string**| Filter by execution id. | [optional] 
 **taskId** | **string**| Filter by task id. | [optional] 
 **activityInstanceId** | **string**| Filter by activity instance id. | [optional] 
 **caseInstanceId** | **string**| Filter by case instance id. | [optional] 
 **caseExecutionId** | **string**| Filter by case execution id. | [optional] 
 **variableInstanceId** | **string**| Filter by variable instance id. | [optional] 
 **variableTypeIn** | **string**| Only include historic details where the variable updates belong to one of the passed comma-separated list of variable types. A list of all supported variable types can be found [here](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#supported-variable-values). **Note:** All non-primitive variables are associated with the type &#x60;serializable&#x60;. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic details that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **userOperationId** | **string**| Filter by a user operation id. | [optional] 
 **formFields** | **bool?**| Only include &#x60;HistoricFormFields&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **variableUpdates** | **bool?**| Only include &#x60;HistoricVariableUpdates&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **excludeTaskDetails** | **bool?**| Excludes all task-related &#x60;HistoricDetails&#x60;, so only items which have no task id set will be selected. When this parameter is used together with &#x60;taskId&#x60;, this call is ignored and task details are not excluded. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **initial** | **bool?**| Restrict to historic variable updates that contain only initial variable values. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **occurredBefore** | **DateTime?**| Restrict to historic details that occured before the given date (including the date). Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., 2013-01-23T14:42:45.000+0200. | [optional] 
 **occurredAfter** | **DateTime?**| Restrict to historic details that occured after the given date (including the date). Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., 2013-01-23T14:42:45.000+0200. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="historicdetail"></a>
# **HistoricDetail**
> HistoricDetailDto HistoricDetail (string id, bool? deserializeValue = null)

Get Historic Detail

Retrieves a historic detail by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class HistoricDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricDetailApi(config);
            var id = id_example;  // string | The id of the detail.
            var deserializeValue = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional) 

            try
            {
                // Get Historic Detail
                HistoricDetailDto result = apiInstance.HistoricDetail(id, deserializeValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDetailApi.HistoricDetail: " + e.Message );
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
 **id** | **string**| The id of the detail. | 
 **deserializeValue** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] 

### Return type

[**HistoricDetailDto**](HistoricDetailDto.md)

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

<a name="historicdetailbinary"></a>
# **HistoricDetailBinary**
> System.IO.Stream HistoricDetailBinary (string id)

Get Historic Detail (Binary)

Retrieves the content of a historic variable update by id. Applicable for byte array and file variables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class HistoricDetailBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricDetailApi(config);
            var id = id_example;  // string | The id of the historic variable update.

            try
            {
                // Get Historic Detail (Binary)
                System.IO.Stream result = apiInstance.HistoricDetailBinary(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDetailApi.HistoricDetailBinary: " + e.Message );
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
 **id** | **string**| The id of the historic variable update. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Detail with given id exists but is not a binary variable. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Detail with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistoricdetails"></a>
# **QueryHistoricDetails**
> List&lt;HistoricDetailDto&gt; QueryHistoricDetails (int? firstResult = null, int? maxResults = null, bool? deserializeValues = null, HistoricDetailQueryDto historicDetailQueryDto = null)

Get Historic Details (POST)

Queries for historic details that fulfill the given parameters. This method is slightly more powerful than the [Get Historic Details](https://docs.camunda.org/manual/7.16/reference/rest/history/detail/get-detail-query/) method because it allows sorting by multiple parameters. The size of the result set can be retrieved by using the [Get Historic Detail Count](https://docs.camunda.org/manual/7.16/reference/rest/history/detail/get-detail-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryHistoricDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new HistoricDetailApi(config);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional) 
            var historicDetailQueryDto = new HistoricDetailQueryDto(); // HistoricDetailQueryDto |  (optional) 

            try
            {
                // Get Historic Details (POST)
                List<HistoricDetailDto> result = apiInstance.QueryHistoricDetails(firstResult, maxResults, deserializeValues, historicDetailQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDetailApi.QueryHistoricDetails: " + e.Message );
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
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] 
 **historicDetailQueryDto** | [**HistoricDetailQueryDto**](HistoricDetailQueryDto.md)|  | [optional] 

### Return type

[**List&lt;HistoricDetailDto&gt;**](HistoricDetailDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

