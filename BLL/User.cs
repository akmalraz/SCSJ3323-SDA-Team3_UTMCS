using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User
    {
        private readonly UserDBTableAdapter userAdapter;

        public User()
        {
            userAdapter = new UserDBTableAdapter();
        }

        public void AddUser(string matrix_id, string password, string email, string name, int phoneNumber)
        {
            userAdapter.addUser(matrix_id, password, email, name, phoneNumber);
        }

        public bool ValidateUser(string matrixId, string password, out string role)
        {
            DataTable userTable = userAdapter.GetData(); // Retrieve all user data from the database

            // Filter the userTable based on matrixId and password
            DataRow[] matchingRows = userTable.Select($"matrix_id = '{matrixId}' AND password = '{password}'");

            if (matchingRows.Length > 0)
            {
                role = matchingRows[0]["Role"].ToString();
                return true;
            }
            else
            {
                role = string.Empty;
                return false;
            }
        }

        public DataTable GetAllUsers()
        {
            return userAdapter.GetData();
        }

        public void UpdateUser(string matrixId, string email, string name, string role)
        {
            userAdapter.updateUser(matrixId, email, name, role);
        }

        public void DeleteUser(string matrixId)
        {
            userAdapter.deleteUser(matrixId);
        }

        public DataTable GetUserByMatrixId(string matrixId)
    {
        return userAdapter.GetDataByMatrix(matrixId);
    }

    public void UpdateUserDetails(string matrixId, string password, string email, string name, int phoneNumber, string profilePicPath)
    {
            userAdapter.updateUserDetail(password, email, name, phoneNumber, profilePicPath, matrixId);
    }
    }
}
