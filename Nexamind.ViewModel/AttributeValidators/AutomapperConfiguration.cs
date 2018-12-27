using AutoMapper;
using Nexamind.Data.Models;
using Nexamind.ViewModel.UserViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexamind.ViewModel.AttributeValidators
{
    public class AutomapperConfiguration : Profile
    {
        public AutomapperConfiguration()
        {
            // From LoginViewModel to User
            //CreateMap<LoginViewModel, User>(MemberList.None)
            //    .ForMember(m => )
        }
    }
}
