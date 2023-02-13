# Control-Task

**Контрольная работа после окончания первой четверти**

### Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Решение
Данную задачу предлагается решить с помощью циклов и условий.
В начале работы программы предлагается ввести в консоли количество элементов массива и каждый из элементов поочерёдно. Одновременно этому реализуем процесс заполнения исходного массива.
Выводим исходный массив в консоль.

Затем, для того чтобы определить размер нового массива, организуем цикл, на каждой итерации которого проверяем каждый элемент исходного массива на количество символов. Если количество символов элемента меньше 4, то увеличиваем счётчик размера нового массива на 1.
Затем объявляем новый массив размерностью, которую определили в предыдущем цикле, он и будет результирующим.

В следующем цикле проверяем каждый элемент исходного массива на количество символов, и если это количество меньше 4, то записываем его в результирующий массив и увеличиваем индекс результирующего массива на 1.
Выводим результирующий массив в консоль.

Работа программы завершена.
