using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using UserApp.Models;

namespace UserApp.SAL
{
    public class ServiceHelper
    {
        readonly MobileServiceClient _mobileServiceClient = new MobileServiceClient(@"http://userxamarinmarathon.azurewebsites.net");
        IMobileServiceTable<UserDetails> _userTable;

        public async Task<IEnumerable<UserDetails>> GetUsersByName(string name)
        {
            _userTable = _mobileServiceClient.GetTable<UserDetails>();

            return await _userTable.Where(u => u.FirstName== name).ToListAsync();
        }

        public async Task InsertUserDetails(UserDetails user)
        {
            _userTable = _mobileServiceClient.GetTable<UserDetails>();

            await _userTable.InsertAsync(user);
        }

    }
}