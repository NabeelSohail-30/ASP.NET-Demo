<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C28_CustomVal.aspx.cs" Inherits="CsharpWebAppDemo.C28_CustomVal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Number(+ve even): <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Invalid" ControlToValidate="TextBox1" ClientValidationFunction="IsEven" OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
    <script>
        function IsEven(source, args)
        {
            if(args.Value=="")
            {
                args.IsValid = false;
            }
            else {
                if(args.Value % 2==0)
                {
                    args.IsValid = true;

                }
                else {
                    args.IsValid = false;
                }
            }
        }
    </script>
</html>
