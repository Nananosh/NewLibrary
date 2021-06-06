using NewLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace NewLibrary.DataBaseConnection.Factory
{
    public static class Factory
    {
        /// <summary>
        /// Эта функция дает нам всех пользователей в виде листа
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        public static List<Profile> GetAllProfiles(SQLiteDataReader dataReader)
        {
            List<Profile> list = new List<Profile>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var name = dataReader.GetString(1);
                var password = dataReader.GetString(2);

                list.Add(new Profile(id, name, password));
            }

            return list;
        }

        public static List<Publication> GetAllPublication(SQLiteDataReader dataReader)
        {
            List<Publication> list = new List<Publication>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var bookid = dataReader.GetInt32(1);
                var publisherid = dataReader.GetInt32(2);
                var year = dataReader.GetInt32(3);
                var place = dataReader.GetString(4);

                list.Add(new Publication(id, bookid, publisherid, year, place));
            }

            return list;
        }
        public static List<Author> GetAllAuthor(SQLiteDataReader dataReader)
        {
            List<Author> list = new List<Author>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var image = dataReader.GetString(1);
                var name = dataReader.GetString(2);
                
                

                list.Add(new Author(id, image, name));
            }

            return list;
        }
        public static List<PublicationInformation> GetAllPublication2(SQLiteDataReader dataReader)
        {
            List<PublicationInformation> list = new List<PublicationInformation>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var bookId = dataReader.GetInt32(1);
                var publisherId = dataReader.GetInt32(2);
                var yearPubl = dataReader.GetInt32(3);
                var placePublication = dataReader.GetString(4);
                var bookName = dataReader.GetString(5);
                var bookPages = dataReader.GetInt32(6);
                var bookImage = dataReader.GetString(7);
                var publisherName = dataReader.GetString(8);
                var authorImage = dataReader.GetString(9);
                var authorName = dataReader.GetString(10);
                var greneName = dataReader.GetString(11);
                list.Add(new PublicationInformation(id,bookId,publisherId,yearPubl,placePublication,bookName,bookPages,bookImage, publisherName, authorImage, authorName, greneName));
            }

            return list;
        }

        public static List<Book> GetAllBooks(SQLiteDataReader dataReader)
        {
            List<Book> list = new List<Book>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var name = dataReader.GetString(1);
                var authorid = dataReader.GetInt32(2);
                var genreid = dataReader.GetInt32(3);
                var image = dataReader.GetString(4);
                var numpage = dataReader.GetInt32(5);

                list.Add(new Book(id, name, authorid, genreid, image, numpage));
            }

            return list;
        }

        public static void InsertProfile(Profile account)
        {
            DatabaseConnection.InsertProfile(account);
        }
        public static int GetPublicationRent(SQLiteDataReader dataReader)
        {
            int state = 0;


            while (dataReader.Read())
            {

                if (!dataReader.IsDBNull(0))
                {
                    state = dataReader.GetInt32(0);
                }
                else state = 0;
                
            }

            return state;
        }
        public static List<Received> GetAllRental(SQLiteDataReader dataReader)
        {
            List<Received> list = new List<Received>();
            while (dataReader.Read())
            {
                var idprof = dataReader.GetInt32(0);
                var idpubl = dataReader.GetInt32(1);
                var bookrentar = dataReader.GetInt32(2);
                var returndate = dataReader.GetString(3);
               

                list.Add(new Received(idprof, idpubl, bookrentar, returndate));
            }

            return list;
        }
        public static List<Received> GetRentalUser(SQLiteDataReader dataReader)
        {

            List<Received> list = new List<Received>();
            while (dataReader.Read())
            {
                var profile_Id = dataReader.GetInt32(0);
                var publication_Id = dataReader.GetInt32(1);
                var book_rental = dataReader.GetInt32(2);
                var return_date = dataReader.GetString(3);
                list.Add(new Received(profile_Id, publication_Id, book_rental, return_date));
            }
            return list;
        }
        public static List<(string,string,int,string,string, int)> GetReceived(SQLiteDataReader dataReader)
        {
            List<(string, string, int, string, string, int)> List = new List<(string, string, int, string, string, int)>();
            while (dataReader.Read())
            {
                var ReceivedInformation = (dataReader.GetString(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetInt32(5));
                List.Add(ReceivedInformation);
            }
            return List;
        }
        public static void RemoveFromReceived(int userid,int publid)
        {

            DatabaseConnection.RemoveFromReceived(userid,publid);
        }
        public static void AddRental(int profileId, int productId, DateTime time)
        {
            DatabaseConnection.AddRental( profileId,  productId,  time);
        }
        public static void SetRental1(int profileId, int productId)
        { 
            DatabaseConnection.SetRental1(profileId, productId);
        }
    }
    
}