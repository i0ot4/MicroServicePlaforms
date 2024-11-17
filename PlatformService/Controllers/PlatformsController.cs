using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.AsyncDataServices;
using PlatformService.Data;
using PlatformService.Dtos;
using PlatformService.Models;
using PlatformService.SyncDataServices.Http;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IPlatformRepo _platformRepo;
        private readonly ICommandDataClient _commandDataClient;
        private readonly IMessageBusClient _messageBusClient;

        public PlatformsController(IPlatformRepo platformRepo, IMapper mapper, ICommandDataClient commandDataClient, IMessageBusClient messageBusClient)
        {
            _platformRepo = platformRepo;
            _mapper = mapper;
            _commandDataClient = commandDataClient;
            _messageBusClient = messageBusClient;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDtos>> GetPlatforms()
        {
            Console.WriteLine("---> Get Platforms Data <---");
            var data = _platformRepo.GetAllPlatforms();

            var dataMap = _mapper.Map<IEnumerable<PlatformReadDtos>>(data);
            return Ok(dataMap);
        }

        [HttpGet("{id}")]
        public ActionResult<PlatformReadDtos> GetPlatformById(int id)
        {
            var data = _platformRepo.GetPlatformById(id);
            if (data != null)
            {
                var dataMap = _mapper.Map<PlatformReadDtos>(data);
                return Ok(dataMap);
            }
            return RedirectToAction("GetPlatforms");
        }

        [HttpPost]
        public async Task<ActionResult<PlatformReadDtos>> CreatePlatform(PlatformCreateDto platformCreateDto)
        {
            var platformModel = _mapper.Map<Platform>(platformCreateDto);
            _platformRepo.CreatePlatform(platformModel);
            _platformRepo.SaveChanges();

            var PlatformReadDtos = _mapper.Map<PlatformReadDtos>(platformModel);

            try
            {
                await _commandDataClient.SendPlatformToCommand(PlatformReadDtos);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"----> Could not Send Synchronously: {ex.Message}");
            }

            try
            {
                var platformPublishedDto = _mapper.Map<PlatformPublishedDto>(PlatformReadDtos);
                platformPublishedDto.Event = "Platform_Publised";
                _messageBusClient.PublishNewPlatform(platformPublishedDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"----> Could not Send Asynchronously MessageBus: {ex.Message}");
            }


            return RedirectToAction("GetPlatformById", new { id = platformModel.Id });
        }


    }
}
