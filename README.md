# cs-edu-repo-17-html-css
Модуль 27. Введение в CSS. 27.9. Проект LifeSpot (HW-03)

**Практика**

Применяем .NET Core со встроенным веб-сервером Kestrel в роли Backend-а

Используем проект [GitHub](https://github.com/SkillFactory-CSARP/LifeSpot)
 в качестве шаблона проекта. При запуске возвращается единственная
 страница `index.html` по адресу: 

http://localhost:5000/

<details><summary> чек-лист </summary>

 - Добавляем слоган с тегом H1 вместо приветствия

 - Добавляем параграф с описанием под слоганом

 - Добавляем к документу встроенный стиль: 
```
<style>
  /* Свойства стиля элемента. Подробнее о них - в модуле по CSS */
  .block {
    border: 2px solid black;
    background-color:azure;
    padding: 10px;
  }
</style>
```
Убираем текст в блок, используя тег `<div></div>`, и указываем блоку
 атрибут `class="bordered"`

 - Добавьте на сайт 3 кнопки для разных городов: Санкт-Петербург,
 Нью-Йорк, Лондон

 - Делаем кнопки ссылками (указаны в задании), чтобы они при нажатии
 открывали трансляции с соответствующих городов

 - Закомментируйте кнопки, чтобы не мешались.
 Добавьте вместо кнопок элементы `iframe` с трансляциями,
 затем удалите закомментированные кнопки

 - Пропишите общее свойство для ваших iframe-контейнеров,
 используя селектор класса (внутри тега `<style></style>`): 
```
.video-container {
  display: inline-block;
}
```
Не забудьте снабдить контейнеры соответствующим атрибутом!
 Добавьте описание под видео

 - Сделайте шапку (или заголовок) сайта.
 Там расположите название и слоган

 - Сделайте нижнюю часть сайта, в которой расположите контакты
 для обратной связи

 - Обновите стили, как предложено в тексте задания.
 Теперь сделайте боковое меню навигации по сайту,
 используя специальный тег

 - Добавьте в проект папку Static со вложенной папкой CSS для стилей.
 Добавьте маршрут в класс Endpoints.сs (см. текст задания).
 Перенесите стили во внешний файл и убедитесь, что они работают

 - С помощью комбинированного селектора измените шрифт на всей странице
 с помощью CSS. Скопируйте себе некоторые новые стили, предложенные
 в меню задания, при желании изменив на свой вкус

 - Добавьте эффекты к надписям на панели навигации, чтобы при наведении
 они подсвечивались

 - Сделайте эти объекты ссылками, ведущими на главную страницу

 - Переопределите стиль заголовка в соответствии с требованием задания.
 Затем переопределите этот селектор, используя другой, с более высоким
 приоритетом, так, чтобы работал именно он

 - Измените фон всех элементов нашей страницы кроме сайд-бара с белого
 на любой другой (используя множественный селектор)

 - Уменьшите межстрочный интервал в блоке с копирайтом на треть

 - Выровняйте футер сайта относительно верхнего контента

 - Дополнительное задание.
 Добавьте текстовое поле для поиска видео на странице
 (пусть пока оно будет нерабочим). Сделайте так, чтобы текстовое поле
 подсвечивалось, когда пользователь выбирает его для ввода

</details>
