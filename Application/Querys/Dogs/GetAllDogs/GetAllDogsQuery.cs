using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Querys.Dogs.GetAllDogs
{
    public class GetAllDogsQuery : IRequest<List<Dog>>
    {
    }
}
