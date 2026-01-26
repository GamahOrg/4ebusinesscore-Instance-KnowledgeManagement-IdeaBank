using IdeaBank.Application.Features.LookUps.LK_InputType.Command.Post;
using IdeaBank.Application.Features.LookUps.LK_InputType.Query.GetAll;
using IdeaBank.Application.Features.LookUps.LK_InputTypes.Command.Delete;

namespace IdeaBank.API.Controllers
{
    public class LookUpController : BaseController
    {
        private readonly IMediator _mediator;
        public LookUpController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region Lk_InputTypes

        [HttpPost("PostLkInputType")]
        public async Task<ResponseDTO> PostLkInputType([FromForm] PostInputTypesCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpDelete("DeleteLkInputType/{id}")]
        public async Task<ResponseDTO> DeleteLkInputType(int id)
        {
            return await _mediator.Send(new DeleteInputTypesCommand { Id = id });
        }

        [HttpGet("GetAllLkInputTypes")]
        public async Task<ResponseDTO> GetAllLkInputTypes()
        {
            return await _mediator.Send(new GetAllLookUpInputTypeQuery { });
        }

        #endregion
    }
}
