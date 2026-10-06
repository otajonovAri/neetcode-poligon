public class Solution {
    public int ScoreOfString(string s) {
        var score = 0;
        for (int i = 1; i < s.Length; i++)
            score += (int)MathF.Abs(s[i] - s[i - 1]);

        return score;
    }
}