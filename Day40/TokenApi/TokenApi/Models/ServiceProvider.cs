using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace TokenApi.Models
{
    public class ServiceProvider:OAuthAuthorizationServerProvider
    {

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            UserModel user = new UserModel();
            var u = user.ValidateUser(context.UserName, context.Password);
            if ( u== null)
            {
                context.SetError("Invalid Credentials", "Username or Password is Invalid");
                return;
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Name, u.UserName));
            identity.AddClaim(new Claim(ClaimTypes.Role, u.Role));
            identity.AddClaim(new Claim(ClaimTypes.Email, u.EmailId));
            
            context.Validated(identity);
        }
    }
}