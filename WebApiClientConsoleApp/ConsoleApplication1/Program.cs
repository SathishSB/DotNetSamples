using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebApiClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {             
            using (var client = new HttpClient())
            {
                ApiTest.PostAString();
                

                client.BaseAddress = new Uri("http://localhost:50641/");

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                RunAsync(client).Wait();  

                GetEmployeByID(client,"mtsubas_e1");

                //TODO : Need to find how to send class object to Web API Method
                //Employee emp = new Employee("mtsubas_e8", "Murtaza", "Mirza", "615-898-2323", 10, 90, true);
                //AddEmployee(client,emp);

                Console.ReadKey();
            }
        }

        static async Task RunAsync(HttpClient client)
        {
            HttpResponseMessage response = client.GetAsync("api/Employee/GetEmpDetails").Result;

            if (response.IsSuccessStatusCode)
            {
                List<Employee> empData = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result.ToList();

                foreach (var e in empData)
                {
                    DisplayEmployeeDetails(e);
                }
            }
            else
            {
                DisplayErrorMessage("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);                
            }           
        }


        static void GetEmployeByID(HttpClient client, string empID)
        {
            var response = client.GetAsync(string.Format("api/Employee/GetEmployeByID/{0}", empID)).Result;
            if (response.IsSuccessStatusCode)
            {                
                var e = response.Content.ReadAsAsync<Employee>().Result;
                DisplayEmployeeDetails(e);
            }
            else
            {
                DisplayErrorMessage("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);                
            } 
        }

        static void AddEmployee(HttpClient client, Employee emp)
        {
            var response = client.GetAsync(string.Format("api/Employee/AddEmployee", emp)).Result;
            if (response.IsSuccessStatusCode)
            {
                List<Employee> empData = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result.ToList();

                foreach (var e in empData)
                {
                    DisplayEmployeeDetails(e);
                }
            }
            else
            {
                DisplayErrorMessage("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);                
            }
        }

        static void DisplayErrorMessage(String Message)
        {
            Console.WriteLine(Message);
        }

        static void DisplayEmployeeDetails(Employee e)
        {
            Console.WriteLine("{0} {1} {2} ({3} {4} {5} {6})", e.employeeFirstName, e.employeeFT, e.employeeHours, e.employeeID, e.employeeLastName, e.employeePayrate, e.employeePhoneNumber);
        }        
    }

    public class Employee
    {
        public string employeeID;
        public string employeeLastName;
        public string employeeFirstName;
        public double employeePayrate;
        public string employeePhoneNumber;
        public int employeeHours;
        public bool employeeFT;

        public Employee(string eID, string eLastName, string eFirstName, string ePhone, double ePayrate, int eHours, bool eFT)
        {
            this.employeeID = eID;
            this.employeeLastName = eLastName;
            this.employeeFirstName = eFirstName;
            this.employeePayrate = ePayrate;
            this.employeePhoneNumber = ePhone;
            this.employeeHours = eHours;
            this.employeeFT = eFT;
        }
    }
}
