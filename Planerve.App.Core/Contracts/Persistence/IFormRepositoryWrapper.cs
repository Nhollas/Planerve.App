using Planerve.App.Core.Contracts.Persistence.FormInterfaces;
using System;

namespace Planerve.App.Core.Contracts.Persistence
{
    public interface IFormRepositoryWrapper
    {
        IFormTypeARepository FormTypeA { get; }
        IFormTypeBRepository FormTypeB { get; }
        IFormTypeCRepository FormTypeC { get; }
        IFormTypeDRepository FormTypeD { get; }
        IFormTypeERepository FormTypeE { get; }
        IFormTypeFRepository FormTypeF { get; }
        IFormTypeGRepository FormTypeG { get; }
        IFormTypeHRepository FormTypeH { get; }
        IFormTypeIRepository FormTypeI { get; }
        IFormTypeJRepository FormTypeJ { get; }
        IFormTypeKRepository FormTypeK { get; }
        IFormTypeLRepository FormTypeL { get; }
        IFormTypeMRepository FormTypeM { get; }
        IFormTypeNRepository FormTypeN { get; }
        IFormTypeORepository FormTypeO { get; }
        IFormTypePRepository FormTypeP { get; }
        IFormTypeQRepository FormTypeQ { get; }
        IFormTypeRRepository FormTypeR { get; }
        IFormTypeSRepository FormTypeS { get; }
        IFormTypeTRepository FormTypeT { get; }
        void Save();
    }
}
