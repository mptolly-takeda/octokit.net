﻿using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    /// <summary>
    /// Represents the public key used to sign the secrets to post to GitHub
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class RepositorySecretsPublicKey
    {
        public RepositorySecretsPublicKey()
        {

        }

        public RepositorySecretsPublicKey(int keyId, string key)
        {
            KeyId = keyId;
            Key = key;
        }

        /// <summary>
        /// The id of this repository public key. Needed to create or update a secret
        /// </summary>
        public int KeyId { get; protected set; }

        /// <summary>
        /// The public key for this repository
        /// </summary>
        public string Key { get; protected set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture,
                    "RepositorySecretPublicKey: Id: {0}", KeyId);
            }
        }
    }
}
