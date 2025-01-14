using System.Reflection;
using DesignPatternsWebApi.DesignPatterns.Repository;
using DesignPatternsWebApi.Services;
using MediatR;


var builder = WebApplication.CreateBuilder(args);

// // 🔹 Serilog Logger Configuration
// builder.Host.UseSerilog((context, configuration) =>
//     configuration.WriteTo.Console().ReadFrom.Configuration(context.Configuration));


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔹 Database Configuration (EF Core InMemory for now, replace with SQL Server if needed)
// builder.Services.AddDbContext<AppDbContext>(options => 
//     options.UseInMemoryDatabase("DesignPatternsDb"));


// 🔹 Design Pattern Services
builder.Services.AddSingleton<SingletonService>();
builder.Services.AddScoped<FactoryService>();
builder.Services.AddScoped<IRepository<string>, UserRepository>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<StrategyService>();


    // 🔹 CQRS Service'ini Dependency Injection'a ekleyelim
builder.Services.AddScoped<CqrsService>();

// 🔹 MediatR için yapılandırma (Yeni Yöntem)
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));



//
// // 🔹 FluentValidation Setup
// builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);


var app = builder.Build();
// app.UseSerilogRequestLogging(); // Log all requests
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.Run();