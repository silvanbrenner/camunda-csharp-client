# CamundaClient.Api.DeploymentApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDeployment**](DeploymentApi.md#createdeployment) | **POST** /deployment/create | 
[**DeleteDeployment**](DeploymentApi.md#deletedeployment) | **DELETE** /deployment/{id} | 
[**GetDeployment**](DeploymentApi.md#getdeployment) | **GET** /deployment/{id} | 
[**GetDeploymentResource**](DeploymentApi.md#getdeploymentresource) | **GET** /deployment/{id}/resources/{resourceId} | 
[**GetDeploymentResourceData**](DeploymentApi.md#getdeploymentresourcedata) | **GET** /deployment/{id}/resources/{resourceId}/data | 
[**GetDeploymentResources**](DeploymentApi.md#getdeploymentresources) | **GET** /deployment/{id}/resources | 
[**GetDeployments**](DeploymentApi.md#getdeployments) | **GET** /deployment | 
[**GetDeploymentsCount**](DeploymentApi.md#getdeploymentscount) | **GET** /deployment/count | 
[**Redeploy**](DeploymentApi.md#redeploy) | **POST** /deployment/{id}/redeploy | 


<a name="createdeployment"></a>
# **CreateDeployment**
> DeploymentWithDefinitionsDto CreateDeployment (string tenantId = null, string deploymentSource = null, bool? deployChangedOnly = null, bool? enableDuplicateFiltering = null, string deploymentName = null, System.IO.Stream data = null)



Creates a deployment.  **Security Consideration**  Deployments can contain custom code in form of scripts or EL expressions to customize process behavior. This may be abused for remote execution of arbitrary code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class CreateDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new DeploymentApi(config);
            var tenantId = tenantId_example;  // string | The tenant id for the deployment to be created. (optional) 
            var deploymentSource = deploymentSource_example;  // string | The source for the deployment to be created. (optional) 
            var deployChangedOnly = true;  // bool? | A flag indicating whether the process engine should perform duplicate checking on a per-resource basis. If set to true, only those resources that have actually changed are deployed. Checks are made against resources included previous deployments of the same name and only against the latest versions of those resources. If set to true, the option enable-duplicate-filtering is overridden and set to true. (optional)  (default to false)
            var enableDuplicateFiltering = true;  // bool? | A flag indicating whether the process engine should perform duplicate checking for the deployment or not. This allows you to check if a deployment with the same name and the same resouces already exists and if true, not create a new deployment but instead return the existing deployment. The default value is false. (optional)  (default to false)
            var deploymentName = deploymentName_example;  // string | The name for the deployment to be created. (optional) 
            var data = BINARY_DATA_HERE;  // System.IO.Stream | The binary data to create the deployment resource. It is possible to have more than one form part with different form part names for the binary data to create a deployment. (optional) 

            try
            {
                DeploymentWithDefinitionsDto result = apiInstance.CreateDeployment(tenantId, deploymentSource, deployChangedOnly, enableDuplicateFiltering, deploymentName, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentApi.CreateDeployment: " + e.Message );
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
 **tenantId** | **string**| The tenant id for the deployment to be created. | [optional] 
 **deploymentSource** | **string**| The source for the deployment to be created. | [optional] 
 **deployChangedOnly** | **bool?**| A flag indicating whether the process engine should perform duplicate checking on a per-resource basis. If set to true, only those resources that have actually changed are deployed. Checks are made against resources included previous deployments of the same name and only against the latest versions of those resources. If set to true, the option enable-duplicate-filtering is overridden and set to true. | [optional] [default to false]
 **enableDuplicateFiltering** | **bool?**| A flag indicating whether the process engine should perform duplicate checking for the deployment or not. This allows you to check if a deployment with the same name and the same resouces already exists and if true, not create a new deployment but instead return the existing deployment. The default value is false. | [optional] [default to false]
 **deploymentName** | **string**| The name for the deployment to be created. | [optional] 
 **data** | **System.IO.Stream****System.IO.Stream**| The binary data to create the deployment resource. It is possible to have more than one form part with different form part names for the binary data to create a deployment. | [optional] 

### Return type

[**DeploymentWithDefinitionsDto**](DeploymentWithDefinitionsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad Request. In case one of the bpmn resources cannot be parsed.  See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#parse-exceptions) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedeployment"></a>
# **DeleteDeployment**
> void DeleteDeployment (string id, bool? cascade = null, bool? skipCustomListeners = null, bool? skipIoMappings = null)



Deletes a deployment by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class DeleteDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new DeploymentApi(config);
            var id = id_example;  // string | The id of the deployment to be deleted.
            var cascade = true;  // bool? | `true`, if all process instances, historic process instances and jobs for this deployment should be deleted. (optional)  (default to false)
            var skipCustomListeners = true;  // bool? | `true`, if only the built-in ExecutionListeners should be notified with the end event. (optional)  (default to false)
            var skipIoMappings = true;  // bool? | `true`, if all input/output mappings should not be invoked. (optional)  (default to false)

            try
            {
                apiInstance.DeleteDeployment(id, cascade, skipCustomListeners, skipIoMappings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentApi.DeleteDeployment: " + e.Message );
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
 **id** | **string**| The id of the deployment to be deleted. | 
 **cascade** | **bool?**| &#x60;true&#x60;, if all process instances, historic process instances and jobs for this deployment should be deleted. | [optional] [default to false]
 **skipCustomListeners** | **bool?**| &#x60;true&#x60;, if only the built-in ExecutionListeners should be notified with the end event. | [optional] [default to false]
 **skipIoMappings** | **bool?**| &#x60;true&#x60;, if all input/output mappings should not be invoked. | [optional] [default to false]

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
| **404** | A Deployment with the provided id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeployment"></a>
# **GetDeployment**
> List&lt;DeploymentDto&gt; GetDeployment (string id)



Retrieves a deployment by id, according to the `Deployment` interface of the engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new DeploymentApi(config);
            var id = id_example;  // string | The id of the deployment.

            try
            {
                List<DeploymentDto> result = apiInstance.GetDeployment(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeployment: " + e.Message );
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
 **id** | **string**| The id of the deployment. | 

### Return type

[**List&lt;DeploymentDto&gt;**](DeploymentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Deployment with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeploymentresource"></a>
# **GetDeploymentResource**
> DeploymentResourceDto GetDeploymentResource (string id, string resourceId)



Retrieves a deployment resource by resource id for the given deployment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetDeploymentResourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new DeploymentApi(config);
            var id = id_example;  // string | The id of the deployment
            var resourceId = resourceId_example;  // string | The id of the deployment resource

            try
            {
                DeploymentResourceDto result = apiInstance.GetDeploymentResource(id, resourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeploymentResource: " + e.Message );
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
 **id** | **string**| The id of the deployment | 
 **resourceId** | **string**| The id of the deployment resource | 

### Return type

[**DeploymentResourceDto**](DeploymentResourceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Deployment Resource with given resource id or deployment id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeploymentresourcedata"></a>
# **GetDeploymentResourceData**
> System.IO.Stream GetDeploymentResourceData (string id, string resourceId)



Retrieves the binary content of a deployment resource for the given deployment by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetDeploymentResourceDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new DeploymentApi(config);
            var id = id_example;  // string | The id of the deployment.
            var resourceId = resourceId_example;  // string | The id of the deployment resource.

            try
            {
                System.IO.Stream result = apiInstance.GetDeploymentResourceData(id, resourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeploymentResourceData: " + e.Message );
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
 **id** | **string**| The id of the deployment. | 
 **resourceId** | **string**| The id of the deployment resource. | 

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
| **200** | Request successful. The media type of the response depends on the filename. |  -  |
| **400** | Deployment Resource with given resource id or deployment id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeploymentresources"></a>
# **GetDeploymentResources**
> List&lt;DeploymentResourceDto&gt; GetDeploymentResources (string id)



Retrieves all deployment resources of a given deployment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetDeploymentResourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new DeploymentApi(config);
            var id = id_example;  // string | The id of the deployment to retrieve the deployment resources for.

            try
            {
                List<DeploymentResourceDto> result = apiInstance.GetDeploymentResources(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeploymentResources: " + e.Message );
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
 **id** | **string**| The id of the deployment to retrieve the deployment resources for. | 

### Return type

[**List&lt;DeploymentResourceDto&gt;**](DeploymentResourceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Deployment resources for the given deployment do not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeployments"></a>
# **GetDeployments**
> List&lt;DeploymentDto&gt; GetDeployments (string id = null, string name = null, string nameLike = null, string source = null, bool? withoutSource = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeDeploymentsWithoutTenantId = null, DateTime? after = null, DateTime? before = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)



Queries for deployments that fulfill given parameters. Parameters may be the properties of deployments, such as the id or name or a range of the deployment time. The size of the result set can be retrieved by using the [Get Deployment count](https://docs.camunda.org/manual/7.14/reference/rest/deployment/get-query-count/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetDeploymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new DeploymentApi(config);
            var id = id_example;  // string | Filter by deployment id (optional) 
            var name = name_example;  // string | Filter by the deployment name. Exact match. (optional) 
            var nameLike = nameLike_example;  // string | Filter by the deployment name that the parameter is a substring of. The parameter can include the wildcard `%` to express like-strategy such as: starts with (`%`name), ends with (name`%`) or contains (`%`name`%`). (optional) 
            var source = source_example;  // string | Filter by the deployment source. (optional) 
            var withoutSource = true;  // bool? | Filter by the deployment source whereby source is equal to `null`. (optional)  (default to false)
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A deployment must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include deployments which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var includeDeploymentsWithoutTenantId = true;  // bool? | Include deployments which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var after = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to all deployments after the given date. By [default](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to all deployments before the given date. By [default](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                List<DeploymentDto> result = apiInstance.GetDeployments(id, name, nameLike, source, withoutSource, tenantIdIn, withoutTenantId, includeDeploymentsWithoutTenantId, after, before, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeployments: " + e.Message );
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
 **id** | **string**| Filter by deployment id | [optional] 
 **name** | **string**| Filter by the deployment name. Exact match. | [optional] 
 **nameLike** | **string**| Filter by the deployment name that the parameter is a substring of. The parameter can include the wildcard &#x60;%&#x60; to express like-strategy such as: starts with (&#x60;%&#x60;name), ends with (name&#x60;%&#x60;) or contains (&#x60;%&#x60;name&#x60;%&#x60;). | [optional] 
 **source** | **string**| Filter by the deployment source. | [optional] 
 **withoutSource** | **bool?**| Filter by the deployment source whereby source is equal to &#x60;null&#x60;. | [optional] [default to false]
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A deployment must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include deployments which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **includeDeploymentsWithoutTenantId** | **bool?**| Include deployments which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **after** | **DateTime?**| Restricts to all deployments after the given date. By [default](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **before** | **DateTime?**| Restricts to all deployments before the given date. By [default](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;DeploymentDto&gt;**](DeploymentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;, or if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeploymentscount"></a>
# **GetDeploymentsCount**
> CountResultDto GetDeploymentsCount (string id = null, string name = null, string nameLike = null, string source = null, bool? withoutSource = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeDeploymentsWithoutTenantId = null, DateTime? after = null, DateTime? before = null)



Queries for the number of deployments that fulfill given parameters. Takes the same parameters as the [Get Deployments](https://docs.camunda.org/manual/7.14/reference/rest/deployment/get-query/) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetDeploymentsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new DeploymentApi(config);
            var id = id_example;  // string | Filter by deployment id (optional) 
            var name = name_example;  // string | Filter by the deployment name. Exact match. (optional) 
            var nameLike = nameLike_example;  // string | Filter by the deployment name that the parameter is a substring of. The parameter can include the wildcard `%` to express like-strategy such as: starts with (`%`name), ends with (name`%`) or contains (`%`name`%`). (optional) 
            var source = source_example;  // string | Filter by the deployment source. (optional) 
            var withoutSource = true;  // bool? | Filter by the deployment source whereby source is equal to `null`. (optional)  (default to false)
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A deployment must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include deployments which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var includeDeploymentsWithoutTenantId = true;  // bool? | Include deployments which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional)  (default to false)
            var after = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to all deployments after the given date. By [default](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime? | Restricts to all deployments before the given date. By [default](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 

            try
            {
                CountResultDto result = apiInstance.GetDeploymentsCount(id, name, nameLike, source, withoutSource, tenantIdIn, withoutTenantId, includeDeploymentsWithoutTenantId, after, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeploymentsCount: " + e.Message );
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
 **id** | **string**| Filter by deployment id | [optional] 
 **name** | **string**| Filter by the deployment name. Exact match. | [optional] 
 **nameLike** | **string**| Filter by the deployment name that the parameter is a substring of. The parameter can include the wildcard &#x60;%&#x60; to express like-strategy such as: starts with (&#x60;%&#x60;name), ends with (name&#x60;%&#x60;) or contains (&#x60;%&#x60;name&#x60;%&#x60;). | [optional] 
 **source** | **string**| Filter by the deployment source. | [optional] 
 **withoutSource** | **bool?**| Filter by the deployment source whereby source is equal to &#x60;null&#x60;. | [optional] [default to false]
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A deployment must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include deployments which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **includeDeploymentsWithoutTenantId** | **bool?**| Include deployments which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] [default to false]
 **after** | **DateTime?**| Restricts to all deployments after the given date. By [default](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 
 **before** | **DateTime?**| Restricts to all deployments before the given date. By [default](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid, for example, if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redeploy"></a>
# **Redeploy**
> DeploymentWithDefinitionsDto Redeploy (string id, RedeploymentDto redeploymentDto = null)



Re-deploys an existing deployment.  The deployment resources to re-deploy can be restricted by using the properties `resourceIds` or `resourceNames`. If no deployment resources to re-deploy are passed then all existing resources of the given deployment are re-deployed.  **Warning**: Deployments can contain custom code in form of scripts or EL expressions to customize process behavior. This may be abused for remote execution of arbitrary code. See the section on [security considerations for custom code](https://docs.camunda.org/manual/7.14/user-guide/process-engine/securing-custom-code/) in the user guide for details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class RedeployExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new DeploymentApi(config);
            var id = id_example;  // string | The id of the deployment to re-deploy.
            var redeploymentDto = new RedeploymentDto(); // RedeploymentDto |  (optional) 

            try
            {
                DeploymentWithDefinitionsDto result = apiInstance.Redeploy(id, redeploymentDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentApi.Redeploy: " + e.Message );
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
 **id** | **string**| The id of the deployment to re-deploy. | 
 **redeploymentDto** | [**RedeploymentDto**](RedeploymentDto.md)|  | [optional] 

### Return type

[**DeploymentWithDefinitionsDto**](DeploymentWithDefinitionsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Deployment or a deployment resource for the given deployment does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

