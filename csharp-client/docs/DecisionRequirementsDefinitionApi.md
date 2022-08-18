# Camunda.OpenApi.Client.Api.DecisionRequirementsDefinitionApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDecisionRequirementsDefinitionById**](DecisionRequirementsDefinitionApi.md#getdecisionrequirementsdefinitionbyid) | **GET** /decision-requirements-definition/{id} | Get Decision Requirements Definition by ID
[**GetDecisionRequirementsDefinitionByKey**](DecisionRequirementsDefinitionApi.md#getdecisionrequirementsdefinitionbykey) | **GET** /decision-requirements-definition/key/{key} | Get Decision Requirements Definition by Key
[**GetDecisionRequirementsDefinitionByKeyAndTenantId**](DecisionRequirementsDefinitionApi.md#getdecisionrequirementsdefinitionbykeyandtenantid) | **GET** /decision-requirements-definition/key/{key}/tenant-id/{tenant-id} | Get Decision Requirements Definition by Key and Tenant ID
[**GetDecisionRequirementsDefinitionDiagramById**](DecisionRequirementsDefinitionApi.md#getdecisionrequirementsdefinitiondiagrambyid) | **GET** /decision-requirements-definition/{id}/diagram | Get Decision Requirements Diagram by ID
[**GetDecisionRequirementsDefinitionDiagramByKey**](DecisionRequirementsDefinitionApi.md#getdecisionrequirementsdefinitiondiagrambykey) | **GET** /decision-requirements-definition/key/{key}/diagram | Get Decision Requirements Diagram by Key
[**GetDecisionRequirementsDefinitionDiagramByKeyAndTenantId**](DecisionRequirementsDefinitionApi.md#getdecisionrequirementsdefinitiondiagrambykeyandtenantid) | **GET** /decision-requirements-definition/key/{key}/tenant-id/{tenant-id}/diagram | Get Decision Requirements Diagram by Key and Tenant ID
[**GetDecisionRequirementsDefinitionDmnXmlById**](DecisionRequirementsDefinitionApi.md#getdecisionrequirementsdefinitiondmnxmlbyid) | **GET** /decision-requirements-definition/{id}/xml | Get DMN XML by ID
[**GetDecisionRequirementsDefinitionDmnXmlByKey**](DecisionRequirementsDefinitionApi.md#getdecisionrequirementsdefinitiondmnxmlbykey) | **GET** /decision-requirements-definition/key/{key}/xml | Get DMN XML by Key
[**GetDecisionRequirementsDefinitionDmnXmlByKeyAndTenantId**](DecisionRequirementsDefinitionApi.md#getdecisionrequirementsdefinitiondmnxmlbykeyandtenantid) | **GET** /decision-requirements-definition/key/{key}/tenant-id/{tenant-id}/xml | Get DMN XML by Key and Tenant ID
[**GetDecisionRequirementsDefinitions**](DecisionRequirementsDefinitionApi.md#getdecisionrequirementsdefinitions) | **GET** /decision-requirements-definition | Get Decision Requirements Definitions
[**GetDecisionRequirementsDefinitionsCount**](DecisionRequirementsDefinitionApi.md#getdecisionrequirementsdefinitionscount) | **GET** /decision-requirements-definition/count | Get Decision Requirements Definition Count


<a name="getdecisionrequirementsdefinitionbyid"></a>
# **GetDecisionRequirementsDefinitionById**
> DecisionRequirementsDefinitionDto GetDecisionRequirementsDefinitionById (string id)

Get Decision Requirements Definition by ID

Retrieves a decision requirements definition according to the `DecisionRequirementsDefinition` interface in the engine.

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
    public class GetDecisionRequirementsDefinitionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the decision requirements definition to be retrieved.

            try
            {
                // Get Decision Requirements Definition by ID
                DecisionRequirementsDefinitionDto result = apiInstance.GetDecisionRequirementsDefinitionById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionRequirementsDefinitionApi.GetDecisionRequirementsDefinitionById: " + e.Message );
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
 **id** | **string**| The id of the decision requirements definition to be retrieved. | 

### Return type

[**DecisionRequirementsDefinitionDto**](DecisionRequirementsDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision requirements definition with given id or key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisionrequirementsdefinitionbykey"></a>
# **GetDecisionRequirementsDefinitionByKey**
> DecisionRequirementsDefinitionDto GetDecisionRequirementsDefinitionByKey (string key)

Get Decision Requirements Definition by Key

Retrieves a decision requirements definition according to the `DecisionRequirementsDefinition` interface in the engine.  Returns the latest version of the decision requirements definition  which belongs to no tenant.

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
    public class GetDecisionRequirementsDefinitionByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision requirements definition (the latest version thereof) to be retrieved.

            try
            {
                // Get Decision Requirements Definition by Key
                DecisionRequirementsDefinitionDto result = apiInstance.GetDecisionRequirementsDefinitionByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionRequirementsDefinitionApi.GetDecisionRequirementsDefinitionByKey: " + e.Message );
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
 **key** | **string**| The key of the decision requirements definition (the latest version thereof) to be retrieved. | 

### Return type

[**DecisionRequirementsDefinitionDto**](DecisionRequirementsDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision requirements definition with given id or key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisionrequirementsdefinitionbykeyandtenantid"></a>
# **GetDecisionRequirementsDefinitionByKeyAndTenantId**
> DecisionRequirementsDefinitionDto GetDecisionRequirementsDefinitionByKeyAndTenantId (string key, string tenantId)

Get Decision Requirements Definition by Key and Tenant ID

Retrieves a decision requirements definition according to the `DecisionRequirementsDefinition` interface in the engine. Returns the latest version of the decision requirements definition  for a tenant.

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
    public class GetDecisionRequirementsDefinitionByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision requirements definition (the latest version thereof) to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant to which the decision requirements definition belongs to.

            try
            {
                // Get Decision Requirements Definition by Key and Tenant ID
                DecisionRequirementsDefinitionDto result = apiInstance.GetDecisionRequirementsDefinitionByKeyAndTenantId(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionRequirementsDefinitionApi.GetDecisionRequirementsDefinitionByKeyAndTenantId: " + e.Message );
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
 **key** | **string**| The key of the decision requirements definition (the latest version thereof) to be retrieved. | 
 **tenantId** | **string**| The id of the tenant to which the decision requirements definition belongs to. | 

### Return type

[**DecisionRequirementsDefinitionDto**](DecisionRequirementsDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision requirements definition with given id or key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisionrequirementsdefinitiondiagrambyid"></a>
# **GetDecisionRequirementsDefinitionDiagramById**
> FileParameter GetDecisionRequirementsDefinitionDiagramById (string id)

Get Decision Requirements Diagram by ID

Retrieves the diagram of a decision requirements definition.

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
    public class GetDecisionRequirementsDefinitionDiagramByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the decision requirements definition.

            try
            {
                // Get Decision Requirements Diagram by ID
                FileParameter result = apiInstance.GetDecisionRequirementsDefinitionDiagramById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionRequirementsDefinitionApi.GetDecisionRequirementsDefinitionDiagramById: " + e.Message );
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
 **id** | **string**| The id of the decision requirements definition. | 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/_*, application/octet-stream, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The image diagram of the decision requirements definition. |  -  |
| **204** | The decision requirements definition doesn&#39;t have an associated diagram. This method returns no content. |  -  |
| **404** | Decision requirements definition with given id or key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisionrequirementsdefinitiondiagrambykey"></a>
# **GetDecisionRequirementsDefinitionDiagramByKey**
> FileParameter GetDecisionRequirementsDefinitionDiagramByKey (string key)

Get Decision Requirements Diagram by Key

Retrieves the diagram of a decision requirements definition. Returns the diagram for the latest version of the decision requirements  definition which belongs to no tenant.

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
    public class GetDecisionRequirementsDefinitionDiagramByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision requirements definition (the latest version thereof) to be retrieved.

            try
            {
                // Get Decision Requirements Diagram by Key
                FileParameter result = apiInstance.GetDecisionRequirementsDefinitionDiagramByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionRequirementsDefinitionApi.GetDecisionRequirementsDefinitionDiagramByKey: " + e.Message );
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
 **key** | **string**| The key of the decision requirements definition (the latest version thereof) to be retrieved. | 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/_*, application/octet-stream, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The image diagram of the decision requirements definition. |  -  |
| **204** | The decision requirements definition doesn&#39;t have an associated diagram. This method returns no content. |  -  |
| **404** | Decision requirements definition with given id or key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisionrequirementsdefinitiondiagrambykeyandtenantid"></a>
# **GetDecisionRequirementsDefinitionDiagramByKeyAndTenantId**
> FileParameter GetDecisionRequirementsDefinitionDiagramByKeyAndTenantId (string key, string tenantId)

Get Decision Requirements Diagram by Key and Tenant ID

Retrieves the diagram of a decision requirements definition. Returns the diagram of the latest version of the decision requirements  definition for a tenant.

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
    public class GetDecisionRequirementsDefinitionDiagramByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision requirements definition (the latest version thereof) to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant to which the decision requirements definition belongs to.

            try
            {
                // Get Decision Requirements Diagram by Key and Tenant ID
                FileParameter result = apiInstance.GetDecisionRequirementsDefinitionDiagramByKeyAndTenantId(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionRequirementsDefinitionApi.GetDecisionRequirementsDefinitionDiagramByKeyAndTenantId: " + e.Message );
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
 **key** | **string**| The key of the decision requirements definition (the latest version thereof) to be retrieved. | 
 **tenantId** | **string**| The id of the tenant to which the decision requirements definition belongs to. | 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/_*, application/octet-stream, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The image diagram of the decision requirements definition. |  -  |
| **204** | The decision requirements definition doesn&#39;t have an associated diagram. This method returns no content. |  -  |
| **404** | Decision requirements definition with given id or key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisionrequirementsdefinitiondmnxmlbyid"></a>
# **GetDecisionRequirementsDefinitionDmnXmlById**
> DecisionRequirementsDefinitionXmlDto GetDecisionRequirementsDefinitionDmnXmlById (string id)

Get DMN XML by ID

Retrieves the DMN XML of a decision requirements definition.

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
    public class GetDecisionRequirementsDefinitionDmnXmlByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the decision requirements definition.

            try
            {
                // Get DMN XML by ID
                DecisionRequirementsDefinitionXmlDto result = apiInstance.GetDecisionRequirementsDefinitionDmnXmlById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionRequirementsDefinitionApi.GetDecisionRequirementsDefinitionDmnXmlById: " + e.Message );
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
 **id** | **string**| The id of the decision requirements definition. | 

### Return type

[**DecisionRequirementsDefinitionXmlDto**](DecisionRequirementsDefinitionXmlDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision requirements definition with given id or key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisionrequirementsdefinitiondmnxmlbykey"></a>
# **GetDecisionRequirementsDefinitionDmnXmlByKey**
> DecisionRequirementsDefinitionXmlDto GetDecisionRequirementsDefinitionDmnXmlByKey (string key)

Get DMN XML by Key

Retrieves the DMN XML of a decision requirements definition. Returns the XML for the latest version of the decision requirements  definition which belongs to no tenant.

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
    public class GetDecisionRequirementsDefinitionDmnXmlByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision requirements definition (the latest version thereof) to be retrieved.

            try
            {
                // Get DMN XML by Key
                DecisionRequirementsDefinitionXmlDto result = apiInstance.GetDecisionRequirementsDefinitionDmnXmlByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionRequirementsDefinitionApi.GetDecisionRequirementsDefinitionDmnXmlByKey: " + e.Message );
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
 **key** | **string**| The key of the decision requirements definition (the latest version thereof) to be retrieved. | 

### Return type

[**DecisionRequirementsDefinitionXmlDto**](DecisionRequirementsDefinitionXmlDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** |  Decision requirements definition with given id or key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisionrequirementsdefinitiondmnxmlbykeyandtenantid"></a>
# **GetDecisionRequirementsDefinitionDmnXmlByKeyAndTenantId**
> DecisionRequirementsDefinitionXmlDto GetDecisionRequirementsDefinitionDmnXmlByKeyAndTenantId (string key, string tenantId)

Get DMN XML by Key and Tenant ID

Retrieves the DMN XML of a decision requirements definition. Returns the XML of the latest version of the decision requirements  definition for a tenant.

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
    public class GetDecisionRequirementsDefinitionDmnXmlByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision requirements definition (the latest version thereof) to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant to which the decision requirements definition belongs to.

            try
            {
                // Get DMN XML by Key and Tenant ID
                DecisionRequirementsDefinitionXmlDto result = apiInstance.GetDecisionRequirementsDefinitionDmnXmlByKeyAndTenantId(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionRequirementsDefinitionApi.GetDecisionRequirementsDefinitionDmnXmlByKeyAndTenantId: " + e.Message );
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
 **key** | **string**| The key of the decision requirements definition (the latest version thereof) to be retrieved. | 
 **tenantId** | **string**| The id of the tenant to which the decision requirements definition belongs to. | 

### Return type

[**DecisionRequirementsDefinitionXmlDto**](DecisionRequirementsDefinitionXmlDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** |  Decision requirements definition with given id or key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisionrequirementsdefinitions"></a>
# **GetDecisionRequirementsDefinitions**
> List&lt;DecisionRequirementsDefinitionDto&gt; GetDecisionRequirementsDefinitions (string decisionRequirementsDefinitionId = null, string decisionRequirementsDefinitionIdIn = null, string name = null, string nameLike = null, string deploymentId = null, string key = null, string keyLike = null, string category = null, string categoryLike = null, int? version = null, bool? latestVersion = null, string resourceName = null, string resourceNameLike = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeDecisionRequirementsDefinitionsWithoutTenantId = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get Decision Requirements Definitions

Queries for decision requirements definitions that fulfill given parameters. Parameters may be the properties of decision requirements definitions, such as the name, key or version.  The size of the result set can be retrieved by using the [Get Decision Requirements Definition Count](https://docs.camunda.org/manual/7.17/reference/rest/decision-requirements-definition/get-query-count/) method.

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
    public class GetDecisionRequirementsDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var decisionRequirementsDefinitionId = decisionRequirementsDefinitionId_example;  // string | Filter by decision requirements definition id. (optional) 
            var decisionRequirementsDefinitionIdIn = decisionRequirementsDefinitionIdIn_example;  // string | Filter by decision requirements definition ids. (optional) 
            var name = name_example;  // string | Filter by decision requirements definition name. (optional) 
            var nameLike = nameLike_example;  // string | Filter by decision requirements definition names that the parameter is a substring of. (optional) 
            var deploymentId = deploymentId_example;  // string | Filter by the id of the deployment a decision requirement definition belongs to. (optional) 
            var key = key_example;  // string | Filter by decision requirements definition key, i.e., the id in the DMN 1.3 XML. Exact match. (optional) 
            var keyLike = keyLike_example;  // string | Filter by decision requirements definition keys that the parameter is a substring of. (optional) 
            var category = category_example;  // string | Filter by decision requirements definition category. Exact match. (optional) 
            var categoryLike = categoryLike_example;  // string | Filter by decision requirements definition categories that the parameter is a substring of. (optional) 
            var version = 56;  // int? | Filter by decision requirements definition version. (optional) 
            var latestVersion = true;  // bool? | Only include those decision requirements definitions that are latest versions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var resourceName = resourceName_example;  // string | Filter by the name of the decision requirements definition resource. Exact match. (optional) 
            var resourceNameLike = resourceNameLike_example;  // string | Filter by names of those decision requirements definition resources that the parameter is a substring of. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A decision requirements definition must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include decision requirements definitions which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var includeDecisionRequirementsDefinitionsWithoutTenantId = true;  // bool? | Include decision requirements definitions which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get Decision Requirements Definitions
                List<DecisionRequirementsDefinitionDto> result = apiInstance.GetDecisionRequirementsDefinitions(decisionRequirementsDefinitionId, decisionRequirementsDefinitionIdIn, name, nameLike, deploymentId, key, keyLike, category, categoryLike, version, latestVersion, resourceName, resourceNameLike, tenantIdIn, withoutTenantId, includeDecisionRequirementsDefinitionsWithoutTenantId, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionRequirementsDefinitionApi.GetDecisionRequirementsDefinitions: " + e.Message );
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
 **decisionRequirementsDefinitionId** | **string**| Filter by decision requirements definition id. | [optional] 
 **decisionRequirementsDefinitionIdIn** | **string**| Filter by decision requirements definition ids. | [optional] 
 **name** | **string**| Filter by decision requirements definition name. | [optional] 
 **nameLike** | **string**| Filter by decision requirements definition names that the parameter is a substring of. | [optional] 
 **deploymentId** | **string**| Filter by the id of the deployment a decision requirement definition belongs to. | [optional] 
 **key** | **string**| Filter by decision requirements definition key, i.e., the id in the DMN 1.3 XML. Exact match. | [optional] 
 **keyLike** | **string**| Filter by decision requirements definition keys that the parameter is a substring of. | [optional] 
 **category** | **string**| Filter by decision requirements definition category. Exact match. | [optional] 
 **categoryLike** | **string**| Filter by decision requirements definition categories that the parameter is a substring of. | [optional] 
 **version** | **int?**| Filter by decision requirements definition version. | [optional] 
 **latestVersion** | **bool?**| Only include those decision requirements definitions that are latest versions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **resourceName** | **string**| Filter by the name of the decision requirements definition resource. Exact match. | [optional] 
 **resourceNameLike** | **string**| Filter by names of those decision requirements definition resources that the parameter is a substring of. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A decision requirements definition must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include decision requirements definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeDecisionRequirementsDefinitionsWithoutTenantId** | **bool?**| Include decision requirements definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **sortBy** | **string**| Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional] 
 **sortOrder** | **string**| Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional] 
 **firstResult** | **int?**| Pagination of results. Specifies the index of the first result to return. | [optional] 
 **maxResults** | **int?**| Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional] 

### Return type

[**List&lt;DecisionRequirementsDefinitionDto&gt;**](DecisionRequirementsDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisionrequirementsdefinitionscount"></a>
# **GetDecisionRequirementsDefinitionsCount**
> CountResultDto GetDecisionRequirementsDefinitionsCount (string decisionRequirementsDefinitionId = null, string decisionRequirementsDefinitionIdIn = null, string name = null, string nameLike = null, string deploymentId = null, string key = null, string keyLike = null, string category = null, string categoryLike = null, int? version = null, bool? latestVersion = null, string resourceName = null, string resourceNameLike = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeDecisionRequirementsDefinitionsWithoutTenantId = null)

Get Decision Requirements Definition Count

Requests the number of decision requirements definitions that fulfill the query criteria. Takes the same filtering parameters as the [Get Decision Requirements Definitions](https://docs.camunda.org/manual/7.17/reference/rest/decision-requirements-definition/get-query/) method.

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
    public class GetDecisionRequirementsDefinitionsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var decisionRequirementsDefinitionId = decisionRequirementsDefinitionId_example;  // string | Filter by decision requirements definition id. (optional) 
            var decisionRequirementsDefinitionIdIn = decisionRequirementsDefinitionIdIn_example;  // string | Filter by decision requirements definition ids. (optional) 
            var name = name_example;  // string | Filter by decision requirements definition name. (optional) 
            var nameLike = nameLike_example;  // string | Filter by decision requirements definition names that the parameter is a substring of. (optional) 
            var deploymentId = deploymentId_example;  // string | Filter by the id of the deployment a decision requirement definition belongs to. (optional) 
            var key = key_example;  // string | Filter by decision requirements definition key, i.e., the id in the DMN 1.3 XML. Exact match. (optional) 
            var keyLike = keyLike_example;  // string | Filter by decision requirements definition keys that the parameter is a substring of. (optional) 
            var category = category_example;  // string | Filter by decision requirements definition category. Exact match. (optional) 
            var categoryLike = categoryLike_example;  // string | Filter by decision requirements definition categories that the parameter is a substring of. (optional) 
            var version = 56;  // int? | Filter by decision requirements definition version. (optional) 
            var latestVersion = true;  // bool? | Only include those decision requirements definitions that are latest versions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var resourceName = resourceName_example;  // string | Filter by the name of the decision requirements definition resource. Exact match. (optional) 
            var resourceNameLike = resourceNameLike_example;  // string | Filter by names of those decision requirements definition resources that the parameter is a substring of. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of tenant ids. A decision requirements definition must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include decision requirements definitions which belong to no tenant. Value may only be `true`, as `false` is the default behavior. (optional) 
            var includeDecisionRequirementsDefinitionsWithoutTenantId = true;  // bool? | Include decision requirements definitions which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get Decision Requirements Definition Count
                CountResultDto result = apiInstance.GetDecisionRequirementsDefinitionsCount(decisionRequirementsDefinitionId, decisionRequirementsDefinitionIdIn, name, nameLike, deploymentId, key, keyLike, category, categoryLike, version, latestVersion, resourceName, resourceNameLike, tenantIdIn, withoutTenantId, includeDecisionRequirementsDefinitionsWithoutTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionRequirementsDefinitionApi.GetDecisionRequirementsDefinitionsCount: " + e.Message );
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
 **decisionRequirementsDefinitionId** | **string**| Filter by decision requirements definition id. | [optional] 
 **decisionRequirementsDefinitionIdIn** | **string**| Filter by decision requirements definition ids. | [optional] 
 **name** | **string**| Filter by decision requirements definition name. | [optional] 
 **nameLike** | **string**| Filter by decision requirements definition names that the parameter is a substring of. | [optional] 
 **deploymentId** | **string**| Filter by the id of the deployment a decision requirement definition belongs to. | [optional] 
 **key** | **string**| Filter by decision requirements definition key, i.e., the id in the DMN 1.3 XML. Exact match. | [optional] 
 **keyLike** | **string**| Filter by decision requirements definition keys that the parameter is a substring of. | [optional] 
 **category** | **string**| Filter by decision requirements definition category. Exact match. | [optional] 
 **categoryLike** | **string**| Filter by decision requirements definition categories that the parameter is a substring of. | [optional] 
 **version** | **int?**| Filter by decision requirements definition version. | [optional] 
 **latestVersion** | **bool?**| Only include those decision requirements definitions that are latest versions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **resourceName** | **string**| Filter by the name of the decision requirements definition resource. Exact match. | [optional] 
 **resourceNameLike** | **string**| Filter by names of those decision requirements definition resources that the parameter is a substring of. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of tenant ids. A decision requirements definition must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include decision requirements definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeDecisionRequirementsDefinitionsWithoutTenantId** | **bool?**| Include decision requirements definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 

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
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

