using System.Threading.Tasks;
using API.Interfaces;

namespace API.Controllers
{
    public interface IUnitOfWork
    {
        IMessageRepository MessageRepository { get; }
        IUserRepository UserRepository { get; }
        ILikesRepository LikesRepository { get; set; }

        Task<bool> Complete();
        bool HasChanges();
    }
}