# Camunda.OpenApi.Client.Api.MigrationApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExecuteMigrationPlan**](MigrationApi.md#executemigrationplan) | **POST** /migration/execute | Execute Migration Plan
[**ExecuteMigrationPlanAsync**](MigrationApi.md#executemigrationplanasync) | **POST** /migration/executeAsync | Execute Migration Plan Async (Batch)
[**GenerateMigrationPlan**](MigrationApi.md#generatemigrationplan) | **POST** /migration/generate | Generate Migration Plan
[**ValidateMigrationPlan**](MigrationApi.md#validatemigrationplan) | **POST** /migration/validate | Validate Migration Plan


<a name="executemigrationplan"></a>
# **ExecuteMigrationPlan**
> void ExecuteMigrationPlan (MigrationExecutionDto migrationExecutionDto = null)

Execute Migration Plan

Executes a migration plan synchronously for multiple process instances. To execute a migration plan asynchronously, use the [Execute Migration Plan Async(Batch)](https://docs.camunda.org/manual/7.17/reference/rest/migration/execute-migration-async/) method.  For more information about the difference between synchronous and asynchronous execution of a migration plan, please refer to the related section of [the user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/process-instance-migration/#executing-a-migration-plan).

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
    public class ExecuteMigrationPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MigrationApi(httpClient, config, httpClientHandler);
            var migrationExecutionDto = new MigrationExecutionDto(); // MigrationExecutionDto |  (optional) 

            try
            {
                // Execute Migration Plan
                apiInstance.ExecuteMigrationPlan(migrationExecutionDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MigrationApi.ExecuteMigrationPlan: " + e.Message );
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
 **migrationExecutionDto** | [**MigrationExecutionDto**](MigrationExecutionDto.md)|  | [optional] 

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
| **400** | The request is not valid if one or more of the following statements apply:  * The provided migration plan is not valid, so an exception of type &#x60;MigrationPlanValidationException&#x60; is returned. * The provided migration plan is not valid for a specific process instance it is applied to, so an exception of type &#x60;MigratingProcessInstanceValidationException&#x60; is returned. * In case additional parameters of the request are unexpected, an exception of type &#x60;InvalidRequestException&#x60; is returned.  See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executemigrationplanasync"></a>
# **ExecuteMigrationPlanAsync**
> BatchDto ExecuteMigrationPlanAsync (MigrationExecutionDto migrationExecutionDto = null)

Execute Migration Plan Async (Batch)

Executes a migration plan asynchronously (batch) for multiple process instances. To execute a migration plan synchronously, use the [Execute MigrationPlan](https://docs.camunda.org/manual/7.17/reference/rest/migration/execute-migration/) method.  For more information about the difference between synchronous and asynchronous execution of a migration plan, please refer to the related section of [the user guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/process-instance-migration/#executing-a-migration-plan).

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
    public class ExecuteMigrationPlanAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MigrationApi(httpClient, config, httpClientHandler);
            var migrationExecutionDto = new MigrationExecutionDto(); // MigrationExecutionDto |  (optional) 

            try
            {
                // Execute Migration Plan Async (Batch)
                BatchDto result = apiInstance.ExecuteMigrationPlanAsync(migrationExecutionDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MigrationApi.ExecuteMigrationPlanAsync: " + e.Message );
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
 **migrationExecutionDto** | [**MigrationExecutionDto**](MigrationExecutionDto.md)|  | [optional] 

### Return type

[**BatchDto**](BatchDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | The request is not valid if one or more of the following statements apply:  * The provided migration plan is not valid, so an exception of type &#x60;MigrationPlanValidationException&#x60; is returned. * In case additional parameters of the request are unexpected, an exception of type &#x60;InvalidRequestException&#x60; is returned.  See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatemigrationplan"></a>
# **GenerateMigrationPlan**
> MigrationPlanDto GenerateMigrationPlan (MigrationPlanGenerationDto migrationPlanGenerationDto = null)

Generate Migration Plan

Generates a migration plan for two process definitions. The generated migration plan contains migration instructions which map equal activities between the two process definitions.

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
    public class GenerateMigrationPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MigrationApi(httpClient, config, httpClientHandler);
            var migrationPlanGenerationDto = new MigrationPlanGenerationDto(); // MigrationPlanGenerationDto |  (optional) 

            try
            {
                // Generate Migration Plan
                MigrationPlanDto result = apiInstance.GenerateMigrationPlan(migrationPlanGenerationDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MigrationApi.GenerateMigrationPlan: " + e.Message );
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
 **migrationPlanGenerationDto** | [**MigrationPlanGenerationDto**](MigrationPlanGenerationDto.md)|  | [optional] 

### Return type

[**MigrationPlanDto**](MigrationPlanDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** |  The requested migration was invalid. See [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatemigrationplan"></a>
# **ValidateMigrationPlan**
> MigrationPlanReportDto ValidateMigrationPlan (MigrationPlanDto migrationPlanDto = null)

Validate Migration Plan

Validates a migration plan statically without executing it. This corresponds to the [creation time validation](https://docs.camunda.org/manual/7.17/user-guide/process-engine/process-instance-migration/#creation-time-validation) described in the user guide.

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
    public class ValidateMigrationPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MigrationApi(httpClient, config, httpClientHandler);
            var migrationPlanDto = new MigrationPlanDto(); // MigrationPlanDto |  (optional) 

            try
            {
                // Validate Migration Plan
                MigrationPlanReportDto result = apiInstance.ValidateMigrationPlan(migrationPlanDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MigrationApi.ValidateMigrationPlan: " + e.Message );
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
 **migrationPlanDto** | [**MigrationPlanDto**](MigrationPlanDto.md)|  | [optional] 

### Return type

[**MigrationPlanReportDto**](MigrationPlanReportDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. The validation report was returned. |  -  |
| **400** | In case additional parameters of the request are unexpected, an exception of type &#x60;InvalidRequestException&#x60; is returned. See the [Introduction](https://docs.camunda.org/manual/7.17/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

