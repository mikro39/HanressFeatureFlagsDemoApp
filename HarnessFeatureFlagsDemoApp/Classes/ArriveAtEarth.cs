using io.harness.cfsdk.client.api;
using io.harness.cfsdk.client.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarnessFeatureFlagsDemoApp.Classes
{

    public class ArriveAtEarth : FeatureFlag
    {
        public ArriveAtEarth(CfClient client, Target target)
            : base(client, target, "arriveatearth")
        {
        }

        public override bool IsEnabled()
        {
            return Client.boolVariation(FlagName, Target, false);
        }
    }
}
