insert into "Translation"("LanguageCode", "Text", "Type")
select distinct languageCode='fr-ca', French as "Text", "Translation"."Type" from languagemapping
  inner join "Translation" on "Translation"."Text" = languagemapping.English;

insert into "ActivityNameTranslation"("ActivityId", "TranslationId")
select distinct t."ActivityId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "ActivityNameTranslation" t on t."TranslationId" = en."TranslationId";

insert into "IndicatorGroupNameTranslation"("IndicatorGroupId", "TranslationId")
select distinct t."IndicatorGroupId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "IndicatorGroupNameTranslation" t on t."TranslationId" = en."TranslationId";

insert into "IndicatorNameTranslation"("IndicatorId", "TranslationId")
select distinct t."IndicatorId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "IndicatorNameTranslation" t on t."TranslationId" = en."TranslationId";

insert into "LifeCourseNameTranslation"("LifeCourseId", "TranslationId")
select distinct t."LifeCourseId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "LifeCourseNameTranslation" t on t."TranslationId" = en."TranslationId";

insert into "MeasureAdditionalRemarksTranslation"("MeasureId", "TranslationId")
select distinct t."MeasureId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "MeasureAdditionalRemarksTranslation" t on t."TranslationId" = en."TranslationId";

insert into "MeasureDataAvailableTranslation"("MeasureId", "TranslationId")
select distinct t."MeasureId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "MeasureDataAvailableTranslation" t on t."TranslationId" = en."TranslationId";

insert into "MeasureDefinitionTranslation"("MeasureId", "TranslationId")
select distinct t."MeasureId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "MeasureDefinitionTranslation" t on t."TranslationId" = en."TranslationId";

insert into "MeasureMethodTranslation"("MeasureId", "TranslationId")
select distinct t."MeasureId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "MeasureMethodTranslation" t on t."TranslationId" = en."TranslationId";

insert into "MeasureNameTranslation"("MeasureId", "TranslationId")
select distinct t."MeasureId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "MeasureNameTranslation" t on t."TranslationId" = en."TranslationId";

insert into "MeasurePopulationTranslation"("MeasureId", "TranslationId")
select distinct t."MeasureId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "MeasurePopulationTranslation" t on t."TranslationId" = en."TranslationId";

insert into "MeasureSourceTranslation"("MeasureId", "TranslationId")
select distinct t."MeasureId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "MeasureSourceTranslation" t on t."TranslationId" = en."TranslationId";

insert into "MeasureUnitTranslation"("MeasureId", "TranslationId")
select distinct t."MeasureId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "MeasureUnitTranslation" t on t."TranslationId" = en."TranslationId";

insert into "PointLabelTranslation"("PointId", "TranslationId")
select distinct t."PointId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "PointLabelTranslation" t on t."TranslationId" = en."TranslationId";

insert into "StrataNameTranslation"("StrataId", "TranslationId")
select distinct t."StrataId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "StrataNameTranslation" t on t."TranslationId" = en."TranslationId";

insert into "StrataNotesTranslation"("StrataId", "TranslationId")
select distinct t."StrataId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "StrataNotesTranslation" t on t."TranslationId" = en."TranslationId";

insert into "StrataPopulationTranslation"("StrataId", "TranslationId")
select distinct t."StrataId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "StrataPopulationTranslation" t on t."TranslationId" = en."TranslationId";

insert into "StrataSourceTranslation"("StrataId", "TranslationId")
select distinct t."StrataId", fr."TranslationId" from "Translation" fr
inner join languagemapping map on fr."Text" = map.French and fr."LanguageCode"='fr-ca'
inner join "Translation" en on en."Text" = map.English
inner join "StrataPopulationTranslation" t on t."TranslationId" = en."TranslationId";

select distinct Text as English, coalesce(French, '') as French from "Translation"
left join languagemapping on English = Text 
where languageCode = 'en-ca' order by French;