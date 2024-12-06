using System.Data.SqlTypes;
using System.IO;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlBoolean fncArquivo_Existe(SqlString Ds_Arquivo)
    {
        return File.Exists(Ds_Arquivo.ToString());
    }
}