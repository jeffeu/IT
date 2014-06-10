using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace it.ModelsDefault1
{
    public class Db : DbContext
    {
        public DbSet<Candidatos> Candidatos { get; set; }
    }
    public class Candidatos
    {
        /*Name

         
         */
        [Key]
        public int CandidatoID { get; set; }
        [Required(ErrorMessage="Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage="Sexo é obrigatório")]
        public string Sexo { get; set; }
        public string CNH { get; set; }
        public string Dependentes { get; set; }
        [Required(ErrorMessage="Data de nascimento é obrigatório")]
        public DateTime DataNasc { get; set; }
        public string EstadoCivil {get;set;}
        [Required(ErrorMessage="Telefone é obrigatório")]
        public string Telefone { get; set; }
        public string Celular { get; set; }
        [Required(ErrorMessage="E-mail é obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage="Endereço é obrigatório")]
        public string Endereco { get; set; }
        [Required(ErrorMessage="Bairro é obrigatório")]
        public string Bairro { get; set; }
        [Required(ErrorMessage="Cidade é obrigatório")]
        public string Cidade { get; set; }
        [Required(ErrorMessage="Estado é obrigatório")]
        public string Estado { get; set; }


    }
}