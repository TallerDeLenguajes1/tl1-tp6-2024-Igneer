## ¿String es una tipo valor o un tipo por referencia?
Hay dos clases de tipos en C#: tipos de referencia y tipos de valor. Las variables de tipos de referencia almacenan referencias en sus datos (Objetos), mientras que las variables de tipos de valor contienen directamente los datos.
Por lo tanto, respondiendo a la pregunta si string es una tipo valor o un tipo por referencia, podemos decir que es de tipo por referencia ya que esta si la pasaramos como argumento de la funcion, se modificara el valor de ésta.
## ¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape se utilizan para representar caracteres esoeciales dentro de cadenas. Y las que tiene el tipo string son las siguientes:
- \\ Representa un carácter de barra invertida
- \" Representa una comilla doble
- \' Representa una comilla simple
- \n Representa un salto de linea
- \t Representa un tabulador horizontal
- \r Representa un retorno de carro (retorno al inicio de línea)
- \b Representa un retroceso (borrado de un carácter)
- \f Representa un avance de página (salto de página)
- \a Representa un carácter de alerta (campana)
- \v Representa un un tabulador vertical
## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
En C#, los caracteres @ y $ tienen significados especiales cuando se utilizan antes de una cadena de texto:
- *@ (Verbatim Identifier Character)*: Cuando precedes una cadena con @, se trata como una cadena literal sin interpretar secuencias de escape. Esto significa que puedes incluir caracteres especiales (como barras invertidas) sin escaparlos. Por ejemplo:
      _string rutaArchivo = @"C:\Directorio\Archivo.txt"_
- *$ (Interpolated String Character)*: El símbolo $ se utiliza para crear cadenas interpoladas. En una cadena interpolada, puedes incluir expresiones dentro de llaves {} que se evalúan y se insertan en la cadena. Por ejemplo: 
      _int edad = 30_;
      _string mensaje = $"Mi edad es {edad} años."_;
