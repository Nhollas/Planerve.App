using Planerve.App.Domain.Entities.FormEntities;

namespace Planerve.App.Core.UnitTests.DataStores
{
    // TODO: Configure this properly.

    public static class FormDataStore
    {
        public static List<FormTypeA> FormTypeA
        {
            get
            {
                return new List<FormTypeA>()
                {
                    new FormTypeA
                    {
                        FormId = Guid.NewGuid(),
                    }
                };
            }
        }

        public static List<FormTypeB> FormTypeB
        {
            get
            {
                return new List<FormTypeB>()
                {
                    new FormTypeB
                    {
                        FormId = Guid.NewGuid(),
                    }
                };
            }
        }

        public static List<FormTypeC> FormTypeC
        {
            get
            {
                return new List<FormTypeC>()
                {
                    new FormTypeC
                    {
                        FormId = Guid.NewGuid(),
                    }
                };
            }
        }

        public static List<FormTypeD> FormTypeD
        {
            get
            {
                return new List<FormTypeD>()
                {
                    new FormTypeD
                    {
                        FormId = Guid.NewGuid(),
                    }
                };
            }
        }

        public static List<FormTypeE> FormTypeE
        {
            get
            {
                return new List<FormTypeE>()
                {
                    new FormTypeE
                    {
                        FormId = Guid.NewGuid(),
                    }
                };
            }
        }
    }
}
