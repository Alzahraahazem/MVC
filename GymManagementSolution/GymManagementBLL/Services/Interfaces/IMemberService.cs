﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementBLL.ViewModel.MemberViewModels;
namespace GymManagementBLL.Services.Interfaces
{
    public interface IMemberService
    {
        IEnumerable<GetAllViewModel> GetAllMembers();
    }
}
