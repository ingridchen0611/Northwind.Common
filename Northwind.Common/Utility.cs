using System;

namespace Northwind.Common
{
    public class Utility
    {
        public static string GetErrorMessage(Exception ex)
        {
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            return ex.Message;
        }
    }
}
