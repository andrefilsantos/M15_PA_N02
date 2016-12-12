using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15_TP01_N02
{
    public class Assistance {
        private readonly uint _idAssistencia;
        private readonly uint _idCliente;
        private readonly uint _idMaquina;
        private readonly uint _idFuncionario;
        private readonly DateTime _dataInicio;
        private readonly DateTime _dataFim;
        private readonly DateTime _horaInicio;
        private readonly DateTime _horaFim;
        private readonly bool _concluida;
        private readonly double _preco;
        private readonly string _observacoes;
        private readonly DateTime _dataCriacao;
        private readonly DateTime _ultimoUpdate;
        private readonly bool _ativo;

        public Assistance(uint idAssistencia, uint idCliente, uint idMaquina, uint idFuncionario, DateTime dataInicio, DateTime dataFim, DateTime horaInicio, DateTime horaFim, bool concluida, double preco, string observacoes, DateTime dataCriacao, DateTime ultimoUpdate, bool ativo)
        {
            _idAssistencia = idAssistencia;
            _idCliente = idCliente;
            _idMaquina = idMaquina;
            _idFuncionario = idFuncionario;
            _dataInicio = dataInicio;
            _dataFim = dataFim;
            _horaInicio = horaInicio;
            _horaFim = horaFim;
            _concluida = concluida;
            _preco = preco;
            _observacoes = observacoes;
            _dataCriacao = dataCriacao;
            _ultimoUpdate = ultimoUpdate;
            _ativo = ativo;
        }

        public uint GetIdAssistencia() => _idAssistencia;
        public uint GetIdCliente() => _idCliente;
        public uint GetIdMaquina() => _idMaquina;
        public uint GetIdFuncionario() => _idFuncionario;
        public DateTime GetDataInicio() => _dataInicio;
        public DateTime GetDataFim() => _dataFim;
        public DateTime GetHoraInicio() => _horaInicio;
        public DateTime GetHoraFim() => _horaFim;
        public bool GetConcluida() => _concluida;
        public double GetPreco() => _preco;
        public string GetObservacoes() => _observacoes;
        public DateTime GetDataCriacao() => _dataCriacao;
        public DateTime GetUltimoUpdate() => _ultimoUpdate;
        public bool GetAtivo() => _ativo;
    }
}
