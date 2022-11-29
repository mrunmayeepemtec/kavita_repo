using CRudApplication.CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRudApplication.RepositoryLayer
{
    public interface ICrudApplicationRL
    {
        public Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request);
        public Task<UserLoginResponse> UserLogin(UserLoginRequest request);
        public Task<AddInformationResponse> AddInformation(AddInformationRequest request);
        public Task<ReadInformationResponse> ReadAllInformation();
        public Task<ReadInformationByIdResponse> ReadInformationById(ReadInformationByIdRequest request);
        public Task<UpdateAllInformationByIdResponse> UpdateAllInformationById(UpdateAllInformationByIdRequest request);
        public Task<UpdateOneInformationByIdResponse> UpdateOneInformationById(UpdateOneInformationByIdRequest request);
        public Task<DeleteInformationByIDResponse> DeleteInformationByID(DeleteInformationByIDRequest request);
        public Task<GetAllDeleteInformationResponse> GetAllDeleteInformation();
        public Task<DeleteAllInformationResponse> DeleteAllInActiveInformation();
    }
}