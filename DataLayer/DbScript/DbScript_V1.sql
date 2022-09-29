IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND  
			TABLE_NAME = 'UserLogMst')
BEGIN 
	Create table dbo.UserTokenMst(
			Id int identity(1,1) primary key,
			UserId int not null,
			Request nvarchar(max) not null,
			RequestDate datetime not null,
			Response nvarchar(max) not null,
			ResponseDate datetime not null,
			);
	PRINT 'Table Created' 
END
ELSE
BEGIN 
	PRINT 'Table Already Exist' 
END
GO






IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND  
			TABLE_NAME = 'SymbolDataMst')
BEGIN 
	Create table dbo.SymbolDataMst(
			Id int identity(1,1) primary key,
			Date Datetime null,
			openvalue nvarchar(max)  null,
			High  nvarchar(max)  null,
			Low nvarchar(max)  null,
			Closevalue nvarchar(max) null,
			AdjClose nvarchar(max) null,
			Volume nvarchar(max)  null,
			Ask nvarchar(max)  null,
			AskSize nvarchar(max)  null,
			AverageAnalystRating nvarchar(max)  null, --List
			AverageAnalystRating nvarchar(max)  null, --List
			AverageDailyVolume10Day nvarchar(max)  null,
			AverageDailyVolume3Month nvarchar(max)  null,
			Bid nvarchar(max)  null,
	       BidSize nvarchar(max)  null,
			BookValue nvarchar(max)  null,
			Currency nvarchar(max)  null,
			DisplayName nvarchar(max)  null,
			DividendDate nvarchar(max)  null,
			DividendDateSeconds nvarchar(max)  null,
			DividendHistory nvarchar(max)  null,
			EarningTime Datetime null,
			EarningTimeEnd Datetime null,
			EarningTimeStart Datetime null,
		   EarningTimeStamp nvarchar(max)  null,			
		  EarningTimeStampEnd nvarchar(max)  null,
		   EarningTImeStampStart nvarchar(max)  null,
		    EpsCurrentYear nvarchar(max)  null,
			 EpsForward nvarchar(max)  null,
 EpsTraillingTwelveMonth nvarchar(max)  null,
  EsgPopulated nvarchar(max)  null,
    Exchnage nvarchar(max)  null,
	  ExchangeCloseTime Datetime   null,
	    ExchangeDataDelayedBy nvarchar(max)  null,
	    ExchangeTimeZone nvarchar(max)  null,
		ExchangeTimeZoneName nvarchar(max)  null,

);
	PRINT 'Table Created' 
END
ELSE
BEGIN 
	PRINT 'Table Already Exist' 
END
GO



IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND  
			TABLE_NAME = 'UserLogMst')
BEGIN 
	Create table dbo.UserTokenMst(
			Id int identity(1,1) primary key,
			UserId int not null,
			Request nvarchar(max) not null,
			RequestDate datetime not null,
			Response nvarchar(max) not null,
			ResponseDate datetime not null,
			);
	PRINT 'Table Created' 
END
ELSE
BEGIN 
	PRINT 'Table Already Exist' 
END
GO


