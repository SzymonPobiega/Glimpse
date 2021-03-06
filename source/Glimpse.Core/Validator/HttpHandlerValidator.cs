﻿using System.Web;
using Glimpse.Core.Configuration;
using Glimpse.Core.Extensibility;

namespace Glimpse.Core.Validator
{
    [GlimpseValidator]
    internal class HttpHandlerValidator:IGlimpseValidator
    {
        public bool IsValid(HttpContextBase context, GlimpseConfiguration configuration, LifecycleEvent lifecycleEvent)
        {
            if (lifecycleEvent == LifecycleEvent.BeginRequest || lifecycleEvent == LifecycleEvent.Handler)
                return true;

            return !(context.Handler is Handler);
        }
    }
}
