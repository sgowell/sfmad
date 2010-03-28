using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using NHibernate;
using Web.Data;

namespace Web.Models.Data
{
    public interface IUserRepository : IRepository<LogOnModel>
    {
        bool ValidateUser(string userName, string password);
    }

    public class UserRepository : RepositoryBase<LogOnModel>, IUserRepository 
    {
        public UserRepository(ISession  session  ) : base(session )
        {
        }

        public bool ValidateUser(string userName, string password)
        {
            string hashedPassword = GetMd5Sum(password);
            IDictionary<string,object> userInfo = new Dictionary<string, object>();
            userInfo.Add("UserName",userName );
            userInfo.Add("Password",hashedPassword );
            return this.FindOne(userInfo) != null;
        }

        public string GetMd5Sum(string str){    
            // First we need to convert the string into bytes, which    
            // means using a text encoder.    
            Encoder enc = System.Text.Encoding.Unicode.GetEncoder();    
            // Create a buffer large enough to hold the string    
            byte[] unicodeText = new byte[str.Length * 2];    
            enc.GetBytes(str.ToCharArray(), 0, str.Length, unicodeText, 0, true);    
            // Now that we have a byte array we can ask the CSP to hash it    
            MD5 md5 = new MD5CryptoServiceProvider();    
            byte[] result = md5.ComputeHash(unicodeText);    
            // Build the final string by converting each byte    
            // into hex and appending it to a StringBuilder    
            StringBuilder sb = new StringBuilder();    
            for (int i=0;i<result.Length;i++)    
            {        sb.Append(result[i].ToString("X2"));    }    
            // And return it    
            return sb.ToString();}

    }
}
