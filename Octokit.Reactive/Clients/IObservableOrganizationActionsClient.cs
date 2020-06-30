﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Octokit.Reactive
{
    /// <summary>
    /// A client for GitHub's Org Actions API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developer.github.com/v3/actions/"> Actions API documentation</a> for more information.
    /// </remarks>
    public interface IObservableOrganizationActionsClient
    {
        /// <summary>
        /// Returns a client to manage organization secrets.
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/actions/secrets"> Secrets API documentation</a> for more information.
        /// </remarks>
        IObservableOrganizationSecretsClient Secrets { get; }
    }
}
