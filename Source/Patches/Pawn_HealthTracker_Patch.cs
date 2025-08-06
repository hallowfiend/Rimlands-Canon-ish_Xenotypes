using HarmonyLib;
using RimWorld;
using Verse;

namespace RMLNDS_CanonishXenotypes
{

    [HarmonyPatch(typeof(Pawn_HealthTracker), "InPainShock")]
    public static class Pawn_HealthTracker_InPainShock_Patch
    {
        private static bool Prefix(Pawn_HealthTracker __instance, Pawn ___pawn) =>
        !___pawn.kindDef.ignoresPainShock && !___pawn.genes.HasActiveGene(RMLNDS_CanonishXenotypes_DefOf.RMLNDSCanonXeno_NoPainShock) && (double)__instance.hediffSet.PainTotal >= (double)___pawn.GetStatValue(StatDefOf.PainShockThreshold);
    }
}
