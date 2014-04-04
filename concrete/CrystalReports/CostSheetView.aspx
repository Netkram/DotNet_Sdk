<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CostSheetView.aspx.cs" Inherits="concrete.Reports.CostSheetView" meta:resourcekey="PageResource1" UICulture="auto" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
  <title>View Report</title>
  <script lang="javaScript" type="text/javascript" src="crystalreportviewers13/js/crviewer/crv.js"></script> 
        </head>
<body>
   <form id="form1" runat="server">
    <div>
    
    </div>
        
      
        
       <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" ReportSourceID="CrystalReportSource1" />
       <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
           
       </CR:CrystalReportSource>
        
      
        
   </form>
</body>
</html>
