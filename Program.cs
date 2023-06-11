using System.Data;
using CommanderGQL.Data;
using CommanderGQL.GraphQL;
using CommanderGQL.GraphQL.Platforms;
using GraphQL.Server.Ui.Voyager;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();
builder.Services.AddPooledDbContextFactory<AppDbContext>(options =>
            options.UseNpgsql(config.GetConnectionString("DefaultConnection")));

//TODO : Find  way the show detailed exception wheb enveiroment is development
builder.Services.AddGraphQLServer()
.RegisterDbContext<AppDbContext>(DbContextKind.Pooled)
.AddQueryType<Query>()
.AddType<PlatformType>()
.AddType<CommandType>()
.AddFiltering()
.AddSorting()
.ModifyRequestOptions(opt => opt.IncludeExceptionDetails = true);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGraphQL();

// app.UseEndpoints(endpoints =>
// {
//     endpoints.MapGraphQL();
// });

app.UseGraphQLVoyager("/ui/voyager", new VoyagerOptions()
{
    GraphQLEndPoint = "/graphql"

});

app.Run();
