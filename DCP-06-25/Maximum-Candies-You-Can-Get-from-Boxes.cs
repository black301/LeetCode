public class Solution
{
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes)
    {
        int result = 0;
        HashSet<int> ints = new HashSet<int>();
        HashSet<int> boxesIhave = new HashSet<int>(initialBoxes);
        Queue<int> queue = new Queue<int>();
        foreach (var box in initialBoxes)
        {
            if (status[box] == 1) // Check if the box is unlocked
            {
                queue.Enqueue(box);
                ints.Add(box); // Add to the set of boxes we have
            }
        }
        while (queue.Count()!=0)
        {
            int box = queue.Dequeue();
            result += candies[box];
            foreach (var containedBox in containedBoxes[box])
            {
                if (!boxesIhave.Contains(containedBox))
                {
                    boxesIhave.Add(containedBox);
                }
                if (status[containedBox] == 1)
                {
                    if (!ints.Contains(containedBox))
                    {
                        queue.Enqueue(containedBox); // Add to queue if the box is unlocked
                        ints.Add(containedBox);
                    }
                }
            }
            foreach (var key in keys[box])
            {
                status[key] = 1; // Unlock the key
                if (boxesIhave.Contains(key))
                {
                    if (!ints.Contains(key))
                    {
                        queue.Enqueue(key); // Add to queue if the box is unlocked
                        ints.Add(key);
                    }
                }
            }

        }
        return result;
    }
}