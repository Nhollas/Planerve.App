using System;
using System.Collections.Generic;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class OwnershipCertificationSection
    {
        public Guid Id { get; set; }
        public int SelectedCertificate { get; set; }
        public bool SoleOwner { get; set; }
        public bool IsAgriculturalHolding { get; set; }
        public bool GiveAppropriateNotice { get; set; }
        public bool GiveSomeNotice { get; set; }
        public CertificateA CertificateA { get; set; }
        public CertificateB CertificateB { get; set; }
        public CertificateC CertificateC { get; set; }
        public CertificateD CertificateD { get; set; }
        public ICollection<Person> Persons { get; set; }
    }

    public class CertificateA
    {
        public int Role { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DeclarationDate { get; set; }
        public bool DeclarationMade { get; set; }
    }

    public class CertificateB
    {
        public bool Certifies { get; set; }
        public int Role { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DeclarationDate { get; set; }
        public bool DeclarationMade { get; set; }
    }

    public class CertificateC
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

    public class CertificateD
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

    public class Person
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
