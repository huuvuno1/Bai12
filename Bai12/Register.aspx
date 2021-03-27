<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Bai12.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/style.css">
    <script src="/script.js"></script>
</head>
<body>
    <form id="form_register" runat="server" method="post" action="Register.aspx">
        <h1>Đăng ký tham gia nhóm chat</h1>
        <p>
            <label for="nickname">Nick name: </label>
            <input id="nickname" name="nickname" />
        </p>
        <p>
            <label for="color">Chọn màu hiển thị: </label>
            <input id="color" type="color" name="color" />
        </p>
        <p>
            <asp:Button ID="btn_register" runat="server" Text="Tham gia" OnClick="btn_register_Click"/>
        </p>
    </form>
</body>
</html>
