global using FinanceAPI.Application.Features.Users.Commands.CreateUser;
global using FinanceAPI.Application.Features.Users.Commands.Login;
global using MediatR;
global using Microsoft.AspNetCore.Mvc;
global using FinanceAPI.Application.Features.FinanceRequestFeatures.Commands.CreateFinanceRequest;
global using FinanceAPI.Application.Features.FinanceRequestFeatures.Queries.GetFinanceRequests;
global using Microsoft.AspNetCore.Authorization;
global using BuildingBlocks.CQRS;
global using Microsoft.OpenApi.Models;
global using FinanceAPI.Infrastructure;
global using FinanceAPI.Application;
global using BuildingBlocks.Common;
global using BuildingBlocks.Exceptions.Handler;
global using System.Web.Http.ExceptionHandling;

