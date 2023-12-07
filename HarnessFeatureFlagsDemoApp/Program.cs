using System;
using System.Collections.Generic;
using System.Threading;
using io.harness.cfsdk.client.api;
using io.harness.cfsdk.client.dto;
using HarnessFeatureFlagsDemoApp.Classes;

namespace GettingStarted
{


    class Program
    {
        public static string ApiKey = "####";

        static void Main(string[] args)
        {
            // Create a feature flag client
            var client = new CfClient(ApiKey, Config.Builder().Build());
            client.WaitForInitialization();

            // Create a target (different targets can get different results based on rules)
            Target target = Target.builder()
                            .Name("DotNET SDK")
                            .Identifier("dotnetsdk")
                            .Attributes(new Dictionary<string, string>() { { "email", "demo@harness.io" } })
                            .build();

            // Create an instance of the ArriveAtEarthFeatureFlag
            var arriveAtEarthFlag = new ArriveAtEarth(client, target);

            // Loop forever reporting the state of the flag
            while (true)
            {
                bool isArriveAtEarth = arriveAtEarthFlag.IsEnabled();
                Console.WriteLine($"POLL: Arrive At Earth = {isArriveAtEarth}");
                Thread.Sleep(10 * 1000);
            }
        }
    }
}
