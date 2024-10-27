namespace PersonalRecord.Domain.Exporter
{
    using PersonalRecord.Domain.Bases;
    using PersonalRecord.Domain.Models.Entities;
    using System.Text;
    using System.Threading.Tasks;

    public class WorkoutExporter : ExporterBase<Workout>
    {
        internal static Guid HelenGuid = new("96e57fc6-12b4-4389-b8c4-e4a4b6a83672");

        public override async Task GenerateAndExportAsync()
        {
            var helenStringBuilder = new StringBuilder();
            helenStringBuilder.AppendLine("Good Times for Helen:");
            helenStringBuilder.AppendLine("- Beginner: 15-17 minutes");
            helenStringBuilder.AppendLine("– Intermediate: 11-14 minutes");
            helenStringBuilder.AppendLine("– Advanced: 9-10 minutes");
            helenStringBuilder.AppendLine("– Elite: <8 minutes");

            var list = new List<Workout>
            {
                new()
                {
                    WorkoutID = HelenGuid,
                    WokName = "Helen",
                    WokHeader = "3 Rounds For Time",
                    WokNotes = helenStringBuilder.ToString()
                },
            };

            await Export(list);
        }
    }
}