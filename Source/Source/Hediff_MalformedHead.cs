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
        public bool CachedHat = false;
        public bool NotifyApparelChanged(Apparel wornApparel)
        {
            return CachedHat = pawn.apparel.BodyPartGroupIsCovered(BodyPartGroupDefOf.FullHead);
        }
        public override float PainOffset =>
        (
                // Check if pawn doesn't exist or is dead or is wearing a hat, if so, apply ridiculous pain
                (pawn == null || pawn.Dead || (CachedHat = true)) ? 0.0f : 5.0f

        );
    }
}