using System.Collections.Generic;
using System.Threading.Tasks;

namespace BukSub.Services
{
    public interface IBookSubscriptionsRepository
    {
        Task SaveAsync(BookSubscriptionServiceModel bookSubscription);

        Task<bool> DeleteAsync(BookSubscriptionServiceModel bookSubscription);
    }
}
