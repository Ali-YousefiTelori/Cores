﻿using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.Cores.Tests.DatabaseLogics.Database.Entities;
using EasyMicroservices.ServiceContracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMicroservices.Cores.AspCore.Tests.Controllers
{
    public class UserController : SimpleQueryServiceController<UserEntity, UserEntity, UserEntity, UserEntity, long>
    {
        public UserController(IContractLogic<UserEntity, UserEntity, UserEntity, UserEntity, long> contractLogic) : base(contractLogic)
        {
        }

        [Authorize]
        [HttpGet]
        public MessageContract AuthorizeError()
        {
            return true;
        }

        [HttpGet]
        public MessageContract InternalError()
        {
            throw new Exception("Internal Error!");
        }
    }
}
