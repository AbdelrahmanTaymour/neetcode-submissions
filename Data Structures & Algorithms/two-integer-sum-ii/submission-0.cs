public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length - 1;

        while(left < right){
            var currentSum = numbers[left] + numbers[right];
            if(currentSum == target)
                return [left + 1, right + 1];

            if(currentSum < target) 
                left++ ;
            else 
                right--;
        }
        return [];
    }
}
