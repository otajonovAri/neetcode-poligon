public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        for(int i = 0; i < matrix.Length; i++)
            for(int j = 0; j < matrix[i].Length; j++)
                if(target == matrix[i][j])
                    return true;

        return false;    
    }
}
