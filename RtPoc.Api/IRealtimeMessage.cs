using System.Threading.Tasks;

namespace RtPoc.Api
{
    public interface IRealtimeMessage
    {
        Task OnChangeTime(string time);
    }
}