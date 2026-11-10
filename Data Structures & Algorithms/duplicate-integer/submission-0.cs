public class Solution {
    public bool hasDuplicate(int[] nums) {
        for(int i = 0; i<nums.Length; i++)
        {
            for(int j = i; j<nums.Length-1; j++)
            {
                if(nums[i] == nums[j+1])
                    return true;
            }
        }
        return false;
    }
}
