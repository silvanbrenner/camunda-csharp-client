# Camunda.OpenApi.Client.Api.GroupApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AvailableGroupInstanceOperations**](GroupApi.md#availablegroupinstanceoperations) | **OPTIONS** /group/{id} | Group Resource Instance Options
[**AvailableGroupMembersOperations**](GroupApi.md#availablegroupmembersoperations) | **OPTIONS** /group/{id}/members | Group Membership Resource Options
[**AvailableGroupOperations**](GroupApi.md#availablegroupoperations) | **OPTIONS** /group | Group Resource Options
[**CreateGroup**](GroupApi.md#creategroup) | **POST** /group/create | Create Group
[**CreateGroupMember**](GroupApi.md#creategroupmember) | **PUT** /group/{id}/members/{userId} | Create Group Member
[**DeleteGroup**](GroupApi.md#deletegroup) | **DELETE** /group/{id} | Delete Group
[**DeleteGroupMember**](GroupApi.md#deletegroupmember) | **DELETE** /group/{id}/members/{userId} | Delete a Group Member
[**GetGroup**](GroupApi.md#getgroup) | **GET** /group/{id} | Get Group
[**GetGroupCount**](GroupApi.md#getgroupcount) | **GET** /group/count | Get List Count
[**GetQueryGroups**](GroupApi.md#getquerygroups) | **GET** /group | Get List
[**PostQueryGroups**](GroupApi.md#postquerygroups) | **POST** /group | Get List (POST)
[**QueryGroupCount**](GroupApi.md#querygroupcount) | **POST** /group/count | Get List Count (POST)
[**UpdateGroup**](GroupApi.md#updategroup) | **PUT** /group/{id} | Update Group


<a name="availablegroupinstanceoperations"></a>
# **AvailableGroupInstanceOperations**
> ResourceOptionsDto AvailableGroupInstanceOperations (string id)

Group Resource Instance Options

The `/group` resource supports two custom OPTIONS requests, one for the resource as such and this one for individual group instances. The OPTIONS request allows checking for the set of available operations that the currently authenticated user can perform on the `/group/{id}` resource instance. If the user can perform an operation or not may depend on various things, including the users authorizations to interact with this resource and the internal configuration of the process engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class AvailableGroupInstanceOperationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var id = id_example;  // string | The id of the group.

            try
            {
                // Group Resource Instance Options
                ResourceOptionsDto result = apiInstance.AvailableGroupInstanceOperations(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.AvailableGroupInstanceOperations: " + e.Message );
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
 **id** | **string**| The id of the group. | 

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

<a name="availablegroupmembersoperations"></a>
# **AvailableGroupMembersOperations**
> ResourceOptionsDto AvailableGroupMembersOperations (string id)

Group Membership Resource Options

The OPTIONS request allows checking for the set of available operations that the currently authenticated user can perform on the resource. If the user can perform an operation or not may depend on various things, including the users authorizations to interact with this resource and the internal configuration of the process engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class AvailableGroupMembersOperationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var id = id_example;  // string | The id of the group.

            try
            {
                // Group Membership Resource Options
                ResourceOptionsDto result = apiInstance.AvailableGroupMembersOperations(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.AvailableGroupMembersOperations: " + e.Message );
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
 **id** | **string**| The id of the group. | 

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

<a name="availablegroupoperations"></a>
# **AvailableGroupOperations**
> ResourceOptionsDto AvailableGroupOperations ()

Group Resource Options

The `/group` resource supports two custom OPTIONS requests, this one for the resource as such and one for individual group instances. The OPTIONS request allows checking for the set of available operations that the currently authenticated user can perform on the `/group` resource. If the user can perform an operation or not may depend on various things, including the users authorizations to interact with this resource and the internal configuration of the process engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class AvailableGroupOperationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);

            try
            {
                // Group Resource Options
                ResourceOptionsDto result = apiInstance.AvailableGroupOperations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.AvailableGroupOperations: " + e.Message );
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

<a name="creategroup"></a>
# **CreateGroup**
> void CreateGroup (GroupDto groupDto = null)

Create Group

Creates a new group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var groupDto = new GroupDto(); // GroupDto |  (optional) 

            try
            {
                // Create Group
                apiInstance.CreateGroup(groupDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.CreateGroup: " + e.Message );
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
 **groupDto** | [**GroupDto**](GroupDto.md)|  | [optional] 

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
| **403** | Identity service is read-only (Cannot modify users / groups / memberships). |  -  |
| **500** | The group could not be created due to an internal server error. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategroupmember"></a>
# **CreateGroupMember**
> void CreateGroupMember (string id, string userId)

Create Group Member

Adds a member to a group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class CreateGroupMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var id = id_example;  // string | The id of the group.
            var userId = userId_example;  // string | The id of user to add to the group.

            try
            {
                // Create Group Member
                apiInstance.CreateGroupMember(id, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.CreateGroupMember: " + e.Message );
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
 **id** | **string**| The id of the group. | 
 **userId** | **string**| The id of user to add to the group. | 

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
| **403** | Identity service is read-only (Cannot modify users / groups / memberships). |  -  |
| **500** | In case an internal error occurs. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (string id)

Delete Group

Deletes a group by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var id = id_example;  // string | The id of the group to be deleted.

            try
            {
                // Delete Group
                apiInstance.DeleteGroup(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.DeleteGroup: " + e.Message );
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
 **id** | **string**| The id of the group to be deleted. | 

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
| **403** | Identity service is read-only (Cannot modify users / groups / memberships). |  -  |
| **404** | Group cannot be found. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupmember"></a>
# **DeleteGroupMember**
> void DeleteGroupMember (string id, string userId)

Delete a Group Member

Removes a member from a group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteGroupMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var id = id_example;  // string | The id of the group.
            var userId = userId_example;  // string | The id of user to remove from the group.

            try
            {
                // Delete a Group Member
                apiInstance.DeleteGroupMember(id, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.DeleteGroupMember: " + e.Message );
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
 **id** | **string**| The id of the group. | 
 **userId** | **string**| The id of user to remove from the group. | 

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
| **403** | Identity service is read-only (Cannot modify users / groups / memberships). |  -  |
| **500** | In case an error occurs. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroup"></a>
# **GetGroup**
> GroupDto GetGroup (string id)

Get Group

Retrieves a group by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var id = id_example;  // string | The id of the group to be retrieved.

            try
            {
                // Get Group
                GroupDto result = apiInstance.GetGroup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.GetGroup: " + e.Message );
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
 **id** | **string**| The id of the group to be retrieved. | 

### Return type

[**GroupDto**](GroupDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Group with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupcount"></a>
# **GetGroupCount**
> CountResultDto GetGroupCount (string id = null, string idIn = null, string name = null, string nameLike = null, string type = null, string member = null, string memberOfTenant = null)

Get List Count

Queries for groups using a list of parameters and retrieves the count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetGroupCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var id = id_example;  // string | Filter by the id of the group. (optional) 
            var idIn = idIn_example;  // string | Filter by a comma seperated list of group ids. (optional) 
            var name = name_example;  // string | Filter by the name of the group. (optional) 
            var nameLike = nameLike_example;  // string | Filter by the name that the parameter is a substring of. (optional) 
            var type = type_example;  // string | Filter by the type of the group. (optional) 
            var member = member_example;  // string | Only retrieve groups where the given user id is a member of. (optional) 
            var memberOfTenant = memberOfTenant_example;  // string | Only retrieve groups which are members of the given tenant. (optional) 

            try
            {
                // Get List Count
                CountResultDto result = apiInstance.GetGroupCount(id, idIn, name, nameLike, type, member, memberOfTenant);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.GetGroupCount: " + e.Message );
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
 **id** | **string**| Filter by the id of the group. | [optional] 
 **idIn** | **string**| Filter by a comma seperated list of group ids. | [optional] 
 **name** | **string**| Filter by the name of the group. | [optional] 
 **nameLike** | **string**| Filter by the name that the parameter is a substring of. | [optional] 
 **type** | **string**| Filter by the type of the group. | [optional] 
 **member** | **string**| Only retrieve groups where the given user id is a member of. | [optional] 
 **memberOfTenant** | **string**| Only retrieve groups which are members of the given tenant. | [optional] 

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

<a name="getquerygroups"></a>
# **GetQueryGroups**
> List&lt;GroupDto&gt; GetQueryGroups (string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null, string id = null, string idIn = null, string name = null, string nameLike = null, string type = null, string member = null, string memberOfTenant = null)

Get List

Queries for a list of groups using a list of parameters. The size of the result set can be retrieved by using the [Get Group Count](https://docs.camunda.org/manual/7.16/reference/rest/group/get-query-count) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetQueryGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var id = id_example;  // string | Filter by the id of the group. (optional) 
            var idIn = idIn_example;  // string | Filter by a comma seperated list of group ids. (optional) 
            var name = name_example;  // string | Filter by the name of the group. (optional) 
            var nameLike = nameLike_example;  // string | Filter by the name that the parameter is a substring of. (optional) 
            var type = type_example;  // string | Filter by the type of the group. (optional) 
            var member = member_example;  // string | Only retrieve groups where the given user id is a member of. (optional) 
            var memberOfTenant = memberOfTenant_example;  // string | Only retrieve groups which are members of the given tenant. (optional) 

            try
            {
                // Get List
                List<GroupDto> result = apiInstance.GetQueryGroups(sortBy, sortOrder, firstResult, maxResults, id, idIn, name, nameLike, type, member, memberOfTenant);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.GetQueryGroups: " + e.Message );
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
 **id** | **string**| Filter by the id of the group. | [optional] 
 **idIn** | **string**| Filter by a comma seperated list of group ids. | [optional] 
 **name** | **string**| Filter by the name of the group. | [optional] 
 **nameLike** | **string**| Filter by the name that the parameter is a substring of. | [optional] 
 **type** | **string**| Filter by the type of the group. | [optional] 
 **member** | **string**| Only retrieve groups where the given user id is a member of. | [optional] 
 **memberOfTenant** | **string**| Only retrieve groups which are members of the given tenant. | [optional] 

### Return type

[**List&lt;GroupDto&gt;**](GroupDto.md)

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

<a name="postquerygroups"></a>
# **PostQueryGroups**
> List&lt;GroupDto&gt; PostQueryGroups (int? firstResult = null, int? maxResults = null, GroupQueryDto groupQueryDto = null)

Get List (POST)

Queries for a list of groups using a list of parameters. The size of the result set can be retrieved by using the [Get Group Count (POST)](https://docs.camunda.org/manual/7.16/reference/rest/group/post-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class PostQueryGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var groupQueryDto = new GroupQueryDto(); // GroupQueryDto |  (optional) 

            try
            {
                // Get List (POST)
                List<GroupDto> result = apiInstance.PostQueryGroups(firstResult, maxResults, groupQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.PostQueryGroups: " + e.Message );
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
 **groupQueryDto** | [**GroupQueryDto**](GroupQueryDto.md)|  | [optional] 

### Return type

[**List&lt;GroupDto&gt;**](GroupDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60; is specified. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querygroupcount"></a>
# **QueryGroupCount**
> CountResultDto QueryGroupCount (GroupQueryDto groupQueryDto = null)

Get List Count (POST)

Queries for groups using a list of parameters and retrieves the count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class QueryGroupCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var groupQueryDto = new GroupQueryDto(); // GroupQueryDto |  (optional) 

            try
            {
                // Get List Count (POST)
                CountResultDto result = apiInstance.QueryGroupCount(groupQueryDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.QueryGroupCount: " + e.Message );
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
 **groupQueryDto** | [**GroupQueryDto**](GroupQueryDto.md)|  | [optional] 

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

<a name="updategroup"></a>
# **UpdateGroup**
> void UpdateGroup (string id, GroupDto groupDto = null)

Update Group

Updates a given group by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new GroupApi(config);
            var id = id_example;  // string | The id of the group.
            var groupDto = new GroupDto(); // GroupDto |  (optional) 

            try
            {
                // Update Group
                apiInstance.UpdateGroup(id, groupDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.UpdateGroup: " + e.Message );
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
 **id** | **string**| The id of the group. | 
 **groupDto** | [**GroupDto**](GroupDto.md)|  | [optional] 

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
| **204** | Request successful. No content. |  -  |
| **403** | Identity service is read-only (Cannot modify users / groups / memberships). |  -  |
| **404** | If the group with the requested Id cannot be found. |  -  |
| **500** | The group could not be updated due to an internal server error. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

