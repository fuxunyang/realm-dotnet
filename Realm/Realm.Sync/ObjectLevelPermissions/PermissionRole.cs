﻿////////////////////////////////////////////////////////////////////////////
//
// Copyright 2018 Realm Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace Realms.Sync
{
    /// <summary>
    /// A Role within the permissions system.
    /// </summary>
    /// <remarks>
    /// A Role consists of a name for the role and a list of users which are members of the role.
    /// Roles are granted privileges on Realms, Classes and Objects, and in turn grant those
    /// privileges to all users which are members of the role.
    /// <para/>
    /// A role named "everyone" is automatically created in new Realms, and all new users which
    /// connect to the Realm are automatically added to it. Any other roles you wish to use are
    /// managed as normal Realm objects.
    /// </remarks>
    [MapTo("__Role")]
    public class PermissionRole : RealmObject
    {
        /// <summary>
        /// Gets the name of the Role.
        /// </summary>
        [MapTo("name")]
        [PrimaryKey]
        [Required]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the users which belong to the role.
        /// </summary>
        [MapTo("members")]
        public IList<PermissionUser> Users { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionRole"/> class.
        /// </summary>
        /// <param name="name">The name of the Role.</param>
        public PermissionRole(string name)
        {
            Name = name;
        }

        private PermissionRole()
        {
        }
    }
}
