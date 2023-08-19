using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutosGeekBiblioteca.DataBases
{
    public class FicharioCliente
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public FicharioCliente(string Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                mensagem = "Conexão BEM-SUCEDIDA";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão como Fichário Cliente FALHOU" + ex.Message;
            }
        }

        public void Incluir(string Id, string clienteJson)
        {
            status = true;
            try
            {
                if(File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    mensagem = "Id do Cliente informado já existe! " + Id;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Id + ".json", clienteJson);
                    status = true;
                    mensagem = "Cliente cadastrado com sucesso. " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão como Fichário Produto FALHOU" + ex.Message;
            }
        }
        public void Apagar(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "Identificador não encontrado " + Id;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");
                    status = true;
                    mensagem = "Exclusão efetuada com sucesso. " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "não foi possível encontrar o Identificador " + ex.Message;
            }
        }
        public void Alterar(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "Alteração não permitida, pois o Identificador não foi encontrado " + Id;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    status = true;
                    mensagem = "Alteração efetuada com sucesso. Identificador: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "não foi possível encontrar o Identificador " + ex.Message;
            }
        }
        public string Buscar(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "O Id procurado não existe. " + Id;
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + Id + ".json");
                    status = true;
                    mensagem = "Conteúdo encontrado.";
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Não foi possível localizar o Id informado. " + ex.Message;
            }
            return "";
        }
        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();
            try
            {
                var Arquivos = Directory.GetFiles(diretorio, "*.json");
                for (int i = 0; i <= Arquivos.Length - 1; i++)
                {
                    string conteudo = File.ReadAllText(Arquivos[i]);
                    List.Add(conteudo);
                }
                return List;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            return List;
        }
    }
}
