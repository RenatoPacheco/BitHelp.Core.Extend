namespace BitHelp.Core.Extend.Test
{
    internal class StructValue<T>
        where T : struct
    {
        public StructValue(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public string GetDisplay()
        {
            return Value.Display();
        }

        public string GetDescription()
        {
            return Value.Description();
        }
    }
}
