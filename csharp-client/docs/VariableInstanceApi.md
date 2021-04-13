# Camunda.OpenApi.Client.Api.VariableInstanceApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVariableInstance**](VariableInstanceApi.md#getvariableinstance) | **GET** /variable-instance/{id} | Get Variable Instance
[**GetVariableInstanceBinary**](VariableInstanceApi.md#getvariableinstancebinary) | **GET** /variable-instance/{id}/data | Get Variable Instance (Binary)
[**GetVariableInstances**](VariableInstanceApi.md#getvariableinstances) | **GET** /variable-instance | Get Variable Instances
[**GetVariableInstancesCount**](VariableInstanceApi.md#getvariableinstancescount) | **GET** /variable-instance/count | Get Variable Instance Count
[**QueryVariableInstances**](VariableInstanceApi.md#queryvariableinstances) | **POST** /variable-instance | Get Variable Instances (POST)
[**QueryVariableInstancesCount**](VariableInstanceApi.md#queryvariableinstancescount) | **POST** /variable-instance/count | Get Variable Instance Count (POST)


<a name="getvariableinstance"></a>
# **GetVariableInstance**
> VariableInstanceDto GetVariableInstance (string id, bool? deserializeValue = null)

Get Variable Instance

Retrieves a variable by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetVariableInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new VariableInstanceApi(config);
            var id = id_example;  // string | The id of the variable instance.
            var deserializeValue = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:**  While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional) 

            try
            {
                // Get Variable Instance
                VariableInstanceDto result = apiInstance.GetVariableInstance(id, deserializeValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariableInstanceApi.GetVariableInstance: " + e.Message );
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
 **deserializeValue** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:**  While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] 

### Return type

[**VariableInstanceDto**](VariableInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Variable with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvariableinstancebinary"></a>
# **GetVariableInstanceBinary**
> System.IO.Stream GetVariableInstanceBinary (string id)

Get Variable Instance (Binary)

Retrieves the content of a variable by id. Applicable for byte array and file variables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetVariableInstanceBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new VariableInstanceApi(config);
            var id = id_example;  // string | The id of the variable instance.

            try
            {
                // Get Variable Instance (Binary)
                System.IO.Stream result = apiInstance.GetVariableInstanceBinary(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariableInstanceApi.GetVariableInstanceBinary: " + e.Message );
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

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. For binary variables or files without any MIME type information, a byte stream is returned.                       File variables with MIME type information are returned as the saved type. Additionally, for file                       variables the Content-Disposition header will be set. |  -  |
| **400** | Variable with given id exists but does not serialize as binary data. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Variable with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvariableinstances"></a>
# **GetVariableInstances**
> List&lt;VariableInstanceDto&gt; GetVariableInstances (string variableName = null, string variableNameLike = null, string processInstanceIdIn = null, string executionIdIn = null, string caseInstanceIdIn = null, string caseExecutionIdIn = null, string taskIdIn = null, string batchIdIn = null, string activityInstanceIdIn = null, string tenantIdIn = null, string variableValues = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null, bool? deserializeValues = null)

Get Variable Instances

Query for variable instances that fulfill given parameters. Parameters may be the properties of variable instances, such as the name or type. The size of the result set can be retrieved by using the [Get Variable Instance Count](https://docs.camunda.org/manual/7.15/reference/rest/variable-instance/get-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetVariableInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new VariableInstanceApi(config);
            var variableName = variableName_example;  // string | Filter by variable instance name. (optional) 
            var variableNameLike = variableNameLike_example;  // string | Filter by the variable instance name. The parameter can include the wildcard `%` to express like-strategy such as: starts with (`%`name), ends with (name`%`) or contains (`%`name`%`). (optional) 
            var processInstanceIdIn = processInstanceIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated process instance ids. (optional) 
            var executionIdIn = executionIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated execution ids. (optional) 
            var caseInstanceIdIn = caseInstanceIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated case instance ids. (optional) 
            var caseExecutionIdIn = caseExecutionIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated case execution ids. (optional) 
            var taskIdIn = taskIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated task ids. (optional) 
            var batchIdIn = batchIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated batch ids. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated activity instance ids. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated tenant ids. (optional) 
            var variableValues = variableValues_example;  // string | Only include variable instances that have the certain values. Value filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note:** Values are always treated as `String` objects on server side.  Valid operator values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match all variable names provided in `variableValues` case-insensitively. If set to `true` **variableName** and **variablename** are treated as equal. (optional) 
            var variableValuesIgnoreCase = true;  // bool? | Match all variable values provided in `variableValues` case-insensitively. If set to `true` **variableValue** and **variablevalue** are treated as equal. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional) 

            try
            {
                // Get Variable Instances
                List<VariableInstanceDto> result = apiInstance.GetVariableInstances(variableName, variableNameLike, processInstanceIdIn, executionIdIn, caseInstanceIdIn, caseExecutionIdIn, taskIdIn, batchIdIn, activityInstanceIdIn, tenantIdIn, variableValues, variableNamesIgnoreCase, variableValuesIgnoreCase, sortBy, sortOrder, firstResult, maxResults, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariableInstanceApi.GetVariableInstances: " + e.Message );
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
 **variableName** | **string**| Filter by variable instance name. | [optional] 
 **variableNameLike** | **string**| Filter by the variable instance name. The parameter can include the wildcard &#x60;%&#x60; to express like-strategy such as: starts with (&#x60;%&#x60;name), ends with (name&#x60;%&#x60;) or contains (&#x60;%&#x60;name&#x60;%&#x60;). | [optional] 
 **processInstanceIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated process instance ids. | [optional] 
 **executionIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated execution ids. | [optional] 
 **caseInstanceIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated case instance ids. | [optional] 
 **caseExecutionIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated case execution ids. | [optional] 
 **taskIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated task ids. | [optional] 
 **batchIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated batch ids. | [optional] 
 **activityInstanceIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated activity instance ids. | [optional] 
 **tenantIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated tenant ids. | [optional] 
 **variableValues** | **string**| Only include variable instances that have the certain values. Value filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note:** Values are always treated as &#x60;String&#x60; objects on server side.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match all variable names provided in &#x60;variableValues&#x60; case-insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal. | [optional] 
 **variableValuesIgnoreCase** | **bool?**| Match all variable values provided in &#x60;variableValues&#x60; case-insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] 

### Return type

[**List&lt;VariableInstanceDto&gt;**](VariableInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;, or if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvariableinstancescount"></a>
# **GetVariableInstancesCount**
> CountResultDto GetVariableInstancesCount (string variableName = null, string variableNameLike = null, string processInstanceIdIn = null, string executionIdIn = null, string caseInstanceIdIn = null, string caseExecutionIdIn = null, string taskIdIn = null, string batchIdIn = null, string activityInstanceIdIn = null, string tenantIdIn = null, string variableValues = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null, string sortBy = null, string sortOrder = null)

Get Variable Instance Count

Query for the number of variable instances that fulfill given parameters. Takes the same parameters as the [Get Variable Instances](https://docs.camunda.org/manual/7.15/reference/rest/variable-instance/get-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetVariableInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new VariableInstanceApi(config);
            var variableName = variableName_example;  // string | Filter by variable instance name. (optional) 
            var variableNameLike = variableNameLike_example;  // string | Filter by the variable instance name. The parameter can include the wildcard `%` to express like-strategy such as: starts with (`%`name), ends with (name`%`) or contains (`%`name`%`). (optional) 
            var processInstanceIdIn = processInstanceIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated process instance ids. (optional) 
            var executionIdIn = executionIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated execution ids. (optional) 
            var caseInstanceIdIn = caseInstanceIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated case instance ids. (optional) 
            var caseExecutionIdIn = caseExecutionIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated case execution ids. (optional) 
            var taskIdIn = taskIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated task ids. (optional) 
            var batchIdIn = batchIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated batch ids. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated activity instance ids. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include variable instances which belong to one of the passed and comma-separated tenant ids. (optional) 
            var variableValues = variableValues_example;  // string | Only include variable instances that have the certain values. Value filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note:** Values are always treated as `String` objects on server side.  Valid operator values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match all variable names provided in `variableValues` case-insensitively. If set to `true` **variableName** and **variablename** are treated as equal. (optional) 
            var variableValuesIgnoreCase = true;  // bool? | Match all variable values provided in `variableValues` case-insensitively. If set to `true` **variableValue** and **variablevalue** are treated as equal. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 

            try
            {
                // Get Variable Instance Count
                CountResultDto result = apiInstance.GetVariableInstancesCount(variableName, variableNameLike, processInstanceIdIn, executionIdIn, caseInstanceIdIn, caseExecutionIdIn, taskIdIn, batchIdIn, activityInstanceIdIn, tenantIdIn, variableValues, variableNamesIgnoreCase, variableValuesIgnoreCase, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariableInstanceApi.GetVariableInstancesCount: " + e.Message );
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
 **variableName** | **string**| Filter by variable instance name. | [optional] 
 **variableNameLike** | **string**| Filter by the variable instance name. The parameter can include the wildcard &#x60;%&#x60; to express like-strategy such as: starts with (&#x60;%&#x60;name), ends with (name&#x60;%&#x60;) or contains (&#x60;%&#x60;name&#x60;%&#x60;). | [optional] 
 **processInstanceIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated process instance ids. | [optional] 
 **executionIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated execution ids. | [optional] 
 **caseInstanceIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated case instance ids. | [optional] 
 **caseExecutionIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated case execution ids. | [optional] 
 **taskIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated task ids. | [optional] 
 **batchIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated batch ids. | [optional] 
 **activityInstanceIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated activity instance ids. | [optional] 
 **tenantIdIn** | **string**| Only include variable instances which belong to one of the passed and comma-separated tenant ids. | [optional] 
 **variableValues** | **string**| Only include variable instances that have the certain values. Value filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note:** Values are always treated as &#x60;String&#x60; objects on server side.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match all variable names provided in &#x60;variableValues&#x60; case-insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal. | [optional] 
 **variableValuesIgnoreCase** | **bool?**| Match all variable values provided in &#x60;variableValues&#x60; case-insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal. | [optional] 
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
| **400** | Returned if some of the query parameters are invalid, for example if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryvariableinstances"></a>
# **QueryVariableInstances**
> List&lt;VariableInstanceDto&gt; QueryVariableInstances (int? firstResult = null, int? maxResults = null, bool? deserializeValues = null, VariableInstanceQueryDto variableInstanceQueryDto = null)

Get Variable Instances (POST)

Query for variable instances that fulfill given parameters through a JSON object. This method is slightly more powerful than the [Get Variable Instances](https://docs.camunda.org/manual/7.15/reference/rest/variable- instance/get-query/) method because it allows filtering by multiple variable instances of types `String`, `Number` or `Boolean`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryVariableInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new VariableInstanceApi(config);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional) 
            var variableInstanceQueryDto = new VariableInstanceQueryDto(); // VariableInstanceQueryDto |  (optional) 

            try
            {
                // Get Variable Instances (POST)
                List<VariableInstanceDto> result = apiInstance.QueryVariableInstances(firstResult, maxResults, deserializeValues, variableInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariableInstanceApi.QueryVariableInstances: " + e.Message );
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
 **variableInstanceQueryDto** | [**VariableInstanceQueryDto**](VariableInstanceQueryDto.md)|  | [optional] 

### Return type

[**List&lt;VariableInstanceDto&gt;**](VariableInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;, or if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryvariableinstancescount"></a>
# **QueryVariableInstancesCount**
> CountResultDto QueryVariableInstancesCount (VariableInstanceQueryDto variableInstanceQueryDto = null)

Get Variable Instance Count (POST)

Query for the number of variable instances that fulfill given parameters. This method takes the same message body as the [Get Variable Instances POST](https://docs.camunda.org/manual/7.15/reference/rest/variable- instance/post-query/) method and therefore it is slightly more powerful than the [Get Variable Instance Count](https://docs.camunda.org/manual/7.15/reference/rest/variable-instance/get-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryVariableInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new VariableInstanceApi(config);
            var variableInstanceQueryDto = new VariableInstanceQueryDto(); // VariableInstanceQueryDto |  (optional) 

            try
            {
                // Get Variable Instance Count (POST)
                CountResultDto result = apiInstance.QueryVariableInstancesCount(variableInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariableInstanceApi.QueryVariableInstancesCount: " + e.Message );
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
 **variableInstanceQueryDto** | [**VariableInstanceQueryDto**](VariableInstanceQueryDto.md)|  | [optional] 

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
| **400** | Returned if some of the query parameters are invalid, for example if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

