using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using LojaProdutosGeekBiblioteca.Classes;
using System.IO;
using Newtonsoft.Json;
using LojaProdutosGeekBiblioteca.DataBases;

namespace LojaProdutosGeekBiblioteca
{
    public class Cliente
    {
        public class Unit
        {

            [Required(ErrorMessage = "Código do Cliente é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do Cliente somente aceita valores numéricos.")]
            [StringLength(5, MinimumLength = 5, ErrorMessage = "Código do Cliente deve ter 5 dígitos.")]
            public string IdCliente { get; set; }

            [Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
            public string NomeCliente { get; set;}

            [Required(ErrorMessage = "Data do cadastro é obrigatório.")]
            [RegularExpression("(^([0-2][0-9]|(3)[0-1])(\\/)(((0)[0-9])|((1)[0-2]))(\\/)\\d{4}$)", ErrorMessage = "Data de Cadastro deve conter somente datas válidas.")]
            [StringLength(10,MinimumLength = 10, ErrorMessage = "Data inválida.")]
            public string DtCadastro { get; set;}

            [Required(ErrorMessage = "RG obrigatório.")]
            [RegularExpression("(^\\d{1,2}).?(\\d{3}).?(\\d{3})-?(\\d{1}|X|x$)", ErrorMessage = "Data de Cadastro deve conter somente datas válidas.")]
            [StringLength(9, MinimumLength = 9, ErrorMessage = "RG deve ter 9 dígitos.")]
            public string Rg { get; set; }

            [Required(ErrorMessage = "CPF obrigatório.")]
            [RegularExpression("(^\\d{3}\\.\\d{3}\\.\\d{3}\\-\\d{2}$)", ErrorMessage = "CPF somente aceita valores numéricos.")]
            [StringLength(14, MinimumLength = 14, ErrorMessage = "CPF deve ter 11 dígitos.")]
            public string Cpf { get; set; }

            [Required(ErrorMessage = "Telefone obrigatório.")]
            [RegularExpression("(\\([0-9][0-9]\\)[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9])", ErrorMessage = "Telefone incorreto.")]
            [StringLength(13, MinimumLength = 13, ErrorMessage = "Telefone deve ter 11 dígitos.")]
            public string Telefone { get; set; }

            [Required(ErrorMessage = "Genero obrigatório.")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "CEP obrigatório.")]
            [RegularExpression("(^\\d{2}\\d{3}[-]\\d{3}$)", ErrorMessage = "CEP somente aceita valores numéricos.")]
            [StringLength(9, MinimumLength = 9, ErrorMessage = "CEP deve ter 8 dígitos.")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "Rua é obrigatória.")]
            [StringLength(100, ErrorMessage = "Rua deve ter no máximo 100 caracteres.")]
            public string Rua { get; set; }

            [RegularExpression("([0-9]+)", ErrorMessage = "Código do Cliente somente aceita valores numéricos.")]
            public string Numero { get; set; }

            [Required(ErrorMessage = "Complemento é obrigatório.")]
            [StringLength(100, ErrorMessage = "Complemento deve ter no máximo 100 caracteres.")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Bairro é obrigatório.")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres.")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Cidade é obrigatória.")]
            [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres.")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Estado é obrigatório.")]
            [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 caracteres.")]
            public string Estado { get; set; }

            public void ValidaClasseCliente()
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
            public void ValidaCPF()
            {
                bool valida = Cls_Uteis.ValidaCPF(this.Cpf);
                if(valida == false)
                {
                    throw new Exception("Cpf Inválido");
                }
            }
            #region "CRUD fichario CLiente"
            public void IncluirFichario(string ConexaoCaminho)
            {
                string clienteJson = Cliente.Serializar(this);
                FicharioCliente F = new FicharioCliente(ConexaoCaminho);
                if (F.status)
                {
                    F.Incluir(this.IdCliente, clienteJson);
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
                FicharioCliente F = new FicharioCliente(conexaoCaminho);
                if (F.status)
                {
                    string clienteJson = F.Buscar(Id);
                    return Cliente.Desserializar(clienteJson);
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void AlterarFichario(string ConexaoCaminho)
            {
                string clienteJson = Cliente.Serializar(this);
                FicharioCliente F = new FicharioCliente(ConexaoCaminho);
                if (F.status)
                {
                    F.Alterar(this.IdCliente, clienteJson);
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
                FicharioCliente F = new FicharioCliente(ConexaoCaminho);
                if (F.status)
                {
                    F.Apagar(this.IdCliente);
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
                FicharioCliente F = new FicharioCliente(ConexaoCaminho);
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
            public List<Unit> LIstUnit { get; set; }
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
