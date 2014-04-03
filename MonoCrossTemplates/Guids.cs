// Guids.cs
// MUST match guids.h
using System;

namespace MonoCross.MonoCrossTemplates
{
    static class GuidList
    {
        public const string guidMonoCrossTemplatesPkgString = "fcd70e39-86c7-401a-8b3f-8b231c31ecd7";
        public const string guidMonoCrossTemplatesCmdSetString = "d3c49ea7-1635-40de-b655-f0e87c9c6e6d";

        public static readonly Guid guidMonoCrossTemplatesCmdSet = new Guid(guidMonoCrossTemplatesCmdSetString);
    };
}