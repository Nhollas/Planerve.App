using System;

namespace Planerve.App.Core.Exceptions;

public class NotFoundException : ApplicationException
{
    public NotFoundException(string name, object key)
        : base($"{name} ({key}) could not be found.")
    {
    }
}