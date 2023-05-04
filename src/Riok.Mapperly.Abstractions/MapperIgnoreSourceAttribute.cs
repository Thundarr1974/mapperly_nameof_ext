using System.Runtime.CompilerServices;

namespace Riok.Mapperly.Abstractions;

/// <summary>
/// Ignores a source property from the mapping.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class MapperIgnoreSourceAttribute : Attribute
{
    /// <summary>
    /// Ignores the specified source property from the mapping.
    /// </summary>
    /// <param name="source">The name of the source property to ignore. The use of `nameof()` is encouraged.</param>
    public MapperIgnoreSourceAttribute(string source, [CallerArgumentExpression(nameof(source))] string? sourceExpression = default)
    {
        Source = MapPropertyAttribute.GetParameter(source, sourceExpression);
    }

    /// <summary>
    /// Gets the source property name which should be ignored from the mapping.
    /// </summary>
    public string Source { get; }
}
