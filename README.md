Contracts
=========

Do tego repozytorium każdy musi wrzucić kontrakty pełnionej przez swój projekt usługi i wprowadzanych przez nią typów danych (jeśli takie występują).

Każdy dwuosobowy zespół powinien zcommitować do tego repozytorium, do folderu */Contracts/Contracts/* jeden plik .cs o nazwie zgodnej z nazwą interfejsu, który tworzy. W pliku tym typowo będzie jeden 'public interface' o nazwie INazwaWaszegoInterfejsu zawierający deklaracje metod udostępnianych przez ten interfejs. Oprócz tego przypadku w większości z Was będzie tam również jedna publiczna klasa, opisująca typ danych wprowadzany przez waszą część projektu - np. dla IAccountRepository może być do Accout, a dla IDepositRepository: Deposit. Być może u niektórych wprowadzanych typów danych jest więcej, choć nie przychodzi mi w tej chwili do głowy taki projekt.

Jeśli wprowadzacie w waszym typie danych (a więc i metodach) jakiś unikalny identyfikator (jest to potrzebne chyba przy każdym typie danych), to powinniście skorzystać z .NETowego Guida.
Wydaje mi się, że ten artykuł o nim mówi: http://msdn.microsoft.com/en-us/library/system.guid.aspx

Wszystkie klasy i interfejsy powinny się znaleźc wewnątrz przestrzeni nazw "Contracts".

UWAGA: Polecam zapoznać się z plikaim *wzor1.cs* i *wzor2.cs*, które pokazują, jak ma wyglądać treść plików tu wrzucanych. Oprócz tego w pliku wzor-implementacja.cs znajduje się skrót tego, co ma znaleźć się w metodzie main każdej usługi.
