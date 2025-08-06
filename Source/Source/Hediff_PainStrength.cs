using RimWorld;
using Verse;

namespace RMLNDS_CanonishXenotypes
{
    public class Hediff_PainStrength : Hediff
    {
        public bool IsLethal => false;
        public float initialSeverity => 0.0f;
        public bool EverCurableByItem => false;
        public bool causesNoPain => true;
        public override float Severity
        {
            set
            {
                this.Severity = (this.pawn.health.hediffSet.PainTotal);
            }
            get => this.Severity;
        }
    }
}