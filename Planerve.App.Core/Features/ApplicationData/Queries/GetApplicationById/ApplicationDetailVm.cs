using System;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;

namespace Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationById;

public class ApplicationDetailVm
{
    public Guid Id { get; set; }
    public string ApplicationReference { get; set; }
    public string FullAddress { get; set; }
    public int ApplicationType { get; set; }
    public SiteApiData SiteApiData { get; set; }
    public ApplicationTypeOne ApplicationTypeOne { get; set; }
    public ApplicationTypeTwo ApplicationTypeTwo { get; set; }
}