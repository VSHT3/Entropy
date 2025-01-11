using BreakInfinity;

public static class BigDoubleFormatter
{
    public static string FormatBigDouble(BigDouble value)
    {
        if (value < 1_000)
            return value.ToString("F0"); // No decimal places for values less than 1000

        string[] suffixes = { "", "K", "M", "B", "T", "Q", "Qn", "Sx", "Sp", "O", "N" };
        int order = 0;

        // Calculate the order of magnitude
        while (value >= 1_000 && order < suffixes.Length - 1)
        {
            order++;
            value /= 1_000;
        }

        // Format the number with two decimal places if it's 1000 or greater
        return value.ToString("F2") + suffixes[order];
    }
}