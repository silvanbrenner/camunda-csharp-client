# Camunda.OpenApi.Client.Api.HistoricVariableInstanceApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteHistoricVariableInstance**](HistoricVariableInstanceApi.md#deletehistoricvariableinstance) | **DELETE** /history/variable-instance/{id} | Delete Variable Instance
[**GetHistoricVariableInstance**](HistoricVariableInstanceApi.md#gethistoricvariableinstance) | **GET** /history/variable-instance/{id} | Get Variable Instance
[**GetHistoricVariableInstanceBinary**](HistoricVariableInstanceApi.md#gethistoricvariableinstancebinary) | **GET** /history/variable-instance/{id}/data | Get Variable Instance (Binary)
[**GetHistoricVariableInstances**](HistoricVariableInstanceApi.md#gethistoricvariableinstances) | **GET** /history/variable-instance | Get Variable Instances
[**GetHistoricVariableInstancesCount**](HistoricVariableInstanceApi.md#gethistoricvariableinstancescount) | **GET** /history/variable-instance/count | Get Variable Instance Count
[**QueryHistoricVariableInstances**](HistoricVariableInstanceApi.md#queryhistoricvariableinstances) | **POST** /history/variable-instance | Get Variable Instances (POST)
[**QueryHistoricVariableInstancesCount**](HistoricVariableInstanceApi.md#queryhistoricvariableinstancescount) | **POST** /history/variable-instance/count | Get Variable Instance Count (POST)


<a name="deletehistoricvariableinstance"></a>
# **DeleteHistoricVariableInstance**
> void DeleteHistoricVariableInstance (string id)

Delete Variable Instance

Deletes a historic variable instance by id.

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
    public class DeleteHistoricVariableInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricVariableInstanceApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the variable instance.

            try
            {
                // Delete Variable Instance
                apiInstance.DeleteHistoricVariableInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricVariableInstanceApi.DeleteHistoricVariableInstance: " + e.Message );
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
 **id** | **string**| The id of the variable instance. | 

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
| **204** | Request successful. This method returns no content. |  -  |
| **404** | Variable with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricvariableinstance"></a>
# **GetHistoricVariableInstance**
> HistoricVariableInstanceDto GetHistoricVariableInstance (string id, bool? deserializeValues = null)

Get Variable Instance

Retrieves a historic variable by id.

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
    public class GetHistoricVariableInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricVariableInstanceApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the variable instance.
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional) 

            try
            {
                // Get Variable Instance
                HistoricVariableInstanceDto result = apiInstance.GetHistoricVariableInstance(id, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricVariableInstanceApi.GetHistoricVariableInstance: " + e.Message );
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
 **id** | **string**| The id of the variable instance. | 
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] 

### Return type

[**HistoricVariableInstanceDto**](HistoricVariableInstanceDto.md)

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

<a name="gethistoricvariableinstancebinary"></a>
# **GetHistoricVariableInstanceBinary**
> FileParameter GetHistoricVariableInstanceBinary (string id)

Get Variable Instance (Binary)

Retrieves the content of a historic variable by id. Applicable for variables that are serialized as binary data.

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
    public class GetHistoricVariableInstanceBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricVariableInstanceApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the variable instance.

            try
            {
                // Get Variable Instance (Binary)
                FileParameter result = apiInstance.GetHistoricVariableInstanceBinary(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricVariableInstanceApi.GetHistoricVariableInstanceBinary: " + e.Message );
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
 **id** | **string**| The id of the variable instance. | 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Variable with given id exists but is not a binary variable. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Variable with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricvariableinstances"></a>
# **GetHistoricVariableInstances**
> List&lt;HistoricVariableInstanceDto&gt; GetHistoricVariableInstances (string variableName = null, string variableNameLike = null, Object variableValue = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null, string variableTypeIn = null, bool? includeDeleted = null, string processInstanceId = null, string processInstanceIdIn = null, string processDefinitionId = null, string processDefinitionKey = null, string executionIdIn = null, string caseInstanceId = null, string caseExecutionIdIn = null, string caseActivityIdIn = null, string taskIdIn = null, string activityInstanceIdIn = null, string tenantIdIn = null, bool? withoutTenantId = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null, bool? deserializeValues = null)

Get Variable Instances

Queries for historic variable instances that fulfill the given parameters. The size of the result set can be retrieved by using the [Get Variable Instance Count](https://docs.camunda.org/manual/7.16/reference/rest/history/variable-instance/get-variable-instance-query-count/) method.

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
    public class GetHistoricVariableInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricVariableInstanceApi(httpClient, config, httpClientHandler);
            var variableName = variableName_example;  // string | Filter by variable name. (optional) 
            var variableNameLike = variableNameLike_example;  // string | Restrict to variables with a name like the parameter. (optional) 
            var variableValue = new Object(); // Object | Filter by variable value. Is treated as a `String` object on server side. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match the variable name provided in `variableName` and `variableNameLike` case- insensitively. If set to `true` **variableName** and **variablename** are treated as equal. (optional) 
            var variableValuesIgnoreCase = true;  // bool? | Match the variable value provided in `variableValue` case-insensitively. If set to `true` **variableValue** and **variablevalue** are treated as equal. (optional) 
            var variableTypeIn = variableTypeIn_example;  // string | Only include historic variable instances which belong to one of the passed and comma- separated variable types. A list of all supported variable types can be found [here](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#supported-variable-values). **Note:** All non-primitive variables are associated with the type 'serializable'. (optional) 
            var includeDeleted = true;  // bool? | Include variables that has already been deleted during the execution. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by the process instance the variable belongs to. (optional) 
            var processInstanceIdIn = processInstanceIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and comma-separated process instance ids. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the process definition the variable belongs to. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by a key of the process definition the variable belongs to. (optional) 
            var executionIdIn = executionIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and and comma-separated execution ids. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by the case instance the variable belongs to. (optional) 
            var caseExecutionIdIn = caseExecutionIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and and comma-separated case execution ids. (optional) 
            var caseActivityIdIn = caseActivityIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and and comma-separated case activity ids. (optional) 
            var taskIdIn = taskIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and and comma-separated task ids. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and and comma-separated activity instance ids. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and comma- separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic variable instances that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional) 

            try
            {
                // Get Variable Instances
                List<HistoricVariableInstanceDto> result = apiInstance.GetHistoricVariableInstances(variableName, variableNameLike, variableValue, variableNamesIgnoreCase, variableValuesIgnoreCase, variableTypeIn, includeDeleted, processInstanceId, processInstanceIdIn, processDefinitionId, processDefinitionKey, executionIdIn, caseInstanceId, caseExecutionIdIn, caseActivityIdIn, taskIdIn, activityInstanceIdIn, tenantIdIn, withoutTenantId, sortBy, sortOrder, firstResult, maxResults, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricVariableInstanceApi.GetHistoricVariableInstances: " + e.Message );
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
 **variableName** | **string**| Filter by variable name. | [optional] 
 **variableNameLike** | **string**| Restrict to variables with a name like the parameter. | [optional] 
 **variableValue** | [**Object**](Object.md)| Filter by variable value. Is treated as a &#x60;String&#x60; object on server side. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match the variable name provided in &#x60;variableName&#x60; and &#x60;variableNameLike&#x60; case- insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal. | [optional] 
 **variableValuesIgnoreCase** | **bool?**| Match the variable value provided in &#x60;variableValue&#x60; case-insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal. | [optional] 
 **variableTypeIn** | **string**| Only include historic variable instances which belong to one of the passed and comma- separated variable types. A list of all supported variable types can be found [here](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#supported-variable-values). **Note:** All non-primitive variables are associated with the type &#39;serializable&#39;. | [optional] 
 **includeDeleted** | **bool?**| Include variables that has already been deleted during the execution. | [optional] 
 **processInstanceId** | **string**| Filter by the process instance the variable belongs to. | [optional] 
 **processInstanceIdIn** | **string**| Only include historic variable instances which belong to one of the passed and comma-separated process instance ids. | [optional] 
 **processDefinitionId** | **string**| Filter by the process definition the variable belongs to. | [optional] 
 **processDefinitionKey** | **string**| Filter by a key of the process definition the variable belongs to. | [optional] 
 **executionIdIn** | **string**| Only include historic variable instances which belong to one of the passed and and comma-separated execution ids. | [optional] 
 **caseInstanceId** | **string**| Filter by the case instance the variable belongs to. | [optional] 
 **caseExecutionIdIn** | **string**| Only include historic variable instances which belong to one of the passed and and comma-separated case execution ids. | [optional] 
 **caseActivityIdIn** | **string**| Only include historic variable instances which belong to one of the passed and and comma-separated case activity ids. | [optional] 
 **taskIdIn** | **string**| Only include historic variable instances which belong to one of the passed and and comma-separated task ids. | [optional] 
 **activityInstanceIdIn** | **string**| Only include historic variable instances which belong to one of the passed and and comma-separated activity instance ids. | [optional] 
 **tenantIdIn** | **string**| Only include historic variable instances which belong to one of the passed and comma- separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic variable instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] 

### Return type

[**List&lt;HistoricVariableInstanceDto&gt;**](HistoricVariableInstanceDto.md)

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

<a name="gethistoricvariableinstancescount"></a>
# **GetHistoricVariableInstancesCount**
> CountResultDto GetHistoricVariableInstancesCount (string variableName = null, string variableNameLike = null, Object variableValue = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null, string variableTypeIn = null, bool? includeDeleted = null, string processInstanceId = null, string processInstanceIdIn = null, string processDefinitionId = null, string processDefinitionKey = null, string executionIdIn = null, string caseInstanceId = null, string caseExecutionIdIn = null, string caseActivityIdIn = null, string taskIdIn = null, string activityInstanceIdIn = null, string tenantIdIn = null, bool? withoutTenantId = null)

Get Variable Instance Count

Queries for the number of historic variable instances that fulfill the given parameters. Takes the same parameters as the [Get Variable Instances](https://docs.camunda.org/manual/7.16/reference/rest/history/variable-instance/get-variable-instance-query/) method.

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
    public class GetHistoricVariableInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricVariableInstanceApi(httpClient, config, httpClientHandler);
            var variableName = variableName_example;  // string | Filter by variable name. (optional) 
            var variableNameLike = variableNameLike_example;  // string | Restrict to variables with a name like the parameter. (optional) 
            var variableValue = new Object(); // Object | Filter by variable value. Is treated as a `String` object on server side. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match the variable name provided in `variableName` and `variableNameLike` case- insensitively. If set to `true` **variableName** and **variablename** are treated as equal. (optional) 
            var variableValuesIgnoreCase = true;  // bool? | Match the variable value provided in `variableValue` case-insensitively. If set to `true` **variableValue** and **variablevalue** are treated as equal. (optional) 
            var variableTypeIn = variableTypeIn_example;  // string | Only include historic variable instances which belong to one of the passed and comma- separated variable types. A list of all supported variable types can be found [here](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#supported-variable-values). **Note:** All non-primitive variables are associated with the type 'serializable'. (optional) 
            var includeDeleted = true;  // bool? | Include variables that has already been deleted during the execution. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Filter by the process instance the variable belongs to. (optional) 
            var processInstanceIdIn = processInstanceIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and comma-separated process instance ids. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the process definition the variable belongs to. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by a key of the process definition the variable belongs to. (optional) 
            var executionIdIn = executionIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and and comma-separated execution ids. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by the case instance the variable belongs to. (optional) 
            var caseExecutionIdIn = caseExecutionIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and and comma-separated case execution ids. (optional) 
            var caseActivityIdIn = caseActivityIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and and comma-separated case activity ids. (optional) 
            var taskIdIn = taskIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and and comma-separated task ids. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and and comma-separated activity instance ids. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include historic variable instances which belong to one of the passed and comma- separated tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include historic variable instances that belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get Variable Instance Count
                CountResultDto result = apiInstance.GetHistoricVariableInstancesCount(variableName, variableNameLike, variableValue, variableNamesIgnoreCase, variableValuesIgnoreCase, variableTypeIn, includeDeleted, processInstanceId, processInstanceIdIn, processDefinitionId, processDefinitionKey, executionIdIn, caseInstanceId, caseExecutionIdIn, caseActivityIdIn, taskIdIn, activityInstanceIdIn, tenantIdIn, withoutTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricVariableInstanceApi.GetHistoricVariableInstancesCount: " + e.Message );
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
 **variableName** | **string**| Filter by variable name. | [optional] 
 **variableNameLike** | **string**| Restrict to variables with a name like the parameter. | [optional] 
 **variableValue** | [**Object**](Object.md)| Filter by variable value. Is treated as a &#x60;String&#x60; object on server side. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match the variable name provided in &#x60;variableName&#x60; and &#x60;variableNameLike&#x60; case- insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal. | [optional] 
 **variableValuesIgnoreCase** | **bool?**| Match the variable value provided in &#x60;variableValue&#x60; case-insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal. | [optional] 
 **variableTypeIn** | **string**| Only include historic variable instances which belong to one of the passed and comma- separated variable types. A list of all supported variable types can be found [here](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#supported-variable-values). **Note:** All non-primitive variables are associated with the type &#39;serializable&#39;. | [optional] 
 **includeDeleted** | **bool?**| Include variables that has already been deleted during the execution. | [optional] 
 **processInstanceId** | **string**| Filter by the process instance the variable belongs to. | [optional] 
 **processInstanceIdIn** | **string**| Only include historic variable instances which belong to one of the passed and comma-separated process instance ids. | [optional] 
 **processDefinitionId** | **string**| Filter by the process definition the variable belongs to. | [optional] 
 **processDefinitionKey** | **string**| Filter by a key of the process definition the variable belongs to. | [optional] 
 **executionIdIn** | **string**| Only include historic variable instances which belong to one of the passed and and comma-separated execution ids. | [optional] 
 **caseInstanceId** | **string**| Filter by the case instance the variable belongs to. | [optional] 
 **caseExecutionIdIn** | **string**| Only include historic variable instances which belong to one of the passed and and comma-separated case execution ids. | [optional] 
 **caseActivityIdIn** | **string**| Only include historic variable instances which belong to one of the passed and and comma-separated case activity ids. | [optional] 
 **taskIdIn** | **string**| Only include historic variable instances which belong to one of the passed and and comma-separated task ids. | [optional] 
 **activityInstanceIdIn** | **string**| Only include historic variable instances which belong to one of the passed and and comma-separated activity instance ids. | [optional] 
 **tenantIdIn** | **string**| Only include historic variable instances which belong to one of the passed and comma- separated tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include historic variable instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

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

<a name="queryhistoricvariableinstances"></a>
# **QueryHistoricVariableInstances**
> List&lt;HistoricVariableInstanceDto&gt; QueryHistoricVariableInstances (int? firstResult = null, int? maxResults = null, bool? deserializeValues = null, HistoricVariableInstanceQueryDto historicVariableInstanceQueryDto = null)

Get Variable Instances (POST)

Queries for historic variable instances that fulfill the given parameters. This method is slightly more powerful than the [Get Variable Instances](https://docs.camunda.org/manual/7.16/reference/rest/history/variable-instance/get-variable-instance-query/) method because it allows filtering by variable values of the different types `String`, `Number` or `Boolean`.

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
    public class QueryHistoricVariableInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricVariableInstanceApi(httpClient, config, httpClientHandler);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional) 
            var historicVariableInstanceQueryDto = new HistoricVariableInstanceQueryDto(); // HistoricVariableInstanceQueryDto |  (optional) 

            try
            {
                // Get Variable Instances (POST)
                List<HistoricVariableInstanceDto> result = apiInstance.QueryHistoricVariableInstances(firstResult, maxResults, deserializeValues, historicVariableInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricVariableInstanceApi.QueryHistoricVariableInstances: " + e.Message );
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
 **historicVariableInstanceQueryDto** | [**HistoricVariableInstanceQueryDto**](HistoricVariableInstanceQueryDto.md)|  | [optional] 

### Return type

[**List&lt;HistoricVariableInstanceDto&gt;**](HistoricVariableInstanceDto.md)

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

<a name="queryhistoricvariableinstancescount"></a>
# **QueryHistoricVariableInstancesCount**
> CountResultDto QueryHistoricVariableInstancesCount (HistoricVariableInstanceQueryDto historicVariableInstanceQueryDto = null)

Get Variable Instance Count (POST)

Queries for historic variable instances that fulfill the given parameters. This method takes the same message body as the [Get Variable Instances (POST)](https://docs.camunda.org/manual/7.16/reference/rest/history/variable-instance/post-variable-instance-query/) method and therefore it is more powerful regarding variable values than the [Get Variable Instance Count](https://docs.camunda.org/manual/7.16/reference/rest/history/variable-instance/get-variable-instance-query-count/) method.

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
    public class QueryHistoricVariableInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new HistoricVariableInstanceApi(httpClient, config, httpClientHandler);
            var historicVariableInstanceQueryDto = new HistoricVariableInstanceQueryDto(); // HistoricVariableInstanceQueryDto |  (optional) 

            try
            {
                // Get Variable Instance Count (POST)
                CountResultDto result = apiInstance.QueryHistoricVariableInstancesCount(historicVariableInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricVariableInstanceApi.QueryHistoricVariableInstancesCount: " + e.Message );
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
 **historicVariableInstanceQueryDto** | [**HistoricVariableInstanceQueryDto**](HistoricVariableInstanceQueryDto.md)|  | [optional] 

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
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

