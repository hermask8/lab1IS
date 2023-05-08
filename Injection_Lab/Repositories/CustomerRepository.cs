using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_Lab.Repositories
{
    public class CustomerRepository : IRepository
    {
        private IDbConnection _connection;

        public CustomerRepository(IDbConnection connectionDB) 
        {
            _connection = connectionDB;
        }

        public List<Customer> GetCustomers()
        {
            if (_connection.GetType() == typeof(MysqlConnection))
                Console.WriteLine("Obtengo los clientes de Mysql");
            else if (_connection.GetType() == typeof(OracleConnection))
                Console.WriteLine("Obtengo los clientes de Oracle");

            return new List<Customer> 
            {
                new Customer() {Id = 1, Name = "Edwin Hilario", Email = "hermask8@gmail.com", Phone = "12345678"},
                new Customer() {Id = 2, Name = "Leonardo Gómez", Email = "edwin.hilario@outlook.com", Phone = "23456789"}
            };
        }
    }
}
