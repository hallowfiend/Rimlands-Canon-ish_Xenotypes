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

        // Initialize CachedHat when hediff is added
        public override void PostAdd(DamageInfo? dinfo)
        {
            base.PostAdd(dinfo);
            UpdateHelmetStatus();
        }

        // Update helmet status whenever apparel changes
        private void UpdateHelmetStatus()
        {
            CachedHat = pawn.apparel.BodyPartGroupIsCovered(BodyPartGroupDefOf.FullHead);
        }

        public override void Notify_PawnPostApplyDamage(DamageInfo dinfo, float totalDamageDealt)
        {
            base.Notify_PawnPostApplyDamage(dinfo, totalDamageDealt);
            UpdateHelmetStatus();
        }

        // Return pain value:
        // Returns 1.0 (max pain) when pawn exists, is alive, and has NO helmet
        // Returns 0.0 (no pain) when pawn is null, dead, or wearing a helmet
        public override float PainOffset =>
            (pawn != null && !pawn.Dead && !CachedHat) ? 1.0f : 0.0f;
    }
}