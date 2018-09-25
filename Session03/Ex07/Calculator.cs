namespace Ex07
{
    public static class Calculator
    {
        public static int Add(params int[] values)
        {
            int result = 0;
            foreach (var value in values)
            {
                result += value;
            }

            return result;
        }
    }
}