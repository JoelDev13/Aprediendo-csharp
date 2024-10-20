# Tipos de Datos en C#

## Tipos de datos comunes:

- **int**: enteros sin decimales.
- **long**: enteros más grandes que un `int`.
- **float**: números decimales con menos precisión (requiere la 'F'). Si se preguntan por qué lleva la 'F', aquí les dejo este artículo que lo explica: [¿Por qué usar la 'F' en float?](https://learn.microsoft.com/es-es/cpp/c-language/type-float?view=msvc-170).
- **double**: decimales de precisión media (no requiere nada al final).
- **decimal**: para cálculos financieros, con alta precisión (requiere la 'M'). Si se preguntan por qué lleva la 'M', aquí les dejo este artículo que lo explica: [¿Por qué usar la 'M' en decimal?](https://www.reddit.com/r/learncsharp/comments/lrh9by/why_is_m_necessary_for_decimals/?tl=es-es).
- **string**: para cadenas de texto.
- **char**: para un solo carácter.
- **bool**: para valores `true` o `false`.
- **int?**: para permitir que un entero pueda ser `null`.

## Conversión de tipos

- **Conversión implícita**: ocurre automáticamente cuando el valor que se quiere convertir cabe perfectamente en el nuevo tipo. Por ejemplo, de `int` a `long` no necesitas hacer nada.
- **Conversión explícita (casting)**: debes hacerlo manualmente cuando puede haber pérdida de datos, como convertir de `double` a `int`. En este caso, los decimales se pierden.
- **Métodos de conversión**: C# tiene métodos como `Convert.ToInt32`, `ToString`, `Convert.ToDouble` que te permiten convertir valores entre tipos.

Aquí les dejo documentos que hablan más detalladamente del tema y de algunos tipos de datos que no se mencionan en este proyecto:
- [Tipos de datos en C#](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/built-in-types#floating-point-numbers)
- [Conversión de tipos en C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)
