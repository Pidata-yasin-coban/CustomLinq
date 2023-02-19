using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinq
{
    public static class LinQExtensions
    {
        public static IEnumerable<UserModel> CustomWhere_EvenID(this IEnumerable<UserModel> users)
        {
            var result = new List<UserModel>();

            foreach (var user in users)
            {
                if (user.Id % 2 == 0)
                {
                    result.Add(user);
                }
            }

            return result;
        }
        public static IEnumerable<UserModel> CustomWhere_GmailUsers(this IEnumerable<UserModel> users)
        {
            var result = new List<UserModel>();

            foreach (var user in users)
            {
                if (user.Email.EndsWith("gmail.com"))
                {
                    result.Add(user);
                }
            }

            return result;
        }
        public static List<UserModel> CustomToList(this IEnumerable<UserModel> users)
        {
            var result = new List<UserModel>();

            foreach (var user in users)
            {
                result.Add(user);
            }

            return result;
        }
        public static UserModel CustomFirstOrDefault(this IEnumerable<UserModel> users)
        {
            foreach (var user in users)
            {
                return user;
            }

            return null;
        }

        public static UserModel CustomFirstOrDefault_FirstNameLengthGrater4(this IEnumerable<UserModel> users)
        {
            foreach (var user in users)
            {
                if (user.FirstName.Length > 4)
                {
                    return user;
                }
               
            }

            return null;
        }
    }
}
