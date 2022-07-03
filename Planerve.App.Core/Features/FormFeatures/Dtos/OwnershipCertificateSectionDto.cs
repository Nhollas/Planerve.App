using System;
using System.Collections.Generic;
namespace Planerve.App.Core.Features.FormFeatures.Dtos
{
    public class OwnershipCertificationSectionDto
    {
        public int SelectedCertificate { get; set; }
        public bool SoleOwner { get; set; }
        public bool IsAgriculturalHolding { get; set; }
        public bool GiveAppropriateNotice { get; set; }
        public bool GiveSomeNotice { get; set; }
        public CertificateADto CertificateA { get; set; }
        public CertificateBDto CertificateB { get; set; }
        public CertificateCDto CertificateC { get; set; }
        public CertificateDDto CertificateD { get; set; }
        public ICollection<PersonDto> Persons { get; set; }
    }

    public class CertificateADto
    {
        public int Role { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DeclarationDate { get; set; }
        public bool DeclarationMade { get; set; }
    }

    public class CertificateBDto
    {
        public bool Certifies { get; set; }
        public int Role { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DeclarationDate { get; set; }
        public bool DeclarationMade { get; set; }
    }

    public class CertificateCDto
    {
        public string StepsTakenDescription { get; set; }
        public string PublishedInPaper { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Role { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DeclarationDate { get; set; }
        public bool DeclarationMade { get; set; }
    }

    public class CertificateDDto
    {
        public string StepsTaken { get; set; }
        public string PublishedInPaper { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Role { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DeclarationDate { get; set; }
        public bool DeclarationMade { get; set; }
    }

    public class PersonDto
    {
        public int CertificateId { get; set; }
        public string Name { get; set; }
        public string HouseName { get; set; }
        public string HouseNumber { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressLineThree { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public DateTime NoticeServed { get; set; }
    }
}
