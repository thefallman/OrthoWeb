﻿using System.Threading;
using System.Threading.Tasks;

namespace com.orthofeet.Shopify.Infrastructure.Policies
{
    public class DefaultRequestExecutionPolicy : IRequestExecutionPolicy
    {
        public async Task<RequestResult<T>> Run<T>(CloneableRequestMessage request, ExecuteRequestAsync<T> executeRequestAsync, CancellationToken cancellationToken)
        {
            var fullResult = await executeRequestAsync(request);

            return fullResult;
        }
    }
}
