public class Solution {
    public bool IsAnagram(string s, string t) {
         if (s.Length != t.Length)
            return false;
            
        int[] lettersCounter = new int[26];

        for(int i=0;i<s.Length; i++){
            lettersCounter[s[i] - 'a']++;
            lettersCounter[t[i] - 'a']--;
        }
        foreach(int count in lettersCounter){
            if(count != 0)
                return false;
        }
        return true;
    }
}
