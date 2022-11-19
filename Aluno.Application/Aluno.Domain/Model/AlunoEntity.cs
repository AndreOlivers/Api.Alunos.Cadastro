using Aluno.Domain.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Domain.Model
{
    public class AlunoEntity : EntityBase
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }

        //public Aluno(string nome)
        //{
        //    if (nome == null)
        //    {
        //        ValidateNomeDomain(nome);
        //    }
        //    else
        //    {
        //        SetNome(nome);
        //    }
        //}

        #region Regra de Negócio
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        #endregion

        #region validações
        public void ValidateNomeDomain(string nome)
        {
            DomainExceptioValidator.When(string.IsNullOrEmpty(nome),
                "Nome inválido, o nome é requirido");

            DomainExceptioValidator.When(nome.Length < 3,
                "Nome inválido, o nome precisa ter no minimo 3 caracteres");
        }

        public void ValidateIdadeDomain(int idade)
        {
            DomainExceptioValidator.When(idade <= 0,
              "A idade não pode ser menor ou igual a do que zero");
        }

        public void ValidateEmailDomain(string email)
        {
            DomainExceptioValidator.When(string.IsNullOrEmpty(email),
                 "Email inválido, o email é requirido");

            DomainExceptioValidator.When(email.Length < 3,
                "Email inválido, o email precisa ter no minimo 3 caracteres");
        }
        #endregion
    }
}
