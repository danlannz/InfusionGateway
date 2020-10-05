using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Win32;

public static class GatewayHelper
{
  /// <summary>
  /// Gets the registered gateways from the registry.
  /// </summary>
  /// <returns>gateways in the format of [gatewayname][version].Gateway ie ibsgateway712.Gateway</returns>
  private static List<String> GetRegisteredGateways()
  {
    var keys = Registry.ClassesRoot.GetSubKeyNames().Where(x => x.StartsWith("ibsgateway", StringComparison.InvariantCultureIgnoreCase)); return keys.ToList();
  }
  public static string GetLatestRegisteredGateway()
  {
    string result = string.Empty;
    // Get all the registered gateways from the registry
    List<String> registeredGateways = GetRegisteredGateways();
    // Create the dictionary for holding the registered gateway versions
    Dictionary<int, string> versions = new Dictionary<int, string>();
    // Loop each of the registered entries
    foreach (string registeredGateway in registeredGateways)
    {
      // Break up the gateway name into an array
      // Ie. gwArr[0] = infusiongatewayxxx
      // gwArr[1] = Gateway
      string[] gwArr = registeredGateway.Split('.');
      // Ensure the string was valid and has split ok
      if (gwArr.Count() > 0)
      {
        // Convert to upper case and split on "IBSGATEWAY" portion
        // This will leave the version number
        string[] versionNumArr = gwArr[0].ToUpper().Split(new string[] { "IBSGATEWAY" }
        , StringSplitOptions.RemoveEmptyEntries);
        // Ensure the version number arr is populated
        if (versionNumArr.Count() > 0)
        {
          int versionNum = 0;
          // Try to parse the string as an integer
          if (Int32.TryParse(versionNumArr[0], out versionNum))
          {
            // Add the to list of available version if it does not already exist and the original gateway class name
            if (!versions.ContainsKey(versionNum))
            {
              versions.Add(versionNum, registeredGateway);
            }
            // Check the versions list is populated
            if (versions.Count > 0)
            {
              // Order by the highest version and set the result to that value
              result = versions.OrderByDescending(x => x.Key).FirstOrDefault().Value;
            }
            // Return the latest gateway version class name
            return result;
          }
        }
      }
    }
    return result;
  }
}
