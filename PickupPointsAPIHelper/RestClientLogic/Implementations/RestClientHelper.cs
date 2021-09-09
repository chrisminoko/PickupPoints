
using PickupPointsAPIHelper.RestClientLogic.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickupPointsAPIHelper.RestClientLogic.Implementations
{
    public class RestClientHelper : IRestClientHelper
    {
        public RestClient restClient(string url)
        {
            return new RestClient(url);
        }
    }
}
