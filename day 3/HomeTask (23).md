### Task 1:
Imagine you create a generic container class called `Cache`,
which can store any objects and provides caching and access to them.
You need to implement this using a static class and generics.
Requirements:
1. The `Cache<T>` class must be static so that it can be accessed without having to create an instance.
2. The `Cache<T>` class must have `Add`, `Get` and `Remove` methods to add, get and remove an object, respectively.
3. The `Cache<T>` class must use generics to support storing any type of object.
##
Представьте, что вы создаете универсальный класс-контейнер под названием `Cache`,                           
который может хранить любые объекты и обеспечивает кеширование и доступ к ним.                        
Необходимо реализовать это с помощью статического класса и обобщений.                
Требования: 
1. Класс `Cache<T>` должен быть статическим, чтобы можно было обращаться к нему без необходимости создавать экземпляр.
2. Класс `Cache<T>` должен иметь методы `Add`, `Get` и `Remove` для добавления, получения и удаления объекта соответственно.
3. Класс `Cache<T>` должен использовать обобщения, чтобы поддерживать хранение любых типов объектов.
##
Тасаввур кунед, ки шумо як синфи контейнери умумӣ бо номи `Cache` эҷод мекунед,
ки хар гуна объектхоро нигох дошта метавонад ва кэширонӣ ва дастрасиро ба онхо таъмин мекунад.
Шумо бояд инро бо истифода аз синфи статикӣ ва генерикҳо амалӣ кунед.
Талабот:
1. Синфи `Cache<T>` бояд статикӣ бошад, то онро бе эҷод кардани намунаи объект истифода барем.
2. Синфи `Cache<T>` бояд мутаносибан усулҳои `Add`, `Get` ва `Remove` барои илова кардан, гирифтан ва нест кардани объектро дошта бошад.
3. Синфи `Cache<T>` бояд барои дастгирии нигоҳдории ҳама намуди объектҳо, генерикҳоро истифода барад.
---
### Task 2:
🔍 Let's look at a static class for working with geometric shapes:

1. Circle:
    - Method `CalcCircleArea(double radius)`: Takes the radius of a circle and calculates its area
      according to the formula `S=πr²`, where `π` is a mathematical constant and `r` is the radius.
    - Method `CalcCirclePerimeter(double radius)`: Takes the radius of a circle and calculates its perimeter using the formula `P=2πr`.

2. Rectangle:
    - Method `CalcRectangleArea(double length, double width)`: Takes the length and width of the rectangle and
       calculates its area using the formula `S = l * w`, where `l` is length, `w` is width.
    - Method `CalcRectanglePerimeter(double length, double width)`:
       Takes the length and width of a rectangle and calculates its perimeter using the formula `P = 2(l + w)`.

3. Triangle:
    - Method `CalcTriangleArea(base, height)`: Takes the base and height of the triangle and
       calculates its area using the formula `S = 0.5 * b * h`, where `b` is the base, `h` is the height.
    - Method `CalcTrianglePerimeter(double side1, double side2, double side3)`: Takes the lengths of the three sides of a triangle and calculates its perimeter using the formula `P = a + b + c`, where `a`, `b`, `c` are the sides of the triangle.

In this static class, you can call these methods by passing the appropriate parameters,
and get the area and perimeter of the corresponding geometric figure without having to create an instance of the class.
##
🔍 Давайте  рассмотрим статический класс для работы с геометрическими фигурами:
1. Круг:
   - Метод `CalcCircleArea(double radius)`: Принимает радиус круга и вычисляет его площадь по формуле `S=πr²`, где `π` - математическая константа, а `r` - радиус.                                  
   - Метод `CalcCirclePerimeter(double radius)`: Принимает радиус круга и вычисляет его периметр по формуле `P=2πr`.

2. Прямоугольник:
   - Метод `CalcRectangleArea(double length, double width)`: Принимает длину и ширину прямоугольника и вычисляет его площадь по формуле `S = l * w`, где `l` - длина, `w` - ширина.                                 
   - Метод `CalcRectanglePerimeter(double length, double width)`: Принимает длину и ширину прямоугольника и вычисляет его периметр по формуле `P = 2(l + w)`.
3. Треугольник:
   - Метод `CalcTriangleArea(double base, double height)`: Принимает основание и высоту треугольника и вычисляет его площадь по формуле `S = 0.5 * b * h`, где `b` - основание, `h` - высота.                      
   - Метод `CalcTrianglePerimeter(double side1, double side2, double side3)`: Принимает длины трех сторон треугольника и вычисляет его периметр по формуле `P = a + b + c`, где `a`, `b`, `c` - стороны треугольника.
В этом статическом классе вы можете вызывать эти методы, передавая соответствующие параметры,
и получать площадь и периметр соответствующей геометрической фигуры без необходимости создавать экземпляр класса. 
##
🔍 Биёед синфи статикиро барои кор бо шаклҳои геометрӣ дида бароем:
1. Доира:
    - Усули `CalcCircleArea(double radius)`: Радиуси давраро мегирад ва масоҳати онро бо формулаи `S=πr²` ҳисоб мекунад, ки дар он `π` доимии математикӣ ва `r` радиус аст.
    - Усули `CalcCirclePerimeter(double radius)`: Радиуси давраро мегирад ва периметри онро бо формулаи `P=2πr` ҳисоб мекунад.

2. Росткунҷа:
    - Усули `CalcRectangleArea(double length, double width)`: дарозӣ ва паҳнои росткунҷаро мегирад ва масоҳати онро бо формулаи `S = l * w` ҳисоб мекунад, ки дар он `l` дарозӣ, `w` паҳн аст .
    - Усули `CalcRectanglePerimeter(double length, double width)`: дарозӣ ва паҳнои росткунҷаро мегирад ва периметри онро бо формулаи `P = 2(l + w)` ҳисоб мекунад.
3. Секунҷа росткунҷа:
    - Усули `CalcTriangleArea(double base, double height)`: Асос ва баландии секунҷаро гирифта, масоҳати онро бо формулаи `S = 0,5 * b * h` ҳисоб мекунад, ки дар он `b` асос аст, `h` аст баландӣ.
    - Усули `CalcTrianglePerimeter(double side1, double side2, double side3)`: Дарозии се тарафи секунҷаро мегирад ва периметри онро бо формулаи `P = a + b + c` ҳисоб мекунад, ки дар он `a`, `b `, `c` - тарафҳои секунҷа.
Дар ин синфи статикӣ, шумо метавонед ин усулҳоро тавассути гузариши параметрҳои мувофиқ даъват кунед,
ва бидуни эҷоди як мисоли синф, майдон ва периметри фигураи геометрии мувофиқро ба даст оред.
---
### Task 3:
Creating a static class to work with mathematical functions and defining static methods to perform the operations involves the following steps:

1. Create a static class: Create a class with the `static` modifier so that it can only contain
    static members and did not require creating an instance of the class to call methods.

3. Methods for calculating operations:
    - Sum: Define a static method `Add(a, b)` that takes two numbers `a` and `b` and returns their sum.
    - Difference: Define a static method `Subtract(a, b)` that takes two numbers `a` and `b` and returns their difference.
    - Product: Define a static method `Multiply(a, b)` that takes two numbers `a` and `b` and returns their product.
    - Division: Define a static method `Divide(a, b)` that takes two numbers `a` and `b` and returns their quotient.

By calling these static methods from your static class you will be able to calculate the sum, difference,
product or division of two numbers without having to create an instance of the class.
##
Создание статического класса для работы с математическими функциями и определение статических методов для выполнения операций включает следующие шаги:
1. Создание статического класса: Создайте класс с модификатором `static`, чтобы он мог содержать только статические члены и не требовал создания экземпляра класса для вызова методов.
3. Методы для вычисления операций:
   - Сумма: Определите статический метод `Add(a, b)`, который принимает два числа `a` и `b` и возвращает их сумму.
   - Разность: Определите статический метод `Subtract(a, b)`, который принимает два числа `a` и `b` и возвращает их разность.
   - Произведение: Определите статический метод `Multiply(a, b)`, который принимает два числа `a` и `b` и возвращает их произведение.
   - Деление: Определите статический метод `Divide(a, b)`, который принимает два числа `a` и `b` и возвращает их частное.
Вызывая эти статические методы из вашего статического класса, вы сможете вычислить сумму, разность, произведение или деление двух чисел без необходимости создания экземпляра класса.                              
##
Эҷоди синфи статикӣ барои кор бо функсияҳои математикӣ ва муайян кардани усулҳои статикӣ барои иҷрои амалҳои зерин:
1. Синфи статикӣ эҷод кунед: Синфро бо модификатори `static` созед, то он танҳо аъзои статикиро дар бар гирад ва барои даъват кардани усулҳо эҷоди синфро талаб накунад.
3. Усулҳои ҳисобкунии амалиётҳо:
    - Ҷамъ: Усули статикии `Add(a, b)`-ро муайян кунед, ки ду адади `a` ва `b`-ро мегирад ва суммаи онҳоро бармегардонад.
    - Фарқ: Усули статикии `Subtract(a, b)` -ро муайян кунед, ки ду рақами `a` ва `b`-ро мегирад ва фарқи онҳоро бармегардонад.
    - Зарб: Усули статикии `Multiply(a, b)` -ро муайян кунед, ки ду рақами `a` ва `b`-ро мегирад ва ҳосили зарби онҳоро бармегардонад.
    - Тақсим: Усули статикии `Divide(a, b)` -ро муайян кунед, ки ду рақами `a` ва `b`-ро мегирад ва ҳосили тақсими онҳоро бармегардонад.
Бо даъват кардани ин усулҳои статикӣ аз синфи статикии худ, шумо метавонед ҷамъ, фарқ, зарб ё тақсими ду ададро бидуни эҷоди як мисоли синф ҳисоб кунед.


