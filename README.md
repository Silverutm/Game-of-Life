
# Game-of-Life
El juego de la vida con formas interesantes precargadas: Osciladores, spaceships, turmites, etc.

El ejecutable se encuentra en `GameofLife/bin/Debug/GameofLife.exe`, el archivo `.sln` es para abrirlo en visual basic.


### Turmites

La carpeta Turmites (`/Input/Turmites`)

Contiene reglas de turmites, se puede encontrar un ejemplo de eso en
[https://en.wikipedia.org/wiki/Turmite](https://en.wikipedia.org/wiki/Turmite)
y en 
[https://en.wikipedia.org/wiki/File:Turmite-111180121010-12536.png](https://en.wikipedia.org/wiki/File:Turmite-111180121010-12536.png)

Donde la regla es 

> {{{1, 1, 1}, {1, 8, 0}}, {{1, 2, 1}, {0, 1, 0}}}

y queda (al convertirlo a una cadena de texto) como:  

    1 1 1 1 8 0 1 2 1 0 1 0

Como se puede ver en los txt de la carpeta `Input`.

### Game of Life
Las demas Carpetas en `Input`
Son diferentes tipos de formas para Conways, los archivos sin extension son archivos de texto que tienen la `SpaceShip` (o alguna otra forma)  en forma matricial, los primeros numeros son filas y columnas, despues vienen f filas con c elementos cada uno(ceros y unos), los archivos txt contienen la misma informacion pero legible para el hombre.

El archivo `Salida.cpp` limpia estos archivos para que pueden ser leidos por el programa, y los convierte en los mismo pero todos los numeros estan separados por espacios en un solo renglon.
