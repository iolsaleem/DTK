<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LearnSideBar.aspx.cs" Inherits="ApplicationLayer.LearnSideBar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nav bar</title>
    <script src="Scripts/jquery-1.10.2.min.js"></script>

    <script type="text/javascript">
        $(function () {
            var $menu = $("menu"), $target = $("target");

            $menu.on("click", '>a', function () {
                var $this = $(this);
                $target.load('echo/html/', { html: $this.attr('href') });
            });

        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <nav id="menu" class="menu-side">
        <a href="About.aspx" id="about">About</a>
        <a href="Project_Readme.html" id="help">Help</a>
        <a href="Contact.aspx" id="contact">Contact</a>
    </nav>
<div id="target">

</div>
    </form>
</body>
</html>
