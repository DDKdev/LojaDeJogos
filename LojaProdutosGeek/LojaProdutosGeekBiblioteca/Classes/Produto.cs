using LojaProdutosGeekBiblioteca.DataBases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutosGeekBiblioteca
{
    public class Produto
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do Produto é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do Produto somente aceita valores numéricos.")]
            [StringLength(5, MinimumLength = 5, ErrorMessage = "Código do Produto deve ter 5 dígitos.")]
            public string IdProduto { get; set; }

            [Required(ErrorMessage = "Nome do produto é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome do produto deve ter no máximo 50 caracteres.")]
            public string NomeProduto { get; set; }

            [Required(ErrorMessage = "Selecionar categoria é obrigatório.")]
            public int Categoria { get; set; }

            [Required(ErrorMessage = "Campo quantidade é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Campo quantidade somente aceita valores numéricos.")]
            public string Quantidade { get; set; }

            [Required(ErrorMessage = "Código de Barras é obrigatório.")]
            [StringLength(15, MinimumLength = 15, ErrorMessage = "Código de Barras deve ter 15 caracteres.")]
            public string CodigoBarra { get; set; }

            [Required(ErrorMessage = "Preço é obrigatória.")]
            [Range(0, double.MaxValue, ErrorMessage = "Preço deve ser um valor positivo.")]
            public Double Preco { get; set; }

            [Required(ErrorMessage = "Nome do Fabricante é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome do Fabricante deve ter no máximo 50 caracteres.")]
            public string Fabricante { get; set; }

            //Criar uma subclasse ou superclasse para depois adicionar
            //as propriedades plataforma e garantia somente nos jogos e acessórios
            public string Plataforma { get; set; }
            public string Garantia { get; set; }

            public void ValidaClasseProduto()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }
            #region "CRUD Fichario Produto"
            public void IncluirFichario(string ConexaoCaminho)
            {
                string produtoJson = Produto.Serializar(this);
                FicharioProduto F = new FicharioProduto(ConexaoCaminho);
                if (F.status)
                {
                    F.Incluir(this.IdProduto, produtoJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            public Unit BuscarFichario(string Id, string conexaoCaminho)
            {
                FicharioProduto F = new FicharioProduto(conexaoCaminho);
                if (F.status)
                {
                    string produtoJson = F.Buscar(Id);
                    return Produto.Desserializar(produtoJson);
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void AlterarFichario(string ConexaoCaminho)
            {
                string produtoJson = Produto.Serializar(this);
                FicharioProduto F = new FicharioProduto(ConexaoCaminho);
                if (F.status)
                {
                    F.Alterar(this.IdProduto, produtoJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            public void ApagarFichario(string ConexaoCaminho)
            {
                FicharioProduto F = new FicharioProduto(ConexaoCaminho);
                if (F.status)
                {
                    F.Apagar(this.IdProduto);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            public List<string> BuscarTodosFichario(string ConexaoCaminho)
            {
                FicharioProduto F = new FicharioProduto(ConexaoCaminho);
                if (F.status)
                {
                    List<string> TodosJson = F.BuscarTodos();
                    return TodosJson;
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            #endregion
        }
        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

        public static Unit Desserializar(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        public static string Serializar(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
