namespace PersonalRecord.Domain.Bases
{
    using Newtonsoft.Json;

    public abstract class ExporterBase<TEntity>
        where TEntity : class
    {
        public abstract Task GenerateAndExportAsync();

        protected async Task Export(IEnumerable<TEntity> entities)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var name = typeof(TEntity).Name;
            var json = JsonConvert.SerializeObject(entities, settings);
            var currentDirectory = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(currentDirectory, "Export", $"{name}Items.json");
            await File.WriteAllTextAsync(filePath, json);
        }
    }
}