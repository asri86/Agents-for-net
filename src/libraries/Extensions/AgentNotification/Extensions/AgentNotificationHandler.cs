﻿using Microsoft.Agents.Builder;
using Microsoft.Agents.Builder.State;
using Microsoft.Kairo.Sdk.AgentsSdkExtensions.Models;


namespace AgentNotification.Extensions
{
    /// <summary>
    /// Function for handling agent notification activities in an agent application.
    /// </summary>
    /// <param name="turnContext"></param>
    /// <param name="turnState"></param>
    /// <param name="agentNotificationActivity">Contains the Possible Agent Notification classes and types</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public delegate Task AgentNotificationHandler(ITurnContext turnContext, ITurnState turnState, AgentNotificationActivity agentNotificationActivity, CancellationToken cancellationToken);
}
