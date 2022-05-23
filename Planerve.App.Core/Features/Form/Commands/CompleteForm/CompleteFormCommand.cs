﻿using MediatR;
using Planerve.App.Domain.Entities.FormEntities;
using System;

namespace Planerve.App.Core.Features.FormData.Commands.CompleteForm
{
    public class CompleteFormCommand : IRequest
    {
        public Guid Id { get; set; }
        public FormTypeOne FormTypeOneData { get; set; }
        public FormTypeTwo FormTypeTwoData { get; set; }
    }
}