using System;

namespace M15_TP01_N02
{
    public class Client
    {
        private readonly uint _idCliente;
        private readonly string _nome;
        private readonly string _morada;
        private readonly string _codigoPostal;
        private readonly string _localidade;
        private readonly string _telefone;
        private readonly string _fax;
        private readonly string _telemovel;
        private readonly string _email;
        private readonly string _site;
        private readonly string _representante;
        private readonly string _observacoes;
        private readonly DateTime _dataCriacao;
        private readonly DateTime _ultimoUpdate;
        private readonly bool _ativo;

        public Client(uint idCliente, string nome, string morada, string codigoPostal, string localidade, string telefone, string fax, string telemovel, string email, string site, string representante, string observacoes, DateTime dataCriacao, DateTime ultimoUpdate, bool ativo)
        {
            _idCliente = idCliente;
            _nome = nome;
            _morada = morada;
            _codigoPostal = codigoPostal;
            _localidade = localidade;
            _telefone = telefone;
            _fax = fax;
            _telemovel = telemovel;
            _email = email;
            _site = site;
            _representante = representante;
            _observacoes = observacoes;
            _dataCriacao = dataCriacao;
            _ultimoUpdate = ultimoUpdate;
            _ativo = ativo;
        }

        public uint GetIdCliente() => _idCliente;
        public string GetNome() => _nome;
        public string GetMorada() => _morada;
        public string GetCodigoPostal() => _codigoPostal;
        public string GetLocalidade() => _localidade;
        public string GetTelefone() => _telefone;
        public string GetFax() => _fax;
        public string GetTelemovel() => _telemovel;
        public string GetEmail() => _email;
        public string GetSite() => _site;
        public string GetRepresentante() => _representante;
        public string GetObservacoes() => _observacoes;
        public DateTime GetDataCriacao() => _dataCriacao;
        public DateTime GetUltimoUpdate() => _ultimoUpdate;
        public bool GetAtivo() => _ativo;

        public override string ToString()
        {
            return _nome;
        }
    }
}