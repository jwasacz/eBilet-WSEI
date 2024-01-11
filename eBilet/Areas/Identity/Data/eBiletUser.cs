using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace eBilet.Areas.Identity.Data;

// Add profile data for application users by adding properties to the eBiletUser class
public class eBiletUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

