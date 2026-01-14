int c = 0;

void tambah (int a, int b)
{
    c = a + b;
    Console.WriteLine ($"{a} + {b} = {c}");
}
void kurang(int a, int b)
{
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}void kali(int a, int b)
{
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}
void bagi(int a, int b)
{
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(8,2);
tambah(9, 6);
kurang(8,3);
kurang(9, 7);
kali(2,3);
kali(2, 5);
bagi(6, 3);
bagi(6,2);
