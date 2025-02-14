USE SRM_86;

Create procedure USP_GetCBondsDataByTabs 
as
begin
	--SECURITY SUMMARY
	SELECT SecurityId, Security_Name, Security_Description, Asset_Type, 
		   Investment_Type, Trading_Factor, Pricing_Factor
	FROM dbo.Bonds;

	--SECURITY IDENTIFIER
	SELECT SecurityId, ISIN, BBG_Ticker, BBG_Unique_ID, CUSIP, SEDOL
	FROM dbo.Bonds;

	--SECURITY DETAILS
	SELECT SecurityId, First_Coupon_Date, Cap, Floor, Coupon_Frequency, Coupon, 
		   Coupon_Type, Spread, Callable_Flag, Fix_to_Float_Flag, Putable_Flag, 
		   Issue_Date, Last_Reset_Date, Maturity, Call_Notification_Max_Days, Put_Notification_Max_Days,
		   Penultimate_Coupon_Date, Reset_Frequency, Has_Position
	FROM dbo.Bonds;

	--RISK
	SELECT SecurityId, Macaulay_Duration, _30D_Volatility, _90D_Volatility, 
		   Convexity, _30Day_Average_Volume
	FROM dbo.Bonds;

	--REGULATORY DETAILS
	SELECT SecurityId, PF_Asset_Class, PF_Country, PF_Credit_Rating, PF_Currency, PF_Instrument,
		   PF_Liquidity_Profile, PF_Maturity, PF_NAICS_Code, PF_Region, PF_Sector, PF_Sub_Asset_Class
	FROM dbo.Bonds;

	--REFERENCE DATA
	SELECT SecurityId, Bloomberg_Industry_Group, Bloomberg_Industry_Sub_Group, Bloomberg_Industry_Sector,
		   Country_of_Issuance, Issue_Currency, Issuer, Risk_Currency
	FROM dbo.Bonds;

	--PUT SCHEDULE
	SELECT SecurityId, Put_Date, Put_Price
	FROM dbo.Bonds;

	--PRICING AND ANALYTICS
	SELECT SecurityId, Ask_Price, High_Price, Low_Price, Open_Price, Volume, Bid_Price,
	       Last_Price
	FROM dbo.Bonds;

	--CALL SCHEDULE
	SELECT SecurityId, Call_Date, Call_Price
	FROM dbo.Bonds;
end;


CREATE PROCEDURE USP_GetEquitiesByTabs
AS
BEGIN	
	--SECURITY SUMMARY
	SELECT SecurityId, Security_Name, Security_Description, Has_Position, Is_Active_Security, 
		   Lot_Size, BBG_Unique_Name
	FROM dbo.Equities;

	--SECURITY IDENTIFIER
	SELECT SecurityId, CUSIP, ISIN, SEDOL, Bloomberg_Ticker, Bloomberg_Unique_ID, 
		   BBG_Global_ID, Ticker_and_Exchange
	FROM dbo.Equities;

	--SECURITY DETAILS
	SELECT SecurityId, Is_ADR_Flag, ADR_Underlying_Ticker, ADR_Underlying_Currency, 
		   Shares_Per_ADR, IPO_Date, Pricing_Currency, Settle_Days, 
		   Total_Shares_Outstanding, Voting_Rights_Per_Share
	FROM dbo.Equities;

	--RISK
	SELECT SecurityId, Average_Volume_20D, Beta, Short_Interest, Return_YTD, Volatility_90D
	FROM dbo.Equities;

	--REGULATORY DETAILS
	SELECT SecurityId, PF_Asset_Class, PF_Country, PF_Credit_Rating, PF_Currency, PF_Instrument,
		   PF_Liquidity_Profile, PF_Maturity, PF_NAICS_Code, PF_Region, PF_Sector, PF_Sub_Asset_Class
	FROM dbo.Equities;

	--REFERENCE DATA
	SELECT SecurityId, Country_of_Issuance, Exchange, Issuer, Issue_Currency, Trading_Currency,
		   BBG_Industry_Sub_Group, Bloomberg_Industry_Group, Bloomberg_Sector, Country_of_Incorporation, 
		   Risk_Currency
	FROM dbo.Equities;

	--PRICING DETAILS
	SELECT SecurityId, Open_Price, Close_Price, Volume, 
		   Last_Price, Ask_Price, Bid_Price, PE_Ratio
	FROM dbo.Equities;

	--DIVIDEND HISTORY
	SELECT SecurityId, Dividend_Declared_Date, Dividend_Ex_Date, Dividend_Record_Date,
		   Dividend_Pay_Date, Dividend_Amount, Frequency, Dividend_Type
	FROM dbo.Equities;
END;