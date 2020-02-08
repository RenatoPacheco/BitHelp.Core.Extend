namespace BitHelp.Core.Extend
{
    static class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new System.ArgumentNullException(nameof(args));
            }
        }
    }
}
