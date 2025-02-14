# .NET Basics

- Command Name: "Project" in launchSettings.json file means it uses Kestrel server.
- We can launch our application to custom URL by including "launchUrl" field in the suitable profile.
- ApiController Attribute in a controller class is used to enhance the developer experience.
  - It automatically detects if our model state binding is invalid then sends the badrequest response to the user.
  - More we can find here: https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-8.0#apicontroller-attribute
