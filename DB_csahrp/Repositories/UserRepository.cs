using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DB_csahrp.Models;
using System.Threading.Tasks;
using DB_csahrp.IUserRepositories;
using DB_csahrp.Consists;

namespace DB_csahrp.Repositories
{
    public class UserRepository : IUserRepository
    {

        public void Create(string firstname, string lastname, string email, int age, string phone)
        {
            string sql = $"insert into Users(firstname, lastname, email, age, phone) values ('{firstname}', '{lastname}', '{email}', {age}, '{phone}')";
            string sss = "create table trrrr(id serial primary key, name varchar(20));";
            Npgsql.NpgsqlConnection con = new Npgsql.NpgsqlConnection(MyConsisits.ConServer);
            con.Open();
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sss, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Update(int id, string row, string anything)
        {
            string sql = $"update users set id = {id}, {row} = '{anything}';";
            Npgsql.NpgsqlConnection con = new Npgsql.NpgsqlConnection(MyConsisits.ConServer);
            con.Open();
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            string sql = $"delete from users where id = {id};";
            Npgsql.NpgsqlConnection con = new Npgsql.NpgsqlConnection(MyConsisits.ConServer);
            con.Open();
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }

        public List<Users> GetAll()
        {
            string sql = "select * from users";

            Npgsql.NpgsqlConnection con = new Npgsql.NpgsqlConnection(MyConsisits.ConServer);
            con.Open();
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sql, con);
            Npgsql.NpgsqlDataReader rdr = cmd.ExecuteReader();
            List<Users> users = new List<Users>();


            while (rdr.Read())
            {
                users.Add(new Users{Id = rdr.GetInt32(0),
                Firstname = rdr.GetString(1), 
                Lastname = rdr.GetString(2), 
                Email = rdr.GetString(3),
                Age = rdr.GetInt32(4),
                Phone = rdr.GetString(5)});

            }
            return users;
        }

        public Users Read(int id)
        {
            string sql = "select * from users";

            Npgsql.NpgsqlConnection con = new Npgsql.NpgsqlConnection(MyConsisits.ConServer);
            con.Open();
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sql, con);
            Npgsql.NpgsqlDataReader rdr = cmd.ExecuteReader();

            Users users = new Users();
            while (rdr.Read())
            {
                users.Id = rdr.GetInt32(0);
                users.Firstname = rdr.GetString(1);
                users.Lastname = rdr.GetString(2);
                users.Email = rdr.GetString(3);
                users.Age = rdr.GetInt32(4);
                users.Phone = rdr.GetString(5);
            }
            return users;
        }

       
    }
}
