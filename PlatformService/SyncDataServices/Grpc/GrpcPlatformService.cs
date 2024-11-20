using AutoMapper;
using Grpc.Core;
using PlatformService.Data;

namespace PlatformService.SyncDataServices.Grpc
{
    public class GrpcPlatformService : GrpcPlatform.GrpcPlatformBase
    {
        #region Failds
        private readonly IPlatformRepo _Repo;
        private readonly IMapper _mapper;
        #endregion

        public GrpcPlatformService(IPlatformRepo Repo, IMapper mapper)
        {
            _Repo = Repo;
            _mapper = mapper;
        }


        public override Task<PlatformResponse> GetAllPlatforms(GetAllRequest request, ServerCallContext context)
        {
            var response = new PlatformResponse();
            var platforms = _Repo.GetAllPlatforms();
            foreach (var plat in platforms)
            {
                response.Platform.Add(_mapper.Map<GrpcPlatformModel>(plat));
            }
            return Task.FromResult(response);
        }

    }
}
