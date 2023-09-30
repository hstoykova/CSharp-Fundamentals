string input = Console.ReadLine();
int sum = 0;

int[] nums = input
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0)
    {
        sum += nums[i];
    }
}

Console.WriteLine(sum);