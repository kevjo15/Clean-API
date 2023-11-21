using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Database;

namespace Application.Querys.Dogs.GetAllDogs
{
    internal class GetAllDogsQuerysHandler : IRequestHandler<GetAllDogsQuery, List<Dog>>
    {
        private readonly MockDatabase _mockDatabase;
        public GetAllDogsQuerysHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }
        public Task<List<Dog>> Handle(GetAllDogsQuery request, CancellationToken cancellationToken)
        {
            //
            List<Dog> allDogsFromMockDB = _mockDatabase.allDogs;
            return Task.FromResult(allDogsFromMockDB);
        }
    }
}
