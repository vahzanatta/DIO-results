/*
//VARIÁVEIS
Console.WriteLine("First program!");

int age = 29;
Console.WriteLine(age);
string name = "Felipe Almeida";
Console.WriteLine(name);
decimal value = 199.99m;
double valueDouble = 199.99;
float valueFloat = 199.99f;
Console.WriteLine(value);
Console.WriteLine(valueDouble);
Console.WriteLine(valueFloat);

var newAge = 34;
Console.WriteLine(newAge);
char flag = 'Y';
Console.WriteLine(flag);
bool active = false;
active = true;
Console.WriteLine(active);

const string description = "Curso CSharp";
//description = "Curso";

Console.WriteLine(description);
*/

/*
int number1 = 1;
var number2 = 2;
*/

/*
//OPERADORES ARITMÉTICOS
int sum = number1 + number2;
Console.WriteLine(sum);

int subtraction = number2 - number1;
Console.WriteLine(subtraction);

int multiplication = (number2 * number1) * 10;
Console.WriteLine(multiplication);

int division = number2 / number1;
Console.WriteLine(division);
*/

/*
//OPERADORES RELACIONAIS
bool equal = number1 == number2;
Console.WriteLine(equal);

bool biggerThan = number2 > number1;
Console.WriteLine(biggerThan);

bool lessThan = number2 < number1;
Console.WriteLine(lessThan);

bool biggerTharOrEqual = number2 >= number1;
Console.WriteLine(biggerTharOrEqual);

bool lessThanOrEqual = number2 <= number1;
Console.WriteLine(lessThanOrEqual);

bool different = number2 != number1;
Console.WriteLine(different);
*/

/*
//OPERADORES LÓGICOS
bool valid = number2 > number1 && 6 > 7;
Console.WriteLine(valid);

bool valid2 = number2 > 10 || 6 > 7;
Console.WriteLine(valid2);

bool valid3 = !(number2 > 3);
Console.WriteLine(valid3);
*/

/*
//OPERADOR TERNÁRIO
bool active = false;
string status = active == true ? "Active registration!" : "Inactive registration!";
Console.WriteLine(status);
*/

/*
//FUNÇÕES
WriteName();

void WriteName(){
    var name = FullName();
    var sum = SumValues();

    Console.WriteLine(name);
    Console.WriteLine(sum);
}

string FullName(){
    string firstName = "Vanessa";
    string lastName = "Zanatta";

    return firstName + " " + lastName;
}

int SumValues(){
    return 30 + 1;
}
*/

/*
var sum = SumValues(30, 1);
Console.WriteLine(sum);

var name = NameAndAge("Vanessa", 31);
Console.WriteLine(name);

int SumValues(int a, int b){
    return a + b;
}

string NameAndAge(string name, int age){
    return "My name is " + name + " and I'm " + age + " years old.";
}
*/

/*
//ARRAY LIST (qualquer tipo de objeto)
using System.Collections;

var arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Vanessa");
arrayList.Add(true);

Console.WriteLine(arrayList[1]); //acesso por índice

arrayList.RemoveAt(1); //remove item da lista pelo índice

arrayList.Clear(); // limpa o Array

foreach(var item in arrayList){ //acesso a lista
    Console.WriteLine(item);
}
*/

/*
//ARRAY TIPADO (necessário definir o tipo de objeto)
//var arrayTipadoNumero = new int [3] {1, 2, 3};
var arrayTipadoNumero = new int[3];

arrayTipadoNumero[0] = 2;
arrayTipadoNumero[1] = 5;
arrayTipadoNumero[2] = 10; //também substitui o item em uma lista pré-definida

//Array.Resize(ref arrayTipadoNumero, 5); //redimensiona a lista

foreach(var item in arrayTipadoNumero){
    Console.WriteLine(item);
}

var arrayTipadoString = new string[2] {"Vanessa", "Zanatta"};
foreach(var item in arrayTipadoString){
    Console.WriteLine(item);
}
*/

/*
//LISTA GENÉRICA ()

var list = new List<string>(10);
list.Add("Vanessa");
list.Add("Silva");
list.Add("Zanatta");

var list = new List<string>(10){
    "Vanessa",
    "Silva",
    "Zanatta",
};

var name = list[0];
Console.WriteLine(name);

list.RemoveAt(0); //remove o item da lista;

foreach(var item in list){
    Console.WriteLine(item)
;}
*/

/*
//DICTIONARY (recebe dois parâmetros: chave e valor; não permite repetição de chave)
var dictionary = new Dictionary<int, string>(){
    {1, "Vanessa"}, //adiciona item na lista;
};

dictionary.Add(2, "Silva"); //adiciona item na lista;

dictionary[3] = "Zanatta"; //adiciona item na lista;

var name = dictionary[3]; //entre colchetes é a key;
Console.WriteLine(name);

foreach (var item in dictionary){
    Console.WriteLine(item.Key); //mostra as keys;
    Console.WriteLine(item.Value); //mostra os valores;
}
*/

/*
//QUEUE (FIFO: first in, first out)
var queue = new Queue<string>();
queue.Enqueue("Vanessa"); //adiciona a fila;
queue.Enqueue("Zanatta");

//var name = queue.Peek();
//Console.WriteLine(name);

var nameOne = queue.Dequeue(); //desempilha da fila;
var nameTwo = queue.Dequeue();

Console.WriteLine(nameOne);
Console.WriteLine(nameTwo);

foreach (var item in queue){
    Console.WriteLine(item);
}
*/

/*
//STACK (LIFO: last in, first out)
var stack = new Stack<string>();
stack.Push("Vanessa");
stack.Push("Zanatta");

var nameOne = stack.Pop();
Console.WriteLine(nameOne);
var nameTwo = stack.Pop();
Console.WriteLine(nameTwo);

foreach (var item in stack){
    Console.WriteLine(item);
}
*/

/*
//IF/ELSE/ELSE IF
var weekdays = 0;
var workingDay = true;

if (weekdays == 0 && workingDay == true)
{
    Console.WriteLine("Today is the day to work.");
}
else if (weekdays == 0 && workingDay == false)
{
    Console.WriteLine("Today is the day to rest.");
}
else
{
    Console.WriteLine("Today is not a weekday.");
}


var weekdays = 7;

if (weekdays == 0)
{
    Console.WriteLine("Today is Sunday.");
}
else if (weekdays == 1)
{
    Console.WriteLine("Today is Monday.");
}
else if (weekdays == 2)
{
    Console.WriteLine("Today is Tuesday.");
}
else if (weekdays == 3)
{
    Console.WriteLine("Today is Wednesday.");
}
else if (weekdays == 4)
{
    Console.WriteLine("Today is Thursday.");
}
else if (weekdays == 5)
{
    Console.WriteLine("Today is Friday.");
}
else if (weekdays == 6)
{
    Console.WriteLine("Today is Saturday.");
}
else
{
    Console.WriteLine("This is not a valid entry!");
}
*/

/*
//SWITCH
var weekdays = 0;

switch (weekdays)
{
    case 0:
        Console.WriteLine("Today is Sunday.");
        break;
    case 1:
        Console.WriteLine("Today is Monday.");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday.");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday.");
        break;
    case 4:
        Console.WriteLine("Today is Thursday.");
        break;
    case 5:
        Console.WriteLine("Today is Friday.");
        break;
    case 6:
        Console.WriteLine("Today is Saturday.");
        break;
    default:
        Console.WriteLine("This is not a valid entry!");
        break;
}

var weekdays = 0;

switch (weekdays < 1)
{
    case true:
        Console.WriteLine("Today is a weekday.");
        break;
    case false:
        Console.WriteLine("This is not a valid entry!");
        break;
    default:
} //better use if/else
*/

/*
//FOR
var list = new List<string> {"Vanessa", "Student", "Csharp"};
var count = list.Count;

for (var i = 0; i < count; i++)
{
    var name = list[i];
    Console.WriteLine(name);
}
*/

/*
//FOREACH
var list = new List<string>(){"Vanessa", "Student", "Csharp"};
foreach (string item in list)
{
    Console.WriteLine(item);
}

foreach (var letra in "Vanessa")
{
    Console.WriteLine(letra);
}
*/

/*
//WHILE/DOWHILE

var i = 3;
int count = 2;

while(i < count) //valida e apenas depois executa o código;
{
    Console.WriteLine("var i = " + i);
    i++;
}

var j = 3;
do //executa o código e depois valida;
{
    Console.WriteLine("var j = " + j);
    j++;
}while (j < count);
*/

/*
//BREAK/CONTINUE

var i = 0;
int count = 5;
int limit = 2;

while(i < count)
{
    if (i < limit)
    {
        Console.WriteLine("Continuando...");
        i++;
        continue; //força a permanência no laço;
    }

    Console.WriteLine("var i = " + i);
    i++;

    if (i == limit)
    {
        Console.WriteLine("Valor de i é igual a 2.");
        break; //interrompe a execução do laço;
    }
}
*/