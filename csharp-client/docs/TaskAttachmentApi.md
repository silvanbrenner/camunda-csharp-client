# Camunda.OpenApi.Client.Api.TaskAttachmentApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAttachment**](TaskAttachmentApi.md#addattachment) | **POST** /task/{id}/attachment/create | Create
[**DeleteAttachment**](TaskAttachmentApi.md#deleteattachment) | **DELETE** /task/{id}/attachment/{attachmentId} | Delete
[**GetAttachment**](TaskAttachmentApi.md#getattachment) | **GET** /task/{id}/attachment/{attachmentId} | Get
[**GetAttachmentData**](TaskAttachmentApi.md#getattachmentdata) | **GET** /task/{id}/attachment/{attachmentId}/data | Get (Binary)
[**GetAttachments**](TaskAttachmentApi.md#getattachments) | **GET** /task/{id}/attachment | Get List


<a name="addattachment"></a>
# **AddAttachment**
> AttachmentDto AddAttachment (string id, string attachmentName = null, string attachmentDescription = null, string attachmentType = null, string url = null, FileParameter content = null)

Create

Creates an attachment for a task.

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
    public class AddAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskAttachmentApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to add the attachment to.
            var attachmentName = attachmentName_example;  // string | The name of the attachment. (optional) 
            var attachmentDescription = attachmentDescription_example;  // string | The description of the attachment. (optional) 
            var attachmentType = attachmentType_example;  // string | The type of the attachment. (optional) 
            var url = url_example;  // string | The url to the remote content of the attachment. (optional) 
            var content = BINARY_DATA_HERE;  // FileParameter | The content of the attachment. (optional) 

            try
            {
                // Create
                AttachmentDto result = apiInstance.AddAttachment(id, attachmentName, attachmentDescription, attachmentType, url, content);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskAttachmentApi.AddAttachment: " + e.Message );
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
 **id** | **string**| The id of the task to add the attachment to. | 
 **attachmentName** | **string**| The name of the attachment. | [optional] 
 **attachmentDescription** | **string**| The description of the attachment. | [optional] 
 **attachmentType** | **string**| The type of the attachment. | [optional] 
 **url** | **string**| The url to the remote content of the attachment. | [optional] 
 **content** | **FileParameter****FileParameter**| The content of the attachment. | [optional] 

### Return type

[**AttachmentDto**](AttachmentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The task does not exists or task id is null. No content or url to remote content exists. See the [Introduction](/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | The history of the engine is disabled. See the [Introduction](/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteattachment"></a>
# **DeleteAttachment**
> void DeleteAttachment (string id, string attachmentId)

Delete

Removes an attachment from a task by id.

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
    public class DeleteAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskAttachmentApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task.
            var attachmentId = attachmentId_example;  // string | The id of the attachment to be removed.

            try
            {
                // Delete
                apiInstance.DeleteAttachment(id, attachmentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskAttachmentApi.DeleteAttachment: " + e.Message );
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
 **id** | **string**| The id of the task. | 
 **attachmentId** | **string**| The id of the attachment to be removed. | 

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
| **403** | The history of the engine is disabled. See the [Introduction](/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | A Task Attachment for the given task id and attachment id does not exist. See the [Introduction](/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachment"></a>
# **GetAttachment**
> AttachmentDto GetAttachment (string id, string attachmentId)

Get

Retrieves a task attachment by task id and attachment id.

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
    public class GetAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskAttachmentApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task.
            var attachmentId = attachmentId_example;  // string | The id of the attachment to be retrieved.

            try
            {
                // Get
                AttachmentDto result = apiInstance.GetAttachment(id, attachmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskAttachmentApi.GetAttachment: " + e.Message );
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
 **id** | **string**| The id of the task. | 
 **attachmentId** | **string**| The id of the attachment to be retrieved. | 

### Return type

[**AttachmentDto**](AttachmentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | The attachment for the given task and attachment id does not exist or the history of the engine is disabled.  See the [Introduction](/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachmentdata"></a>
# **GetAttachmentData**
> FileParameter GetAttachmentData (string id, string attachmentId)

Get (Binary)

Retrieves the binary content of a task attachment by task id and attachment id.

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
    public class GetAttachmentDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskAttachmentApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task.
            var attachmentId = attachmentId_example;  // string | The id of the attachment to be retrieved.

            try
            {
                // Get (Binary)
                FileParameter result = apiInstance.GetAttachmentData(id, attachmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskAttachmentApi.GetAttachmentData: " + e.Message );
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
 **id** | **string**| The id of the task. | 
 **attachmentId** | **string**| The id of the attachment to be retrieved. | 

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
| **200** | Request successful. |  -  |
| **404** | The attachment content for the given task id and attachment id does not exist, or the history of the engine is disabled.  See the [Introduction](/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachments"></a>
# **GetAttachments**
> List&lt;AttachmentDto&gt; GetAttachments (string id)

Get List

Gets the attachments for a task.

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
    public class GetAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskAttachmentApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the task to retrieve the attachments for.

            try
            {
                // Get List
                List<AttachmentDto> result = apiInstance.GetAttachments(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskAttachmentApi.GetAttachments: " + e.Message );
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
 **id** | **string**| The id of the task to retrieve the attachments for. | 

### Return type

[**List&lt;AttachmentDto&gt;**](AttachmentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | No task exists for the given task id. See the [Introduction](/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

