# Juegos2D Sprites
 
## 1. Agregar el atlas de sprites del personaje a la escena. Configurar el sprite como múltiple y subdividirlo para tener acceso a los sprites para generar las animaciones. Agregar una de las imágenes a la escena.

Creamos un proyecto de Unity en 2D

![proyecto2D](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/1.%20crear%20proyecto.PNG)

Seleccionamos el atlas de sprites y desde el inspector cambiamos la varialble **sprite Mode** de *Single* a *Multiple*. Una vez hecho esto separaremos los distintos sprites que se encuentran dentro del atlas. Para ello tendremos que pulsar el botón de **Sprite Editor**

![Sprite Editor](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/2.%20sprite%20editor.png)

Una vez dentro, seleccionamos la pestaña de Sprite Editor y en el *type*, seleccionamos **Grid By Cell Count** y ponemos el numero de columnas y de filas del atlas.

![Slice](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/3.%20separaci%C3%B3n%20sprites.png)

Una vez separados los sprites, podemos añadir uno a la escena y ver el resultado

![sprite1](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/4.%20personaje%20a%20escena.PNG)

## 2. Creamos un objeto 2D, arrastrando un conjunto de imágenes que selecciones al objeto añadiremos una animación. Agregar al personaje la animación “Walk Down”.

Para hacer esto, debemos seleccionar el conjunto de sprites que queremos para hacer la animacion de *"walk down"* y las pondremos en la escena. Esto creará una GameObject con el componente **Animator** y una animación.

![seleccion](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/5.%20seleccion%20de%20imagenes%20para%20animaci%C3%B3n.PNG)

![animacion](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/6.%20Animator.PNG)

![gifanimado](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/7.%20Ejecucion%20walkDown.gif)

## 3. Crear los scripts para controlar el movimiento para el personaje. Añadir los scripts necesarios para moverlo por la pantalla. En este caso sólo tendremos que mover las coordenadas (X, Y). 

Creamos el script para el movimiento y se lo añadimos al personaje

[Script movimiento](https://github.com/Alu0101030562/Juegos2D-Sprites/blob/main/Assets/Scripts/PlayerController.cs)

![Animacion direccion](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/9.%20Animacion%20caminar%20horizontal.PNG)

![gif animado movimiento](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/8.%20Ejecucion%20movimiento.gif)


## 4. Además necesitamos que el sprite se oriente hacia donde camina, podemos hacerlo usando la propiedad Flip en el eje X en función de si se está moviendo hacia la izquierda (movimiento negativo) o hacia la derecha (movimiento positivo). 

Hacemos el script para que mire en la direccion a la que camina, eligiendo las animaciones necesarias para poder visualizarlo.

[Script orientacion](https://github.com/Alu0101030562/Juegos2D-Sprites/blob/main/Assets/Scripts/PlayerControllerOrientation.cs)

![Gif orientacion](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/10.%20Ejecucion%20movimiento%20orientacion.gif)

## 5. Crear las animaciones del personaje: Para cada animación que queramos agregar a un objeto seleccionamos la colección de sprites que forman la animación y la arrastramos hasta él. Agregaremos todas las animaciones al personaje. El objeto Animator Controller las gestiona en la ejecución.

Creamos la animación para caminar hacia arriba y usamos la que teniamos anteriormente de caminar hacia abajo (walk down). También crearemos dos variables desde la ventana de **Animator**

1. *isWalking*, de tipo bool y que nos indicará si el personaje está moviéndose.
2. *verticalMovement*, de tipo float. En caso de que su valor sea mayor que 0, activaremos la animación de mirar arriba. En el caso de que sea menor que 0, se activará la de mirar abajo.

![animator](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/11.%20Animator%20final.PNG)

Ajustamos las condiciones de las transiciones y hacemos el script que ira dentro del personaje para hacer la animación de movimiento.

[Script final](https://github.com/Alu0101030562/Juegos2D-Sprites/blob/main/Assets/Scripts/PlayerControllerOrientationFinal.cs)

![gif final](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Sprites2D/12.%20Ejecuci%C3%B3n%20final.gif)
