using RimWorld;
using System;
using System.Collections.Generic;
using Verse;

namespace RMLNDS_CanonishXenotypes
{

	public class Gene_MalformedHead : Gene
	{   
        public override void PostAdd()
        {
            base.PostAdd();
            pawn.health.AddHediff(RMLNDS_CanonishXenotypes_DefOf.RMLNDSCanonXeno_GoliathHediff);
        }
        public override void PostRemove()
        {
            base.PostRemove();
            pawn.health.RemoveHediff(pawn.health.hediffSet.GetFirstHediffOfDef(RMLNDS_CanonishXenotypes_DefOf.RMLNDSCanonXeno_GoliathHediff));
        }
    }
}
