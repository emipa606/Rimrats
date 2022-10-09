using RimWorld;
using UnityEngine;
using Verse;
using Verse.AI;

namespace Rimrats;

public class ThinkNode_ConditionalRimrat : ThinkNode_Conditional
{
    private int curious = Random.Range(1, 1000);

    public override ThinkNode DeepCopy(bool resolve = true)
    {
        var thinkNode_ConditionalRimrat = (ThinkNode_ConditionalRimrat)base.DeepCopy(resolve);
        thinkNode_ConditionalRimrat.curious = curious;
        return thinkNode_ConditionalRimrat;
    }

    protected override bool Satisfied(Pawn pawn)
    {
        if (pawn.def.defName != "Rimrat")
        {
            return true;
        }

        if (pawn.training?.HasLearned(TrainableDefOf.Tameness) == true)
        {
            return true;
        }

        return Rand.Value < curious;
    }
}