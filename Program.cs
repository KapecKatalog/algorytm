int[] arr = {42, 87, -15, 10};
int a = int.Parse(Console.ReadLine());

int max = arr[0], min = arr[0], count = 0;
float sum = 0, avg;
List<int> pos = new List<int>();

for(int i = 0; i < arr.Length; i++){
    if(arr[i] == a)
        pos.Add(i);
    sum += arr[i];
    count++;
    if(arr[i] > max)
        max = arr[i];
    if(arr[i] < min)
        min = arr[i];
}

avg = sum / count;

int low = 0, high = 0;

for(int i = 0; i < arr.Length; i++){
    if(arr[i] < avg)
        low += 1;
    if(arr[i] > avg)
        high += 1;
}

System.Console.Write($"Miejsca występowania {a}: ");
foreach(int x in pos) Console.Write(x);
System.Console.WriteLine("\nNajwiększa liczba: " + max);
System.Console.WriteLine("Najmniejsza liczba: " + min);
System.Console.WriteLine("Średnia: " + avg);
System.Console.WriteLine("Ilośc liczb poniżej średniej: " + low);
System.Console.WriteLine("Ilośc liczb powyżej średniej: " + high);

