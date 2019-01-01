
print("-----------Generador de consultas----------")
print("1. Insertar")
print("0. Salir")
print("Ingresa una opción: ", end="")
opcion = input()

print("------Elige una tabla--------")
print("1. Empleado")
print("Ingresa una opción: ", end="")
tabla = input()

if tabla == "1":
    if opcion == "1":
        print("nombres")
        nombres = input()
        print("apellidoPaterno")
        apellidoPaterno = input()
        print("apellidoMaterno")
        apellidoMaterno = input()
        print("telefono")
        telefono = input()
        print("celular")
        celular = input()
        print("ci")
        ci = input()
        print("direccion")
        direccion = input()
        print("usuario")
        usuario = input()
        print("contraseña")
        contraseña = input()

        print("INSERT INTO Empleado(nombres,apellidoPaterno,apellidoMaterno,telefono,celular,ci,direccion,usuario,contraseña VALUES(" + nombres + "," + apellidoPaterno + "," + apellidoMaterno + "," + telefono + "," + celular + "," + ci + "," + direccion + "," + usuario + "," + contraseña + ")")

        