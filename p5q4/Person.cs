using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p5
{
 public class Person //should be public 
 {
  private string m_name;
  private int m_age;
  private char m_gender;

  public Person() {
   m_name = "unknown";
   m_age = 0;
   m_gender = 'M';
  }

  public Person(string n, int a, char g) {
   m_name = n;
   m_age = a;
   m_gender = g;
  }

  public string Name {
   get { return this.m_name; }
   set { this.m_name = value; }
  }
  public int Age
  {
   get { return this.m_age; }
   set { this.m_age = value; }
  }
  public char Gender
  {
   get { return this.m_gender; }
   set { this.m_gender = value; }
  }

  public int getYearOfBirth() {
   return DateTime.Now.Year - m_age;
  }


 }
}
