using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.ServiceModel.Description;
using System.Web;

namespace TaskDataCRMwebApi.Models
{
    public class DataContextCRM
    {
        public IOrganizationService Service { get; set; }
        //public OrganizationServiceContext Service { get; set; }

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