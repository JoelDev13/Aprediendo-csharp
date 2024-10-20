# Tipos de Datos en C#

## Tipos de datos comunes:

- **int**: enteros sin decimales.
- **long**: enteros m�s grandes que un `int`.
- **float**: n�meros decimales con menos precisi�n (requiere la 'F'). Si se preguntan por qu� lleva la 'F', aqu� les dejo este art�culo que lo explica: [�Por qu� usar la 'F' en float?](https://learn.microsoft.com/es-es/cpp/c-language/type-float?view=msvc-170).
- **double**: decimales de precisi�n media (no requiere nada al final).
- **decimal**: para c�lculos financieros, con alta precisi�n (requiere la 'M'). Si se preguntan por qu� lleva la 'M', aqu� les dejo este art�culo que lo explica: [�Por qu� usar la 'M' en decimal?](https://www.reddit.com/r/learncsharp/comments/lrh9by/why_is_m_necessary_for_decimals/?tl=es-es).
- **string**: para cadenas de texto.
- **char**: para un solo car�cter.
- **bool**: para valores `true` o `false`.
- **int?**: para permitir que un entero pueda ser `null`.

## Conversi�n de tipos

- **Conversi�n impl�cita**: ocurre autom�ticamente cuando el valor que se quiere convertir cabe perfectamente en el nuevo tipo. Por ejemplo, de `int` a `long` no necesitas hacer nada.
- **Conversi�n expl�cita (casting)**: debes hacerlo manualmente cuando puede haber p�rdida de datos, como convertir de `double` a `int`. En este caso, los decimales se pierden.
- **M�todos de conversi�n**: C# tiene m�todos como `Convert.ToInt32`, `ToString`, `Convert.ToDouble` que te permiten convertir valores entre tipos.

Aqu� les dejo documentos que hablan m�s detalladamente del tema y de algunos tipos de datos que no se mencionan en este proyecto:
- [Tipos de datos en C#](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/built-in-types#floating-point-numbers)
- [Conversi�n de tipos en C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)
