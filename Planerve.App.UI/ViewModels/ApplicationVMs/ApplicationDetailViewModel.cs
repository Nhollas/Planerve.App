

using Planerve.App.UI.Services.Base;

namespace Planerve.App.UI.ViewModels.ApplicationVMs;

public class ApplicationDetailViewModel
{
    public Guid Id { get; set; }
    public string ApplicationReference { get; set; }
    public string ApplicationName { get; set; }
    public string OwnerId { get; set; }
    public string VersionNumber { get; set; }
    public string AddressLineOne { get; set; }
    public string AddressLineTwo { get; set; }
    public string AddressLineThree { get; set; }
    public string FullAddress { get; set; }
    public int ApplicationType { get; set; }
    public string Postcode { get; set; }
    public string LocalAuthority { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastUpdated { get; set; }
    public FormTypeOne FormTypeOne { get; set; }
    public FormTypeTwo FormTypeTwo { get; set; }
}