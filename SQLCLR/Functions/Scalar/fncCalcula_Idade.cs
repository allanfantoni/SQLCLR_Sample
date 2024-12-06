using System.Data.SqlTypes;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlInt32 fncCalcula_Idade(SqlDateTime Dt_Nascimento, SqlDateTime Dt_Hoje)
    {
        if (Dt_Nascimento.IsNull || Dt_Hoje.IsNull)
            return SqlInt32.Null;

        var anos = Dt_Hoje.Value.Year - Dt_Nascimento.Value.Year;

        if (Dt_Hoje.Value.Month < Dt_Nascimento.Value.Month || (Dt_Hoje.Value.Month == Dt_Nascimento.Value.Month && Dt_Hoje.Value.Day < Dt_Nascimento.Value.Day))
            anos--;

        return anos;
    }
}