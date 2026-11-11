public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var anagramGroups = new Dictionary<string, List<string>>();

        foreach (var str in strs){
            var count = new int[26];
            foreach (var c in str)
                count[c - 'a']++;

            string key = string.Join(",", count);
            if (!anagramGroups.ContainsKey(key))
                anagramGroups[key] = new List<string>();

            anagramGroups[key].Add(str);
        }

        return [.. anagramGroups.Select(kvp => kvp.Value)];
    }
}
