# camunda-csharp-client
Generated C# OpenApi Client for Camunda

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