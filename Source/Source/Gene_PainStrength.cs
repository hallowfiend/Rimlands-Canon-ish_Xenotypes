using Verse;
using RimWorld;

namespace RMLNDS_CanonishXenotypes
{

    public class Gene_PainStrength : Gene
    {
        public override void PostAdd()
        {
            base.PostAdd();
            pawn.health.AddHediff(RMLNDS_CanonishXenotypes_DefOf.RMLNDSCanonXeno_PainStrength);
        }
        public override void PostRemove()
        {
            base.PostRemove();
            pawn.health.RemoveHediff(pawn.health.hediffSet.GetFirstHediffOfDef(RMLNDS_CanonishXenotypes_DefOf.RMLNDSCanonXeno_PainStrength));
        }
    }
}