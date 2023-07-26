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
            [Required(ErrorMessage = "O código do Produto é obrigatório")]
            public string IdProduto { get; set; }
            public string NomeProduto { get; set; }
            public string Categoria { get; set; }
            public int Quantidade { get; set; }
            public string CodigoBarra { get; set; }
            public int Preco { get; set; }
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
        }
        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }
    }
}
