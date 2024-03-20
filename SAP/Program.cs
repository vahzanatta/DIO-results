namespace SAP;

public class Solution
{
    public static int countCustomers(int[] bill)
    {
        int answer = 0;
        //write your code here
        foreach (int numOfCust in bill)
        {
            answer += numOfCust;
        }

        return answer;
    }

    public static void Main(string[] args)
    {
        string[] input;
        //input for bill
        int N = int.Parse(Console.ReadLine());
        int numOfCust = int.Parse(Console.ReadLine());

        int bill_size = int.Parse(Console.ReadLine());
        int[] bill = new int[bill_size];
        input = Console.ReadLine().Split(' ');
        for (int idx = 0; idx < bill_size; idx++)
        {
            bill[idx] = int.Parse(input[idx]);
        }

        int result = countCustomers(bill);
        //Console.Write(result);

        double squareRoot = Math.Sqrt(result);
        if (squareRoot % 1 == 0)
        {
            Console.Write(result);
        }
    }
}
