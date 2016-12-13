using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15_TP01_N02
{
    public class Machines
    {
        private readonly uint _idMaquina;
        private readonly uint _idCliente;
        private readonly string _descricao;
        private readonly string _ip;
        private readonly string _loginAcesso;
        private readonly string _passwordAcesso;
        private readonly DateTime _dataCriacao;
        private readonly DateTime _ultimoUpdate;
        private readonly bool _ativo;

        public Machines(uint idMaquina, uint idCliente, string descricao, string ip, string loginAcesso, string passwordAcesso, DateTime dataCriacao, DateTime ultimoUpdate, bool ativo)
        {
            _idMaquina = idMaquina;
            _idCliente = idCliente;
            _descricao = descricao;
            _ip = ip;
            _loginAcesso = loginAcesso;
            _passwordAcesso = passwordAcesso;
            _dataCriacao = dataCriacao;
            _ultimoUpdate = ultimoUpdate;
            _ativo = ativo;
        }

        public uint GetIdMaquina() => _idMaquina;
        public uint GetIdCliente() => _idCliente;
        public string GetDescricao() => _descricao;
        public string GetIp() => _ip;
        public string GetLoginAcesso() => _loginAcesso;
        public string GetPasswordAcesso() => _passwordAcesso;
        public DateTime GetDataCriacao() => _dataCriacao;
        public DateTime GetUltimoUpdate() => _ultimoUpdate;
        public bool GetAtivo() => _ativo;

        public override string ToString()
        {
            return _descricao;
        }
    }
}
