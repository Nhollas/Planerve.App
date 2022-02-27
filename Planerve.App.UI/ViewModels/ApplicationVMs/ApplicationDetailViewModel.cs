using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.UI.ViewModels.ApplicationVMs;

public class ApplicationDetailViewModel
{
    public string? ApplicationReference { get; set; }

    [Required(ErrorMessage = "An application name is required.")]
    [Display(Name = "Application Name")]
    public string? ApplicationName { get; set; }
    public string? OwnerId { get; set; }

    [Required(ErrorMessage = "An address is required.")]
    [Display(Name = "Address Line 1")]
    public string? AddressLineOne { get; set; }
    [Display(Name = "Address Line 2")]
    public string? AddressLineTwo { get; set; }
    [Display(Name = "Address Line 3")]
    public string? AddressLineThree { get; set; }
    public string? FullAddress { get; set; }
    [Required(ErrorMessage = "An application type is required.")]
    [Display(Name = "Application Type")]
    public int ApplicationType { get; set; }
    public SiteApiData? SiteApiData { get; set; }
    public ApplicationTypeOne? ApplicationTypeOne { get; set; }
    public ApplicationTypeTwo? ApplicationTypeTwo { get; set; }
}