using PIckupPoint.BO.ResponseModels;
using PIckupPoint.BO.ResponseModels.PickuPointsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickupPointsAPIHelper.ApiHelperLogic.Interfaces
{
    public interface IApiHelperLogic
    {
        Task<LoginResponse> LoginRequest(string userName, string password);
        Task<Root> GetPickuPoints(string accessToken);
    }
}
