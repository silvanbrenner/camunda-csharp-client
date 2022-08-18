# Camunda.OpenApi.Client.Api.DecisionDefinitionApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EvaluateDecisionById**](DecisionDefinitionApi.md#evaluatedecisionbyid) | **POST** /decision-definition/{id}/evaluate | Evaluate By Id
[**EvaluateDecisionByKey**](DecisionDefinitionApi.md#evaluatedecisionbykey) | **POST** /decision-definition/key/{key}/evaluate | Evaluate By Key
[**EvaluateDecisionByKeyAndTenant**](DecisionDefinitionApi.md#evaluatedecisionbykeyandtenant) | **POST** /decision-definition/key/{key}/tenant-id/{tenant-id}/evaluate | Evaluate By Key And Tenant
[**GetDecisionDefinitionById**](DecisionDefinitionApi.md#getdecisiondefinitionbyid) | **GET** /decision-definition/{id} | Get Decision Definition By Id
[**GetDecisionDefinitionByKey**](DecisionDefinitionApi.md#getdecisiondefinitionbykey) | **GET** /decision-definition/key/{key} | Get Decision Definition By Key
[**GetDecisionDefinitionByKeyAndTenantId**](DecisionDefinitionApi.md#getdecisiondefinitionbykeyandtenantid) | **GET** /decision-definition/key/{key}/tenant-id/{tenant-id} | Get Decision Definition By Key And Tenant Id
[**GetDecisionDefinitionDiagram**](DecisionDefinitionApi.md#getdecisiondefinitiondiagram) | **GET** /decision-definition/{id}/diagram | Get Diagram
[**GetDecisionDefinitionDiagramByKey**](DecisionDefinitionApi.md#getdecisiondefinitiondiagrambykey) | **GET** /decision-definition/key/{key}/diagram | Get Diagram By Key
[**GetDecisionDefinitionDiagramByKeyAndTenant**](DecisionDefinitionApi.md#getdecisiondefinitiondiagrambykeyandtenant) | **GET** /decision-definition/key/{key}/tenant-id/{tenant-id}/diagram | Get Diagram By Key And Tenant
[**GetDecisionDefinitionDmnXmlById**](DecisionDefinitionApi.md#getdecisiondefinitiondmnxmlbyid) | **GET** /decision-definition/{id}/xml | Get XML By Id
[**GetDecisionDefinitionDmnXmlByKey**](DecisionDefinitionApi.md#getdecisiondefinitiondmnxmlbykey) | **GET** /decision-definition/key/{key}/xml | Get XML By Key
[**GetDecisionDefinitionDmnXmlByKeyAndTenant**](DecisionDefinitionApi.md#getdecisiondefinitiondmnxmlbykeyandtenant) | **GET** /decision-definition/key/{key}/tenant-id/{tenant-id}/xml | Get XML By Key and Tenant
[**GetDecisionDefinitions**](DecisionDefinitionApi.md#getdecisiondefinitions) | **GET** /decision-definition | Get List
[**GetDecisionDefinitionsCount**](DecisionDefinitionApi.md#getdecisiondefinitionscount) | **GET** /decision-definition/count | Get List Count
[**UpdateHistoryTimeToLiveByDecisionDefinitionId**](DecisionDefinitionApi.md#updatehistorytimetolivebydecisiondefinitionid) | **PUT** /decision-definition/{id}/history-time-to-live | Update History Time to Live
[**UpdateHistoryTimeToLiveByDecisionDefinitionKey**](DecisionDefinitionApi.md#updatehistorytimetolivebydecisiondefinitionkey) | **PUT** /decision-definition/key/{key}/history-time-to-live | Update History Time to Live By Key
[**UpdateHistoryTimeToLiveByDecisionDefinitionKeyAndTenant**](DecisionDefinitionApi.md#updatehistorytimetolivebydecisiondefinitionkeyandtenant) | **PUT** /decision-definition/key/{key}/tenant-id/{tenant-id}/history-time-to-live | Update History Time to Live By Key And Tenant


<a name="evaluatedecisionbyid"></a>
# **EvaluateDecisionById**
> List&lt;Dictionary&lt;string, VariableValueDto&gt;&gt; EvaluateDecisionById (string id, EvaluateDecisionDto evaluateDecisionDto = null)

Evaluate By Id

Evaluates a given decision and returns the result. The input values of the decision have to be supplied in the request body.

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
    public class EvaluateDecisionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the decision definition to be evaluated.
            var evaluateDecisionDto = new EvaluateDecisionDto(); // EvaluateDecisionDto |  (optional) 

            try
            {
                // Evaluate By Id
                List<Dictionary<string, VariableValueDto>> result = apiInstance.EvaluateDecisionById(id, evaluateDecisionDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.EvaluateDecisionById: " + e.Message );
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
 **id** | **string**| The id of the decision definition to be evaluated. | 
 **evaluateDecisionDto** | [**EvaluateDecisionDto**](EvaluateDecisionDto.md)|  | [optional] 

### Return type

**List<Dictionary<string, VariableValueDto>>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="evaluatedecisionbykey"></a>
# **EvaluateDecisionByKey**
> List&lt;Dictionary&lt;string, VariableValueDto&gt;&gt; EvaluateDecisionByKey (string key, EvaluateDecisionDto evaluateDecisionDto = null)

Evaluate By Key

Evaluates the latest version of the decision definition which belongs to no tenant. The input values of the decision have to be supplied in the request body.

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
    public class EvaluateDecisionByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision definition (the latest version thereof) to be evaluated.
            var evaluateDecisionDto = new EvaluateDecisionDto(); // EvaluateDecisionDto |  (optional) 

            try
            {
                // Evaluate By Key
                List<Dictionary<string, VariableValueDto>> result = apiInstance.EvaluateDecisionByKey(key, evaluateDecisionDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.EvaluateDecisionByKey: " + e.Message );
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
 **key** | **string**| The key of the decision definition (the latest version thereof) to be evaluated. | 
 **evaluateDecisionDto** | [**EvaluateDecisionDto**](EvaluateDecisionDto.md)|  | [optional] 

### Return type

**List<Dictionary<string, VariableValueDto>>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="evaluatedecisionbykeyandtenant"></a>
# **EvaluateDecisionByKeyAndTenant**
> List&lt;Dictionary&lt;string, VariableValueDto&gt;&gt; EvaluateDecisionByKeyAndTenant (string key, string tenantId, EvaluateDecisionDto evaluateDecisionDto = null)

Evaluate By Key And Tenant

Evaluates the latest version of the decision definition for tenant. The input values of the decision have to be supplied in the request body.

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
    public class EvaluateDecisionByKeyAndTenantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision definition (the latest version thereof) to be evaluated.
            var tenantId = tenantId_example;  // string | The id of the tenant the decision definition belongs to.
            var evaluateDecisionDto = new EvaluateDecisionDto(); // EvaluateDecisionDto |  (optional) 

            try
            {
                // Evaluate By Key And Tenant
                List<Dictionary<string, VariableValueDto>> result = apiInstance.EvaluateDecisionByKeyAndTenant(key, tenantId, evaluateDecisionDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.EvaluateDecisionByKeyAndTenant: " + e.Message );
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
 **key** | **string**| The key of the decision definition (the latest version thereof) to be evaluated. | 
 **tenantId** | **string**| The id of the tenant the decision definition belongs to. | 
 **evaluateDecisionDto** | [**EvaluateDecisionDto**](EvaluateDecisionDto.md)|  | [optional] 

### Return type

**List<Dictionary<string, VariableValueDto>>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisiondefinitionbyid"></a>
# **GetDecisionDefinitionById**
> DecisionDefinitionDto GetDecisionDefinitionById (string id)

Get Decision Definition By Id

Retrieves a decision definition by id, according to the `DecisionDefinition` interface in the engine.

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
    public class GetDecisionDefinitionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the decision definition to be retrieved.

            try
            {
                // Get Decision Definition By Id
                DecisionDefinitionDto result = apiInstance.GetDecisionDefinitionById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.GetDecisionDefinitionById: " + e.Message );
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
 **id** | **string**| The id of the decision definition to be retrieved. | 

### Return type

[**DecisionDefinitionDto**](DecisionDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisiondefinitionbykey"></a>
# **GetDecisionDefinitionByKey**
> DecisionDefinitionDto GetDecisionDefinitionByKey (string key)

Get Decision Definition By Key

Retrieves the latest version of the decision definition which belongs to no tenant.

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
    public class GetDecisionDefinitionByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision definition (the latest version thereof) to be retrieved.

            try
            {
                // Get Decision Definition By Key
                DecisionDefinitionDto result = apiInstance.GetDecisionDefinitionByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.GetDecisionDefinitionByKey: " + e.Message );
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
 **key** | **string**| The key of the decision definition (the latest version thereof) to be retrieved. | 

### Return type

[**DecisionDefinitionDto**](DecisionDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisiondefinitionbykeyandtenantid"></a>
# **GetDecisionDefinitionByKeyAndTenantId**
> DecisionDefinitionDto GetDecisionDefinitionByKeyAndTenantId (string key, string tenantId)

Get Decision Definition By Key And Tenant Id

Retrieves the latest version of the decision definition for tenant

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
    public class GetDecisionDefinitionByKeyAndTenantIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision definition (the latest version thereof) to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant the decision definition belongs to.

            try
            {
                // Get Decision Definition By Key And Tenant Id
                DecisionDefinitionDto result = apiInstance.GetDecisionDefinitionByKeyAndTenantId(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.GetDecisionDefinitionByKeyAndTenantId: " + e.Message );
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
 **key** | **string**| The key of the decision definition (the latest version thereof) to be retrieved. | 
 **tenantId** | **string**| The id of the tenant the decision definition belongs to. | 

### Return type

[**DecisionDefinitionDto**](DecisionDefinitionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisiondefinitiondiagram"></a>
# **GetDecisionDefinitionDiagram**
> FileParameter GetDecisionDefinitionDiagram (string id)

Get Diagram

Retrieves the diagram of a decision definition.

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
    public class GetDecisionDefinitionDiagramExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the process definition.

            try
            {
                // Get Diagram
                FileParameter result = apiInstance.GetDecisionDefinitionDiagram(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.GetDecisionDefinitionDiagram: " + e.Message );
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
 **id** | **string**| The id of the process definition. | 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. The image diagram of this process. |  -  |
| **204** | The decision definition doesn&#39;t have an associated diagram. |  -  |
| **404** | Decision definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisiondefinitiondiagrambykey"></a>
# **GetDecisionDefinitionDiagramByKey**
> FileParameter GetDecisionDefinitionDiagramByKey (string key)

Get Diagram By Key

Returns the diagram for the latest version of the decision definition which belongs to no tenant

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
    public class GetDecisionDefinitionDiagramByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision definition (the latest version thereof) to be retrieved.

            try
            {
                // Get Diagram By Key
                FileParameter result = apiInstance.GetDecisionDefinitionDiagramByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.GetDecisionDefinitionDiagramByKey: " + e.Message );
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
 **key** | **string**| The key of the decision definition (the latest version thereof) to be retrieved. | 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. The image diagram of this process. |  -  |
| **204** | The decision definition doesn&#39;t have an associated diagram. |  -  |
| **404** | Decision definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisiondefinitiondiagrambykeyandtenant"></a>
# **GetDecisionDefinitionDiagramByKeyAndTenant**
> FileParameter GetDecisionDefinitionDiagramByKeyAndTenant (string key, string tenantId)

Get Diagram By Key And Tenant

Returns the XML of the latest version of the decision definition for tenant.

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
    public class GetDecisionDefinitionDiagramByKeyAndTenantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision definition (the latest version thereof) to be retrieved.
            var tenantId = tenantId_example;  // string | The id of the tenant the decision definition belongs to.

            try
            {
                // Get Diagram By Key And Tenant
                FileParameter result = apiInstance.GetDecisionDefinitionDiagramByKeyAndTenant(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.GetDecisionDefinitionDiagramByKeyAndTenant: " + e.Message );
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
 **key** | **string**| The key of the decision definition (the latest version thereof) to be retrieved. | 
 **tenantId** | **string**| The id of the tenant the decision definition belongs to. | 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. The image diagram of this process. |  -  |
| **204** | The decision definition doesn&#39;t have an associated diagram. |  -  |
| **404** | Decision definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisiondefinitiondmnxmlbyid"></a>
# **GetDecisionDefinitionDmnXmlById**
> DecisionDefinitionDiagramDto GetDecisionDefinitionDmnXmlById (string id)

Get XML By Id

Retrieves the DMN XML of a decision definition.

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
    public class GetDecisionDefinitionDmnXmlByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the decision definition.

            try
            {
                // Get XML By Id
                DecisionDefinitionDiagramDto result = apiInstance.GetDecisionDefinitionDmnXmlById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.GetDecisionDefinitionDmnXmlById: " + e.Message );
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
 **id** | **string**| The id of the decision definition. | 

### Return type

[**DecisionDefinitionDiagramDto**](DecisionDefinitionDiagramDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisiondefinitiondmnxmlbykey"></a>
# **GetDecisionDefinitionDmnXmlByKey**
> DecisionDefinitionDiagramDto GetDecisionDefinitionDmnXmlByKey (string key)

Get XML By Key

Retrieves the XML for the latest version of the decision definition which belongs to no tenant.

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
    public class GetDecisionDefinitionDmnXmlByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision definition (the latest version thereof).

            try
            {
                // Get XML By Key
                DecisionDefinitionDiagramDto result = apiInstance.GetDecisionDefinitionDmnXmlByKey(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.GetDecisionDefinitionDmnXmlByKey: " + e.Message );
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
 **key** | **string**| The key of the decision definition (the latest version thereof). | 

### Return type

[**DecisionDefinitionDiagramDto**](DecisionDefinitionDiagramDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisiondefinitiondmnxmlbykeyandtenant"></a>
# **GetDecisionDefinitionDmnXmlByKeyAndTenant**
> DecisionDefinitionDiagramDto GetDecisionDefinitionDmnXmlByKeyAndTenant (string key, string tenantId)

Get XML By Key and Tenant

Retrieves the XML of the latest version of the decision definition for tenant

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
    public class GetDecisionDefinitionDmnXmlByKeyAndTenantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision definition (the latest version thereof).
            var tenantId = tenantId_example;  // string | The id of the tenant the decision definition belongs to.

            try
            {
                // Get XML By Key and Tenant
                DecisionDefinitionDiagramDto result = apiInstance.GetDecisionDefinitionDmnXmlByKeyAndTenant(key, tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.GetDecisionDefinitionDmnXmlByKeyAndTenant: " + e.Message );
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
 **key** | **string**| The key of the decision definition (the latest version thereof). | 
 **tenantId** | **string**| The id of the tenant the decision definition belongs to. | 

### Return type

[**DecisionDefinitionDiagramDto**](DecisionDefinitionDiagramDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Decision definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdecisiondefinitions"></a>
# **GetDecisionDefinitions**
> List&lt;DecisionDefinitionDto&gt; GetDecisionDefinitions (string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null, string decisionDefinitionId = null, string decisionDefinitionIdIn = null, string name = null, string nameLike = null, string deploymentId = null, DateTime? deployedAfter = null, DateTime? deployedAt = null, string key = null, string keyLike = null, string category = null, string categoryLike = null, int? version = null, bool? latestVersion = null, string resourceName = null, string resourceNameLike = null, string decisionRequirementsDefinitionId = null, string decisionRequirementsDefinitionKey = null, bool? withoutDecisionRequirementsDefinition = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeDecisionDefinitionsWithoutTenantId = null, string versionTag = null, string versionTagLike = null)

Get List

Queries for decision definitions that fulfill given parameters. Parameters may be the properties of decision definitions, such as the name, key or version. The size of the result set can be retrieved by using the [Get Decision Definition Count](https://docs.camunda.org/manual/7.17/reference/rest/decision-definition/get-query-count/) method.

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
    public class GetDecisionDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var sortBy = sortBy_example;  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var decisionDefinitionId = decisionDefinitionId_example;  // string | Filter by decision definition id. (optional) 
            var decisionDefinitionIdIn = decisionDefinitionIdIn_example;  // string | Filter by decision definition ids. (optional) 
            var name = name_example;  // string | Filter by decision definition name. (optional) 
            var nameLike = nameLike_example;  // string | Filter by decision definition names that the parameter is a substring of. (optional) 
            var deploymentId = deploymentId_example;  // string | Filter by the deployment the id belongs to. (optional) 
            var deployedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by the deploy time of the deployment the decision definition belongs to. Only selects decision definitions that have been deployed after (exclusive) a specific time. (optional) 
            var deployedAt = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by the deploy time of the deployment the decision definition belongs to. Only selects decision definitions that have been deployed at a specific time (exact match). (optional) 
            var key = key_example;  // string | Filter by decision definition key, i.e., the id in the DMN 1.0 XML. Exact match. (optional) 
            var keyLike = keyLike_example;  // string | Filter by decision definition keys that the parameter is a substring of. (optional) 
            var category = category_example;  // string | Filter by decision definition category. Exact match. (optional) 
            var categoryLike = categoryLike_example;  // string | Filter by decision definition categories that the parameter is a substring of. (optional) 
            var version = 56;  // int? | Filter by decision definition version. (optional) 
            var latestVersion = true;  // bool? | Only include those decision definitions that are latest versions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var resourceName = resourceName_example;  // string | Filter by the name of the decision definition resource. Exact match. (optional) 
            var resourceNameLike = resourceNameLike_example;  // string | Filter by names of those decision definition resources that the parameter is a substring of. (optional) 
            var decisionRequirementsDefinitionId = decisionRequirementsDefinitionId_example;  // string | Filter by the id of the decision requirements definition this decision definition belongs to. (optional) 
            var decisionRequirementsDefinitionKey = decisionRequirementsDefinitionKey_example;  // string | Filter by the key of the decision requirements definition this decision definition belongs to. (optional) 
            var withoutDecisionRequirementsDefinition = true;  // bool? | Only include decision definitions which does not belongs to any decision requirements definition. Value may only be `true`, as `false` is the default behavior. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of `Strings`. A decision definition must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include decision definitions which belong to no tenant. Value can effectively only be `true`, as `false` is the default behavior. (optional) 
            var includeDecisionDefinitionsWithoutTenantId = true;  // bool? | Include decision definitions which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var versionTag = versionTag_example;  // string | Filter by the version tag. (optional) 
            var versionTagLike = versionTagLike_example;  // string | Filter by the version tags of those decision definition resources that the parameter is a substring of. (optional) 

            try
            {
                // Get List
                List<DecisionDefinitionDto> result = apiInstance.GetDecisionDefinitions(sortBy, sortOrder, firstResult, maxResults, decisionDefinitionId, decisionDefinitionIdIn, name, nameLike, deploymentId, deployedAfter, deployedAt, key, keyLike, category, categoryLike, version, latestVersion, resourceName, resourceNameLike, decisionRequirementsDefinitionId, decisionRequirementsDefinitionKey, withoutDecisionRequirementsDefinition, tenantIdIn, withoutTenantId, includeDecisionDefinitionsWithoutTenantId, versionTag, versionTagLike);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.GetDecisionDefinitions: " + e.Message );
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
 **decisionDefinitionId** | **string**| Filter by decision definition id. | [optional] 
 **decisionDefinitionIdIn** | **string**| Filter by decision definition ids. | [optional] 
 **name** | **string**| Filter by decision definition name. | [optional] 
 **nameLike** | **string**| Filter by decision definition names that the parameter is a substring of. | [optional] 
 **deploymentId** | **string**| Filter by the deployment the id belongs to. | [optional] 
 **deployedAfter** | **DateTime?**| Filter by the deploy time of the deployment the decision definition belongs to. Only selects decision definitions that have been deployed after (exclusive) a specific time. | [optional] 
 **deployedAt** | **DateTime?**| Filter by the deploy time of the deployment the decision definition belongs to. Only selects decision definitions that have been deployed at a specific time (exact match). | [optional] 
 **key** | **string**| Filter by decision definition key, i.e., the id in the DMN 1.0 XML. Exact match. | [optional] 
 **keyLike** | **string**| Filter by decision definition keys that the parameter is a substring of. | [optional] 
 **category** | **string**| Filter by decision definition category. Exact match. | [optional] 
 **categoryLike** | **string**| Filter by decision definition categories that the parameter is a substring of. | [optional] 
 **version** | **int?**| Filter by decision definition version. | [optional] 
 **latestVersion** | **bool?**| Only include those decision definitions that are latest versions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **resourceName** | **string**| Filter by the name of the decision definition resource. Exact match. | [optional] 
 **resourceNameLike** | **string**| Filter by names of those decision definition resources that the parameter is a substring of. | [optional] 
 **decisionRequirementsDefinitionId** | **string**| Filter by the id of the decision requirements definition this decision definition belongs to. | [optional] 
 **decisionRequirementsDefinitionKey** | **string**| Filter by the key of the decision requirements definition this decision definition belongs to. | [optional] 
 **withoutDecisionRequirementsDefinition** | **bool?**| Only include decision definitions which does not belongs to any decision requirements definition. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of &#x60;Strings&#x60;. A decision definition must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include decision definitions which belong to no tenant. Value can effectively only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeDecisionDefinitionsWithoutTenantId** | **bool?**| Include decision definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **versionTag** | **string**| Filter by the version tag. | [optional] 
 **versionTagLike** | **string**| Filter by the version tags of those decision definition resources that the parameter is a substring of. | [optional] 

### Return type

[**List&lt;DecisionDefinitionDto&gt;**](DecisionDefinitionDto.md)

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

<a name="getdecisiondefinitionscount"></a>
# **GetDecisionDefinitionsCount**
> CountResultDto GetDecisionDefinitionsCount (string decisionDefinitionId = null, string decisionDefinitionIdIn = null, string name = null, string nameLike = null, string deploymentId = null, DateTime? deployedAfter = null, DateTime? deployedAt = null, string key = null, string keyLike = null, string category = null, string categoryLike = null, int? version = null, bool? latestVersion = null, string resourceName = null, string resourceNameLike = null, string decisionRequirementsDefinitionId = null, string decisionRequirementsDefinitionKey = null, bool? withoutDecisionRequirementsDefinition = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? includeDecisionDefinitionsWithoutTenantId = null, string versionTag = null, string versionTagLike = null)

Get List Count

Requests the number of decision definitions that fulfill the query criteria. Takes the same filtering parameters as the [Get Decision Definition](https://docs.camunda.org/manual/7.17/reference/rest/decision-definition/get-query/) method.

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
    public class GetDecisionDefinitionsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var decisionDefinitionId = decisionDefinitionId_example;  // string | Filter by decision definition id. (optional) 
            var decisionDefinitionIdIn = decisionDefinitionIdIn_example;  // string | Filter by decision definition ids. (optional) 
            var name = name_example;  // string | Filter by decision definition name. (optional) 
            var nameLike = nameLike_example;  // string | Filter by decision definition names that the parameter is a substring of. (optional) 
            var deploymentId = deploymentId_example;  // string | Filter by the deployment the id belongs to. (optional) 
            var deployedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by the deploy time of the deployment the decision definition belongs to. Only selects decision definitions that have been deployed after (exclusive) a specific time. (optional) 
            var deployedAt = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by the deploy time of the deployment the decision definition belongs to. Only selects decision definitions that have been deployed at a specific time (exact match). (optional) 
            var key = key_example;  // string | Filter by decision definition key, i.e., the id in the DMN 1.0 XML. Exact match. (optional) 
            var keyLike = keyLike_example;  // string | Filter by decision definition keys that the parameter is a substring of. (optional) 
            var category = category_example;  // string | Filter by decision definition category. Exact match. (optional) 
            var categoryLike = categoryLike_example;  // string | Filter by decision definition categories that the parameter is a substring of. (optional) 
            var version = 56;  // int? | Filter by decision definition version. (optional) 
            var latestVersion = true;  // bool? | Only include those decision definitions that are latest versions. Value may only be `true`, as `false` is the default behavior. (optional) 
            var resourceName = resourceName_example;  // string | Filter by the name of the decision definition resource. Exact match. (optional) 
            var resourceNameLike = resourceNameLike_example;  // string | Filter by names of those decision definition resources that the parameter is a substring of. (optional) 
            var decisionRequirementsDefinitionId = decisionRequirementsDefinitionId_example;  // string | Filter by the id of the decision requirements definition this decision definition belongs to. (optional) 
            var decisionRequirementsDefinitionKey = decisionRequirementsDefinitionKey_example;  // string | Filter by the key of the decision requirements definition this decision definition belongs to. (optional) 
            var withoutDecisionRequirementsDefinition = true;  // bool? | Only include decision definitions which does not belongs to any decision requirements definition. Value may only be `true`, as `false` is the default behavior. (optional) 
            var tenantIdIn = tenantIdIn_example;  // string | Filter by a comma-separated list of `Strings`. A decision definition must have one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include decision definitions which belong to no tenant. Value can effectively only be `true`, as `false` is the default behavior. (optional) 
            var includeDecisionDefinitionsWithoutTenantId = true;  // bool? | Include decision definitions which belong to no tenant. Can be used in combination with `tenantIdIn`. Value may only be `true`, as `false` is the default behavior. (optional) 
            var versionTag = versionTag_example;  // string | Filter by the version tag. (optional) 
            var versionTagLike = versionTagLike_example;  // string | Filter by the version tags of those decision definition resources that the parameter is a substring of. (optional) 

            try
            {
                // Get List Count
                CountResultDto result = apiInstance.GetDecisionDefinitionsCount(decisionDefinitionId, decisionDefinitionIdIn, name, nameLike, deploymentId, deployedAfter, deployedAt, key, keyLike, category, categoryLike, version, latestVersion, resourceName, resourceNameLike, decisionRequirementsDefinitionId, decisionRequirementsDefinitionKey, withoutDecisionRequirementsDefinition, tenantIdIn, withoutTenantId, includeDecisionDefinitionsWithoutTenantId, versionTag, versionTagLike);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.GetDecisionDefinitionsCount: " + e.Message );
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
 **decisionDefinitionId** | **string**| Filter by decision definition id. | [optional] 
 **decisionDefinitionIdIn** | **string**| Filter by decision definition ids. | [optional] 
 **name** | **string**| Filter by decision definition name. | [optional] 
 **nameLike** | **string**| Filter by decision definition names that the parameter is a substring of. | [optional] 
 **deploymentId** | **string**| Filter by the deployment the id belongs to. | [optional] 
 **deployedAfter** | **DateTime?**| Filter by the deploy time of the deployment the decision definition belongs to. Only selects decision definitions that have been deployed after (exclusive) a specific time. | [optional] 
 **deployedAt** | **DateTime?**| Filter by the deploy time of the deployment the decision definition belongs to. Only selects decision definitions that have been deployed at a specific time (exact match). | [optional] 
 **key** | **string**| Filter by decision definition key, i.e., the id in the DMN 1.0 XML. Exact match. | [optional] 
 **keyLike** | **string**| Filter by decision definition keys that the parameter is a substring of. | [optional] 
 **category** | **string**| Filter by decision definition category. Exact match. | [optional] 
 **categoryLike** | **string**| Filter by decision definition categories that the parameter is a substring of. | [optional] 
 **version** | **int?**| Filter by decision definition version. | [optional] 
 **latestVersion** | **bool?**| Only include those decision definitions that are latest versions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **resourceName** | **string**| Filter by the name of the decision definition resource. Exact match. | [optional] 
 **resourceNameLike** | **string**| Filter by names of those decision definition resources that the parameter is a substring of. | [optional] 
 **decisionRequirementsDefinitionId** | **string**| Filter by the id of the decision requirements definition this decision definition belongs to. | [optional] 
 **decisionRequirementsDefinitionKey** | **string**| Filter by the key of the decision requirements definition this decision definition belongs to. | [optional] 
 **withoutDecisionRequirementsDefinition** | **bool?**| Only include decision definitions which does not belongs to any decision requirements definition. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **tenantIdIn** | **string**| Filter by a comma-separated list of &#x60;Strings&#x60;. A decision definition must have one of the given tenant ids. | [optional] 
 **withoutTenantId** | **bool?**| Only include decision definitions which belong to no tenant. Value can effectively only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **includeDecisionDefinitionsWithoutTenantId** | **bool?**| Include decision definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
 **versionTag** | **string**| Filter by the version tag. | [optional] 
 **versionTagLike** | **string**| Filter by the version tags of those decision definition resources that the parameter is a substring of. | [optional] 

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

<a name="updatehistorytimetolivebydecisiondefinitionid"></a>
# **UpdateHistoryTimeToLiveByDecisionDefinitionId**
> void UpdateHistoryTimeToLiveByDecisionDefinitionId (string id, HistoryTimeToLiveDto historyTimeToLiveDto = null)

Update History Time to Live

Updates history time to live for decision definition. The field is used within [History cleanup](https://docs.camunda.org/manual/7.17/user-guide/process-engine/history/#history-cleanup).

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
    public class UpdateHistoryTimeToLiveByDecisionDefinitionIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The id of the decision definition to change history time to live.
            var historyTimeToLiveDto = new HistoryTimeToLiveDto(); // HistoryTimeToLiveDto |  (optional) 

            try
            {
                // Update History Time to Live
                apiInstance.UpdateHistoryTimeToLiveByDecisionDefinitionId(id, historyTimeToLiveDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.UpdateHistoryTimeToLiveByDecisionDefinitionId: " + e.Message );
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
 **id** | **string**| The id of the decision definition to change history time to live. | 
 **historyTimeToLiveDto** | [**HistoryTimeToLiveDto**](HistoryTimeToLiveDto.md)|  | [optional] 

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
| **400** | Returned if some of the request parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Decision definition with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatehistorytimetolivebydecisiondefinitionkey"></a>
# **UpdateHistoryTimeToLiveByDecisionDefinitionKey**
> void UpdateHistoryTimeToLiveByDecisionDefinitionKey (string key, HistoryTimeToLiveDto historyTimeToLiveDto = null)

Update History Time to Live By Key

Updates the latest version of the decision definition which belongs to no tenant. The field is used within [History cleanup](https://docs.camunda.org/manual/7.17/user-guide/process-engine/history/#history-cleanup).

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
    public class UpdateHistoryTimeToLiveByDecisionDefinitionKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision definitions to change history time to live.
            var historyTimeToLiveDto = new HistoryTimeToLiveDto(); // HistoryTimeToLiveDto |  (optional) 

            try
            {
                // Update History Time to Live By Key
                apiInstance.UpdateHistoryTimeToLiveByDecisionDefinitionKey(key, historyTimeToLiveDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.UpdateHistoryTimeToLiveByDecisionDefinitionKey: " + e.Message );
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
 **key** | **string**| The key of the decision definitions to change history time to live. | 
 **historyTimeToLiveDto** | [**HistoryTimeToLiveDto**](HistoryTimeToLiveDto.md)|  | [optional] 

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
| **400** | Returned if some of the request parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Decision definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatehistorytimetolivebydecisiondefinitionkeyandtenant"></a>
# **UpdateHistoryTimeToLiveByDecisionDefinitionKeyAndTenant**
> void UpdateHistoryTimeToLiveByDecisionDefinitionKeyAndTenant (string key, string tenantId, HistoryTimeToLiveDto historyTimeToLiveDto = null)

Update History Time to Live By Key And Tenant

Updates the latest version of the decision definition for tenant. The field is used within [History cleanup](https://docs.camunda.org/manual/7.17/user-guide/process-engine/history/#history-cleanup).

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
    public class UpdateHistoryTimeToLiveByDecisionDefinitionKeyAndTenantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DecisionDefinitionApi(httpClient, config, httpClientHandler);
            var key = key_example;  // string | The key of the decision definitions to change history time to live.
            var tenantId = tenantId_example;  // string | The id of the tenant the decision definition belongs to.
            var historyTimeToLiveDto = new HistoryTimeToLiveDto(); // HistoryTimeToLiveDto |  (optional) 

            try
            {
                // Update History Time to Live By Key And Tenant
                apiInstance.UpdateHistoryTimeToLiveByDecisionDefinitionKeyAndTenant(key, tenantId, historyTimeToLiveDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecisionDefinitionApi.UpdateHistoryTimeToLiveByDecisionDefinitionKeyAndTenant: " + e.Message );
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
 **key** | **string**| The key of the decision definitions to change history time to live. | 
 **tenantId** | **string**| The id of the tenant the decision definition belongs to. | 
 **historyTimeToLiveDto** | [**HistoryTimeToLiveDto**](HistoryTimeToLiveDto.md)|  | [optional] 

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
| **400** | Returned if some of the request parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Decision definition with given key does not exist. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

