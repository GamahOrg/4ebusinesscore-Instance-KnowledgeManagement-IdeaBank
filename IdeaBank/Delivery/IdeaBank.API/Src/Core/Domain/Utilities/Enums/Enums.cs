namespace Domain.Enums
{
    public enum State
    {
        NotDeleted,
        Deleted
    }
    public enum StatusEnum
    {
        FailedToSave,
        SavedSuccessfully,
        Exception,
        Success,
        Failed,
        FailedToFindTheObject,
        AlreadyExisting
    }
    public enum ActionNameEnum
    {
        Get,
        Post,
        Put,
        Delete,
    }

    public enum NewsStatus
    {
        Ordinary,
        Important
    }

    public enum IdeaCategory
    {
        WorkImprovment,
        WorkDevelopment,
        EventProposal,
        TechnicalDevelopment,
        RealState,
        SolveProblem,
        ImprovingExistingProject,
        NewIdea

    }
    public enum LikeStatus
    {
        Like,
        Dislike
    }
    public enum RequestStage
    {
        Pending = 1,
        Accept = 2,
        Rejected = 3 ,
        AcceptAndNotPublished = 4
    }
}