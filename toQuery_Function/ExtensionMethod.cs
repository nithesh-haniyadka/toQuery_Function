namespace ExtensionMethods
{
    public static class ExtMethodClass
    {
        public static int ToCurrency(this string str)
        {
            return Int32.Parse(str);
        }
    }
}