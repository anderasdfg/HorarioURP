<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Cuenta_Login" %>

<%--<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>--%>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Ingresar - Administrador</title>
    	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/login-util.css">
	<link rel="stylesheet" type="text/css" href="css/login-main.css">
<!--===============================================================================================-->
</head>
<body runat="server">
	<div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100">
				<div class="login100-pic js-tilt">
					<img src="img/urp.png" alt="Universidad Ricardo Palma">
				</div>
				<form class="login100-form validate-form" runat="server">
					<span class="login100-form-title">
						Administrador
					</span>

					<div class="wrap-input100 validate-input" data-validate = "El usuario es requerido">
                        <asp:TextBox ID="txtUsuario" class="input100" type="text" name="usuario" placeholder="Usuario" runat="server" ></asp:TextBox>
						<%--<input class="input100" type="text" name="usuario" placeholder="Usuario">--%>
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-envelope" aria-hidden="true"></i>
						</span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "La contraseña es requerida">
						<asp:TextBox ID="txtContrasenia" class="input100" type="text" name="contraseña" placeholder="Contraseña" runat="server"></asp:TextBox>
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-lock" aria-hidden="true"></i>
						</span>
					</div>
					
					<div class="container-login100-form-btn">
                        <asp:Button ID="btnIniciarSesion" class="login100-form-btn" Text="Iniciar sesión" runat="server" OnClick="btnIniciarSesion_Click"  />
					</div>
                    <%--No quito esta parte porque si no se descuadra xd--%>
					<div class="text-center p-t-12">
						<span class="txt1">
							<%--Forgot--%>
						</span>

						<a class="txt2" href="#">
                            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
							
						</a>
					</div>

					<div class="text-center p-t-136">
						<a class="txt2" href="#">
						<%--	Create your Account--%>
							
						</a>
					</div>
				</form>
			</div>
		</div>
	</div>
	
	

	
<!--===============================================================================================-->	
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/tilt/tilt.jquery.min.js"></script>
	<script >
		$('.js-tilt').tilt({
			scale: 1.1
		})
	</script>
<!--===============================================================================================-->
	<script src="js/login-main.js"></script>

</body>
</html>
