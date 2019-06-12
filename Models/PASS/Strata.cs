﻿// This file was generated by a tool by using the automation attributes
// All changes done to this file will be undone
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infobase.Automation;
namespace Infobase.Models.PASS
{
    [TextData("Name")]
    [TextData("Notes")]
    [TextData("PopulationTitleFragment")]
    [TextData("Source")]
    [ChildOf(typeof(Measure))]
    [ParentOf(typeof(Point), false)]
    public class Strata
    {
        public int StrataId { get; set; }
        public int Index { get; set; }
        public string StrataName(string culture)
        {
            switch (culture)
            {
                case "en-ca": return StrataNameEn;
                case "fr-ca": return StrataNameFr;
            }
            return "No culture";
        }
        public string StrataNameEn { get; set; }
        public string StrataNameFr { get; set; }
        public string StrataNotes(string culture)
        {
            switch (culture)
            {
                case "en-ca": return StrataNotesEn;
                case "fr-ca": return StrataNotesFr;
            }
            return "No culture";
        }
        public string StrataNotesEn { get; set; }
        public string StrataNotesFr { get; set; }
        public string StrataPopulationTitleFragment(string culture)
        {
            switch (culture)
            {
                case "en-ca": return StrataPopulationTitleFragmentEn;
                case "fr-ca": return StrataPopulationTitleFragmentFr;
            }
            return "No culture";
        }
        public string StrataPopulationTitleFragmentEn { get; set; }
        public string StrataPopulationTitleFragmentFr { get; set; }
        public string StrataSource(string culture)
        {
            switch (culture)
            {
                case "en-ca": return StrataSourceEn;
                case "fr-ca": return StrataSourceFr;
            }
            return "No culture";
        }
        public string StrataSourceEn { get; set; }
        public string StrataSourceFr { get; set; }
        public int MeasureId { get; set; }
        public virtual Measure Measure { get; set; }
        [InverseProperty("Strata")]
        public virtual ICollection<Point> Points { get; set; }
    }
}