namespace IdeaBank.API.Controller
{
    public class IdeaController : BaseController
    {
        private readonly IMediator _mediator;
        public IdeaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("PostIdea")]
        public async Task<ResponseDTO> PostIdea([FromForm] PostIdeaCommand command)
        {
            return await _mediator.Send(command);
        }

        //// GetAll 
        //[HttpGet]
        //[Route("GetAllIdeasPaginated")]
        //public async Task<ResponseDTO> GetAllIdeasPaginated(int pageNumber, int pageSize)
        //{
        //    var query = new GetAllIdeasPaginatedQuery(pageNumber, pageSize);
        //    return await _mediator.Send(query);
        //}

        //// GetById
        //[HttpGet, Route("GetIdeaDetailsById/{ideaId}")]
        //public async Task<ResponseDTO> GetIdeaDetailsId(Guid ideaId) => await _mediator.Send(new GetIdeaBankDetailsQuery(ideaId));

        [HttpPut("PutIdea/{ideaId}")]
        public async Task<ResponseDTO> PutIdea([FromRoute] Guid ideaId, [FromForm] PutIdeaCommand command)
        {
            command.IdeaId = ideaId;
            return await _mediator.Send(command);
        }

        [HttpDelete]
        [Route("DeleteIdea/{ideaId}")]
        public async Task<ResponseDTO> DeleteIdea(Guid ideaId) => await _mediator.Send(new DeleteIdeaCommand(ideaId));

        [HttpPut("ChangeRequestStage/{ideaId}")]
        public async Task<ResponseDTO> ChangeRequestStage([FromRoute] Guid ideaId, [FromBody] UpdateRequestStageCommand command)
        {
            command.IdeaId = ideaId;
            return await _mediator.Send(command);
        }

        [HttpGet]
            [Route("GetAllIdeasByRequestStage")]
        public async Task<ResponseDTO> GetAllIdeasByRequestStage(int requestStage, int pageNumber, int pageSize)
        {
            var query = new GetIdeasByRequestStageQuery(requestStage, pageNumber, pageSize);
            return await _mediator.Send(query);
        }

        [HttpGet]
        [Route("GetIdeaDetailsByRequestStage/{ideaId}")]
        public async Task<ResponseDTO> GetIdeaDetailsByRequestStage(Guid ideaId, int requestStage)
        {
            var query = new GetIdeaDetailsByRequestStageQuery(ideaId, requestStage);
            return await _mediator.Send(query);
        }

        [HttpPost]
        [Route("PostIdeaLikeDislike")]
        public async Task<ResponseDTO> PostIdeaLikeDislike([FromBody] PostIdeaLikeCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPost]
        [Route("PostIdeaComment")]
        public async Task<ResponseDTO> PostIdeaComment([FromBody] PostIdeaCommentCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("PutIdeaComment/{commentId}")]
        public async Task<ResponseDTO> PutIdeaComment([FromRoute] Guid commentId, [FromBody] PutIdeaCommentCommand command)
        {
            command.CommentId = commentId;
            return await _mediator.Send(command);
        }

        [HttpDelete]
        [Route("DeleteIdeaComment/{commentId}")]
        public async Task<ResponseDTO> DeleteIdeaComment(Guid commentId) => await _mediator.Send(new DeleteIdeaCommentCommand(commentId));

        [HttpPost]
        [Route("PostCommentLikeDislike")]
        public async Task<ResponseDTO> PostCommentLikeDislike([FromBody] PostCommentLikeCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPost, Route("PostIdeaRating")]
        public async Task<ResponseDTO> PostIdeaRating([FromBody] PostIdeaRateCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpGet]
        [Route("GetIdeaRates/{ideaId}")]
        public async Task<ResponseDTO> GetIdeaRates(Guid ideaId)
        {
            return await _mediator.Send(new GetIdeaRateQuery(ideaId));
        }

        /*[HttpGet]
        [Route("GetAllIdeasCommentsPaginated")]
        public async Task<ResponseDTO> GetAllIdeasCommentsPaginated(int pageNumber, int pageSize)
        {
            var query = new GetAllIdeaCommentsPaginatedQuery(pageNumber, pageSize);
            return await _mediator.Send(query);
        }*/

    }
}
