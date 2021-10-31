# Lenguajes de programación. Seminario 2

## Tema 4: Dynamic en C#

## ¿Que se entiende por DLR y CLR en .NET?


## DLR:
  .NET proporciona un run-time environment, denominado Common Language Runtime(CLR), que ejecuta el código y proporciona servicios qie facilitan el proceso de desarrollo. Los compiladores y las herramientas exponen la funcionalidad del Common Langugage Runtime y le permite escribir código que se beneficie de este entorno de ejecución controlado(managed excution environment). El código que desarrolles con un compilador de lenguaje que tiene como objetivo el tiempo de ejecución se llama código administrativo(managed code). El código administrativo se beneficia de características como la integración entre lenguajes (cross-language), el manaje de excepciones entre lenguajes (cross-language exception handling), la seguridad mejorada(enhanced security), el control de versiones y el siporte de implementación, un modelo simplificado para la interacción de componentes y la depuración y perfilado de servicios. Para permitir que el tiempo de ejecución proporcione servicios al código administrado, los compiladores de lenguaje deben emitir metadatos que describan los tipos, miembros y referencias en su código. Los metadatos se almacenan con el código; los archivos ejecutables portables (Portable execute(PE)) cargados del Common Language Runtime contienen metadatos. El runtime usa los metadatos para localizar y cargar clases, diseñar instancias en memoria, resolver invocaciones a métodos, generar código nativo, reforzar la seguridad y establecer límites de contexto en tiempo de ejecución.
  
    

  DLR (Dynamic Language Runtime) es una libreria que todos lenguajes dinamicos y el compilador de C# usan para ejecutar codigo dinamico.

  El proposito del DLR es permitir que un sistema de lenguajes dinamicos se ejecute en .Net Framework y brindarles interoperatividad .Net. El DLR annade objetos dinamicos a C# y Visual Basic para admitir el comportamiento dinamico en estos lenguajes y permitir su interoperacion con lenguajes dinamicos.

  El DLR es un entorno de ejecucion que agrega un conjunto de servicios para lenguajes dinamicos al CLR (Common Language Runtime). El DLR facilita el desarrollo de lenguajes dinamicos para que se ejecuten en .Net Framework y la adicion de funciones dinamicas a los lenguajes estaticos.

  #### Ventajas principales de los DLR

  1. Simplifica la portabilidad de lenguajes dinamicos a .Net Framework
  2. Habilita funciones dinamicas en lenguajes tipados estaticamente.
  3. Proporciona beneficios futuros de DLR y .Net Framework.
  4. Permite compartir bibliotecas y objetos.


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
