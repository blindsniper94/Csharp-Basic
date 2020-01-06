using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{

    public class HomeController : Controller
    {
        private string _connectionString = @"Data Source=LAPTOP-VH74KBAP\SQLEXPRESS;Initial Catalog=CarInsurance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~Views/Shared/Error.cshtml");
            }
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(User user)
        {
            double monthlyTotal = 50;

            if (user.Age < 25)
            {
                monthlyTotal = monthlyTotal + 25;
                if (user.Age < 18)
                {
                    monthlyTotal = monthlyTotal + 75;
                }
            }
            if (user.Age > 100)
            {
                monthlyTotal = monthlyTotal + 25;
            }
            if (user.CarYear < 2000)
            {
                monthlyTotal = monthlyTotal + 25;
            }
            if (user.CarYear > 2015)
            {
                monthlyTotal = monthlyTotal + 25;
            }
            if (user.CarMake == "porsche")
            {
                monthlyTotal = monthlyTotal + 25;
                if (user.CarModel == "911carrera")
                {
                    monthlyTotal = monthlyTotal + 25;
                }
            }
            for (int i = 0; i < user.UserSpeedingTickets; i++)
            {
                monthlyTotal = monthlyTotal + 10;
            }
            if (user.UserDui == true)
            {
                monthlyTotal = (monthlyTotal * .25) + monthlyTotal;
            }
            user.Quote = monthlyTotal;
            string queryString = @"Insert into Users (FirstName, LastName, EmailAddress, Age, CarYear, CarModel, CarMake, UserSpeedingTickets, UserDui, FullCoverage, Quote)
                                    Values (@FirstName, @LastName, @EmailAddress, @Age, @CarYear, @CarModel, @CarMake, @UserSpeedingTickets, @UserDui, @FullCoverage, @Quote)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                command.Parameters.Add("@LastName", SqlDbType.VarChar);
                command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                command.Parameters.Add("@Age", SqlDbType.Int);
                command.Parameters.Add("@CarYear", SqlDbType.Int);
                command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                command.Parameters.Add("@UserSpeedingTickets", SqlDbType.Int);
                command.Parameters.Add("@UserDui", SqlDbType.Bit);
                command.Parameters.Add("@FullCoverage", SqlDbType.Bit);
                command.Parameters.Add("@Quote", SqlDbType.Int);

                command.Parameters["@FirstName"].Value = user.FirstName;
                command.Parameters["@LastName"].Value = user.LastName;
                command.Parameters["@EmailAddress"].Value = user.EmailAddress;
                command.Parameters["@Age"].Value = user.Age;
                command.Parameters["@CarYear"].Value = user.CarYear;
                command.Parameters["@CarModel"].Value = user.CarModel;
                command.Parameters["@CarMake"].Value = user.CarMake;
                command.Parameters["@UserSpeedingTickets"].Value = user.UserSpeedingTickets;
                command.Parameters["@UserDui"].Value = user.UserDui;
                command.Parameters["@FullCoverage"].Value = user.FullCoverage;
                command.Parameters["@Quote"].Value = user.Quote;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return View("CaculateTotal",user);
        }
        public ActionResult CaculateTotal(User user)
        {

            string queryString = "Select * From Users where user.Id = @Id";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters["@Id"].Value = user.Id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    user.Id = Convert.ToInt32(reader["Id"]);
                    user.FirstName = reader["FirstName"].ToString();
                    user.LastName = reader["LastName"].ToString();
                    user.EmailAddress = reader["EmailAddress"].ToString();
                    user.Age = Convert.ToInt32(reader["Age"]);
                    user.CarYear = Convert.ToInt32(reader["CarYear"]);
                    user.CarModel = reader["CarModel"].ToString();
                    user.CarMake = reader["CarMake"].ToString();
                    user.UserSpeedingTickets = Convert.ToInt32(reader["UserSpeedingTickets"]);
                    user.UserDui = Convert.ToBoolean(reader["UserDui"]);
                    user.FullCoverage = Convert.ToBoolean(reader["FullCoverage"]);
                }
                connection.Close();

                return View(user);
            }
        }
    }
}