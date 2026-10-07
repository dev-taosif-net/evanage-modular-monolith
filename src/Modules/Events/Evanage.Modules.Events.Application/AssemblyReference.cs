using System.Reflection;

namespace Evanage.Modules.Events.Application;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}
