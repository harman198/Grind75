namespace Grind75.Core;

public class TwoSum
{
    public (int idx1, int idx2)? SimpleSolution(int[] items, int target)
    {
        if (items == null || items.Length < 2) return null;

        for (int i = 0; i < items.Length; i++)
        {
            var subTarget = target - items[i];
            var subTargetIndex = items.ToList().FindIndex(i+1, item => item == subTarget);

            if (subTargetIndex == -1) continue;
            else return (i, subTargetIndex);
        }
        return null;
   }
}
