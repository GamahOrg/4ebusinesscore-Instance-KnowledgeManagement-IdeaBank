global using Domain.Enums;
global using System.Text.Json;
global using IdeaBank.Infrastructure.ResponseDto;
global using IdeaBank.Infrastructure.UnitOfWork;
global using IdeaBank.Infrastructure.GenericRepo;
global using IdeaBank.Infrastructure.Helpers;
global using IdeaBank.Application.Helpers;
global using IdeaBank.Application;
global using IdeaBank.API.Extension;
global using MediatR;
global using FluentValidation.AspNetCore;
global using Microsoft.Extensions.FileProviders;
global using Microsoft.Net.Http.Headers;
global using Microsoft.OpenApi.Models;
global using IdeaBank.API.MiddleWares;
global using Microsoft.EntityFrameworkCore;
global using IdeaBank.Infrastructure.Context;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Authorization;
global using IdeaBank.API.Controllers;
global using IdeaBank.Application.Features.Idea.Command.Delete;
global using IdeaBank.Application.Features.Idea.Command.Post;
global using IdeaBank.Application.Features.Idea.Command.Put;
global using IdeaBank.Application.Features.Likes.Command.Post;
global using IdeaBank.Application.Features.Likes.Query.GetIdeaLikes;
global using IdeaBank.Application.Features.Comments.Command.Post;
global using IdeaBank.Application.Features.Comments.Command.Put;
global using IdeaBank.Application.Features.Comments.Command.Delete;
global using IdeaBank.Application.Features.Rates.Command.Post;
global using IdeaBank.Application.Features.Rates.Query;
global using IdeaBank.Application.Features.Likes.Command.PostCommentLike;
global using IdeaBank.Application.Features.Idea.Query.GetAllPaginated;
global using IdeaBank.Application.Features.Idea.Query.GetIdeaBankDetails;
global using IdeaBank.Application.Features.Comments.Query.GetAllPaginated;
global using IdeaBank.Application.Features.Idea.Command.ChangeRequestStatus;
global using IdeaBank.Application.Features.Idea.Query.GetAllIdeasByRequestStage;
global using IdeaBank.Application.Features.Idea.Query.GetIdeaDetailsByRequestStage;
global using Serilog;
global using IdeaBank.Application.Services;





