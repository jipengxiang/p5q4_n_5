using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;

namespace p5
{
    class DBPerson
    {
        private int averageAge;//add this
        public int AverageAge
        {
            get { return averageAge; }
            set { averageAge = value; }
        }//until here
        public List<Person> GetPersonList(out string status)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        using (DataTable table = new DataTable())
                        {
                            status = string.Empty;
                            conn.ConnectionString =
                               "Data Source=LAPTOP-99FSJQJ6\\SQLEXPRESS;" +
                                   "database=ApplicationDevelopmentDB;" +
              "integrated security=true";
                            comm.Connection = conn;
                            conn.Open();
                            //comm.CommandText = "select tblPerson.name, tblPerson.age, tblGender.genderDesc from tblPerson, tblGender where tblPerson.gender = tblGender.genderId";
                            comm.CommandText =
                                "select tblPerson.name, tblPerson.age, " +
                                " tblGender.genderDesc from tblPerson INNER JOIN " +
                                " tblGender ON tblPerson.gender = tblGender.genderId";
                            da.SelectCommand = comm;



                            List<Person> persons = new List<Person>(); //instantiate the persons array
                            //List<Person> persons = new List<Person>(); //instantiate the persons list
                            da.Fill(table);
                            // int i = 0;
                            foreach (DataRow row in table.Rows)
                            {
                                persons.Add(new Person(
                                    row["name"].ToString(),
                                    int.Parse(row["age"].ToString()),
                                    char.Parse(row["genderDesc"].ToString())));
                                //read columns from DataRow to create a Person object store in array
                                //i++;
                            }
                            //   averageAge = (int)
                            //   (table.Compute("AVG(age)", "GenderDesc='Male'"));
                            object dec = table.Compute("AVG(age)", "GenderDesc='Male'");

                            bool result = int.TryParse(dec.ToString(), out averageAge);

                            return persons;
                            //SELECT AVG(Age) from tablename where GenderDesc='Male'
                            //SQL aggregate function
                        }
                    }
                }


            }

            //    catch (Exception ex)
            //{
            //    status = ex.Message;
            //}
            //finally
            //{
            //    conn.Close();
            //}

        }


        public void UpdateDB(List<Person> list)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    conn.ConnectionString =
                      "Data Source=LAPTOP-99FSJQJ6\\SQLEXPRESS;" +
                                   "database=ApplicationDevelopmentDB;" +
              "integrated security=true";
                    conn.Open();
                    comm.Connection = conn;
                    comm.CommandText = "UPDATE tblPerson set Age=@InA where Name=@InOA";
                    comm.Parameters.Add("@InOA", SqlDbType.VarChar, 20);
                    comm.Parameters.Add("@InA", SqlDbType.Int);
                    foreach (Person p in list)
                    {

                        comm.Parameters["@InOA"].Value = p.Name;
                        comm.Parameters["@InA"].Value = p.Age;

                        comm.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }
        public void DeleteDB(string name)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    conn.ConnectionString =
                        "Data Source=LAPTOP-99FSJQJ6\\SQLEXPRESS;" +
                                   "database=ApplicationDevelopmentDB;" +
              "integrated security=true";
                    conn.Open();
                    comm.Connection = conn;
                    comm.CommandText = "DELETE tblPerson where Name=@InOA";

                    comm.Parameters.Add("@InOA", SqlDbType.VarChar, 20);
                    comm.Parameters["@InOA"].Value = name;
                    comm.ExecuteNonQuery();

                }
                conn.Close();
            }
        }
        public void InsertDB(Person p)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    conn.ConnectionString =
                        "Data Source=LAPTOP-99FSJQJ6\\SQLEXPRESS;" +
                                   "database=ApplicationDevelopmentDB;" +
              "integrated security=true";
                    conn.Open();
                    comm.Connection = conn;
                    comm.CommandText = "INSERT tblPerson set (Name,Age,Gender) VALUES (@InOA,@InA,@InG)";
                    comm.Parameters.Add("@InOA", SqlDbType.VarChar, 20);
                    comm.Parameters.Add("@InA", SqlDbType.Int);
                    comm.Parameters.Add("@InG", SqlDbType.Char);
                    comm.Parameters["@InOA"].Value = p.Name;
                    comm.Parameters["@InA"].Value = p.Age;
                    comm.Parameters["@InG"].Value = p.Gender;

                    comm.ExecuteNonQuery();

                }
                conn.Close();
            }
        }
    }
}



