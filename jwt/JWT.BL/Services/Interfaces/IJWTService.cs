using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT.BL.Services.Interfaces;

public interface IJWTService
{
    string GenerateToken(string username);
}
