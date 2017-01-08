using System;

namespace M15_PA01_N02.Classes
{
    public class Client
    {
        private readonly uint _clientId;
        private readonly string _name;
        private readonly string _street;
        private readonly string _cep;
        private readonly string _city;
        private readonly string _phone;
        private readonly string _fax;
        private readonly string _mobilePhone;
        private readonly string _email;
        private readonly string _site;
        private readonly string _agent;
        private readonly string _comments;
        private readonly DateTime _addDate;
        private readonly DateTime _lastUpdate;
        private readonly bool _active;

        public Client(uint clientId, string name, string street, string cep, string city, string phone, string fax, string mobilePhone, string email, string site, string agent, string comments, DateTime addDate, DateTime lastUpdate, bool active)
        {
            _clientId = clientId;
            _name = name;
            _street = street;
            _cep = cep;
            _city = city;
            _phone = phone;
            _fax = fax;
            _mobilePhone = mobilePhone;
            _email = email;
            _site = site;
            _agent = agent;
            _comments = comments;
            _addDate = addDate;
            _lastUpdate = lastUpdate;
            _active = active;
        }

        public uint GetClientId() => _clientId;
        public string GetName() => _name;
        public string GetStreet() => _street;
        public string GetCep() => _cep;
        public string GetCity() => _city;
        public string GetPhone() => _phone;
        public string GetFax() => _fax;
        public string GetMobilePhone() => _mobilePhone;
        public string GetEmail() => _email;
        public string GetSite() => _site;
        public string GetAgent() => _agent;
        public string GetComments() => _comments;
        public DateTime GetAddDate() => _addDate;
        public DateTime GetLastUpdate() => _lastUpdate;
        public bool GetActive() => _active;

        public override string ToString() => _name;
    }
}