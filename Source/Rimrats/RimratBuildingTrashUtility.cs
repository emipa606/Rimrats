using RimWorld;
using UnityEngine;
using Verse;
using Verse.AI;

namespace Rimrats
{
    public static class RimratBuildingTrashUtility
    {
        private const int AttackJobTimeLimit = 1000;

        public static bool IsGoodTrashTargetFor(Building b, Pawn pawn)
        {
            return pawn.CanReach(b, PathEndMode.Touch, Danger.Deadly);
        }

        public static Job AttackJobOnFor(Building b, Pawn pawn)
        {
            var job = new Job(JobDefOf.AttackMelee, b);
            var timeLimit = Random.Range(300, 3000);
            job.expiryInterval = timeLimit;
            return job;
        }
    }
}