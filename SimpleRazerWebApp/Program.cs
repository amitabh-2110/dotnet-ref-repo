using SimpleRazerWebApp.Middlewares;

// Program.cs is a simple Console Application with Main method which starts when we start the application.

/* WebApplication is a class in which CreateBuilder static method is present. CreateBuilder method initializes an instance of WebApplicationBuilder class
 * and sets up the configuration from appsettings.json for our web application. CreateBuilder method also set configuration taken inside 'args' argument
 * which contains environment config., hosting URLs etc.
 */

var builder = WebApplication.CreateBuilder(args);

// configure or register services to the DI container set up by the WebApplicationBuilder instance
builder.Services.AddRazorPages();
builder.Services.AddControllers();

/* Now builder.Build method will lock those configurations in order to consume these later and prepare our web app for handling user request. Now this app
 * represents our application with all its configurations and services.
 */

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios.
    app.UseHsts();
}

// app.Use() is used to chain middleware and it accepts two arguments httpContext object and next function
app.Use(async (context, next) =>
{
    Console.WriteLine(context.Request.Path);
    Console.WriteLine("before next");
    await next();
    // this line will execute after the next middleware in the pipeline finished executing.
    // It means when the next middleware in the pipeline finish its execution control again comes to this middleware.
    Console.WriteLine("after next");
});

app.UseTestMiddleware();

// app.Map() middleware used to execute handlers based on the matching path and does not pass the request furthur but returns from here
app.Map("/api", async (context) =>
{
    await context.Response.WriteAsync("Returning from /api path"); // it does not return but just write text to the response body
    Console.WriteLine("inside /api middleware");
});

app.UseHttpsRedirection(); // check if the middleware need to redirect http to https
app.UseStaticFiles(); // middleware used to serve any static file in response to request

app.UseRouting(); // middleware used to route the user request to appropriate request handler

app.UseAuthorization(); // middleware to authorize the user request

// app.MapRazorPages(); // middleware to execute the razor page and convert it into html (maps at both '/' and '/Index' route)

app.MapControllers(); // middleware to route the request to the controllers

// app.Run() is used to setup terminal middleware in the middleware pipeline and doesn't accept next function
// used for short circuiting
// app.Run(async context =>
// {
//     await context.Response.WriteAsync("Hello from terminal middleware");
//     Console.WriteLine("inside run middleware");
// });

app.Run();
