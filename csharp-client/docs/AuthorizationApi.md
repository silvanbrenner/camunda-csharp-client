# Camunda.OpenApi.Client.Api.AuthorizationApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AvailableOperationsAuthorization**](AuthorizationApi.md#availableoperationsauthorization) | **OPTIONS** /authorization | Authorization Resource Options
[**AvailableOperationsAuthorizationInstance**](AuthorizationApi.md#availableoperationsauthorizationinstance) | **OPTIONS** /authorization/{id} | Authorization Resource Options
[**CreateAuthorization**](AuthorizationApi.md#createauthorization) | **POST** /authorization/create | Create a New Authorization
[**DeleteAuthorization**](AuthorizationApi.md#deleteauthorization) | **DELETE** /authorization/{id} | Delete Authorization
[**GetAuthorization**](AuthorizationApi.md#getauthorization) | **GET** /authorization/{id} | Get Authorization
[**GetAuthorizationCount**](AuthorizationApi.md#getauthorizationcount) | **GET** /authorization/count | Get Authorization Count
[**IsUserAuthorized**](AuthorizationApi.md#isuserauthorized) | **GET** /authorization/check | Perform an Authorization Check
[**QueryAuthorizations**](AuthorizationApi.md#queryauthorizations) | **GET** /authorization | Get Authorizations
[**UpdateAuthorization**](AuthorizationApi.md#updateauthorization) | **PUT** /authorization/{id} | Update an Authorization


<a name="availableoperationsauthorization"></a>
# **AvailableOperationsAuthorization**
> ResourceOptionsDto AvailableOperationsAuthorization ()

Authorization Resource Options

The OPTIONS request allows you to check for the set of available operations that the currently authenticated user can perform on the `/authorization` resource. Whether the user can perform an operation or not may depend on various factors, including the users authorizations to interact with this resource and the internal configuration of the process engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class AvailableOperationsAuthorizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new AuthorizationApi(config);

            try
            {
                // Authorization Resource Options
                ResourceOptionsDto result = apiInstance.AvailableOperationsAuthorization();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AvailableOperationsAuthorization: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ResourceOptionsDto**](ResourceOptionsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="availableoperationsauthorizationinstance"></a>
# **AvailableOperationsAuthorizationInstance**
> ResourceOptionsDto AvailableOperationsAuthorizationInstance (string id)

Authorization Resource Options

The OPTIONS request allows you to check for the set of available operations that the currently authenticated user can perform on a given instance of the `/authorization` resource. Whether the user can perform an operation or not may depend on various factors, including the users authorizations to interact with this resource and the internal configuration of the process engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class AvailableOperationsAuthorizationInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new AuthorizationApi(config);
            var id = id_example;  // string | The id of the authorization to be retrieved.

            try
            {
                // Authorization Resource Options
                ResourceOptionsDto result = apiInstance.AvailableOperationsAuthorizationInstance(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AvailableOperationsAuthorizationInstance: " + e.Message );
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
 **id** | **string**| The id of the authorization to be retrieved. | 

### Return type

[**ResourceOptionsDto**](ResourceOptionsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createauthorization"></a>
# **CreateAuthorization**
> AuthorizationDto CreateAuthorization (AuthorizationCreateDto authorizationCreateDto = null)

Create a New Authorization

Creates a new authorization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class CreateAuthorizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new AuthorizationApi(config);
            var authorizationCreateDto = new AuthorizationCreateDto(); // AuthorizationCreateDto |  (optional) 

            try
            {
                // Create a New Authorization
                AuthorizationDto result = apiInstance.CreateAuthorization(authorizationCreateDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.CreateAuthorization: " + e.Message );
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
 **authorizationCreateDto** | [**AuthorizationCreateDto**](AuthorizationCreateDto.md)|  | [optional] 

### Return type

[**AuthorizationDto**](AuthorizationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the properties in the request body are invalid, for example if a permission parameter is not valid for the provided resourceType. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | The authenticated user is unauthorized to create an instance of this resource. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The authorization could not be updated due to an internal server error. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthorization"></a>
# **DeleteAuthorization**
> void DeleteAuthorization (string id)

Delete Authorization

Deletes an authorization by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteAuthorizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new AuthorizationApi(config);
            var id = id_example;  // string | The id of the authorization to be deleted.

            try
            {
                // Delete Authorization
                apiInstance.DeleteAuthorization(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.DeleteAuthorization: " + e.Message );
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
 **id** | **string**| The id of the authorization to be deleted. | 

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
| **403** | If the authenticated user is unauthorized to delete the resource instance. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Authorization cannot be found. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthorization"></a>
# **GetAuthorization**
> AuthorizationDto GetAuthorization (string id)

Get Authorization

Retrieves an authorization by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetAuthorizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new AuthorizationApi(config);
            var id = id_example;  // string | The id of the authorization to be retrieved.

            try
            {
                // Get Authorization
                AuthorizationDto result = apiInstance.GetAuthorization(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorization: " + e.Message );
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
 **id** | **string**| The id of the authorization to be retrieved. | 

### Return type

[**AuthorizationDto**](AuthorizationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Authorization with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthorizationcount"></a>
# **GetAuthorizationCount**
> CountResultDto GetAuthorizationCount (string id = null, int? type = null, string userIdIn = null, string groupIdIn = null, int? resourceType = null, string resourceId = null)

Get Authorization Count

Queries for authorizations using a list of parameters and retrieves the count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetAuthorizationCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new AuthorizationApi(config);
            var id = id_example;  // string | Filter by the id of the authorization. (optional) 
            var type = 56;  // int? | Filter by authorization type. (0=global, 1=grant, 2=revoke). See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/authorization-service/#authorization-type) for more information about authorization types. (optional) 
            var userIdIn = userIdIn_example;  // string | Filter by a comma-separated list of userIds. (optional) 
            var groupIdIn = groupIdIn_example;  // string | Filter by a comma-separated list of groupIds. (optional) 
            var resourceType = 56;  // int? | Filter by an integer representation of the resource type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/authorization-service/#resources) for a list of integer representations of resource types. (optional) 
            var resourceId = resourceId_example;  // string | Filter by resource id. (optional) 

            try
            {
                // Get Authorization Count
                CountResultDto result = apiInstance.GetAuthorizationCount(id, type, userIdIn, groupIdIn, resourceType, resourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationCount: " + e.Message );
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
 **id** | **string**| Filter by the id of the authorization. | [optional] 
 **type** | **int?**| Filter by authorization type. (0&#x3D;global, 1&#x3D;grant, 2&#x3D;revoke). See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/authorization-service/#authorization-type) for more information about authorization types. | [optional] 
 **userIdIn** | **string**| Filter by a comma-separated list of userIds. | [optional] 
 **groupIdIn** | **string**| Filter by a comma-separated list of groupIds. | [optional] 
 **resourceType** | **int?**| Filter by an integer representation of the resource type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/authorization-service/#resources) for a list of integer representations of resource types. | [optional] 
 **resourceId** | **string**| Filter by resource id. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60; is specified. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="isuserauthorized"></a>
# **IsUserAuthorized**
> AuthorizationCheckResultDto IsUserAuthorized (string permissionName, string resourceName, int resourceType, string resourceId = null, string userId = null)

Perform an Authorization Check

Performs an authorization check for the currently authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class IsUserAuthorizedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new AuthorizationApi(config);
            var permissionName = permissionName_example;  // string | String value representing the permission name to check for.
            var resourceName = resourceName_example;  // string | String value for the name of the resource to check permissions for.
            var resourceType = 56;  // int | An integer representing the resource type to check permissions for. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/authorization-service/#resources) for a list of integer representations of resource types.
            var resourceId = resourceId_example;  // string | The id of the resource to check permissions for. If left blank, a check for global permissions on the resource is performed. (optional) 
            var userId = userId_example;  // string | The id of the user to check permissions for. The currently authenticated user must have a READ permission for the Authorization resource. If `userId` is blank, a check for the currently authenticated user is performed. (optional) 

            try
            {
                // Perform an Authorization Check
                AuthorizationCheckResultDto result = apiInstance.IsUserAuthorized(permissionName, resourceName, resourceType, resourceId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.IsUserAuthorized: " + e.Message );
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
 **permissionName** | **string**| String value representing the permission name to check for. | 
 **resourceName** | **string**| String value for the name of the resource to check permissions for. | 
 **resourceType** | **int**| An integer representing the resource type to check permissions for. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/authorization-service/#resources) for a list of integer representations of resource types. | 
 **resourceId** | **string**| The id of the resource to check permissions for. If left blank, a check for global permissions on the resource is performed. | [optional] 
 **userId** | **string**| The id of the user to check permissions for. The currently authenticated user must have a READ permission for the Authorization resource. If &#x60;userId&#x60; is blank, a check for the currently authenticated user is performed. | [optional] 

### Return type

[**AuthorizationCheckResultDto**](AuthorizationCheckResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a permission parameterName is not valid for the provided resourceType. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **401** | The user is not authenticated. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | When a &#x60;userId&#x60; is passed and the user does not possess a READ permission for the Authorization resource. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Authorization with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryauthorizations"></a>
# **QueryAuthorizations**
> List&lt;AuthorizationDto&gt; QueryAuthorizations (string id = null, int? type = null, string userIdIn = null, string groupIdIn = null, int? resourceType = null, string resourceId = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Authorizations

Queries for a list of authorizations using a list of parameters. The size of the result set can be retrieved by using the [Get Authorization Count](https://docs.camunda.org/manual/7.16/reference/rest/authorization/get-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryAuthorizationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new AuthorizationApi(config);
            var id = id_example;  // string | Filter by the id of the authorization. (optional) 
            var type = 56;  // int? | Filter by authorization type. (0=global, 1=grant, 2=revoke). See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/authorization-service/#authorization-type) for more information about authorization types. (optional) 
            var userIdIn = userIdIn_example;  // string | Filter by a comma-separated list of userIds. (optional) 
            var groupIdIn = groupIdIn_example;  // string | Filter by a comma-separated list of groupIds. (optional) 
            var resourceType = 56;  // int? | Filter by an integer representation of the resource type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/authorization-service/#resources) for a list of integer representations of resource types. (optional) 
            var resourceId = resourceId_example;  // string | Filter by resource id. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get Authorizations
                List<AuthorizationDto> result = apiInstance.QueryAuthorizations(id, type, userIdIn, groupIdIn, resourceType, resourceId, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.QueryAuthorizations: " + e.Message );
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
 **id** | **string**| Filter by the id of the authorization. | [optional] 
 **type** | **int?**| Filter by authorization type. (0&#x3D;global, 1&#x3D;grant, 2&#x3D;revoke). See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/authorization-service/#authorization-type) for more information about authorization types. | [optional] 
 **userIdIn** | **string**| Filter by a comma-separated list of userIds. | [optional] 
 **groupIdIn** | **string**| Filter by a comma-separated list of groupIds. | [optional] 
 **resourceType** | **int?**| Filter by an integer representation of the resource type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/authorization-service/#resources) for a list of integer representations of resource types. | [optional] 
 **resourceId** | **string**| Filter by resource id. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;AuthorizationDto&gt;**](AuthorizationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60; is specified. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateauthorization"></a>
# **UpdateAuthorization**
> void UpdateAuthorization (string id, AuthorizationUpdateDto authorizationUpdateDto = null)

Update an Authorization

Updates an authorization by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateAuthorizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new AuthorizationApi(config);
            var id = id_example;  // string | The id of the authorization to be updated.
            var authorizationUpdateDto = new AuthorizationUpdateDto(); // AuthorizationUpdateDto |  (optional) 

            try
            {
                // Update an Authorization
                apiInstance.UpdateAuthorization(id, authorizationUpdateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.UpdateAuthorization: " + e.Message );
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
 **id** | **string**| The id of the authorization to be updated. | 
 **authorizationUpdateDto** | [**AuthorizationUpdateDto**](AuthorizationUpdateDto.md)|  | [optional] 

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
| **204** | Request successful. This method returns no content. |  -  |
| **400** | Returned if some of the properties in the request body are invalid, for example if a permission parameter is not valid for the provided resourceType. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **403** | The authenticated user is unauthorized to update this resource. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | The authorization with the requested Id cannot be found. |  -  |
| **500** | The authorization could not be updated due to an internal server error. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

