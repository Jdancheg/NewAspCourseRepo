using MetricsAgent.Models;
using MetricsAgent.Services;
using MetricsAgent.Services.Impl;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using System.Data.SQLite;

namespace MetricsAgent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddScoped<ICpuMetricsRepository, CpuMetricsRepository>();

            //ConfigureSqlLiteConnection();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MetricsAgent", Version = "v1" });

                // ��������� TimeSpan
                c.MapType<TimeSpan>(() => new OpenApiSchema
                {
                    Type = "string",
                    Example = new OpenApiString("00:00:00")
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.UseHttpLogging();

            app.MapControllers();

            app.Run();
        }

        /// <summary>
        /// ����� ������������� ���������� � ������������ ��������� ��.
        /// ���� �� �� ����������, �� ������� ����� ������ ��.
        /// </summary>
        private static void ConfigureSqliteConnection()
        {
            const string connectionString = @"DataSource = metrics.db; Version = 3; Pooling = true; Max Pool Size = 100;";
            var connection = new SQLiteConnection(connectionString); 
            connection.Open();
            PrepareSchema(connection);
        }

        /// <summary>
        /// ����� �������� ������� cpumetrics � ��
        /// </summary>
        /// <param name="connection"></param>
        private static void PrepareSchema(SQLiteConnection connection)
        {
            using (var command = new SQLiteCommand(connection))
            {
                // ���� � �� ���� �������, cpumetrcis, ������� ��!
                command.CommandText = "DROP TABLE IF EXISTS cpumetrics";
                command.ExecuteNonQuery();
                // ������� ����� ������� cpumetrcis
                command.CommandText = @"CREATE TABLE cpumetrics(id INTEGER PRIMARY KEY, value INT, time INT)";
                command.ExecuteNonQuery();
            }
        }

    }
}