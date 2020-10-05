using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace InfusionGateway
{
  class Program
  {
    static dynamic IBSGateway(string path, string login)
    {
      // this does not work with .NET Core 2.0

      // Attempt to get the latest gateway version registered on the server
      string latestGateway = GatewayHelper.GetLatestRegisteredGateway();
      if (string.IsNullOrWhiteSpace(latestGateway))
      {
        throw new Exception("A registered gateway could not be found");
      }
      // Create the gateway object
      Type gatewayType = Type.GetTypeFromProgID(latestGateway);
      dynamic gw = Activator.CreateInstance(gatewayType);

      gw.Init();
      gw.setpath(path);
      gw.login(login);

      return gw;
    }

    static void Main(string[] args)
    {
      string dataPath = "c:\\Infusion\\--DEMO--\\";
      string login = "HospoConnect";
      dynamic gw = IBSGateway(dataPath, login);

      // Get all customers
      gw.open("Customer", "a_customer_get");
      gw.select("a_customer_get");
      int lnRecCount = gw.reccount();
      Console.WriteLine(lnRecCount);
      gw.GoTop();

      for (int i = 0; i < lnRecCount; i++)
      {
        int account = gw.get("Account");
        string name = gw.get("Name");
        string add1 = gw.get("Add1").Trim();
        string add2 = gw.get("Add2").Trim();
        Console.WriteLine($"Account: {account}, Name: {name}, Address: {add1}, {add2}");

        gw.Skip("a_customer_get");
      }
      gw.close("a_customer_get");

      // Create an Invoice
      gw.PINVNUMBER = gw.nextinv(0).ToString().Trim();
      gw.PACCOUNT = 1000;
      gw.PDATE = DateTime.Now;
      gw.PLOCATION = 1;
      gw.PTITLE = "HOSPOCONNECT";
      Console.WriteLine($"PINVNUMBER: {gw.PINVNUMBER}, PACCOUNT: {gw.PACCOUNT}, PDATE: {gw.PDATE}, PLOCATION: {gw.PLOCATION}");
      Console.WriteLine(gw.createInvoice());

    }
  }
}
