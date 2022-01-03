using PressSdk.CodeGenerators.Abstract.Patterns.SeDefinitions;
using SE.ErrorsDefinitions.ErrorEvents.Enums;
using static SE.ErrorsDefinitions.ErrorEvents.Enums.ErrorEnumerations;

namespace SE.ErrorsDefinitions.ErrorEvents
{
    [ErrorEvent]
    [Description("aSID temperature sensor is not responding")]
    [Extension(nameof(ErrorEventExtension.EventHelper))]
    [Classification(nameof(ErrorEventClassification.AsidEvents))]
    [WhatToDo("Verify sensor wiring are not damaged")]
    [SuspectedCause("")]
    [EventTrigger("aSID temperature sensor is stuck")]
    public class ASID_IR_MLX_FREEZE
    {
        [SensorIDParam]
        public SensorID Sensor { get; }
		
		[SensorIDParam1]
		
        public SensorID Sensor123 { get; }

    }
}


