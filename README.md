# Function
Simplify reflection loading types.

# Install
Install-Package Minux.TypeLoader -Version 2.0.1   
dotnet add package Minux.TypeLoader --version 2.0.1   

# Add to services
```c#
public void ConfigureServices(IServiceCollection services)
{
  services.AddTypeLoader();
}
```

# Use
```c#
// Load all types that implementing the IMyService interface from the application domain 
IEnumerable<Type> myServiceTypes = loader.Load<IMyService>();
```

```c#
// Load all types that implementing the IMyService interface and declared with MyCustomAttribute from the application domain 
IEnumerable<Type, MyCustomAttribute> myServiceTypes = loader.Load<IMyService, MyCustomAttribute>();
```
