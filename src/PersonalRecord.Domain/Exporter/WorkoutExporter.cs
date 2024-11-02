namespace PersonalRecord.Domain.Exporter
{
    using PersonalRecord.Domain.Bases;
    using PersonalRecord.Domain.Models.Entities;
    using System.Text;
    using System.Threading.Tasks;

    public class WorkoutExporter : ExporterBase<Workout>
    {
        private static Guid HelenGuid = new("96e57fc6-12b4-4389-b8c4-e4a4b6a83672");
        private static Guid DianeGuid = new("1b8c1fcb-1c32-4416-a4ef-2471a9597c84");

        public override async Task GenerateAndExportAsync()
        {
            var helenStringBuilder = new StringBuilder();
            helenStringBuilder.AppendLine("Good Times for Helen:");
            helenStringBuilder.AppendLine("– Beginner: 15-17 minutes");
            helenStringBuilder.AppendLine("– Intermediate: 11-14 minutes");
            helenStringBuilder.AppendLine("– Advanced: 9-10 minutes");
            helenStringBuilder.AppendLine("– Elite: <8 minutes");

            var dianeStringBuilder = new StringBuilder();
            dianeStringBuilder.AppendLine("Good Times for Diane:");
            dianeStringBuilder.AppendLine("– Beginner: 10-14 minutes");
            dianeStringBuilder.AppendLine("– Intermediate: 6-9 minutes");
            dianeStringBuilder.AppendLine("– Advanced: 5-6 minutes");
            dianeStringBuilder.AppendLine("– Elite: <4 minutes");

            var list = new List<Workout>
            {
                new()
                {
                    WorkoutID = HelenGuid,
                    WokName = "Helen",
                    WokHeader = "3 Rounds For Time",
                    WokNotes = helenStringBuilder.ToString(),
                    WokWorkoutToExerciseItems =
                    [
                        new()
                        {
                            WorkoutToExerciseID = new Guid("dc52c198-a867-4c92-b964-c6d28e359b44"),
                            WteWorkoutID_FK = HelenGuid,
                            WteExerciseID_FK = ExerciseExporter.RunGuid,
                            WteExerciseDistance = 400
                        },
                        new()
                        {
                            WorkoutToExerciseID = new Guid("6250b22c-02e1-47a0-ab01-2bcaeea1cc73"),
                            WteWorkoutID_FK = HelenGuid,
                            WteExerciseID_FK = ExerciseExporter.KettlebellSwingsGuid,
                            WteExerciseRepCount = 21
                        },
                        new()
                        {
                            WorkoutToExerciseID = new Guid("79f9e18e-9c75-4ad4-aa7a-6ef1ccfe84b6"),
                            WteWorkoutID_FK = HelenGuid,
                            WteExerciseID_FK = ExerciseExporter.PullUpsGuid,
                            WteExerciseRepCount = 12
                        }
                    ]
                },
                new()
                {
                    WorkoutID = DianeGuid,
                    WokName = "Diane",
                    WokHeader = "21-15-9 Rounds For Time",
                    WokNotes = dianeStringBuilder.ToString(),
                    WokWorkoutToExerciseItems =
                    [
                        new()
                        {
                            WorkoutToExerciseID = new Guid("bc75eb4c-586a-45f0-a0cd-2428b14f28e7"),
                            WteWorkoutID_FK = DianeGuid,
                            WteExerciseID_FK = ExerciseExporter.DeadliftsGuid,
                            WteExerciseRepCount = 21
                        },
                        new()
                        {
                            WorkoutToExerciseID = new Guid("86fe2993-c428-4131-a65e-f467449d2953"),
                            WteWorkoutID_FK = DianeGuid,
                            WteExerciseID_FK = ExerciseExporter.HandstandPushUpsGuid,
                            WteExerciseRepCount = 21
                        },
                        new()
                        {
                            WorkoutToExerciseID = new Guid("54d9b35c-95a3-4799-880c-021ee76218de"),
                            WteWorkoutID_FK = DianeGuid,
                            WteExerciseID_FK = ExerciseExporter.DeadliftsGuid,
                            WteExerciseRepCount = 15
                        },
                        new()
                        {
                            WorkoutToExerciseID = new Guid("5b3d2d12-62eb-4a8f-9fdd-89490c431d52"),
                            WteWorkoutID_FK = DianeGuid,
                            WteExerciseID_FK = ExerciseExporter.HandstandPushUpsGuid,
                            WteExerciseRepCount = 15
                        },
                        new()
                        {
                            WorkoutToExerciseID = new Guid("298e14f4-86c3-4e37-bd29-75734a9714bf"),
                            WteWorkoutID_FK = DianeGuid,
                            WteExerciseID_FK = ExerciseExporter.DeadliftsGuid,
                            WteExerciseRepCount = 9
                        },
                        new()
                        {
                            WorkoutToExerciseID = new Guid("4603e55c-ec51-4ba5-9483-b727eef79da0"),
                            WteWorkoutID_FK = DianeGuid,
                            WteExerciseID_FK = ExerciseExporter.HandstandPushUpsGuid,
                            WteExerciseRepCount = 9
                        }
                    ]
                },
            };

            await Export(list);
        }
    }
}