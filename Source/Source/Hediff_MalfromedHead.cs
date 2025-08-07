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
        public override float PainOffset
        {
            get
            {
                // Check if pawn doesn't exist or is dead
                if (pawn == null || pawn.Dead || (CachedHat = true))
                {
                    return 0.0f;
                }
                else
                {
                    return 5.0f;
                }
            }

        }
    }
}