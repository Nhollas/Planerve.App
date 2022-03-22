using System;

namespace Planerve.App.Core.Exceptions
{
    public class NotAuthorisedException : ApplicationException
    {

        public NotAuthorisedException(string name, object userId)
            : base($"({userId}) is not authorised to view this item.")
        {
        }
    }
}
