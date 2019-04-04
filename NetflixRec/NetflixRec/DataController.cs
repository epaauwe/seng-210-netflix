using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace NetflixRec
{
    public class DataController
    {
        private static SqlConnection conn = new SqlConnection("Server=tcp:sengteam10.database.windows.net,1433;" +
            "Initial Catalog=netflix;Persist Security Info=False;User ID=team10;Password=Bababooey210;" +
            "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataReader reader;

        public static void OpenConnection(string cmdText)
        {
            conn.Open();
            cmd = new SqlCommand(cmdText, conn);
            reader = cmd.ExecuteReader();
        }

        public static List<Content> LoadContent(int userID)
        {
            var content = new List<Content>();
            OpenConnection("SELECT * FROM content");
            while (reader.Read())
            {
                Content c = new Content();
                c.ID = Convert.ToInt32(reader[0]);
                if (reader[1].ToString().Length > 0)
                    c.Year = Convert.ToInt32(reader[1]);
                c.Title = reader[2].ToString();
                content.Add(c);
            }
            reader.Close();
            var contentUsers = new List<int>();
            cmd = new SqlCommand("SELECT * FROM ContentUser WHERE userID=" + userID, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                contentUsers.Add(Convert.ToInt32(reader[0]));
            }
            conn.Close();
            return content.Where(c => !contentUsers.Contains(c.ID)).ToList(); // returns all content that the user hasn't rated yet
        }

        public static void InsertRating(int contentID, int userID, double rating)
        {
            conn.Open();
            cmd = new SqlCommand(String.Format("INSERT INTO ContentUser (contentID, userID, rating) VALUES ('{0}', '{1}', '{2}')", contentID, userID, rating), conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static int LoadUserID(string login, string password)
        {
            OpenConnection(String.Format("SELECT userID FROM \"User\" WHERE login='{0}' AND password='{1}'", login, password));
            int id = -1;
            while (reader.Read())
            {
                id = Convert.ToInt32(reader[0].ToString());
            }
            conn.Close();
            return id; // returns -1 if user doesn't exist
        }

        public static int CreateUser(string fName, string lName, string login, string password)
        {
            if (LoadUserID(login, password) != -1)
                return -1; // return -1 if user exists

            OpenConnection("SELECT TOP 1 userID FROM \"User\" ORDER BY userID DESC");
            int id = 0;
            while (reader.Read())
            {
                id = Convert.ToInt32(reader[0].ToString()) + 1;
            }
            reader.Close();
            cmd = new SqlCommand(String.Format("INSERT INTO \"User\" (fName, lName, login, password) VALUES ('{0}', '{1}', '{2}', '{3}')", fName, lName, login, password), conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return id; // return id of new user
        }
    }

    public class Content
    {
        public int ID;
        public int Year;
        public string Title;
    }
}