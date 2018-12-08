using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Importar biblioteca
using System.Data;

/// <summary>
/// Descrição resumida de EnderecoDB
/// </summary>
public class EnderecoDB
{
    public static int Insert(Endereco endereco)
    {

        int retorno = 0;
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO endereco(end_rua, end_numero, end_bairro, end_cidade, end_estado, end_cep, pes_codigo) " +
                "VALUES(?end_rua, ?end_numero, ?end_bairro, ?end_cidade, ?end_estado, ?end_cep, ?pes_codigo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?end_rua", endereco.End_rua));
            objCommand.Parameters.Add(Mapped.Parameter("?end_numero", endereco.End_numero));
            objCommand.Parameters.Add(Mapped.Parameter("?end_bairro", endereco.End_bairro));
            objCommand.Parameters.Add(Mapped.Parameter("?end_cidade", endereco.End_cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?end_estado", endereco.End_estado));
            objCommand.Parameters.Add(Mapped.Parameter("?end_cep", endereco.End_cep));
            
            //Atenção para /fk
            objCommand.Parameters.Add(Mapped.Parameter("?pes_codigo", endereco.Pes_codigo.Pes_codigo));
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
        objCommand = Mapped.Command("Select * from pessoa inner join endereco using (pes_codigo)", objConnection);
        //objCommand = Mapped.Command("SELECT * FROM endereco ORDER BY End_rua, End_numero, End_bairro, End_cidade, End_estado, End_cep", objConnection);
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
        objCommand = Mapped.Command("Select * from endereco where end_codigo = ?id;", objConnection);
        objCommand.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds); // O objeto DataAdapter vai preencher o DataSet com os dados do BD, O método Fill é o responsável por preencher o DataSet         
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(Endereco endereco)
    {

        int retorno = 0;
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE endereco SET end_rua=?end_rua, end_numero=?end_numero, end_bairro=?end_bairro, " +
                "end_cidade=?end_cidade, end_estado=?end_estado, end_cep=?end_cep," +
                " pes_codigo=?pes_codigo WHERE end_codigo=?end_codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?end_rua", endereco.End_rua));
            objCommand.Parameters.Add(Mapped.Parameter("?end_numero", endereco.End_numero));
            objCommand.Parameters.Add(Mapped.Parameter("?end_bairro", endereco.End_bairro));
            objCommand.Parameters.Add(Mapped.Parameter("?end_cidade", endereco.End_cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?end_estado", endereco.End_estado));
            objCommand.Parameters.Add(Mapped.Parameter("?end_cep", endereco.End_cep));
            objCommand.Parameters.Add(Mapped.Parameter("?end_codigo", endereco.End_codigo));
            //FK 
            objCommand.Parameters.Add(Mapped.Parameter("?pes_codigo", endereco.Pes_codigo.Pes_codigo));

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
            string sql = "DELETE FROM endereco WHERE end_codigo=?end_codigo;";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?end_codigo", codigo));
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