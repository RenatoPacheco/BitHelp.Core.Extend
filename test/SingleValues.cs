using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BitHelp.Core.Extend.Test
{
    public class SingleValues
    {
        [Description("Char description")]
        public char Char { get; set; }

        [Description("String description")]
        public string String { get; set; }

        [Description("Int description")]
        public int Int { get; set; }

        [Display(Name = "Int null")]
        public int? IntNull { get; set; }

        [Description("Long description")]
        public long Long { get; set; }

        [Display(Name = "Long null")]
        public long? LongNull { get; set; }

        [Description("Decimal description")]
        public decimal Decimal { get; set; }

        [Display(Name = "Decimal null")]
        public decimal? DecimalNull { get; set; }

        [Description("Uint description")]
        public uint Uint { get; set; }

        [Display(Name = "Uint null")]
        public uint? UintNull { get; set; }

        [Display(Name = "Date time")]
        public DateTime DateTime { get; set; }

        [Display(Name = "Date time null")]
        public DateTime? DateTimeNull { get; set; }

        [Description("Guid description")]
        public Guid Guid { get; set; }

        [Display(Name = "Guid null")]
        public Guid? GuidNull { get; set; }

        [Description("Bool description")]
        public bool Bool { get; set; }

        [Display(Name = "Bool null")]
        public bool? BoolNull { get; set; }
    }
}
