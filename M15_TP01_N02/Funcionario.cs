using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15_TP01_N02
{
    internal class Funcionario
    {
        private readonly uint _idFuncionario;
        private readonly string _nome;
        private readonly string _username;
        private readonly string _password;
        private readonly string _foto;
        private readonly string _nCc;
        private readonly string _telefone;
        private readonly string _email;
        private readonly string _observacoes;
        private readonly bool _ativo;
        private readonly DateTime _dataCriacao;
        private readonly DateTime _dataNascimento;

        public Funcionario(uint idFuncionario, string nome, string username, string password, DateTime dataNascimento, string foto, string nCc, string telefone, string email, string observacoes, DateTime dataCriacao, bool ativo)
        {
            _idFuncionario = idFuncionario;
            _nome = nome;
            _username = username;
            _password = password;
            _dataNascimento = dataNascimento;
            _foto = foto;
            _nCc = nCc;
            _telefone = telefone;
            _email = email;
            _observacoes = observacoes;
            _dataCriacao = dataCriacao;
            _ativo = ativo;
        }

        public uint GetId() => _idFuncionario;
        public string GetNome() => _nome;
        public string GetUsername() => _username;
        public string GetPassword() => _password;
        public string GetFoto() => _foto;
        public string GetNCc() => _nCc;
        public string GetTelefone() => _telefone;
        public string GetEmail() => _email;
        public string GetObservacoes() => _observacoes;
        public bool GetAtivo() => _ativo;
        public DateTime GetDataCriacao() => _dataCriacao;
        public DateTime GetDataNascimento() => _dataNascimento;

    }
}
