using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planerve.App.Domain.Entities.FormEntities;

// Approval of details reserved by a condition (Discharge)
public class FormTypeC : AuditableEntity
{
    [Key]
    public Guid FormId { get; set; }
    public SiteSection SiteSection { get; set; }
    public ApplicantSection ApplicantSection { get; set; }
    public AgentSection AgentSection { get; set; }
    public ConditionProposalSection ConditionProposalSection { get; set; }
    public DischargeConditionSection DischargeConditionSection { get; set; }
    public SiteVisitSection SiteVisitSection { get; set; }
    public AdviceSection AdviceSection { get; set; }
}
