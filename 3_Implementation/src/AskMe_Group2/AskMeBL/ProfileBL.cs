using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AskMeDAL;
using AskMeDTO;

namespace AskMeBL
{
    public class ProfileBL
    {

        ProfileDAL dalObj;
        public ProfileBL()
        {
            dalObj = new ProfileDAL();
        }

        public int AddProfile(ProfileDTO profileObj)
        {
            try
            {
                var result = dalObj.AddProfile(profileObj);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProfileDTO> GetProfile(string userName)
        {
            try
            {
                var result = dalObj.GetProfileDetails(userName);
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<ProfileDTO> GetAllProfile()
        {
            try
            {
                var result = dalObj.GetAllProfileDetails();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
