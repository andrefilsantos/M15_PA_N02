using System;

namespace M15_PA01_N02.Classes
{
    public class Employee
    {
        private readonly uint _employeeId;
        private readonly string _name;
        private readonly string _username;
        private readonly string _password;
        private readonly DateTime _birthday;
        private readonly string _photo;
        private readonly string _nCc;
        private readonly string _phone;
        private readonly string _email;
        private readonly string _comments;
        private readonly DateTime _addDate;
        private readonly DateTime _lastUpdate;
        private readonly bool _active;

        public Employee(uint employeeId, string name, string username, string password, DateTime birthday, string photo, string nCc, string phone, string email, DateTime addDate, string comments, DateTime lastUpdate, bool active)
        {
            _employeeId = employeeId;
            _name = name;
            _username = username;
            _password = password;
            _birthday = birthday;
            _photo = photo;
            _nCc = nCc;
            _phone = phone;
            _email = email;
            _addDate = addDate;
            _comments = comments;
            _lastUpdate = lastUpdate;
            _active = active;
        }

        public uint GetEmployeeId() => _employeeId;
        public string GetName() => _name;
        public string GetUsername() => _username;
        public string GetPassword() => _password;
        public DateTime GetBirthday() => _birthday;
        public string GetPhoto() => _photo;
        public string GetNCc() => _nCc;
        public string GetPhone() => _phone;
        public string GetEmail() => _email;
        public string GetComments() => _comments;
        public DateTime GetAddDate() => _addDate;
        public DateTime GetLastUpdate() => _lastUpdate;
        public bool GetActive() => _active;
        public override string ToString() => _name;
    }
}
