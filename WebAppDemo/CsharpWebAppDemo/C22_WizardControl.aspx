<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C22_WizardControl.aspx.cs" Inherits="CsharpWebAppDemo.C22_WizardControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
        .img-size{
            width:25px;
            height:25px;
        }
    </style>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" CancelButtonImageUrl="~/Images/CSharp.png" CancelButtonType="Image" DisplayCancelButton="True" OnFinishButtonClick="Wizard1_FinishButtonClick" OnNextButtonClick="Wizard1_NextButtonClick" OnPreRender="Wizard1_PreRender" OnActiveStepChanged="Wizard1_ActiveStepChanged" OnSideBarButtonClick="Wizard1_SideBarButtonClick">
            <CancelButtonStyle CssClass="img-size" />
            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1" StepType="Start">
                    <h1>Student Detail</h1>
                    <asp:Label ID="Label1" runat="server" Text="Std Name"></asp:Label>
                    <asp:TextBox ID="TxtStdName" runat="server"></asp:TextBox>

                    <asp:Label ID="Label2" runat="server" Text="Std Age"></asp:Label>
                    <asp:TextBox ID="TxtStdAge" runat="server"></asp:TextBox>

                    <asp:Label ID="Label3" runat="server" Text="Std Nationality"></asp:Label>
                    <asp:TextBox ID="TxtStdNationality" runat="server"></asp:TextBox>
                </asp:WizardStep>

                <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2" StepType="Step">
                    <h1>Father Detail</h1>
                    <asp:Label ID="Label4" runat="server" Text="Father Name"></asp:Label>
                    <asp:TextBox ID="TxtFname" runat="server"></asp:TextBox>

                    <asp:Label ID="Label5" runat="server" Text="Father Age"></asp:Label>
                    <asp:TextBox ID="TxtFage" runat="server"></asp:TextBox>

                    <asp:Label ID="Label6" runat="server" Text="Father Nationality"></asp:Label>
                    <asp:TextBox ID="TxtFnationality" runat="server"></asp:TextBox>
                </asp:WizardStep>

                <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3" StepType="Step">
                    <h1>Mother Detail</h1>
                    <asp:Label ID="Label7" runat="server" Text="Mother Name"></asp:Label>
                    <asp:TextBox ID="TxtMname" runat="server"></asp:TextBox>

                    <asp:Label ID="Label8" runat="server" Text="Mother Age"></asp:Label>
                    <asp:TextBox ID="TxtMage" runat="server"></asp:TextBox>

                    <asp:Label ID="Label9" runat="server" Text="Mother Nationality"></asp:Label>
                    <asp:TextBox ID="TxtMnationality" runat="server"></asp:TextBox>
                </asp:WizardStep>

                <asp:WizardStep ID="WizardStep4" runat="server" Title="Step 4" StepType="Finish">
                    <h1>View Detail</h1>
                    <asp:Label ID="Label10" runat="server" Text="Std Name"></asp:Label>
                    <br />
                    <asp:Label ID="Label11" runat="server" Text="Std Age"></asp:Label>
                    <br />
                   
                    <asp:Label ID="Label12" runat="server" Text="Std Nationality"></asp:Label>
                    <br />
                    
                    <asp:Label ID="Label13" runat="server" Text="Father Name"></asp:Label>
                    <br />
                    
                    <asp:Label ID="Label14" runat="server" Text="Father Age"></asp:Label>
                    <br />
                   
                    <asp:Label ID="Label15" runat="server" Text="Father Nationality"></asp:Label>
                    <br />
                   
                    <asp:Label ID="Label16" runat="server" Text="Mother Name"></asp:Label>
                    <br />
                   
                    <asp:Label ID="Label17" runat="server" Text="Mother Age"></asp:Label>
                    <br />
                    
                    <asp:Label ID="Label18" runat="server" Text="Mother Nationality"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
        <br />
        <br />
        <asp:Literal ID="Literal1" runat="server" Text="This is Literal"></asp:Literal>
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" BackColor="#CC33FF" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
