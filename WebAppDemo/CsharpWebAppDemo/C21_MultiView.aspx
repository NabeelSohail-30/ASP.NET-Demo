<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C21_MultiView.aspx.cs" Inherits="CsharpWebAppDemo.C21_MultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <h1>Student Detail</h1>
                    <asp:Label ID="Label1" runat="server" Text="Std Name"></asp:Label>
                    <asp:TextBox ID="TxtStdName" runat="server"></asp:TextBox>

                    <asp:Label ID="Label2" runat="server" Text="Std Age"></asp:Label>
                    <asp:TextBox ID="TxtStdAge" runat="server"></asp:TextBox>

                    <asp:Label ID="Label3" runat="server" Text="Std Nationality"></asp:Label>
                    <asp:TextBox ID="TxtStdNationality" runat="server"></asp:TextBox>

                    <asp:Button ID="BtnNextFD" runat="server" Text="Next (FD)" OnClick="BtnNextFD_Click" />
                </asp:View>

                <asp:View ID="View2" runat="server">
                    <h1>Father Detail</h1>
                    <asp:Label ID="Label4" runat="server" Text="Father Name"></asp:Label>
                    <asp:TextBox ID="TxtFname" runat="server"></asp:TextBox>

                    <asp:Label ID="Label5" runat="server" Text="Father Age"></asp:Label>
                    <asp:TextBox ID="TxtFage" runat="server"></asp:TextBox>

                    <asp:Label ID="Label6" runat="server" Text="Father Nationality"></asp:Label>
                    <asp:TextBox ID="TxtFnationality" runat="server"></asp:TextBox>

                    <asp:Button ID="BtnPrevSD" runat="server" Text="Prev (SD)" OnClick="BtnPrevSD_Click" />
                    <asp:Button ID="BtnNextMD" runat="server" Text="Next (MD)" OnClick="BtnNextMD_Click" />
                </asp:View>

                <asp:View ID="View3" runat="server">
                    <h1>Mother Detail</h1>
                    <asp:Label ID="Label7" runat="server" Text="Mother Name"></asp:Label>
                    <asp:TextBox ID="TxtMname" runat="server"></asp:TextBox>

                    <asp:Label ID="Label8" runat="server" Text="Mother Age"></asp:Label>
                    <asp:TextBox ID="TxtMage" runat="server"></asp:TextBox>

                    <asp:Label ID="Label9" runat="server" Text="Mother Nationality"></asp:Label>
                    <asp:TextBox ID="TxtMnationality" runat="server"></asp:TextBox>

                     <asp:Button ID="BtnPrevFD" runat="server" Text="Prev (MD)" OnClick="BtnPrevFD_Click" />
                    <asp:Button ID="BtnNextVD" runat="server" Text="Next (VD)" OnClick="BtnNextVD_Click" />
                </asp:View>

                <asp:View ID="View4" runat="server">
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

                     <asp:Button ID="BtnPrevMD" runat="server" Text="Prev MD)" OnClick="BtnPrevMD_Click" />
                    <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
                </asp:View>
            </asp:MultiView>

        </div>
    </form>
</body>
</html>
