using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Persistence.FormInterfaces;
using Planerve.App.Persistence.Contexts;
using Planerve.App.Persistence.Repositories.FormRepositories;

namespace Planerve.App.Persistence.Repositories
{
    public class FormRepositoryWrapper : IFormRepositoryWrapper
    {
        private readonly PlanerveDbContext _context;
        private IFormTypeARepository _typeARepository;
        private IFormTypeBRepository _typeBRepository;
        private IFormTypeCRepository _typeCRepository;
        private IFormTypeDRepository _typeDRepository;
        private IFormTypeERepository _typeERepository;
        private IFormTypeFRepository _typeFRepository;
        private IFormTypeGRepository _typeGRepository;
        private IFormTypeHRepository _typeHRepository;
        private IFormTypeIRepository _typeIRepository;
        private IFormTypeJRepository _typeJRepository;
        private IFormTypeKRepository _typeKRepository;
        private IFormTypeLRepository _typeLRepository;
        private IFormTypeMRepository _typeMRepository;
        private IFormTypeNRepository _typeNRepository;
        private IFormTypeORepository _typeORepository;
        private IFormTypePRepository _typePRepository;
        private IFormTypeQRepository _typeQRepository;
        private IFormTypeRRepository _typeRRepository;
        private IFormTypeSRepository _typeSRepository;
        private IFormTypeTRepository _typeTRepository;

        public IFormTypeARepository FormTypeA
        {
            get
            {
                if (_typeARepository == null)
                {
                    _typeARepository = new FormTypeARepository(_context);
                }
                return _typeARepository;
            }
        }

        public IFormTypeBRepository FormTypeB
        {
            get
            {
                if (_typeBRepository == null)
                {
                    _typeBRepository = new FormTypeBRepository(_context);
                }
                return _typeBRepository;
            }
        }

        public IFormTypeCRepository FormTypeC
        {
            get
            {
                if (_typeCRepository == null)
                {
                    _typeCRepository = new FormTypeCRepository(_context);
                }
                return _typeCRepository;
            }
        }

        public IFormTypeDRepository FormTypeD
        {
            get
            {
                if (_typeDRepository == null)
                {
                    _typeDRepository = new FormTypeDRepository(_context);
                }
                return _typeDRepository;
            }
        }

        public IFormTypeERepository FormTypeE
        {
            get
            {
                if (_typeERepository == null)
                {
                    _typeERepository = new FormTypeERepository(_context);
                }
                return _typeERepository;
            }
        }

        public IFormTypeFRepository FormTypeF
        {
            get
            {
                if (_typeFRepository == null)
                {
                    _typeFRepository = new FormTypeFRepository(_context);
                }
                return _typeFRepository;
            }
        }

        public IFormTypeGRepository FormTypeG
        {
            get
            {
                if (_typeGRepository == null)
                {
                    _typeGRepository = new FormTypeGRepository(_context);
                }
                return _typeGRepository;
            }
        }

        public IFormTypeHRepository FormTypeH
        {
            get
            {
                if (_typeHRepository == null)
                {
                    _typeHRepository = new FormTypeHRepository(_context);
                }
                return _typeHRepository;
            }
        }

        public IFormTypeIRepository FormTypeI
        {
            get
            {
                if (_typeIRepository == null)
                {
                    _typeIRepository = new FormTypeIRepository(_context);
                }
                return _typeIRepository;
            }
        }

        public IFormTypeJRepository FormTypeJ
        {
            get
            {
                if (_typeJRepository == null)
                {
                    _typeJRepository = new FormTypeJRepository(_context);
                }
                return _typeJRepository;
            }
        }

        public IFormTypeKRepository FormTypeK
        {
            get
            {
                if (_typeKRepository == null)
                {
                    _typeKRepository = new FormTypeKRepository(_context);
                }
                return _typeKRepository;
            }
        }

        public IFormTypeLRepository FormTypeL
        {
            get
            {
                if (_typeLRepository == null)
                {
                    _typeLRepository = new FormTypeLRepository(_context);
                }
                return _typeLRepository;
            }
        }

        public IFormTypeMRepository FormTypeM
        {
            get
            {
                if (_typeMRepository == null)
                {
                    _typeMRepository = new FormTypeMRepository(_context);
                }
                return _typeMRepository;
            }
        }

        public IFormTypeNRepository FormTypeN
        {
            get
            {
                if (_typeNRepository == null)
                {
                    _typeNRepository = new FormTypeNRepository(_context);
                }
                return _typeNRepository;
            }
        }

        public IFormTypeORepository FormTypeO
        {
            get
            {
                if (_typeORepository == null)
                {
                    _typeORepository = new FormTypeORepository(_context);
                }
                return _typeORepository;
            }
        }

        public IFormTypePRepository FormTypeP
        {
            get
            {
                if (_typePRepository == null)
                {
                    _typePRepository = new FormTypePRepository(_context);
                }
                return _typePRepository;
            }
        }

        public IFormTypeQRepository FormTypeQ
        {
            get
            {
                if (_typeQRepository == null)
                {
                    _typeQRepository = new FormTypeQRepository(_context);
                }
                return _typeQRepository;
            }
        }

        public IFormTypeRRepository FormTypeR
        {
            get
            {
                if (_typeRRepository == null)
                {
                    _typeRRepository = new FormTypeRRepository(_context);
                }
                return _typeRRepository;
            }
        }

        public IFormTypeSRepository FormTypeS
        {
            get
            {
                if (_typeSRepository == null)
                {
                    _typeSRepository = new FormTypeSRepository(_context);
                }
                return _typeSRepository;
            }
        }

        public IFormTypeTRepository FormTypeT
        {
            get
            {
                if (_typeTRepository == null)
                {
                    _typeTRepository = new FormTypeTRepository(_context);
                }
                return _typeTRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
