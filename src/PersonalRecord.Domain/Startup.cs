namespace PersonalRecord.Domain
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using PersonalRecord.Domain.Models.Entities;

    public class Startup
    {
        private readonly string _connectionString;
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = "";
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PersonalRecordContext>(opt => opt.UseSqlite(_connectionString));
        }
    }
}