# Lenguajes de programación. Seminario 2

## Tema 4: Dynamic en C #

## ¿Que se entiende por DLR y CLR en .NET?
  DLR (Dynamic Language Runtime) es una libreria que todos lenguajes dinamicos y el compilador de C# usan para ejecutar codigo dinamico.

  El proposito del DLR es permitir que un sistema de lenguajes dinamicos se ejecute en .Net Framework y brindarles interoperatividad .Net. El DLR annade objetos dinamicos a C# y Visual Basic para admitir el comportamiento dinamico en estos lenguajes y permitir su interoperacion con lenguajes dinamicos.



## 6. ¿Qué representan call site , receiver y binder ?

<img src="./imgs/img1.png" style="zoom: 67%;" />
 
Call site:
Es una especie de átomo del DLR, el más pequeño
fragmento de código que se puede considerar como una sola unidad ejecutable.Una expresión puede
contienen muchos call sites, pero el comportamiento se construye de forma natural, evaluando un **call
site** a la vez. Durante el resto de la discusión, solo consideraremos un único sitio de llamada.
Será útil tener un pequeño ejemplo de un sitio de llamadas al que hacer referencia, así que aquí hay una
Por ejemplo, donde d es, por supuesto, una variable de tipo dinámico:
```
d.Foo (10);
```

El call site se representa en código como **System.Runtime.CompilerServices.Call-Site<T>**.




### Integrantes

- Javier E. Domínguez Hernández C-312
- David Orlando De Quesada Oliva C-311
- Daniel de la Cruz Prieto C-311
