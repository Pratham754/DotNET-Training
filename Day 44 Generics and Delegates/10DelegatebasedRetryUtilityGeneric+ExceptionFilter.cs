using System;

public class Program
{
    private static int _tries = 0;                    // Simulation counter

    public static void Main()
    {
        // A function that fails twice, then succeeds
        int result = ExecuteWithRetry(() =>
        {
            _tries++;
            if (_tries <= 2) throw new InvalidOperationException("Temporary failure");
            return 999;
        }, maxAttempts: 3);

        Console.WriteLine(result);                    // Expected: 999
    }

    // ✅ TODO: Students implement only this function
    public static T ExecuteWithRetry<T>(Func<T> work, int maxAttempts)
    {
        // TODO:
        // 1) Validate inputs
        ArgumentNullException.ThrowIfNull(work);
        if (maxAttempts <= 0) throw new ArgumentOutOfRangeException(nameof(maxAttempts), "must  be > 0");
        Exception? lastException = null;

        // 2) Try executing work
        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
        // 3) If exception occurs and attempts remain, retry
            try
            {
                return work();
            }
            catch (Exception ex)
            {
                lastException = ex;
                if (attempt == maxAttempts){break;}
            }
        }
        // 4) If attempts exhausted, throw last exception
        throw new Exception("All tries expired: ",lastException);
    }
}