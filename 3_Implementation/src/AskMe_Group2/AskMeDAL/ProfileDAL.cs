using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AskMeDTO;

namespace AskMeDAL
{
    public class ProfileDAL
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        MVCGroupProjectEntities connect;
        public ProfileDAL()
        {
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectMe"].ToString());
           connect = new MVCGroupProjectEntities();
        }

        public int AddProfile(ProfileDTO profileObj)
        {
            try
            {
                sqlCmd = new SqlCommand("uspAddProfile", sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@userName", profileObj.UserName);
                sqlCmd.Parameters.AddWithValue("@uEmail", profileObj.UEmail);
                sqlCmd.Parameters.AddWithValue("@uAge", profileObj.UAge);
                


                sqlCon.Open();

                SqlParameter prmReturn = new SqlParameter();
                prmReturn.ParameterName = "ReturnValue";
                prmReturn.SqlDbType = System.Data.SqlDbType.Int;
                sqlCmd.Parameters.Add(prmReturn);
                prmReturn.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCmd.ExecuteNonQuery();
                int returnVal = Convert.ToInt32(prmReturn.Value);
                return returnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                sqlCon.Close();
            }
        }

        public List<ProfileDTO> GetProfileDetails(string userName)
        {
            try
            {
                List<ProfileDTO> profileInfo = new List<ProfileDTO>();
                var listFromDb = connect.UserDetails.Where(x => x.UserName == userName).ToList();
                foreach (var item in listFromDb)
                {
                    profileInfo.Add(new ProfileDTO
                    {
                        UserId = item.UserId,
                        UserName = item.UserName,
                        UEmail = item.UEmail,
                        UAge = item.UAge
                    });
                }

                return profileInfo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProfileDTO> GetAllProfileDetails()
        {
            try
            {
                List<ProfileDTO> profileInfo = new List<ProfileDTO>();
                var listFromDb = connect.UserDetails.ToList();
                foreach (var item in listFromDb)
                {
                    profileInfo.Add(new ProfileDTO
                    {
                        UserId = item.UserId,
                        UserName = item.UserName,
                        UEmail = item.UEmail,
                        UAge = item.UAge
                    });
                }

                return profileInfo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
