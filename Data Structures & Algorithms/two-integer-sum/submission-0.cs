public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(nums[0], 0);

        for(int i = 1; i<nums.Length; i++){
            int valueToFind = target - nums[i];
            
            if(dict.ContainsKey(valueToFind))
                return [dict[valueToFind], i];

            dict.Add(nums[i], i);
        }

        return [];
    }
}
