/* Copy all english text to Translations table */
DELETE FROM Translation;

INSERT INTO Translation (LanguageCode, [Text])
	SELECT DISTINCT 'EN', [Activity EN] FROM _Master A
		WHERE  A.[Activity EN] NOT IN (SELECT [Text] FROM Translation WHERE [Text] is NOT null)

INSERT INTO Translation (LanguageCode, [Text])
	SELECT DISTINCT 'EN', [Indicator Group EN] FROM _Master A
		WHERE  A.[Indicator Group EN] NOT IN (SELECT [Text] FROM Translation WHERE [Text] is NOT null)

INSERT INTO Translation (LanguageCode, [Text])
	SELECT DISTINCT 'EN', [Life Course EN] FROM _Master A
		WHERE  A.[Life Course EN] NOT IN (SELECT [Text] FROM Translation WHERE [Text] is NOT null)

INSERT INTO Translation (LanguageCode, [Text])
	SELECT DISTINCT 'EN', [Indicator EN] FROM _Master A
		WHERE  A.[Indicator EN] NOT IN (SELECT [Text] FROM Translation WHERE [Text] is NOT null)
		
INSERT INTO Translation (LanguageCode, [Text])
	SELECT DISTINCT 'EN', [Specific Measure EN] FROM _Master A
		WHERE  A.[Specific Measure EN] NOT IN (SELECT [Text] FROM Translation WHERE [Text] is NOT null)		

INSERT INTO Translation (LanguageCode, [Text])
	SELECT DISTINCT 'EN', [Strata] FROM _Master A
		WHERE  A.[Strata] NOT IN (SELECT [Text] FROM Translation WHERE [Text] is NOT null)		

INSERT INTO Translation (LanguageCode, [Text])
	SELECT DISTINCT 'EN', [Disaggregation] FROM _Master A
		WHERE  A.[Disaggregation] NOT IN (SELECT [Text] FROM Translation WHERE [Text] is NOT null)

INSERT INTO Translation (LanguageCode, [Text])
	SELECT DISTINCT 'EN', [Labels] FROM _Master A
		WHERE  A.[Labels] NOT IN (SELECT [Text] FROM Translation WHERE [Text] is NOT null)

INSERT INTO Translation (LanguageCode, [Text])
	SELECT DISTINCT 'EN', [Source] FROM _Master A
		WHERE  A.[Disaggregation] NOT IN (SELECT [Text] FROM Translation WHERE [Text] is NOT null)

INSERT INTO Translation (LanguageCode, [Text])
	SELECT DISTINCT 'EN', [Notes] FROM _Master A
		WHERE  A.[Notes] NOT IN (SELECT [Text] FROM Translation WHERE [Text] is NOT null)

INSERT INTO Translation (LanguageCode, [Text])
	SELECT DISTINCT 'EN', [Population] FROM _Master A
		WHERE  A.[Population] NOT IN (SELECT [Text] FROM Translation WHERE [Text] is NOT null)


/* Create activies */
/* Activies has only a single column which cannot be inserted into directly. To create a row, it is necessary to create a new temporary column */

Alter table Activity
Add Txt varchar(255);
GO

DELETE FROM Activity;
DBCC CHECKIDENT (Activity, RESEED, 0)

INSERT INTO Activity (Txt)
	SELECT DISTINCT [Activity EN] FROM _Master;

INSERT INTO ActivityNameTranslation (ActivityId, TranslationId)
	SELECT ActivityId, B.TranslationId from Activity A
		JOIN Translation B 
			ON A.Txt = B.[Text];

Alter table Activity
Drop column Txt;
GO

/*Create Indicator Groups */

Alter table IndicatorGroup
Add Txt varchar(255);
GO

DELETE FROM IndicatorGroup;
DBCC CHECKIDENT (IndicatorGroup, RESEED, 0)

INSERT INTO IndicatorGroup (ActivityId, Txt)
SELECT ActivityID, [Indicator Group EN] FROM 
	(SELECT DISTINCT ActivityID, [Indicator Group EN] FROM [_Master] A
	JOIN Translation B ON B.[Text] = A.[Activity EN]
	JOIN ActivityNameTranslation C ON B.TranslationID = C.TranslationID ) _;

/* Bind with translations */
DELETE FROM IndicatorGroupNameTranslation;

INSERT INTO IndicatorGroupNameTranslation (IndicatorGroupId, TranslationId)
	SELECT IndicatorGroupId, TranslationId FROM IndicatorGroup A
		JOIN Translation B ON A.Txt = B.[Text];

Alter table IndicatorGroup
Drop column Txt;
GO


/*Create Lifecourses */

Alter table LifeCourse
Add Txt varchar(255);
GO

DELETE FROM LifeCourse;
DBCC CHECKIDENT (LifeCourse, RESEED, 0)

INSERT INTO LifeCourse (IndicatorGroupId, Txt)
SELECT IndicatorGroupId, [Life Course EN] FROM 
	(SELECT distinct ActivityId, IndicatorGroupId, [Life Course EN] FROM _Master A
	/*Bind with Activity */
	JOIN Translation B on A.[Activity EN] = B.[Text]
	JOIN ActivityNameTranslation C on B.TranslationId = C.TranslationId

	/* Bind with indicator Group */
	
	JOIN Translation D on A.[Indicator Group EN] = D.[Text]
	JOIN IndicatorGroupNameTranslation E on E.TranslationId = D.TranslationId) _;

/* Bind with translations */
DELETE FROM LifeCourseNameTranslation;

INSERT INTO LifeCourseNameTranslation (LifeCourseId, TranslationId)
	SELECT LifeCourseId, TranslationId FROM LifeCourse A
		JOIN Translation B ON A.Txt = B.[Text];

Alter table LifeCourse
Drop column Txt;
GO


/*Create Indicators */

Alter table Indicator
Add Txt varchar(255);
GO

DELETE FROM Indicator;
DBCC CHECKIDENT (Indicator, RESEED, 0)

INSERT INTO Indicator (LifeCourseId, Txt)
SELECT LifeCourseId, [Indicator EN] FROM 
	(SELECT distinct ActivityId, IndicatorGroupId, LifeCourseId, [Indicator EN] FROM _Master A
	/*Bind with Activity */
	JOIN Translation B on A.[Activity EN] = B.[Text]
	JOIN ActivityNameTranslation C on B.TranslationId = C.TranslationId

	/* Bind with indicator Group */
	
	JOIN Translation D on A.[Indicator Group EN] = D.[Text]
	JOIN IndicatorGroupNameTranslation E on E.TranslationId = D.TranslationId

	/* Bind with life course */
	
	JOIN Translation F on A.[Life Course EN] = F.[Text]
	JOIN LifeCourseNameTranslation G on F.TranslationId = G.TranslationId) _;

/* Bind with translations */
DELETE FROM IndicatorNameTranslation;

INSERT INTO IndicatorNameTranslation (IndicatorId, TranslationId)
	SELECT IndicatorId, TranslationId FROM Indicator A
		JOIN Translation B ON A.Txt = B.[Text];

Alter table Indicator
Drop column Txt;
GO


/*Create Measure */

Alter table Measure
Add Txt varchar(255);
GO

Alter table Measure
Add Txt2 varchar(255);
GO

DELETE FROM Measure;
DBCC CHECKIDENT (Measure, RESEED, 0)

INSERT INTO Measure (IndicatorId, Txt, Txt2)
SELECT IndicatorId, [Specific Measure EN], Labels FROM 
	(SELECT DISTINCT [Specific Measure EN], E.IndicatorId, Labels FROM [_Master] A
	JOIN Translation D ON D.[Text] = A.[Indicator EN]
	JOIN IndicatorNameTranslation E ON E.TranslationID = D.TranslationID
	 ) _;

/* Bind with translations */
DELETE FROM MeasureNameTranslation;

INSERT INTO MeasureNameTranslation (MeasureId, TranslationId)
	SELECT MeasureId, TranslationId FROM Measure A
		JOIN Translation B ON A.Txt = B.[Text];

DELETE FROM MeasureUnitTranslation;

INSERT INTO MeasureUnitTranslation (MeasureId, TranslationId)
	SELECT MeasureId, TranslationId FROM Measure A
		JOIN Translation B ON A.Txt2 = B.[Text];

Alter table Measure
Drop column Txt;
GO

Alter table Measure
Drop column Txt2;
GO

/*Create Strata */

Alter table Strata
Add Txt varchar(255);
GO

Alter table Strata
Add Txt2 varchar(255);
GO

Alter table Strata
Add Txt3 varchar(255);
GO

DELETE FROM Strata;
DBCC CHECKIDENT (Strata, RESEED, 0)

INSERT INTO Strata (MeasureId, Txt, Txt2, Txt3)
SELECT measureid, [strata], notes, [population] FROM 
	(SELECT DISTINCT [strata], E.measureid, Labels, notes, [population] FROM [_Master] A
	JOIN Translation D ON D.[Text] = A.[Specific Measure EN]
	JOIN measurenametranslation E ON E.TranslationID = D.TranslationID
	 ) _;

/* Bind with translations */
DELETE FROM StrataNameTranslation;

INSERT INTO StrataNameTranslation (StrataId, TranslationId)
	SELECT strataid, TranslationId FROM strata A
		JOIN Translation B ON A.Txt = B.[Text];

DELETE FROM stratanotestranslation;

INSERT INTO stratanotestranslation (StrataId, TranslationId)
	SELECT strataid, TranslationId FROM strata A
		JOIN Translation B ON A.Txt2 = B.[Text];

		
DELETE FROM stratapopulationtranslation;

INSERT INTO stratapopulationtranslation (StrataId, TranslationId)
	SELECT strataid, TranslationId FROM strata A
		JOIN Translation B ON A.Txt3 = B.[Text];

Alter table strata
Drop column Txt;
GO

Alter table strata
Drop column Txt2;
GO
Alter table strata
Drop column Txt3;
GO


/*Create Indicators */

Alter table Point
Add Txt varchar(255);
GO

DELETE FROM Point;
DBCC CHECKIDENT (Point, RESEED, 0)
/*
INSERT INTO Point (StrataId, Txt)
SELECT LifeCourseId, [Indicator EN] FROM 
	(SELECT DISTINCT [Indicator EN], E.LifeCourseId FROM [_Master] A
	JOIN Translation D ON D.[Text] = A.Strata
	JOIN StrataNameTranslation E ON E.TranslationID = D.TranslationID
	 ) _;

/* Bind with translations */
DELETE FROM IndicatorNameTranslation;

INSERT INTO IndicatorNameTranslation (IndicatorId, TranslationId)
	SELECT IndicatorId, TranslationId FROM Indicator A
		JOIN Translation B ON A.Txt = B.[Text];*/

Alter table Point
Drop column Txt;
GO