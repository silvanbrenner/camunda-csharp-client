# Camunda.OpenApi.Client.Api.ProcessInstanceApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAsyncHistoricQueryBased**](ProcessInstanceApi.md#deleteasynchistoricquerybased) | **POST** /process-instance/delete-historic-query-based | Delete Async Historic Query Based (POST)
[**DeleteProcessInstance**](ProcessInstanceApi.md#deleteprocessinstance) | **DELETE** /process-instance/{id} | Delete
[**DeleteProcessInstanceVariable**](ProcessInstanceApi.md#deleteprocessinstancevariable) | **DELETE** /process-instance/{id}/variables/{varName} | Delete Process Variable
[**DeleteProcessInstancesAsyncOperation**](ProcessInstanceApi.md#deleteprocessinstancesasyncoperation) | **POST** /process-instance/delete | Delete Async (POST)
[**GetActivityInstanceTree**](ProcessInstanceApi.md#getactivityinstancetree) | **GET** /process-instance/{id}/activity-instances | Get Activity Instance
[**GetProcessInstance**](ProcessInstanceApi.md#getprocessinstance) | **GET** /process-instance/{id} | Get Process Instance
[**GetProcessInstanceVariable**](ProcessInstanceApi.md#getprocessinstancevariable) | **GET** /process-instance/{id}/variables/{varName} | Get Process Variable
[**GetProcessInstanceVariableBinary**](ProcessInstanceApi.md#getprocessinstancevariablebinary) | **GET** /process-instance/{id}/variables/{varName}/data | Get Process Variable (Binary)
[**GetProcessInstanceVariables**](ProcessInstanceApi.md#getprocessinstancevariables) | **GET** /process-instance/{id}/variables | Get Process Variables
[**GetProcessInstances**](ProcessInstanceApi.md#getprocessinstances) | **GET** /process-instance | Get List
[**GetProcessInstancesCount**](ProcessInstanceApi.md#getprocessinstancescount) | **GET** /process-instance/count | Get List Count
[**ModifyProcessInstance**](ProcessInstanceApi.md#modifyprocessinstance) | **POST** /process-instance/{id}/modification | Modify Process Instance Execution State
[**ModifyProcessInstanceAsyncOperation**](ProcessInstanceApi.md#modifyprocessinstanceasyncoperation) | **POST** /process-instance/{id}/modification-async | Modify Process Instance Execution State Async
[**ModifyProcessInstanceVariables**](ProcessInstanceApi.md#modifyprocessinstancevariables) | **POST** /process-instance/{id}/variables | Update/Delete Process Variables
[**QueryProcessInstances**](ProcessInstanceApi.md#queryprocessinstances) | **POST** /process-instance | Get List (POST)
[**QueryProcessInstancesCount**](ProcessInstanceApi.md#queryprocessinstancescount) | **POST** /process-instance/count | Get List Count (POST)
[**SetProcessInstanceVariable**](ProcessInstanceApi.md#setprocessinstancevariable) | **PUT** /process-instance/{id}/variables/{varName} | Update Process Variable
[**SetProcessInstanceVariableBinary**](ProcessInstanceApi.md#setprocessinstancevariablebinary) | **POST** /process-instance/{id}/variables/{varName}/data | Update Process Variable (Binary)
[**SetRetriesByProcess**](ProcessInstanceApi.md#setretriesbyprocess) | **POST** /process-instance/job-retries | Set Job Retries Async (POST)
[**SetRetriesByProcessHistoricQueryBased**](ProcessInstanceApi.md#setretriesbyprocesshistoricquerybased) | **POST** /process-instance/job-retries-historic-query-based | Set Job Retries Async Historic Query Based (POST)
[**SetVariablesAsyncOperation**](ProcessInstanceApi.md#setvariablesasyncoperation) | **POST** /process-instance/variables-async | Set Variables Async (POST)
[**UpdateSuspensionState**](ProcessInstanceApi.md#updatesuspensionstate) | **PUT** /process-instance/suspended | Activate/Suspend In Group
[**UpdateSuspensionStateAsyncOperation**](ProcessInstanceApi.md#updatesuspensionstateasyncoperation) | **POST** /process-instance/suspended-async | Activate/Suspend In Batch
[**UpdateSuspensionStateById**](ProcessInstanceApi.md#updatesuspensionstatebyid) | **PUT** /process-instance/{id}/suspended | Activate/Suspend Process Instance By Id


<a name="deleteasynchistoricquerybased"></a>
# **DeleteAsyncHistoricQueryBased**
> BatchDto DeleteAsyncHistoricQueryBased (DeleteProcessInstancesDto deleteProcessInstancesDto = null)

Delete Async Historic Query Based (POST)

Deletes a set of process instances asynchronously (batch) based on a historic process instance query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteAsyncHistoricQueryBasedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var deleteProcessInstancesDto = new DeleteProcessInstancesDto(); // DeleteProcessInstancesDto | **Unallowed property**: `processInstanceQuery` (optional) 

            try
            {
                // Delete Async Historic Query Based (POST)
                BatchDto result = apiInstance.DeleteAsyncHistoricQueryBased(deleteProcessInstancesDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.DeleteAsyncHistoricQueryBased: " + e.Message );
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
 **deleteProcessInstancesDto** | [**DeleteProcessInstancesDto**](DeleteProcessInstancesDto.md)| **Unallowed property**: &#x60;processInstanceQuery&#x60; | [optional] 

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
| **400** | Bad Request Returned if some of the query parameters are invalid, i.e., neither processInstanceIds, nor historicProcessInstanceQuery is present |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprocessinstance"></a>
# **DeleteProcessInstance**
> void DeleteProcessInstance (string id, bool? skipCustomListeners = null, bool? skipIoMappings = null, bool? skipSubprocesses = null, bool? failIfNotExists = null)

Delete

Deletes a running process instance by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteProcessInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to be deleted.
            var skipCustomListeners = true;  // bool? | If set to true, the custom listeners will be skipped. (optional)  (default to false)
            var skipIoMappings = true;  // bool? | If set to true, the input/output mappings will be skipped. (optional)  (default to false)
            var skipSubprocesses = true;  // bool? | If set to true, subprocesses related to deleted processes will be skipped. (optional)  (default to false)
            var failIfNotExists = true;  // bool? | If set to false, the request will still be successful if the process id is not found. (optional)  (default to true)

            try
            {
                // Delete
                apiInstance.DeleteProcessInstance(id, skipCustomListeners, skipIoMappings, skipSubprocesses, failIfNotExists);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.DeleteProcessInstance: " + e.Message );
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
 **id** | **string**| The id of the process instance to be deleted. | 
 **skipCustomListeners** | **bool?**| If set to true, the custom listeners will be skipped. | [optional] [default to false]
 **skipIoMappings** | **bool?**| If set to true, the input/output mappings will be skipped. | [optional] [default to false]
 **skipSubprocesses** | **bool?**| If set to true, subprocesses related to deleted processes will be skipped. | [optional] [default to false]
 **failIfNotExists** | **bool?**| If set to false, the request will still be successful if the process id is not found. | [optional] [default to true]

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
| **404** | Not found Process instance with given id does not exist.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprocessinstancevariable"></a>
# **DeleteProcessInstanceVariable**
> void DeleteProcessInstanceVariable (string id, string varName)

Delete Process Variable

Deletes a variable of a process instance by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteProcessInstanceVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to delete the variable from.
            var varName = varName_example;  // string | The name of the variable to delete.

            try
            {
                // Delete Process Variable
                apiInstance.DeleteProcessInstanceVariable(id, varName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.DeleteProcessInstanceVariable: " + e.Message );
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
 **id** | **string**| The id of the process instance to delete the variable from. | 
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
| **204** | Request successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprocessinstancesasyncoperation"></a>
# **DeleteProcessInstancesAsyncOperation**
> BatchDto DeleteProcessInstancesAsyncOperation (DeleteProcessInstancesDto deleteProcessInstancesDto = null)

Delete Async (POST)

Deletes multiple process instances asynchronously (batch).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteProcessInstancesAsyncOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var deleteProcessInstancesDto = new DeleteProcessInstancesDto(); // DeleteProcessInstancesDto | **Unallowed property**: `historicProcessInstanceQuery` (optional) 

            try
            {
                // Delete Async (POST)
                BatchDto result = apiInstance.DeleteProcessInstancesAsyncOperation(deleteProcessInstancesDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.DeleteProcessInstancesAsyncOperation: " + e.Message );
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
 **deleteProcessInstancesDto** | [**DeleteProcessInstancesDto**](DeleteProcessInstancesDto.md)| **Unallowed property**: &#x60;historicProcessInstanceQuery&#x60; | [optional] 

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
| **400** | Bad Request Returned if some of the query parameters are invalid, i.e., neither processInstanceIds, nor processInstanceQuery is present |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivityinstancetree"></a>
# **GetActivityInstanceTree**
> ActivityInstanceDto GetActivityInstanceTree (string id)

Get Activity Instance

Retrieves an Activity Instance (Tree) for a given process instance by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetActivityInstanceTreeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance for which the activity instance should be retrieved.

            try
            {
                // Get Activity Instance
                ActivityInstanceDto result = apiInstance.GetActivityInstanceTree(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.GetActivityInstanceTree: " + e.Message );
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
 **id** | **string**| The id of the process instance for which the activity instance should be retrieved. | 

### Return type

[**ActivityInstanceDto**](ActivityInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **500** | Process instance with given id does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstance"></a>
# **GetProcessInstance**
> ProcessInstanceDto GetProcessInstance (string id)

Get Process Instance

Retrieves a process instance by id, according to the `ProcessInstance` interface in the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to be retrieved.

            try
            {
                // Get Process Instance
                ProcessInstanceDto result = apiInstance.GetProcessInstance(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.GetProcessInstance: " + e.Message );
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
 **id** | **string**| The id of the process instance to be retrieved. | 

### Return type

[**ProcessInstanceDto**](ProcessInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Process instance with given id does not exist. See the  [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstancevariable"></a>
# **GetProcessInstanceVariable**
> VariableValueDto GetProcessInstanceVariable (string id, string varName, bool? deserializeValue = null)

Get Process Variable

Retrieves a variable of a given process instance by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessInstanceVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to retrieve the variable for.
            var varName = varName_example;  // string | The name of the variable to retrieve.
            var deserializeValue = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. (optional)  (default to true)

            try
            {
                // Get Process Variable
                VariableValueDto result = apiInstance.GetProcessInstanceVariable(id, varName, deserializeValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.GetProcessInstanceVariable: " + e.Message );
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
 **id** | **string**| The id of the process instance to retrieve the variable for. | 
 **varName** | **string**| The name of the variable to retrieve. | 
 **deserializeValue** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] [default to true]

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
| **400** | Bad Request Variable with given id does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstancevariablebinary"></a>
# **GetProcessInstanceVariableBinary**
> System.IO.Stream GetProcessInstanceVariableBinary (string id, string varName)

Get Process Variable (Binary)

Retrieves the content of a Process Variable by the Process Instance id and the Process Variable name. Applicable for byte array or file Process Variables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessInstanceVariableBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to retrieve the variable for.
            var varName = varName_example;  // string | The name of the variable to retrieve.

            try
            {
                // Get Process Variable (Binary)
                System.IO.Stream result = apiInstance.GetProcessInstanceVariableBinary(id, varName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.GetProcessInstanceVariableBinary: " + e.Message );
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
 **id** | **string**| The id of the process instance to retrieve the variable for. | 
 **varName** | **string**| The name of the variable to retrieve. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful.         For binary variables or files without any MIME type information, a byte stream is returned.         File variables with MIME type information are returned as the saved type.         Additionally, for file variables the Content-Disposition header will be set. |  -  |
| **400** | Bad Request A Process Variable with the given id exists but does not serialize as binary data. |  -  |
| **404** | Not Found A Process Variable with the given id does not exist.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstancevariables"></a>
# **GetProcessInstanceVariables**
> Dictionary&lt;string, VariableValueDto&gt; GetProcessInstanceVariables (string id, bool? deserializeValues = null)

Get Process Variables

Retrieves all variables of a given process instance by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessInstanceVariablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to retrieve the variables from.
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. (optional)  (default to true)

            try
            {
                // Get Process Variables
                Dictionary<string, VariableValueDto> result = apiInstance.GetProcessInstanceVariables(id, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.GetProcessInstanceVariables: " + e.Message );
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
 **id** | **string**| The id of the process instance to retrieve the variables from. | 
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] [default to true]

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
| **200** | Request successful. |  -  |
| **500** | Process instance with given id does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstances"></a>
# **GetProcessInstances**
> List&lt;ProcessInstanceDto&gt; GetProcessInstances (string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null, string processInstanceIds = null, string businessKey = null, string businessKeyLike = null, string caseInstanceId = null, string processDefinitionId = null, string processDefinitionKey = null, string processDefinitionKeyIn = null, string processDefinitionKeyNotIn = null, string deploymentId = null, string superProcessInstance = null, string subProcessInstance = null, string superCaseInstance = null, string subCaseInstance = null, bool? active = null, bool? suspended = null, bool? withIncident = null, string incidentId = null, string incidentType = null, string incidentMessage = null, string incidentMessageLike = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? processDefinitionWithoutTenantId = null, string activityIdIn = null, bool? rootProcessInstances = null, bool? leafProcessInstances = null, string variables = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null)

Get List

Queries for process instances that fulfill given parameters. Parameters may be static as well as dynamic runtime properties of process instances. The size of the result set can be retrieved by using the Get Instance Count method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var processInstanceIds = processInstanceIds_example;  // string | Filter by a comma-separated list of process instance ids. (optional) 
            var businessKey = businessKey_example;  // string | Filter by process instance business key. (optional) 
            var businessKeyLike = businessKeyLike_example;  // string | Filter by process instance business key that the parameter is a substring of. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by case instance id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the deployment the id belongs to. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by the key of the process definition the instances run on. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Filter by a comma-separated list of process definition keys. A process instance must have one of the given process definition keys. (optional) 
            var processDefinitionKeyNotIn = processDefinitionKeyNotIn_example;  // string | Exclude instances by a comma-separated list of process definition keys. A process instance must not have one of the given process definition keys. (optional) 
            var deploymentId = deploymentId_example;  // string | Filter by the deployment the id belongs to. (optional) 
            var superProcessInstance = superProcessInstance_example;  // string | Restrict query to all process instances that are sub process instances of the given process instance. Takes a process instance id. (optional) 
            var subProcessInstance = subProcessInstance_example;  // string | Restrict query to all process instances that have the given process instance as a sub process instance. Takes a process instance id. (optional) 
            var superCaseInstance = superCaseInstance_example;  // string | Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. (optional) 
            var subCaseInstance = subCaseInstance_example;  // string | Restrict query to all process instances that have the given case instance as a sub case instance. Takes a case instance id. (optional) 
            var active = true;  // bool? | Only include active process instances. Value may only be true, as false is the default behavior. (optional)  (default to false)
            var suspended = true;  // bool? | Only include suspended process instances. Value may only be true, as false is the default behavior. (optional)  (default to false)
            var withIncident = true;  // bool? | Filter by presence of incidents. Selects only process instances that have an incident. (optional)  (default to false)
            var incidentId = incidentId_example;  // string | Filter by the incident id. (optional) 
            var incidentType = incidentType_example;  // string | Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Filter by the incident message. Exact match. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Filter by the incident message that the parameter is a substring of. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A process instance must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include process instances which belong to no tenant. (optional)  (default to false)
            var processDefinitionWithoutTenantId = true;  // bool? | Only include process instances which process definition has no tenant id. (optional)  (default to false)
            var activityIdIn = activityIdIn_example;  // string | Filter by a comma-separated list of activity ids. A process instance must currently wait in a leaf activity with one of the given activity ids. (optional) 
            var rootProcessInstances = true;  // bool? | Restrict the query to all process instances that are top level process instances. (optional)  (default to false)
            var leafProcessInstances = true;  // bool? | Restrict the query to all process instances that are leaf instances. (i.e. don't have any sub instances). (optional)  (default to false)
            var variables = variables_example;  // string | Only include process instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note**: Values are always treated as String objects on server side.  Valid `operator` values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match all variable names in this query case-insensitively. If set to true variableName and variablename are treated as equal. (optional)  (default to false)
            var variableValuesIgnoreCase = true;  // bool? | Match all variable values in this query case-insensitively. If set to true variableValue and variablevalue are treated as equal. (optional)  (default to false)

            try
            {
                // Get List
                List<ProcessInstanceDto> result = apiInstance.GetProcessInstances(sortBy, sortOrder, firstResult, maxResults, processInstanceIds, businessKey, businessKeyLike, caseInstanceId, processDefinitionId, processDefinitionKey, processDefinitionKeyIn, processDefinitionKeyNotIn, deploymentId, superProcessInstance, subProcessInstance, superCaseInstance, subCaseInstance, active, suspended, withIncident, incidentId, incidentType, incidentMessage, incidentMessageLike, tenantIdIn, withoutTenantId, processDefinitionWithoutTenantId, activityIdIn, rootProcessInstances, leafProcessInstances, variables, variableNamesIgnoreCase, variableValuesIgnoreCase);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.GetProcessInstances: " + e.Message );
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
 **processInstanceIds** | **string**| Filter by a comma-separated list of process instance ids. | [optional] 
 **businessKey** | **string**| Filter by process instance business key. | [optional] 
 **businessKeyLike** | **string**| Filter by process instance business key that the parameter is a substring of. | [optional] 
 **caseInstanceId** | **string**| Filter by case instance id. | [optional] 
 **processDefinitionId** | **string**| Filter by the deployment the id belongs to. | [optional] 
 **processDefinitionKey** | **string**| Filter by the key of the process definition the instances run on. | [optional] 
 **processDefinitionKeyIn** | **string**| Filter by a comma-separated list of process definition keys. A process instance must have one of the given process definition keys. | [optional] 
 **processDefinitionKeyNotIn** | **string**| Exclude instances by a comma-separated list of process definition keys. A process instance must not have one of the given process definition keys. | [optional] 
 **deploymentId** | **string**| Filter by the deployment the id belongs to. | [optional] 
 **superProcessInstance** | **string**| Restrict query to all process instances that are sub process instances of the given process instance. Takes a process instance id. | [optional] 
 **subProcessInstance** | **string**| Restrict query to all process instances that have the given process instance as a sub process instance. Takes a process instance id. | [optional] 
 **superCaseInstance** | **string**| Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. | [optional] 
 **subCaseInstance** | **string**| Restrict query to all process instances that have the given case instance as a sub case instance. Takes a case instance id. | [optional] 
 **active** | **bool?**| Only include active process instances. Value may only be true, as false is the default behavior. | [optional] [default to false]
 **suspended** | **bool?**| Only include suspended process instances. Value may only be true, as false is the default behavior. | [optional] [default to false]
 **withIncident** | **bool?**| Filter by presence of incidents. Selects only process instances that have an incident. | [optional] [default to false]
 **incidentId** | **string**| Filter by the incident id. | [optional] 
 **incidentType** | **string**| Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentMessage** | **string**| Filter by the incident message. Exact match. | [optional] 
 **incidentMessageLike** | **string**| Filter by the incident message that the parameter is a substring of. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A process instance must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include process instances which belong to no tenant. | [optional] [default to false]
 **processDefinitionWithoutTenantId** | **bool?**| Only include process instances which process definition has no tenant id. | [optional] [default to false]
 **activityIdIn** | **string**| Filter by a comma-separated list of activity ids. A process instance must currently wait in a leaf activity with one of the given activity ids. | [optional] 
 **rootProcessInstances** | **bool?**| Restrict the query to all process instances that are top level process instances. | [optional] [default to false]
 **leafProcessInstances** | **bool?**| Restrict the query to all process instances that are leaf instances. (i.e. don&#39;t have any sub instances). | [optional] [default to false]
 **variables** | **string**| Only include process instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note**: Values are always treated as String objects on server side.  Valid &#x60;operator&#x60; values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match all variable names in this query case-insensitively. If set to true variableName and variablename are treated as equal. | [optional] [default to false]
 **variableValuesIgnoreCase** | **bool?**| Match all variable values in this query case-insensitively. If set to true variableValue and variablevalue are treated as equal. | [optional] [default to false]

### Return type

[**List&lt;ProcessInstanceDto&gt;**](ProcessInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad Request Returned if some of the query parameters are invalid, for example if a sortOrder parameter is supplied, but no sortBy, or if an invalid operator for variable comparison is used. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstancescount"></a>
# **GetProcessInstancesCount**
> CountResultDto GetProcessInstancesCount (string processInstanceIds = null, string businessKey = null, string businessKeyLike = null, string caseInstanceId = null, string processDefinitionId = null, string processDefinitionKey = null, string processDefinitionKeyIn = null, string processDefinitionKeyNotIn = null, string deploymentId = null, string superProcessInstance = null, string subProcessInstance = null, string superCaseInstance = null, string subCaseInstance = null, bool? active = null, bool? suspended = null, bool? withIncident = null, string incidentId = null, string incidentType = null, string incidentMessage = null, string incidentMessageLike = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? processDefinitionWithoutTenantId = null, string activityIdIn = null, bool? rootProcessInstances = null, bool? leafProcessInstances = null, string variables = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null)

Get List Count

Queries for the number of process instances that fulfill given parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetProcessInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var processInstanceIds = processInstanceIds_example;  // string | Filter by a comma-separated list of process instance ids. (optional) 
            var businessKey = businessKey_example;  // string | Filter by process instance business key. (optional) 
            var businessKeyLike = businessKeyLike_example;  // string | Filter by process instance business key that the parameter is a substring of. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Filter by case instance id. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Filter by the deployment the id belongs to. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Filter by the key of the process definition the instances run on. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Filter by a comma-separated list of process definition keys. A process instance must have one of the given process definition keys. (optional) 
            var processDefinitionKeyNotIn = processDefinitionKeyNotIn_example;  // string | Exclude instances by a comma-separated list of process definition keys. A process instance must not have one of the given process definition keys. (optional) 
            var deploymentId = deploymentId_example;  // string | Filter by the deployment the id belongs to. (optional) 
            var superProcessInstance = superProcessInstance_example;  // string | Restrict query to all process instances that are sub process instances of the given process instance. Takes a process instance id. (optional) 
            var subProcessInstance = subProcessInstance_example;  // string | Restrict query to all process instances that have the given process instance as a sub process instance. Takes a process instance id. (optional) 
            var superCaseInstance = superCaseInstance_example;  // string | Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. (optional) 
            var subCaseInstance = subCaseInstance_example;  // string | Restrict query to all process instances that have the given case instance as a sub case instance. Takes a case instance id. (optional) 
            var active = true;  // bool? | Only include active process instances. Value may only be true, as false is the default behavior. (optional)  (default to false)
            var suspended = true;  // bool? | Only include suspended process instances. Value may only be true, as false is the default behavior. (optional)  (default to false)
            var withIncident = true;  // bool? | Filter by presence of incidents. Selects only process instances that have an incident. (optional)  (default to false)
            var incidentId = incidentId_example;  // string | Filter by the incident id. (optional) 
            var incidentType = incidentType_example;  // string | Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. (optional) 
            var incidentMessage = incidentMessage_example;  // string | Filter by the incident message. Exact match. (optional) 
            var incidentMessageLike = incidentMessageLike_example;  // string | Filter by the incident message that the parameter is a substring of. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A process instance must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include process instances which belong to no tenant. (optional)  (default to false)
            var processDefinitionWithoutTenantId = true;  // bool? | Only include process instances which process definition has no tenant id. (optional)  (default to false)
            var activityIdIn = activityIdIn_example;  // string | Filter by a comma-separated list of activity ids. A process instance must currently wait in a leaf activity with one of the given activity ids. (optional) 
            var rootProcessInstances = true;  // bool? | Restrict the query to all process instances that are top level process instances. (optional)  (default to false)
            var leafProcessInstances = true;  // bool? | Restrict the query to all process instances that are leaf instances. (i.e. don't have any sub instances). (optional)  (default to false)
            var variables = variables_example;  // string | Only include process instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note**: Values are always treated as String objects on server side.  Valid `operator` values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match all variable names in this query case-insensitively. If set to true variableName and variablename are treated as equal. (optional)  (default to false)
            var variableValuesIgnoreCase = true;  // bool? | Match all variable values in this query case-insensitively. If set to true variableValue and variablevalue are treated as equal. (optional)  (default to false)

            try
            {
                // Get List Count
                CountResultDto result = apiInstance.GetProcessInstancesCount(processInstanceIds, businessKey, businessKeyLike, caseInstanceId, processDefinitionId, processDefinitionKey, processDefinitionKeyIn, processDefinitionKeyNotIn, deploymentId, superProcessInstance, subProcessInstance, superCaseInstance, subCaseInstance, active, suspended, withIncident, incidentId, incidentType, incidentMessage, incidentMessageLike, tenantIdIn, withoutTenantId, processDefinitionWithoutTenantId, activityIdIn, rootProcessInstances, leafProcessInstances, variables, variableNamesIgnoreCase, variableValuesIgnoreCase);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.GetProcessInstancesCount: " + e.Message );
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
 **processInstanceIds** | **string**| Filter by a comma-separated list of process instance ids. | [optional] 
 **businessKey** | **string**| Filter by process instance business key. | [optional] 
 **businessKeyLike** | **string**| Filter by process instance business key that the parameter is a substring of. | [optional] 
 **caseInstanceId** | **string**| Filter by case instance id. | [optional] 
 **processDefinitionId** | **string**| Filter by the deployment the id belongs to. | [optional] 
 **processDefinitionKey** | **string**| Filter by the key of the process definition the instances run on. | [optional] 
 **processDefinitionKeyIn** | **string**| Filter by a comma-separated list of process definition keys. A process instance must have one of the given process definition keys. | [optional] 
 **processDefinitionKeyNotIn** | **string**| Exclude instances by a comma-separated list of process definition keys. A process instance must not have one of the given process definition keys. | [optional] 
 **deploymentId** | **string**| Filter by the deployment the id belongs to. | [optional] 
 **superProcessInstance** | **string**| Restrict query to all process instances that are sub process instances of the given process instance. Takes a process instance id. | [optional] 
 **subProcessInstance** | **string**| Restrict query to all process instances that have the given process instance as a sub process instance. Takes a process instance id. | [optional] 
 **superCaseInstance** | **string**| Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id. | [optional] 
 **subCaseInstance** | **string**| Restrict query to all process instances that have the given case instance as a sub case instance. Takes a case instance id. | [optional] 
 **active** | **bool?**| Only include active process instances. Value may only be true, as false is the default behavior. | [optional] [default to false]
 **suspended** | **bool?**| Only include suspended process instances. Value may only be true, as false is the default behavior. | [optional] [default to false]
 **withIncident** | **bool?**| Filter by presence of incidents. Selects only process instances that have an incident. | [optional] [default to false]
 **incidentId** | **string**| Filter by the incident id. | [optional] 
 **incidentType** | **string**| Filter by the incident type. See the [User Guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/incidents/#incident-types) for a list of incident types. | [optional] 
 **incidentMessage** | **string**| Filter by the incident message. Exact match. | [optional] 
 **incidentMessageLike** | **string**| Filter by the incident message that the parameter is a substring of. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A process instance must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include process instances which belong to no tenant. | [optional] [default to false]
 **processDefinitionWithoutTenantId** | **bool?**| Only include process instances which process definition has no tenant id. | [optional] [default to false]
 **activityIdIn** | **string**| Filter by a comma-separated list of activity ids. A process instance must currently wait in a leaf activity with one of the given activity ids. | [optional] 
 **rootProcessInstances** | **bool?**| Restrict the query to all process instances that are top level process instances. | [optional] [default to false]
 **leafProcessInstances** | **bool?**| Restrict the query to all process instances that are leaf instances. (i.e. don&#39;t have any sub instances). | [optional] [default to false]
 **variables** | **string**| Only include process instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note**: Values are always treated as String objects on server side.  Valid &#x60;operator&#x60; values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match all variable names in this query case-insensitively. If set to true variableName and variablename are treated as equal. | [optional] [default to false]
 **variableValuesIgnoreCase** | **bool?**| Match all variable values in this query case-insensitively. If set to true variableValue and variablevalue are treated as equal. | [optional] [default to false]

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
| **400** | Bad Request Returned if some of the query parameters are invalid, for example an invalid operator for variable comparison is used. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyprocessinstance"></a>
# **ModifyProcessInstance**
> void ModifyProcessInstance (string id, ProcessInstanceModificationDto processInstanceModificationDto = null)

Modify Process Instance Execution State

Submits a list of modification instructions to change a process instance's execution state. A modification instruction is one of the following:  * Starting execution before an activity * Starting execution after an activity on its single outgoing sequence flow * Starting execution on a specific sequence flow * Canceling an activity instance, transition instance, or all instances (activity or transition) for an activity  Instructions are executed immediately and in the order they are provided in this request's body. Variables can be provided with every starting instruction.  The exact semantics of modification can be read about in the [User guide](https://docs.camunda.org/manual/develop/user-guide/process-engine/process-instance-modification/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ModifyProcessInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to modify.
            var processInstanceModificationDto = new ProcessInstanceModificationDto(); // ProcessInstanceModificationDto |  (optional) 

            try
            {
                // Modify Process Instance Execution State
                apiInstance.ModifyProcessInstance(id, processInstanceModificationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.ModifyProcessInstance: " + e.Message );
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
 **id** | **string**| The id of the process instance to modify. | 
 **processInstanceModificationDto** | [**ProcessInstanceModificationDto**](ProcessInstanceModificationDto.md)|  | [optional] 

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
| **400** | At least one modification instruction misses required parameters. |  -  |
| **500** | The modification cannot be performed, for example because it starts a failing activity. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyprocessinstanceasyncoperation"></a>
# **ModifyProcessInstanceAsyncOperation**
> BatchDto ModifyProcessInstanceAsyncOperation (string id, ProcessInstanceModificationDto processInstanceModificationDto = null)

Modify Process Instance Execution State Async

Submits a list of modification instructions to change a process instance's execution state async. A modification instruction is one of the following:  * Starting execution before an activity * Starting execution after an activity on its single outgoing sequence flow * Starting execution on a specific sequence flow * Cancelling an activity instance, transition instance, or all instances (activity or transition) for an activity  Instructions are executed asynchronous and in the order they are provided in this request's body. Variables can be provided with every starting instruction.  The exact semantics of modification can be read about in the [User guide](https://docs.camunda.org/manual/7.15/user-guide/process-engine/process-instance-modification/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ModifyProcessInstanceAsyncOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to modify.
            var processInstanceModificationDto = new ProcessInstanceModificationDto(); // ProcessInstanceModificationDto |  (optional) 

            try
            {
                // Modify Process Instance Execution State Async
                BatchDto result = apiInstance.ModifyProcessInstanceAsyncOperation(id, processInstanceModificationDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.ModifyProcessInstanceAsyncOperation: " + e.Message );
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
 **id** | **string**| The id of the process instance to modify. | 
 **processInstanceModificationDto** | [**ProcessInstanceModificationDto**](ProcessInstanceModificationDto.md)|  | [optional] 

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
| **400** | Bad Request At least one modification instruction misses required parameters. |  -  |
| **403** | Forbidden If the user is not allowed to execute batches. See the Introduction for the error response format. |  -  |
| **500** | The modification cannot be performed, for example because it starts a failing activity. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyprocessinstancevariables"></a>
# **ModifyProcessInstanceVariables**
> void ModifyProcessInstanceVariables (string id, PatchVariablesDto patchVariablesDto = null)

Update/Delete Process Variables

Updates or deletes the variables of a process instance by id. Updates precede deletions. So, if a variable is updated AND deleted, the deletion overrides the update.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ModifyProcessInstanceVariablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to set variables for.
            var patchVariablesDto = new PatchVariablesDto(); // PatchVariablesDto |  (optional) 

            try
            {
                // Update/Delete Process Variables
                apiInstance.ModifyProcessInstanceVariables(id, patchVariablesDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.ModifyProcessInstanceVariables: " + e.Message );
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
 **id** | **string**| The id of the process instance to set variables for. | 
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
| **204** | Request successful. |  -  |
| **400** | Bad Request The variable value or type is invalid, for example if the value could not be parsed to an Integer value or the passed variable type is not supported. |  -  |
| **500** | Update or delete could not be executed, for example because the process instance does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryprocessinstances"></a>
# **QueryProcessInstances**
> List&lt;ProcessInstanceDto&gt; QueryProcessInstances (int? firstResult = null, int? maxResults = null, ProcessInstanceQueryDto processInstanceQueryDto = null)

Get List (POST)

Queries for process instances that fulfill given parameters through a JSON object. This method is slightly more powerful than the Get Instances method because it allows filtering by multiple process variables of types `string`, `number` or `boolean`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryProcessInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var processInstanceQueryDto = new ProcessInstanceQueryDto(); // ProcessInstanceQueryDto |  (optional) 

            try
            {
                // Get List (POST)
                List<ProcessInstanceDto> result = apiInstance.QueryProcessInstances(firstResult, maxResults, processInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.QueryProcessInstances: " + e.Message );
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
 **processInstanceQueryDto** | [**ProcessInstanceQueryDto**](ProcessInstanceQueryDto.md)|  | [optional] 

### Return type

[**List&lt;ProcessInstanceDto&gt;**](ProcessInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad Request Returned if some of the query parameters are invalid, for example if a sortOrder parameter is supplied, but no sortBy, or if an invalid operator for variable comparison is used. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryprocessinstancescount"></a>
# **QueryProcessInstancesCount**
> CountResultDto QueryProcessInstancesCount (ProcessInstanceQueryDto processInstanceQueryDto = null)

Get List Count (POST)

Queries for the number of process instances that fulfill the given parameters. This method takes the same message body as the Get Instances (POST) method and therefore it is slightly more powerful than the Get Instance Count method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryProcessInstancesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var processInstanceQueryDto = new ProcessInstanceQueryDto(); // ProcessInstanceQueryDto |  (optional) 

            try
            {
                // Get List Count (POST)
                CountResultDto result = apiInstance.QueryProcessInstancesCount(processInstanceQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.QueryProcessInstancesCount: " + e.Message );
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
 **processInstanceQueryDto** | [**ProcessInstanceQueryDto**](ProcessInstanceQueryDto.md)|  | [optional] 

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
| **400** | Bad Request Returned if some of the query parameters are invalid, for example if an invalid operator for variable comparison is used. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setprocessinstancevariable"></a>
# **SetProcessInstanceVariable**
> void SetProcessInstanceVariable (string id, string varName, VariableValueDto variableValueDto = null)

Update Process Variable

Sets a variable of a given process instance by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SetProcessInstanceVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to set the variable for.
            var varName = varName_example;  // string | The name of the variable to set.
            var variableValueDto = new VariableValueDto(); // VariableValueDto |  (optional) 

            try
            {
                // Update Process Variable
                apiInstance.SetProcessInstanceVariable(id, varName, variableValueDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.SetProcessInstanceVariable: " + e.Message );
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
 **id** | **string**| The id of the process instance to set the variable for. | 
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
| **204** | Request successful. |  -  |
| **400** | Bad Request The variable value or type is invalid, for example if the value could not be parsed to an Integer value or the passed variable type is not supported. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setprocessinstancevariablebinary"></a>
# **SetProcessInstanceVariableBinary**
> void SetProcessInstanceVariableBinary (string id, string varName, System.IO.Stream data = null, string valueType = null)

Update Process Variable (Binary)

Sets the serialized value for a binary variable or the binary value for a file variable.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SetProcessInstanceVariableBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to retrieve the variable for.
            var varName = varName_example;  // string | The name of the variable to retrieve.
            var data = BINARY_DATA_HERE;  // System.IO.Stream | The binary data to be set. For File variables, this multipart can contain the filename, binary value and MIME type of the file variable to be set Only the filename is mandatory. (optional) 
            var valueType = valueType_example;  // string | The name of the variable type. Either Bytes for a byte array variable or File for a file variable. (optional) 

            try
            {
                // Update Process Variable (Binary)
                apiInstance.SetProcessInstanceVariableBinary(id, varName, data, valueType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.SetProcessInstanceVariableBinary: " + e.Message );
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
 **id** | **string**| The id of the process instance to retrieve the variable for. | 
 **varName** | **string**| The name of the variable to retrieve. | 
 **data** | **System.IO.Stream****System.IO.Stream**| The binary data to be set. For File variables, this multipart can contain the filename, binary value and MIME type of the file variable to be set Only the filename is mandatory. | [optional] 
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
| **204** | Request successful. |  -  |
| **400** | Bad Request The variable value or type is invalid, for example if no filename is set. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setretriesbyprocess"></a>
# **SetRetriesByProcess**
> BatchDto SetRetriesByProcess (SetJobRetriesByProcessDto setJobRetriesByProcessDto = null)

Set Job Retries Async (POST)

Create a batch to set retries of jobs associated with given processes asynchronously.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SetRetriesByProcessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var setJobRetriesByProcessDto = new SetJobRetriesByProcessDto(); // SetJobRetriesByProcessDto | Please note that if both processInstances and processInstanceQuery are provided, then the resulting execution will be performed on the union of these sets. **Unallowed property**: `historicProcessInstanceQuery` (optional) 

            try
            {
                // Set Job Retries Async (POST)
                BatchDto result = apiInstance.SetRetriesByProcess(setJobRetriesByProcessDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.SetRetriesByProcess: " + e.Message );
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
 **setJobRetriesByProcessDto** | [**SetJobRetriesByProcessDto**](SetJobRetriesByProcessDto.md)| Please note that if both processInstances and processInstanceQuery are provided, then the resulting execution will be performed on the union of these sets. **Unallowed property**: &#x60;historicProcessInstanceQuery&#x60; | [optional] 

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
| **400** | Bad Request Returned if some of the query parameters are invalid, for example if neither processInstanceIds, nor processInstanceQuery is present. Or if the retry count is not specified. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setretriesbyprocesshistoricquerybased"></a>
# **SetRetriesByProcessHistoricQueryBased**
> BatchDto SetRetriesByProcessHistoricQueryBased (SetJobRetriesByProcessDto setJobRetriesByProcessDto = null)

Set Job Retries Async Historic Query Based (POST)

Create a batch to set retries of jobs asynchronously based on a historic process instance query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SetRetriesByProcessHistoricQueryBasedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var setJobRetriesByProcessDto = new SetJobRetriesByProcessDto(); // SetJobRetriesByProcessDto | Please note that if both processInstances and historicProcessInstanceQuery are provided, then the resulting execution will be performed on the union of these sets. **Unallowed property**: `processInstanceQuery` (optional) 

            try
            {
                // Set Job Retries Async Historic Query Based (POST)
                BatchDto result = apiInstance.SetRetriesByProcessHistoricQueryBased(setJobRetriesByProcessDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.SetRetriesByProcessHistoricQueryBased: " + e.Message );
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
 **setJobRetriesByProcessDto** | [**SetJobRetriesByProcessDto**](SetJobRetriesByProcessDto.md)| Please note that if both processInstances and historicProcessInstanceQuery are provided, then the resulting execution will be performed on the union of these sets. **Unallowed property**: &#x60;processInstanceQuery&#x60; | [optional] 

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
| **400** | Bad Request Returned if some of the query parameters are invalid, for example if neither processInstanceIds, nor historicProcessInstanceQuery is present. Or if the retry count is not specified. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setvariablesasyncoperation"></a>
# **SetVariablesAsyncOperation**
> BatchDto SetVariablesAsyncOperation (SetVariablesAsyncDto setVariablesAsyncDto = null)

Set Variables Async (POST)

Update or create runtime process variables in the root scope of process instances.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SetVariablesAsyncOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var setVariablesAsyncDto = new SetVariablesAsyncDto(); // SetVariablesAsyncDto |  (optional) 

            try
            {
                // Set Variables Async (POST)
                BatchDto result = apiInstance.SetVariablesAsyncOperation(setVariablesAsyncDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.SetVariablesAsyncOperation: " + e.Message );
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
 **setVariablesAsyncDto** | [**SetVariablesAsyncDto**](SetVariablesAsyncDto.md)|  | [optional] 

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
| **400** | Bad Request * The variable value or type is invalid, for example if the value could not be parsed to an Integer value or the passed variable type is not supported * If none of &#x60;processInstanceIds&#x60;, &#x60;processInstanceQuery&#x60; and &#x60;historicProcessInstanceQuery&#x60; is given * If no or an empty array of &#x60;variables&#x60; is given * If no process instance ids where found * If a transient variable is set * If the engine config flag &#x60;javaSerializationFormatEnabled&#x60; is &#x60;false&#x60; and a Java serialized variable is given |  -  |
| **403** | Returned if the user is not allowed to create the batch.  See the [Introduction](https://docs.camunda.org/manual/7.15/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesuspensionstate"></a>
# **UpdateSuspensionState**
> void UpdateSuspensionState (ProcessInstanceSuspensionStateDto processInstanceSuspensionStateDto = null)

Activate/Suspend In Group

Activates or suspends process instances by providing certain criteria:  # Activate/Suspend Process Instance By Process Definition Id * `suspend` * `processDefinitionId`  # Activate/Suspend Process Instance By Process Definition Key  * `suspend` * `processDefinitionKey` * `processDefinitionTenantId` * `processDefinitionWithoutTenantId`  # Activate/Suspend Process Instance In Group * `suspend` * `processInstanceIds` * `processInstanceQuery` * `historicProcessInstanceQuery`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateSuspensionStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var processInstanceSuspensionStateDto = new ProcessInstanceSuspensionStateDto(); // ProcessInstanceSuspensionStateDto |  (optional) 

            try
            {
                // Activate/Suspend In Group
                apiInstance.UpdateSuspensionState(processInstanceSuspensionStateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.UpdateSuspensionState: " + e.Message );
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
 **processInstanceSuspensionStateDto** | [**ProcessInstanceSuspensionStateDto**](ProcessInstanceSuspensionStateDto.md)|  | [optional] 

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
| **400** | Bad Request Returned if some of the request parameters are invalid, for example if the provided processDefinitionId or processDefinitionKey parameter is null. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesuspensionstateasyncoperation"></a>
# **UpdateSuspensionStateAsyncOperation**
> BatchDto UpdateSuspensionStateAsyncOperation (ProcessInstanceSuspensionStateAsyncDto processInstanceSuspensionStateAsyncDto = null)

Activate/Suspend In Batch

Activates or suspends process instances asynchronously with a list of process instance ids, a process instance query, and/or a historical process instance query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateSuspensionStateAsyncOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var processInstanceSuspensionStateAsyncDto = new ProcessInstanceSuspensionStateAsyncDto(); // ProcessInstanceSuspensionStateAsyncDto |  (optional) 

            try
            {
                // Activate/Suspend In Batch
                BatchDto result = apiInstance.UpdateSuspensionStateAsyncOperation(processInstanceSuspensionStateAsyncDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.UpdateSuspensionStateAsyncOperation: " + e.Message );
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
 **processInstanceSuspensionStateAsyncDto** | [**ProcessInstanceSuspensionStateAsyncDto**](ProcessInstanceSuspensionStateAsyncDto.md)|  | [optional] 

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
| **400** | Bad Request Returned if some of the request parameters are invalid, for example if the provided processDefinitionId or processDefinitionKey parameter is null. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesuspensionstatebyid"></a>
# **UpdateSuspensionStateById**
> void UpdateSuspensionStateById (string id, SuspensionStateDto suspensionStateDto = null)

Activate/Suspend Process Instance By Id

Activates or suspends a given process instance by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateSuspensionStateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new ProcessInstanceApi(config);
            var id = id_example;  // string | The id of the process instance to activate or suspend.
            var suspensionStateDto = new SuspensionStateDto(); // SuspensionStateDto |  (optional) 

            try
            {
                // Activate/Suspend Process Instance By Id
                apiInstance.UpdateSuspensionStateById(id, suspensionStateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessInstanceApi.UpdateSuspensionStateById: " + e.Message );
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
 **id** | **string**| The id of the process instance to activate or suspend. | 
 **suspensionStateDto** | [**SuspensionStateDto**](SuspensionStateDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

