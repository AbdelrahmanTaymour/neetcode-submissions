public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> uniqueNums = new HashSet<int>(nums);
        return nums.Length > uniqueNums.Count;
    }
}