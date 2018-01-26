using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//Q2
using System.Data.SqlClient;
//Q2

namespace p5
{
    class PersonCollection
    {

       // private Person[] persons; //array of Person objects
        private List<Person> persons;

        private int current;

        //part 2 , Q3
        private DBPerson db; 
        private string dbStatus; 
        public int AverageAge
        {
            get { return db.AverageAge; } 
        }

        public PersonCollection()
        {
            current = 0;
            //persons = new Person[8];
              persons = new List<Person>();
            //persons[0] = new Person("Mr A", 20, 'M');
            //persons[1] = new Person("Mr B", 30, 'M');
            //persons[2] = new Person("Miss C", 25, 'F');
            //persons[3] = new Person("Mrs D", 19, 'F');
            //persons[4] = new Person("Mr E", 45, 'M');
            //persons[5] = new Person("Mr F", 22, 'M');
            //persons[6] = new Person("Ms G", 76, 'F');
            //persons[7] = new Person("Miss H", 66, 'F');

            //persons.Add(new Person("Mr A", 20, 'M'));
            //persons.Add(new Person("Mr B", 30, 'M'));
            //persons.Add(new Person("Miss C", 25, 'F'));
            //persons.Add(new Person("Mrs D", 19, 'F'));
            //persons.Add(new Person("Mr E", 45, 'M'));
            //persons.Add(new Person("Mr F", 22, 'M'));
            //persons.Add(new Person("Ms G", 76, 'F'));
            //persons.Add(new Person("Miss H", 66, 'F'));


            // DB codes for Question 2-----------------------------------------------------------

            //SqlConnection conn = new SqlConnection();
            //SqlCommand comm = new SqlCommand();
            //SqlDataAdapter da = new SqlDataAdapter();
            //DataTable table = new DataTable();
            //// DataRow row;

            //conn.ConnectionString =
            //"Data Source=DMIT-NB42248-5\\SQLEXPRESS;database=ApplicationDevelopmentDB;" +
            //"integrated security=true"; //use your own setting
            //comm.Connection = conn;
            //comm.CommandText =
            //    "select tblPerson.name, tblPerson.age, tblGender.genderDesc " +
            //    "from tblPerson, tblGender where tblPerson.gender=tblGender.genderId";//inner join
            //da.SelectCommand = comm;
            //conn.Open();
            //da.Fill(table);
            ////persons = new Person[table.Rows.Count]; //instantiate the persons[] array

            //DataRow row;
            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    row = table.Rows[i];//retrieve DataRow
            //    persons[i] = new Person(
            //        row["name"].ToString(),
            //        int.Parse(row["age"].ToString()),
            //        char.Parse(row["genderDesc"].ToString()));
            //    //read columns from DataRow to create a Person object store in array
            //}
            //conn.Close();

            // End DB codes for Question 2-----------------------------------------------------------

            //Q3
            db = new DBPerson();
            persons = new List<Person>();
            persons = db.GetPersonList(out dbStatus);
            //bool a = int.TryParse(out x)

            //if (dbStatus.Length != 0)
            //{
            //    persons.Add(new Person("Mr A", 20, 'M'));
            //    persons.Add(new Person("Mr B", 30, 'M'));
            //    persons.Add(new Person("Miss C", 25, 'F'));
            //    persons.Add(new Person("Mrs D", 19, 'F'));
            //    persons.Add(new Person("Mr E", 45, 'M'));
            //    persons.Add(new Person("Mr F", 22, 'M'));
            //    persons.Add(new Person("Ms G", 76, 'F'));
            //    persons.Add(new Person("Miss H", 66, 'F'));
            //}



        }

        public Person getCurrentPerson()
        {
            return persons[current];
        }

        public int getTotalNoOfPersons()
        {
           // return persons.Length;//array size
            return persons.Count;
        }

        public int Current
        {
            get { return this.current; }
            set { this.current = value; }
        }

        public string DbStatus//Q3
        {
            get
            {
                return dbStatus;
            }

            set
            {
                dbStatus = value;
            }
        }

        
    }
}
