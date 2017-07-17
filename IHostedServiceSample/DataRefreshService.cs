using System;
using System.Threading;
using System.Threading.Tasks;

namespace IHostedServiceSample
{
    public class DataRefreshService : HostedService
    {
        private readonly RandomStringProvider _randomStringProvider;

        public DataRefreshService(RandomStringProvider randomStringProvider)
        {
            _randomStringProvider = randomStringProvider;
        }
        
        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                await _randomStringProvider.UpdateString(cancellationToken);
                await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
            }
        }
    }
}