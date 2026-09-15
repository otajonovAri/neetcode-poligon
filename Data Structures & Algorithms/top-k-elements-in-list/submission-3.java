class Solution {
    public int[] topKFrequent(int[] nums, int k) {
        if(nums.length == k) return nums;
       Map<Integer, Integer> map = new HashMap<>();
        for (int num : nums) {
            map.put(num, map.getOrDefault(num, 0) + 1);
        }

        List<Integer> list = new ArrayList<>();
        for (Map.Entry<Integer, Integer> entry : map.entrySet()) {
            if (entry.getValue() >= k) {
                list.add(entry.getKey());
            }
        }

        return list.stream().mapToInt(i -> i).toArray();
    }
}