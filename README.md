# camunda-csharp-client
Generated C# OpenApi Client for Camunda

Nuget package: https://www.nuget.org/packages/Camunda.OpenApi.Client/

## Versions
| Camunda Version | Camunda.OpenApi.Client Version |
|-----------------|--------------------------------|
| 7.14.0          | 1.0.1                          |

## Generate Client
mvn clean package

## Example usage
```csharp
var config = new Configuration();
config.BasePath = "http://localhost:8080/engine-rest";

var apiInstance = new TaskApi(config);
try
{
    var result = apiInstance.QueryTasks();
    result.ForEach(item => Console.WriteLine(item.ToString()));
}
catch (ApiException e)
{
    Debug.Print(e.StackTrace);
}
```