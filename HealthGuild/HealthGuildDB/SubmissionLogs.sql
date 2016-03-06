CREATE TABLE [dbo].[SubmissionLogs]
(
	[SubmissionLogID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RunStartTime] DATETIME NOT NULL, 
    [RunEndTime] DATETIME NOT NULL, 
    [FileErrorCount] INT NOT NULL
)
