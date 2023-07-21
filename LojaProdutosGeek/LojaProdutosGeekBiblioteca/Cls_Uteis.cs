using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutosGeekBiblioteca
{
    public class Cls_Uteis
    {
        public static bool ValidaAcesso(string login, string senha)
        {
            if((login == "Admin") && (senha == "123Mudar"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
