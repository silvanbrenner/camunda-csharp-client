# CamundaClient.Api.TaskIdentityLinkApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddIdentityLink**](TaskIdentityLinkApi.md#addidentitylink) | **POST** /task/{id}/identity-links | 
[**DeleteIdentityLink**](TaskIdentityLinkApi.md#deleteidentitylink) | **POST** /task/{id}/identity-links/delete | 
[**GetIdentityLinks**](TaskIdentityLinkApi.md#getidentitylinks) | **GET** /task/{id}/identity-links | 


<a name="addidentitylink"></a>
# **AddIdentityLink**
> void AddIdentityLink (string id, IdentityLinkDto identityLinkDto = null)



Adds an identity link to a task by id. Can be used to link any user or group to a task and specify a relation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class AddIdentityLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskIdentityLinkApi(config);
            var id = id_example;  // string | The id of the task to add a link to.
            var identityLinkDto = new IdentityLinkDto(); // IdentityLinkDto |  (optional) 

            try
            {
                apiInstance.AddIdentityLink(id, identityLinkDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskIdentityLinkApi.AddIdentityLink: " + e.Message );
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
 **id** | **string**| The id of the task to add a link to. | 
 **identityLinkDto** | [**IdentityLinkDto**](IdentityLinkDto.md)|  | [optional] 

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
| **400** | Task with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteidentitylink"></a>
# **DeleteIdentityLink**
> void DeleteIdentityLink (string id, IdentityLinkDto identityLinkDto = null)



Removes an identity link from a task by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class DeleteIdentityLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskIdentityLinkApi(config);
            var id = id_example;  // string | The id of the task to remove a link from.
            var identityLinkDto = new IdentityLinkDto(); // IdentityLinkDto |  (optional) 

            try
            {
                apiInstance.DeleteIdentityLink(id, identityLinkDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskIdentityLinkApi.DeleteIdentityLink: " + e.Message );
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
 **id** | **string**| The id of the task to remove a link from. | 
 **identityLinkDto** | [**IdentityLinkDto**](IdentityLinkDto.md)|  | [optional] 

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
| **400** | Task with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentitylinks"></a>
# **GetIdentityLinks**
> List&lt;IdentityLinkDto&gt; GetIdentityLinks (string id, string type = null)



Gets the identity links for a task by id, which are the users and groups that are in *some* relation to it (including assignee and owner).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetIdentityLinksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskIdentityLinkApi(config);
            var id = id_example;  // string | The id of the task to retrieve the identity links for.
            var type = type_example;  // string | Filter by the type of links to include. (optional) 

            try
            {
                List<IdentityLinkDto> result = apiInstance.GetIdentityLinks(id, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskIdentityLinkApi.GetIdentityLinks: " + e.Message );
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
 **id** | **string**| The id of the task to retrieve the identity links for. | 
 **type** | **string**| Filter by the type of links to include. | [optional] 

### Return type

[**List&lt;IdentityLinkDto&gt;**](IdentityLinkDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Task with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

