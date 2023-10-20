using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutosGeekBiblioteca.DataBases
{
    public class FicharioDBCliente
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public LocalDBClass db;

        public FicharioDBCliente(string Tabela)
        {
            status = true;
            try
            {
                db = new LocalDBClass();
                tabela = Tabela;
                mensagem = "Conexão com a tabela com sucesso";

            }
            catch (Exception Ex)
            {
                mensagem = "Conexão com a tabela com erro: " + Ex.Message;
            }
        }

        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                //INSERT INTO CLIENTE (ID,JSON) VALUES ('000001',{...})
                var SQL = "INSERT INTO " + tabela + "(Id,JSON) VALUES ('" + Id + "', '" + jsonUnit + "')";
                db.SQLCommand(SQL);
                status = true;
                mensagem = "Inclusão efetuada com sucesso. Identificador: " + Id;

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }

        public string Buscar(string Id)
        {
            status = true;
            try
            {
                // SELECT ID, JSON FROM CLIENTE WHERE ID = '000010'
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + Id;
                    return conteudo;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            return "";
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();
            try
            {
                //SELECT ID, JSON FROM CLIENTE
                var SQL = "SELECT Id, JSON FROM " + tabela;
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        string conteudo = dt.Rows[i]["JSON"].ToString();
                        List.Add(conteudo);
                    }
                    return List;
                }
                else
                {
                    status = false;
                    mensagem = "Não existe clientes na base de dados";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            return List;
        }

        public void Apagar(string Id)
        {
            status = true;
            try
            {
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    //DELETE FROM CLIENTE WHERE ID = '000010'
                    SQL = "DELETE FROM " + tabela + "WHERE ID = '" + Id + "'";
                    status = true;
                    mensagem = "Cliente apagado da base de dados";
                }
                else
                {
                    status = false;
                    mensagem = "Não existe o Identificadro informado " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
        }

        public void Alterar(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    //UPDATE CLIENTE SET JSON = '{...}' WHERE ID = '000010'
                    SQL = "UPDATE " + tabela + " SET JSON = '" + jsonUnit + "' WHERE ID = '" + Id + "'";
                    status = true;
                    mensagem = "Alteração feita com suvcesso";
                }
                else
                {
                    status = false;
                    mensagem = "Alteração não permitida pois o identificador não existe " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }
    }
}
