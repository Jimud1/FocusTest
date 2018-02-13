--Will use datafix for my test/example 
USE [DATAFIXES]
IF EXISTS (
        SELECT type_desc, type
        FROM sys.procedures WITH(NOLOCK)
        WHERE NAME = 'Datafix_Policy_GET_ByPolicyKey'
            AND type = 'P'
      )
     DROP PROCEDURE dbo.Datafix_Policy_GET_ByPolicyKey
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		James Hood	
-- Create date: 12-02/2018
-- Description:	Get policy 
-- =============================================
CREATE PROCEDURE [dbo].[Datafix_Policy_GET_ByPolicyKey]
	@PolicyKey NVARCHAR(20)
AS
BEGIN
    CREATE TABLE #PolicyID (PolicyID DECIMAL(18, 0) PRIMARY KEY CLUSTERED)
    INSERT #PolicyID SELECT DISTINCT PVR_POLICY_ID_FK FROM FOCUS_POLICY..PA_POLICY_VERSION WHERE PVR_PUBLIC_KEY like @PolicyKey
	SET NOCOUNT ON;
	SELECT 
                po.POLICY_ID AS [PolicyId]
              , PRODUCT.PRD_NAME AS [ProductName]
              , dbo.FocusPolicyStatus(po.POL_POLICY_STATUS_FK) As PolicyStatus
              , po.POL_START_DATE AS PolicyStartDate
              , po.POL_END_DATE AS PolicyEndDate
              , po.POL_ROW_STATUS As PolicyRowStatus                 
       From
              #PolicyID
              Join FOCUS_POLICY.dbo.PA_POLICY po (nolock) On po.POLICY_ID = #PolicyID.PolicyID
              Join FOCUS_POLICY.dbo.PA_PORTFOLIO pf (nolock) On pf.POLICY_ID_FK = #PolicyID.PolicyID
              LEFT JOIN FOCUS_POLICY..PRODUCT ON PRODUCT.PRD_EXTERNAL_KEY = po.POL_EXTERNAL_PRODUCT_KEY
              LEFT JOIN DATAFIXES..SOURCE_OF_BUSINESS ON SOURCE_CODE = po.POL_INCEPTION_SOURCE
       Order By
              po.POLICY_ID DESC
END
