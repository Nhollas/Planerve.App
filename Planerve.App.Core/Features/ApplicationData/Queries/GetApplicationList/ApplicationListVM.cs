using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using System;

namespace Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationList;

public class ApplicationListVm
{
    public Guid ApplicationId { get; set; }
    public string ApplicationName { get; set; }
    public string ApplicationReference { get; set; }
    public string OwnerId { get; set; }
    public string AddressLineOne { get; set; }
    public string AddressLineTwo { get; set; }
    public string AddressLineThree { get; set; }
    public string FullAddress => $"{AddressLineOne} {AddressLineTwo} {AddressLineThree}";
    public int ApplicationType { get; set; }
    public SiteApiData SiteApiData { get; set; }
    public ApplicationTypeOne ApplicationTypeOne { get; set; }
    public ApplicationTypeTwo ApplicationTypeTwo { get; set; }
}