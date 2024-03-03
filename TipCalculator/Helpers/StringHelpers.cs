using System;

namespace TipCalculator.Helpers
{
    public class StringHelper
    {
        public static string GetOperator(string command)
        {
            string op = "";
            if (string.IsNullOrEmpty(command))
                return op;

            switch (command.ToLower())
            {
                case "10":
                    op = "10%";
                    break;
                case "15":
                    op = "15%";
                    break;
                case "20":
                    op = "20%";
                    break;
                default:
                    break;
            }

            return op;
        }
    }
}