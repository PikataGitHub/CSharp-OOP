namespace ExtensionMethods_01_02.Extensions
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder inputStringBuilder, int index, int lenght)
        {
            StringBuilder outputStringBuilder = new StringBuilder();

            for (int i = index; i < (index + lenght); i++)
            {
               outputStringBuilder.Append(inputStringBuilder[i]);
            }

            return outputStringBuilder;
        }
    }
}
