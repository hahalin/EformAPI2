using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using EformAPI2.Models;


namespace EformAPI2.Repo
{
    public class AuthRepository : IDisposable
    {
        private ApplicationDbContext _ctx;
        private UserManager<ApplicationUser> _userManager;

        public AuthRepository()
        {
            _ctx = new ApplicationDbContext();
            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_ctx));
        }

        public async Task<ApplicationUser> FindUser(string userid, string pwd)
        {
            ApplicationUser user = await _userManager.FindAsync(userid, pwd);
            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}