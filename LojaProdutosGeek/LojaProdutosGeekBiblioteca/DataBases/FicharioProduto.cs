using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutosGeekBiblioteca.DataBases
{
    public class FicharioProduto
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public FicharioProduto(string Diretorio)
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
                mensagem = "Conexão com o Fichário Produto FALHOU" + ex.Message;
            }
        }

        public void Incluir(string Id, string produtoJson)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    mensagem = "Id do Produto informado já existe! " + Id;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Id + ".json", produtoJson);
                    status = true;
                    mensagem = "Produto cadastrado com sucesso. " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão como Fichário Produto FALHOU" + ex.Message;
            }
        }
    }
}
