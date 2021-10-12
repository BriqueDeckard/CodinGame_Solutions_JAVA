using System;
using System.Text.Json;

namespace _02_JSONToObject
{
    public class Department
    {
        public int DeptId { get; set; }

        public string DepartmentName { get; set; }

        public string ToString()
        {
            return "ID:" + DeptId + ", Name:" + DepartmentName + " ;";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = "{\"DeptId\": 101, \"DepartmentName\": \"IT\"}";
            Department department =
                JsonSerializer.Deserialize<Department>(jsonString);
            Console.WriteLine("Departement : " + department.ToString());
        }
    }
}
