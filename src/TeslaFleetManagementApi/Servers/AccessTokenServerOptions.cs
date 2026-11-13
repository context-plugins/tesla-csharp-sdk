using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi.Servers;

public class AccessTokenServerOptions
{
    public ProductionOptions Production { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Production.BaseUrl, path, []));

    public class ProductionOptions
    {
        public string BaseUrl { get; set; } = "https://fleet-auth.prd.vn.cloud.tesla.com/oauth2/v3";
    }
}
