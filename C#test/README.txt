
Для запуска программы необходимо:
•Установить SSMS(Mirosoft SQL Management Studio)

1)открыть файл "do1", нажать F5
2)открыть файл "do2", нажать F5

3)Запустить SSMS

4)Скопировать "Имя сервера"(к примеру ".\SQLEXPRESS")

5)Открыть Siberc_project\Classes\DataBaseConnaction.cs (можно даже через блокнот)

6)Найти строку:
serversql_ = "LIMAS-PC\\MSSQLSERVER01",//сервер меняем тут

7)Заменить "LIMAS-PC\\MSSQLSERVER01" на имя сервера(к примеру ".\SQLEXPRESS")

должно получиться:
serversql_ = ".\SQLEXPRESS",//сервер меняем тут

8)Запустит приложение Sibers_project
