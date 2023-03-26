using Generic.Service;
using GenericInference.Service;
using Inference.Service;
using Prime.Services;
using String.Services;

var primeService = new PrimeService();
var intService = new IntService();
var testService = new TextService();
var genericServiceString = new GenericService<string>();
var genericServiceInt = new GenericService<int>();
var inferenceServicePrime = new InferenceService(primeService);
var inferenceServiceInt = new InferenceService(intService);
var genericInferenceServicePrime = new GenericInferenceService<PrimeService>(primeService);
var genericInferenceServiceInt = new GenericInferenceService<PrimeService>(intService);

primeService.IsPrimeNonVirtual("1");
primeService.IsPrimeVirtual("2");

intService.IsIntNonVirtual("3");
intService.IsPrimeNonVirtual("4");
intService.IsPrimeVirtual("5");

testService.IsStringAbstract("6");
testService.IsStringNonVirtual("7");
testService.IsStringVirtual("8");

genericServiceString.IsGenericNonVirtual("9");
genericServiceString.IsGenericVirtual("10");
genericServiceInt.IsGenericNonVirtual(11);
genericServiceInt.IsGenericVirtual(12);

inferenceServicePrime.IsInferenceNonVirtual("13");
inferenceServicePrime.IsInferenceVirtual("14");

inferenceServiceInt.IsInferenceNonVirtual("15");
inferenceServiceInt.IsInferenceVirtual("16");

genericInferenceServicePrime.IsGenericInferenceNonVirtual("17");
genericInferenceServicePrime.IsGenericInferenceVirtual("18");

genericInferenceServiceInt.IsGenericInferenceNonVirtual("19");
genericInferenceServiceInt.IsGenericInferenceVirtual("20");