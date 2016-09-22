using System;

namespace AutoCode.Config
{
    public static class Config
    {
        public static string ConvertDbType(String dbType)
        {
            string returnValue;
            switch (dbType.ToLower())
            {
                case "bigint":
                    returnValue = "Int64?";
                    break;
                case "binary":
                    returnValue = "Byte[]";
                    break;
                case "bit":
                    returnValue = "bool?";
                    break;
                case "datetime":
                    returnValue = "DateTime?";
                    break;
                case "date":
                    returnValue = "DateTime?";
                    break;
                case "decimal":
                    returnValue = "decimal?";
                    break;
                case "float":
                    returnValue = "double?";
                    break;
                case "image":
                    returnValue = "Byte[]";
                    break;
                case "int":
                    returnValue = "int?";
                    break;
                case "money":
                    returnValue = "Single?";
                    break;
                case "numeric":
                    returnValue = "decimal?";
                    break;
                case "real":
                    returnValue = "Single?";
                    break;
                case "smalldatetime":
                    returnValue = "DateTime?";
                    break;
                case "smallint":
                    returnValue = "Int16?";
                    break;
                case "smallmoney":
                    returnValue = "Single?";
                    break;
                case "timestamp":
                    returnValue = "Byte[]";
                    break;
                case "tinyint":
                    returnValue = "byte?";
                    break;
                case "uniqueidentifier":
                    returnValue = "Guid?";
                    break;
                case "varbinary":
                    returnValue = "Byte[]";
                    break;
                case "char":
                case "nchar":
                case "ntext":
                case "nvarchar":
                case "text":
                case "varchar":               
                    returnValue = "string";
                    break;
                default:
                    returnValue = "object";
                    break;
            }

            return returnValue;
        }

        public static string IsPkid(string ispkid)
        {
            return ispkid.Equals("1") ? "true" : "false";
        }
    }
}
