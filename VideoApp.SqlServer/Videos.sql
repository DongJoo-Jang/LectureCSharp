--[1]테이블 작성
CREATE TABLE [dbo].[Videos]
(
	[Id] int Not null Identity(1, 1) Primary key,
	[Created] DateTimeOffset(7)
		Default(SysDateTimeOffset() AT TIME ZONE 'Koread Standard Time'),
	
	[Title] NVarChar(255) Not Null,				--제목
	[Url] NVarChar(Max) Null,					--URL

	[Nmae] NVarChar(50) Null,					--등록자
	[Company] NVarChar (255) Null ,				--플랫폼
)
Go
