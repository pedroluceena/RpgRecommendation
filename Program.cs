using Microsoft.EntityFrameworkCore;
using RpgRecommendation.Services;
using RpgRecommendation.Models;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner de injeção de dependência
builder.Services.AddRazorPages();
builder.Services.AddScoped<IRpgRecommendationService, BasicRpgRecommendationService>();

// Configuração do banco de dados (quando você estiver pronto para implementar)
// builder.Services.AddDbContext<YourDbContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configura o pipeline de requisições HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();

app.Run();