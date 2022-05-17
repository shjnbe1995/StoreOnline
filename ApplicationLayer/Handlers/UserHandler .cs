using ApplicationLayer.Commands;
using ApplicationLayer.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Handlers
{
    public class UserHandler: IRequestHandler<UserCommand, UserResponse>
    {
    }
}
