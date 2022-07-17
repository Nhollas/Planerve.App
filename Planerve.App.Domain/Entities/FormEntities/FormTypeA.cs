using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities;

// Householder Planning Permission
public class FormTypeA : AuditableEntity
{
    public void Initialize(Guid formId)
    {
        FormId = formId;
        SiteSection = new SiteSection() { Id = formId };
        ApplicantSection = new ApplicantSection() { Id = formId };
        AgentSection = new AgentSection() { Id = formId };
        ProposalSection = new ProposalSection() { Id = formId };
        MaterialSection = new MaterialSection() { Id = formId };
        TreeAndHedgeSection = new TreeAndHedgeSection() { Id = formId };
        AccessSection = new AccessSection() { Id = formId };
        ParkingSection = new ParkingSection() { Id = formId };
        SiteVisitSection = new SiteVisitSection() { Id = formId };
        AdviceSection = new AdviceSection() { Id = formId };
        AuthorityMemberSection = new AuthorityMemberSection() { Id = formId };
        OwnershipCertificationSection = new OwnershipCertificationSection() { Id = formId };
    }

    [Key]
    public Guid FormId { get; set; }
    public SiteSection SiteSection { get; set; }
    public ApplicantSection ApplicantSection { get; set; }
    public AgentSection AgentSection { get; set; }
    public ProposalSection ProposalSection { get; set; }
    public MaterialSection MaterialSection { get; set; }
    public TreeAndHedgeSection TreeAndHedgeSection { get; set; }
    public AccessSection AccessSection { get; set; }
    public ParkingSection ParkingSection { get; set; }
    public SiteVisitSection SiteVisitSection { get; set; }
    public AdviceSection AdviceSection { get; set; }
    public AuthorityMemberSection AuthorityMemberSection { get; set; }
    public OwnershipCertificationSection OwnershipCertificationSection { get; set; }
}
