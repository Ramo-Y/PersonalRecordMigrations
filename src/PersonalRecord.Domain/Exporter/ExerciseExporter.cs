namespace PersonalRecord.Domain.Exporter
{
    using PersonalRecord.Domain.Bases;
    using PersonalRecord.Domain.Models.Entities;
    using System.Collections.Generic;

    public class ExerciseExporter : ExporterBase<Exercise>
    {
        internal static Guid RunGuid = new("ea5a4f3b-7781-4901-9894-a7f3d376db70");

        internal static Guid KettlebellSwingsGuid = new("ddd7610c-c7a0-44fa-8ff9-6e77cca1d244");

        internal static Guid PullUpsGuid = new("c6f50c62-8d9a-4367-944f-c7244b23366e");

        internal static Guid DeadliftsGuid = new("2e28deb5-d9b9-4900-b11d-519d01d86b3e");

        internal static Guid HandstandPushUpsGuid = new("7efdf00a-0428-40a6-afc8-96a3c2ccd4d8");

        public override async Task GenerateAndExportAsync()
        {
            var list = new List<Exercise>
            {
                new()
                {
                    ExerciseID = RunGuid,
                    ExrName = "Run"
                },
                new()
                {
                    ExerciseID = KettlebellSwingsGuid,
                    ExrName = "Kettlebell Swings"
                },
                new()
                {
                    ExerciseID = PullUpsGuid,
                    ExrName = "Pull-Ups"
                },
                new()
                {
                    ExerciseID = DeadliftsGuid,
                    ExrName = "Deadlifts"
                },
                new()
                {
                    ExerciseID = HandstandPushUpsGuid,
                    ExrName = "Handstand Push-Ups"
                },
            };

            await Export(list);
        }
    }
}