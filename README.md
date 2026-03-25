# Angry Birds - Sistema en C#

---

## Autor
Proyecto desarrollado como práctica de POO programación orientado a objetos en C# por Celedonio, Leon Flores de 6°7

---

## Descripción

Este proyecto consiste en el desarrollo de un sistema orientado a objetos en C# basado en el universo de Angry Birds. El objetivo es modelar el comportamiento de los pájaros, los eventos que ocurren en la isla, y la interacción con los obstáculos de la isla de los cerditos.

El sistema fue diseñado aplicando conceptos de Programación Orientada a Objetos como herencia, encapsulamiento, polimorfismo y composición.

---

## Conceptos aplicados

* Clases y objetos
* Herencia
* Polimorfismo
* Encapsulamiento
* Composición y agregación
* Uso de listas (`List<T>`)
* Validaciones y excepciones

---

## Modelo del dominio

### Pájaros

Todos los pájaros heredan de una clase abstracta `Pajaro`, que define:

* Nivel de ira
* Método `ObtenerFuerza()`
* Método `Enojar()`

#### Tipos de pájaros implementados:

* **Pájaro común**: fuerza = ira * 2
* **Red**: fuerza basada en ira y cantidad de veces enojado
* **Chuck**: depende de la velocidad
* **Bomb**: tiene un tope máximo de fuerza
* **Terence**: similar a Red pero con multiplicador configurable
* **Matilda**: suma la fuerza de sus huevos

---

### Huevos

Los huevos tienen:

* Peso (validado)
* Fuerza equivalente a su peso

Son utilizados por Matilda para incrementar su fuerza.

---

### Isla Cerdito

Representa el lugar donde están los obstáculos.

Contiene una lista de `Obstaculo`, que pueden ser:

* Pared de vidrio
* Pared de madera
* Pared de piedra
* Cerditos obreros
* Cerditos con casco
* Cerditos con escudo

Cada obstáculo tiene una resistencia que debe ser superada por la fuerza de un pájaro para ser destruido.

---

### Isla Pájaro

Contiene todos los pájaros y permite:

* Obtener pájaros fuertes
* Calcular la fuerza total de la isla
* Aplicar eventos
* Atacar la isla de los cerditos

---

### Eventos

Se modelan mediante una clase abstracta `Evento`, que permite aplicar diferentes efectos sobre la isla:

* **Sesión de manejo de la ira**
* **Invasión de cerditos**
* **Fiesta sorpresa**
* **Serie de eventos**

Esto permite extender fácilmente el sistema agregando nuevos eventos.

---

## Mecánica de ataque

Cuando la isla de los pájaros ataca:

1. Se lanzan los pájaros uno por uno
2. Cada pájaro impacta contra el obstáculo más cercano
3. Si su fuerza supera la resistencia, el obstáculo se destruye
4. Si no, el obstáculo permanece

El objetivo es eliminar todos los obstáculos y recuperar los huevos.

---

## Pruebas del sistema

El sistema puede ser probado de dos formas:

### Consola

Mediante un proyecto de consola que:

* Instancia pájaros
* Aplica eventos
* Simula ataques

### Tests (opcional)

Utilizando frameworks como xUnit para validar comportamientos automáticamente.

---

## Estructura del proyecto

* **AngryBirds.Biblioteca**

  * Contiene toda la lógica del dominio
* **AngryBirds.Consola**

  * Permite ejecutar y probar el sistema

---

## Cómo ejecutar

1. Crear la solución:

```bash
dotnet new sln
```

2. Crear proyectos:

```bash
dotnet new classlib -n AngryBirds.Biblioteca
dotnet new console -n AngryBirds.Consola
```

3. Agregar referencia:

```bash
dotnet add AngryBirds.Consola reference AngryBirds.Biblioteca
```

4. Ejecutar:

```bash
dotnet run --project AngryBirds.Consola
```

---

## Extensibilidad

El sistema está preparado para crecer fácilmente:

* Agregar nuevos tipos de pájaros
* Incorporar nuevos eventos
* Crear nuevos obstáculos
* Modificar comportamientos sin romper el sistema

Esto se logra gracias al uso de herencia y polimorfismo.

---

## Conclusión

Este proyecto permite aplicar conceptos clave de programación orientada a objetos en un caso práctico, logrando un sistema modular, flexible y fácil de mantener.

---
