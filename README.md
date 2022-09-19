# ИТОГОВЫЙ ТЕСТ ПО ПЕРВОМУ БЛОКУ 

## **Задача**
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## **Алгоритм решения задачи:**
Сначала объявляется два массива: первый, с заданными элементами, и второй, длина которого равно длине первого массива. 

После этого запускается цикл, соразмерный длине массива, внутри цикла проверка условия ( Длина элемента массива <=3 ). Если условие выполняется, элемент первого массива заносится в count элемент второго массива. Переменная count создана, чтобы поочередно закидывать элементы из первого массива во второй и чтобы потом не было пробелов. После выполнения итерации в цикле вступает в силу инкремент. Цикл работает до окончания проверки всех элементов первого массива.