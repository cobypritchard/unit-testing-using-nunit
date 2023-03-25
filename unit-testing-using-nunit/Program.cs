using Prime.Services;
using String.Services;

var primeService = new PrimeService();
var intService = new IntService();
var testService = new TextService();

primeService.IsPrimeNonVirtual("1");
primeService.IsPrimeVirtual("2");

intService.IsIntNonVirtual("3");
intService.IsPrimeNonVirtual("4");
intService.IsPrimeVirtual("5");

testService.IsStringAbstract("6");
testService.IsStringNonVirtual("7");
testService.IsStringVirtual("8");