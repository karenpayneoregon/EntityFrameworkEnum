using System;
using System.Data.SqlClient;
using System.Text;

namespace EnumGeneratorLibrary
{
    public class Generator
    {
        /// <summary>
        /// Create an enum from a reference table using the primary key
        /// as a value for a enum member and a description field name for
        /// the enum name.
        /// </summary>
        /// <param name="pServerName">Server name e.g. .\SQLEXPRESS</param>
        /// <param name="pDatabase">Database containing table to create enum</param>
        /// <param name="pTable">Table name under pServerName, pDatabase to create enum</param>
        /// <param name="pIdentifier">Primary key in pTable</param>
        /// <param name="pName">Description/name of enum</param>
        /// <returns></returns>
        public string Create(
            string pServerName, 
            string pDatabase, string pTable, 
            string pIdentifier, 
            string pName)
        {
            var builder = new StringBuilder();

            var connectionString = 
                $"Data Source={pServerName};Initial Catalog={pDatabase};Integrated Security=True";

            using (var cn = new SqlConnection {ConnectionString = connectionString })
            {
                var selectStatement = $"SELECT {pIdentifier},{pName} FROM {pTable}";
                using (var cmd = new SqlCommand{Connection = cn, CommandText = selectStatement })
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        builder.AppendLine($"public enum {pTable}");
                        builder.AppendLine("{");
                        while (reader.Read())
                        {
                            builder.AppendLine(
                                $"    {reader.GetString(1).Replace(" ","")} = " +
                                $"{reader.GetInt32(0)},");
                        }

                        builder.AppendLine("};");

                        return ReplaceLastOccurrence(builder.ToString(),",","");
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        }
        public string ReplaceLastOccurrence(string pSource, string pFind, string pReplace)
        {
            var place = pSource.LastIndexOf(pFind, StringComparison.Ordinal);

            if (place == -1)
            {
                return pSource;
            }

            var result = pSource.Remove(place, pFind.Length).Insert(place, pReplace);
            return result;
        }
    }
}
