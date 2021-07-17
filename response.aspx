<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="response.aspx.cs" Inherits="shapath.response" %>

<!DOCTYPE html>

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
        <div class="container-fluid bgimage">
            <div class="row bg-primary">
                        <div class="col-12 ">
                    <h2 class="text-center text-white">RAJASTHAN JANARDAN RAI NAGAR VIDYAPEET UNIVERSITY</h2>
                </div>    
            </div><br>
            <div>
            <center><img src= "certificateimage/certificate_mba.jpeg" style="height:719px;width:1080px; /></center>
            </div>
            <div class="row">
            <div class="col-lg-12  col-sm-12 text-center mt-4 mb-5">
                    <asp:Button ID="btnsubmit" runat="server" Text="Download Certificate" CssClass="btn btn-primary" OnClick="btnsubmit_Click"/>
                </div>
        </div>
            </div>

    </form>
    <footer class="sticky-footer bg-primary w-100">
        <div class="container my-auto">
            <div class="copyright text-center my-auto text-white font-weight-bold">
                <span>Copyright &copy; 2021</span>
            </div>
        </div>
    </footer>
</body>

</html>
