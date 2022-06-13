namespace Data
{
    public static class FreqAnalysis
    {
        private static Dictionary<string, int> FreqAnalysisFromString(string input)
        {
           var result = new Dictionary<string, int>();

            var words = input.Split(new String[] { " ", ",", ".", Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            foreach(var word in words)
            {
                if(result.ContainsKey(word))
                {
                    result[word] += 1;
                }
                else
                {
                    result.Add(word,1);
                }
            }

            return result;
        }

        public static async Task<Dictionary<string, int>> FreqAnalysisFromUrl(string url)
        {
            var httpClient = new HttpClient();

            var content = await httpClient.GetStringAsync(url);

            return FreqAnalysisFromString(content);
        }

        public static Dictionary<string, int> FreqAnalysisFromFile(string file)
        {
            var content = File.ReadAllText(file);

            return FreqAnalysisFromString(content);
        }
    }
}