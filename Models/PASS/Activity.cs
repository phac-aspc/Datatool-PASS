﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReactDotNetDemo.Models.PASS
{
    public class Activity
    {
        public int ActivityId { get; set; }

        [InverseProperty("Activity")]
        public virtual ICollection<IndicatorGroup> IndicatorGroups { get; set; }
        public virtual ICollection<ActivityNameTranslation> ActivityNameTranslations { get; set; }
        public virtual ICollection<ActivityDescriptionTranslation> ActivityDescriptionTranslations { get; set; }
        /* Text getters */
        public string GetActivityName(string lc, string type) => Translation.GetTranslation(ActivityNameTranslations, lc, null);

        public int? DefaultIndicatorGroupId { get; set; }
        [ForeignKey("DefaultIndicatorGroupId")]
        public virtual IndicatorGroup DefaultIndicatorGroup { get; set; }
    }

    public class ActivityNameTranslation: ITranslation
    {
        public int TranslationId { get; set; }
        public virtual Translation Translation { get; set; }
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }
    }


    public class ActivityDescriptionTranslation : ITranslation
    {
        public int TranslationId { get; set; }
        public virtual Translation Translation { get; set; }
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }
    }

}
