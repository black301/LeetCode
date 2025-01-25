public class Solution
{
    public int ConvertTime(string current, string correct)
    {
        int CurrentTime = (int.Parse($"{current[0]}{current[1]}") * 60)+(int.Parse($"{current[3]}{current[4]}")); 
        int CorrectTime = (int.Parse($"{correct[0]}{correct[1]}") * 60)+(int.Parse($"{correct[3]}{correct[4]}")); 
        int time=CorrectTime-CurrentTime;
        int count = time / 60;
        time = time%60;
        count += time / 15;
        time = time % 15;
        count += time / 5;
        time = time % 5;
        count += time;
        return count;
    }
}