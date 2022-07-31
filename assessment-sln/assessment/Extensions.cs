using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace assessment
{
    public static class Extensions
    {
        /// <summary>
        /// Gets a string from a IDataReader given the column name, returns null if the value is null
        /// </summary>
        /// <param name="rdr"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static string GetString(this IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
                return null;
            return rdr.GetString(ordinal);
        }

        public static int GetInt32(this IDataReader rdr, string columnName)
        {
            int ordinal = rdr.GetOrdinal(columnName);
            if (rdr.IsDBNull(ordinal))
                return 0;
            return rdr.GetInt32(ordinal);
        }
    }
}