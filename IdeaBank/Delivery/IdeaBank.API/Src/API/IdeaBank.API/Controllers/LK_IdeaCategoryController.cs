

using IdeaBank.Application.Features.IdeaCategoryFeature.Command.Delete;
using IdeaBank.Application.Features.IdeaCategoryFeature.Command.Post;
using IdeaBank.Application.Features.IdeaCategoryFeature.Command.Put;
using IdeaBank.Application.Features.IdeaCategoryFeature.Query.GetAllCategoryIdea;
using IdeaBank.Application.Features.IdeaCategoryFeature.Query.GetById;

namespace IdeaBank.API.Controllers
{

    public class LK_IdeaCategoryController : BaseController
    {
        private readonly IMediator _mediator;

        public LK_IdeaCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<ResponseDTO> Post(PostLkIdeaCategoryDto dto)
        {
            return await _mediator.Send(new PostLLK_IdeaCategoryCommand(dto));
        }


        [HttpPut]
        public async Task<ResponseDTO> Put(int Id, PostLkIdeaCategoryDto dto)
        {
            return await _mediator.Send(new PutLK_IdeaCategoryCommand(dto, Id));
        }

        [HttpDelete]
        public async Task<ResponseDTO> Delete(int Id)
        {
            return await _mediator.Send(new DeletetLK_IdeaCategoryCommand(Id));
        }

        [HttpGet]

        public async Task<ResponseDTO> GetAll()
        {
            return await _mediator.Send(new GetAllCategoryIdeaQuery());

        }


        [HttpGet("{Id}")]

        public async Task<ResponseDTO> Get(int Id)
        {
            return await _mediator.Send(new GetLK_IdeaCategoryByIdQuery(Id));
        }
    }
}
