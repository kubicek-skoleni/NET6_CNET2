namespace Model
{
    /// <summary>
    /// Výsledek frekvenční analýzi pro jeden zdroj (soubor nebo url)
    /// </summary>
    public class FAResult
    {
        /// <summary>
        /// Zdroj textu
        /// </summary>
        public string Source { get; set; }

        public SourceType SourceType { get; set; }
        
        /// <summary>
        /// Výsledná frekvenční analýza slov 
        /// </summary>
        public Dictionary<string, int> Words { get; set; }

        public override string ToString() => $"{Source} {Words?.Count}";

    }

    public enum SourceType
    {
        URL,
        FILE
    }
}