# Lenguajes de programación. Seminario 2

## Tema 4: Dynamic en C#

## ¿Que se entiende por DLR y CLR en .NET?

##### DLR (Dynamic Language Runtime)
  DLR (Dynamic Language Runtime) es una libreria que todos lenguajes dinamicos y el compilador de C# usan para ejecutar codigo dinamico.

  El proposito del DLR es permitir que un sistema de lenguajes dinamicos se ejecute en .Net Framework y brindarles interoperatividad .Net. El DLR añade objetos dinamicos a C# y Visual Basic para admitir el comportamiento dinamico en estos lenguajes y permitir su interoperacion con lenguajes dinamicos.

  El DLR es un entorno de ejecución que agrega un conjunto de servicios para lenguajes dinamicos al CLR (Common Language Runtime). El DLR facilita el desarrollo de lenguajes dinamicos para que se ejecuten en .Net Framework y la adicion de funciones dinamicas a los lenguajes estaticos.

##### CLR (Common Language Runtime)
  El CLR es un entorno de tiempo de ejecución que proporciona .Net que corre el codigo y provee servicios que hacen el proceso de desarrollo mas facil. El siguiente diagrama muestra el modelos de ejecución del CLR. 

  ![The CLR Execution Model](./imgs/img3.png)

  CLR facilita el diseño de componentes y aplicaciones cuyos objetos interactuan entre idiomas. Los objetos escritos en diferentes idiomas pueden comunicarse entre si y sus comportamientos pueden integrarse estrechamente. Por ejemplo, puede definir una clase y luego usar un lenguaje diferente para derivar una clase de su clase original o llamar a un metodo en la clase original. Tambien puede pasar una instancia de una clase a un metodo de una clase escrito en un idioma diferente. Esta integracion entre lenguajes es posible porque los compiladores de lenguajes y las herramientas que tienen como objetivo el tiempo de ejecución utilizan un sistema de tipo comun definido por el tiempo de ejecución para definir nuevos tipos, asi como para crear, usar, persistir y vincularse a tipos.

#### Ventajas principales del DLR

  1. Simplifica la portabilidad de lenguajes dinamicos a .Net Framework
  2. Habilita funciones dinamicas en lenguajes tipados estaticamente.
  3. Proporciona beneficios futuros de DLR y .Net Framework.
  4. Permite compartir bibliotecas y objetos.

## ¿Están al mismo nivel en la arquitectura de .Net ?

CLR es solo otra biblioteca. No esta al mismo nivel que el CLR, no se ocupa de la compilacion JIT, la clasificacion de API nativas, la recoleccion de basura, etc. Pero se basa en gran parte del trabajo en .Net 2.0 y 3.5, en particular los tipos *DynamicMethod* y *Expression*. La API del arbol de expresion se ha ampliado en .Net4 para permitir que el DLR tambien exprese mas conceptos. La siguiente figura muestra un diagrama.

![How the components of .Net4 fit together](.img/../imgs/img2.png)

DLR se basa en CLR y ofrece servicios para lenguajes dinámicos: tipos dinamicos, distribución de metodos dinámicos, generacion de codigo, etc. La idea es hacer que esas sean uniformes y compartilas entre lenguajes dinamicos para que funcionen de manera predecible y similar, la igual que como sucede con CLR con otros lenguajes.
De cierta manera son comparables estos conceptos, un lenguaje en .Net usa CLR, un lenguaje dinamico deberia usar DLR, pero tambien usara CLR. Son conjuntos basicos de funcionalidades que los diseñadores consideraron buenos cuando son comunes en todos los lenguajes. IronPython e IronRuby se implementaron sobre DLR, al igual que la funcion dinámica de C# 4.

## 6. ¿Qué representan call site , receiver y binder ?

![Lifecycle of a dynamic expression](.img/../imgs/img1.png)
<!-- <img src="./imgs/img1.png" style="zoom: 67%;" /> -->
 
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
