﻿using System.Threading;

namespace Volo.Abp.BlobStoring
{
    public interface IBlobContainerFactory
    {
        /// <summary>
        /// Gets a named container.
        /// </summary>
        /// <param name="name">The name of the container</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>
        /// The container object.
        /// </returns>
        IBlobContainer Create(
            string name,
            CancellationToken cancellationToken = default
        );
    }
}