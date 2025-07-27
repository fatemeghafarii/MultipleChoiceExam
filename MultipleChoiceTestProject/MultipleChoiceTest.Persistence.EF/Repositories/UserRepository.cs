using MultipleChoiceTest.Model.Interfaces;
using MultipleChoiceTest.Model.Models;
using MultipleChoiceTest.Persistence.EF.Contexts;

namespace MultipleChoiceTest.Persistence.EF.Repositories;

public class UserRepository(MultipleChoiceTestContext context) :
                            BaseRepository<User, int>(context), IUserRepository
{
}
