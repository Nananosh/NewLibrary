using NewLibrary.Models;
using System;
using System.Data.SQLite;

namespace NewLibrary.DataBaseConnection
{
    public static class DatabaseConnection
    {
        private readonly static SQLiteConnection _connection =
            DatabaseConnectionManager.GetSqlConnection().OpenAndReturn();
        public static SQLiteDataReader GetAllProfiles()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select * from profile";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetAllPublication()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select * from publication";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetAllAuthor()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select * from author";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetAllPublication2()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select publication.id, publication.id_book, publication.id_publishing_house, publication.year_publication, publication.place_publication, b.name, b.number_pages, b.image,p.name, a.image, a.name, g.name from publication " +
                                  "join book b on b.id = publication.id_book " +
                                  "join publishing_house p on p.id = publication.id_publishing_house " +
                                  "join author a on a.id = b.id_author " +
                                  "join genre g on g.id = b.id_genre;";
           
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetReceived(int id)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"SELECT b.name,image,year_publication,place_publication, return_date, id_publication FROM book_rental " +
                                    "join publication p on p.id = book_rental.id_publication "+
                                    "join book b on b.id = p.id_book "+
                                    $"join publishing_house ph on ph.id = p.id_publishing_house where id_profile = {id} and book_rental =1";
            return command.ExecuteReader();
        }
        public static void RemoveFromReceived(int profileid, int productId)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"UPDATE book_rental SET book_rental=0 where id_profile={profileid} and id_publication={productId}";
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
        }
        public static SQLiteDataReader GetAllBooks()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select * from book";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetAllRental()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select * from book_rental";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetRentalUser(int id)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select * from book_rental where id_profile={id} and book_rental=1";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetPublicationRent(int id)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"SELECT max(book_rental) from book_rental where id_publication={id};";
            return command.ExecuteReader();
        }
        public static void InsertProfile(Profile account)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"INSERT INTO profile(nickname,password) VALUES (:nickname,:password);";
            command.Parameters.AddWithValue("nickname", account.NickName);
            command.Parameters.AddWithValue("password", account.Password);
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
        }
        public static void AddRental(int profileId, int productId, DateTime time)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"INSERT INTO book_rental(id_profile,id_publication,book_rental,return_date) VALUES (:id_profile,:id_publication,:book_rental,:return_date);";
            command.Parameters.AddWithValue("id_profile", profileId);
            command.Parameters.AddWithValue("id_publication", productId);
            command.Parameters.AddWithValue("book_rental", 1);
            command.Parameters.AddWithValue("return_date", time.ToString("D"));
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
        }
        public static void SetRental1(int profileId, int productId)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"Update  book_rental  Set book_rental=0 where id_profile={profileId} and id_publication={productId}";
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
        }

    }
}