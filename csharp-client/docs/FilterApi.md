# Camunda.OpenApi.Client.Api.FilterApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFilter**](FilterApi.md#createfilter) | **POST** /filter/create | Create Filter
[**DeleteFilter**](FilterApi.md#deletefilter) | **DELETE** /filter/{id} | Delete Filter
[**ExecuteFilterCount**](FilterApi.md#executefiltercount) | **GET** /filter/{id}/count | Execute Filter Count
[**ExecuteFilterList**](FilterApi.md#executefilterlist) | **GET** /filter/{id}/list | Execute Filter List
[**ExecuteFilterSingleResult**](FilterApi.md#executefiltersingleresult) | **GET** /filter/{id}/singleResult | Execute Filter Single Result
[**FilterResourceOptions**](FilterApi.md#filterresourceoptions) | **OPTIONS** /filter | Filter Resource Options
[**FilterResourceOptionsSingle**](FilterApi.md#filterresourceoptionssingle) | **OPTIONS** /filter/{id} | Filter Resource Options
[**GetFilterCount**](FilterApi.md#getfiltercount) | **GET** /filter/count | Get Filter Count
[**GetFilterList**](FilterApi.md#getfilterlist) | **GET** /filter | Get Filters
[**GetSingleFilter**](FilterApi.md#getsinglefilter) | **GET** /filter/{id} | Get Single Filter
[**PostExecuteFilterCount**](FilterApi.md#postexecutefiltercount) | **POST** /filter/{id}/count | Execute Filter Count (POST)
[**PostExecuteFilterList**](FilterApi.md#postexecutefilterlist) | **POST** /filter/{id}/list | Execute Filter List (POST)
[**PostExecuteFilterSingleResult**](FilterApi.md#postexecutefiltersingleresult) | **POST** /filter/{id}/singleResult | Execute Filter Single Result (POST)
[**UpdateFilter**](FilterApi.md#updatefilter) | **PUT** /filter/{id} | Update Filter


<a name="createfilter"></a>
# **CreateFilter**
> FilterDto CreateFilter (CreateFilterDto createFilterDto = null)

Create Filter

Creates a new filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class CreateFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var createFilterDto = new CreateFilterDto(); // CreateFilterDto |  (optional) 

            try
            {
                // Create Filter
                FilterDto result = apiInstance.CreateFilter(createFilterDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.CreateFilter: " + e.Message );
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
 **createFilterDto** | [**CreateFilterDto**](CreateFilterDto.md)|  | [optional] 

### Return type

[**FilterDto**](FilterDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** |  Filter was invalid. See [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **403** |  The authenticated user is unauthorized to create a new filter. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefilter"></a>
# **DeleteFilter**
> void DeleteFilter (string id)

Delete Filter

Deletes a filter by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var id = id_example;  // string | The id of the filter to be deleted.

            try
            {
                // Delete Filter
                apiInstance.DeleteFilter(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.DeleteFilter: " + e.Message );
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
 **id** | **string**| The id of the filter to be deleted. | 

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
| **403** |  The authenticated user is unauthorized to delete this filter. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **404** |  Filter cannot be found. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executefiltercount"></a>
# **ExecuteFilterCount**
> CountResultDto ExecuteFilterCount (string id)

Execute Filter Count

Executes the saved query of the filter by id and returns the count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ExecuteFilterCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var id = id_example;  // string | The id of the filter to execute.

            try
            {
                // Execute Filter Count
                CountResultDto result = apiInstance.ExecuteFilterCount(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.ExecuteFilterCount: " + e.Message );
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
 **id** | **string**| The id of the filter to execute. | 

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
| **403** |  The authenticated user is unauthorized to read this filter. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **404** |  Filter with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executefilterlist"></a>
# **ExecuteFilterList**
> List&lt;Object&gt; ExecuteFilterList (string id, int? firstResult = null, int? maxResults = null)

Execute Filter List

Executes the saved query of the filter by id and returns the result list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ExecuteFilterListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var id = id_example;  // string | The id of the filter to execute.
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Execute Filter List
                List<Object> result = apiInstance.ExecuteFilterList(id, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.ExecuteFilterList: " + e.Message );
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
 **id** | **string**| The id of the filter to execute. | 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. A JSON array containing JSON objects corresponding to the matching entity interface in the engine. This depends on the saved query in the filter. Therefore it is not possible to specify a generic result format, i.e., if the resource type of the filter is Task the result will correspond to the Task interface in the engine. |  -  |
| **403** |  The authenticated user is unauthorized to read this filter. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **404** |  Filter with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executefiltersingleresult"></a>
# **ExecuteFilterSingleResult**
> Object ExecuteFilterSingleResult (string id)

Execute Filter Single Result

Executes the saved query of the filter by id and returns the single result.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ExecuteFilterSingleResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var id = id_example;  // string | The id of the filter to execute.

            try
            {
                // Execute Filter Single Result
                Object result = apiInstance.ExecuteFilterSingleResult(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.ExecuteFilterSingleResult: " + e.Message );
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
 **id** | **string**| The id of the filter to execute. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. A JSON object corresponding to the matching entity interface in the engine. This depends on the saved query in the filter. Therefore it is not possible to specify a generic result format, i.e., if the resource type of the filter is Task the result will correspond to the Task interface in the engine. |  -  |
| **204** | Request successful, but the result was empty. This method returns no content. |  -  |
| **400** |  The executed filter returned more than one single result. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **403** |  The authenticated user is unauthorized to read this filter. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **404** |  Filter with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filterresourceoptions"></a>
# **FilterResourceOptions**
> ResourceOptionsDto FilterResourceOptions ()

Filter Resource Options

The OPTIONS request allows you to check for the set of available operations  that the currently authenticated user can perform on the `/filter` resource. Whether the user can perform an operation or not may depend on various factors, including the users authorizations to interact with this resource and the internal configuration of the process engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class FilterResourceOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);

            try
            {
                // Filter Resource Options
                ResourceOptionsDto result = apiInstance.FilterResourceOptions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.FilterResourceOptions: " + e.Message );
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

<a name="filterresourceoptionssingle"></a>
# **FilterResourceOptionsSingle**
> ResourceOptionsDto FilterResourceOptionsSingle (string id)

Filter Resource Options

The OPTIONS request allows you to check for the set of available operations  that the currently authenticated user can perform on the `/filter` resource. Whether the user can perform an operation or not may depend on various factors, including the users authorizations to interact with this resource and the internal configuration of the process engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class FilterResourceOptionsSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var id = id_example;  // string | The id of the filter to be checked.

            try
            {
                // Filter Resource Options
                ResourceOptionsDto result = apiInstance.FilterResourceOptionsSingle(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.FilterResourceOptionsSingle: " + e.Message );
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
 **id** | **string**| The id of the filter to be checked. | 

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

<a name="getfiltercount"></a>
# **GetFilterCount**
> CountResultDto GetFilterCount (string filterId = null, string resourceType = null, string name = null, string nameLike = null, string owner = null)

Get Filter Count

Retrieves the number of filters that fulfill a provided query. Corresponds to the size of the result set when using the  [Get Filters](https://docs.camunda.org/manual/7.16/reference/rest/filter/get-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetFilterCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var filterId = filterId_example;  // string | Filter by the id of the filter. (optional) 
            var resourceType = resourceType_example;  // string | Filter by the resource type of the filter, e.g., `Task`. (optional) 
            var name = name_example;  // string | Filter by the name of the filter. (optional) 
            var nameLike = nameLike_example;  // string | Filter by the name that the parameter is a substring of. (optional) 
            var owner = owner_example;  // string | Filter by the user id of the owner of the filter. (optional) 

            try
            {
                // Get Filter Count
                CountResultDto result = apiInstance.GetFilterCount(filterId, resourceType, name, nameLike, owner);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.GetFilterCount: " + e.Message );
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
 **filterId** | **string**| Filter by the id of the filter. | [optional] 
 **resourceType** | **string**| Filter by the resource type of the filter, e.g., &#x60;Task&#x60;. | [optional] 
 **name** | **string**| Filter by the name of the filter. | [optional] 
 **nameLike** | **string**| Filter by the name that the parameter is a substring of. | [optional] 
 **owner** | **string**| Filter by the user id of the owner of the filter. | [optional] 

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
| **400** |  Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60;parameter is supplied, but no &#x60;sortBy&#x60;, or if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilterlist"></a>
# **GetFilterList**
> List&lt;FilterDto&gt; GetFilterList (string filterId = null, string resourceType = null, string name = null, string nameLike = null, string owner = null, bool? itemCount = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Filters

Queries for a list of filters using a list of parameters. The size of the result set can be retrieved by using the [Get Filter Count](https://docs.camunda.org/manual/7.16/reference/rest/filter/get-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetFilterListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var filterId = filterId_example;  // string | Filter by the id of the filter. (optional) 
            var resourceType = resourceType_example;  // string | Filter by the resource type of the filter, e.g., `Task`. (optional) 
            var name = name_example;  // string | Filter by the name of the filter. (optional) 
            var nameLike = nameLike_example;  // string | Filter by the name that the parameter is a substring of. (optional) 
            var owner = owner_example;  // string | Filter by the user id of the owner of the filter. (optional) 
            var itemCount = true;  // bool? | If set to `true`, each filter result will contain an `itemCount` property with the number of items matched by the filter itself. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get Filters
                List<FilterDto> result = apiInstance.GetFilterList(filterId, resourceType, name, nameLike, owner, itemCount, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.GetFilterList: " + e.Message );
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
 **filterId** | **string**| Filter by the id of the filter. | [optional] 
 **resourceType** | **string**| Filter by the resource type of the filter, e.g., &#x60;Task&#x60;. | [optional] 
 **name** | **string**| Filter by the name of the filter. | [optional] 
 **nameLike** | **string**| Filter by the name that the parameter is a substring of. | [optional] 
 **owner** | **string**| Filter by the user id of the owner of the filter. | [optional] 
 **itemCount** | **bool?**| If set to &#x60;true&#x60;, each filter result will contain an &#x60;itemCount&#x60; property with the number of items matched by the filter itself. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;FilterDto&gt;**](FilterDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** |  Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60; is specified. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsinglefilter"></a>
# **GetSingleFilter**
> FilterDto GetSingleFilter (string id, bool? itemCount = null)

Get Single Filter

Retrieves a single filter by id, according to the `Filter` interface in the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetSingleFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var id = id_example;  // string | The id of the filter to be retrieved.
            var itemCount = true;  // bool? | If set to `true`, each filter result will contain an `itemCount` property with the number of items matched by the filter itself. (optional) 

            try
            {
                // Get Single Filter
                FilterDto result = apiInstance.GetSingleFilter(id, itemCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.GetSingleFilter: " + e.Message );
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
 **id** | **string**| The id of the filter to be retrieved. | 
 **itemCount** | **bool?**| If set to &#x60;true&#x60;, each filter result will contain an &#x60;itemCount&#x60; property with the number of items matched by the filter itself. | [optional] 

### Return type

[**FilterDto**](FilterDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **403** | The authenticated user is unauthorized to read this filter. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Filter with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexecutefiltercount"></a>
# **PostExecuteFilterCount**
> CountResultDto PostExecuteFilterCount (string id, Object body = null)

Execute Filter Count (POST)

Executes the saved query of the filter by id and returns the count. This method is slightly more powerful then the [Get Execute Filter Count](https://docs.camunda.org/manual/7.16/reference/rest/filter/get-execute-count/)  method because it allows to extend the saved query of the filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class PostExecuteFilterCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var id = id_example;  // string | The id of the filter to execute.
            var body = {"assignee":"jonny1","taskDefinitionKey":"aTaskKey"};  // Object | A JSON object which corresponds to the type of the saved query of the filter, i.e., if the resource type of the filter is Task the body should form a valid task query corresponding to the Task resource. (optional) 

            try
            {
                // Execute Filter Count (POST)
                CountResultDto result = apiInstance.PostExecuteFilterCount(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.PostExecuteFilterCount: " + e.Message );
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
 **id** | **string**| The id of the filter to execute. | 
 **body** | **Object**| A JSON object which corresponds to the type of the saved query of the filter, i.e., if the resource type of the filter is Task the body should form a valid task query corresponding to the Task resource. | [optional] 

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
| **400** |  The extending query was invalid. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **403** |  The authenticated user is unauthorized to read this filter. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **404** |  Filter with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexecutefilterlist"></a>
# **PostExecuteFilterList**
> List&lt;Object&gt; PostExecuteFilterList (string id, int? firstResult = null, int? maxResults = null, Object body = null)

Execute Filter List (POST)

Executes the saved query of the filter by id and returns the result list. This method is slightly more powerful then the  [Get Execute FilterList](https://docs.camunda.org/manual/7.16/reference/rest/filter/get-execute-list/) method because it allows to extend the saved query of the filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class PostExecuteFilterListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var id = id_example;  // string | The id of the filter to execute.
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var body = {"assignee":"jonny1","taskDefinitionKey":"aTaskKey"};  // Object | A JSON object which corresponds to the type of the saved query of the filter, i.e., if the resource type of the filter is Task the body should form a valid task query corresponding to the Task resource. (optional) 

            try
            {
                // Execute Filter List (POST)
                List<Object> result = apiInstance.PostExecuteFilterList(id, firstResult, maxResults, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.PostExecuteFilterList: " + e.Message );
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
 **id** | **string**| The id of the filter to execute. | 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 
 **body** | **Object**| A JSON object which corresponds to the type of the saved query of the filter, i.e., if the resource type of the filter is Task the body should form a valid task query corresponding to the Task resource. | [optional] 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. A JSON array containing JSON objects corresponding to the matching entity interface in the engine. This depends on the saved query in the filter. Therefore it is not possible to specify a generic result format, i.e., if the resource type of the filter is Task the result will correspond to the Task interface in the engine. |  -  |
| **400** |  The extending query was invalid. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **403** |  The authenticated user is unauthorized to read this filter. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **404** |  Filter with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexecutefiltersingleresult"></a>
# **PostExecuteFilterSingleResult**
> Object PostExecuteFilterSingleResult (string id, Object body = null)

Execute Filter Single Result (POST)

Executes the saved query of the filter by id and returns the single result. This method is slightly more powerful then the [Get Execute Filter Single Result](https://docs.camunda.org/manual/7.16/reference/rest/filter/get-execute-single-result/) method because it allows to extend the saved query of the filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class PostExecuteFilterSingleResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var id = id_example;  // string | The id of the filter to execute.
            var body = {"assignee":"jonny1","taskDefinitionKey":"aTaskKey"};  // Object | A JSON object which corresponds to the type of the saved query of the filter, i.e., if the resource type of the filter is Task the body should form a valid task query corresponding to the Task resource. (optional) 

            try
            {
                // Execute Filter Single Result (POST)
                Object result = apiInstance.PostExecuteFilterSingleResult(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.PostExecuteFilterSingleResult: " + e.Message );
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
 **id** | **string**| The id of the filter to execute. | 
 **body** | **Object**| A JSON object which corresponds to the type of the saved query of the filter, i.e., if the resource type of the filter is Task the body should form a valid task query corresponding to the Task resource. | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. A JSON object corresponding to the corresponding entity interface in the engine. This depends on the saved query in the filter. Therefore it is not possible specify a generic result format, i.e., if the resource type of the filter is Task the result will correspond to the Task interface in the engine. |  -  |
| **204** | Request successful, but the result was empty. This method returns no content. |  -  |
| **400** |  The executed filter returned more than one single result or the extending query was invalid. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **403** |  The authenticated user is unauthorized to read this filter. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **404** |  Filter with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefilter"></a>
# **UpdateFilter**
> void UpdateFilter (string id, CreateFilterDto createFilterDto = null)

Update Filter

Updates an existing filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class UpdateFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new FilterApi(config);
            var id = id_example;  // string | The id of the filter to be updated.
            var createFilterDto = new CreateFilterDto(); // CreateFilterDto |  (optional) 

            try
            {
                // Update Filter
                apiInstance.UpdateFilter(id, createFilterDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilterApi.UpdateFilter: " + e.Message );
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
 **id** | **string**| The id of the filter to be updated. | 
 **createFilterDto** | [**CreateFilterDto**](CreateFilterDto.md)|  | [optional] 

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
| **400** |  Filter was invalid. See [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **403** |  The authenticated user is unauthorized to update this filter. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |
| **404** |  Filter cannot be found. See the [Introduction](https://docs.camunda.org/manual/7.16/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

