using ApiEmployee.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace ApiEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = "select id, name, age, status, createdAt from Employee";
            DataTable dataTable = new DataTable();
            String sqlDataSource = _configuration.GetConnectionString("manageuser_25_levantuoi");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    dataTable.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(dataTable);
        }

        [HttpPost]
        public JsonResult Post(Employee employee)
        {
            string query = @"Insert into Employee values
                (
                    '" + employee.name + "'" +
                    ",'" + employee.age + "'" +
                    ",'" + employee.status + "'" +
                    ",'" + employee.createdAt + "'" +
                    ")";
            DataTable dataTable = new DataTable();
            String sqlDataSource = _configuration.GetConnectionString("manageuser_25_levantuoi");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    dataTable.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Thêm mới thành công");
        }

        [HttpPut]
        public JsonResult Put(Employee employee)
        {
            string query = @"Update Employee set
                name = N'" + employee.name + "' "
                 + "age = '" + employee.age + "' "
                + "status = '" + employee.status + "' "
                + "createdAt = '" + employee.createdAt + "' "
                + "where id = " + employee.id;
            DataTable dataTable = new DataTable();
            String sqlDataSource = _configuration.GetConnectionString("manageuser_25_levantuoi");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    dataTable.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Update thành công");
        }

        [HttpDelete]
        public JsonResult Delete(int id)
        {
            string query = @"Delete from Employee " + "where id = " + id;
            DataTable dataTable = new DataTable();
            String sqlDataSource = _configuration.GetConnectionString("manageuser_25_levantuoi");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    dataTable.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Xóa thành công");
        }


        [Route("GetAllCompanyName")]
        [HttpGet]
        public JsonResult GetAllCompanyName()
        {
            string query = "select companyName from COMPANY";
            DataTable dataTable = new DataTable();
            String sqlDataSource = _configuration.GetConnectionString("manageuser_25_levantuoi");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    dataTable.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(dataTable);
        }
    }
}
