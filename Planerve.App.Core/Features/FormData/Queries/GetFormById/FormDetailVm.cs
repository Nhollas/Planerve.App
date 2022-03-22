using Planerve.App.Domain.Entities.FormEntities;
using System;

namespace Planerve.App.Core.Features.FormData.Queries.GetFormById;

public class FormDetailVm
{
    public Guid Id { get; set; }
    public int ApplicationType { get; set; }
    public FormTypeOne FormTypeOneData { get; set; }
    public FormTypeTwo FormTypeTwoData { get; set; }
}