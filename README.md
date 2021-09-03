# ElGamal
## EA 3 - Criptografía - UNLaM
### Integrantes:
* Carbone, Emanuel
* Firpo, Ayelén
* Tamashiro, Santiago
* Vogel, Facundo

## Descripción
El programa consiste de una interfaz gráfica que le permite al usuario encriptar:
* Texto plano
* Un archivo de texto (.txt)
* Un archivo de imagen (.jpg, .png, etc.)


Para ello, el programa genera un par de claves en XML, una pública y una privada. Procede al proceso de encriptación que consiste en los siguientes pasos:
1. El archivo a encriptar se convierte en un vector de bytes.
2. El vector de bytes se particiona en vectores más pequeños de acuerdo al tamaño de bloque permitido según el tamaño de las claves, calculándose de la forma _(bits clave -1)/8_.
3. Para cada bloque, se genera un número aleatorio _K_, donde _K - 1_ debe ser coprimo con el número _P_. De no ser así, se vuelve a generar el número.
4. Se generan 2 bloques de bytes:
    - Uno resultante del cálculo del secreto compartido.
    - Otro resultante del producto entre la exponenciación modular de la clave pública y el mensaje.
5. La concatenación de ambos bloques es el bloque cifrado. Nótese que el bloque cifrado tiene el doble de tamaño que el bloque original.
6. Se repite este procedimiento hasta que no haya más bloques para cifrar.
7. Si el último bloque es menor al tamaño fijo de bloque, se debe rellenar con 0.



Para desencriptar, el programa calcula el inverso multiplicativo del bloque correspondiente al secreto compartido utilizando la clave privada del receptor. Luego, realiza el producto entre dicho bloque y el bloque cifrado mediante la clave pública del receptor, cuyo resultado es sometido a un módulo _P_. De esta forma, se recupera el bloque de bytes original.

Una vez reconstituidos todos los bloques de bytes originales, se concatenan para reformar el archivo sin encriptar. Al usuario se le mostrará por pantalla tanto el archivo original como el archivo desencriptado para que pueda corroborar que ambos son idénticos.
