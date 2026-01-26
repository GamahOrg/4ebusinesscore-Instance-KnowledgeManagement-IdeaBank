
using IdeaBank.Application.Features.Lk_RequestStageFeature.Command.Delete;
using IdeaBank.Application.Features.Lk_RequestStageFeature.Command.Post;
using IdeaBank.Application.Features.Lk_RequestStageFeature.Command.Put;
using IdeaBank.Application.Features.Lk_RequestStageFeature.Query.GetAll;
using IdeaBank.Application.Features.Lk_RequestStageFeature.Query.GetById;

namespace IdeaBank.API.Controllers
{
 
    public class Lk_RequestStageController : BaseController
    {
        private readonly IMediator _mediator;

        public Lk_RequestStageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseDTO> Post(PostLk_RequestStageDto dto)
        {
            return await _mediator.Send(new PostLk_RequestStageCommand(dto));
        }


        [HttpPut]
        public async Task<ResponseDTO> Put(int Id, PostLk_RequestStageDto dto)
        {
            return await _mediator.Send(new PutLk_RequestStageCommand( Id , dto));
        }

        [HttpDelete]
        public async Task<ResponseDTO> Delete(int Id)
        {
            return await _mediator.Send(new DeleteLk_RequestStageCommand(Id));
        }

        [HttpGet]

        public async Task<ResponseDTO> GetAll([FromQuery] GetAllLk_RequestStagesRequest dto)
        {
            return await _mediator.Send(new GetAllLk_RequestStagesQuery(dto));

        }


        [HttpGet("{Id}")]

        public async Task<ResponseDTO> Get(int Id)
        {
            return await _mediator.Send(new GetLk_RequestStageByIdQuery(Id));
        }
    }
}
