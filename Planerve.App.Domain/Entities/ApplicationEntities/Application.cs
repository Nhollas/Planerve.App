using Planerve.App.Domain.Entities.FormEntities;
using System;

namespace Planerve.App.Domain.Entities.ApplicationEntities;

public class Application
{
    public Guid Id { get; set; }
    public string ApplicationReference { get; set; }
    public string ApplicationName { get; set; }
    public string FullAddress { get; set; }
    public string OwnerId { get; set; }
    public int ApplicationType { get; set; }
    public SiteApiData SiteApiData { get; set; }
    public ApplicationTypeOne ApplicationTypeOne { get; set; }
    public ApplicationTypeTwo ApplicationTypeTwo { get; set; }
}