using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace M15_PA01_N02.Classes
{
    public class Database
    {
        private static Database _instance;
        private readonly SqlConnection _ligacaoBd;
        public static Database Instance => _instance ?? (_instance = new Database());

        public Database()
        {
            try
            {
                var strLigacao = ConfigurationManager.ConnectionStrings["sql"].ToString();
                _ligacaoBd = new SqlConnection(strLigacao);
                _ligacaoBd.Open();
            }
            catch (Exception)
            {
                var strLigacao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() + "M15_TP01_N02.mdf" + ";Integrated Security=True;Connect Timeout=30";
                _ligacaoBd = new SqlConnection(strLigacao);
                _ligacaoBd.Open();
            }
        }

        ~Database() { try { _ligacaoBd.Close(); } catch (Exception e) { Console.WriteLine(e.Message); } }

        public DataTable SqlQuery(string query)
        {
            var queryResult = new DataTable();
            var sqlQuery = new SqlCommand(query, _ligacaoBd);
            var result = sqlQuery.ExecuteReader();
            queryResult.Load(result);
            return queryResult;
        }

        public static void CreateDataBase(string name)
        {
            var nomeBd = Path.GetFileNameWithoutExtension(name);
            var ligacaoServidor = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30");
            ligacaoServidor.Open();
            var strSql = $"CREATE DATABASE {nomeBd} ON PRIMARY (NAME={nomeBd}, FILENAME='{name}' )";
            var comando = new SqlCommand(strSql, ligacaoServidor);
            comando.ExecuteNonQuery();
            ligacaoServidor = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={name};Integrated Security=True;Connect Timeout=30");
            ligacaoServidor.Open();
            strSql = @"CREATE TABLE Clientes(
	                        idCliente    	INT            NOT NULL IDENTITY PRIMARY KEY,
	                        nome         	NVARCHAR(100)  NOT NULL,
	                        morada       	NVARCHAR(100),
	                        codigoPostal 	NVARCHAR(8)    CHECK (codigoPostal LIKE '____-___'),
	                        localidade   	NVARCHAR(30),
	                        telefone     	NVARCHAR(9),
	                        fax          	NVARCHAR(9),
	                        telemovel    	NVARCHAR(9), 
	                        email        	NVARCHAR(100)  UNIQUE CHECK(email LIKE('%@%.%')), 
	                        site         	NVARCHAR(100), 
	                        representante  	NVARCHAR(100),
	                        observacoes  	TEXT, 
	                        dataCriacao  	DATE 		   NOT NULL DEFAULT getdate(),
	                        ultimoUpdate   	DATE 		   NOT NULL DEFAULT getdate(),
	                        ativo           BIT			   DEFAULT(1)
                        )

                        CREATE TABLE Maquinas(
	                        idMaquina      INT             NOT NULL IDENTITY PRIMARY KEY,
	                        idCliente      INT             NOT NULL REFERENCES Clientes(idCliente),
	                        descricao      TEXT		       NOT NULL,
	                        ip             NVARCHAR(100),
	                        loginAcesso    NVARCHAR(50),
	                        passwordAcesso NVARCHAR(100),
	                        dataCriacao    DATE 		   NOT NULL DEFAULT getdate(),
	                        ultimoUpdate   DATE 		   NOT NULL DEFAULT getdate(),
	                        ativo          BIT			   DEFAULT(1)
                        )

                        CREATE TABLE Funcionarios(
	                        idFuncionario  INT             NOT NULL IDENTITY PRIMARY KEY,
	                        nome           NVARCHAR(50)    NOT NULL,
	                        username       NVARCHAR(100)   NOT NULL,
	                        password       TEXT            NOT NULL,
	                        dataNascimento DATE,
	                        foto           NVARCHAR(500)   CHECK(foto LIKE('images/Funcionarios/%')),
	                        nCC            NVARCHAR(12), 
	                        telefone       NVARCHAR(9), 
	                        email          NVARCHAR(100)   UNIQUE CHECK(email LIKE('%@%.%')), 
	                        observacoes    TEXT,
	                        dataCriacao    DATE 		   NOT NULL DEFAULT getdate(),
	                        ultimoUpdate   DATE 		   NOT NULL DEFAULT getdate(), 
	                        ativo          BIT			   DEFAULT(1)
                        )

                        CREATE TABLE Assistencias(
	                        idAssistencia  INT             NOT NULL IDENTITY PRIMARY KEY,
	                        idCliente      INT     		   NOT NULL REFERENCES Clientes(idCliente),
	                        idMaquina      INT    		   NOT NULL REFERENCES Maquinas(idMaquina),
	                        idFuncionario  INT     		   NOT NULL REFERENCES Funcionarios(idFuncionario),
	                        dataInicio     DATE    		   DEFAULT getdate(),
	                        dataFim        DATE    		   DEFAULT getdate(),
	                        horaInicio     TIME    		   DEFAULT CONVERT(TIME, getdate()),
	                        horaFim        TIME    		   DEFAULT CONVERT(TIME, getdate()),
	                        concluida      BIT,
	                        preco          MONEY,
	                        observacoes    TEXT,
	                        dataCriacao    DATE 		   NOT NULL DEFAULT getdate(),
	                        ultimoUpdate   DATE 		   NOT NULL DEFAULT getdate(),
	                        ativo          BIT			   DEFAULT(1)
                        )

                        INSERT INTO Funcionarios(nome, username, password) VALUES
                                                 'Administrator', 'admin', 'admin')";
            comando = new SqlCommand(strSql, ligacaoServidor);
            comando.ExecuteNonQuery();
        }

        public bool Login(string username, string password)
        {
            var sqlQuery =
                new SqlCommand($@"SELECT * FROM Funcionarios WHERE username LIKE '{username}' AND password LIKE '{password}' AND ativo = 1", _ligacaoBd);
            var employee = new DataTable();

            var user = sqlQuery.ExecuteReader();
            employee.Load(user);
            if (employee.Rows.Count <= 0) return employee.Rows.Count > 0;

            uint employeeId;
            string name, userUsername, userPassword, photo, phone, email, nCc, comments;
            DateTime bithday, addDate, lastUpdate;
            bool active;

            try { employeeId = Convert.ToUInt32(employee.Rows[0][0]); } catch { employeeId = 0; }
            try { name = (string)employee.Rows[0][1]; } catch { name = ""; }
            try { userUsername = (string)employee.Rows[0][2]; } catch { userUsername = ""; }
            try { userPassword = (string)employee.Rows[0][3]; } catch { userPassword = ""; }
            try { bithday = DateTime.Parse(employee.Rows[0][4].ToString()); } catch { bithday = new DateTime(); }
            try { photo = (string)employee.Rows[0][5]; } catch { photo = ""; }
            try { nCc = (string)employee.Rows[0][6]; } catch { nCc = ""; }
            try { phone = (string)employee.Rows[0][7]; } catch { phone = ""; }
            try { email = (string)employee.Rows[0][8]; } catch { email = ""; }
            try { comments = (string)employee.Rows[0][9]; } catch { comments = ""; }
            try { addDate = DateTime.Parse(employee.Rows[0][10].ToString()); } catch { addDate = new DateTime(); }
            try { lastUpdate = DateTime.Parse(employee.Rows[0][11].ToString()); } catch { lastUpdate = new DateTime(); }
            try { active = (bool)employee.Rows[0][12]; } catch { active = false; }


            Utils.Instance.User = new Employee(employeeId,
                                                name,
                                                userUsername,
                                                userPassword,
                                                bithday,
                                                photo,
                                                nCc,
                                                phone,
                                                email,
                                                addDate,
                                                comments,
                                                lastUpdate,
                                                active);
            return employee.Rows.Count > 0;
        }

        public void InsertAssistance(int idCliente, int idMaquina, int idFuncionario, string dataInicio, string dataFim, string horaInicio, string horaFim, bool concluida, decimal preco, string observacoes)
        {
            var comando = new SqlCommand(@"INSERT INTO Assistencias(idMaquina, idCliente, idFuncionario, dataInicio, dataFim, horaInicio, horaFim, concluida, preco, observacoes, dataCriacao, ultimoUpdate, ativo) VALUES (@idMaquina, @idCliente, @idFuncionario, @dataInicio, @dataFim, @horaInicio, @horaFim, @concluida, @preco, @observacoes, getDate(), getDate(), 'true');", _ligacaoBd);
            comando.Parameters.AddWithValue("@idMaquina", idMaquina);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@idFuncionario", idFuncionario);
            comando.Parameters.AddWithValue("@dataInicio", dataInicio);
            comando.Parameters.AddWithValue("@dataFim", dataFim);
            comando.Parameters.AddWithValue("@horaInicio", horaInicio);
            comando.Parameters.AddWithValue("@horaFim", horaFim);
            comando.Parameters.AddWithValue("@concluida", concluida);
            comando.Parameters.AddWithValue("@preco", preco);
            comando.Parameters.AddWithValue("@observacoes", observacoes);
            comando.ExecuteNonQuery();
        }

        public void InsertClient(string nome, string morada, string localidade, string codigoPostal, string telefone, string fax, string telemovel, string email, string site, string representante, string observacoes)
        {

            var comando = new SqlCommand(@"INSERT INTO Clientes(nome, morada, localidade, codigoPostal, telefone, fax, telemovel, email, site, representante, observacoes, dataCriacao, ultimoUpdate, ativo) VALUES (@nome, @morada, @localidade, @codigoPostal, @telefone, @fax, @telemovel, @email, @site, @representante, @observacoes, getDate(), getDate(), 'true');", _ligacaoBd);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@morada", morada);
            comando.Parameters.AddWithValue("@localidade", localidade);
            comando.Parameters.AddWithValue("@codigoPostal", codigoPostal);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@fax", fax);
            comando.Parameters.AddWithValue("@telemovel", telemovel);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@site", site);
            comando.Parameters.AddWithValue("@representante", representante);
            comando.Parameters.AddWithValue("@observacoes", observacoes);
            comando.ExecuteNonQuery();
        }

        public void InsertEmloyee(string nome, string username, string password, string dataNascimento, string foto, string nCc, string telefone, string email, string observacoes)
        {
            var comando =
                new SqlCommand(
                    $@"INSERT INTO Funcionarios(nome, username, password, dataNascimento, foto, nCc, telefone, email, observacoes, dataCriacao, ultimoUpdate, ativo) VALUES (@nome, @username, @password, @dataNascimento, @foto, @nCc, @telefone, @email, @observacoes, getDate(), getDate(), 'true');",
                    _ligacaoBd);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@username", username);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(dataNascimento).ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@foto", foto);
            comando.Parameters.AddWithValue("@nCc", nCc);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@observacoes", observacoes);
            comando.ExecuteNonQuery();
        }

        public void InsertMachine(string idCliente, string descricao, string ip, string loginAcesso, string passwordAcesso)
        {

            var comando = new SqlCommand(@"INSERT INTO Maquinas(idCliente, descricao, ip, loginAcesso, passwordAcesso, dataCriacao, ultimoUpdate, ativo) VALUES (@idCliente, @descricao, @ip, @loginAcesso, @passwordAcesso, getDate(), getDate(), 'true');", _ligacaoBd);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@descricao", descricao);
            comando.Parameters.AddWithValue("@ip", ip);
            comando.Parameters.AddWithValue("@loginAcesso", loginAcesso);
            comando.Parameters.AddWithValue("@passwordAcesso", passwordAcesso);
            comando.ExecuteNonQuery();
        }

        public void DeleteItem(string table, uint id, string action)
        {
            var comando = new SqlCommand($@"UPDATE {table} SET ativo = '{action}' WHERE id{table.Substring(0, table.Length - 1)}={id}", _ligacaoBd);
            comando.ExecuteNonQuery();
        }
        public void EditClient(string nome, string morada, string localidade, string codigoPostal, string telefone, string fax, string telemovel, string email, string site, string representante, string observacoes, uint id)
        {

            var comando = new SqlCommand($@"UPDATE Clientes SET nome = @nome, morada = @morada, localidade = @localidade, codigoPostal = @codigoPostal, telefone = @telefone, fax =  @fax, telemovel = @telemovel, email = @email, site = @site, representante = @representante, observacoes = @observacoes, ultimoUpdate=getDate() WHERE idCliente = {id}", _ligacaoBd);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@morada", morada);
            comando.Parameters.AddWithValue("@localidade", localidade);
            comando.Parameters.AddWithValue("@codigoPostal", codigoPostal);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@fax", fax);
            comando.Parameters.AddWithValue("@telemovel", telemovel);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@site", site);
            comando.Parameters.AddWithValue("@representante", representante);
            comando.Parameters.AddWithValue("@observacoes", observacoes);
            comando.ExecuteNonQuery();
        }

        public void UpdateEmloyee(uint idFuncionario, string nome, string username, string password, string dataNascimento, string photo, string nCc, string telefone, string email, string observacoes)
        {

            var comando = new SqlCommand($@"UPDATE Funcionarios SET nome = @nome, username=@username, password=@password, dataNascimento=@dataNascimento,nCc=@nCc, foto=@foto, telefone=@telefone, email=@email, observacoes=@observacoes, ultimoUpdate=getDate() WHERE idFuncionario={idFuncionario};", _ligacaoBd);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@username", username);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(dataNascimento).ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@foto", photo);
            comando.Parameters.AddWithValue("@nCc", nCc);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@observacoes", observacoes);
            comando.ExecuteNonQuery();
        }

        public void UpdateMachine(uint idMaquina, string idCliente, string descricao, string ip, string loginAcesso, string passwordAcesso)
        {

            var comando = new SqlCommand($@"UPDATE Maquinas SET idCliente = @idCliente, descricao = @descricao, ip = @ip, loginAcesso = @loginAcesso, passwordAcesso = @passwordAcesso, ultimoUpdate = getDate() WHERE idMaquina={idMaquina}", _ligacaoBd);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@descricao", descricao);
            comando.Parameters.AddWithValue("@ip", ip);
            comando.Parameters.AddWithValue("@loginAcesso", loginAcesso);
            comando.Parameters.AddWithValue("@passwordAcesso", passwordAcesso);
            comando.ExecuteNonQuery();
        }

        public void ConcludeAssistance(string id, string value)
        {
            var comando = new SqlCommand($"UPDATE Assistencias SET concluida = '{value}', dataFim='{DateTime.Now:yyyy-MM-dd}', horaFim='{DateTime.Now.Hour + ":" + DateTime.Now.Minute}' WHERE idAssistencia={id}", _ligacaoBd);
            comando.ExecuteNonQuery();
        }
    }
}
