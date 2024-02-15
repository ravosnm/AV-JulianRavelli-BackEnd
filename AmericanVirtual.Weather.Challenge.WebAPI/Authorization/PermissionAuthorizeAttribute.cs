﻿using Microsoft.AspNetCore.Authorization;
using AmericanVirtual.Weather.Challenge.Common.Extensions;

namespace AmericanVirtual.Weather.Challenge.WebAPI.Authorization
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class PermissionAuthorizeAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// Creates a new instance of <see cref="AuthorizeAttribute"/> class.
        /// </summary>
        /// <param name="permissions">A list of permissions to authorize</param>
        public PermissionAuthorizeAttribute(params string[] permissions)
        {
            Policy = $"Permission:{permissions.PackToString(":")}";
        }
    }
}