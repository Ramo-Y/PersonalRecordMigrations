namespace PersonalRecord.Domain.Exporter
{
    using PersonalRecord.Domain.Bases;
    using PersonalRecord.Domain.Models.Entities;

    public class WorkoutToExerciseExporter : ExporterBase<WorkoutToExercise>
    {
        public override async Task GenerateAndExportAsync()
        {
            var list = new List<WorkoutToExercise>
            {
                new()
                {
                    WorkoutToExerciseID = new Guid("dc52c198-a867-4c92-b964-c6d28e359b44"),
                    WteWorkoutID_FK = WorkoutExporter.HelenGuid,
                    WteExerciseID_FK = ExerciseExporter.RunGuid,
                    WteExerciseDistance = 400
                },
                new()
                {
                    WorkoutToExerciseID = new Guid("6250b22c-02e1-47a0-ab01-2bcaeea1cc73"),
                    WteWorkoutID_FK = WorkoutExporter.HelenGuid,
                    WteExerciseID_FK = ExerciseExporter.KettlebellSwingsGuid,
                    WteExerciseRepCount = 21
                },
                new()
                {
                    WorkoutToExerciseID = new Guid("79f9e18e-9c75-4ad4-aa7a-6ef1ccfe84b6"),
                    WteWorkoutID_FK = WorkoutExporter.HelenGuid,
                    WteExerciseID_FK = ExerciseExporter.PullUpsGuid,
                    WteExerciseRepCount = 21
                }
            };

            await Export(list);
        }
    }
}