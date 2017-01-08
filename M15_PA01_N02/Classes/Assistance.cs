using System;

namespace M15_PA01_N02.Classes
{
    public class Assistance
    {
        private readonly uint _assistanceId;
        private readonly uint _clientId;
        private readonly uint _machineId;
        private readonly uint _employeeId;
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;
        private readonly DateTime _startTime;
        private readonly DateTime _endTime;
        private readonly bool _concluded;
        private readonly double _price;
        private readonly string _comments;
        private readonly DateTime _addDate;
        private readonly DateTime _lastUpdate;
        private readonly bool _active;

        public Assistance(uint assistanceId, uint clientId, uint machineId, uint employeeId, DateTime startDate, DateTime endDate, DateTime startTime, DateTime endTime, bool concluded, double price, string comments, DateTime addDate, DateTime lastUpdate, bool active)
        {
            _assistanceId = assistanceId;
            _clientId = clientId;
            _machineId = machineId;
            _employeeId = employeeId;
            _startDate = startDate;
            _endDate = endDate;
            _startTime = startTime;
            _endTime = endTime;
            _concluded = concluded;
            _price = price;
            _comments = comments;
            _addDate = addDate;
            _lastUpdate = lastUpdate;
            _active = active;
        }

        public uint GetAssistanceId() => _assistanceId;
        public uint GetClientId() => _clientId;
        public uint GetMachineId() => _machineId;
        public uint GetEmployeeId() => _employeeId;
        public DateTime GetStartDate() => _startDate;
        public DateTime GetEndDate() => _endDate;
        public DateTime GetStartTime() => _startTime;
        public DateTime GetEndTime() => _endTime;
        public bool GetConcluded() => _concluded;
        public double GetPrice() => _price;
        public string GetComments() => _comments;
        public DateTime GetAddDate() => _addDate;
        public DateTime GetLastUpdate() => _lastUpdate;
        public bool GetActive() => _active;
    }
}
