using RestSharp;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PickupPointsAPIHelper.RestClientLogic.Interfaces
{
    public interface IRestClientHelper
    {
        RestClient restClient(string url);
    }
}
