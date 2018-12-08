using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Usuario
/// </summary>
public class Usuario
{
    private int usu_codigo;
    private string usu_email;
    private string usu_senha;
    private DateTime usu_dataCadastro;

    //Fk
    private Perfil per_codigo;
    private Pessoa pes_codigo;

    public int Usu_codigo { get => usu_codigo; set => usu_codigo = value; }
    public string Usu_email { get => usu_email; set => usu_email = value; }
    public string Usu_senha { get => usu_senha; set => usu_senha = value; }
    public DateTime Usu_dataCadastro { get => usu_dataCadastro; set => usu_dataCadastro = value; }
    public global::Perfil Per_codigo { get => per_codigo; set => per_codigo = value; }
    public global::Pessoa Pes_codigo { get => pes_codigo; set => pes_codigo = value; }
}