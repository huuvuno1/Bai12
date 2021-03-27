<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrameSet.aspx.cs" Inherits="Bai12.FrameSet" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=, initial-scale=1.0">
    <title>Document</title>
    <!-- <meta http-equiv="refresh" content="3"> -->
    <link rel="stylesheet" href="/style.css">
    
</head>

<body>
    <div class="layout">
        <div class="row-top">
            <div class="iframe1">
                <iframe src="/Members.aspx" frameborder="1"></iframe>
            </div>
            <div class="iframe2">
                <iframe src="/MessageList.aspx" frameborder="1"></iframe>
            </div>
        </div>
        <div class="row-bottom">
            <iframe src="/PostMsg.html" frameborder="1"></iframe>
        </div>
    </div>
</body>

</html>