**FECHA DE ENTREGA 18/01/2021**


**Requisitos:**
- Unity 2020.x.
- Visual Studio.

**Objetivos:**
1. Crear los siguientes sistemas e implementar el principio de responsabilidad única: 
* a.  Sistema de movimiento del personaje principal.
* b.  Sistema de movimiento de los enemigos.
* c.  Sistema de generación de enemigos.
* d.  Sistema de destrucción de objetos al salir de la pantalla.
2. Estructurar y comentar el código correctamente.
3. Compilar el proyecto de Unity para Windows.


**Procedimientos:**
1. Crear un sistema de movimiento horizontal que utilice eventos de entrada de teclado y aplicarlo al prefab “Player”. Mientras el objeto esté en movimiento debe activarse el objeto hijo “Engine”.
2. Crear un sistema de movimiento vertical de forma continuada y aplicarlo a los prefabs “Enemy1” y “Enemy2”. Mientras el objeto esté en movimiento debe activarse el objeto hijo “Engine”.
3. Crear un sistema de destrucción de objetos que ejecute su lógica al colisionar. Aplicar este sistema a los prefabs “Enemy1” y “Enemy2” para que se destruyan al tocar el collider de la parte inferior de la pantalla.
4. Estructurar y comentar el código utilizando las regiones adecuadas y comentarios.
5. El proyecto se debe compilar para ser ejecutado en Windows. La compilación del proyecto se debe guardar en una carpeta llamada "build" en la raíz del proyecto de Unity.
