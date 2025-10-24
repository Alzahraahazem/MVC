using GymManagementBLL.Services.Interfaces;
using GymManagementBLL.ViewModel.MemberViewModels;
using GymManagementDAL.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementBLL.ViewModel.MemberViewModels;
using GymManagementDAL.Entities;
using System.Runtime.CompilerServices;
namespace GymManagementBLL.Services.Classes
{
    internal class MemberService : IMemberService
    {
        private readonly IGenericRepository<Member> _memberRepository;
        public MemberService(IGenericRepository<Member> memberRepository) {
            _memberRepository = memberRepository;
        }


        public IEnumerable<GetAllViewModel> GetAllMembers()
        {
            throw new NotImplementedException();
        }
    }
}
