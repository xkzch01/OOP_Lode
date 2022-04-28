<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grid.aspx.cs" Inherits="OOP_Ships.Grid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 0px;
            left: 0px;
            height: 30px;
            width: 30px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div id="div_Background" style="position: fixed; width: 1200px; height: 1000px; margin-right: 0px;">
            <h1 class="display-4" style="position: fixed; top: 50px; left: 420px;">Project OOP Ships</h1>
            <div id="div_X_Coords_Sector_A" style="width: 300px; height: 30px; position: inherit; top: 120px; left: 50px;">
                <table align="center" width="300" height="30">
                    <tr>
                        <td align="center" width="30">A</td>
                        <td align="center" width="30">B</td>
                        <td align="center" width="30">C</td>
                        <td align="center" width="30">D</td>
                        <td align="center" width="30">E</td>
                        <td align="center" width="30">F</td>
                        <td align="center" width="30">G</td>
                        <td align="center" width="30">H</td>
                        <td align="center" width="30">I</td>
                        <td align="center" width="30">J</td>
                    </tr>
                </table>             
            </div>
            <div id="div_Y_Coords_Sector_A" style="width: 30px; height: 300px; position: inherit; top: 150px; left: 20px;">
                <table align="center" width="30" height="300">
                    <tr><td align="center">1</td></tr>
                    <tr><td align="center">2</td></tr>
                    <tr><td align="center">3</td></tr>
                    <tr><td align="center">4</td></tr>
                    <tr><td align="center">5</td></tr>
                    <tr><td align="center">6</td></tr>
                    <tr><td align="center">7</td></tr>
                    <tr><td align="center">8</td></tr>
                    <tr><td align="center">9</td></tr>
                    <tr><td align="center">10</td></tr>
                </table>             
            </div>
            <div id="div_Player_A_Sector" style="width: 300px; height: 300px; position: inherit; top: 150px; left: 50px;">
                <!-- COLUMN 1 -->
                <div id="divAA1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 0px; text-align: right;">
                    <asp:Button ID="ButtonAA1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAA2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonAA2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAA3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonAA3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAA4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonAA4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAA5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonAA5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAA6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonAA6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAA7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonAA7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAA8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonAA8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAA9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonAA9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAA10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonAA10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 2 -->
                <div id="divAB1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 30px; text-align: right;">
                    <asp:Button ID="ButtonAB1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAB2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonAB2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAB3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonAB3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAB4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonAB4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAB5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonAB5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAB6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonAB6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAB7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonAB7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAB8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonAB8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAB9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonAB9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAB10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonAB10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 3 -->
                <div id="divAC1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 60px; text-align: right;">
                    <asp:Button ID="ButtonAC1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAC2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonAC2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAC3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonAC3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAC4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonAC4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAC5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonAC5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAC6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonAC6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAC7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonAC7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAC8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonAC8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAC9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonAC9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAC10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonAC10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 4 -->
                <div id="divAD1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 90px; text-align: right;">
                    <asp:Button ID="ButtonAD1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAD2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonAD2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAD3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonAD3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAD4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonAD4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAD5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonAD5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAD6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonAD6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAD7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonAD7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAD8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonAD8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAD9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonAD9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAD10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonAD10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 5 -->
                <div id="divAE1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 120px; text-align: right;">
                    <asp:Button ID="ButtonAE1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAE2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonAE2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAE3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonAE3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAE4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonAE4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAE5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonAE5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAE6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonAE6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAE7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonAE7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAE8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonAE8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAE9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonAE9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAE10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonAE10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 6 -->
                <div id="divAF1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 150px; text-align: right;">
                    <asp:Button ID="ButtonAF1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAF2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonAF2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAF3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonAF3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAF4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonAF4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAF5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonAF5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAF6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonAF6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAF7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonAF7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAF8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonAF8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAF9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonAF9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAF10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonAF10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 7 -->
                <div id="divAG1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 180px; text-align: right;">
                    <asp:Button ID="ButtonAG1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAG2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonAG2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAG3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonAG3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAG4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonAG4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAG5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonAG5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAG6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonAG6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAG7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonAG7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAG8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonAG8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAG9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonAG9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAG10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonAG10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 8 -->
                <div id="divAH1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 210px; text-align: right;">
                    <asp:Button ID="ButtonAH1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAH2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonAH2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAH3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonAH3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAH4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonAH4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAH5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonAH5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAH6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonAH6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAH7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonAH7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAH8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonAH8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAH9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonAH9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAH10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonAH10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 9 -->
                <div id="divAI1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 240px; text-align: right;">
                    <asp:Button ID="ButtonAI1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAI2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonAI2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAI3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonAI3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAI4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonAI4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAI5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonAI5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAI6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonAI6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAI7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonAI7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAI8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonAI8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAI9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonAI9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAI10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonAI10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 10 -->
                <div id="divAJ1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 270px; text-align: right;">
                    <asp:Button ID="ButtonAJ1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAJ2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonAJ2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAJ3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonAJ3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAJ4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonAJ4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAJ5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonAJ5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAJ6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonAJ6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAJ7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonAJ7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAJ8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonAJ8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAJ9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonAJ9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divAJ10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonAJ10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
            </div>

            <div id="div_Attack_Sector" style="width: 300px; height: 300px; position: inherit; top: 150px; left: 400px;">
                <!-- Player 1 Coords attack -->
                <asp:Label ID="lbl_Coordination_X_PlayerA" runat="server" Text="X Coordination" 
                    style="position: fixed; top: 180px; left: 425px; height: 20px; width: 100px"></asp:Label>
                <asp:TextBox ID="txtbox_Coordination_X_PlayerA" runat="server" Text="" 
                    style="position: fixed; top: 200px; left: 425px; height: 20px; width: 100px"></asp:TextBox>
                <asp:Label ID="lbl_Coordination_Y_PlayerA" runat="server" Text="Y Coordination" 
                    style="position: fixed; top: 230px; left: 425px; height: 20px; width: 100px"></asp:Label>
                <asp:TextBox ID="txtbox_Coordination_Y_PlayerA" runat="server" Text="" 
                    style="position: fixed; top: 250px; left: 425px; height: 20px; width: 100px"></asp:TextBox>
                <asp:Button ID="btn_PlayerA_Attack" runat="server" Text="Fire" OnClick="PlayerA_Attack" 
                    style="position: fixed; top: 300px; left: 450px; height: 35px; width: 50px"/>
                <!-- Player 2 Coords attack -->
                <asp:Label ID="lbl_Coordination_X_Player_B" runat="server" Text="X Coordination" 
                    style="position: fixed; top: 180px; left: 570px; height: 20px; width: 100px"></asp:Label>
                <asp:TextBox ID="txtbox_Coordination_X_PlayerB" runat="server" Text="" 
                    style="position: fixed; top: 200px; left: 570px; height: 20px; width: 100px"></asp:TextBox>
                <asp:Label ID="lbl_Coordination_Y_PlayerN" runat="server" Text="Y Coordination" 
                    style="position: fixed; top: 230px; left: 570px; height: 20px; width: 100px"></asp:Label>
                <asp:TextBox ID="txtbox_Coordination_Y_PlayerB" runat="server" Text="" 
                    style="position: fixed; top: 250px; left: 570px; height: 20px; width: 100px"></asp:TextBox>
                <asp:Button ID="btn_PlayerB_Attack" runat="server" Text="Fire" OnClick="PlayerB_Attack" 
                    style="position: fixed; top: 300px; left: 600px; height: 35px; width: 50px;" />
                

            </div>
            <div id="div_X_Coords_Sector_B" style="width: 300px; height: 30px; position: inherit; top: 120px; left: 750px;">
                <table align="center" width="300" height="30">
                    <tr>
                        <td align="center" width="30">A</td>
                        <td align="center" width="30">B</td>
                        <td align="center" width="30">C</td>
                        <td align="center" width="30">D</td>
                        <td align="center" width="30">E</td>
                        <td align="center" width="30">F</td>
                        <td align="center" width="30">G</td>
                        <td align="center" width="30">H</td>
                        <td align="center" width="30">I</td>
                        <td align="center" width="30">J</td>
                    </tr>
                </table>             
            </div>
            <div id="div_Y_Coords_Sector_B" style="width: 30px; height: 300px; position: inherit; top: 150px; left: 720px;">
                <table align="center" width="30" height="300">
                    <tr><td align="center">1</td></tr>
                    <tr><td align="center">2</td></tr>
                    <tr><td align="center">3</td></tr>
                    <tr><td align="center">4</td></tr>
                    <tr><td align="center">5</td></tr>
                    <tr><td align="center">6</td></tr>
                    <tr><td align="center">7</td></tr>
                    <tr><td align="center">8</td></tr>
                    <tr><td align="center">9</td></tr>
                    <tr><td align="center">10</td></tr>
                </table>             
            </div>
            <div id="div_Player_B_Sector" style="width: 300px; height: 300px; position: inherit; top: 150px; left: 750px;">
                <!-- COLUMN 1 -->
                <div id="divBA1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 0px; text-align: right;">
                    <asp:Button ID="ButtonBA1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBA2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonBA2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBA3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonBA3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBA4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonBA4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBA5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonBA5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBA6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonBA6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBA7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonBA7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBA8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonBA8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBA9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonBA9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBA10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 0px; text-align: center;">
                    <asp:Button ID="ButtonBA10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 2 -->
                <div id="divBB1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 30px; text-align: right;">
                    <asp:Button ID="ButtonBB1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBB2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonBB2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBB3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonBB3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBB4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonBB4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBB5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonBB5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBB6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonBB6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBB7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonBB7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBB8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonBB8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBB9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonBB9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBB10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 30px; text-align: center;">
                    <asp:Button ID="ButtonBB10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 3 -->
                <div id="divBC1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 60px; text-align: right;">
                    <asp:Button ID="ButtonBC1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBC2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonBC2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBC3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonBC3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBC4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonBC4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBC5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonBC5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBC6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonBC6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBC7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonBC7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBC8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonBC8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBC9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonBC9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBC10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 60px; text-align: center;">
                    <asp:Button ID="ButtonBC10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 4 -->
                <div id="divBD1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 90px; text-align: right;">
                    <asp:Button ID="ButtonBD1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBD2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonBD2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBD3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonBD3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBD4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonBD4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBD5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonBD5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBD6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonBD6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBD7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonBD7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBD8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonBD8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBD9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonBD9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBD10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 90px; text-align: center;">
                    <asp:Button ID="ButtonBD10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 5 -->
                <div id="divBE1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 120px; text-align: right;">
                    <asp:Button ID="ButtonBE1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBE2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonBE2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBE3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonBE3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBE4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonBE4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBE5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonBE5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBE6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonBE6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBE7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonBE7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBE8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonBE8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBE9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonBE9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBE10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 120px; text-align: center;">
                    <asp:Button ID="ButtonBE10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 6 -->
                <div id="divBF1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 150px; text-align: right;">
                    <asp:Button ID="ButtonBF1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBF2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonBF2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBF3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonBF3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBF4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonBF4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBF5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonBF5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBF6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonBF6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBF7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonBF7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBF8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonBF8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBF9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonBF9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBF10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 150px; text-align: center;">
                    <asp:Button ID="ButtonBF10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 7 -->
                <div id="divBG1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 180px; text-align: right;">
                    <asp:Button ID="ButtonBG1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBG2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonBG2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBG3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonBG3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBG4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonBG4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBG5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonBG5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBG6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonBG6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBG7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonBG7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBG8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonBG8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBG9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonBG9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBG10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 180px; text-align: center;">
                    <asp:Button ID="ButtonBG10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 8 -->
                <div id="divBH1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 210px; text-align: right;">
                    <asp:Button ID="ButtonBH1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBH2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonBH2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBH3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonBH3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBH4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonBH4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBH5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonBH5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBH6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonBH6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBH7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonBH7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBH8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonBH8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBH9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonBH9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBH10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 210px; text-align: center;">
                    <asp:Button ID="ButtonBH10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 9 -->
                <div id="divBI1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 240px; text-align: right;">
                    <asp:Button ID="ButtonBI1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBI2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonBI2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBI3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonBI3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBI4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonBI4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBI5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonBI5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBI6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonBI6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBI7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonBI7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBI8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonBI8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBI9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonBI9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBI10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 240px; text-align: center;">
                    <asp:Button ID="ButtonBI10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>

                <!-- COLUMN 10 -->
                <div id="divBJ1" style=" width: 30px; height: 30px; position: absolute; top: 0px; left: 270px; text-align: right;">
                    <asp:Button ID="ButtonBJ1" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBJ2" style=" width: 30px; height: 30px; position: absolute; top: 30px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonBJ2" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBJ3" style=" width: 30px; height: 30px; position: absolute; top: 60px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonBJ3" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBJ4" style=" width: 30px; height: 30px; position: absolute; top: 90px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonBJ4" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBJ5" style=" width: 30px; height: 30px; position: absolute; top: 120px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonBJ5" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBJ6" style=" width: 30px; height: 30px; position: absolute; top: 150px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonBJ6" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBJ7" style=" width: 30px; height: 30px; position: absolute; top: 180px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonBJ7" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBJ8" style=" width: 30px; height: 30px; position: absolute; top: 210px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonBJ8" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBJ9" style=" width: 30px; height: 30px; position: absolute; top: 240px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonBJ9" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
                <div id="divBJ10" style=" width: 30px; height: 30px; position: absolute; top: 270px; left: 270px; text-align: center;">
                    <asp:Button ID="ButtonBJ10" runat="server" Text="" style="position: absolute; top: 0px; left: 0px; height: 30px; width: 30px"></asp:Button></div>
            </div>   
        </div>
    </form>
</body>

</html>
