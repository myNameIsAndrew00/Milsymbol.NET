using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milsymbol.NET
{
    /// <summary>
    /// Encapsulates all symbol options according to military symbol.
    /// </summary>
    internal class SymbolOptions
    {
        /// <summary>
        /// Property associated with FieldID C.
        /// </summary>
        public string? Quantity { get; set; }

        /// <summary>
        /// Property associated with FieldID F.
        /// </summary>
        public string? ReinforcedReduced { get; set; }

        /// <summary>
        /// Property associated with FieldID G.
        /// </summary>
        public string? StaffComments { get; set; }

        /// <summary>
        /// Property associated with FieldID H.
        /// </summary>
        public string? AdditionalInformation { get; set; }

        /// <summary>
        /// Property associated with FieldID J.
        /// </summary>
        public string? EvaluationRating { get; set; }

        /// <summary>
        /// Property associated with FieldID K.
        /// </summary>
        public string? CombatEffectiveness { get; set; }

        /// <summary>
        /// Property associated with FieldID L.
        /// </summary>
        public string? SignatureEquipment { get; set; }

        /// <summary>
        /// Property associated with FieldID M.
        /// </summary>
        public string? HigherFormation { get; set; }

        /// <summary>
        /// Property associated with FieldID N.
        /// </summary>
        public string? Hostile { get; set; }

        /// <summary>
        /// Property associated with FieldID P.
        /// </summary>
        public string? IffSif { get; set; }

        /// <summary>
        /// Property associated with FieldID Q.
        /// </summary>
        public string? Direction { get; set; }

        /// <summary>
        /// Property associated with FieldID R2.
        /// </summary>
        public string? Sigint { get; set; }

        /// <summary>
        /// Property associated with FieldID T.
        /// </summary>
        public string? UniqueDesignation { get; set; }

        /// <summary>
        /// Property associated with FieldID V.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Property associated with FieldID W.
        /// </summary>
        public string? Dtg { get; set; }

        /// <summary>
        /// Property associated with FieldID X.
        /// </summary>
        public string? AltitudeDepth { get; set; }

        /// <summary>
        /// Property associated with FieldID Y.
        /// </summary>
        public string? Location { get; set; }

        /// <summary>
        /// Property associated with FieldID Z.
        /// </summary>
        public string? Speed { get; set; }

        /// <summary>
        /// Property associated with the length of the speed leader.
        /// </summary>
        public int SpeedLeader { get; set; }

        /// <summary>
        /// Property associated with FieldID AA.
        /// </summary>
        public string? SpecialHeadquarters { get; set; }

        /// <summary>
        /// Property associated with FieldID AC Country.
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Property associated with FieldID AD.
        /// </summary>
        public string? PlatformType { get; set; }

        /// <summary>
        /// Property associated with FieldID AE.
        /// </summary>
        public string? EquipmentTeardownTime { get; set; }

        /// <summary>
        /// Property associated with FieldID AF.
        /// </summary>
        public string? CommonIdentifier { get; set; }

        /// <summary>
        /// Property associated with FieldID AG.
        /// </summary>
        public string? AuxiliaryEquipmentIndicator { get; set; }

        /// <summary>
        /// Property associated with FieldID AH.
        /// </summary>
        public string? HeadquartersElement { get; set; }

        /// <summary>
        /// Property associated with FieldID AI.
        /// </summary>
        public string? InstallationComposition { get; set; }
    }
}
