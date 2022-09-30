# API Frontend

It deals with frontend logic required for WebApi of .NET Project


## Requirements

1. VS Code

2. .NET 6.0


## Commits

1. .NET MVC Template

    Created by using following command

```powershell
dotnet new mvc 
```

2. Code Clean

3. CoinStat API

```cs
// CoinStat Controller
[HttpGet]
public async Task<IActionResult> CoinStat_All()
{
    var response = await httpClient.GetAsync(Configuration.GetValue<string>("coinstat"));
    var content = await response.Content.ReadAsStringAsync();

    var Api = new List<Api>();
    // if (response.Content.Headers.ContentType.MediaType == "application/json")
    // {
    Api = JsonConvert.DeserializeObject<List<Api>>(content);
    // }
    return View(Api);
}
```

4. CoinLore API

```cs
// CoinLore Controller
[HttpGet]
public async Task<IActionResult> CoinLore_Individual()
{
    var response = await httpClient.GetAsync(Configuration.GetValue<string>("coinlore"));
    var content = await response.Content.ReadAsStringAsync();

    var Api = new List<Api>();
    // if (response.Content.Headers.ContentType.MediaType == "application/json")
    // {
    Api = JsonConvert.DeserializeObject<List<Api>>(content);
    // }
    return View(Api);
}
```

5. Final Changes


## Start

### To Start enter following command in terminal

```powershell
dotnet run
```

### Visit the following link

[localhost:4000/](https://localhost:4000/)
