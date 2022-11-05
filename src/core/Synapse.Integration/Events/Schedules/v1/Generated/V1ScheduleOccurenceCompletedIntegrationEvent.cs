﻿
/*
 * Copyright © 2022-Present The Synapse Authors
 * <p>
 * Licensed under the Apache License, Version 2.0(the "License");
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
 */

/* -----------------------------------------------------------------------
 * This file has been automatically generated by a tool
 * -----------------------------------------------------------------------
 */

namespace Synapse.Integration.Events.Schedules
{

	/// <summary>
	/// Represents the IDomainEvent fired whenever a scheduled V1Workflow has been executed
	/// </summary>
	[DataContract]
	public partial class V1ScheduleOccurenceCompletedIntegrationEvent
		: V1IntegrationEvent
	{

		/// <summary>
		/// Gets the id of the aggregate that has produced the event
		/// </summary>
		[DataMember(Name = "AggregateId", Order = 1)]
		[Description("Gets the id of the aggregate that has produced the event")]
		public virtual string AggregateId { get; set; }

		/// <summary>
		/// Gets the date and time at which the event has been produced
		/// </summary>
		[DataMember(Name = "CreatedAt", Order = 2)]
		[Description("Gets the date and time at which the event has been produced")]
		public virtual DateTime CreatedAt { get; set; }

		/// <summary>
		/// The id of the V1Schedule's occurence V1WorkflowInstance that has been executed
		/// </summary>
		[DataMember(Name = "WorkflowInstanceId", Order = 3)]
		[Description("The id of the V1Schedule's occurence V1WorkflowInstance that has been executed")]
		public virtual string WorkflowInstanceId { get; set; }

		/// <summary>
		/// The V1Schedule's next occurence
		/// </summary>
		[DataMember(Name = "NextOccurenceAt", Order = 4)]
		[Description("The V1Schedule's next occurence")]
		public virtual DateTime? NextOccurenceAt { get; set; }

    }

}
