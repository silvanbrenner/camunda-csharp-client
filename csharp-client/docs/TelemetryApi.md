# Camunda.OpenApi.Client.Api.TelemetryApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigureTelemetry**](TelemetryApi.md#configuretelemetry) | **POST** /telemetry/configuration | Configure Telemetry
[**GetTelemetryConfiguration**](TelemetryApi.md#gettelemetryconfiguration) | **GET** /telemetry/configuration | Fetch Telemetry Configuration


<a name="configuretelemetry"></a>
# **ConfigureTelemetry**
> void ConfigureTelemetry (TelemetryConfigurationDto telemetryConfigurationDto = null)

Configure Telemetry

Configures whether Camunda receives data collection of the process engine setup and usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ConfigureTelemetryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TelemetryApi(config);
            var telemetryConfigurationDto = new TelemetryConfigurationDto(); // TelemetryConfigurationDto |  (optional) 

            try
            {
                // Configure Telemetry
                apiInstance.ConfigureTelemetry(telemetryConfigurationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TelemetryApi.ConfigureTelemetry: " + e.Message );
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
 **telemetryConfigurationDto** | [**TelemetryConfigurationDto**](TelemetryConfigurationDto.md)|  | [optional] 

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
| **401** | If the user who perform the operation is not a &lt;b&gt;camunda-admin&lt;/b&gt; user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettelemetryconfiguration"></a>
# **GetTelemetryConfiguration**
> TelemetryConfigurationDto GetTelemetryConfiguration ()

Fetch Telemetry Configuration

Fetches Telemetry Configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetTelemetryConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TelemetryApi(config);

            try
            {
                // Fetch Telemetry Configuration
                TelemetryConfigurationDto result = apiInstance.GetTelemetryConfiguration();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TelemetryApi.GetTelemetryConfiguration: " + e.Message );
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

[**TelemetryConfigurationDto**](TelemetryConfigurationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **401** | If the user who perform the operation is not a &lt;b&gt;camunda-admin&lt;/b&gt; user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

