﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BitHelp.Core.Extend.Test
{
    public class ArrayValues
    {
        [Display(Name = "Array char")]
        public char[] Char { get; set; }

        [Display(Name = "Array string")]
        public string[] String { get; set; }

        [Display(Name = "Array int")]
        public int[] Int { get; set; }

        [Display(Name = "Array long")]
        public long[] Long { get; set; }

        [Display(Name = "Array decimal")]
        public decimal[] Decimal { get; set; }

        [Display(Name = "Array uint")]
        public uint[] Uint { get; set; }

        [Display(Name = "Array date time")]
        public DateTime[] DateTime { get; set; }

        [Display(Name = "Array guid")]
        public Guid[] Guid { get; set; }

        [Display(Name = "Array bool")]
        public bool[] Bool { get; set; }
    }
}
