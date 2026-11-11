public class Solution {
    public bool IsAnagram(string s, string t) {
        var sDict = new Dictionary<char, int>();
        var tDict = new Dictionary<char, int>();

        foreach(char c in s){
            if(!sDict.TryAdd(c, 1)) sDict[c] = sDict[c] + 1;
        }

        foreach(char c in t){
            if(!tDict.TryAdd(c, 1)) tDict[c] = tDict[c] + 1;
        }

        if (sDict.Count != tDict.Count) return false;

        foreach(var kvp in sDict){
            if(!tDict.TryGetValue(kvp.Key, out int tValue) || kvp.Value != tValue)
                return false;
        }

        return true;
    }
}
