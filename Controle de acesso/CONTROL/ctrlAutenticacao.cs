using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using MODEL;

//Controle de autenticação
namespace CONTROL
{
    public class ctrlAutenticacao
    {
        //Método de autenticação
        public static bool Autenticar(mdlUsuario dados)
        {
            return daoUsuario.Autenticar(dados);
        }
    }
}
