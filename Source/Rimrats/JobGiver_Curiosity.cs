using System.Linq;
using RimWorld;
using Verse;
using Verse.AI;

namespace Rimrats;

public class JobGiver_Curiosity : ThinkNode_JobGiver
{
    private readonly float searchRadius = 99999f;

    protected override Job TryGiveJob(Pawn pawn)
    {
        if (pawn.def.defName != "Rimrat")
        {
            return null;
        }

        if (pawn.training?.HasLearned(TrainableDefOf.Tameness) == true)
        {
            return null;
        }

        var allBuildingsPowered = from building in pawn.Map.listerBuildings.allBuildingsColonist
            where building.TransmitsPowerNow && building.PowerComp?.Props?.PowerConsumption == 0
            select building;

        if (!allBuildingsPowered.Any())
        {
            return null;
        }

        var radius = searchRadius * searchRadius;
        foreach (var building in allBuildingsPowered.InRandomOrder())
        {
            if (!RimratBuildingTrashUtility.IsGoodTrashTargetFor(building, pawn))
            {
                continue;
            }

            if (searchRadius >= 9999f || (building.Position - pawn.Position).LengthHorizontalSquared <= radius)
            {
                return RimratBuildingTrashUtility.AttackJobOnFor(building, pawn);
            }
        }

        return null;
    }
}