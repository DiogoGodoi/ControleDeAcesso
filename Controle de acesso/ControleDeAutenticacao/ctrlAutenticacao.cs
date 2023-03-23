using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioDao;
using UsuarioModel;

//Controle de autenticação
namespace ControleDeAutenticacao
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
