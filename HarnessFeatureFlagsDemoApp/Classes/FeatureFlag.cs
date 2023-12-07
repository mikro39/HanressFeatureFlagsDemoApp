using io.harness.cfsdk.client.api;
using io.harness.cfsdk.client.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarnessFeatureFlagsDemoApp.Classes
{
    // Define a base class for feature flags
    public abstract class FeatureFlag
    {
        protected readonly string FlagName;
        protected readonly CfClient Client;
        protected readonly Target Target;

        protected FeatureFlag(CfClient client, Target target, string flagName)
        {
            Client = client;
            Target = target;
            FlagName = flagName;
        }

        // Abstract method to be implemented by derived classes
        public abstract bool IsEnabled();
    }

}
