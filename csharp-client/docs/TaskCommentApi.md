# CamundaClient.Api.TaskCommentApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateComment**](TaskCommentApi.md#createcomment) | **POST** /task/{id}/comment/create | 
[**GetComment**](TaskCommentApi.md#getcomment) | **GET** /task/{id}/comment/{commentId} | 
[**GetComments**](TaskCommentApi.md#getcomments) | **GET** /task/{id}/comment | 


<a name="createcomment"></a>
# **CreateComment**
> CommentDto CreateComment (string id, CommentDto commentDto = null)



Creates a comment for a task by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class CreateCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskCommentApi(config);
            var id = id_example;  // string | The id of the task to add the comment to.
            var commentDto = new CommentDto(); // CommentDto | **Note:** Only the `message` property will be used. Every other property passed to this endpoint will be ignored. (optional) 

            try
            {
                CommentDto result = apiInstance.CreateComment(id, commentDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskCommentApi.CreateComment: " + e.Message );
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
 **id** | **string**| The id of the task to add the comment to. | 
 **commentDto** | [**CommentDto**](CommentDto.md)| **Note:** Only the &#x60;message&#x60; property will be used. Every other property passed to this endpoint will be ignored. | [optional] 

### Return type

[**CommentDto**](CommentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The task does not exist or no comment message was submitted. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | The history of the engine is disabled. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomment"></a>
# **GetComment**
> CommentDto GetComment (string id, string commentId)



Retrieves a task comment by task id and comment id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskCommentApi(config);
            var id = id_example;  // string | The id of the task.
            var commentId = commentId_example;  // string | The id of the comment to be retrieved.

            try
            {
                CommentDto result = apiInstance.GetComment(id, commentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskCommentApi.GetComment: " + e.Message );
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
 **commentId** | **string**| The id of the comment to be retrieved. | 

### Return type

[**CommentDto**](CommentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | The task or comment with given task and comment id does not exist, or the history of the engine is disabled. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomments"></a>
# **GetComments**
> List&lt;CommentDto&gt; GetComments (string id)



Gets the comments for a task by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetCommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskCommentApi(config);
            var id = id_example;  // string | The id of the task to retrieve the comments for.

            try
            {
                List<CommentDto> result = apiInstance.GetComments(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskCommentApi.GetComments: " + e.Message );
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
 **id** | **string**| The id of the task to retrieve the comments for. | 

### Return type

[**List&lt;CommentDto&gt;**](CommentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | No task exists for the given task id. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

