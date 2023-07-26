using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LojaProdutosGeekBiblioteca
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage ="O código do Cliente é obrigatório")]
            public string IdCliente { get; set; }
            public string NomeCliente { get; set;}
            public string DtCadastro { get; set;}
            public string Rg { get; set; }
            public string Cpf { get; set; }
            public string Telefone { get; set; }
            public int Genero { get; set; }
            public string Cep { get; set; }
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
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
        }

        public class List
        {
            public List<Unit> LIstUnit { get; set; }
        }
    }
}
