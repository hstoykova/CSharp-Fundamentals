string input = Console.ReadLine();
int evenSum = 0;
int oddSum = 0;

int[] nums = input
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0)
    {
        evenSum += nums[i];
    }
    else
    {
        oddSum += nums[i];
    }
}

Console.WriteLine(evenSum - oddSum);
