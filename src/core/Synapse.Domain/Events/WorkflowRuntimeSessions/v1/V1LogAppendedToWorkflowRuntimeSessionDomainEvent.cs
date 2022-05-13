﻿/*
 * Copyright © 2022-Present The Synapse Authors
 * <p>
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * <p>
 * http://www.apache.org/licenses/LICENSE-2.0
 * <p>
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

namespace Synapse.Domain.Events.WorkflowRuntimeSessions
{

    /// <summary>
    /// Represents the <see cref="IDomainEvent"/> fired whenever a new log has been outputed to a <see cref="V1WorkflowRuntimeSession"/>
    /// </summary>
    [DataTransferObjectType(typeof(Integration.Events.WorkflowRuntimeSessions.V1WorkflowRuntimeSessionLogAppendedIntegrationEvent))]
    public class V1LogAppendedToWorkflowRuntimeSessionDomainEvent
        : DomainEvent<Models.V1WorkflowRuntimeSession, string>
    {

        /// <summary>
        /// Initializes a new <see cref="V1LogAppendedToWorkflowRuntimeSessionDomainEvent"/>
        /// </summary>
        protected V1LogAppendedToWorkflowRuntimeSessionDomainEvent()
        {

        }

        /// <summary>
        /// Initializes a new <see cref="V1LogAppendedToWorkflowRuntimeSessionDomainEvent"/>
        /// </summary>
        /// <param name="id">The id of the <see cref="V1WorkflowRuntimeSession"/> that has outputted the log</param>
        /// <param name="log">The log outputed by the <see cref="V1WorkflowRuntimeSession"/></param>
        public V1LogAppendedToWorkflowRuntimeSessionDomainEvent(string id, string log)
            : base(id)
        {
            this.Log = log;
        }

        /// <summary>
        /// Gets the log outputed by the <see cref="V1WorkflowRuntimeSession"/>
        /// </summary>
        public virtual string Log { get; protected set; } = null!;

    }

}
