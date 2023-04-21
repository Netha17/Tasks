<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Validations.aspx.cs" Inherits="Crud.Validations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        User Id
                    </td>
                    <td>
                        <asp:TextBox ID="UserId" runat="server" ></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="usernameValidator" runat="server" Display="Dynamic" ErrorMessage="Username is Required" Text="*" SetFocusOnError="True" ControlToValidate="UserId" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                    <tr>
                    <td>
                        Password
                    </td>
                    <td>
                        <asp:TextBox ID="Password" runat="server" type="password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="pwValidator" runat="server" ErrorMessage="Password is Required" Text="*" SetFocusOnError="True" ControlToValidate="Password"  ForeColor="Red"></asp:RequiredFieldValidator>

                        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Password should contain atleast 8 characters" ForeColor="Red" ValidateEmptyText="True" ControlToValidate="Password" OnServerValidate="CustomValidator1_ServerValidate" Display="Dynamic"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Confirm password
                    </td>
                    <td>
                        <asp:TextBox ID="ConfirmPassword" runat="server" type="password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="CpwValidator" runat="server" Display="Dynamic" ErrorMessage="Confrim Password is Required" Text="*" SetFocusOnError="True" ControlToValidate="ConfirmPassword"  ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords Mismatched" ControlToValidate="ConfirmPassword" ControlToCompare="Password" ForeColor  ="Red"></asp:CompareValidator>
                      
                    </td>
                </tr>
                <tr>
                    <td>
                        Email Id
                    </td>
                    <td>
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="emailValidator" runat="server" Display="Dynamic" ErrorMessage="Enter Email" Text="*" SetFocusOnError="True" ControlToValidate="email"  ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email address" ForeColor="Red" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                    Mobile Number
                    </td>
                    <td>
                        <asp:TextBox ID="mbl" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter valid mobile number" ControlToValidate="mbl" ValidationExpression="[6789]\d{9}" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>

                </tr>
                <tr>
                    <td>
                        Age
                    </td>
                    <td>
                         <asp:TextBox ID="age" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" Display="Dynamic" ErrorMessage="Age should be greater than 18 and less than 60" ControlToValidate="age" MaximumValue="60" MinimumValue="18" Type="Integer" ForeColor="Red"></asp:RangeValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        <input type="submit" value="Submit" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
