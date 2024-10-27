namespace PersonalRecord.Domain.Exporter
{
    using PersonalRecord.Domain.Bases;
    using PersonalRecord.Domain.Models.Entities;
    using System.Collections.Generic;

    public class ExerciseExporter : ExporterBase<Exercise>
    {
        public async override Task GenerateAndExportAsync()
        {
            var list = new List<Exercise>
            {
                new()
                {
                    ExerciseID = new Guid("ea5a4f3b-7781-4901-9894-a7f3d376db70"),
                    ExrName = "Run"
                },
                new()
                {
                    ExerciseID = new Guid("ddd7610c-c7a0-44fa-8ff9-6e77cca1d244"),
                    ExrName = "Kettlebell Swings"
                },
                new()
                {
                    ExerciseID = new Guid("c6f50c62-8d9a-4367-944f-c7244b23366e"),
                    ExrName = "Pull-Ups"
                }
            };

            await Export(list, nameof(Exercise));
        }
    }
}