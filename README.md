# Minimalist3D
## Introducción
El propósito de este proyecto es aplicar y reforzar conocimientos como la gestión de componentes o la persistencia de datos en Unity (6.2). El ejercicio ha sido desarrollado en base al primer enunciado generado por ChatGPT ([link](https://chatgpt.com/share/698b4c1f-1c40-8011-9d7f-a3e96d2a22f2) a la conversación) bajo ciertas modificaciones. El resultado está explicado en el siguiente apartado.
## Ejercicio
### Controles y funcionamiento
El jugador mueve la cámara con el ratón controlando un cubo puntero que sirve de guía para colocar otros cubos (click izquierdo). Estos cubos se pueden poner en todo el espacio: en el aire, en el suelo, más lejos o más cerca (con la rueda del ratón).  
Mediante su color, el cubo puntero indica si es posible situar un cubo en la posición actual: verde si no hay problema, rojo si está en contacto con otro cubo, impidiendo ser colocado. Esto evita superposiciones.  
A medida que se añaden cubos a la escena sus posiciones se van almacenando en una lista. Cuando se cierra el programa esta lista se traduce y se guarda en un archivo de tipo json. Al volver a iniciar el juego se lee el archivo y automáticamente se colocan cubos en las posiciones guardadas.  
### A tener en cuenta
Para que el programa funcione es necesario asignar en el inspector de Unity:  
GameObject | Component | A asignar |
:---: | :---: | :---: |
Initializer | Data_Manager | /Prefabs/Cube |
Pointer_Cube | Cube_Instantiator | /Prefabs/Cube |  

¡Gracias por leer!
