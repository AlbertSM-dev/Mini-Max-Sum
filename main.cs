public class Result
{
    public static void miniMaxSum(List<int> num) {
    long sum = 0;
    int min = num[0];
    int max = num[0];
    
    for(int i = 0; i < num.Count(); i++)
    {
        sum += num[i];
        if(num[i] < min)
        {
        min = num[i];
        }
        if(num[i] > max)
        {
        max = num[i];
        }
    }
    var result1 = sum - max;
    var result2 = sum - min;     
    Console.WriteLine(result1 + " " + result2);
    }    
}
