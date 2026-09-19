# OOP Principles Demo

Detta projekt är skapat för att demonstrera de fyra grundläggande OOP-principerna i C#.

## OOP-principer

### 1. Encapsulation

Branch: `encapsulation`

Jag använde privata fält och publika metoder för att skydda och kontrollera data i `BankAccount`.

Exempel:

* `private balance`
* `Deposit()`
* `Withdraw()`

### 2. Inheritance

Branch: `inheritance`

Jag skapade klassen `SavingsAccount` som ärver från `BankAccount`.

```csharp
public class SavingsAccount : BankAccount
```

### 3. Polymorphism

Branch: `polymorphism`

Jag använde `virtual` och `override` för att låta olika klasser ha olika beteenden för samma metod.

Exempel:

* `virtual ShowAccountType()`
* `override ShowAccountType()`

### 4. Abstraction

Branch: `abstraction`

Jag skapade en abstrakt klass `Account` som fungerar som en gemensam grund för olika kontotyper.

Exempel:

* `abstract class Account`
* `abstract ShowAccountInfo()`

## GitHub och Pull Requests

Varje OOP-princip implementerades på en egen branch och skickades sedan till `main` genom en Pull Request.

* `encapsulation`
* `inheritance`
* `polymorphism`
* `abstraction`

## Teknik

* C#
* .NET
* Visual Studio
* Git
* GitHub
