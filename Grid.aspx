<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grid.aspx.cs" Inherits="OOP_Ships.Grid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                <table border="1" align="center" width="300" height="300">
                    <tr>
                        <!--<td align="center" role="button"><asp:Button ID="Button2" runat="server" Text="Button" />
                        </td>           
                        <!--<td align="center"><img height="20" width="20" src="test.jpg"></td> -->
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                </table>
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
                <table border="1" align="center" width="300" height="300">
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                        <td align="center"></td>
                    </tr>
                </table>
            </div>   
        </div>
    </form>
</body>

</html>
