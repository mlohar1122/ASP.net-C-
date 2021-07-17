<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form.aspx.cs" Inherits="shapath.form" %>

<%@ Register Assembly="BotDetect" Namespace="BotDetect.Web.UI" TagPrefix="BotDetect" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script src="Scripts/jquery-3.5.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row bg-primary mb-4">
                <div class="col-12 ">
                    <h2 class="text-center text-white" > <img src= "certificateimage/loggoo.png" width="40" height="40"/>  RAJASTHAN JANARDAN RAI NAGAR VIDYAPEET UNIVERSITY</h2>
                </div>
            </div>
            <div class="row mt-3">
                <div class="col-lg-1 offset-lg-1 col-sm-12 ">
                    <label class="mt-2">Saluation</label>
                    <asp:DropDownList ID="ddlprename" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Mr."></asp:ListItem>
                        <asp:ListItem Text="Ms."></asp:ListItem>
                        <asp:ListItem Text="Dr."></asp:ListItem>
                        <asp:ListItem Text="Prof."></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-4  col-sm-12">
                    <label class="mt-2">Name</label>
                    <asp:TextBox ID="txtname" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-lg-2 col-sm-12">
                    <label class="mt-2">Gender</label>
                    <asp:DropDownList ID="ddlgender" runat="server" CssClass="form-control">
                        <asp:ListItem Text="MALE"></asp:ListItem>
                        <asp:ListItem Text="FEMALE"></asp:ListItem>
                        <asp:ListItem Text="OTHER"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-3 col-sm-12">
                    <%--<label>Age</label>
                    <asp:TextBox ID="txtage" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>--%>
                </div>
                <div class="col-lg-5 offset-lg-1 col-sm-12">
                    <label class="mt-2">Institution / Company Name</label>
                    <asp:TextBox ID="txtstate" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-lg-5  col-sm-12">
                    <label class="mt-2">Feedback</label>
                    <asp:TextBox ID="txtdistrict" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-lg-5 offset-lg-1 col-sm-12">
                    <label class="mt-2">E-mail</label>
                    <asp:TextBox ID="txtemail" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-lg-5  col-sm-12">
                    <label class="mt-2">Mobile</label>
                    <asp:TextBox ID="txtmobile" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-lg-5 offset-lg-1 col-sm-12">
                    <label class="mt-2">Enter Captcha</label>
                    <asp:TextBox ID="txtcaptcha" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-lg-5  col-sm-12">
                    <label class="mt-2">Captcha Code</label>
                    <BotDetect:WebFormsCaptcha ID="captchabox" runat="server" UserInputControlID="txtcaptcha" />
                </div>
                <div class="col-lg-12  col-sm-12 text-center mt-4">
                    <asp:Button ID="btnsubmit" runat="server" Text="SUBMIT" CssClass="btn btn-success" OnClick="btnsubmit_Click"/>
                </div>
            </div>
        </div>
    </form>
     <footer class="sticky-footer bg-primary">
        <div class="container my-auto">
            <div class="copyright text-center my-auto text-white font-weight-bold">
                <span>Copyright &copy; 2021</span>
            </div>
        </div>
    </footer>
</body>
</html>
