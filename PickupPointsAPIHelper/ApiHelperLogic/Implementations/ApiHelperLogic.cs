using Newtonsoft.Json;
using PIckupPoint.BO.ResponseModels;
using PIckupPoint.BO.ResponseModels.PickuPointsModels;
using PickupPointsAPIHelper.ApiHelperLogic.Interfaces;
using PickupPointsAPIHelper.RestClientLogic.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickupPointsAPIHelper.ApiHelperLogic.Implementations
{
    public class ApiHelperLogic : IApiHelperLogic
    {
        private readonly string _apiUri="https://api.staging.pargo.co.za/";
        private readonly IRestClientHelper _restClientHelper;

        public ApiHelperLogic(IRestClientHelper restClientHelper)
        {
            _restClientHelper = restClientHelper;
        }

        public async Task<Root> GetPickuPoints(string accessToken)
        {
            var restClient = _restClientHelper.restClient($"{_apiUri}pickup_points");
            restClient.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("authorization", $"Bearer {accessToken}");
            IRestResponse restResponse = await restClient.ExecuteAsync<Root>(request);
            var restResponseContent = restResponse.Content;
            var formatedRestResponse = JsonConvert.DeserializeObject<Root>(restResponseContent);
            return formatedRestResponse;
        }

        public async Task<LoginResponse> LoginRequest(string userName, string password)
        {
            var restClient = _restClientHelper.restClient($"{_apiUri}auth");
            restClient.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse restResponse = await restClient.ExecuteAsync<LoginResponse>(request);
            var restResponseContent = restResponse.Content;
            var formatedRestResponse = JsonConvert.DeserializeObject<LoginResponse>(restResponseContent);
            return formatedRestResponse;
        }
    }
}
