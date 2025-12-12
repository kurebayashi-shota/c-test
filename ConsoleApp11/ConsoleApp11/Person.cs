using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp11;

class Person
{
    public string Name { get; set; }
    public long Phone { get; set; }
    public string Email { get; set; }
    public Person(string name, long phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }
}