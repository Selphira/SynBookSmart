using Mutagen.Bethesda.Synthesis.Settings;

namespace BookSmart
{
    class Settings
    {
        // Which labels to add
        [SynthesisOrder]
        [SynthesisTooltip("Ajoutez le tag de compétence au nom du livre si le livre enseigne une compétence.")]
        public bool addSkillLabels = true;
        
        [SynthesisOrder]
        [SynthesisTooltip("Ajoutez le tag marqueur de carte au nom du livre si le livre enseigne des marqueurs de carte.")]
        public bool addMapMarkerLabels = true;

        [SynthesisOrder]
        [SynthesisTooltip("Ajoute le tag quête au nom du livre si celui-ci est utilisé dans une quête.")]
        public bool addQuestLabels = true;

        [SynthesisOrder]
        [SynthesisTooltip("Part du principe que tout LIVRE avec lié à un script est un livre de quête. Peut marquer incorrectement certains livres. Améliorera la détection des livres de mods qui utilisent leurs propres scripts.")]
        public bool assumeBookScriptsAreQuests = false;

        // Label Position
        public enum LabelPosition
        {
            Before_Name,
            After_Name
        }

        [SynthesisOrder]
        [SynthesisSettingName("Position du tag")]
        [SynthesisTooltip("Où placer le tag lors de la création du nouveau nom.")]
        public LabelPosition labelPosition { get; set; } = LabelPosition.Before_Name;

        // Label Format
        public enum LabelFormat
        {
            Étoile,
            Court,
            Long
        }

        [SynthesisOrder]
        [SynthesisSettingName("Format du tag")]
        [SynthesisTooltip("Étoile: *BookName\r\nCourt: <Alch> BookName\r\nLong: <Alchemy> BookName")]
        public LabelFormat labelFormat { get; set; } = LabelFormat.Long;

        // Encapsulating Characters
        public enum EncapsulatingCharacters
        {
            Parenthèses,
            Curly_Brackets,
            Square_Brackets,
            Chevrons,
            Étoiles           
        }

        [SynthesisOrder]
        [SynthesisSettingName("Caractères d'encapsulation")]
        [SynthesisTooltip("The characters to wrap the skill name in.\r\nParenthèses: ()\r\nCurly Brackets: {}\r\nSquare Brackets: []\r\nChevrons: <>\r\nÉtoiles: *")]
        public EncapsulatingCharacters encapsulatingCharacters { get; set; } = EncapsulatingCharacters.Parenthèses;
    }
}
