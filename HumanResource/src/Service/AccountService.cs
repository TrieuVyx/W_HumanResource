using HumanResource.src.DTO.Response;
using HumanResource.src.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.Service
{
    internal class AccountService
    {
        private AccountRepository accountRepository;

        public AccountService() {

            accountRepository = new AccountRepository();
        }

        internal List<AccountResDTO> FindAllAccount()
        {
            try
            {
                return accountRepository.FindAllAccount();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Phát Sinh Từ AccountService " + ex.Message);
            }
        }
    }
}
