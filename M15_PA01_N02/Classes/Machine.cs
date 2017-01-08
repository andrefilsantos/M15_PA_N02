using System;

namespace M15_PA01_N02.Classes
{
    public class Machine
    {
        private readonly uint _machineId;
        private readonly uint _clientId;
        private readonly string _description;
        private readonly string _ip;
        private readonly string _login;
        private readonly string _password;
        private readonly DateTime _addDate;
        private readonly DateTime _lastUpdate;
        private readonly bool _active;

        public Machine(uint machineId, uint clientId, string description, string ip, string login, string password, DateTime addDate, DateTime lastUpdate, bool active)
        {
            _machineId = machineId;
            _clientId = clientId;
            _description = description;
            _ip = ip;
            _login = login;
            _password = password;
            _addDate = addDate;
            _lastUpdate = lastUpdate;
            _active = active;
        }

        public uint GetMachineId() => _machineId;
        public uint GetClientId() => _clientId;
        public string GetDescription() => _description;
        public string GetIp() => _ip;
        public string GetLogin() => _login;
        public string GetPassword() => _password;
        public DateTime GetAddDate() => _addDate;
        public DateTime GetLastUpdate() => _lastUpdate;
        public bool GetActive() => _active;

        public override string ToString() => _description;
    }
}