# camunda-csharp-client
Generated C# OpenApi Client for Camunda

Nuget package: https://www.nuget.org/packages/Camunda.OpenApi.Client/

## Versions
| Camunda Version | Camunda.OpenApi.Client Version |
|-----------------|--------------------------------|
| 7.14.0          | 1.0.1                          |

## Example
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

## Example with Dependency Injection

You can implement your own Extension with your settings:
```csharp
public static class CamundaClientExtension
    {
        public static void AddCamundaClient(this IServiceCollection services)
        {
            var config = new Configuration
            {
                BasePath = "http://localhost:8080/engine-rest",
                UserAgent = "CamundaClient"
            };

            // enable Basic Authentication
            // var credentials = Encoding.ASCII.GetBytes("demo:demo");
            // config.DefaultHeaders["Authorization"] =  new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials)).ToString();

            // add all needed api's
            services.AddSingleton(new TaskApi(config));
            services.AddSingleton(new TaskVariableApi(config));
            services.AddSingleton(new ProcessInstanceApi(config));
            services.AddSingleton(new ProcessDefinitionApi(config));
            services.AddSingleton(new DeploymentApi(config));
            services.AddSingleton(new MessageApi(config));
            services.AddSingleton(new HistoricProcessInstanceApi(config));
            services.AddSingleton(new HistoricActivityInstanceApi(config));
        }
    }
```

Add `services.AddCamundaClient();` in Startup.cs on the `ConfigureServices` method:
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddCamundaClient();
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo {Title = "TestWebApp", Version = "v1"});
    });
}

```

Now you can inject the api services everywhere in your application. Example:
```csharp
[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{
    private readonly TaskApi _taskApi;

    public ExampleController(TaskApi taskApi)
    {
        _taskApi = taskApi;
    }

    [HttpGet]
    public IEnumerable<TaskDto> Get()
    {
        return _taskApi.QueryTasks();
    }
}
```