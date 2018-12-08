using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Importar biblioteca
using System.Data;
/// <summary>
/// Descrição resumida de AcademiaDB
/// </summary>
public class AcademiaDB
{
    // INSERT
    public static int Insert(Academia academia)
    {

        int retorno = 0;
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO academia(aca_nomefantasia, aca_razaosocial, aca_cnpj) VALUES(?aca_nomefantasia, ?aca_razaosocial, ?aca_cnpj)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?aca_nomefantasia", academia.Aca_nomeFantasia));
            objCommand.Parameters.Add(Mapped.Parameter("?aca_razaosocial", academia.Aca_razaoSocial));
            objCommand.Parameters.Add(Mapped.Parameter("?aca_cnpj", academia.Aca_cnpj));
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
        objCommand = Mapped.Command("SELECT * FROM academia ORDER BY Aca_nomefantasia, Aca_razaosocial, Aca_cnpj", objConnection);
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
        objCommand = Mapped.Command("Select * from academia where aca_codigo = ?id;", objConnection);
        objCommand.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds); // O objeto DataAdapter vai preencher o DataSet com os dados do BD, O método Fill é o responsável por preencher o DataSet         
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(Academia academia)
    {

        int retorno = 0;
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE academia SET aca_nomefantasia=?aca_nomefantasia, aca_razaosocial=?aca_razaosocial, aca_cnpj=?aca_cnpj" +
                "WHERE aca_codigo=?aca_codigo;";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?aca_nomefantasia", academia.Aca_nomeFantasia));
            objCommand.Parameters.Add(Mapped.Parameter("?aca_razaosocial", academia.Aca_razaoSocial));
            objCommand.Parameters.Add(Mapped.Parameter("?aca_cnpj", academia.Aca_cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?aca_codigo", academia.Aca_codigo));

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
            string sql = "DELETE FROM academia WHERE aca_codigo=?aca_codigo;";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?aca_codigo", codigo));
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