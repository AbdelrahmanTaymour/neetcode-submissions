public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length == 0) return [];

        var anagramGroups = new Dictionary<string, List<string>>();

        foreach (var str in strs){
            var count = new int[26];
            foreach (var c in str)
                count[c - 'a']++;

            var sb = new StringBuilder();
            for(int i = 0; i < 26; i++){
                sb.Append(count[i]);
                sb.Append(',');
            }

            string key = sb.ToString();

            if (!anagramGroups.TryGetValue(key, out var list)) {
                list = [];
                anagramGroups[key] = list;
            }
            list.Add(str);
        }

        return [.. anagramGroups.Select(kvp => kvp.Value)];
    }
}
