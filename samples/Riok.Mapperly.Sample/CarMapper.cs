using Riok.Mapperly.Abstractions;

namespace Riok.Mapperly.Sample;

// Enums of source and target have different numeric values -> use ByName strategy to map them
[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
public static partial class CarMapper
{
    [MapProperty(nameof(Car.Manufacturer), nameof(CarDto.Producer))] // Map property with a different name in the target type
    public static partial CarDto MapCarToDto(Car car);

    [MapProperty(nameof(@Car.Manufacturer.Id), nameof(ProducerDto.Id))]
    [MapProperty(nameof(@Car.Manufacturer.Name), nameof(ProducerDto.Name))]
    public static partial ProducerDto MapCarToProducerDto(Car car);
}
