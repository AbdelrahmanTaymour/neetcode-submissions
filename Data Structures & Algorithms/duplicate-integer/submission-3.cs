public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums == null) return false;

        HashSet<int> uniqueNums = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if(!uniqueNums.Add(nums[i]))
                return true;
        }

        return false;
    }
}