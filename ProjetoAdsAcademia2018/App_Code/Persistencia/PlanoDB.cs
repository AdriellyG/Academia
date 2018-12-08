using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrição resumida de PlanoDB
/// </summary>
public class PlanoDB
{
    // INSERT
    public static int Insert(Plano plano)
    {

        int retorno = 0;
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO plano(pla_datavencimento, cli_codigo, ser_codigo) " +
                "VALUES(?pla_datavencimento, ?cli_codigo, ?ser_codigo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pla_datavencimento", plano.Pla_dataVencimento));


            //Atenção para /fk
            objCommand.Parameters.Add(Mapped.Parameter("?cli_codigo", plano.Cli_codigo.Cli_codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_codigo", plano.Ser_codigo.Ser_codigo));
            objCommand.ExecuteNonQuery(); // utilizado quando cdigo não tem retorno, como seria o caso do SELECT
            //Fecha a conexão
            objConexao.Close();
            //Disponibiliza o objeto conexão e o objeto comando para serem utilizados novamente –limpando a memória
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception e)
        {
            retorno = -2;
        }
        return retorno;
    }

    // BUSCA
    public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("Select * from cliente inner join plano using (cli_codigo) inner join servico using (ser_codigo);", objConnection);
        //objCommand = Mapped.Command("Select * from pessoa inner join usuario using (pes_codigo);", objConnection);
        //objCommand = Mapped.Command("Select * from perfil inner join usuario using (per_codigo);", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds); // O objeto DataAdapter vai preencher o DataSet com os dados do BD, O método Fill é o responsável por preencher o DataSet         
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static DataSet SelectID(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("Select * from plano where pla_codigo = ?id;", objConnection);
        objCommand.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds); // O objeto DataAdapter vai preencher o DataSet com os dados do BD, O método Fill é o responsável por preencher o DataSet         
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(Plano plano)
    {

        int retorno = 0;
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE plano SET pla_datavencimento=?pla_datavencimento, cli_codigo=?cli_codigo, ser_codigo=?ser_codigo" +
                " WHERE pla_codigo=?pla_codigo;";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pla_datavencimento", plano.Pla_dataVencimento));
            objCommand.Parameters.Add(Mapped.Parameter("?pla_codigo", plano.Pla_codigo));

            objCommand.Parameters.Add(Mapped.Parameter("?cli_codigo", plano.Cli_codigo.Cli_codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_codigo", plano.Ser_codigo.Ser_codigo));
            objCommand.ExecuteNonQuery(); // utilizado quando cdigo não tem retorno, como seria o caso do SELECT
            //Fecha a conexão
            objConexao.Close();
            //Disponibiliza o objeto conexão e o objeto comando para serem utilizados novamente –limpando a memória
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception e)
        {
            retorno = -2;
        }
        return retorno;
    }

    public static int Delete(int codigo)
    {

        int retorno = 0;
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "DELETE FROM plano WHERE pla_codigo=?pla_codigo;";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pla_codigo", codigo));
            objCommand.ExecuteNonQuery(); // utilizado quando cdigo não tem retorno, como seria o caso do SELECT
            //Fecha a conexão
            objConexao.Close();
            //Disponibiliza o objeto conexão e o objeto comando para serem utilizados novamente –limpando a memória
            objCommand.Dispose();
            objConexao.Dispose();
        }
        catch (Exception e)
        {
            retorno = -2;
        }
        return retorno;
    }
}