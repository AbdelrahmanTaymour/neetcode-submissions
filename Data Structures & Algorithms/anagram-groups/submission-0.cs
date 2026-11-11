public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs == null || strs.Length == 0) return [];

        var anagramGroups = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!anagramGroups.TryGetValue(key, out var list)) {
                list = new List<string>();
                anagramGroups[key] = list;
            }
            list.Add(str);
        }

        return [.. anagramGroups.Values];
    }
}
