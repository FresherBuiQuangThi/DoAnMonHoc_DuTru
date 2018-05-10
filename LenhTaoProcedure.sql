USE qldg
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[KIEMTRA_TABLE]
AS
BEGIN
	declare @result bit
	set @result=0
	IF object_id('PHIEUMUON') is not null
		if object_id('CHITIET_PHIEUMUON') is not null
		if object_id('PHIEUTRA') is not null
		if object_id('CHITIET_PHIEUTRA') is not null
		set @result=1
	select @result
END