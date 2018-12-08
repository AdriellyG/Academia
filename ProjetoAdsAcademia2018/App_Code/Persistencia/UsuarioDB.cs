using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrição resumida de UsuarioDB
/// </summary>
public class UsuarioDB
{
    // INSERT
    public static int Insert(Usuario usuario)
    {

        int retorno = 0;
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "INSERT INTO usuario(usu_email, usu_senha, usu_datacadastro, pes_codigo, per_codigo) VALUES(?usu_email, ?usu_senha, ?usu_datacadastro, ?pes_codigo, ?per_codigo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?usu_email", usuario.Usu_email));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_senha", usuario.Usu_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_datacadastro", DateTime.Now));


            //Atenção para /fk
            objCommand.Parameters.Add(Mapped.Parameter("?pes_codigo", usuario.Pes_codigo.Pes_codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?per_codigo", usuario.Per_codigo.Per_codigo));
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
        objCommand = Mapped.Command("Select * from pessoa inner join usuario using (pes_codigo) inner join perfil using (per_codigo);", objConnection);
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
        objCommand = Mapped.Command("Select * from usuario where usu_codigo = ?id;", objConnection);
        objCommand.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds); // O objeto DataAdapter vai preencher o DataSet com os dados do BD, O método Fill é o responsável por preencher o DataSet         
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(Usuario usuario)
    {

        int retorno = 0;
        try
        {
            IDbConnection objConexao; // Abre a conexao
            IDbCommand objCommand; // Cria o comando
            string sql = "UPDATE usuario SET usu_email=?usu_email, usu_senha=?usu_senha, usu_datacadastro=?usu_datacadastro," +
                " pes_codigo=?pes_codigo, per_codigo=?per_codigo WHERE usu_codigo=?usu_codigo;";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?usu_email", usuario.Usu_email));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_senha", usuario.Usu_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_datacadastro", usuario.Usu_dataCadastro));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_codigo", usuario.Usu_codigo));

            objCommand.Parameters.Add(Mapped.Parameter("?pes_codigo", usuario.Pes_codigo.Pes_codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?per_codigo", usuario.Per_codigo.Per_codigo));
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
            string sql = "DELETE FROM usuario WHERE usu_codigo=?usu_codigo;";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?usu_codigo", codigo));
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

    public static Pessoa ValidaAcesso(string email, string senha)
    {
        Pessoa pes = null;
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataReader objDataReader;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM usuario inner join pessoa using(pes_codigo) WHERE usu_email=?email AND usu_senha=?senha;", objConnection);
        objCommand.Parameters.Add(Mapped.Parameter("?email", email));
        objCommand.Parameters.Add(Mapped.Parameter("?senha", senha));
        objDataReader = objCommand.ExecuteReader();
        while (objDataReader.Read())
        {
            pes = new Pessoa();
            pes.Pes_codigo = Convert.ToInt32(objDataReader["pes_codigo"]);
            pes.Pes_nome = Convert.ToString(objDataReader["pes_nome"]);
            pes.Pes_cpf = Convert.ToString(objDataReader["pes_cpf"]);
            pes.Pes_rg = Convert.ToString(objDataReader["pes_rg"]);
            pes.Usuario = new Usuario();
            pes.Usuario.Usu_codigo = Convert.ToInt32(objDataReader["usu_codigo"]);
            pes.Usuario.Usu_email = Convert.ToString(objDataReader["usu_email"]);
            pes.Usuario.Usu_senha = Convert.ToString(objDataReader["usu_senha"]);
            //pes.Usuario.Per_codigo.Per_descricaoPerfil = Convert.ToString(objDataReader["usu_perfil"]);
            pes.Usuario.Usu_dataCadastro = Convert.ToDateTime(objDataReader["usu_datacadastro"]);
        }
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return pes;
    }
}