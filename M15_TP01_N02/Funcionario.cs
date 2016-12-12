using System;

namespace M15_TP01_N02
{
    internal class Funcionario
    {
        private readonly uint _idFuncionario;
        private readonly string _nome;
        private readonly string _username;
        private readonly string _password;
        private readonly DateTime _dataNascimento;
        private readonly string _foto;
        private readonly string _nCC;
        private readonly string _telefone;
        private readonly string _email;
        private readonly string _observacoes;
        private readonly DateTime _dataCriacao;
        private readonly DateTime _ultimoUpdate;
        private readonly bool _ativo;

        public Funcionario(uint idFuncionario, string nome, string username, string password, DateTime dataNascimento, string foto, string nCc, string telefone, string email, DateTime dataCriacao, string observacoes, DateTime ultimoUpdate, bool ativo)
        {
            _idFuncionario = idFuncionario;
            _nome = nome;
            _username = username;
            _password = password;
            _dataNascimento = dataNascimento;
            _foto = foto;
            _nCC = nCc;
            _telefone = telefone;
            _email = email;
            _dataCriacao = dataCriacao;
            _observacoes = observacoes;
            _ultimoUpdate = ultimoUpdate;
            _ativo = ativo;
        }

        public uint GetIdFuncionario() => _idFuncionario;
        public string GetNome() => _nome;
        public string GetUsername() => _username;
        public string GetPassword() => _password;
        public DateTime GetDataNascimento() => _dataNascimento;
        public string GetFoto() => _foto;
        public string GetNCC() => _nCC;
        public string GetTelefone() => _telefone;
        public string GetEmail() => _email;
        public string GetObservacoes() => _observacoes;
        public DateTime GetDataCriacao() => _dataCriacao;
        public DateTime GetUltimoUpdate() => _ultimoUpdate;
        public bool GetAtivo() => _ativo;
    }
}
