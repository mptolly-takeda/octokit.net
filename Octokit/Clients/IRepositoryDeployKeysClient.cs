﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octokit
{
    public interface IRepositoryDeployKeysClient
    {
        /// <summary>
        /// Get a single deploy key by number for a repository.
        /// </summary>
        /// <param name="owner">The owner of the repository.</param>
        /// <param name="name">The name of the repository.</param>
        /// <param name="number">The id of the deploy key.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get")]
        Task<DeployKey> Get(string owner, string name, int number);

        /// <summary>
        /// Get all deploy keys for a repository.
        /// </summary>
        /// <param name="owner">The owner of the repository.</param>
        /// <param name="name">The name of the repository.</param>
        Task<IReadOnlyList<DeployKey>> GetForRepository(string owner, string name);

        /// <summary>
        /// Creates a new deploy key for a repository.
        /// </summary>
        /// <param name="owner">The owner of the repository.</param>
        /// <param name="name">The name of the repository.</param>
        /// <param name="newDeployKey">The deploy key to create for the repository.</param>
        /// <returns></returns>
        Task<DeployKey> Create(string owner, string name, NewDeployKey newDeployKey);

        /// <summary>
        /// Deploy keys are immutable. If you need to update a key, remove the key and create a new one instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="newDeployKey"></param>
        /// <returns></returns>
        /// Task<DeployKey> Update(string owner, string name, int number, NewDeployKey newDeployKey);
        
        /// <summary>
        /// Deletes a deploy key from a repository.
        /// </summary>
        /// <param name="owner">The owner of the repository.</param>
        /// <param name="name">The name of the repository.</param>
        /// <param name="number">The id of the deploy key to delete.</param>
        /// <returns></returns>
        Task Delete(string owner, string name, int number);
    }
}
