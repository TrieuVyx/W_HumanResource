using HumanResource.src.DTO.Response;
using HumanResource.src.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Controller
{
    internal class AccountController
    {
        private readonly AccountService accountService;
        public AccountController() {
            accountService = new AccountService();
        
        }  
        internal List<AccountResDTO> FindAllAccount()
        {
            try
            {


                return accountService.FindAllAccount();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ AccountController " + ex.Message);
            }
        }
    }
}
