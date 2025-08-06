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
        public override float PainOffset => HatChecker;
        public float HatChecker
        {
            set
            {
                // Check if pawn doesn't exist or is dead
                if (pawn == null || pawn.Dead || (CachedHat = true))
                {
                    HatChecker = 0.0f;
                }
                else
                {
                    HatChecker = 5.0f;
                }
            }
            get => HatChecker;

        }
    }
}