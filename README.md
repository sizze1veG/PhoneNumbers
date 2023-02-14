<h1 align="center">Программа "Картотека абонентов"</h1>

[<img src='https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/github.svg' alt='github' height='40'>](https://github.com/sizze1veG)  [<img src='https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/instagram.svg' alt='instagram' height='40'>](https://www.instagram.com/sizze1veG/)  [<img src='https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/icloud.svg' alt='website' height='40'>](https://vk.com/sizze1veg)  

<h2>Задание</h2>
На междугородней телефонной станции картотека абонентов, содержащая сведения о телефонах и их владельцах, организована в виде линейного списка. Написать программу, которая:

- обеспечивает начальное формирование картотеки в виде линейного списка;
- производит вывод всей картотеки;
- вводит номер телефона и время разговора;
- выводит извещение на оплату телефонного разговора.

Программа должна обеспечивать диалог и контроль ошибок при вводе.

- Главное окно программы
<picture>
  <img src="https://github.com/sizze1veG/PhoneNumbers/blob/main/screenshots/Screenshot_1.png">
</picture>

Здесь представлены все кнопки, а так же полный список абонентов

- Добавление абонента

Чтобы добавить данные, нужно написать имя нового абонента и его номер телефона в соответствующие строки, 
а затем нажать кнопку «Добавить данные». Программа проверит введенные данные и добавит их в таблицу или выведет сообщение о том, 
что данные были введены неверно. Имя абонента должно состоять минимум из 4 букв. Номер должен начинаться на «7» или «8» и состоять из 11 цифр.

- Удаление абонента

Удалить данные можно, выбрав нужную строку в таблице, и нажать на кнопку «Удалить данные».

- Вывод извещения на оплату

По нажатию кнопки «Вывести извещение» можно узнать стоимость звонка. Необходимо ввести номер телефона и время разговора в минутах. 
Программа посчитает стоимость разговора и выведет сообщение на экран. Стоимость одной минуты разговора зависит от кода номера телефона, 
который можно найти в файле «Code.txt». Если код не будет найден, то стоимость одной минуты будет составлять 2 руб.
