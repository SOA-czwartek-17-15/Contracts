Contracts
=========

##Opis repozytorium

Do tego repozytorium każdy musi wrzucić kontrakty pełnionej przez swój projekt usługi i wprowadzanych przez nią typów danych (jeśli takie występują).

Każdy dwuosobowy zespół powinien zcommitować do tego repozytorium, do folderu */Contracts/Contracts/* jeden plik .cs o nazwie zgodnej z nazwą interfejsu, który tworzy. W pliku tym typowo będzie jeden 'public interface' o nazwie INazwaWaszegoInterfejsu zawierający deklaracje metod udostępnianych przez ten interfejs. Oprócz tego przypadku w większości z Was będzie tam również jedna publiczna klasa, opisująca typ danych wprowadzany przez waszą część projektu - np. dla IAccountRepository może być do Accout, a dla IDepositRepository: Deposit. Być może u niektórych wprowadzanych typów danych jest więcej, choć nie przychodzi mi w tej chwili do głowy taki projekt.

Jeśli wprowadzacie w waszym typie danych (a więc i metodach) jakiś unikalny identyfikator (jest to potrzebne chyba przy każdym typie danych), to powinniście skorzystać z .NETowego Guida.
Wydaje mi się, że ten artykuł o nim mówi: http://msdn.microsoft.com/en-us/library/system.guid.aspx

Wszystkie klasy i interfejsy powinny się znaleźc wewnątrz przestrzeni nazw "Contracts".

UWAGA: Polecam zapoznać się z plikaim *wzor1.cs* i *wzor2.cs*, które pokazują, jak ma wyglądać treść plików tu wrzucanych. Oprócz tego w pliku *wzor-implementacja.cs* znajduje się skrót tego, co ma znaleźć się w metodzie main każdej usługi.

##Osoby i ich projekty

Abyście wiedzieli, kogo o co dręczyć:

Konrad Seweryn - sevikon - IServiceRepository
Mateusz Ścirka - mateuszs - IServiceRepository

Magdalena Witkowska - magdzia - IAccountRepository
Małgorzata Maciurzyńska - malgmaci - IAccountRepository

Mateusz Kotlarz - rampler - ICanExternalTransferMoney
Kacper Półchłopek - jelcz - ICanExternalTransferMoney

Bartłomiej Hebda - bartQH - IClientRepository
Tomasz Bąba - Munez3 - IClientRepository

Piotr Mitana - the-Mitu - ICanTransferMoney
Tomasz Idziak - mastablasta1 - ICanTransferMoney

Michał Kurzeja - michalkurzeja - IAuditorService
Tomasz Kalinowski - kalinowskitomasz - IAuditorService

Michał Urbanek - kremuwa - IDepositRepository
Michał Gajda - Altertwin - IDepositRepository

Wojciech Harzowski - harzo - IClientService
Krzysztof Gaszyński - krisu-pl - IClientService
