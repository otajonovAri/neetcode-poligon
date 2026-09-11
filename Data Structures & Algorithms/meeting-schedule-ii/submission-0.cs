/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        if (intervals == null || intervals.Count == 0)
            return 0;

        List<int> startTimes = new List<int>();
        List<int> endTimes = new List<int>();
        foreach (var interval in intervals)
        {
            startTimes.Add(interval.start);
            endTimes.Add(interval.end);
        }

        startTimes.Sort();
        endTimes.Sort();
        
        int startPointer = 0, endPointer = 0;
        int roomsNeeded = 0;
        while (startPointer < startTimes.Count)
        {
            if (startTimes[startPointer] < endTimes[endPointer])
            {
                roomsNeeded++;
                startPointer++;
            }
            else
            {
                endPointer++;
                startPointer++;
            }
        }
        return roomsNeeded;
    }
}
