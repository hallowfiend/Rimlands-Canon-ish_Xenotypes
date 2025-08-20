using RimWorld;
using Verse;

namespace RMLNDS_CanonishXenotypes
{
    public class Hediff_PainStrength : Hediff
    {
        public bool IsLethal => false;
        public bool causesNoPain => true;
        public override float Severity => CalculateSeverity();

        private float CalculateSeverity()
        {
            return this.pawn.health.hediffSet.PainTotal;
        }
    }
}