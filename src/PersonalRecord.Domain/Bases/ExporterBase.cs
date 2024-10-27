namespace PersonalRecord.Domain.Bases
{
    using Newtonsoft.Json;

    public abstract class ExporterBase<TEntity>
        where TEntity : class
    {
        public abstract Task GenerateAndExportAsync();

        protected async Task Export(IEnumerable<TEntity> entities, string fileName)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(entities, settings);
            var currentDirectory = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(currentDirectory, "Export", $"{fileName}Items.json");
            await File.WriteAllTextAsync(filePath, json);
        }
    }
}