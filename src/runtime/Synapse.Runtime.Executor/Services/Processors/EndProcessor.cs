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

using Synapse.Integration.Events.WorkflowActivities;

namespace Synapse.Runtime.Executor.Services.Processors
{

    /// <summary>
    /// Represents an <see cref="IWorkflowActivityProcessor"/> used to process <see cref="EndDefinition"/>s
    /// </summary>
    public class EndProcessor
        : WorkflowActivityProcessor, IEndProcessor
    {

        /// <inheritdoc/>
        public EndProcessor(ILoggerFactory loggerFactory, IWorkflowRuntimeContext context, IWorkflowActivityProcessorFactory activityProcessorFactory, 
            IOptions<ApplicationOptions> options, V1WorkflowActivity activity, EndDefinition end) 
            : base(loggerFactory, context, activityProcessorFactory, options, activity)
        {
            this.End = end;
        }

        /// <summary>
        /// Gets the <see cref="EndDefinition"/> to process
        /// </summary>
        public EndDefinition? End { get; }

        /// <inheritdoc/>
        protected override Task InitializeAsync(CancellationToken cancellationToken)
        {
            //TODO
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        protected override async Task ProcessAsync(CancellationToken cancellationToken)
        {
            //TODO
            await this.OnNextAsync(new V1WorkflowActivityCompletedIntegrationEvent(this.Activity.Id, this.Activity.Input), cancellationToken);
            await this.OnCompletedAsync(cancellationToken);
        }

    }

}
