using HotChocolate.Execution;
using hotcholate_IStructualEquatable_repro;

var builder = WebApplication.CreateBuilder(args);

var _ = await builder
    .Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .BuildSchemaAsync();

var app = builder.Build();

app.MapGraphQL();
app.Run();
