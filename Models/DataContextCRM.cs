using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Tooling.Connector;
using System.Configuration;

namespace TaskDataCRMwebApi.Models
{
    public class DataContextCRM
    {
        public IOrganizationService Service { get; set; }

       public DataContextCRM()
       {
            string crmConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            CrmServiceClient crmSvcClient = new CrmServiceClient(crmConnectionString);
            OrganizationServiceProxy proxy = crmSvcClient.OrganizationServiceProxy;
            proxy.EnableProxyTypes();

            Service = (IOrganizationService)proxy;
        }
    }
}