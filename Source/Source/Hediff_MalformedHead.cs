using RimWorld;
using System;
using System.Collections.Generic;
using Verse;

namespace RMLNDS_CanonishXenotypes
{
    public class Hediff_MalformedHead : HediffWithComps
    {
    
        public override bool Visible => false;
        public bool IsLethal => false;
        public bool CachedHat;
        public void NotifyApparelChanged(Apparel wornApparel)
        {
            CachedHat = pawn.apparel.BodyPartGroupIsCovered(BodyPartGroupDefOf.FullHead);
            return;
        }
        public override float PainOffset =>
        (
                // Check if pawn doesn't exist or is dead or is wearing a hat, if not so, apply max pain
                (pawn == null || pawn.Dead || (CachedHat == false)) ? 0.0f : 1.0f

        );
    }
}