var builder = WebApplication.CreateBuilder(args);
var app = APISetup.Setup(builder);

string dbConnectionString = builder.Configuration["DefaultConnection"];
SqlConnection connectionString = new SqlConnection(dbConnectionString);
connectionString.Open();

// HEALTHCHECK
app.MapHealthChecks("/healthcheck/");

// CLIENTES 
ClientController.ActivateEndpoints(app: app, connectionString: connectionString, builder: builder);

// APOLICES 
PolicyController.ActivateEndpoints(app: app, connectionString: connectionString);

// COBERTURAS
CoverageController.ActivateEndpoints(app: app, connectionString: connectionString);

// OCORRENCIAS
IncidentController.ActivateEndpoints(app: app, connectionString: connectionString);

// TERCEIRIZADOS
OutsourcedController.ActivateEndpoints(app: app, connectionString: connectionString);

// USUARIOS
UserController.ActivateEndpoints(app: app, connectionString: connectionString, builder: builder);

// VEICULOS
VehicleController.ActivateEndpoints(app: app, connectionString: connectionString);

// FIPE API
FipeController.ActivateEndpoints(app: app);

app.Run();

