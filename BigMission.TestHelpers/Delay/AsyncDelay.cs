using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMission.TestHelpers.Delay;

public class AsyncDelay : IAsyncDelay
{
    public Task Delay(TimeSpan delay)
    {
        return Task.Delay(delay);
    }
}
