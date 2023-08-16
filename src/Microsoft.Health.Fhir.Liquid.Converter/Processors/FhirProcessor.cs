﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using Microsoft.Health.Fhir.Liquid.Converter.Models;
using Microsoft.Health.Logging.Telemetry;

namespace Microsoft.Health.Fhir.Liquid.Converter.Processors
{
    public class FhirProcessor : JsonProcessor
    {
        public FhirProcessor(ProcessorSettings processorSettings, ITelemetryLogger telemetryLogger)
            : base(processorSettings, telemetryLogger)
        {
        }

        protected override string InternalConvert(string data, string rootTemplate, ITemplateProvider templateProvider, TraceInfo traceInfo = null)
        {
            // TO DO For FHIR Specific Logic
            // 1. Add FHIR related checks for pre-processor and post-processor.
            // 2. Add log for version conversion.
            // 3. Add logic to process "extension" and "contained" fields.

            return base.InternalConvert(data, rootTemplate, templateProvider, traceInfo);
        }
    }
}
