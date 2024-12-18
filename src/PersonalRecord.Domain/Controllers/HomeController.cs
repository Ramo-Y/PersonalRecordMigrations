namespace PersonalRecord.Domain.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PersonalRecord.Domain.Exporter;
    using PersonalRecord.Domain.Models;
    using PersonalRecord.Domain.ViewModels;
    using System.Diagnostics;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PreparationDatabase _preparationDatabase;
        private readonly ExerciseExporter _exerciseExporter;
        private readonly WorkoutExporter _workoutExporter;

        public HomeController(
            ILogger<HomeController> logger,
            PreparationDatabase preparationDatabase,
            ExerciseExporter exerciseExporter,
            WorkoutExporter workoutExporter)
        {
            _logger = logger;
            _preparationDatabase = preparationDatabase;
            _exerciseExporter = exerciseExporter;
            _workoutExporter = workoutExporter;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task ApplyMigrations()
        {
            await _preparationDatabase.PreparatePopulationAsync();
        }

        public async Task ExportAll()
        {
            await _exerciseExporter.GenerateAndExportAsync();
            await _workoutExporter.GenerateAndExportAsync();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}