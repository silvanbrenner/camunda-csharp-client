# Camunda.OpenApi.Client.Api.TaskApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Claim**](TaskApi.md#claim) | **POST** /task/{id}/claim | Claim
[**Complete**](TaskApi.md#complete) | **POST** /task/{id}/complete | Complete
[**CreateTask**](TaskApi.md#createtask) | **POST** /task/create | Create
[**DelegateTask**](TaskApi.md#delegatetask) | **POST** /task/{id}/delegate | Delegate
[**DeleteTask**](TaskApi.md#deletetask) | **DELETE** /task/{id} | Delete
[**GetDeployedForm**](TaskApi.md#getdeployedform) | **GET** /task/{id}/deployed-form | Get Deployed Form
[**GetForm**](TaskApi.md#getform) | **GET** /task/{id}/form | Get Form Key
[**GetFormVariables**](TaskApi.md#getformvariables) | **GET** /task/{id}/form-variables | Get Task Form Variables
[**GetRenderedForm**](TaskApi.md#getrenderedform) | **GET** /task/{id}/rendered-form | Get Rendered Form
[**GetTask**](TaskApi.md#gettask) | **GET** /task/{id} | Get
[**GetTasks**](TaskApi.md#gettasks) | **GET** /task | Get List
[**GetTasksCount**](TaskApi.md#gettaskscount) | **GET** /task/count | Get List Count
[**HandleBpmnError**](TaskApi.md#handlebpmnerror) | **POST** /task/{id}/bpmnError | Handle BPMN Error
[**HandleEscalation**](TaskApi.md#handleescalation) | **POST** /task/{id}/bpmnEscalation | Handle BPMN Escalation
[**QueryTasks**](TaskApi.md#querytasks) | **POST** /task | Get List (POST)
[**QueryTasksCount**](TaskApi.md#querytaskscount) | **POST** /task/count | Get List Count (POST)
[**Resolve**](TaskApi.md#resolve) | **POST** /task/{id}/resolve | Resolve
[**SetAssignee**](TaskApi.md#setassignee) | **POST** /task/{id}/assignee | Set Assignee
[**Submit**](TaskApi.md#submit) | **POST** /task/{id}/submit-form | Submit Form
[**Unclaim**](TaskApi.md#unclaim) | **POST** /task/{id}/unclaim | Unclaim
[**UpdateTask**](TaskApi.md#updatetask) | **PUT** /task/{id} | Update


<a name="claim"></a>
# **Claim**
> void Claim (string id, UserIdDto userIdDto = null)

Claim

Claims a task for a specific user.  **Note:** The difference with the [Set Assignee](https://docs.camunda.org/manual/7.17/reference/rest/task/post-assignee/) method is that here a check is performed to see if the task already has a user assigned to it.

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
    public class ClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to claim.
            var userIdDto = new UserIdDto(); // UserIdDto | Provide the id of the user that claims the task. (optional) 

            try
            {
                // Claim
                apiInstance.Claim(id, userIdDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.Claim: " + e.Message );
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
 **id** | **string**| The id of the task to claim. | 
 **userIdDto** | [**UserIdDto**](UserIdDto.md)| Provide the id of the user that claims the task. | [optional] 

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
| **500** | Task with given id does not exist or claiming was not successful. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="complete"></a>
# **Complete**
> Dictionary&lt;string, VariableValueDto&gt; Complete (string id, CompleteTaskDto completeTaskDto = null)

Complete

Completes a task and updates process variables.

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
    public class CompleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to complete.
            var completeTaskDto = new CompleteTaskDto(); // CompleteTaskDto |  (optional) 

            try
            {
                // Complete
                Dictionary<string, VariableValueDto> result = apiInstance.Complete(id, completeTaskDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.Complete: " + e.Message );
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
 **id** | **string**| The id of the task to complete. | 
 **completeTaskDto** | [**CompleteTaskDto**](CompleteTaskDto.md)|  | [optional] 

### Return type

[**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. The response contains the process variables. |  -  |
| **204** | Request successful. The response contains no variables. |  -  |
| **400** | The variable value or type is invalid, for example if the value could not be parsed to an Integer value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | If the task does not exist or the corresponding process instance could not be resumed successfully. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtask"></a>
# **CreateTask**
> void CreateTask (TaskDto taskDto = null)

Create

Creates a new task.

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
    public class CreateTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var taskDto = new TaskDto(); // TaskDto |  (optional) 

            try
            {
                // Create
                apiInstance.CreateTask(taskDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.CreateTask: " + e.Message );
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
 **taskDto** | [**TaskDto**](TaskDto.md)|  | [optional] 

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
| **400** | Returned if a not valid &#x60;delegationState&#x60; is supplied. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delegatetask"></a>
# **DelegateTask**
> void DelegateTask (string id, UserIdDto userIdDto = null)

Delegate

Delegates a task to another user.

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
    public class DelegateTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to delegate.
            var userIdDto = new UserIdDto(); // UserIdDto | Provide the id of the user that the task should be delegated to. (optional) 

            try
            {
                // Delegate
                apiInstance.DelegateTask(id, userIdDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.DelegateTask: " + e.Message );
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
 **id** | **string**| The id of the task to delegate. | 
 **userIdDto** | [**UserIdDto**](UserIdDto.md)| Provide the id of the user that the task should be delegated to. | [optional] 

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
| **500** | If the task does not exist or delegation was not successful. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetask"></a>
# **DeleteTask**
> void DeleteTask (string id)

Delete

Removes a task by id.

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
    public class DeleteTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to be removed.

            try
            {
                // Delete
                apiInstance.DeleteTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.DeleteTask: " + e.Message );
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
 **id** | **string**| The id of the task to be removed. | 

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
| **400** | Bad Request. The Task with the given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The Task with the given id cannot be deleted because it is part of a running process or case instance. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeployedform"></a>
# **GetDeployedForm**
> FileParameter GetDeployedForm (string id)

Get Deployed Form

Retrieves the deployed form that is referenced from a given task. For further information please refer to the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/task-forms/#embedded-task-forms).

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
    public class GetDeployedFormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to get the deployed form for.

            try
            {
                // Get Deployed Form
                FileParameter result = apiInstance.GetDeployedForm(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.GetDeployedForm: " + e.Message );
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
 **id** | **string**| The id of the task to get the deployed form for. | 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xhtml+xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The form key has wrong format. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | The deployed form cannot be retrieved due to missing permissions on task resource. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | No deployed form for a given task exists. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getform"></a>
# **GetForm**
> FormDto GetForm (string id)

Get Form Key

Retrieves the form key for a task. The form key corresponds to the `FormData#formKey` property in the engine. This key can be used to do task-specific form rendering in client applications. Additionally, the context path of the containing process application is returned.

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
    public class GetFormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to retrieve the form for.

            try
            {
                // Get Form Key
                FormDto result = apiInstance.GetForm(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.GetForm: " + e.Message );
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
 **id** | **string**| The id of the task to retrieve the form for. | 

### Return type

[**FormDto**](FormDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Task with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getformvariables"></a>
# **GetFormVariables**
> Dictionary&lt;string, VariableValueDto&gt; GetFormVariables (string id, string variableNames = null, bool? deserializeValues = null)

Get Task Form Variables

Retrieves the form variables for a task. The form variables take form data specified on the task into account. If form fields are defined, the variable types and default values of the form fields are taken into account.

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
    public class GetFormVariablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to retrieve the variables for.
            var variableNames = variableNames_example;  // string | A comma-separated list of variable names. Allows restricting the list of requested variables to the variable names in the list. It is best practice to restrict the list of variables to the variables actually required by the form in order to minimize fetching of data. If the query parameter is ommitted all variables are fetched. If the query parameter contains non-existent variable names, the variable names are ignored. (optional) 
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](http://jackson.codehaus.org/) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. (optional)  (default to true)

            try
            {
                // Get Task Form Variables
                Dictionary<string, VariableValueDto> result = apiInstance.GetFormVariables(id, variableNames, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.GetFormVariables: " + e.Message );
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
 **id** | **string**| The id of the task to retrieve the variables for. | 
 **variableNames** | **string**| A comma-separated list of variable names. Allows restricting the list of requested variables to the variable names in the list. It is best practice to restrict the list of variables to the variables actually required by the form in order to minimize fetching of data. If the query parameter is ommitted all variables are fetched. If the query parameter contains non-existent variable names, the variable names are ignored. | [optional] 
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).  If set to true, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](http://jackson.codehaus.org/) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to false, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] [default to true]

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
| **200** | Request successful. A JSON object containing a property for each variable returned. |  -  |
| **404** |  id is null or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrenderedform"></a>
# **GetRenderedForm**
> FileParameter GetRenderedForm (string id)

Get Rendered Form

Retrieves the rendered form for a task. This method can be used to get the HTML rendering of a [Generated Task Form](https://docs.camunda.org/manual/7.17/user-guide/task-forms/#generated-task-forms).

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
    public class GetRenderedFormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to get the rendered form for.

            try
            {
                // Get Rendered Form
                FileParameter result = apiInstance.GetRenderedForm(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.GetRenderedForm: " + e.Message );
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
 **id** | **string**| The id of the task to get the rendered form for. | 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xhtml+xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The task with the given id does not exist or has no form field metadata defined for this task. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettask"></a>
# **GetTask**
> TaskDto GetTask (string id)

Get

Retrieves a task by id.

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
    public class GetTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to be retrieved.

            try
            {
                // Get
                TaskDto result = apiInstance.GetTask(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.GetTask: " + e.Message );
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
 **id** | **string**| The id of the task to be retrieved. | 

### Return type

[**TaskDto**](TaskDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Task with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasks"></a>
# **GetTasks**
> List&lt;TaskDto&gt; GetTasks (string taskId = null, string taskIdIn = null, string processInstanceId = null, string processInstanceIdIn = null, string processInstanceBusinessKey = null, string processInstanceBusinessKeyExpression = null, string processInstanceBusinessKeyIn = null, string processInstanceBusinessKeyLike = null, string processInstanceBusinessKeyLikeExpression = null, string processDefinitionId = null, string processDefinitionKey = null, string processDefinitionKeyIn = null, string processDefinitionName = null, string processDefinitionNameLike = null, string executionId = null, string caseInstanceId = null, string caseInstanceBusinessKey = null, string caseInstanceBusinessKeyLike = null, string caseDefinitionId = null, string caseDefinitionKey = null, string caseDefinitionName = null, string caseDefinitionNameLike = null, string caseExecutionId = null, string activityInstanceIdIn = null, string tenantIdIn = null, bool? withoutTenantId = null, string assignee = null, string assigneeExpression = null, string assigneeLike = null, string assigneeLikeExpression = null, string assigneeIn = null, string assigneeNotIn = null, string owner = null, string ownerExpression = null, string candidateGroup = null, string candidateGroupExpression = null, string candidateUser = null, string candidateUserExpression = null, bool? includeAssignedTasks = null, string involvedUser = null, string involvedUserExpression = null, bool? assigned = null, bool? unassigned = null, string taskDefinitionKey = null, string taskDefinitionKeyIn = null, string taskDefinitionKeyLike = null, string name = null, string nameNotEqual = null, string nameLike = null, string nameNotLike = null, string description = null, string descriptionLike = null, int? priority = null, int? maxPriority = null, int? minPriority = null, string dueDate = null, string dueDateExpression = null, string dueAfter = null, string dueAfterExpression = null, string dueBefore = null, string dueBeforeExpression = null, bool? withoutDueDate = null, string followUpDate = null, string followUpDateExpression = null, string followUpAfter = null, string followUpAfterExpression = null, string followUpBefore = null, string followUpBeforeExpression = null, string followUpBeforeOrNotExistent = null, string followUpBeforeOrNotExistentExpression = null, string createdOn = null, string createdOnExpression = null, string createdAfter = null, string createdAfterExpression = null, string createdBefore = null, string createdBeforeExpression = null, string delegationState = null, string candidateGroups = null, string candidateGroupsExpression = null, bool? withCandidateGroups = null, bool? withoutCandidateGroups = null, bool? withCandidateUsers = null, bool? withoutCandidateUsers = null, bool? active = null, bool? suspended = null, string taskVariables = null, string processVariables = null, string caseInstanceVariables = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null, string parentTaskId = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get List

Queries for tasks that fulfill a given filter. The size of the result set can be retrieved by using the Get Task Count method.  **Security Consideration:** There are several query parameters (such as assigneeExpression) for specifying an EL expression. These are disabled by default to prevent remote code execution. See the section on [security considerations](https://docs.camunda.org/manual/7.17/user-guide/process-engine/securing-custom-code/) for custom code in the user guide for details.

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
    public class GetTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var taskId = taskId_example;  // string | Restrict to task with the given id. (optional) 
            var taskIdIn = taskIdIn_example;  // string | Restrict to tasks with any of the given ids. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Restrict to tasks that belong to process instances with the given id. (optional) 
            var processInstanceIdIn = processInstanceIdIn_example;  // string | Restrict to tasks that belong to process instances with the given ids. (optional) 
            var processInstanceBusinessKey = processInstanceBusinessKey_example;  // string | Restrict to tasks that belong to process instances with the given business key. (optional) 
            var processInstanceBusinessKeyExpression = processInstanceBusinessKeyExpression_example;  // string | Restrict to tasks that belong to process instances with the given business key which  is described by an expression. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. (optional) 
            var processInstanceBusinessKeyIn = processInstanceBusinessKeyIn_example;  // string | Restrict to tasks that belong to process instances with one of the give business keys.  The keys need to be in a comma-separated list. (optional) 
            var processInstanceBusinessKeyLike = processInstanceBusinessKeyLike_example;  // string | Restrict to tasks that have a process instance business key that has the parameter  value as a substring. (optional) 
            var processInstanceBusinessKeyLikeExpression = processInstanceBusinessKeyLikeExpression_example;  // string | Restrict to tasks that have a process instance business key that has the parameter  value as a substring and is described by an expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Restrict to tasks that belong to a process definition with the given id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Restrict to tasks that belong to a process definition with the given key. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Restrict to tasks that belong to a process definition with one of the given keys. The  keys need to be in a comma-separated list. (optional) 
            var processDefinitionName = processDefinitionName_example;  // string | Restrict to tasks that belong to a process definition with the given name. (optional) 
            var processDefinitionNameLike = processDefinitionNameLike_example;  // string | Restrict to tasks that have a process definition name that has the parameter value as  a substring. (optional) 
            var executionId = executionId_example;  // string | Restrict to tasks that belong to an execution with the given id. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Restrict to tasks that belong to case instances with the given id. (optional) 
            var caseInstanceBusinessKey = caseInstanceBusinessKey_example;  // string | Restrict to tasks that belong to case instances with the given business key. (optional) 
            var caseInstanceBusinessKeyLike = caseInstanceBusinessKeyLike_example;  // string | Restrict to tasks that have a case instance business key that has the parameter value  as a substring. (optional) 
            var caseDefinitionId = caseDefinitionId_example;  // string | Restrict to tasks that belong to a case definition with the given id. (optional) 
            var caseDefinitionKey = caseDefinitionKey_example;  // string | Restrict to tasks that belong to a case definition with the given key. (optional) 
            var caseDefinitionName = caseDefinitionName_example;  // string | Restrict to tasks that belong to a case definition with the given name. (optional) 
            var caseDefinitionNameLike = caseDefinitionNameLike_example;  // string | Restrict to tasks that have a case definition name that has the parameter value as a  substring. (optional) 
            var caseExecutionId = caseExecutionId_example;  // string | Restrict to tasks that belong to a case execution with the given id. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Only include tasks which belong to one of the passed and comma-separated activity  instance ids. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include tasks which belong to one of the passed and comma-separated  tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include tasks which belong to no tenant. Value may only be `true`,  as `false` is the default behavior. (optional)  (default to false)
            var assignee = assignee_example;  // string | Restrict to tasks that the given user is assigned to. (optional) 
            var assigneeExpression = assigneeExpression_example;  // string | Restrict to tasks that the user described by the given expression is assigned to.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var assigneeLike = assigneeLike_example;  // string | Restrict to tasks that have an assignee that has the parameter  value as a substring. (optional) 
            var assigneeLikeExpression = assigneeLikeExpression_example;  // string | Restrict to tasks that have an assignee that has the parameter value described by the  given expression as a substring. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var assigneeIn = assigneeIn_example;  // string | Only include tasks which are assigned to one of the passed and  comma-separated user ids. (optional) 
            var assigneeNotIn = assigneeNotIn_example;  // string | Only include tasks which are not assigned to one of the passed and comma-separated user ids. (optional) 
            var owner = owner_example;  // string | Restrict to tasks that the given user owns. (optional) 
            var ownerExpression = ownerExpression_example;  // string | Restrict to tasks that the user described by the given expression owns. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var candidateGroup = candidateGroup_example;  // string | Only include tasks that are offered to the given group. (optional) 
            var candidateGroupExpression = candidateGroupExpression_example;  // string | Only include tasks that are offered to the group described by the given expression.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var candidateUser = candidateUser_example;  // string | Only include tasks that are offered to the given user or to one of his groups. (optional) 
            var candidateUserExpression = candidateUserExpression_example;  // string | Only include tasks that are offered to the user described by the given expression.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var includeAssignedTasks = true;  // bool? | Also include tasks that are assigned to users in candidate queries. Default is to only  include tasks that are not assigned to any user if you query by candidate user or group(s). (optional)  (default to false)
            var involvedUser = involvedUser_example;  // string | Only include tasks that the given user is involved in. A user is involved in a task if  an identity link exists between task and user (e.g., the user is the assignee). (optional) 
            var involvedUserExpression = involvedUserExpression_example;  // string | Only include tasks that the user described by the given expression is involved in. A user is involved in a task if an identity link exists between task and user (e.g., the user is the assignee). See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. (optional) 
            var assigned = true;  // bool? | If set to `true`, restricts the query to all tasks that are assigned. (optional)  (default to false)
            var unassigned = true;  // bool? | If set to `true`, restricts the query to all tasks that are unassigned. (optional)  (default to false)
            var taskDefinitionKey = taskDefinitionKey_example;  // string | Restrict to tasks that have the given key. (optional) 
            var taskDefinitionKeyIn = taskDefinitionKeyIn_example;  // string | Restrict to tasks that have one of the given keys. The keys need to be in a comma-separated list. (optional) 
            var taskDefinitionKeyLike = taskDefinitionKeyLike_example;  // string | Restrict to tasks that have a key that has the parameter value as a substring. (optional) 
            var name = name_example;  // string | Restrict to tasks that have the given name. (optional) 
            var nameNotEqual = nameNotEqual_example;  // string | Restrict to tasks that do not have the given name. (optional) 
            var nameLike = nameLike_example;  // string | Restrict to tasks that have a name with the given parameter value as substring. (optional) 
            var nameNotLike = nameNotLike_example;  // string | Restrict to tasks that do not have a name with the given parameter value as substring. (optional) 
            var description = description_example;  // string | Restrict to tasks that have the given description. (optional) 
            var descriptionLike = descriptionLike_example;  // string | Restrict to tasks that have a description that has the parameter value as a substring. (optional) 
            var priority = 56;  // int? | Restrict to tasks that have the given priority. (optional) 
            var maxPriority = 56;  // int? | Restrict to tasks that have a lower or equal priority. (optional) 
            var minPriority = 56;  // int? | Restrict to tasks that have a higher or equal priority. (optional) 
            var dueDate = dueDate_example;  // string | Restrict to tasks that are due on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.546+0200`. (optional) 
            var dueDateExpression = dueDateExpression_example;  // string | Restrict to tasks that are due on the date described by the given expression. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var dueAfter = dueAfter_example;  // string | Restrict to tasks that are due after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.435+0200`. (optional) 
            var dueAfterExpression = dueAfterExpression_example;  // string | Restrict to tasks that are due after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var dueBefore = dueBefore_example;  // string | Restrict to tasks that are due before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.243+0200`. (optional) 
            var dueBeforeExpression = dueBeforeExpression_example;  // string | Restrict to tasks that are due before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var withoutDueDate = true;  // bool? | Only include tasks which have no due date. Value may only be `true`,  as `false` is the default behavior. (optional)  (default to false)
            var followUpDate = followUpDate_example;  // string | Restrict to tasks that have a followUp date on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.342+0200`. (optional) 
            var followUpDateExpression = followUpDateExpression_example;  // string | Restrict to tasks that have a followUp date on the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var followUpAfter = followUpAfter_example;  // string | Restrict to tasks that have a followUp date after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.542+0200`. (optional) 
            var followUpAfterExpression = followUpAfterExpression_example;  // string | Restrict to tasks that have a followUp date after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var followUpBefore = followUpBefore_example;  // string | Restrict to tasks that have a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.234+0200`. (optional) 
            var followUpBeforeExpression = followUpBeforeExpression_example;  // string | Restrict to tasks that have a followUp date before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var followUpBeforeOrNotExistent = followUpBeforeOrNotExistent_example;  // string | Restrict to tasks that have no followUp date or a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.432+0200`. The typical use case is to query all `active` tasks for a user for a given date. (optional) 
            var followUpBeforeOrNotExistentExpression = followUpBeforeOrNotExistentExpression_example;  // string | Restrict to tasks that have no followUp date or a followUp date before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var createdOn = createdOn_example;  // string | Restrict to tasks that were created on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.324+0200`. (optional) 
            var createdOnExpression = createdOnExpression_example;  // string | Restrict to tasks that were created on the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var createdAfter = createdAfter_example;  // string | Restrict to tasks that were created after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.342+0200`. (optional) 
            var createdAfterExpression = createdAfterExpression_example;  // string | Restrict to tasks that were created after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var createdBefore = createdBefore_example;  // string | Restrict to tasks that were created before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.332+0200`. (optional) 
            var createdBeforeExpression = createdBeforeExpression_example;  // string | Restrict to tasks that were created before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var delegationState = delegationState_example;  // string | Restrict to tasks that are in the given delegation state. Valid values are `PENDING` and `RESOLVED`. (optional) 
            var candidateGroups = candidateGroups_example;  // string | Restrict to tasks that are offered to any of the given candidate groups. Takes a comma-separated list of group names, so for example `developers,support,sales`. (optional) 
            var candidateGroupsExpression = candidateGroupsExpression_example;  // string | Restrict to tasks that are offered to any of the candidate groups described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to `java.util.List` of Strings. (optional) 
            var withCandidateGroups = true;  // bool? | Only include tasks which have a candidate group. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var withoutCandidateGroups = true;  // bool? | Only include tasks which have no candidate group. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var withCandidateUsers = true;  // bool? | Only include tasks which have a candidate user. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var withoutCandidateUsers = true;  // bool? | Only include tasks which have no candidate users. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var active = true;  // bool? | Only include active tasks. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var suspended = true;  // bool? | Only include suspended tasks. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var taskVariables = taskVariables_example;  // string | Only include tasks that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note**: Values are always treated as String objects on server side.  Valid `operator` values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var processVariables = processVariables_example;  // string | Only include tasks that belong to process instances that have variables with certain  values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note**: Values are always treated as String objects on server side.  Valid `operator` values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`; `notLike`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var caseInstanceVariables = caseInstanceVariables_example;  // string | Only include tasks that belong to case instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note**: Values are always treated as String objects on server side.  Valid `operator` values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match all variable names in this query case-insensitively. If set `variableName` and `variablename` are treated as equal. (optional)  (default to false)
            var variableValuesIgnoreCase = true;  // bool? | Match all variable values in this query case-insensitively. If set `variableValue` and `variablevalue` are treated as equal. (optional)  (default to false)
            var parentTaskId = parentTaskId_example;  // string | Restrict query to all tasks that are sub tasks of the given task. Takes a task id. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get List
                List<TaskDto> result = apiInstance.GetTasks(taskId, taskIdIn, processInstanceId, processInstanceIdIn, processInstanceBusinessKey, processInstanceBusinessKeyExpression, processInstanceBusinessKeyIn, processInstanceBusinessKeyLike, processInstanceBusinessKeyLikeExpression, processDefinitionId, processDefinitionKey, processDefinitionKeyIn, processDefinitionName, processDefinitionNameLike, executionId, caseInstanceId, caseInstanceBusinessKey, caseInstanceBusinessKeyLike, caseDefinitionId, caseDefinitionKey, caseDefinitionName, caseDefinitionNameLike, caseExecutionId, activityInstanceIdIn, tenantIdIn, withoutTenantId, assignee, assigneeExpression, assigneeLike, assigneeLikeExpression, assigneeIn, assigneeNotIn, owner, ownerExpression, candidateGroup, candidateGroupExpression, candidateUser, candidateUserExpression, includeAssignedTasks, involvedUser, involvedUserExpression, assigned, unassigned, taskDefinitionKey, taskDefinitionKeyIn, taskDefinitionKeyLike, name, nameNotEqual, nameLike, nameNotLike, description, descriptionLike, priority, maxPriority, minPriority, dueDate, dueDateExpression, dueAfter, dueAfterExpression, dueBefore, dueBeforeExpression, withoutDueDate, followUpDate, followUpDateExpression, followUpAfter, followUpAfterExpression, followUpBefore, followUpBeforeExpression, followUpBeforeOrNotExistent, followUpBeforeOrNotExistentExpression, createdOn, createdOnExpression, createdAfter, createdAfterExpression, createdBefore, createdBeforeExpression, delegationState, candidateGroups, candidateGroupsExpression, withCandidateGroups, withoutCandidateGroups, withCandidateUsers, withoutCandidateUsers, active, suspended, taskVariables, processVariables, caseInstanceVariables, variableNamesIgnoreCase, variableValuesIgnoreCase, parentTaskId, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.GetTasks: " + e.Message );
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
 **taskId** | **string**| Restrict to task with the given id. | [optional] 
 **taskIdIn** | **string**| Restrict to tasks with any of the given ids. | [optional] 
 **processInstanceId** | **string**| Restrict to tasks that belong to process instances with the given id. | [optional] 
 **processInstanceIdIn** | **string**| Restrict to tasks that belong to process instances with the given ids. | [optional] 
 **processInstanceBusinessKey** | **string**| Restrict to tasks that belong to process instances with the given business key. | [optional] 
 **processInstanceBusinessKeyExpression** | **string**| Restrict to tasks that belong to process instances with the given business key which  is described by an expression. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. | [optional] 
 **processInstanceBusinessKeyIn** | **string**| Restrict to tasks that belong to process instances with one of the give business keys.  The keys need to be in a comma-separated list. | [optional] 
 **processInstanceBusinessKeyLike** | **string**| Restrict to tasks that have a process instance business key that has the parameter  value as a substring. | [optional] 
 **processInstanceBusinessKeyLikeExpression** | **string**| Restrict to tasks that have a process instance business key that has the parameter  value as a substring and is described by an expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **processDefinitionId** | **string**| Restrict to tasks that belong to a process definition with the given id. | [optional] 
 **processDefinitionKey** | **string**| Restrict to tasks that belong to a process definition with the given key. | [optional] 
 **processDefinitionKeyIn** | **string**| Restrict to tasks that belong to a process definition with one of the given keys. The  keys need to be in a comma-separated list. | [optional] 
 **processDefinitionName** | **string**| Restrict to tasks that belong to a process definition with the given name. | [optional] 
 **processDefinitionNameLike** | **string**| Restrict to tasks that have a process definition name that has the parameter value as  a substring. | [optional] 
 **executionId** | **string**| Restrict to tasks that belong to an execution with the given id. | [optional] 
 **caseInstanceId** | **string**| Restrict to tasks that belong to case instances with the given id. | [optional] 
 **caseInstanceBusinessKey** | **string**| Restrict to tasks that belong to case instances with the given business key. | [optional] 
 **caseInstanceBusinessKeyLike** | **string**| Restrict to tasks that have a case instance business key that has the parameter value  as a substring. | [optional] 
 **caseDefinitionId** | **string**| Restrict to tasks that belong to a case definition with the given id. | [optional] 
 **caseDefinitionKey** | **string**| Restrict to tasks that belong to a case definition with the given key. | [optional] 
 **caseDefinitionName** | **string**| Restrict to tasks that belong to a case definition with the given name. | [optional] 
 **caseDefinitionNameLike** | **string**| Restrict to tasks that have a case definition name that has the parameter value as a  substring. | [optional] 
 **caseExecutionId** | **string**| Restrict to tasks that belong to a case execution with the given id. | [optional] 
 **activityInstanceIdIn** | **string**| Only include tasks which belong to one of the passed and comma-separated activity  instance ids. | [optional] 
 **tenantIdIn** | **string**| Only include tasks which belong to one of the passed and comma-separated  tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include tasks which belong to no tenant. Value may only be &#x60;true&#x60;,  as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **assignee** | **string**| Restrict to tasks that the given user is assigned to. | [optional] 
 **assigneeExpression** | **string**| Restrict to tasks that the user described by the given expression is assigned to.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **assigneeLike** | **string**| Restrict to tasks that have an assignee that has the parameter  value as a substring. | [optional] 
 **assigneeLikeExpression** | **string**| Restrict to tasks that have an assignee that has the parameter value described by the  given expression as a substring. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **assigneeIn** | **string**| Only include tasks which are assigned to one of the passed and  comma-separated user ids. | [optional] 
 **assigneeNotIn** | **string**| Only include tasks which are not assigned to one of the passed and comma-separated user ids. | [optional] 
 **owner** | **string**| Restrict to tasks that the given user owns. | [optional] 
 **ownerExpression** | **string**| Restrict to tasks that the user described by the given expression owns. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **candidateGroup** | **string**| Only include tasks that are offered to the given group. | [optional] 
 **candidateGroupExpression** | **string**| Only include tasks that are offered to the group described by the given expression.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **candidateUser** | **string**| Only include tasks that are offered to the given user or to one of his groups. | [optional] 
 **candidateUserExpression** | **string**| Only include tasks that are offered to the user described by the given expression.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **includeAssignedTasks** | **bool?**| Also include tasks that are assigned to users in candidate queries. Default is to only  include tasks that are not assigned to any user if you query by candidate user or group(s). | [optional] [default to false]
 **involvedUser** | **string**| Only include tasks that the given user is involved in. A user is involved in a task if  an identity link exists between task and user (e.g., the user is the assignee). | [optional] 
 **involvedUserExpression** | **string**| Only include tasks that the user described by the given expression is involved in. A user is involved in a task if an identity link exists between task and user (e.g., the user is the assignee). See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. | [optional] 
 **assigned** | **bool?**| If set to &#x60;true&#x60;, restricts the query to all tasks that are assigned. | [optional] [default to false]
 **unassigned** | **bool?**| If set to &#x60;true&#x60;, restricts the query to all tasks that are unassigned. | [optional] [default to false]
 **taskDefinitionKey** | **string**| Restrict to tasks that have the given key. | [optional] 
 **taskDefinitionKeyIn** | **string**| Restrict to tasks that have one of the given keys. The keys need to be in a comma-separated list. | [optional] 
 **taskDefinitionKeyLike** | **string**| Restrict to tasks that have a key that has the parameter value as a substring. | [optional] 
 **name** | **string**| Restrict to tasks that have the given name. | [optional] 
 **nameNotEqual** | **string**| Restrict to tasks that do not have the given name. | [optional] 
 **nameLike** | **string**| Restrict to tasks that have a name with the given parameter value as substring. | [optional] 
 **nameNotLike** | **string**| Restrict to tasks that do not have a name with the given parameter value as substring. | [optional] 
 **description** | **string**| Restrict to tasks that have the given description. | [optional] 
 **descriptionLike** | **string**| Restrict to tasks that have a description that has the parameter value as a substring. | [optional] 
 **priority** | **int?**| Restrict to tasks that have the given priority. | [optional] 
 **maxPriority** | **int?**| Restrict to tasks that have a lower or equal priority. | [optional] 
 **minPriority** | **int?**| Restrict to tasks that have a higher or equal priority. | [optional] 
 **dueDate** | **string**| Restrict to tasks that are due on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.546+0200&#x60;. | [optional] 
 **dueDateExpression** | **string**| Restrict to tasks that are due on the date described by the given expression. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **dueAfter** | **string**| Restrict to tasks that are due after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.435+0200&#x60;. | [optional] 
 **dueAfterExpression** | **string**| Restrict to tasks that are due after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **dueBefore** | **string**| Restrict to tasks that are due before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.243+0200&#x60;. | [optional] 
 **dueBeforeExpression** | **string**| Restrict to tasks that are due before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **withoutDueDate** | **bool?**| Only include tasks which have no due date. Value may only be &#x60;true&#x60;,  as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **followUpDate** | **string**| Restrict to tasks that have a followUp date on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.342+0200&#x60;. | [optional] 
 **followUpDateExpression** | **string**| Restrict to tasks that have a followUp date on the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **followUpAfter** | **string**| Restrict to tasks that have a followUp date after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.542+0200&#x60;. | [optional] 
 **followUpAfterExpression** | **string**| Restrict to tasks that have a followUp date after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **followUpBefore** | **string**| Restrict to tasks that have a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.234+0200&#x60;. | [optional] 
 **followUpBeforeExpression** | **string**| Restrict to tasks that have a followUp date before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **followUpBeforeOrNotExistent** | **string**| Restrict to tasks that have no followUp date or a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.432+0200&#x60;. The typical use case is to query all &#x60;active&#x60; tasks for a user for a given date. | [optional] 
 **followUpBeforeOrNotExistentExpression** | **string**| Restrict to tasks that have no followUp date or a followUp date before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **createdOn** | **string**| Restrict to tasks that were created on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.324+0200&#x60;. | [optional] 
 **createdOnExpression** | **string**| Restrict to tasks that were created on the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **createdAfter** | **string**| Restrict to tasks that were created after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.342+0200&#x60;. | [optional] 
 **createdAfterExpression** | **string**| Restrict to tasks that were created after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **createdBefore** | **string**| Restrict to tasks that were created before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.332+0200&#x60;. | [optional] 
 **createdBeforeExpression** | **string**| Restrict to tasks that were created before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **delegationState** | **string**| Restrict to tasks that are in the given delegation state. Valid values are &#x60;PENDING&#x60; and &#x60;RESOLVED&#x60;. | [optional] 
 **candidateGroups** | **string**| Restrict to tasks that are offered to any of the given candidate groups. Takes a comma-separated list of group names, so for example &#x60;developers,support,sales&#x60;. | [optional] 
 **candidateGroupsExpression** | **string**| Restrict to tasks that are offered to any of the candidate groups described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to &#x60;java.util.List&#x60; of Strings. | [optional] 
 **withCandidateGroups** | **bool?**| Only include tasks which have a candidate group. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **withoutCandidateGroups** | **bool?**| Only include tasks which have no candidate group. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **withCandidateUsers** | **bool?**| Only include tasks which have a candidate user. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **withoutCandidateUsers** | **bool?**| Only include tasks which have no candidate users. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **active** | **bool?**| Only include active tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **suspended** | **bool?**| Only include suspended tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **taskVariables** | **string**| Only include tasks that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note**: Values are always treated as String objects on server side.  Valid &#x60;operator&#x60; values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **processVariables** | **string**| Only include tasks that belong to process instances that have variables with certain  values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note**: Values are always treated as String objects on server side.  Valid &#x60;operator&#x60; values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;; &#x60;notLike&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **caseInstanceVariables** | **string**| Only include tasks that belong to case instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note**: Values are always treated as String objects on server side.  Valid &#x60;operator&#x60; values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match all variable names in this query case-insensitively. If set &#x60;variableName&#x60; and &#x60;variablename&#x60; are treated as equal. | [optional] [default to false]
 **variableValuesIgnoreCase** | **bool?**| Match all variable values in this query case-insensitively. If set &#x60;variableValue&#x60; and &#x60;variablevalue&#x60; are treated as equal. | [optional] [default to false]
 **parentTaskId** | **string**| Restrict query to all tasks that are sub tasks of the given task. Takes a task id. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;TaskDto&gt;**](TaskDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;, or if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskscount"></a>
# **GetTasksCount**
> CountResultDto GetTasksCount (string taskId = null, string taskIdIn = null, string processInstanceId = null, string processInstanceIdIn = null, string processInstanceBusinessKey = null, string processInstanceBusinessKeyExpression = null, string processInstanceBusinessKeyIn = null, string processInstanceBusinessKeyLike = null, string processInstanceBusinessKeyLikeExpression = null, string processDefinitionId = null, string processDefinitionKey = null, string processDefinitionKeyIn = null, string processDefinitionName = null, string processDefinitionNameLike = null, string executionId = null, string caseInstanceId = null, string caseInstanceBusinessKey = null, string caseInstanceBusinessKeyLike = null, string caseDefinitionId = null, string caseDefinitionKey = null, string caseDefinitionName = null, string caseDefinitionNameLike = null, string caseExecutionId = null, string activityInstanceIdIn = null, string tenantIdIn = null, bool? withoutTenantId = null, string assignee = null, string assigneeExpression = null, string assigneeLike = null, string assigneeLikeExpression = null, string assigneeIn = null, string assigneeNotIn = null, string owner = null, string ownerExpression = null, string candidateGroup = null, string candidateGroupExpression = null, string candidateUser = null, string candidateUserExpression = null, bool? includeAssignedTasks = null, string involvedUser = null, string involvedUserExpression = null, bool? assigned = null, bool? unassigned = null, string taskDefinitionKey = null, string taskDefinitionKeyIn = null, string taskDefinitionKeyLike = null, string name = null, string nameNotEqual = null, string nameLike = null, string nameNotLike = null, string description = null, string descriptionLike = null, int? priority = null, int? maxPriority = null, int? minPriority = null, string dueDate = null, string dueDateExpression = null, string dueAfter = null, string dueAfterExpression = null, string dueBefore = null, string dueBeforeExpression = null, bool? withoutDueDate = null, string followUpDate = null, string followUpDateExpression = null, string followUpAfter = null, string followUpAfterExpression = null, string followUpBefore = null, string followUpBeforeExpression = null, string followUpBeforeOrNotExistent = null, string followUpBeforeOrNotExistentExpression = null, string createdOn = null, string createdOnExpression = null, string createdAfter = null, string createdAfterExpression = null, string createdBefore = null, string createdBeforeExpression = null, string delegationState = null, string candidateGroups = null, string candidateGroupsExpression = null, bool? withCandidateGroups = null, bool? withoutCandidateGroups = null, bool? withCandidateUsers = null, bool? withoutCandidateUsers = null, bool? active = null, bool? suspended = null, string taskVariables = null, string processVariables = null, string caseInstanceVariables = null, bool? variableNamesIgnoreCase = null, bool? variableValuesIgnoreCase = null, string parentTaskId = null)

Get List Count

Retrieves the number of tasks that fulfill a provided filter. Corresponds to the size of the result set when using the [Get Tasks](https://docs.camunda.org/manual/7.17/reference/rest/task/) method.  **Security Consideration:** There are several query parameters (such as assigneeExpression) for specifying an EL expression. These are disabled by default to prevent remote code execution. See the section on [security considerations](https://docs.camunda.org/manual/7.17/user-guide/process-engine/securing-custom-code/) for custom code in the user guide for details.

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
    public class GetTasksCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var taskId = taskId_example;  // string | Restrict to task with the given id. (optional) 
            var taskIdIn = taskIdIn_example;  // string | Restrict to tasks with any of the given ids. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Restrict to tasks that belong to process instances with the given id. (optional) 
            var processInstanceIdIn = processInstanceIdIn_example;  // string | Restrict to tasks that belong to process instances with the given ids. (optional) 
            var processInstanceBusinessKey = processInstanceBusinessKey_example;  // string | Restrict to tasks that belong to process instances with the given business key. (optional) 
            var processInstanceBusinessKeyExpression = processInstanceBusinessKeyExpression_example;  // string | Restrict to tasks that belong to process instances with the given business key which  is described by an expression. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. (optional) 
            var processInstanceBusinessKeyIn = processInstanceBusinessKeyIn_example;  // string | Restrict to tasks that belong to process instances with one of the give business keys.  The keys need to be in a comma-separated list. (optional) 
            var processInstanceBusinessKeyLike = processInstanceBusinessKeyLike_example;  // string | Restrict to tasks that have a process instance business key that has the parameter  value as a substring. (optional) 
            var processInstanceBusinessKeyLikeExpression = processInstanceBusinessKeyLikeExpression_example;  // string | Restrict to tasks that have a process instance business key that has the parameter  value as a substring and is described by an expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Restrict to tasks that belong to a process definition with the given id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Restrict to tasks that belong to a process definition with the given key. (optional) 
            var processDefinitionKeyIn = processDefinitionKeyIn_example;  // string | Restrict to tasks that belong to a process definition with one of the given keys. The  keys need to be in a comma-separated list. (optional) 
            var processDefinitionName = processDefinitionName_example;  // string | Restrict to tasks that belong to a process definition with the given name. (optional) 
            var processDefinitionNameLike = processDefinitionNameLike_example;  // string | Restrict to tasks that have a process definition name that has the parameter value as  a substring. (optional) 
            var executionId = executionId_example;  // string | Restrict to tasks that belong to an execution with the given id. (optional) 
            var caseInstanceId = caseInstanceId_example;  // string | Restrict to tasks that belong to case instances with the given id. (optional) 
            var caseInstanceBusinessKey = caseInstanceBusinessKey_example;  // string | Restrict to tasks that belong to case instances with the given business key. (optional) 
            var caseInstanceBusinessKeyLike = caseInstanceBusinessKeyLike_example;  // string | Restrict to tasks that have a case instance business key that has the parameter value  as a substring. (optional) 
            var caseDefinitionId = caseDefinitionId_example;  // string | Restrict to tasks that belong to a case definition with the given id. (optional) 
            var caseDefinitionKey = caseDefinitionKey_example;  // string | Restrict to tasks that belong to a case definition with the given key. (optional) 
            var caseDefinitionName = caseDefinitionName_example;  // string | Restrict to tasks that belong to a case definition with the given name. (optional) 
            var caseDefinitionNameLike = caseDefinitionNameLike_example;  // string | Restrict to tasks that have a case definition name that has the parameter value as a  substring. (optional) 
            var caseExecutionId = caseExecutionId_example;  // string | Restrict to tasks that belong to a case execution with the given id. (optional) 
            var activityInstanceIdIn = activityInstanceIdIn_example;  // string | Only include tasks which belong to one of the passed and comma-separated activity  instance ids. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Only include tasks which belong to one of the passed and comma-separated  tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include tasks which belong to no tenant. Value may only be `true`,  as `false` is the default behavior. (optional)  (default to false)
            var assignee = assignee_example;  // string | Restrict to tasks that the given user is assigned to. (optional) 
            var assigneeExpression = assigneeExpression_example;  // string | Restrict to tasks that the user described by the given expression is assigned to.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var assigneeLike = assigneeLike_example;  // string | Restrict to tasks that have an assignee that has the parameter  value as a substring. (optional) 
            var assigneeLikeExpression = assigneeLikeExpression_example;  // string | Restrict to tasks that have an assignee that has the parameter value described by the  given expression as a substring. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var assigneeIn = assigneeIn_example;  // string | Only include tasks which are assigned to one of the passed and  comma-separated user ids. (optional) 
            var assigneeNotIn = assigneeNotIn_example;  // string | Only include tasks which are not assigned to one of the passed and comma-separated user ids. (optional) 
            var owner = owner_example;  // string | Restrict to tasks that the given user owns. (optional) 
            var ownerExpression = ownerExpression_example;  // string | Restrict to tasks that the user described by the given expression owns. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var candidateGroup = candidateGroup_example;  // string | Only include tasks that are offered to the given group. (optional) 
            var candidateGroupExpression = candidateGroupExpression_example;  // string | Only include tasks that are offered to the group described by the given expression.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var candidateUser = candidateUser_example;  // string | Only include tasks that are offered to the given user or to one of his groups. (optional) 
            var candidateUserExpression = candidateUserExpression_example;  // string | Only include tasks that are offered to the user described by the given expression.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. (optional) 
            var includeAssignedTasks = true;  // bool? | Also include tasks that are assigned to users in candidate queries. Default is to only  include tasks that are not assigned to any user if you query by candidate user or group(s). (optional)  (default to false)
            var involvedUser = involvedUser_example;  // string | Only include tasks that the given user is involved in. A user is involved in a task if  an identity link exists between task and user (e.g., the user is the assignee). (optional) 
            var involvedUserExpression = involvedUserExpression_example;  // string | Only include tasks that the user described by the given expression is involved in. A user is involved in a task if an identity link exists between task and user (e.g., the user is the assignee). See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. (optional) 
            var assigned = true;  // bool? | If set to `true`, restricts the query to all tasks that are assigned. (optional)  (default to false)
            var unassigned = true;  // bool? | If set to `true`, restricts the query to all tasks that are unassigned. (optional)  (default to false)
            var taskDefinitionKey = taskDefinitionKey_example;  // string | Restrict to tasks that have the given key. (optional) 
            var taskDefinitionKeyIn = taskDefinitionKeyIn_example;  // string | Restrict to tasks that have one of the given keys. The keys need to be in a comma-separated list. (optional) 
            var taskDefinitionKeyLike = taskDefinitionKeyLike_example;  // string | Restrict to tasks that have a key that has the parameter value as a substring. (optional) 
            var name = name_example;  // string | Restrict to tasks that have the given name. (optional) 
            var nameNotEqual = nameNotEqual_example;  // string | Restrict to tasks that do not have the given name. (optional) 
            var nameLike = nameLike_example;  // string | Restrict to tasks that have a name with the given parameter value as substring. (optional) 
            var nameNotLike = nameNotLike_example;  // string | Restrict to tasks that do not have a name with the given parameter value as substring. (optional) 
            var description = description_example;  // string | Restrict to tasks that have the given description. (optional) 
            var descriptionLike = descriptionLike_example;  // string | Restrict to tasks that have a description that has the parameter value as a substring. (optional) 
            var priority = 56;  // int? | Restrict to tasks that have the given priority. (optional) 
            var maxPriority = 56;  // int? | Restrict to tasks that have a lower or equal priority. (optional) 
            var minPriority = 56;  // int? | Restrict to tasks that have a higher or equal priority. (optional) 
            var dueDate = dueDate_example;  // string | Restrict to tasks that are due on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.546+0200`. (optional) 
            var dueDateExpression = dueDateExpression_example;  // string | Restrict to tasks that are due on the date described by the given expression. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var dueAfter = dueAfter_example;  // string | Restrict to tasks that are due after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.435+0200`. (optional) 
            var dueAfterExpression = dueAfterExpression_example;  // string | Restrict to tasks that are due after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var dueBefore = dueBefore_example;  // string | Restrict to tasks that are due before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.243+0200`. (optional) 
            var dueBeforeExpression = dueBeforeExpression_example;  // string | Restrict to tasks that are due before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var withoutDueDate = true;  // bool? | Only include tasks which have no due date. Value may only be `true`,  as `false` is the default behavior. (optional)  (default to false)
            var followUpDate = followUpDate_example;  // string | Restrict to tasks that have a followUp date on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.342+0200`. (optional) 
            var followUpDateExpression = followUpDateExpression_example;  // string | Restrict to tasks that have a followUp date on the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var followUpAfter = followUpAfter_example;  // string | Restrict to tasks that have a followUp date after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.542+0200`. (optional) 
            var followUpAfterExpression = followUpAfterExpression_example;  // string | Restrict to tasks that have a followUp date after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var followUpBefore = followUpBefore_example;  // string | Restrict to tasks that have a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.234+0200`. (optional) 
            var followUpBeforeExpression = followUpBeforeExpression_example;  // string | Restrict to tasks that have a followUp date before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var followUpBeforeOrNotExistent = followUpBeforeOrNotExistent_example;  // string | Restrict to tasks that have no followUp date or a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.432+0200`. The typical use case is to query all `active` tasks for a user for a given date. (optional) 
            var followUpBeforeOrNotExistentExpression = followUpBeforeOrNotExistentExpression_example;  // string | Restrict to tasks that have no followUp date or a followUp date before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var createdOn = createdOn_example;  // string | Restrict to tasks that were created on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.324+0200`. (optional) 
            var createdOnExpression = createdOnExpression_example;  // string | Restrict to tasks that were created on the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var createdAfter = createdAfter_example;  // string | Restrict to tasks that were created after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.342+0200`. (optional) 
            var createdAfterExpression = createdAfterExpression_example;  // string | Restrict to tasks that were created after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var createdBefore = createdBefore_example;  // string | Restrict to tasks that were created before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.332+0200`. (optional) 
            var createdBeforeExpression = createdBeforeExpression_example;  // string | Restrict to tasks that were created before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a `java.util.Date` or `org.joda.time.DateTime` object. (optional) 
            var delegationState = delegationState_example;  // string | Restrict to tasks that are in the given delegation state. Valid values are `PENDING` and `RESOLVED`. (optional) 
            var candidateGroups = candidateGroups_example;  // string | Restrict to tasks that are offered to any of the given candidate groups. Takes a comma-separated list of group names, so for example `developers,support,sales`. (optional) 
            var candidateGroupsExpression = candidateGroupsExpression_example;  // string | Restrict to tasks that are offered to any of the candidate groups described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to `java.util.List` of Strings. (optional) 
            var withCandidateGroups = true;  // bool? | Only include tasks which have a candidate group. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var withoutCandidateGroups = true;  // bool? | Only include tasks which have no candidate group. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var withCandidateUsers = true;  // bool? | Only include tasks which have a candidate user. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var withoutCandidateUsers = true;  // bool? | Only include tasks which have no candidate users. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var active = true;  // bool? | Only include active tasks. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var suspended = true;  // bool? | Only include suspended tasks. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var taskVariables = taskVariables_example;  // string | Only include tasks that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note**: Values are always treated as String objects on server side.  Valid `operator` values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var processVariables = processVariables_example;  // string | Only include tasks that belong to process instances that have variables with certain  values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note**: Values are always treated as String objects on server side.  Valid `operator` values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`; `notLike`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var caseInstanceVariables = caseInstanceVariables_example;  // string | Only include tasks that belong to case instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form `key_operator_value`. `key` is the variable name, `operator` is the comparison operator to be used and `value` the variable value.  **Note**: Values are always treated as String objects on server side.  Valid `operator` values are: `eq` - equal to; `neq` - not equal to; `gt` - greater than; `gteq` - greater than or equal to; `lt` - lower than; `lteq` - lower than or equal to; `like`. `key` and `value` may not contain underscore or comma characters. (optional) 
            var variableNamesIgnoreCase = true;  // bool? | Match all variable names in this query case-insensitively. If set `variableName` and `variablename` are treated as equal. (optional)  (default to false)
            var variableValuesIgnoreCase = true;  // bool? | Match all variable values in this query case-insensitively. If set `variableValue` and `variablevalue` are treated as equal. (optional)  (default to false)
            var parentTaskId = parentTaskId_example;  // string | Restrict query to all tasks that are sub tasks of the given task. Takes a task id. (optional) 

            try
            {
                // Get List Count
                CountResultDto result = apiInstance.GetTasksCount(taskId, taskIdIn, processInstanceId, processInstanceIdIn, processInstanceBusinessKey, processInstanceBusinessKeyExpression, processInstanceBusinessKeyIn, processInstanceBusinessKeyLike, processInstanceBusinessKeyLikeExpression, processDefinitionId, processDefinitionKey, processDefinitionKeyIn, processDefinitionName, processDefinitionNameLike, executionId, caseInstanceId, caseInstanceBusinessKey, caseInstanceBusinessKeyLike, caseDefinitionId, caseDefinitionKey, caseDefinitionName, caseDefinitionNameLike, caseExecutionId, activityInstanceIdIn, tenantIdIn, withoutTenantId, assignee, assigneeExpression, assigneeLike, assigneeLikeExpression, assigneeIn, assigneeNotIn, owner, ownerExpression, candidateGroup, candidateGroupExpression, candidateUser, candidateUserExpression, includeAssignedTasks, involvedUser, involvedUserExpression, assigned, unassigned, taskDefinitionKey, taskDefinitionKeyIn, taskDefinitionKeyLike, name, nameNotEqual, nameLike, nameNotLike, description, descriptionLike, priority, maxPriority, minPriority, dueDate, dueDateExpression, dueAfter, dueAfterExpression, dueBefore, dueBeforeExpression, withoutDueDate, followUpDate, followUpDateExpression, followUpAfter, followUpAfterExpression, followUpBefore, followUpBeforeExpression, followUpBeforeOrNotExistent, followUpBeforeOrNotExistentExpression, createdOn, createdOnExpression, createdAfter, createdAfterExpression, createdBefore, createdBeforeExpression, delegationState, candidateGroups, candidateGroupsExpression, withCandidateGroups, withoutCandidateGroups, withCandidateUsers, withoutCandidateUsers, active, suspended, taskVariables, processVariables, caseInstanceVariables, variableNamesIgnoreCase, variableValuesIgnoreCase, parentTaskId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.GetTasksCount: " + e.Message );
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
 **taskId** | **string**| Restrict to task with the given id. | [optional] 
 **taskIdIn** | **string**| Restrict to tasks with any of the given ids. | [optional] 
 **processInstanceId** | **string**| Restrict to tasks that belong to process instances with the given id. | [optional] 
 **processInstanceIdIn** | **string**| Restrict to tasks that belong to process instances with the given ids. | [optional] 
 **processInstanceBusinessKey** | **string**| Restrict to tasks that belong to process instances with the given business key. | [optional] 
 **processInstanceBusinessKeyExpression** | **string**| Restrict to tasks that belong to process instances with the given business key which  is described by an expression. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. | [optional] 
 **processInstanceBusinessKeyIn** | **string**| Restrict to tasks that belong to process instances with one of the give business keys.  The keys need to be in a comma-separated list. | [optional] 
 **processInstanceBusinessKeyLike** | **string**| Restrict to tasks that have a process instance business key that has the parameter  value as a substring. | [optional] 
 **processInstanceBusinessKeyLikeExpression** | **string**| Restrict to tasks that have a process instance business key that has the parameter  value as a substring and is described by an expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **processDefinitionId** | **string**| Restrict to tasks that belong to a process definition with the given id. | [optional] 
 **processDefinitionKey** | **string**| Restrict to tasks that belong to a process definition with the given key. | [optional] 
 **processDefinitionKeyIn** | **string**| Restrict to tasks that belong to a process definition with one of the given keys. The  keys need to be in a comma-separated list. | [optional] 
 **processDefinitionName** | **string**| Restrict to tasks that belong to a process definition with the given name. | [optional] 
 **processDefinitionNameLike** | **string**| Restrict to tasks that have a process definition name that has the parameter value as  a substring. | [optional] 
 **executionId** | **string**| Restrict to tasks that belong to an execution with the given id. | [optional] 
 **caseInstanceId** | **string**| Restrict to tasks that belong to case instances with the given id. | [optional] 
 **caseInstanceBusinessKey** | **string**| Restrict to tasks that belong to case instances with the given business key. | [optional] 
 **caseInstanceBusinessKeyLike** | **string**| Restrict to tasks that have a case instance business key that has the parameter value  as a substring. | [optional] 
 **caseDefinitionId** | **string**| Restrict to tasks that belong to a case definition with the given id. | [optional] 
 **caseDefinitionKey** | **string**| Restrict to tasks that belong to a case definition with the given key. | [optional] 
 **caseDefinitionName** | **string**| Restrict to tasks that belong to a case definition with the given name. | [optional] 
 **caseDefinitionNameLike** | **string**| Restrict to tasks that have a case definition name that has the parameter value as a  substring. | [optional] 
 **caseExecutionId** | **string**| Restrict to tasks that belong to a case execution with the given id. | [optional] 
 **activityInstanceIdIn** | **string**| Only include tasks which belong to one of the passed and comma-separated activity  instance ids. | [optional] 
 **tenantIdIn** | **string**| Only include tasks which belong to one of the passed and comma-separated  tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include tasks which belong to no tenant. Value may only be &#x60;true&#x60;,  as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **assignee** | **string**| Restrict to tasks that the given user is assigned to. | [optional] 
 **assigneeExpression** | **string**| Restrict to tasks that the user described by the given expression is assigned to.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **assigneeLike** | **string**| Restrict to tasks that have an assignee that has the parameter  value as a substring. | [optional] 
 **assigneeLikeExpression** | **string**| Restrict to tasks that have an assignee that has the parameter value described by the  given expression as a substring. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **assigneeIn** | **string**| Only include tasks which are assigned to one of the passed and  comma-separated user ids. | [optional] 
 **assigneeNotIn** | **string**| Only include tasks which are not assigned to one of the passed and comma-separated user ids. | [optional] 
 **owner** | **string**| Restrict to tasks that the given user owns. | [optional] 
 **ownerExpression** | **string**| Restrict to tasks that the user described by the given expression owns. See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **candidateGroup** | **string**| Only include tasks that are offered to the given group. | [optional] 
 **candidateGroupExpression** | **string**| Only include tasks that are offered to the group described by the given expression.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **candidateUser** | **string**| Only include tasks that are offered to the given user or to one of his groups. | [optional] 
 **candidateUserExpression** | **string**| Only include tasks that are offered to the user described by the given expression.  See the  [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions)  for more information on available functions. | [optional] 
 **includeAssignedTasks** | **bool?**| Also include tasks that are assigned to users in candidate queries. Default is to only  include tasks that are not assigned to any user if you query by candidate user or group(s). | [optional] [default to false]
 **involvedUser** | **string**| Only include tasks that the given user is involved in. A user is involved in a task if  an identity link exists between task and user (e.g., the user is the assignee). | [optional] 
 **involvedUserExpression** | **string**| Only include tasks that the user described by the given expression is involved in. A user is involved in a task if an identity link exists between task and user (e.g., the user is the assignee). See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. | [optional] 
 **assigned** | **bool?**| If set to &#x60;true&#x60;, restricts the query to all tasks that are assigned. | [optional] [default to false]
 **unassigned** | **bool?**| If set to &#x60;true&#x60;, restricts the query to all tasks that are unassigned. | [optional] [default to false]
 **taskDefinitionKey** | **string**| Restrict to tasks that have the given key. | [optional] 
 **taskDefinitionKeyIn** | **string**| Restrict to tasks that have one of the given keys. The keys need to be in a comma-separated list. | [optional] 
 **taskDefinitionKeyLike** | **string**| Restrict to tasks that have a key that has the parameter value as a substring. | [optional] 
 **name** | **string**| Restrict to tasks that have the given name. | [optional] 
 **nameNotEqual** | **string**| Restrict to tasks that do not have the given name. | [optional] 
 **nameLike** | **string**| Restrict to tasks that have a name with the given parameter value as substring. | [optional] 
 **nameNotLike** | **string**| Restrict to tasks that do not have a name with the given parameter value as substring. | [optional] 
 **description** | **string**| Restrict to tasks that have the given description. | [optional] 
 **descriptionLike** | **string**| Restrict to tasks that have a description that has the parameter value as a substring. | [optional] 
 **priority** | **int?**| Restrict to tasks that have the given priority. | [optional] 
 **maxPriority** | **int?**| Restrict to tasks that have a lower or equal priority. | [optional] 
 **minPriority** | **int?**| Restrict to tasks that have a higher or equal priority. | [optional] 
 **dueDate** | **string**| Restrict to tasks that are due on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.546+0200&#x60;. | [optional] 
 **dueDateExpression** | **string**| Restrict to tasks that are due on the date described by the given expression. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **dueAfter** | **string**| Restrict to tasks that are due after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.435+0200&#x60;. | [optional] 
 **dueAfterExpression** | **string**| Restrict to tasks that are due after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **dueBefore** | **string**| Restrict to tasks that are due before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.243+0200&#x60;. | [optional] 
 **dueBeforeExpression** | **string**| Restrict to tasks that are due before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **withoutDueDate** | **bool?**| Only include tasks which have no due date. Value may only be &#x60;true&#x60;,  as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **followUpDate** | **string**| Restrict to tasks that have a followUp date on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.342+0200&#x60;. | [optional] 
 **followUpDateExpression** | **string**| Restrict to tasks that have a followUp date on the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **followUpAfter** | **string**| Restrict to tasks that have a followUp date after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.542+0200&#x60;. | [optional] 
 **followUpAfterExpression** | **string**| Restrict to tasks that have a followUp date after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **followUpBefore** | **string**| Restrict to tasks that have a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.234+0200&#x60;. | [optional] 
 **followUpBeforeExpression** | **string**| Restrict to tasks that have a followUp date before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **followUpBeforeOrNotExistent** | **string**| Restrict to tasks that have no followUp date or a followUp date before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.432+0200&#x60;. The typical use case is to query all &#x60;active&#x60; tasks for a user for a given date. | [optional] 
 **followUpBeforeOrNotExistentExpression** | **string**| Restrict to tasks that have no followUp date or a followUp date before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **createdOn** | **string**| Restrict to tasks that were created on the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.324+0200&#x60;. | [optional] 
 **createdOnExpression** | **string**| Restrict to tasks that were created on the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **createdAfter** | **string**| Restrict to tasks that were created after the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.342+0200&#x60;. | [optional] 
 **createdAfterExpression** | **string**| Restrict to tasks that were created after the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **createdBefore** | **string**| Restrict to tasks that were created before the given date. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.332+0200&#x60;. | [optional] 
 **createdBeforeExpression** | **string**| Restrict to tasks that were created before the date described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to a &#x60;java.util.Date&#x60; or &#x60;org.joda.time.DateTime&#x60; object. | [optional] 
 **delegationState** | **string**| Restrict to tasks that are in the given delegation state. Valid values are &#x60;PENDING&#x60; and &#x60;RESOLVED&#x60;. | [optional] 
 **candidateGroups** | **string**| Restrict to tasks that are offered to any of the given candidate groups. Takes a comma-separated list of group names, so for example &#x60;developers,support,sales&#x60;. | [optional] 
 **candidateGroupsExpression** | **string**| Restrict to tasks that are offered to any of the candidate groups described by the given expression. See the [user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/expression-language/#internal-context-functions) for more information on available functions. The expression must evaluate to &#x60;java.util.List&#x60; of Strings. | [optional] 
 **withCandidateGroups** | **bool?**| Only include tasks which have a candidate group. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **withoutCandidateGroups** | **bool?**| Only include tasks which have no candidate group. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **withCandidateUsers** | **bool?**| Only include tasks which have a candidate user. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **withoutCandidateUsers** | **bool?**| Only include tasks which have no candidate users. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **active** | **bool?**| Only include active tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **suspended** | **bool?**| Only include suspended tasks. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **taskVariables** | **string**| Only include tasks that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note**: Values are always treated as String objects on server side.  Valid &#x60;operator&#x60; values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **processVariables** | **string**| Only include tasks that belong to process instances that have variables with certain  values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note**: Values are always treated as String objects on server side.  Valid &#x60;operator&#x60; values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;; &#x60;notLike&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **caseInstanceVariables** | **string**| Only include tasks that belong to case instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:  A valid parameter value has the form &#x60;key_operator_value&#x60;. &#x60;key&#x60; is the variable name, &#x60;operator&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value.  **Note**: Values are always treated as String objects on server side.  Valid &#x60;operator&#x60; values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;. &#x60;key&#x60; and &#x60;value&#x60; may not contain underscore or comma characters. | [optional] 
 **variableNamesIgnoreCase** | **bool?**| Match all variable names in this query case-insensitively. If set &#x60;variableName&#x60; and &#x60;variablename&#x60; are treated as equal. | [optional] [default to false]
 **variableValuesIgnoreCase** | **bool?**| Match all variable values in this query case-insensitively. If set &#x60;variableValue&#x60; and &#x60;variablevalue&#x60; are treated as equal. | [optional] [default to false]
 **parentTaskId** | **string**| Restrict query to all tasks that are sub tasks of the given task. Takes a task id. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlebpmnerror"></a>
# **HandleBpmnError**
> void HandleBpmnError (string id, TaskBpmnErrorDto taskBpmnErrorDto = null)

Handle BPMN Error

Reports a business error in the context of a running task by id. The error code must be specified to identify the BPMN error handler. See the documentation for [Reporting Bpmn Error](https://docs.camunda.org/manual/7.17/reference/bpmn20/tasks/user-task/#reporting-bpmn-error) in User Tasks.

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
    public class HandleBpmnErrorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task a BPMN error is reported for.
            var taskBpmnErrorDto = new TaskBpmnErrorDto(); // TaskBpmnErrorDto |  (optional) 

            try
            {
                // Handle BPMN Error
                apiInstance.HandleBpmnError(id, taskBpmnErrorDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.HandleBpmnError: " + e.Message );
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
 **id** | **string**| The id of the task a BPMN error is reported for. | 
 **taskBpmnErrorDto** | [**TaskBpmnErrorDto**](TaskBpmnErrorDto.md)|  | [optional] 

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
| **400** | Returned if the &#x60;errorCode&#x60; or &#x60;id&#x60; are not present in the request. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | If the authenticated user is unauthorized to update the task. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Returned if the task does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handleescalation"></a>
# **HandleEscalation**
> void HandleEscalation (string id, TaskEscalationDto taskEscalationDto = null)

Handle BPMN Escalation

Reports an escalation in the context of a running task by id. The escalation code must be specified to identify the escalation handler. See the documentation for [Reporting Bpmn Escalation](https://docs.camunda.org/manual/7.17/reference/bpmn20/tasks/user-task/#reporting-bpmn-escalation) in User Tasks.

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
    public class HandleEscalationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task in which context a BPMN escalation is reported.
            var taskEscalationDto = new TaskEscalationDto(); // TaskEscalationDto |  (optional) 

            try
            {
                // Handle BPMN Escalation
                apiInstance.HandleEscalation(id, taskEscalationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.HandleEscalation: " + e.Message );
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
 **id** | **string**| The id of the task in which context a BPMN escalation is reported. | 
 **taskEscalationDto** | [**TaskEscalationDto**](TaskEscalationDto.md)|  | [optional] 

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
| **400** | Returned if the &lt;code&gt;escalationCode&lt;/code&gt; is not provided in the request. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | If the authenticated user is unauthorized to update the process instance. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Returned if the task does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querytasks"></a>
# **QueryTasks**
> List&lt;TaskDto&gt; QueryTasks (int? firstResult = null, int? maxResults = null, TaskQueryDto taskQueryDto = null)

Get List (POST)

Queries for tasks that fulfill a given filter. This method is slightly more powerful than the [Get Tasks](https://docs.camunda.org/manual/7.17/reference/rest/task/get-query/) method because it allows filtering by multiple process or task variables of types `String`, `Number` or `Boolean`. The size of the result set can be retrieved by using the [Get Task Count (POST)](https://docs.camunda.org/manual/7.17/reference/rest/task/post-query-count/) method.  **Security Consideration**: There are several parameters (such as `assigneeExpression`) for specifying an EL expression. These are disabled by default to prevent remote code execution. See the section on [security considerations for custom code](https://docs.camunda.org/manual/7.17/user-guide/process-engine/securing-custom-code/) in the user guide for details.

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
    public class QueryTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var taskQueryDto = new TaskQueryDto(); // TaskQueryDto |  (optional) 

            try
            {
                // Get List (POST)
                List<TaskDto> result = apiInstance.QueryTasks(firstResult, maxResults, taskQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.QueryTasks: " + e.Message );
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
 **taskQueryDto** | [**TaskQueryDto**](TaskQueryDto.md)|  | [optional] 

### Return type

[**List&lt;TaskDto&gt;**](TaskDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;, or if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querytaskscount"></a>
# **QueryTasksCount**
> CountResultDto QueryTasksCount (TaskQueryDto taskQueryDto = null)

Get List Count (POST)

Retrieves the number of tasks that fulfill the given filter. Corresponds to the size of the result set of the [Get Tasks (POST)](https://docs.camunda.org/manual/7.17/reference/rest/task/post-query/) method and takes the same parameters.  **Security Consideration**: There are several parameters (such as `assigneeExpression`) for specifying an EL expression. These are disabled by default to prevent remote code execution. See the section on [security considerations for custom code](https://docs.camunda.org/manual/7.17/user-guide/process-engine/securing-custom-code/) in the user guide for details.

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
    public class QueryTasksCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var taskQueryDto = new TaskQueryDto(); // TaskQueryDto |  (optional) 

            try
            {
                // Get List Count (POST)
                CountResultDto result = apiInstance.QueryTasksCount(taskQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.QueryTasksCount: " + e.Message );
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
 **taskQueryDto** | [**TaskQueryDto**](TaskQueryDto.md)|  | [optional] 

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
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolve"></a>
# **Resolve**
> void Resolve (string id, CompleteTaskDto completeTaskDto = null)

Resolve

Resolves a task and updates execution variables.  Resolving a task marks that the assignee is done with the task delegated to them, and that it can be sent back to the owner. Can only be executed when the task has been delegated. The assignee will be set to the owner, who performed the delegation.

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
    public class ResolveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to resolve.
            var completeTaskDto = new CompleteTaskDto(); // CompleteTaskDto |  (optional) 

            try
            {
                // Resolve
                apiInstance.Resolve(id, completeTaskDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.Resolve: " + e.Message );
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
 **id** | **string**| The id of the task to resolve. | 
 **completeTaskDto** | [**CompleteTaskDto**](CompleteTaskDto.md)|  | [optional] 

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
| **400** | The variable value or type is invalid, for example if the value could not be parsed to an Integer value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | If the task does not exist or the corresponding process instance could not be resumed successfully. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setassignee"></a>
# **SetAssignee**
> void SetAssignee (string id, UserIdDto userIdDto = null)

Set Assignee

Changes the assignee of a task to a specific user.  **Note:** The difference with the [Claim Task](https://docs.camunda.org/manual/7.17/reference/rest/task/post-claim/) method is that this method does not check if the task already has a user assigned to it.

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
    public class SetAssigneeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to set the assignee for.
            var userIdDto = new UserIdDto(); // UserIdDto | Provide the id of the user that will be the assignee of the task. (optional) 

            try
            {
                // Set Assignee
                apiInstance.SetAssignee(id, userIdDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.SetAssignee: " + e.Message );
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
 **id** | **string**| The id of the task to set the assignee for. | 
 **userIdDto** | [**UserIdDto**](UserIdDto.md)| Provide the id of the user that will be the assignee of the task. | [optional] 

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
| **500** | Task with given id does not exist or setting the assignee was not successful. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submit"></a>
# **Submit**
> Dictionary&lt;string, VariableValueDto&gt; Submit (string id, CompleteTaskDto completeTaskDto = null)

Submit Form

Completes a task and updates process variables using a form submit. There are two difference between this method and the `complete` method:  * If the task is in state `PENDING` - i.e., has been delegated before, it is not completed but resolved. Otherwise it will be completed. * If the task has Form Field Metadata defined, the process engine will perform backend validation for any form fields which have validators defined. See the [Generated Task Forms](https://docs.camunda.org/manual/7.17/user-guide/task-forms/_index/#generated-task-forms) section of the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/) for more information.

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
    public class SubmitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to submit the form for.
            var completeTaskDto = new CompleteTaskDto(); // CompleteTaskDto |  (optional) 

            try
            {
                // Submit Form
                Dictionary<string, VariableValueDto> result = apiInstance.Submit(id, completeTaskDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.Submit: " + e.Message );
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
 **id** | **string**| The id of the task to submit the form for. | 
 **completeTaskDto** | [**CompleteTaskDto**](CompleteTaskDto.md)|  | [optional] 

### Return type

[**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. The response contains the process variables. |  -  |
| **204** | Request successful. The response contains no variables. |  -  |
| **400** | The variable value or type is invalid, for example if the value could not be parsed to an Integer value or the passed variable type is not supported.  See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | If the task does not exist or the corresponding process instance could not be resumed successfully.  See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unclaim"></a>
# **Unclaim**
> void Unclaim (string id)

Unclaim

Resets a task's assignee. If successful, the task is not assigned to a user.

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
    public class UnclaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to unclaim.

            try
            {
                // Unclaim
                apiInstance.Unclaim(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.Unclaim: " + e.Message );
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
 **id** | **string**| The id of the task to unclaim. | 

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
| **500** | The Task with the given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetask"></a>
# **UpdateTask**
> void UpdateTask (string id, TaskDto taskDto = null)

Update

Updates a task.

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
    public class UpdateTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to be updated.
            var taskDto = new TaskDto(); // TaskDto |  (optional) 

            try
            {
                // Update
                apiInstance.UpdateTask(id, taskDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskApi.UpdateTask: " + e.Message );
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
 **id** | **string**| The id of the task to be updated. | 
 **taskDto** | [**TaskDto**](TaskDto.md)|  | [optional] 

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
| **400** | Returned if a not valid &#x60;delegationState&#x60; is supplied. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | If the corresponding task cannot be found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

