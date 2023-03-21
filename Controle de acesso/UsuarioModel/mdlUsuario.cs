﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioModel
{
	//Model de usuário
	public class mdlUsuario
	{
		//Atributos
		public string nome { get; set; }
		public string senha { get; set; }
		public static string staticNome { get; set; }
		public static string staticSenha { get; set; }
		public mdlUsuario(string nome, string senha)
		{
			this.nome = nome;
			this.senha = senha;
			staticNome = nome;
			staticSenha = senha;
		}
		public static string getNome()
		{
			return staticNome;
		}
		public static string getSenha() 
		{ 
		return staticSenha;
		}
	}
}
