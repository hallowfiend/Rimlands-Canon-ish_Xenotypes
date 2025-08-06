using RimWorld;
using Verse;

namespace RMLNDS_CanonishXenotypes
{
    [DefOf]
    public static class RMLNDS_CanonishXenotypes_DefOf
    {
        public static HediffDef RMLNDSCanonXeno_GoliathHediff;
        public static HediffDef RMLNDSCanonXeno_PainStrength;
        public static GeneDef RMLNDSCanonXeno_NoPainShock;
        public static GeneDef RMLNDSCanonXeno_HelmetDependency;
        static RMLNDS_CanonishXenotypes_DefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(RMLNDS_CanonishXenotypes_DefOf));
        }
    }
}
