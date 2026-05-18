using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG262_Bob_s_Gym.Classes;
using PRG262_Bob_s_Gym.Exceptions;


namespace PRG262_Bob_s_Gym.DataAccess
{

    /// <summary>
    /// Methods to Create/Read/Update/Delete users on the DB.
    /// </summary>
    public class MemberDAO
    {
        /// <summary>
        /// Used to create a member.
        /// </summary>
        /// <returns>the result as an int</returns>
        public int AddMember(Member member)
        {
            SqlParameter[] parameter = {
                new SqlParameter("@FirstName", member.FirstName),
                new SqlParameter("@LastName", member.LastName),
                new SqlParameter("@DateOfBirth", member.DOB),
                new SqlParameter("@Gender", member.Gender),
                new SqlParameter("@PhoneNumber", member.PhoneNumber),
                new SqlParameter("@Address", member.Address),
                new SqlParameter("@TrainingProgram", member.TrainingProgram),
                new SqlParameter("@MembershipStartDate", member.MembershipStartDate),
                new SqlParameter("@MembershipEndDate", member.MembershipEndDate),
            };

            object result = DBHelper.ExecuteScalarVal("sp_CreateMember", CommandType.StoredProcedure, parameter);
            return Convert.ToInt32(result);
        }

        public DataTable GetAllMembers()
        {

            try
            {
                return DBHelper.ExecDataTable("sp_GetAllMembers", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving all members: {ex.Message}", ex);
                throw;
            }
        }

        /// <summary>
        /// Updates the data table 
        /// 
        /// </summary>
        /// 
        public bool UpdateMember(Member member)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MemberID", member.MemberID),
                new SqlParameter("@FirstName", member.FirstName),
                new SqlParameter("@LastName", member.LastName),
                new SqlParameter("@DateOFBirth", member.DOB),
                new SqlParameter("@Gender", member.Gender),
                new SqlParameter("@PhonNumber", member.PhoneNumber),
                new SqlParameter("@Address", member.Address),
                new SqlParameter("@TrainingProgram", member.TrainingProgram),
                new SqlParameter("@MembershipStartDate", member.MembershipStartDate),
                new SqlParameter("@MembershipEndDate", member.MembershipEndDate),
            };
            int rowsAffected = DBHelper.ExecuteNonQ("sp_UpdateMember", CommandType.StoredProcedure, parameters);

            return rowsAffected > 0;

        }

        public DataTable SearchMembers(string searchTerm)
        {
            try
            {
                SqlParameter[] parameter = { new SqlParameter("@SearchTerm", searchTerm ?? "") };
                return DBHelper.ExecDataTable("sp_SearchMembers", CommandType.StoredProcedure, parameter);
            }
            catch (CustomExceptions.RecordNotFoundException)
            {

                throw new CustomExceptions.RecordNotFoundException(searchTerm, "");
            }
        }

        /// <summary>
        /// Deletes a member from the database
        /// 
        /// </summary>
        /// <param name="memberID">ID of the member to delete</param>
        
        public bool DeleteMember(int memberID)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@MemberID", memberID)
                };

                int rowsAffected = DBHelper.ExecuteNonQ("sp_DeleteMember", CommandType.StoredProcedure, parameter);
                return rowsAffected > 0;
            } catch(Exception ex)
            {
                throw new Exception($"Error deleting member: {ex.Message}", ex);
            }

        public DataTable DeleteMember(int Id)
        {
            SqlParameter[] paramter = new SqlParameter("@MemberID", id);
            int rowsAffected = DBHelper.ExecuteNonQ("sp_DeleteMember", CommandType.StoredProcedure, paramter);
            return rowsAffected;

        }
    }
}
