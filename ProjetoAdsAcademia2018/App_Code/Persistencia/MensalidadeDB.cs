using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrição resumida de MensalidadeDB
/// </summary>
public class MensalidadeDB
{
    public static int Insert(Mensalidade mensalidade)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO mensalidade(men_valor, men_datapamento, men_status, ser_codigo) " +
            "VALUES(?men_valor, ?men_datapamento, ?men_status, ?ser_codigo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?men_valor", mensalidade.Men_valor));
            objCommand.Parameters.Add(Mapped.Parameter("?men_datapamento", mensalidade.Men_dataPagamento));
            objCommand.Parameters.Add(Mapped.Parameter("?men_status", mensalidade.Men_status));

            //Atenção para /fk
            objCommand.Parameters.Add(Mapped.Parameter("?ser_codigo", mensalidade.Ser_codigo.Ser_codigo));
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

    public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("Select * from servico inner join mensalidade using (ser_codigo) order by men_codigo", objConnection);
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
        objCommand = Mapped.Command("Select * from mensalidade where men_codigo = ?id;", objConnection);
        objCommand.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds); // O objeto DataAdapter vai preencher o DataSet com os dados do BD, O método Fill é o responsável por preencher o DataSet         
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(Mensalidade mensalidade)
    {

        int retorno = 0;
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE mensalidade SET men_valor=?men_valor, men_datapamento=?men_datapamento, men_status=?men_status," +
                " ser_codigo=?ser_codigo WHERE men_codigo=?men_codigo;";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?men_valor", mensalidade.Men_valor));
            objCommand.Parameters.Add(Mapped.Parameter("?men_datapamento", mensalidade.Men_dataPagamento));
            objCommand.Parameters.Add(Mapped.Parameter("?men_status", mensalidade.Men_status));
            objCommand.Parameters.Add(Mapped.Parameter("?men_codigo", mensalidade.Men_codigo));

            objCommand.Parameters.Add(Mapped.Parameter("?ser_codigo", mensalidade.Ser_codigo.Ser_codigo));

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
            string sql = "DELETE FROM mensalidade WHERE men_codigo=?men_codigo;";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?men_codigo", codigo));
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