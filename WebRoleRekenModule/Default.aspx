<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebRoleRekenModule._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1><br />
                <h2>Call RekenModule to calculate sum</h2>
            </hgroup>
            <p>
                <asp:Button ID="btnCalculateDll" runat="server" Text="Calculate Dll" OnClick="btnCalculateDll_Click" />
                <asp:Table ID="Table3" runat="server" Width="409px">
                    <asp:TableRow ID="TableRow2" runat="server">
                        <asp:TableCell ID="TableCell9" runat="server">
                            <asp:Label ID="lblResultdll" runat="server" Text="Result"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell ID="TableCell10" runat="server">
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <asp:Label ID="lblErrorDll" runat="server" Text="" ForeColor="Red"></asp:Label><br/>

                <asp:Button ID="Button1" runat="server" Text="Calculate Dll Mutex" OnClick="btnCalculateDllMutex_Click" />
                <asp:Table ID="Table1" runat="server" Width="409px">
                    <asp:TableRow ID="TableRow1" runat="server">
                        <asp:TableCell ID="TableCell1" runat="server">
                            <asp:Label ID="lblResultdllMutex" runat="server" Text="Result"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell ID="TableCell2" runat="server">
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <asp:Label ID="lblErrorDllMutex" runat="server" Text="" ForeColor="Red"></asp:Label><br/>

                <asp:Button ID="Button2" runat="server" Text="Calculate Dll 32" OnClick="btnCalculateDll32_Click" />
                <asp:Table ID="Table2" runat="server" Width="409px">
                    <asp:TableRow ID="TableRow3" runat="server">
                        <asp:TableCell ID="TableCell3" runat="server">
                            <asp:Label ID="lblResult32" runat="server" Text="Result"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell ID="TableCell4" runat="server">
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <asp:Label ID="lblErrorDll32" runat="server" Text="" ForeColor="Red"></asp:Label><br/>

                <asp:Button ID="Button3" runat="server" Text="Calculate Dll 32 Mutex" OnClick="btnCalculateDll32Mutex_Click" />
                <asp:Table ID="Table4" runat="server" Width="409px">
                    <asp:TableRow ID="TableRow4" runat="server">
                        <asp:TableCell ID="TableCell5" runat="server">
                            <asp:Label ID="lblResult32Mutex" runat="server" Text="Result"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell ID="TableCell6" runat="server">
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <asp:Label ID="lblErrorDll32Mutex" runat="server" Text="" ForeColor="Red"></asp:Label>
            </p>
        </div>
    </section>
</asp:Content>

