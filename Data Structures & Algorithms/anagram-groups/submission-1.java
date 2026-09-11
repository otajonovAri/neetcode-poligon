class Solution {
    public List<List<String>> groupAnagrams(String[] strs)
    {
        Map <String, List<String>> map = new HashMap<>();
        for(String item : strs)
        {
            String sorted = Sorting(item);

            if(!map.containsKey(sorted))
            {
                map.put(sorted, new ArrayList<>());
            }

            map.get(sorted).add(item);
        }

        return new ArrayList<>(map.values());
    }
    private String Sorting(String str)
    {
        char[] chars = str.toCharArray();
        Arrays.sort(chars);
        return new String(chars);
    }
}